using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class PathCamera : ShapeBase
	{
		public PathCamera(bool pRegister = false)
			: base(pRegister)
		{
		}

		public PathCamera(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public PathCamera(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public PathCamera(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public PathCamera(SimObject pObj) : base(pObj)
		{
		}

		public PathCamera(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.PathCamera_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setPosition(IntPtr thisPtr, float position);
         private static _setPosition _setPositionFunc;
         internal static void setPosition(IntPtr thisPtr, float position)
         {
         	if (_setPositionFunc == null)
         	{
         		_setPositionFunc =
         			(_setPosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPathCamera_setPosition"), typeof(_setPosition));
         	}
         
         	 _setPositionFunc(thisPtr, position);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setTarget(IntPtr thisPtr, float position);
         private static _setTarget _setTargetFunc;
         internal static void setTarget(IntPtr thisPtr, float position)
         {
         	if (_setTargetFunc == null)
         	{
         		_setTargetFunc =
         			(_setTarget)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPathCamera_setTarget"), typeof(_setTarget));
         	}
         
         	 _setTargetFunc(thisPtr, position);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setState(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newState);
         private static _setState _setStateFunc;
         internal static void setState(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newState)
         {
         	if (_setStateFunc == null)
         	{
         		_setStateFunc =
         			(_setState)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPathCamera_setState"), typeof(_setState));
         	}
         
         	 _setStateFunc(thisPtr, newState);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _reset(IntPtr thisPtr, float speed);
         private static _reset _resetFunc;
         internal static void reset(IntPtr thisPtr, float speed)
         {
         	if (_resetFunc == null)
         	{
         		_resetFunc =
         			(_reset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPathCamera_reset"), typeof(_reset));
         	}
         
         	 _resetFunc(thisPtr, speed);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _pushBack(IntPtr thisPtr, InternalTransformFStruct transform, float speed, [MarshalAs(UnmanagedType.LPWStr)]string type, [MarshalAs(UnmanagedType.LPWStr)]string path);
         private static _pushBack _pushBackFunc;
         internal static void pushBack(IntPtr thisPtr, InternalTransformFStruct transform, float speed, [MarshalAs(UnmanagedType.LPWStr)]string type, [MarshalAs(UnmanagedType.LPWStr)]string path)
         {
         	if (_pushBackFunc == null)
         	{
         		_pushBackFunc =
         			(_pushBack)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPathCamera_pushBack"), typeof(_pushBack));
         	}
         
         	 _pushBackFunc(thisPtr, transform, speed, type, path);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _pushFront(IntPtr thisPtr, InternalTransformFStruct transform, float speed, [MarshalAs(UnmanagedType.LPWStr)]string type, [MarshalAs(UnmanagedType.LPWStr)]string path);
         private static _pushFront _pushFrontFunc;
         internal static void pushFront(IntPtr thisPtr, InternalTransformFStruct transform, float speed, [MarshalAs(UnmanagedType.LPWStr)]string type, [MarshalAs(UnmanagedType.LPWStr)]string path)
         {
         	if (_pushFrontFunc == null)
         	{
         		_pushFrontFunc =
         			(_pushFront)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPathCamera_pushFront"), typeof(_pushFront));
         	}
         
         	 _pushFrontFunc(thisPtr, transform, speed, type, path);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _popFront(IntPtr thisPtr);
         private static _popFront _popFrontFunc;
         internal static void popFront(IntPtr thisPtr)
         {
         	if (_popFrontFunc == null)
         	{
         		_popFrontFunc =
         			(_popFront)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPathCamera_popFront"), typeof(_popFront));
         	}
         
         	 _popFrontFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _PathCamera_create();
         private static _PathCamera_create _PathCamera_createFunc;
         internal static IntPtr PathCamera_create()
         {
         	if (_PathCamera_createFunc == null)
         	{
         		_PathCamera_createFunc =
         			(_PathCamera_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PathCamera_create"), typeof(_PathCamera_create));
         	}
         
         	return  _PathCamera_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setPosition(float position = 0.0f)
         {
            InternalUnsafeMethods.setPosition(ObjectPtr, position);
         }
      
         public virtual void setTarget(float position = 1.0f)
         {
            InternalUnsafeMethods.setTarget(ObjectPtr, position);
         }
      
         public virtual void setState(string newState = "forward")
         {
            InternalUnsafeMethods.setState(ObjectPtr, newState);
         }
      
         public virtual void reset(float speed = 1.0f)
         {
            InternalUnsafeMethods.reset(ObjectPtr, speed);
         }
      
         public virtual void pushBack(TransformF transform, float speed = 1.0f, string type = "Normal", string path = "Linear")
         {
            InternalUnsafeMethods.pushBack(ObjectPtr, transform.ToStruct(), speed, type, path);
         }
      
         public virtual void pushFront(TransformF transform, float speed = 1.0f, string type = "Normal", string path = "Linear")
         {
            InternalUnsafeMethods.pushFront(ObjectPtr, transform.ToStruct(), speed, type, path);
         }
      
         public virtual void popFront()
         {
            InternalUnsafeMethods.popFront(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}