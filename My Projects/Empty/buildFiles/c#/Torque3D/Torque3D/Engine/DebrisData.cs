using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class DebrisData : GameBaseData
	{
		public DebrisData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public DebrisData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public DebrisData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public DebrisData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public DebrisData(SimObject pObj) : base(pObj)
		{
		}

		public DebrisData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.DebrisData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DebrisData_create();
         private static _DebrisData_create _DebrisData_createFunc;
         internal static IntPtr DebrisData_create()
         {
         	if (_DebrisData_createFunc == null)
         	{
         		_DebrisData_createFunc =
         			(_DebrisData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_DebrisData_create"), typeof(_DebrisData_create));
         	}
         
         	return  _DebrisData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string Texture
         {
         	get { return getFieldValue("Texture"); }
         	set { setFieldValue("Texture", value); }
         }
      
         public string ShapeFile
         {
         	get { return getFieldValue("ShapeFile"); }
         	set { setFieldValue("ShapeFile", value); }
         }
      
         public DynamicFieldVector<ParticleEmitterData> Emitters
         {
         	get { return new DynamicFieldVector<ParticleEmitterData>(this, "Emitters", 2, val => Sim.FindObject<ParticleEmitterData>(val), obj => obj.getId().ToString()); }
         }
      
         public ExplosionData Explosion
         {
         	get { return Sim.FindObject<ExplosionData>(getFieldValue("Explosion")); }
         	set { setFieldValue("Explosion", value.getId().ToString()); }
         }
      
         public float Elasticity
         {
         	get { return float.Parse(getFieldValue("Elasticity")); }
         	set { setFieldValue("Elasticity", value.ToString()); }
         }
      
         public float Friction
         {
         	get { return float.Parse(getFieldValue("Friction")); }
         	set { setFieldValue("Friction", value.ToString()); }
         }
      
         public int NumBounces
         {
         	get { return int.Parse(getFieldValue("NumBounces")); }
         	set { setFieldValue("NumBounces", value.ToString()); }
         }
      
         public int BounceVariance
         {
         	get { return int.Parse(getFieldValue("BounceVariance")); }
         	set { setFieldValue("BounceVariance", value.ToString()); }
         }
      
         public float MinSpinSpeed
         {
         	get { return float.Parse(getFieldValue("MinSpinSpeed")); }
         	set { setFieldValue("MinSpinSpeed", value.ToString()); }
         }
      
         public float MaxSpinSpeed
         {
         	get { return float.Parse(getFieldValue("MaxSpinSpeed")); }
         	set { setFieldValue("MaxSpinSpeed", value.ToString()); }
         }
      
         public float GravModifier
         {
         	get { return float.Parse(getFieldValue("GravModifier")); }
         	set { setFieldValue("GravModifier", value.ToString()); }
         }
      
         public float TerminalVelocity
         {
         	get { return float.Parse(getFieldValue("TerminalVelocity")); }
         	set { setFieldValue("TerminalVelocity", value.ToString()); }
         }
      
         public float Velocity
         {
         	get { return float.Parse(getFieldValue("Velocity")); }
         	set { setFieldValue("Velocity", value.ToString()); }
         }
      
         public float VelocityVariance
         {
         	get { return float.Parse(getFieldValue("VelocityVariance")); }
         	set { setFieldValue("VelocityVariance", value.ToString()); }
         }
      
         public float Lifetime
         {
         	get { return float.Parse(getFieldValue("Lifetime")); }
         	set { setFieldValue("Lifetime", value.ToString()); }
         }
      
         public float LifetimeVariance
         {
         	get { return float.Parse(getFieldValue("LifetimeVariance")); }
         	set { setFieldValue("LifetimeVariance", value.ToString()); }
         }
      
         public bool UseRadiusMass
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseRadiusMass")); }
         	set { setFieldValue("UseRadiusMass", value ? "1" : "0"); }
         }
      
         public float BaseRadius
         {
         	get { return float.Parse(getFieldValue("BaseRadius")); }
         	set { setFieldValue("BaseRadius", value.ToString()); }
         }
      
         public bool ExplodeOnMaxBounce
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ExplodeOnMaxBounce")); }
         	set { setFieldValue("ExplodeOnMaxBounce", value ? "1" : "0"); }
         }
      
         public bool StaticOnMaxBounce
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("StaticOnMaxBounce")); }
         	set { setFieldValue("StaticOnMaxBounce", value ? "1" : "0"); }
         }
      
         public bool SnapOnMaxBounce
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SnapOnMaxBounce")); }
         	set { setFieldValue("SnapOnMaxBounce", value ? "1" : "0"); }
         }
      
         public bool Fade
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Fade")); }
         	set { setFieldValue("Fade", value ? "1" : "0"); }
         }
      
         public bool IgnoreWater
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IgnoreWater")); }
         	set { setFieldValue("IgnoreWater", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}