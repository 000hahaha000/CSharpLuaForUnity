﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

internal class LuaInterface_LuaFieldWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaInterface.LuaField), typeof(System.Object));
		L.RegFunction("Get", Get);
		L.RegFunction("Set", Set);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Get(IntPtr L)
	{
		try
		{			
			LuaField obj = (LuaField)ToLua.CheckObject(L, 1, typeof(LuaField));            
            return obj.Get(L);						
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Set(IntPtr L)
	{
		try
		{			
            LuaField obj = (LuaField)ToLua.CheckObject(L, 1, typeof(LuaField));            
            return obj.Set(L);
        }
        catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

