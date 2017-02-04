using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class WheeledVehicleSpring : SimDataBlock
	{
		public WheeledVehicleSpring(bool pRegister = false)
			: base(pRegister)
		{
		}

		public WheeledVehicleSpring(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public WheeledVehicleSpring(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public WheeledVehicleSpring(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public WheeledVehicleSpring(SimObject pObj) : base(pObj)
		{
		}

		public WheeledVehicleSpring(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.WheeledVehicleSpring_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _WheeledVehicleSpring_create();
         private static _WheeledVehicleSpring_create _WheeledVehicleSpring_createFunc;
         internal static IntPtr WheeledVehicleSpring_create()
         {
         	if (_WheeledVehicleSpring_createFunc == null)
         	{
         		_WheeledVehicleSpring_createFunc =
         			(_WheeledVehicleSpring_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_WheeledVehicleSpring_create"), typeof(_WheeledVehicleSpring_create));
         	}
         
         	return  _WheeledVehicleSpring_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float Length
         {
         	get { return float.Parse(getFieldValue("Length")); }
         	set { setFieldValue("Length", value.ToString()); }
         }
      
         public float Force
         {
         	get { return float.Parse(getFieldValue("Force")); }
         	set { setFieldValue("Force", value.ToString()); }
         }
      
         public float Damping
         {
         	get { return float.Parse(getFieldValue("Damping")); }
         	set { setFieldValue("Damping", value.ToString()); }
         }
      
         public float AntiSwayForce
         {
         	get { return float.Parse(getFieldValue("AntiSwayForce")); }
         	set { setFieldValue("AntiSwayForce", value.ToString()); }
         }
      
      
      #endregion

	}
}