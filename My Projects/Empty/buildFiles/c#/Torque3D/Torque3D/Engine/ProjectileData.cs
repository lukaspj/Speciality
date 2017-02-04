using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ProjectileData : GameBaseData
	{
		public ProjectileData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ProjectileData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ProjectileData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ProjectileData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ProjectileData(SimObject pObj) : base(pObj)
		{
		}

		public ProjectileData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ProjectileData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ProjectileData_create();
         private static _ProjectileData_create _ProjectileData_createFunc;
         internal static IntPtr ProjectileData_create()
         {
         	if (_ProjectileData_createFunc == null)
         	{
         		_ProjectileData_createFunc =
         			(_ProjectileData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ProjectileData_create"), typeof(_ProjectileData_create));
         	}
         
         	return  _ProjectileData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public ParticleEmitterData ParticleEmitter
         {
         	get { return Sim.FindObject<ParticleEmitterData>(getFieldValue("ParticleEmitter")); }
         	set { setFieldValue("ParticleEmitter", value.getId().ToString()); }
         }
      
         public ParticleEmitterData ParticleWaterEmitter
         {
         	get { return Sim.FindObject<ParticleEmitterData>(getFieldValue("ParticleWaterEmitter")); }
         	set { setFieldValue("ParticleWaterEmitter", value.getId().ToString()); }
         }
      
         public string ProjectileShapeName
         {
         	get { return getFieldValue("ProjectileShapeName"); }
         	set { setFieldValue("ProjectileShapeName", value); }
         }
      
         public Point3F Scale
         {
         	get { return new Point3F(getFieldValue("Scale")); }
         	set { setFieldValue("Scale", value.ToString()); }
         }
      
         public SFXTrack Sound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("Sound")); }
         	set { setFieldValue("Sound", value.getId().ToString()); }
         }
      
         public ExplosionData Explosion
         {
         	get { return Sim.FindObject<ExplosionData>(getFieldValue("Explosion")); }
         	set { setFieldValue("Explosion", value.getId().ToString()); }
         }
      
         public ExplosionData WaterExplosion
         {
         	get { return Sim.FindObject<ExplosionData>(getFieldValue("WaterExplosion")); }
         	set { setFieldValue("WaterExplosion", value.getId().ToString()); }
         }
      
         public SplashData Splash
         {
         	get { return Sim.FindObject<SplashData>(getFieldValue("Splash")); }
         	set { setFieldValue("Splash", value.getId().ToString()); }
         }
      
         public DecalData Decal
         {
         	get { return Sim.FindObject<DecalData>(getFieldValue("Decal")); }
         	set { setFieldValue("Decal", value.getId().ToString()); }
         }
      
         public LightDescription LightDesc
         {
         	get { return Sim.FindObject<LightDescription>(getFieldValue("LightDesc")); }
         	set { setFieldValue("LightDesc", value.getId().ToString()); }
         }
      
         public bool IsBallistic
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsBallistic")); }
         	set { setFieldValue("IsBallistic", value ? "1" : "0"); }
         }
      
         public float VelInheritFactor
         {
         	get { return float.Parse(getFieldValue("VelInheritFactor")); }
         	set { setFieldValue("VelInheritFactor", value.ToString()); }
         }
      
         public float MuzzleVelocity
         {
         	get { return float.Parse(getFieldValue("MuzzleVelocity")); }
         	set { setFieldValue("MuzzleVelocity", value.ToString()); }
         }
      
         public float ImpactForce
         {
         	get { return float.Parse(getFieldValue("ImpactForce")); }
         	set { setFieldValue("ImpactForce", value.ToString()); }
         }
      
         public int Lifetime
         {
         	get { return int.Parse(getFieldValue("Lifetime")); }
         	set { setFieldValue("Lifetime", value.ToString()); }
         }
      
         public int ArmingDelay
         {
         	get { return int.Parse(getFieldValue("ArmingDelay")); }
         	set { setFieldValue("ArmingDelay", value.ToString()); }
         }
      
         public int FadeDelay
         {
         	get { return int.Parse(getFieldValue("FadeDelay")); }
         	set { setFieldValue("FadeDelay", value.ToString()); }
         }
      
         public float BounceElasticity
         {
         	get { return float.Parse(getFieldValue("BounceElasticity")); }
         	set { setFieldValue("BounceElasticity", value.ToString()); }
         }
      
         public float BounceFriction
         {
         	get { return float.Parse(getFieldValue("BounceFriction")); }
         	set { setFieldValue("BounceFriction", value.ToString()); }
         }
      
         public float GravityMod
         {
         	get { return float.Parse(getFieldValue("GravityMod")); }
         	set { setFieldValue("GravityMod", value.ToString()); }
         }
      
      
      #endregion

	}
}