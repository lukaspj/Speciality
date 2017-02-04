using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class WheeledVehicle : Vehicle
	{
		public WheeledVehicle(bool pRegister = false)
			: base(pRegister)
		{
		}

		public WheeledVehicle(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public WheeledVehicle(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public WheeledVehicle(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public WheeledVehicle(SimObject pObj) : base(pObj)
		{
		}

		public WheeledVehicle(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.WheeledVehicle_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setWheelSteering(IntPtr thisPtr, int wheel, float steering);
         private static _setWheelSteering _setWheelSteeringFunc;
         internal static bool setWheelSteering(IntPtr thisPtr, int wheel, float steering)
         {
         	if (_setWheelSteeringFunc == null)
         	{
         		_setWheelSteeringFunc =
         			(_setWheelSteering)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWheeledVehicle_setWheelSteering"), typeof(_setWheelSteering));
         	}
         
         	return  _setWheelSteeringFunc(thisPtr, wheel, steering);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setWheelPowered(IntPtr thisPtr, int wheel, bool powered);
         private static _setWheelPowered _setWheelPoweredFunc;
         internal static bool setWheelPowered(IntPtr thisPtr, int wheel, bool powered)
         {
         	if (_setWheelPoweredFunc == null)
         	{
         		_setWheelPoweredFunc =
         			(_setWheelPowered)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWheeledVehicle_setWheelPowered"), typeof(_setWheelPowered));
         	}
         
         	return  _setWheelPoweredFunc(thisPtr, wheel, powered);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setWheelTire(IntPtr thisPtr, int wheel, IntPtr tire);
         private static _setWheelTire _setWheelTireFunc;
         internal static bool setWheelTire(IntPtr thisPtr, int wheel, IntPtr tire)
         {
         	if (_setWheelTireFunc == null)
         	{
         		_setWheelTireFunc =
         			(_setWheelTire)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWheeledVehicle_setWheelTire"), typeof(_setWheelTire));
         	}
         
         	return  _setWheelTireFunc(thisPtr, wheel, tire);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setWheelSpring(IntPtr thisPtr, int wheel, IntPtr spring);
         private static _setWheelSpring _setWheelSpringFunc;
         internal static bool setWheelSpring(IntPtr thisPtr, int wheel, IntPtr spring)
         {
         	if (_setWheelSpringFunc == null)
         	{
         		_setWheelSpringFunc =
         			(_setWheelSpring)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWheeledVehicle_setWheelSpring"), typeof(_setWheelSpring));
         	}
         
         	return  _setWheelSpringFunc(thisPtr, wheel, spring);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getWheelCount(IntPtr thisPtr);
         private static _getWheelCount _getWheelCountFunc;
         internal static int getWheelCount(IntPtr thisPtr)
         {
         	if (_getWheelCountFunc == null)
         	{
         		_getWheelCountFunc =
         			(_getWheelCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWheeledVehicle_getWheelCount"), typeof(_getWheelCount));
         	}
         
         	return  _getWheelCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _WheeledVehicle_create();
         private static _WheeledVehicle_create _WheeledVehicle_createFunc;
         internal static IntPtr WheeledVehicle_create()
         {
         	if (_WheeledVehicle_createFunc == null)
         	{
         		_WheeledVehicle_createFunc =
         			(_WheeledVehicle_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_WheeledVehicle_create"), typeof(_WheeledVehicle_create));
         	}
         
         	return  _WheeledVehicle_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool setWheelSteering(int wheel, float steering)
         {
            return InternalUnsafeMethods.setWheelSteering(ObjectPtr, wheel, steering);
         }
      
         public virtual bool setWheelPowered(int wheel, bool powered)
         {
            return InternalUnsafeMethods.setWheelPowered(ObjectPtr, wheel, powered);
         }
      
         public virtual bool setWheelTire(int wheel, WheeledVehicleTire tire)
         {
            return InternalUnsafeMethods.setWheelTire(ObjectPtr, wheel, tire.ObjectPtr);
         }
      
         public virtual bool setWheelSpring(int wheel, WheeledVehicleSpring spring)
         {
            return InternalUnsafeMethods.setWheelSpring(ObjectPtr, wheel, spring.ObjectPtr);
         }
      
         public virtual int getWheelCount()
         {
            return InternalUnsafeMethods.getWheelCount(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}