﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

internal class UnityEngine_AnimationWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Animation), typeof(UnityEngine.Behaviour));
		L.RegFunction("Stop", Stop);
		L.RegFunction("Stop0", Stop0);
		L.RegFunction("Stop1", Stop1);
		L.RegFunction("Rewind", Rewind);
		L.RegFunction("Rewind0", Rewind0);
		L.RegFunction("Rewind1", Rewind1);
		L.RegFunction("Sample", Sample);
		L.RegFunction("IsPlaying", IsPlaying);
		L.RegFunction("get_Item", get_Item);
		L.RegFunction("Play", Play);
		L.RegFunction("Play0", Play0);
		L.RegFunction("Play1", Play1);
		L.RegFunction("Play2", Play2);
		L.RegFunction("Play3", Play3);
		L.RegFunction("CrossFade", CrossFade);
		L.RegFunction("CrossFade0", CrossFade0);
		L.RegFunction("CrossFade1", CrossFade1);
		L.RegFunction("CrossFade2", CrossFade2);
		L.RegFunction("Blend", Blend);
		L.RegFunction("Blend0", Blend0);
		L.RegFunction("Blend1", Blend1);
		L.RegFunction("Blend2", Blend2);
		L.RegFunction("CrossFadeQueued", CrossFadeQueued);
		L.RegFunction("CrossFadeQueued0", CrossFadeQueued0);
		L.RegFunction("CrossFadeQueued1", CrossFadeQueued1);
		L.RegFunction("CrossFadeQueued2", CrossFadeQueued2);
		L.RegFunction("CrossFadeQueued3", CrossFadeQueued3);
		L.RegFunction("PlayQueued", PlayQueued);
		L.RegFunction("PlayQueued0", PlayQueued0);
		L.RegFunction("PlayQueued1", PlayQueued1);
		L.RegFunction("PlayQueued2", PlayQueued2);
		L.RegFunction("AddClip", AddClip);
		L.RegFunction("AddClip0", AddClip0);
		L.RegFunction("AddClip1", AddClip1);
		L.RegFunction("AddClip2", AddClip2);
		L.RegFunction("RemoveClip", RemoveClip);
		L.RegFunction("RemoveClip0", RemoveClip0);
		L.RegFunction("RemoveClip1", RemoveClip1);
		L.RegFunction("GetClipCount", GetClipCount);
		L.RegFunction("SyncLayer", SyncLayer);
		L.RegFunction("GetEnumerator", GetEnumerator);
		L.RegFunction("GetClip", GetClip);
		L.RegFunction("New", _CreateUnityEngine_Animation);
		L.RegVar("this", _this, null);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("clip", get_clip, set_clip);
		L.RegFunction("getclip", get_clip);
		L.RegFunction("setclip", set_clip);
		L.RegVar("playAutomatically", get_playAutomatically, set_playAutomatically);
		L.RegFunction("getplayAutomatically", get_playAutomatically);
		L.RegFunction("setplayAutomatically", set_playAutomatically);
		L.RegVar("wrapMode", get_wrapMode, set_wrapMode);
		L.RegFunction("getwrapMode", get_wrapMode);
		L.RegFunction("setwrapMode", set_wrapMode);
		L.RegVar("isPlaying", get_isPlaying, null);
		L.RegFunction("getisPlaying", get_isPlaying);
		L.RegVar("animatePhysics", get_animatePhysics, set_animatePhysics);
		L.RegFunction("getanimatePhysics", get_animatePhysics);
		L.RegFunction("setanimatePhysics", set_animatePhysics);
		L.RegVar("cullingType", get_cullingType, set_cullingType);
		L.RegFunction("getcullingType", get_cullingType);
		L.RegFunction("setcullingType", set_cullingType);
		L.RegVar("localBounds", get_localBounds, set_localBounds);
		L.RegFunction("getlocalBounds", get_localBounds);
		L.RegFunction("setlocalBounds", set_localBounds);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Animation(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				var obj = new UnityEngine.Animation();
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Animation.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _get_this(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			var obj = (UnityEngine.Animation)ToLua.CheckObject(L, 1, typeof(UnityEngine.Animation));
			string arg0 = ToLua.CheckString(L, 2);
			var o = obj[arg0];
			ToLua.PushSealed(L, o);
			return 1;

		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _this(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushvalue(L, 1);
			LuaDLL.tolua_bindthis(L, _get_this, null);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Stop(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				return Stop0(L);
			}
			else if (count == 2)
			{
				return Stop1(L);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Animation.Stop");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Stop0(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			obj.Stop();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Stop1(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			string arg0 = ToLua.ToString(L, 2);
			obj.Stop(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Rewind(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				return Rewind0(L);
			}
			else if (count == 2)
			{
				return Rewind1(L);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Animation.Rewind");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Rewind0(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			obj.Rewind();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Rewind1(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			string arg0 = ToLua.ToString(L, 2);
			obj.Rewind(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Sample(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			var obj = (UnityEngine.Animation)ToLua.CheckObject(L, 1, typeof(UnityEngine.Animation));
			obj.Sample();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsPlaying(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			var obj = (UnityEngine.Animation)ToLua.CheckObject(L, 1, typeof(UnityEngine.Animation));
			string arg0 = ToLua.CheckString(L, 2);
			var o = obj.IsPlaying(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Item(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			var obj = (UnityEngine.Animation)ToLua.CheckObject(L, 1, typeof(UnityEngine.Animation));
			string arg0 = ToLua.CheckString(L, 2);
			var o = obj[arg0];
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Play(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				return Play0(L);
			}
			else if (count == 2 && TypeChecker.CheckTypes<uint>(L, 2))
			{
				return Play1(L);
			}
			else if (count == 2 && TypeChecker.CheckTypes<string>(L, 2))
			{
				return Play2(L);
			}
			else if (count == 3)
			{
				return Play3(L);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Animation.Play");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Play0(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			var o = obj.Play();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Play1(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			UnityEngine.PlayMode arg0 = (UnityEngine.PlayMode)LuaDLL.lua_tonumber(L, 2);
			var o = obj.Play(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Play2(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			string arg0 = ToLua.ToString(L, 2);
			var o = obj.Play(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Play3(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			string arg0 = ToLua.ToString(L, 2);
			UnityEngine.PlayMode arg1 = (UnityEngine.PlayMode)LuaDLL.lua_tonumber(L, 3);
			var o = obj.Play(arg0, arg1);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CrossFade(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				return CrossFade0(L);
			}
			else if (count == 3)
			{
				return CrossFade1(L);
			}
			else if (count == 4)
			{
				return CrossFade2(L);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Animation.CrossFade");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CrossFade0(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			string arg0 = ToLua.ToString(L, 2);
			obj.CrossFade(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CrossFade1(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			string arg0 = ToLua.ToString(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			obj.CrossFade(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CrossFade2(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			string arg0 = ToLua.ToString(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			UnityEngine.PlayMode arg2 = (UnityEngine.PlayMode)LuaDLL.lua_tonumber(L, 4);
			obj.CrossFade(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Blend(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				return Blend0(L);
			}
			else if (count == 3)
			{
				return Blend1(L);
			}
			else if (count == 4)
			{
				return Blend2(L);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Animation.Blend");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Blend0(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			string arg0 = ToLua.ToString(L, 2);
			obj.Blend(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Blend1(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			string arg0 = ToLua.ToString(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			obj.Blend(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Blend2(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			string arg0 = ToLua.ToString(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
			obj.Blend(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CrossFadeQueued(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				return CrossFadeQueued0(L);
			}
			else if (count == 3)
			{
				return CrossFadeQueued1(L);
			}
			else if (count == 4)
			{
				return CrossFadeQueued2(L);
			}
			else if (count == 5)
			{
				return CrossFadeQueued3(L);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Animation.CrossFadeQueued");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CrossFadeQueued0(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			string arg0 = ToLua.ToString(L, 2);
			var o = obj.CrossFadeQueued(arg0);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CrossFadeQueued1(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			string arg0 = ToLua.ToString(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			var o = obj.CrossFadeQueued(arg0, arg1);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CrossFadeQueued2(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			string arg0 = ToLua.ToString(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			UnityEngine.QueueMode arg2 = (UnityEngine.QueueMode)LuaDLL.lua_tonumber(L, 4);
			var o = obj.CrossFadeQueued(arg0, arg1, arg2);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CrossFadeQueued3(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			string arg0 = ToLua.ToString(L, 2);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
			UnityEngine.QueueMode arg2 = (UnityEngine.QueueMode)LuaDLL.lua_tonumber(L, 4);
			UnityEngine.PlayMode arg3 = (UnityEngine.PlayMode)LuaDLL.lua_tonumber(L, 5);
			var o = obj.CrossFadeQueued(arg0, arg1, arg2, arg3);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PlayQueued(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				return PlayQueued0(L);
			}
			else if (count == 3)
			{
				return PlayQueued1(L);
			}
			else if (count == 4)
			{
				return PlayQueued2(L);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Animation.PlayQueued");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PlayQueued0(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			string arg0 = ToLua.ToString(L, 2);
			var o = obj.PlayQueued(arg0);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PlayQueued1(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			string arg0 = ToLua.ToString(L, 2);
			UnityEngine.QueueMode arg1 = (UnityEngine.QueueMode)LuaDLL.lua_tonumber(L, 3);
			var o = obj.PlayQueued(arg0, arg1);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PlayQueued2(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			string arg0 = ToLua.ToString(L, 2);
			UnityEngine.QueueMode arg1 = (UnityEngine.QueueMode)LuaDLL.lua_tonumber(L, 3);
			UnityEngine.PlayMode arg2 = (UnityEngine.PlayMode)LuaDLL.lua_tonumber(L, 4);
			var o = obj.PlayQueued(arg0, arg1, arg2);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddClip(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				return AddClip0(L);
			}
			else if (count == 5)
			{
				return AddClip1(L);
			}
			else if (count == 6)
			{
				return AddClip2(L);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Animation.AddClip");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddClip0(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			UnityEngine.AnimationClip arg0 = (UnityEngine.AnimationClip)ToLua.ToObject(L, 2);
			string arg1 = ToLua.ToString(L, 3);
			obj.AddClip(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddClip1(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			UnityEngine.AnimationClip arg0 = (UnityEngine.AnimationClip)ToLua.ToObject(L, 2);
			string arg1 = ToLua.ToString(L, 3);
			int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
			int arg3 = (int)LuaDLL.lua_tonumber(L, 5);
			obj.AddClip(arg0, arg1, arg2, arg3);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddClip2(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			UnityEngine.AnimationClip arg0 = (UnityEngine.AnimationClip)ToLua.ToObject(L, 2);
			string arg1 = ToLua.ToString(L, 3);
			int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
			int arg3 = (int)LuaDLL.lua_tonumber(L, 5);
			bool arg4 = LuaDLL.lua_toboolean(L, 6);
			obj.AddClip(arg0, arg1, arg2, arg3, arg4);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveClip(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<UnityEngine.AnimationClip>(L, 2))
			{
				return RemoveClip0(L);
			}
			else if (count == 2 && TypeChecker.CheckTypes<string>(L, 2))
			{
				return RemoveClip1(L);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Animation.RemoveClip");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveClip0(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			UnityEngine.AnimationClip arg0 = (UnityEngine.AnimationClip)ToLua.ToObject(L, 2);
			obj.RemoveClip(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveClip1(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			var obj = (UnityEngine.Animation)ToLua.ToObject(L, 1);
			string arg0 = ToLua.ToString(L, 2);
			obj.RemoveClip(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClipCount(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			var obj = (UnityEngine.Animation)ToLua.CheckObject(L, 1, typeof(UnityEngine.Animation));
			var o = obj.GetClipCount();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SyncLayer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			var obj = (UnityEngine.Animation)ToLua.CheckObject(L, 1, typeof(UnityEngine.Animation));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.SyncLayer(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEnumerator(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			var obj = (UnityEngine.Animation)ToLua.CheckObject(L, 1, typeof(UnityEngine.Animation));
			var o = obj.GetEnumerator();
			ToLua.PushIEnumerator(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClip(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			var obj = (UnityEngine.Animation)ToLua.CheckObject(L, 1, typeof(UnityEngine.Animation));
			string arg0 = ToLua.CheckString(L, 2);
			var o = obj.GetClip(arg0);
			ToLua.PushSealed(L, o);
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
	static int get_clip(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Animation obj = (UnityEngine.Animation)o;
			UnityEngine.AnimationClip ret = obj.clip;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index clip on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_playAutomatically(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Animation obj = (UnityEngine.Animation)o;
			bool ret = obj.playAutomatically;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index playAutomatically on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_wrapMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Animation obj = (UnityEngine.Animation)o;
			UnityEngine.WrapMode ret = obj.wrapMode;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index wrapMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isPlaying(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Animation obj = (UnityEngine.Animation)o;
			bool ret = obj.isPlaying;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isPlaying on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_animatePhysics(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Animation obj = (UnityEngine.Animation)o;
			bool ret = obj.animatePhysics;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index animatePhysics on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cullingType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Animation obj = (UnityEngine.Animation)o;
			UnityEngine.AnimationCullingType ret = obj.cullingType;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cullingType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localBounds(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Animation obj = (UnityEngine.Animation)o;
			UnityEngine.Bounds ret = obj.localBounds;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index localBounds on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_clip(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Animation obj = (UnityEngine.Animation)o;
			UnityEngine.AnimationClip arg0 = (UnityEngine.AnimationClip)ToLua.CheckObject(L, 2, typeof(UnityEngine.AnimationClip));
			obj.clip = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index clip on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_playAutomatically(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Animation obj = (UnityEngine.Animation)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.playAutomatically = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index playAutomatically on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_wrapMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Animation obj = (UnityEngine.Animation)o;
			UnityEngine.WrapMode arg0 = (UnityEngine.WrapMode)LuaDLL.luaL_checknumber(L, 2);
			obj.wrapMode = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index wrapMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_animatePhysics(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Animation obj = (UnityEngine.Animation)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.animatePhysics = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index animatePhysics on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cullingType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Animation obj = (UnityEngine.Animation)o;
			UnityEngine.AnimationCullingType arg0 = (UnityEngine.AnimationCullingType)LuaDLL.luaL_checknumber(L, 2);
			obj.cullingType = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cullingType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_localBounds(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Animation obj = (UnityEngine.Animation)o;
			UnityEngine.Bounds arg0 = ToLua.ToBounds(L, 2);
			obj.localBounds = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index localBounds on a nil value");
		}
	}
}

