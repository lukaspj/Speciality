using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Util;

namespace Torque3D
{
	public static unsafe class Globals
	{
      #region UnsafeNativeMethods

	   new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Globals_GetString(string variable);
         private static _Globals_GetString _Globals_GetStringFunc;
         internal static IntPtr Globals_GetString(string variable)
         {
            if (_Globals_GetStringFunc == null)
            {
               _Globals_GetStringFunc =
                  (_Globals_GetString)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
                     "fn_getConsoleString"), typeof(_Globals_GetString));
            }

            return _Globals_GetStringFunc(variable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Globals_SetString(string variable, string val);
         private static _Globals_SetString _Globals_SetStringFunc;
         internal static void Globals_SetString(string variable, string val)
         {
            if (_Globals_SetStringFunc == null)
            {
               _Globals_SetStringFunc =
                  (_Globals_SetString)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
                     "fn_setConsoleString"), typeof(_Globals_SetString));
            }

            _Globals_SetStringFunc(variable, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Globals_GetInt(string variable);
         private static _Globals_GetInt _Globals_GetIntFunc;
         internal static int Globals_GetInt(string variable)
         {
            if (_Globals_GetIntFunc == null)
            {
               _Globals_GetIntFunc =
                  (_Globals_GetInt)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
                     "fn_getConsoleInt"), typeof(_Globals_GetInt));
            }

            return _Globals_GetIntFunc(variable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Globals_SetInt(string variable, int val);
         private static _Globals_SetInt _Globals_SetIntFunc;
         internal static void Globals_SetInt(string variable, int val)
         {
            if (_Globals_SetIntFunc == null)
            {
               _Globals_SetIntFunc =
                  (_Globals_SetInt)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
                     "fn_setConsoleInt"), typeof(_Globals_SetInt));
            }

            _Globals_SetIntFunc(variable, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _Globals_GetFloat(string variable);
         private static _Globals_GetFloat _Globals_GetFloatFunc;
         internal static float Globals_GetFloat(string variable)
         {
            if (_Globals_GetFloatFunc == null)
            {
               _Globals_GetFloatFunc =
                  (_Globals_GetFloat)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
                     "fn_getConsoleFloat"), typeof(_Globals_GetFloat));
            }

            return _Globals_GetFloatFunc(variable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Globals_SetFloat(string variable, float val);
         private static _Globals_SetFloat _Globals_SetFloatFunc;
         internal static void Globals_SetFloat(string variable, float val)
         {
            if (_Globals_SetFloatFunc == null)
            {
               _Globals_SetFloatFunc =
                  (_Globals_SetFloat)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
                     "fn_setConsoleFloat"), typeof(_Globals_SetFloat));
            }

            _Globals_SetFloatFunc(variable, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return:MarshalAs(UnmanagedType.I1)]
         private delegate bool _Globals_GetBool(string variable);
         private static _Globals_GetBool _Globals_GetBoolFunc;
         internal static bool Globals_GetBool(string variable)
         {
            if (_Globals_GetBoolFunc == null)
            {
               _Globals_GetBoolFunc =
                  (_Globals_GetBool)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
                     "fn_getConsoleBool"), typeof(_Globals_GetBool));
            }

            return _Globals_GetBoolFunc(variable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Globals_SetBool(string variable, bool val);
         private static _Globals_SetBool _Globals_SetBoolFunc;
         internal static void Globals_SetBool(string variable, bool val)
         {
            if (_Globals_SetBoolFunc == null)
            {
               _Globals_SetBoolFunc =
                  (_Globals_SetBool)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
                     "fn_setConsoleBool"), typeof(_Globals_SetBool));
            }

            _Globals_SetBoolFunc(variable, val);
         }
      }

      #endregion


      #region Functions

      public static bool GetBool(string variable)
      {
         return InternalUnsafeMethods.Globals_GetBool("$" + variable);
      }

      public static void SetBool(string variable, bool val)
      {
         InternalUnsafeMethods.Globals_SetBool("$" + variable, val);
      }

      public static int GetInt(string variable)
      {
         return InternalUnsafeMethods.Globals_GetInt("$" + variable);
      }

      public static void SetInt(string variable, int val)
      {
         InternalUnsafeMethods.Globals_SetInt("$" + variable, val);
      }

      public static float GetFloat(string variable)
      {
         return InternalUnsafeMethods.Globals_GetFloat("$" + variable);
      }

      public static void SetFloat(string variable, float val)
      {
         InternalUnsafeMethods.Globals_SetFloat("$" + variable, val);
      }

      public static string GetString(string variable)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Globals_GetString("$" + variable));
      }

      public static void SetString(string variable, string val)
      {
         InternalUnsafeMethods.Globals_SetString("$" + variable, val);
      }

      #endregion

	   public static void Increment(string global)
	   {
	      SetInt(global, GetInt(global) + 1);
	   }

	   public static void Decrement(string global)
	   {
	      SetInt(global, GetInt(global) - 1);
	   }
	}
}