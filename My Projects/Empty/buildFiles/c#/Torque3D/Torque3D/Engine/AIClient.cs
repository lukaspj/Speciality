using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class AIClient : AIConnection
	{
		public AIClient(bool pRegister = false)
			: base(pRegister)
		{
		}

		public AIClient(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public AIClient(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public AIClient(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public AIClient(SimObject pObj) : base(pObj)
		{
		}

		public AIClient(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.AIClient_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMoveSpeed(IntPtr thisPtr, float speed);
         private static _setMoveSpeed _setMoveSpeedFunc;
         internal static void setMoveSpeed(IntPtr thisPtr, float speed)
         {
         	if (_setMoveSpeedFunc == null)
         	{
         		_setMoveSpeedFunc =
         			(_setMoveSpeed)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIClient_setMoveSpeed"), typeof(_setMoveSpeed));
         	}
         
         	 _setMoveSpeedFunc(thisPtr, speed);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _stop(IntPtr thisPtr);
         private static _stop _stopFunc;
         internal static void stop(IntPtr thisPtr)
         {
         	if (_stopFunc == null)
         	{
         		_stopFunc =
         			(_stop)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIClient_stop"), typeof(_stop));
         	}
         
         	 _stopFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setAimLocation(IntPtr thisPtr, InternalPoint3FStruct v);
         private static _setAimLocation _setAimLocationFunc;
         internal static void setAimLocation(IntPtr thisPtr, InternalPoint3FStruct v)
         {
         	if (_setAimLocationFunc == null)
         	{
         		_setAimLocationFunc =
         			(_setAimLocation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIClient_setAimLocation"), typeof(_setAimLocation));
         	}
         
         	 _setAimLocationFunc(thisPtr, v);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMoveDestination(IntPtr thisPtr, InternalPoint3FStruct v);
         private static _setMoveDestination _setMoveDestinationFunc;
         internal static void setMoveDestination(IntPtr thisPtr, InternalPoint3FStruct v)
         {
         	if (_setMoveDestinationFunc == null)
         	{
         		_setMoveDestinationFunc =
         			(_setMoveDestination)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIClient_setMoveDestination"), typeof(_setMoveDestination));
         	}
         
         	 _setMoveDestinationFunc(thisPtr, v);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getAimLocation(IntPtr thisPtr);
         private static _getAimLocation _getAimLocationFunc;
         internal static InternalPoint3FStruct getAimLocation(IntPtr thisPtr)
         {
         	if (_getAimLocationFunc == null)
         	{
         		_getAimLocationFunc =
         			(_getAimLocation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIClient_getAimLocation"), typeof(_getAimLocation));
         	}
         
         	return  _getAimLocationFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getMoveDestination(IntPtr thisPtr);
         private static _getMoveDestination _getMoveDestinationFunc;
         internal static InternalPoint3FStruct getMoveDestination(IntPtr thisPtr)
         {
         	if (_getMoveDestinationFunc == null)
         	{
         		_getMoveDestinationFunc =
         			(_getMoveDestination)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIClient_getMoveDestination"), typeof(_getMoveDestination));
         	}
         
         	return  _getMoveDestinationFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setTargetObject(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName);
         private static _setTargetObject _setTargetObjectFunc;
         internal static void setTargetObject(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName)
         {
         	if (_setTargetObjectFunc == null)
         	{
         		_setTargetObjectFunc =
         			(_setTargetObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIClient_setTargetObject"), typeof(_setTargetObject));
         	}
         
         	 _setTargetObjectFunc(thisPtr, objName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getTargetObject(IntPtr thisPtr);
         private static _getTargetObject _getTargetObjectFunc;
         internal static int getTargetObject(IntPtr thisPtr)
         {
         	if (_getTargetObjectFunc == null)
         	{
         		_getTargetObjectFunc =
         			(_getTargetObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIClient_getTargetObject"), typeof(_getTargetObject));
         	}
         
         	return  _getTargetObjectFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _missionCycleCleanup(IntPtr thisPtr);
         private static _missionCycleCleanup _missionCycleCleanupFunc;
         internal static void missionCycleCleanup(IntPtr thisPtr)
         {
         	if (_missionCycleCleanupFunc == null)
         	{
         		_missionCycleCleanupFunc =
         			(_missionCycleCleanup)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIClient_missionCycleCleanup"), typeof(_missionCycleCleanup));
         	}
         
         	 _missionCycleCleanupFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _move(IntPtr thisPtr);
         private static _move _moveFunc;
         internal static void move(IntPtr thisPtr)
         {
         	if (_moveFunc == null)
         	{
         		_moveFunc =
         			(_move)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIClient_move"), typeof(_move));
         	}
         
         	 _moveFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getLocation(IntPtr thisPtr);
         private static _getLocation _getLocationFunc;
         internal static InternalPoint3FStruct getLocation(IntPtr thisPtr)
         {
         	if (_getLocationFunc == null)
         	{
         		_getLocationFunc =
         			(_getLocation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIClient_getLocation"), typeof(_getLocation));
         	}
         
         	return  _getLocationFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _moveForward(IntPtr thisPtr);
         private static _moveForward _moveForwardFunc;
         internal static void moveForward(IntPtr thisPtr)
         {
         	if (_moveForwardFunc == null)
         	{
         		_moveForwardFunc =
         			(_moveForward)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIClient_moveForward"), typeof(_moveForward));
         	}
         
         	 _moveForwardFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AIClient_create();
         private static _AIClient_create _AIClient_createFunc;
         internal static IntPtr AIClient_create()
         {
         	if (_AIClient_createFunc == null)
         	{
         		_AIClient_createFunc =
         			(_AIClient_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AIClient_create"), typeof(_AIClient_create));
         	}
         
         	return  _AIClient_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setMoveSpeed(float speed)
         {
            InternalUnsafeMethods.setMoveSpeed(ObjectPtr, speed);
         }
      
         public virtual void stop()
         {
            InternalUnsafeMethods.stop(ObjectPtr);
         }
      
         public virtual void setAimLocation(Point3F v)
         {
            InternalUnsafeMethods.setAimLocation(ObjectPtr, v.ToStruct());
         }
      
         public virtual void setMoveDestination(Point3F v)
         {
            InternalUnsafeMethods.setMoveDestination(ObjectPtr, v.ToStruct());
         }
      
         public virtual Point3F getAimLocation()
         {
            return new Point3F(InternalUnsafeMethods.getAimLocation(ObjectPtr));
         }
      
         public virtual Point3F getMoveDestination()
         {
            return new Point3F(InternalUnsafeMethods.getMoveDestination(ObjectPtr));
         }
      
         public virtual void setTargetObject(string objName)
         {
            InternalUnsafeMethods.setTargetObject(ObjectPtr, objName);
         }
      
         public virtual int getTargetObject()
         {
            return InternalUnsafeMethods.getTargetObject(ObjectPtr);
         }
      
         public virtual void missionCycleCleanup()
         {
            InternalUnsafeMethods.missionCycleCleanup(ObjectPtr);
         }
      
         public virtual void move()
         {
            InternalUnsafeMethods.move(ObjectPtr);
         }
      
         public virtual Point3F getLocation()
         {
            return new Point3F(InternalUnsafeMethods.getLocation(ObjectPtr));
         }
      
         public virtual void moveForward()
         {
            InternalUnsafeMethods.moveForward(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}