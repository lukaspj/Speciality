using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class WheeledVehicleTire : SimDataBlock
	{
		public WheeledVehicleTire(bool pRegister = false)
			: base(pRegister)
		{
		}

		public WheeledVehicleTire(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public WheeledVehicleTire(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public WheeledVehicleTire(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public WheeledVehicleTire(SimObject pObj) : base(pObj)
		{
		}

		public WheeledVehicleTire(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.WheeledVehicleTire_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _WheeledVehicleTire_create();
         private static _WheeledVehicleTire_create _WheeledVehicleTire_createFunc;
         internal static IntPtr WheeledVehicleTire_create()
         {
         	if (_WheeledVehicleTire_createFunc == null)
         	{
         		_WheeledVehicleTire_createFunc =
         			(_WheeledVehicleTire_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_WheeledVehicleTire_create"), typeof(_WheeledVehicleTire_create));
         	}
         
         	return  _WheeledVehicleTire_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string ShapeFile
         {
         	get { return getFieldValue("ShapeFile"); }
         	set { setFieldValue("ShapeFile", value); }
         }
      
         public float Mass
         {
         	get { return float.Parse(getFieldValue("Mass")); }
         	set { setFieldValue("Mass", value.ToString()); }
         }
      
         public float Radius
         {
         	get { return float.Parse(getFieldValue("Radius")); }
         	set { setFieldValue("Radius", value.ToString()); }
         }
      
         public float StaticFriction
         {
         	get { return float.Parse(getFieldValue("StaticFriction")); }
         	set { setFieldValue("StaticFriction", value.ToString()); }
         }
      
         public float KineticFriction
         {
         	get { return float.Parse(getFieldValue("KineticFriction")); }
         	set { setFieldValue("KineticFriction", value.ToString()); }
         }
      
         public float Restitution
         {
         	get { return float.Parse(getFieldValue("Restitution")); }
         	set { setFieldValue("Restitution", value.ToString()); }
         }
      
         public float LateralForce
         {
         	get { return float.Parse(getFieldValue("LateralForce")); }
         	set { setFieldValue("LateralForce", value.ToString()); }
         }
      
         public float LateralDamping
         {
         	get { return float.Parse(getFieldValue("LateralDamping")); }
         	set { setFieldValue("LateralDamping", value.ToString()); }
         }
      
         public float LateralRelaxation
         {
         	get { return float.Parse(getFieldValue("LateralRelaxation")); }
         	set { setFieldValue("LateralRelaxation", value.ToString()); }
         }
      
         public float LongitudinalForce
         {
         	get { return float.Parse(getFieldValue("LongitudinalForce")); }
         	set { setFieldValue("LongitudinalForce", value.ToString()); }
         }
      
         public float LongitudinalDamping
         {
         	get { return float.Parse(getFieldValue("LongitudinalDamping")); }
         	set { setFieldValue("LongitudinalDamping", value.ToString()); }
         }
      
         public float LongitudinalRelaxation
         {
         	get { return float.Parse(getFieldValue("LongitudinalRelaxation")); }
         	set { setFieldValue("LongitudinalRelaxation", value.ToString()); }
         }
      
      
      #endregion

	}
}