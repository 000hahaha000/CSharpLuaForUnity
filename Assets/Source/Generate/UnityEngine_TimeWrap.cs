﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_TimeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("Time");
		L.RegVar("time", get_time, null);
		L.RegFunction("gettime", get_time);
		L.RegVar("timeSinceLevelLoad", get_timeSinceLevelLoad, null);
		L.RegFunction("gettimeSinceLevelLoad", get_timeSinceLevelLoad);
		L.RegVar("deltaTime", get_deltaTime, null);
		L.RegFunction("getdeltaTime", get_deltaTime);
		L.RegVar("fixedTime", get_fixedTime, null);
		L.RegFunction("getfixedTime", get_fixedTime);
		L.RegVar("unscaledTime", get_unscaledTime, null);
		L.RegFunction("getunscaledTime", get_unscaledTime);
		L.RegVar("unscaledDeltaTime", get_unscaledDeltaTime, null);
		L.RegFunction("getunscaledDeltaTime", get_unscaledDeltaTime);
		L.RegVar("fixedDeltaTime", get_fixedDeltaTime, set_fixedDeltaTime);
		L.RegFunction("getfixedDeltaTime", get_fixedDeltaTime);
		L.RegFunction("setfixedDeltaTime", set_fixedDeltaTime);
		L.RegVar("maximumDeltaTime", get_maximumDeltaTime, set_maximumDeltaTime);
		L.RegFunction("getmaximumDeltaTime", get_maximumDeltaTime);
		L.RegFunction("setmaximumDeltaTime", set_maximumDeltaTime);
		L.RegVar("smoothDeltaTime", get_smoothDeltaTime, null);
		L.RegFunction("getsmoothDeltaTime", get_smoothDeltaTime);
		L.RegVar("maximumParticleDeltaTime", get_maximumParticleDeltaTime, set_maximumParticleDeltaTime);
		L.RegFunction("getmaximumParticleDeltaTime", get_maximumParticleDeltaTime);
		L.RegFunction("setmaximumParticleDeltaTime", set_maximumParticleDeltaTime);
		L.RegVar("timeScale", get_timeScale, set_timeScale);
		L.RegFunction("gettimeScale", get_timeScale);
		L.RegFunction("settimeScale", set_timeScale);
		L.RegVar("frameCount", get_frameCount, null);
		L.RegFunction("getframeCount", get_frameCount);
		L.RegVar("renderedFrameCount", get_renderedFrameCount, null);
		L.RegFunction("getrenderedFrameCount", get_renderedFrameCount);
		L.RegVar("realtimeSinceStartup", get_realtimeSinceStartup, null);
		L.RegFunction("getrealtimeSinceStartup", get_realtimeSinceStartup);
		L.RegVar("captureFramerate", get_captureFramerate, set_captureFramerate);
		L.RegFunction("getcaptureFramerate", get_captureFramerate);
		L.RegFunction("setcaptureFramerate", set_captureFramerate);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_time(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.time);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_timeSinceLevelLoad(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.timeSinceLevelLoad);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_deltaTime(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.deltaTime);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fixedTime(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.fixedTime);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_unscaledTime(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.unscaledTime);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_unscaledDeltaTime(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.unscaledDeltaTime);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fixedDeltaTime(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.fixedDeltaTime);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maximumDeltaTime(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.maximumDeltaTime);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_smoothDeltaTime(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.smoothDeltaTime);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maximumParticleDeltaTime(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.maximumParticleDeltaTime);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_timeScale(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.timeScale);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_frameCount(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.Time.frameCount);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_renderedFrameCount(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.Time.renderedFrameCount);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_realtimeSinceStartup(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.realtimeSinceStartup);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_captureFramerate(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.Time.captureFramerate);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fixedDeltaTime(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Time.fixedDeltaTime = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maximumDeltaTime(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Time.maximumDeltaTime = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maximumParticleDeltaTime(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Time.maximumParticleDeltaTime = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_timeScale(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Time.timeScale = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_captureFramerate(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Time.captureFramerate = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

