using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class HoverVehicle : Vehicle
	{
		public HoverVehicle(bool pRegister = false)
			: base(pRegister)
		{
		}

		public HoverVehicle(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public HoverVehicle(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public HoverVehicle(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public HoverVehicle(SimObject pObj) : base(pObj)
		{
		}

		public HoverVehicle(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.HoverVehicle_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _HoverVehicle_create();
         private static _HoverVehicle_create _HoverVehicle_createFunc;
         internal static IntPtr HoverVehicle_create()
         {
         	if (_HoverVehicle_createFunc == null)
         	{
         		_HoverVehicle_createFunc =
         			(_HoverVehicle_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_HoverVehicle_create"), typeof(_HoverVehicle_create));
         	}
         
         	return  _HoverVehicle_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}