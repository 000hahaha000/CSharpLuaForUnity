﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

internal class UnityEngine_EventSystems_BaseRaycasterWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.EventSystems.BaseRaycaster), typeof(UnityEngine.EventSystems.UIBehaviour));
		L.RegFunction("Raycast", Raycast);
		L.RegFunction("ToString", ToString);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("eventCamera", get_eventCamera, null);
		L.RegFunction("geteventCamera", get_eventCamera);
		L.RegVar("sortOrderPriority", get_sortOrderPriority, null);
		L.RegFunction("getsortOrderPriority", get_sortOrderPriority);
		L.RegVar("renderOrderPriority", get_renderOrderPriority, null);
		L.RegFunction("getrenderOrderPriority", get_renderOrderPriority);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Raycast(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			var obj = (UnityEngine.EventSystems.BaseRaycaster)ToLua.CheckObject<UnityEngine.EventSystems.BaseRaycaster>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> arg1 = (System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>)ToLua.CheckObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>));
			obj.Raycast(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			var obj = (UnityEngine.EventSystems.BaseRaycaster)ToLua.CheckObject<UnityEngine.EventSystems.BaseRaycaster>(L, 1);
			var o = obj.ToString();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_eventCamera(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.BaseRaycaster obj = (UnityEngine.EventSystems.BaseRaycaster)o;
			UnityEngine.Camera ret = obj.eventCamera;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index eventCamera on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sortOrderPriority(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.BaseRaycaster obj = (UnityEngine.EventSystems.BaseRaycaster)o;
			int ret = obj.sortOrderPriority;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index sortOrderPriority on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_renderOrderPriority(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.BaseRaycaster obj = (UnityEngine.EventSystems.BaseRaycaster)o;
			int ret = obj.renderOrderPriority;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index renderOrderPriority on a nil value");
		}
	}
}

