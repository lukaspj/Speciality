using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class FlyingVehicle : Vehicle
	{
		public FlyingVehicle(bool pRegister = false)
			: base(pRegister)
		{
		}

		public FlyingVehicle(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public FlyingVehicle(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public FlyingVehicle(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public FlyingVehicle(SimObject pObj) : base(pObj)
		{
		}

		public FlyingVehicle(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.FlyingVehicle_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _useCreateHeight(IntPtr thisPtr, bool enabled);
         private static _useCreateHeight _useCreateHeightFunc;
         internal static void useCreateHeight(IntPtr thisPtr, bool enabled)
         {
         	if (_useCreateHeightFunc == null)
         	{
         		_useCreateHeightFunc =
         			(_useCreateHeight)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnFlyingVehicle_useCreateHeight"), typeof(_useCreateHeight));
         	}
         
         	 _useCreateHeightFunc(thisPtr, enabled);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FlyingVehicle_create();
         private static _FlyingVehicle_create _FlyingVehicle_createFunc;
         internal static IntPtr FlyingVehicle_create()
         {
         	if (_FlyingVehicle_createFunc == null)
         	{
         		_FlyingVehicle_createFunc =
         			(_FlyingVehicle_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_FlyingVehicle_create"), typeof(_FlyingVehicle_create));
         	}
         
         	return  _FlyingVehicle_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void useCreateHeight(bool enabled)
         {
            InternalUnsafeMethods.useCreateHeight(ObjectPtr, enabled);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}