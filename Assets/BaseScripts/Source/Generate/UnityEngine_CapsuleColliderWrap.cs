﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

internal class UnityEngine_CapsuleColliderWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.CapsuleCollider), typeof(UnityEngine.Collider));
		L.RegFunction("New", _CreateUnityEngine_CapsuleCollider);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("center", get_center, set_center);
		L.RegFunction("getcenter", get_center);
		L.RegFunction("setcenter", set_center);
		L.RegVar("radius", get_radius, set_radius);
		L.RegFunction("getradius", get_radius);
		L.RegFunction("setradius", set_radius);
		L.RegVar("height", get_height, set_height);
		L.RegFunction("getheight", get_height);
		L.RegFunction("setheight", set_height);
		L.RegVar("direction", get_direction, set_direction);
		L.RegFunction("getdirection", get_direction);
		L.RegFunction("setdirection", set_direction);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_CapsuleCollider(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				var obj = new UnityEngine.CapsuleCollider();
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.CapsuleCollider.New");
			}
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
	static int get_center(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.CapsuleCollider obj = (UnityEngine.CapsuleCollider)o;
			UnityEngine.Vector3 ret = obj.center;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index center on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_radius(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.CapsuleCollider obj = (UnityEngine.CapsuleCollider)o;
			float ret = obj.radius;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index radius on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_height(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.CapsuleCollider obj = (UnityEngine.CapsuleCollider)o;
			float ret = obj.height;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index height on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_direction(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.CapsuleCollider obj = (UnityEngine.CapsuleCollider)o;
			int ret = obj.direction;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index direction on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_center(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.CapsuleCollider obj = (UnityEngine.CapsuleCollider)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.center = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index center on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_radius(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.CapsuleCollider obj = (UnityEngine.CapsuleCollider)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.radius = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index radius on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_height(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.CapsuleCollider obj = (UnityEngine.CapsuleCollider)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.height = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index height on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_direction(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.CapsuleCollider obj = (UnityEngine.CapsuleCollider)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.direction = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index direction on a nil value");
		}
	}
}

