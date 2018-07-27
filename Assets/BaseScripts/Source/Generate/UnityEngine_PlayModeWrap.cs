﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

internal class UnityEngine_PlayModeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.PlayMode));
		L.RegVar("StopSameLayer", get_StopSameLayer, null);
		L.RegVar("StopAll", get_StopAll, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
		TypeTraits<UnityEngine.PlayMode>.Check = CheckType;
		StackTraits<UnityEngine.PlayMode>.Push = Push;
	}

	static void Push(IntPtr L, UnityEngine.PlayMode arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(UnityEngine.PlayMode), L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_StopSameLayer(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.PlayMode.StopSameLayer);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_StopAll(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.PlayMode.StopAll);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.PlayMode o = (UnityEngine.PlayMode)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

