using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class VehicleData : ShapeBaseData
	{
		public VehicleData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public VehicleData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public VehicleData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public VehicleData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public VehicleData(SimObject pObj) : base(pObj)
		{
		}

		public VehicleData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.VehicleData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _VehicleData_create();
         private static _VehicleData_create _VehicleData_createFunc;
         internal static IntPtr VehicleData_create()
         {
         	if (_VehicleData_createFunc == null)
         	{
         		_VehicleData_createFunc =
         			(_VehicleData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_VehicleData_create"), typeof(_VehicleData_create));
         	}
         
         	return  _VehicleData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public bool EnablePhysicsRep
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("EnablePhysicsRep")); }
         	set { setFieldValue("EnablePhysicsRep", value ? "1" : "0"); }
         }
      
         public float JetForce
         {
         	get { return float.Parse(getFieldValue("JetForce")); }
         	set { setFieldValue("JetForce", value.ToString()); }
         }
      
         public float JetEnergyDrain
         {
         	get { return float.Parse(getFieldValue("JetEnergyDrain")); }
         	set { setFieldValue("JetEnergyDrain", value.ToString()); }
         }
      
         public float MinJetEnergy
         {
         	get { return float.Parse(getFieldValue("MinJetEnergy")); }
         	set { setFieldValue("MinJetEnergy", value.ToString()); }
         }
      
         public float SteeringReturn
         {
         	get { return float.Parse(getFieldValue("SteeringReturn")); }
         	set { setFieldValue("SteeringReturn", value.ToString()); }
         }
      
         public float SteeringReturnSpeedScale
         {
         	get { return float.Parse(getFieldValue("SteeringReturnSpeedScale")); }
         	set { setFieldValue("SteeringReturnSpeedScale", value.ToString()); }
         }
      
         public bool PowerSteering
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("PowerSteering")); }
         	set { setFieldValue("PowerSteering", value ? "1" : "0"); }
         }
      
         public Point3F MassCenter
         {
         	get { return new Point3F(getFieldValue("MassCenter")); }
         	set { setFieldValue("MassCenter", value.ToString()); }
         }
      
         public Point3F MassBox
         {
         	get { return new Point3F(getFieldValue("MassBox")); }
         	set { setFieldValue("MassBox", value.ToString()); }
         }
      
         public float BodyRestitution
         {
         	get { return float.Parse(getFieldValue("BodyRestitution")); }
         	set { setFieldValue("BodyRestitution", value.ToString()); }
         }
      
         public float BodyFriction
         {
         	get { return float.Parse(getFieldValue("BodyFriction")); }
         	set { setFieldValue("BodyFriction", value.ToString()); }
         }
      
         public SFXProfile SoftImpactSound
         {
         	get { return Sim.FindObject<SFXProfile>(getFieldValue("SoftImpactSound")); }
         	set { setFieldValue("SoftImpactSound", value.getId().ToString()); }
         }
      
         public SFXProfile HardImpactSound
         {
         	get { return Sim.FindObject<SFXProfile>(getFieldValue("HardImpactSound")); }
         	set { setFieldValue("HardImpactSound", value.getId().ToString()); }
         }
      
         public float MinImpactSpeed
         {
         	get { return float.Parse(getFieldValue("MinImpactSpeed")); }
         	set { setFieldValue("MinImpactSpeed", value.ToString()); }
         }
      
         public float SoftImpactSpeed
         {
         	get { return float.Parse(getFieldValue("SoftImpactSpeed")); }
         	set { setFieldValue("SoftImpactSpeed", value.ToString()); }
         }
      
         public float HardImpactSpeed
         {
         	get { return float.Parse(getFieldValue("HardImpactSpeed")); }
         	set { setFieldValue("HardImpactSpeed", value.ToString()); }
         }
      
         public float MinRollSpeed
         {
         	get { return float.Parse(getFieldValue("MinRollSpeed")); }
         	set { setFieldValue("MinRollSpeed", value.ToString()); }
         }
      
         public float MaxSteeringAngle
         {
         	get { return float.Parse(getFieldValue("MaxSteeringAngle")); }
         	set { setFieldValue("MaxSteeringAngle", value.ToString()); }
         }
      
         public float MaxDrag
         {
         	get { return float.Parse(getFieldValue("MaxDrag")); }
         	set { setFieldValue("MaxDrag", value.ToString()); }
         }
      
         public float MinDrag
         {
         	get { return float.Parse(getFieldValue("MinDrag")); }
         	set { setFieldValue("MinDrag", value.ToString()); }
         }
      
         public int Integration
         {
         	get { return int.Parse(getFieldValue("Integration")); }
         	set { setFieldValue("Integration", value.ToString()); }
         }
      
         public float CollisionTol
         {
         	get { return float.Parse(getFieldValue("CollisionTol")); }
         	set { setFieldValue("CollisionTol", value.ToString()); }
         }
      
         public float ContactTol
         {
         	get { return float.Parse(getFieldValue("ContactTol")); }
         	set { setFieldValue("ContactTol", value.ToString()); }
         }
      
         public bool CameraRoll
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CameraRoll")); }
         	set { setFieldValue("CameraRoll", value ? "1" : "0"); }
         }
      
         public float CameraLag
         {
         	get { return float.Parse(getFieldValue("CameraLag")); }
         	set { setFieldValue("CameraLag", value.ToString()); }
         }
      
         public float CameraDecay
         {
         	get { return float.Parse(getFieldValue("CameraDecay")); }
         	set { setFieldValue("CameraDecay", value.ToString()); }
         }
      
         public float CameraOffset
         {
         	get { return float.Parse(getFieldValue("CameraOffset")); }
         	set { setFieldValue("CameraOffset", value.ToString()); }
         }
      
         public ParticleEmitterData DustEmitter
         {
         	get { return Sim.FindObject<ParticleEmitterData>(getFieldValue("DustEmitter")); }
         	set { setFieldValue("DustEmitter", value.getId().ToString()); }
         }
      
         public float TriggerDustHeight
         {
         	get { return float.Parse(getFieldValue("TriggerDustHeight")); }
         	set { setFieldValue("TriggerDustHeight", value.ToString()); }
         }
      
         public float DustHeight
         {
         	get { return float.Parse(getFieldValue("DustHeight")); }
         	set { setFieldValue("DustHeight", value.ToString()); }
         }
      
         public DynamicFieldVector<ParticleEmitterData> DamageEmitter
         {
         	get { return new DynamicFieldVector<ParticleEmitterData>(this, "DamageEmitter", 3, val => Sim.FindObject<ParticleEmitterData>(val), obj => obj.getId().ToString()); }
         }
      
         public DynamicFieldVector<Point3F> DamageEmitterOffset
         {
         	get { return new DynamicFieldVector<Point3F>(this, "DamageEmitterOffset", 2, val => new Point3F(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> DamageLevelTolerance
         {
         	get { return new DynamicFieldVector<float>(this, "DamageLevelTolerance", 2, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public float NumDmgEmitterAreas
         {
         	get { return float.Parse(getFieldValue("NumDmgEmitterAreas")); }
         	set { setFieldValue("NumDmgEmitterAreas", value.ToString()); }
         }
      
         public DynamicFieldVector<ParticleEmitterData> SplashEmitter
         {
         	get { return new DynamicFieldVector<ParticleEmitterData>(this, "SplashEmitter", 2, val => Sim.FindObject<ParticleEmitterData>(val), obj => obj.getId().ToString()); }
         }
      
         public float SplashFreqMod
         {
         	get { return float.Parse(getFieldValue("SplashFreqMod")); }
         	set { setFieldValue("SplashFreqMod", value.ToString()); }
         }
      
         public float SplashVelEpsilon
         {
         	get { return float.Parse(getFieldValue("SplashVelEpsilon")); }
         	set { setFieldValue("SplashVelEpsilon", value.ToString()); }
         }
      
         public float ExitSplashSoundVelocity
         {
         	get { return float.Parse(getFieldValue("ExitSplashSoundVelocity")); }
         	set { setFieldValue("ExitSplashSoundVelocity", value.ToString()); }
         }
      
         public float SoftSplashSoundVelocity
         {
         	get { return float.Parse(getFieldValue("SoftSplashSoundVelocity")); }
         	set { setFieldValue("SoftSplashSoundVelocity", value.ToString()); }
         }
      
         public float MediumSplashSoundVelocity
         {
         	get { return float.Parse(getFieldValue("MediumSplashSoundVelocity")); }
         	set { setFieldValue("MediumSplashSoundVelocity", value.ToString()); }
         }
      
         public float HardSplashSoundVelocity
         {
         	get { return float.Parse(getFieldValue("HardSplashSoundVelocity")); }
         	set { setFieldValue("HardSplashSoundVelocity", value.ToString()); }
         }
      
         public SFXProfile ExitingWater
         {
         	get { return Sim.FindObject<SFXProfile>(getFieldValue("ExitingWater")); }
         	set { setFieldValue("ExitingWater", value.getId().ToString()); }
         }
      
         public SFXProfile ImpactWaterEasy
         {
         	get { return Sim.FindObject<SFXProfile>(getFieldValue("ImpactWaterEasy")); }
         	set { setFieldValue("ImpactWaterEasy", value.getId().ToString()); }
         }
      
         public SFXProfile ImpactWaterMedium
         {
         	get { return Sim.FindObject<SFXProfile>(getFieldValue("ImpactWaterMedium")); }
         	set { setFieldValue("ImpactWaterMedium", value.getId().ToString()); }
         }
      
         public SFXProfile ImpactWaterHard
         {
         	get { return Sim.FindObject<SFXProfile>(getFieldValue("ImpactWaterHard")); }
         	set { setFieldValue("ImpactWaterHard", value.getId().ToString()); }
         }
      
         public SFXProfile WaterWakeSound
         {
         	get { return Sim.FindObject<SFXProfile>(getFieldValue("WaterWakeSound")); }
         	set { setFieldValue("WaterWakeSound", value.getId().ToString()); }
         }
      
         public float CollDamageThresholdVel
         {
         	get { return float.Parse(getFieldValue("CollDamageThresholdVel")); }
         	set { setFieldValue("CollDamageThresholdVel", value.ToString()); }
         }
      
         public float CollDamageMultiplier
         {
         	get { return float.Parse(getFieldValue("CollDamageMultiplier")); }
         	set { setFieldValue("CollDamageMultiplier", value.ToString()); }
         }
      
      
      #endregion

	}
}