--[[
Copyright 2017 YANG Huan (sy.yanghuan@gmail.com).

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

  http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
--]]

local System = System
local throw = System.throw
local try = System.try
local trunc = System.trunc
local post = System.post
local addTimer = System.addTimer
local removeTimer = System.removeTimer
local Exception = System.Exception
local NotImplementedException = System.NotImplementedException
local ArgumentOutOfRangeException = System.ArgumentOutOfRangeException

local type = type
local table = table
local tinsert = table.insert
local tremove = table.remove
local setmetatable = setmetatable
local assert = assert
local ipairs = ipairs
local coroutine = coroutine
local ccreate = coroutine.create
local cresume = coroutine.resume
local cyield = coroutine.yield

local TaskCanceledException = System.define("System.TaskCanceledException", {
  __tostring = Exception.ToString,
  __inherits__ = { Exception },

  __ctor__ = function(this, task)
    this.task = task  
    Exception.__ctor__(this, "A task was canceled.")
  end,

  getTask = function(this) 
    return this.task
  end,
})

local TaskStatusCreated = 0
local TaskStatusWaitingForActivation = 1
local TaskStatusWaitingToRun = 2
local TaskStatusRunning = 3
local TaskStatusWaitingForChildrenToComplete = 4
local TaskStatusRanToCompletion = 5
local TaskStatusCanceled = 6
local TaskStatusFaulted = 7

System.defEnum("System.TaskStatus", {
  Created = TaskStatusCreated,
  WaitingForActivation = TaskStatusWaitingForActivation,
  WaitingToRun = TaskStatusWaitingToRun,
  Running = TaskStatusRunning,
  WaitingForChildrenToComplete = TaskStatusWaitingForChildrenToComplete,
  RanToCompletion = TaskStatusRanToCompletion,
  Canceled = TaskStatusCanceled,
  Faulted = TaskStatusFaulted,
})

local UnobservedTaskExceptionEventArgs = System.define("System.UnobservedTaskExceptionEventArgs", {
  __ctor__ = function (this, exception)
    this.exception = exception
  end,
  SetObserved = function (this)
    this.observed = true
  end,
  getObserved = function (this)
    if this.observed then
      return true
    end
    return false
  end,
  getException = function (this)
    return this.exception
  end
})

local unobservedTaskException
local function publishUnobservedTaskException(sender, ueea)
  local handler = unobservedTaskException
  if handler then
    handler(sender, ueea)
  end
end

local TaskScheduler = System.define("System.TaskScheduler", {
  addUnobservedTaskException = function (value)
    unobservedTaskException = unobservedTaskException + value
  end,
  removeUnobservedTaskException = function (value)
    unobservedTaskException = unobservedTaskException - value
  end
})

local TaskExceptionHolder = {
  __index = false,
  __gc = function (this)
    if not this.isHandled then
      local e = this.exception
      if e then
        local ueea = UnobservedTaskExceptionEventArgs(e)
        publishUnobservedTaskException(this.task, ueea)
        if not ueea.observed then
          print("Warning: TaskExceptionHolder" , e)
        end
      end
    end
  end
}
TaskExceptionHolder.__index = TaskExceptionHolder

local function newTaskExceptionHolder(task, exception) 
  return setmetatable({ task = task, exception = exception }, TaskExceptionHolder)
end

local function createExceptionObject(this)
  if not this.isHandled then
    this.isHandled = true
  end
  return this.exception
end

local Task
local nextTaskId = 1
local currentTask
local completedTask

local function getNewId()
  local id = nextTaskId
  nextTaskId = nextTaskId + 1
  return id
end

local function getId(this)
  local id = this.id
  if id == nil then
    id = getNewId()
    this.id = id
  end
  return id 
end

local function isCompleted(this)
  local status = this.status
  return status == TaskStatusRanToCompletion or status == TaskStatusFaulted or status == TaskStatusCanceled
end

local function fromResult(result)
  return setmetatable({ status = TaskStatusRanToCompletion, data = result }, Task)
end

local function fromCanceled(cancellationToken)
  if cancellationToken and cancellationToken:getIsCancellationRequested() then 
    throw(ArgumentOutOfRangeException("cancellationToken"))
  end
  return setmetatable({ status = TaskStatusCanceled, data = cancellationToken }, Task)
end

local function getCompletedTask()
  local t = completedTask
  if t == nil then
    t = fromResult()
    completedTask = t
  end
  return t
end

local function trySetComplete(this, status, data)
  if isCompleted(this) then
    return false
  end

  this.status = status
  this.data = data

  local continueActions = this.continueActions
  if continueActions then
    for _, action in ipairs(continueActions) do
      action(this)
    end
    this.continueActions = nil
  end
  return true
end

local function trySetResult(this, result)
  return trySetComplete(this, TaskStatusRanToCompletion, result)
end

local function trySetException(this, exception)
  if this.isVoid then
    throw(exception)
  end
  return trySetComplete(this, TaskStatusFaulted, newTaskExceptionHolder(this, exception))
end

local function trySetCanceled(this, cancellationToken)
  return trySetComplete(this, TaskStatusCanceled, cancellationToken)
end

local function newWaitingTask(isVoid)
  return setmetatable({ status = TaskStatusWaitingForActivation, isVoid = isVoid }, Task)
end

local function getContinueActions(task) 
  local continueActions = task.continueActions
  if continueActions == nil then
    continueActions = {}
    task.continueActions = continueActions
  end
  return continueActions
end

local function await(t, task)
  assert(t.co)
  local continueActions = getContinueActions(task)
  tinsert(continueActions, function (task)
    local status = task.status
    local ok, v
    if status == TaskStatusRanToCompletion then
      ok, v = true, task.data
    elseif status == TaskStatusFaulted then
      ok, v = false, createExceptionObject(task.data)
    elseif status == TaskStatusCanceled then
      ok, v = false, TaskCanceledException(task)
    else
      assert(false)
    end
    ok, v = cresume(t.co, ok, v)
    if not ok then
      assert(trySetException(t, v))
    end
  end)
  local ok, v = cyield()
  if ok then
    return v
  else
    throw(v)
  end
end

Task = System.define("System.Task", {
  __ctor__ = function (this, action, state)
    this.status = TaskStatusCreated
    this.data = function ()
      action(state)
    end
  end,
  getId = getId,
  getCurrentId = function ()
    local t = currentTask
    if t then
      return getId(t)
    end
  end,
  getStatus = function (this)
    return this.status
  end,
  getException = function (this)
    if this.status == TaskStatusFaulted then
      return createExceptionObject(this.data)
    end
    return nil
  end,
  getIsCompleted = isCompleted,
  getIsCanceled = function (this)
    return this.status == TaskStatusCanceled
  end,
  getIsFaulted = function (this)
    return this.status == TaskStatusFaulted
  end,
  FromResult = fromResult,
  FromCanceled = fromCanceled,
  getCompletedTask = getCompletedTask,
  Delay = function (delay, cancellationToken)
    if type(delay) == "table" then
      delay = trunc(delay:getTotalMilliseconds())
      if delay < -1 or delay > 2147483647 then
        throw(ArgumentOutOfRangeException("delay"))
      end
    elseif delay < -1 then
      throw(ArgumentOutOfRangeException("millisecondsDelay"))  
    end

    if cancellationToken and cancellationToken:getIsCancellationRequested() then
      return fromCanceled(cancellationToken)
    elseif delay == 0 then
      return getCompletedTask()
    end

    local t = newWaitingTask()
    local timerId, registration  

    if cancellationToken and cancellationToken:getCanBeCanceled() then
      registration = cancellationToken.source:register(function ()
        local success = trySetCanceled(t, cancellationToken)
        if success and timerId then
          removeTimer(timerId)
        end
      end)
    end

    if delay ~= -1 then
      timerId = addTimer(function ()
        local success = trySetResult(t)
        if success and registration then
          registration:Dispose()
        end
      end, delay)
    end

    return t
  end,
  ContinueWith = function (this, continuationAction)
    local t = newWaitingTask()
    local function f()
      try(function ()
        assert(trySetResult(t, continuationAction()))
      end, function (e)
        assert(trySetException(t, e))
      end)
    end
    if isCompleted(this) then
      post(f)
    else
      local continueActions = getContinueActions(task)
      tinsert(continueActions, f)
    end
    return t
  end,
  await = function (this, task)
    local status = task.status
    if status == TaskStatusWaitingForActivation then
      return await(this, task)
    elseif status == TaskStatusRanToCompletion then
      return task.data
    elseif status == TaskStatusFaulted then
      throw(createExceptionObject(task.data))
    elseif status ==  TaskStatusCanceled then
      throw(TaskCanceledException(task))
    else
      return await(this, task)
    end
  end
})

local taskCoroutinePool = {}
local function taskCoroutineCreate(t, f)
  local co = tremove(taskCoroutinePool)
  if co == nil then
    co = ccreate(function (...)
      local r = f(t, ...)
      assert(trySetResult(t, r))
      while true do
        t = nil
        f = nil
        tinsert(taskCoroutinePool, co)
        t, f = cyield()
        r = f(t, cyield())
        assert(trySetResult(t, r))
      end
    end)
    t.co = co
  else
    t.co = co
    cresume(co, t, f)
  end
  return co
end

local function async(f, isVoid, ...)
  local t = newWaitingTask(isVoid)
  local co = taskCoroutineCreate(t, f)
  local ok, v = cresume(co, ...)
  if not ok then
    assert(trySetException(t, v))
  end
  return t
end

function System.asyncVoid(f, ...)
  async(f, true, ...)
end

function System.async(f, ...)
  return async(f, nil, ...)
end
