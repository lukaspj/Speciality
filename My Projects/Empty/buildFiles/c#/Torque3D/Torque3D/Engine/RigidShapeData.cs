using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RigidShapeData : ShapeBaseData
	{
		public RigidShapeData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RigidShapeData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RigidShapeData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RigidShapeData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RigidShapeData(SimObject pObj) : base(pObj)
		{
		}

		public RigidShapeData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RigidShapeData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RigidShapeData_create();
         private static _RigidShapeData_create _RigidShapeData_createFunc;
         internal static IntPtr RigidShapeData_create()
         {
         	if (_RigidShapeData_createFunc == null)
         	{
         		_RigidShapeData_createFunc =
         			(_RigidShapeData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RigidShapeData_create"), typeof(_RigidShapeData_create));
         	}
         
         	return  _RigidShapeData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
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
      
         public float DragForce
         {
         	get { return float.Parse(getFieldValue("DragForce")); }
         	set { setFieldValue("DragForce", value.ToString()); }
         }
      
         public float VertFactor
         {
         	get { return float.Parse(getFieldValue("VertFactor")); }
         	set { setFieldValue("VertFactor", value.ToString()); }
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
      
         public ParticleEmitterData DustTrailEmitter
         {
         	get { return Sim.FindObject<ParticleEmitterData>(getFieldValue("DustTrailEmitter")); }
         	set { setFieldValue("DustTrailEmitter", value.getId().ToString()); }
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
      
         public SFXTrack SoftImpactSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("SoftImpactSound")); }
         	set { setFieldValue("SoftImpactSound", value.getId().ToString()); }
         }
      
         public SFXTrack HardImpactSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("HardImpactSound")); }
         	set { setFieldValue("HardImpactSound", value.getId().ToString()); }
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
      
         public SFXTrack ExitingWater
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("ExitingWater")); }
         	set { setFieldValue("ExitingWater", value.getId().ToString()); }
         }
      
         public SFXTrack ImpactWaterEasy
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("ImpactWaterEasy")); }
         	set { setFieldValue("ImpactWaterEasy", value.getId().ToString()); }
         }
      
         public SFXTrack ImpactWaterMedium
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("ImpactWaterMedium")); }
         	set { setFieldValue("ImpactWaterMedium", value.getId().ToString()); }
         }
      
         public SFXTrack ImpactWaterHard
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("ImpactWaterHard")); }
         	set { setFieldValue("ImpactWaterHard", value.getId().ToString()); }
         }
      
         public SFXTrack WaterWakeSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("WaterWakeSound")); }
         	set { setFieldValue("WaterWakeSound", value.getId().ToString()); }
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
      
      
      #endregion

	}
}