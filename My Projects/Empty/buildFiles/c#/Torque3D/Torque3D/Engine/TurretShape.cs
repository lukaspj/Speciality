using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class TurretShape : Item
	{
		public TurretShape(bool pRegister = false)
			: base(pRegister)
		{
		}

		public TurretShape(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public TurretShape(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public TurretShape(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public TurretShape(SimObject pObj) : base(pObj)
		{
		}

		public TurretShape(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.TurretShape_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getAllowManualRotation(IntPtr thisPtr);
         private static _getAllowManualRotation _getAllowManualRotationFunc;
         internal static bool getAllowManualRotation(IntPtr thisPtr)
         {
         	if (_getAllowManualRotationFunc == null)
         	{
         		_getAllowManualRotationFunc =
         			(_getAllowManualRotation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTurretShape_getAllowManualRotation"), typeof(_getAllowManualRotation));
         	}
         
         	return  _getAllowManualRotationFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setAllowManualRotation(IntPtr thisPtr, bool allow);
         private static _setAllowManualRotation _setAllowManualRotationFunc;
         internal static void setAllowManualRotation(IntPtr thisPtr, bool allow)
         {
         	if (_setAllowManualRotationFunc == null)
         	{
         		_setAllowManualRotationFunc =
         			(_setAllowManualRotation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTurretShape_setAllowManualRotation"), typeof(_setAllowManualRotation));
         	}
         
         	 _setAllowManualRotationFunc(thisPtr, allow);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getAllowManualFire(IntPtr thisPtr);
         private static _getAllowManualFire _getAllowManualFireFunc;
         internal static bool getAllowManualFire(IntPtr thisPtr)
         {
         	if (_getAllowManualFireFunc == null)
         	{
         		_getAllowManualFireFunc =
         			(_getAllowManualFire)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTurretShape_getAllowManualFire"), typeof(_getAllowManualFire));
         	}
         
         	return  _getAllowManualFireFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setAllowManualFire(IntPtr thisPtr, bool allow);
         private static _setAllowManualFire _setAllowManualFireFunc;
         internal static void setAllowManualFire(IntPtr thisPtr, bool allow)
         {
         	if (_setAllowManualFireFunc == null)
         	{
         		_setAllowManualFireFunc =
         			(_setAllowManualFire)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTurretShape_setAllowManualFire"), typeof(_setAllowManualFire));
         	}
         
         	 _setAllowManualFireFunc(thisPtr, allow);
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
         				"fnTurretShape_getState"), typeof(_getState));
         	}
         
         	return  _getStateFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getTurretEulerRotation(IntPtr thisPtr);
         private static _getTurretEulerRotation _getTurretEulerRotationFunc;
         internal static InternalPoint3FStruct getTurretEulerRotation(IntPtr thisPtr)
         {
         	if (_getTurretEulerRotationFunc == null)
         	{
         		_getTurretEulerRotationFunc =
         			(_getTurretEulerRotation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTurretShape_getTurretEulerRotation"), typeof(_getTurretEulerRotation));
         	}
         
         	return  _getTurretEulerRotationFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setTurretEulerRotation(IntPtr thisPtr, InternalPoint3FStruct rot);
         private static _setTurretEulerRotation _setTurretEulerRotationFunc;
         internal static void setTurretEulerRotation(IntPtr thisPtr, InternalPoint3FStruct rot)
         {
         	if (_setTurretEulerRotationFunc == null)
         	{
         		_setTurretEulerRotationFunc =
         			(_setTurretEulerRotation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTurretShape_setTurretEulerRotation"), typeof(_setTurretEulerRotation));
         	}
         
         	 _setTurretEulerRotationFunc(thisPtr, rot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _doRespawn(IntPtr thisPtr);
         private static _doRespawn _doRespawnFunc;
         internal static bool doRespawn(IntPtr thisPtr)
         {
         	if (_doRespawnFunc == null)
         	{
         		_doRespawnFunc =
         			(_doRespawn)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTurretShape_doRespawn"), typeof(_doRespawn));
         	}
         
         	return  _doRespawnFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TurretShape_create();
         private static _TurretShape_create _TurretShape_createFunc;
         internal static IntPtr TurretShape_create()
         {
         	if (_TurretShape_createFunc == null)
         	{
         		_TurretShape_createFunc =
         			(_TurretShape_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_TurretShape_create"), typeof(_TurretShape_create));
         	}
         
         	return  _TurretShape_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool getAllowManualRotation()
         {
            return InternalUnsafeMethods.getAllowManualRotation(ObjectPtr);
         }
      
         public virtual void setAllowManualRotation(bool allow)
         {
            InternalUnsafeMethods.setAllowManualRotation(ObjectPtr, allow);
         }
      
         public virtual bool getAllowManualFire()
         {
            return InternalUnsafeMethods.getAllowManualFire(ObjectPtr);
         }
      
         public virtual void setAllowManualFire(bool allow)
         {
            InternalUnsafeMethods.setAllowManualFire(ObjectPtr, allow);
         }
      
         public virtual string getState()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getState(ObjectPtr));
         }
      
         public virtual Point3F getTurretEulerRotation()
         {
            return new Point3F(InternalUnsafeMethods.getTurretEulerRotation(ObjectPtr));
         }
      
         public virtual void setTurretEulerRotation(Point3F rot)
         {
            InternalUnsafeMethods.setTurretEulerRotation(ObjectPtr, rot.ToStruct());
         }
      
         public virtual bool doRespawn()
         {
            return InternalUnsafeMethods.doRespawn(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool Respawn
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Respawn")); }
         	set { setFieldValue("Respawn", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}