using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class Player : ShapeBase
	{
		public Player(bool pRegister = false)
			: base(pRegister)
		{
		}

		public Player(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public Player(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public Player(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public Player(SimObject pObj) : base(pObj)
		{
		}

		public Player(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Player_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getPose(IntPtr thisPtr);
         private static _getPose _getPoseFunc;
         internal static IntPtr getPose(IntPtr thisPtr)
         {
         	if (_getPoseFunc == null)
         	{
         		_getPoseFunc =
         			(_getPose)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPlayer_getPose"), typeof(_getPose));
         	}
         
         	return  _getPoseFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _allowAllPoses(IntPtr thisPtr);
         private static _allowAllPoses _allowAllPosesFunc;
         internal static void allowAllPoses(IntPtr thisPtr)
         {
         	if (_allowAllPosesFunc == null)
         	{
         		_allowAllPosesFunc =
         			(_allowAllPoses)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPlayer_allowAllPoses"), typeof(_allowAllPoses));
         	}
         
         	 _allowAllPosesFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _allowJumping(IntPtr thisPtr, bool state);
         private static _allowJumping _allowJumpingFunc;
         internal static void allowJumping(IntPtr thisPtr, bool state)
         {
         	if (_allowJumpingFunc == null)
         	{
         		_allowJumpingFunc =
         			(_allowJumping)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPlayer_allowJumping"), typeof(_allowJumping));
         	}
         
         	 _allowJumpingFunc(thisPtr, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _allowJetJumping(IntPtr thisPtr, bool state);
         private static _allowJetJumping _allowJetJumpingFunc;
         internal static void allowJetJumping(IntPtr thisPtr, bool state)
         {
         	if (_allowJetJumpingFunc == null)
         	{
         		_allowJetJumpingFunc =
         			(_allowJetJumping)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPlayer_allowJetJumping"), typeof(_allowJetJumping));
         	}
         
         	 _allowJetJumpingFunc(thisPtr, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _allowSprinting(IntPtr thisPtr, bool state);
         private static _allowSprinting _allowSprintingFunc;
         internal static void allowSprinting(IntPtr thisPtr, bool state)
         {
         	if (_allowSprintingFunc == null)
         	{
         		_allowSprintingFunc =
         			(_allowSprinting)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPlayer_allowSprinting"), typeof(_allowSprinting));
         	}
         
         	 _allowSprintingFunc(thisPtr, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _allowCrouching(IntPtr thisPtr, bool state);
         private static _allowCrouching _allowCrouchingFunc;
         internal static void allowCrouching(IntPtr thisPtr, bool state)
         {
         	if (_allowCrouchingFunc == null)
         	{
         		_allowCrouchingFunc =
         			(_allowCrouching)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPlayer_allowCrouching"), typeof(_allowCrouching));
         	}
         
         	 _allowCrouchingFunc(thisPtr, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _allowProne(IntPtr thisPtr, bool state);
         private static _allowProne _allowProneFunc;
         internal static void allowProne(IntPtr thisPtr, bool state)
         {
         	if (_allowProneFunc == null)
         	{
         		_allowProneFunc =
         			(_allowProne)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPlayer_allowProne"), typeof(_allowProne));
         	}
         
         	 _allowProneFunc(thisPtr, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _allowSwimming(IntPtr thisPtr, bool state);
         private static _allowSwimming _allowSwimmingFunc;
         internal static void allowSwimming(IntPtr thisPtr, bool state)
         {
         	if (_allowSwimmingFunc == null)
         	{
         		_allowSwimmingFunc =
         			(_allowSwimming)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPlayer_allowSwimming"), typeof(_allowSwimming));
         	}
         
         	 _allowSwimmingFunc(thisPtr, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getState(IntPtr thisPtr);
         private static _getState _getStateFunc;
         internal static IntPtr getState(IntPtr thisPtr)
         {
         	if (_getStateFunc == null)
         	{
         		_getStateFunc =
         			(_getState)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPlayer_getState"), typeof(_getState));
         	}
         
         	return  _getStateFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getDamageLocation(IntPtr thisPtr, InternalPoint3FStruct pos);
         private static _getDamageLocation _getDamageLocationFunc;
         internal static IntPtr getDamageLocation(IntPtr thisPtr, InternalPoint3FStruct pos)
         {
         	if (_getDamageLocationFunc == null)
         	{
         		_getDamageLocationFunc =
         			(_getDamageLocation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPlayer_getDamageLocation"), typeof(_getDamageLocation));
         	}
         
         	return  _getDamageLocationFunc(thisPtr, pos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setArmThread(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _setArmThread _setArmThreadFunc;
         internal static bool setArmThread(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_setArmThreadFunc == null)
         	{
         		_setArmThreadFunc =
         			(_setArmThread)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPlayer_setArmThread"), typeof(_setArmThread));
         	}
         
         	return  _setArmThreadFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setActionThread(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, bool hold, bool fsp);
         private static _setActionThread _setActionThreadFunc;
         internal static bool setActionThread(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, bool hold, bool fsp)
         {
         	if (_setActionThreadFunc == null)
         	{
         		_setActionThreadFunc =
         			(_setActionThread)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPlayer_setActionThread"), typeof(_setActionThread));
         	}
         
         	return  _setActionThreadFunc(thisPtr, name, hold, fsp);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setControlObject(IntPtr thisPtr, IntPtr obj);
         private static _setControlObject _setControlObjectFunc;
         internal static bool setControlObject(IntPtr thisPtr, IntPtr obj)
         {
         	if (_setControlObjectFunc == null)
         	{
         		_setControlObjectFunc =
         			(_setControlObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPlayer_setControlObject"), typeof(_setControlObject));
         	}
         
         	return  _setControlObjectFunc(thisPtr, obj);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getControlObject(IntPtr thisPtr);
         private static _getControlObject _getControlObjectFunc;
         internal static int getControlObject(IntPtr thisPtr)
         {
         	if (_getControlObjectFunc == null)
         	{
         		_getControlObjectFunc =
         			(_getControlObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPlayer_getControlObject"), typeof(_getControlObject));
         	}
         
         	return  _getControlObjectFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearControlObject(IntPtr thisPtr);
         private static _clearControlObject _clearControlObjectFunc;
         internal static void clearControlObject(IntPtr thisPtr)
         {
         	if (_clearControlObjectFunc == null)
         	{
         		_clearControlObjectFunc =
         			(_clearControlObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPlayer_clearControlObject"), typeof(_clearControlObject));
         	}
         
         	 _clearControlObjectFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _checkDismountPoint(IntPtr thisPtr, InternalPoint3FStruct oldPos, InternalPoint3FStruct pos);
         private static _checkDismountPoint _checkDismountPointFunc;
         internal static bool checkDismountPoint(IntPtr thisPtr, InternalPoint3FStruct oldPos, InternalPoint3FStruct pos)
         {
         	if (_checkDismountPointFunc == null)
         	{
         		_checkDismountPointFunc =
         			(_checkDismountPoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPlayer_checkDismountPoint"), typeof(_checkDismountPoint));
         	}
         
         	return  _checkDismountPointFunc(thisPtr, oldPos, pos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getNumDeathAnimations(IntPtr thisPtr);
         private static _getNumDeathAnimations _getNumDeathAnimationsFunc;
         internal static int getNumDeathAnimations(IntPtr thisPtr)
         {
         	if (_getNumDeathAnimationsFunc == null)
         	{
         		_getNumDeathAnimationsFunc =
         			(_getNumDeathAnimations)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPlayer_getNumDeathAnimations"), typeof(_getNumDeathAnimations));
         	}
         
         	return  _getNumDeathAnimationsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Player_create();
         private static _Player_create _Player_createFunc;
         internal static IntPtr Player_create()
         {
         	if (_Player_createFunc == null)
         	{
         		_Player_createFunc =
         			(_Player_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Player_create"), typeof(_Player_create));
         	}
         
         	return  _Player_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual string getPose()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getPose(ObjectPtr));
         }
      
         public virtual void allowAllPoses()
         {
            InternalUnsafeMethods.allowAllPoses(ObjectPtr);
         }
      
         public virtual void allowJumping(bool state)
         {
            InternalUnsafeMethods.allowJumping(ObjectPtr, state);
         }
      
         public virtual void allowJetJumping(bool state)
         {
            InternalUnsafeMethods.allowJetJumping(ObjectPtr, state);
         }
      
         public virtual void allowSprinting(bool state)
         {
            InternalUnsafeMethods.allowSprinting(ObjectPtr, state);
         }
      
         public virtual void allowCrouching(bool state)
         {
            InternalUnsafeMethods.allowCrouching(ObjectPtr, state);
         }
      
         public virtual void allowProne(bool state)
         {
            InternalUnsafeMethods.allowProne(ObjectPtr, state);
         }
      
         public virtual void allowSwimming(bool state)
         {
            InternalUnsafeMethods.allowSwimming(ObjectPtr, state);
         }
      
         public virtual string getState()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getState(ObjectPtr));
         }
      
         public virtual string getDamageLocation(Point3F pos)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getDamageLocation(ObjectPtr, pos.ToStruct()));
         }
      
         public virtual bool setArmThread(string name)
         {
            return InternalUnsafeMethods.setArmThread(ObjectPtr, name);
         }
      
         public virtual bool setActionThread(string name, bool hold = false, bool fsp = true)
         {
            return InternalUnsafeMethods.setActionThread(ObjectPtr, name, hold, fsp);
         }
      
         public virtual bool setControlObject(ShapeBase obj)
         {
            return InternalUnsafeMethods.setControlObject(ObjectPtr, obj.ObjectPtr);
         }
      
         public virtual int getControlObject()
         {
            return InternalUnsafeMethods.getControlObject(ObjectPtr);
         }
      
         public virtual void clearControlObject()
         {
            InternalUnsafeMethods.clearControlObject(ObjectPtr);
         }
      
         public virtual bool checkDismountPoint(Point3F oldPos, Point3F pos)
         {
            return InternalUnsafeMethods.checkDismountPoint(ObjectPtr, oldPos.ToStruct(), pos.ToStruct());
         }
      
         public virtual int getNumDeathAnimations()
         {
            return InternalUnsafeMethods.getNumDeathAnimations(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}