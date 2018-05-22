﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_MeshRendererWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.MeshRenderer), typeof(UnityEngine.Renderer));
		L.RegFunction("New", _CreateUnityEngine_MeshRenderer);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("additionalVertexStreams", get_additionalVertexStreams, set_additionalVertexStreams);
		L.RegFunction("getadditionalVertexStreams", get_additionalVertexStreams);
		L.RegFunction("setadditionalVertexStreams", set_additionalVertexStreams);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_MeshRenderer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.MeshRenderer obj = new UnityEngine.MeshRenderer();
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.MeshRenderer.New");
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
	static int get_additionalVertexStreams(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.MeshRenderer obj = (UnityEngine.MeshRenderer)o;
			UnityEngine.Mesh ret = obj.additionalVertexStreams;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index additionalVertexStreams on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_additionalVertexStreams(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.MeshRenderer obj = (UnityEngine.MeshRenderer)o;
			UnityEngine.Mesh arg0 = (UnityEngine.Mesh)ToLua.CheckObject(L, 2, typeof(UnityEngine.Mesh));
			obj.additionalVertexStreams = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index additionalVertexStreams on a nil value");
		}
	}
}

