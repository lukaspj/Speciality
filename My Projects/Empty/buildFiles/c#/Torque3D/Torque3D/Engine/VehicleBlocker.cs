using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class VehicleBlocker : SceneObject
	{
		public VehicleBlocker(bool pRegister = false)
			: base(pRegister)
		{
		}

		public VehicleBlocker(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public VehicleBlocker(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public VehicleBlocker(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public VehicleBlocker(SimObject pObj) : base(pObj)
		{
		}

		public VehicleBlocker(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.VehicleBlocker_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _VehicleBlocker_create();
         private static _VehicleBlocker_create _VehicleBlocker_createFunc;
         internal static IntPtr VehicleBlocker_create()
         {
         	if (_VehicleBlocker_createFunc == null)
         	{
         		_VehicleBlocker_createFunc =
         			(_VehicleBlocker_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_VehicleBlocker_create"), typeof(_VehicleBlocker_create));
         	}
         
         	return  _VehicleBlocker_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public Point3F Dimensions
         {
         	get { return new Point3F(getFieldValue("Dimensions")); }
         	set { setFieldValue("Dimensions", value.ToString()); }
         }
      
      
      #endregion

	}
}