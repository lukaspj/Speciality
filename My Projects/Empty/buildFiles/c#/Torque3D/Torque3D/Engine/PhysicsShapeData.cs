using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class PhysicsShapeData : GameBaseData
	{
		public PhysicsShapeData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public PhysicsShapeData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public PhysicsShapeData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public PhysicsShapeData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public PhysicsShapeData(SimObject pObj) : base(pObj)
		{
		}

		public PhysicsShapeData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.PhysicsShapeData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _PhysicsShapeData_create();
         private static _PhysicsShapeData_create _PhysicsShapeData_createFunc;
         internal static IntPtr PhysicsShapeData_create()
         {
         	if (_PhysicsShapeData_createFunc == null)
         	{
         		_PhysicsShapeData_createFunc =
         			(_PhysicsShapeData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PhysicsShapeData_create"), typeof(_PhysicsShapeData_create));
         	}
         
         	return  _PhysicsShapeData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string ShapeName
         {
         	get { return getFieldValue("ShapeName"); }
         	set { setFieldValue("ShapeName", value); }
         }
      
         public PhysicsDebrisData Debris
         {
         	get { return Sim.FindObject<PhysicsDebrisData>(getFieldValue("Debris")); }
         	set { setFieldValue("Debris", value.getId().ToString()); }
         }
      
         public ExplosionData Explosion
         {
         	get { return Sim.FindObject<ExplosionData>(getFieldValue("Explosion")); }
         	set { setFieldValue("Explosion", value.getId().ToString()); }
         }
      
         public PhysicsShapeData DestroyedShape
         {
         	get { return Sim.FindObject<PhysicsShapeData>(getFieldValue("DestroyedShape")); }
         	set { setFieldValue("DestroyedShape", value.getId().ToString()); }
         }
      
         public float Mass
         {
         	get { return float.Parse(getFieldValue("Mass")); }
         	set { setFieldValue("Mass", value.ToString()); }
         }
      
         public float Friction
         {
         	get { return float.Parse(getFieldValue("Friction")); }
         	set { setFieldValue("Friction", value.ToString()); }
         }
      
         public float StaticFriction
         {
         	get { return float.Parse(getFieldValue("StaticFriction")); }
         	set { setFieldValue("StaticFriction", value.ToString()); }
         }
      
         public float Restitution
         {
         	get { return float.Parse(getFieldValue("Restitution")); }
         	set { setFieldValue("Restitution", value.ToString()); }
         }
      
         public float LinearDamping
         {
         	get { return float.Parse(getFieldValue("LinearDamping")); }
         	set { setFieldValue("LinearDamping", value.ToString()); }
         }
      
         public float AngularDamping
         {
         	get { return float.Parse(getFieldValue("AngularDamping")); }
         	set { setFieldValue("AngularDamping", value.ToString()); }
         }
      
         public float LinearSleepThreshold
         {
         	get { return float.Parse(getFieldValue("LinearSleepThreshold")); }
         	set { setFieldValue("LinearSleepThreshold", value.ToString()); }
         }
      
         public float AngularSleepThreshold
         {
         	get { return float.Parse(getFieldValue("AngularSleepThreshold")); }
         	set { setFieldValue("AngularSleepThreshold", value.ToString()); }
         }
      
         public float WaterDampingScale
         {
         	get { return float.Parse(getFieldValue("WaterDampingScale")); }
         	set { setFieldValue("WaterDampingScale", value.ToString()); }
         }
      
         public float BuoyancyDensity
         {
         	get { return float.Parse(getFieldValue("BuoyancyDensity")); }
         	set { setFieldValue("BuoyancyDensity", value.ToString()); }
         }
      
         public PhysicsSimType SimType
         {
         	get { return (PhysicsSimType)Enum.Parse(typeof(PhysicsSimType), getFieldValue("SimType"), true); }
         	set { setFieldValue("SimType", value.ToString()); }
         }
      
      
      #endregion

	}
}