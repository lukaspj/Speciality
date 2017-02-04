using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class PlayerData : ShapeBaseData
	{
		public PlayerData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public PlayerData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public PlayerData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public PlayerData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public PlayerData(SimObject pObj) : base(pObj)
		{
		}

		public PlayerData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.PlayerData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _PlayerData_create();
         private static _PlayerData_create _PlayerData_createFunc;
         internal static IntPtr PlayerData_create()
         {
         	if (_PlayerData_createFunc == null)
         	{
         		_PlayerData_createFunc =
         			(_PlayerData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PlayerData_create"), typeof(_PlayerData_create));
         	}
         
         	return  _PlayerData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float PickupRadius
         {
         	get { return float.Parse(getFieldValue("PickupRadius")); }
         	set { setFieldValue("PickupRadius", value.ToString()); }
         }
      
         public float MaxTimeScale
         {
         	get { return float.Parse(getFieldValue("MaxTimeScale")); }
         	set { setFieldValue("MaxTimeScale", value.ToString()); }
         }
      
         public bool RenderFirstPerson
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderFirstPerson")); }
         	set { setFieldValue("RenderFirstPerson", value ? "1" : "0"); }
         }
      
         public bool FirstPersonShadows
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FirstPersonShadows")); }
         	set { setFieldValue("FirstPersonShadows", value ? "1" : "0"); }
         }
      
         public float MinLookAngle
         {
         	get { return float.Parse(getFieldValue("MinLookAngle")); }
         	set { setFieldValue("MinLookAngle", value.ToString()); }
         }
      
         public float MaxLookAngle
         {
         	get { return float.Parse(getFieldValue("MaxLookAngle")); }
         	set { setFieldValue("MaxLookAngle", value.ToString()); }
         }
      
         public float MaxFreelookAngle
         {
         	get { return float.Parse(getFieldValue("MaxFreelookAngle")); }
         	set { setFieldValue("MaxFreelookAngle", value.ToString()); }
         }
      
         public float MaxStepHeight
         {
         	get { return float.Parse(getFieldValue("MaxStepHeight")); }
         	set { setFieldValue("MaxStepHeight", value.ToString()); }
         }
      
         public float RunForce
         {
         	get { return float.Parse(getFieldValue("RunForce")); }
         	set { setFieldValue("RunForce", value.ToString()); }
         }
      
         public float RunEnergyDrain
         {
         	get { return float.Parse(getFieldValue("RunEnergyDrain")); }
         	set { setFieldValue("RunEnergyDrain", value.ToString()); }
         }
      
         public float MinRunEnergy
         {
         	get { return float.Parse(getFieldValue("MinRunEnergy")); }
         	set { setFieldValue("MinRunEnergy", value.ToString()); }
         }
      
         public float MaxForwardSpeed
         {
         	get { return float.Parse(getFieldValue("MaxForwardSpeed")); }
         	set { setFieldValue("MaxForwardSpeed", value.ToString()); }
         }
      
         public float MaxBackwardSpeed
         {
         	get { return float.Parse(getFieldValue("MaxBackwardSpeed")); }
         	set { setFieldValue("MaxBackwardSpeed", value.ToString()); }
         }
      
         public float MaxSideSpeed
         {
         	get { return float.Parse(getFieldValue("MaxSideSpeed")); }
         	set { setFieldValue("MaxSideSpeed", value.ToString()); }
         }
      
         public float RunSurfaceAngle
         {
         	get { return float.Parse(getFieldValue("RunSurfaceAngle")); }
         	set { setFieldValue("RunSurfaceAngle", value.ToString()); }
         }
      
         public float MinImpactSpeed
         {
         	get { return float.Parse(getFieldValue("MinImpactSpeed")); }
         	set { setFieldValue("MinImpactSpeed", value.ToString()); }
         }
      
         public float MinLateralImpactSpeed
         {
         	get { return float.Parse(getFieldValue("MinLateralImpactSpeed")); }
         	set { setFieldValue("MinLateralImpactSpeed", value.ToString()); }
         }
      
         public float HorizMaxSpeed
         {
         	get { return float.Parse(getFieldValue("HorizMaxSpeed")); }
         	set { setFieldValue("HorizMaxSpeed", value.ToString()); }
         }
      
         public float HorizResistSpeed
         {
         	get { return float.Parse(getFieldValue("HorizResistSpeed")); }
         	set { setFieldValue("HorizResistSpeed", value.ToString()); }
         }
      
         public float HorizResistFactor
         {
         	get { return float.Parse(getFieldValue("HorizResistFactor")); }
         	set { setFieldValue("HorizResistFactor", value.ToString()); }
         }
      
         public float UpMaxSpeed
         {
         	get { return float.Parse(getFieldValue("UpMaxSpeed")); }
         	set { setFieldValue("UpMaxSpeed", value.ToString()); }
         }
      
         public float UpResistSpeed
         {
         	get { return float.Parse(getFieldValue("UpResistSpeed")); }
         	set { setFieldValue("UpResistSpeed", value.ToString()); }
         }
      
         public float UpResistFactor
         {
         	get { return float.Parse(getFieldValue("UpResistFactor")); }
         	set { setFieldValue("UpResistFactor", value.ToString()); }
         }
      
         public float JumpForce
         {
         	get { return float.Parse(getFieldValue("JumpForce")); }
         	set { setFieldValue("JumpForce", value.ToString()); }
         }
      
         public float JumpEnergyDrain
         {
         	get { return float.Parse(getFieldValue("JumpEnergyDrain")); }
         	set { setFieldValue("JumpEnergyDrain", value.ToString()); }
         }
      
         public float MinJumpEnergy
         {
         	get { return float.Parse(getFieldValue("MinJumpEnergy")); }
         	set { setFieldValue("MinJumpEnergy", value.ToString()); }
         }
      
         public float MinJumpSpeed
         {
         	get { return float.Parse(getFieldValue("MinJumpSpeed")); }
         	set { setFieldValue("MinJumpSpeed", value.ToString()); }
         }
      
         public float MaxJumpSpeed
         {
         	get { return float.Parse(getFieldValue("MaxJumpSpeed")); }
         	set { setFieldValue("MaxJumpSpeed", value.ToString()); }
         }
      
         public float JumpSurfaceAngle
         {
         	get { return float.Parse(getFieldValue("JumpSurfaceAngle")); }
         	set { setFieldValue("JumpSurfaceAngle", value.ToString()); }
         }
      
         public int JumpDelay
         {
         	get { return int.Parse(getFieldValue("JumpDelay")); }
         	set { setFieldValue("JumpDelay", value.ToString()); }
         }
      
         public float AirControl
         {
         	get { return float.Parse(getFieldValue("AirControl")); }
         	set { setFieldValue("AirControl", value.ToString()); }
         }
      
         public bool JumpTowardsNormal
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("JumpTowardsNormal")); }
         	set { setFieldValue("JumpTowardsNormal", value ? "1" : "0"); }
         }
      
         public float SprintForce
         {
         	get { return float.Parse(getFieldValue("SprintForce")); }
         	set { setFieldValue("SprintForce", value.ToString()); }
         }
      
         public float SprintEnergyDrain
         {
         	get { return float.Parse(getFieldValue("SprintEnergyDrain")); }
         	set { setFieldValue("SprintEnergyDrain", value.ToString()); }
         }
      
         public float MinSprintEnergy
         {
         	get { return float.Parse(getFieldValue("MinSprintEnergy")); }
         	set { setFieldValue("MinSprintEnergy", value.ToString()); }
         }
      
         public float MaxSprintForwardSpeed
         {
         	get { return float.Parse(getFieldValue("MaxSprintForwardSpeed")); }
         	set { setFieldValue("MaxSprintForwardSpeed", value.ToString()); }
         }
      
         public float MaxSprintBackwardSpeed
         {
         	get { return float.Parse(getFieldValue("MaxSprintBackwardSpeed")); }
         	set { setFieldValue("MaxSprintBackwardSpeed", value.ToString()); }
         }
      
         public float MaxSprintSideSpeed
         {
         	get { return float.Parse(getFieldValue("MaxSprintSideSpeed")); }
         	set { setFieldValue("MaxSprintSideSpeed", value.ToString()); }
         }
      
         public float SprintStrafeScale
         {
         	get { return float.Parse(getFieldValue("SprintStrafeScale")); }
         	set { setFieldValue("SprintStrafeScale", value.ToString()); }
         }
      
         public float SprintYawScale
         {
         	get { return float.Parse(getFieldValue("SprintYawScale")); }
         	set { setFieldValue("SprintYawScale", value.ToString()); }
         }
      
         public float SprintPitchScale
         {
         	get { return float.Parse(getFieldValue("SprintPitchScale")); }
         	set { setFieldValue("SprintPitchScale", value.ToString()); }
         }
      
         public bool SprintCanJump
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SprintCanJump")); }
         	set { setFieldValue("SprintCanJump", value ? "1" : "0"); }
         }
      
         public float SwimForce
         {
         	get { return float.Parse(getFieldValue("SwimForce")); }
         	set { setFieldValue("SwimForce", value.ToString()); }
         }
      
         public float MaxUnderwaterForwardSpeed
         {
         	get { return float.Parse(getFieldValue("MaxUnderwaterForwardSpeed")); }
         	set { setFieldValue("MaxUnderwaterForwardSpeed", value.ToString()); }
         }
      
         public float MaxUnderwaterBackwardSpeed
         {
         	get { return float.Parse(getFieldValue("MaxUnderwaterBackwardSpeed")); }
         	set { setFieldValue("MaxUnderwaterBackwardSpeed", value.ToString()); }
         }
      
         public float MaxUnderwaterSideSpeed
         {
         	get { return float.Parse(getFieldValue("MaxUnderwaterSideSpeed")); }
         	set { setFieldValue("MaxUnderwaterSideSpeed", value.ToString()); }
         }
      
         public float CrouchForce
         {
         	get { return float.Parse(getFieldValue("CrouchForce")); }
         	set { setFieldValue("CrouchForce", value.ToString()); }
         }
      
         public float MaxCrouchForwardSpeed
         {
         	get { return float.Parse(getFieldValue("MaxCrouchForwardSpeed")); }
         	set { setFieldValue("MaxCrouchForwardSpeed", value.ToString()); }
         }
      
         public float MaxCrouchBackwardSpeed
         {
         	get { return float.Parse(getFieldValue("MaxCrouchBackwardSpeed")); }
         	set { setFieldValue("MaxCrouchBackwardSpeed", value.ToString()); }
         }
      
         public float MaxCrouchSideSpeed
         {
         	get { return float.Parse(getFieldValue("MaxCrouchSideSpeed")); }
         	set { setFieldValue("MaxCrouchSideSpeed", value.ToString()); }
         }
      
         public float ProneForce
         {
         	get { return float.Parse(getFieldValue("ProneForce")); }
         	set { setFieldValue("ProneForce", value.ToString()); }
         }
      
         public float MaxProneForwardSpeed
         {
         	get { return float.Parse(getFieldValue("MaxProneForwardSpeed")); }
         	set { setFieldValue("MaxProneForwardSpeed", value.ToString()); }
         }
      
         public float MaxProneBackwardSpeed
         {
         	get { return float.Parse(getFieldValue("MaxProneBackwardSpeed")); }
         	set { setFieldValue("MaxProneBackwardSpeed", value.ToString()); }
         }
      
         public float MaxProneSideSpeed
         {
         	get { return float.Parse(getFieldValue("MaxProneSideSpeed")); }
         	set { setFieldValue("MaxProneSideSpeed", value.ToString()); }
         }
      
         public float JetJumpForce
         {
         	get { return float.Parse(getFieldValue("JetJumpForce")); }
         	set { setFieldValue("JetJumpForce", value.ToString()); }
         }
      
         public float JetJumpEnergyDrain
         {
         	get { return float.Parse(getFieldValue("JetJumpEnergyDrain")); }
         	set { setFieldValue("JetJumpEnergyDrain", value.ToString()); }
         }
      
         public float JetMinJumpEnergy
         {
         	get { return float.Parse(getFieldValue("JetMinJumpEnergy")); }
         	set { setFieldValue("JetMinJumpEnergy", value.ToString()); }
         }
      
         public float JetMinJumpSpeed
         {
         	get { return float.Parse(getFieldValue("JetMinJumpSpeed")); }
         	set { setFieldValue("JetMinJumpSpeed", value.ToString()); }
         }
      
         public float JetMaxJumpSpeed
         {
         	get { return float.Parse(getFieldValue("JetMaxJumpSpeed")); }
         	set { setFieldValue("JetMaxJumpSpeed", value.ToString()); }
         }
      
         public float JetJumpSurfaceAngle
         {
         	get { return float.Parse(getFieldValue("JetJumpSurfaceAngle")); }
         	set { setFieldValue("JetJumpSurfaceAngle", value.ToString()); }
         }
      
         public float FallingSpeedThreshold
         {
         	get { return float.Parse(getFieldValue("FallingSpeedThreshold")); }
         	set { setFieldValue("FallingSpeedThreshold", value.ToString()); }
         }
      
         public int RecoverDelay
         {
         	get { return int.Parse(getFieldValue("RecoverDelay")); }
         	set { setFieldValue("RecoverDelay", value.ToString()); }
         }
      
         public float RecoverRunForceScale
         {
         	get { return float.Parse(getFieldValue("RecoverRunForceScale")); }
         	set { setFieldValue("RecoverRunForceScale", value.ToString()); }
         }
      
         public float LandSequenceTime
         {
         	get { return float.Parse(getFieldValue("LandSequenceTime")); }
         	set { setFieldValue("LandSequenceTime", value.ToString()); }
         }
      
         public bool TransitionToLand
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("TransitionToLand")); }
         	set { setFieldValue("TransitionToLand", value ? "1" : "0"); }
         }
      
         public Point3F BoundingBox
         {
         	get { return new Point3F(getFieldValue("BoundingBox")); }
         	set { setFieldValue("BoundingBox", value.ToString()); }
         }
      
         public Point3F CrouchBoundingBox
         {
         	get { return new Point3F(getFieldValue("CrouchBoundingBox")); }
         	set { setFieldValue("CrouchBoundingBox", value.ToString()); }
         }
      
         public Point3F ProneBoundingBox
         {
         	get { return new Point3F(getFieldValue("ProneBoundingBox")); }
         	set { setFieldValue("ProneBoundingBox", value.ToString()); }
         }
      
         public Point3F SwimBoundingBox
         {
         	get { return new Point3F(getFieldValue("SwimBoundingBox")); }
         	set { setFieldValue("SwimBoundingBox", value.ToString()); }
         }
      
         public float BoxHeadPercentage
         {
         	get { return float.Parse(getFieldValue("BoxHeadPercentage")); }
         	set { setFieldValue("BoxHeadPercentage", value.ToString()); }
         }
      
         public float BoxTorsoPercentage
         {
         	get { return float.Parse(getFieldValue("BoxTorsoPercentage")); }
         	set { setFieldValue("BoxTorsoPercentage", value.ToString()); }
         }
      
         public float BoxHeadLeftPercentage
         {
         	get { return float.Parse(getFieldValue("BoxHeadLeftPercentage")); }
         	set { setFieldValue("BoxHeadLeftPercentage", value.ToString()); }
         }
      
         public float BoxHeadRightPercentage
         {
         	get { return float.Parse(getFieldValue("BoxHeadRightPercentage")); }
         	set { setFieldValue("BoxHeadRightPercentage", value.ToString()); }
         }
      
         public float BoxHeadBackPercentage
         {
         	get { return float.Parse(getFieldValue("BoxHeadBackPercentage")); }
         	set { setFieldValue("BoxHeadBackPercentage", value.ToString()); }
         }
      
         public float BoxHeadFrontPercentage
         {
         	get { return float.Parse(getFieldValue("BoxHeadFrontPercentage")); }
         	set { setFieldValue("BoxHeadFrontPercentage", value.ToString()); }
         }
      
         public ParticleEmitterData FootPuffEmitter
         {
         	get { return Sim.FindObject<ParticleEmitterData>(getFieldValue("FootPuffEmitter")); }
         	set { setFieldValue("FootPuffEmitter", value.getId().ToString()); }
         }
      
         public int FootPuffNumParts
         {
         	get { return int.Parse(getFieldValue("FootPuffNumParts")); }
         	set { setFieldValue("FootPuffNumParts", value.ToString()); }
         }
      
         public float FootPuffRadius
         {
         	get { return float.Parse(getFieldValue("FootPuffRadius")); }
         	set { setFieldValue("FootPuffRadius", value.ToString()); }
         }
      
         public ParticleEmitterData DustEmitter
         {
         	get { return Sim.FindObject<ParticleEmitterData>(getFieldValue("DustEmitter")); }
         	set { setFieldValue("DustEmitter", value.getId().ToString()); }
         }
      
         public DecalData DecalData
         {
         	get { return Sim.FindObject<DecalData>(getFieldValue("DecalData")); }
         	set { setFieldValue("DecalData", value.getId().ToString()); }
         }
      
         public float DecalOffset
         {
         	get { return float.Parse(getFieldValue("DecalOffset")); }
         	set { setFieldValue("DecalOffset", value.ToString()); }
         }
      
         public SFXTrack FootSoftSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("FootSoftSound")); }
         	set { setFieldValue("FootSoftSound", value.getId().ToString()); }
         }
      
         public SFXTrack FootHardSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("FootHardSound")); }
         	set { setFieldValue("FootHardSound", value.getId().ToString()); }
         }
      
         public SFXTrack FootMetalSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("FootMetalSound")); }
         	set { setFieldValue("FootMetalSound", value.getId().ToString()); }
         }
      
         public SFXTrack FootSnowSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("FootSnowSound")); }
         	set { setFieldValue("FootSnowSound", value.getId().ToString()); }
         }
      
         public SFXTrack FootShallowSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("FootShallowSound")); }
         	set { setFieldValue("FootShallowSound", value.getId().ToString()); }
         }
      
         public SFXTrack FootWadingSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("FootWadingSound")); }
         	set { setFieldValue("FootWadingSound", value.getId().ToString()); }
         }
      
         public SFXTrack FootUnderwaterSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("FootUnderwaterSound")); }
         	set { setFieldValue("FootUnderwaterSound", value.getId().ToString()); }
         }
      
         public SFXTrack FootBubblesSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("FootBubblesSound")); }
         	set { setFieldValue("FootBubblesSound", value.getId().ToString()); }
         }
      
         public SFXTrack MovingBubblesSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("MovingBubblesSound")); }
         	set { setFieldValue("MovingBubblesSound", value.getId().ToString()); }
         }
      
         public SFXTrack WaterBreathSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("WaterBreathSound")); }
         	set { setFieldValue("WaterBreathSound", value.getId().ToString()); }
         }
      
         public SFXTrack ImpactSoftSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("ImpactSoftSound")); }
         	set { setFieldValue("ImpactSoftSound", value.getId().ToString()); }
         }
      
         public SFXTrack ImpactHardSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("ImpactHardSound")); }
         	set { setFieldValue("ImpactHardSound", value.getId().ToString()); }
         }
      
         public SFXTrack ImpactMetalSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("ImpactMetalSound")); }
         	set { setFieldValue("ImpactMetalSound", value.getId().ToString()); }
         }
      
         public SFXTrack ImpactSnowSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("ImpactSnowSound")); }
         	set { setFieldValue("ImpactSnowSound", value.getId().ToString()); }
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
      
         public SFXTrack ExitingWater
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("ExitingWater")); }
         	set { setFieldValue("ExitingWater", value.getId().ToString()); }
         }
      
         public SplashData Splash
         {
         	get { return Sim.FindObject<SplashData>(getFieldValue("Splash")); }
         	set { setFieldValue("Splash", value.getId().ToString()); }
         }
      
         public float SplashVelocity
         {
         	get { return float.Parse(getFieldValue("SplashVelocity")); }
         	set { setFieldValue("SplashVelocity", value.ToString()); }
         }
      
         public float SplashAngle
         {
         	get { return float.Parse(getFieldValue("SplashAngle")); }
         	set { setFieldValue("SplashAngle", value.ToString()); }
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
      
         public float BubbleEmitTime
         {
         	get { return float.Parse(getFieldValue("BubbleEmitTime")); }
         	set { setFieldValue("BubbleEmitTime", value.ToString()); }
         }
      
         public DynamicFieldVector<ParticleEmitterData> SplashEmitter
         {
         	get { return new DynamicFieldVector<ParticleEmitterData>(this, "SplashEmitter", 3, val => Sim.FindObject<ParticleEmitterData>(val), obj => obj.getId().ToString()); }
         }
      
         public float FootstepSplashHeight
         {
         	get { return float.Parse(getFieldValue("FootstepSplashHeight")); }
         	set { setFieldValue("FootstepSplashHeight", value.ToString()); }
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
      
         public float ExitSplashSoundVelocity
         {
         	get { return float.Parse(getFieldValue("ExitSplashSoundVelocity")); }
         	set { setFieldValue("ExitSplashSoundVelocity", value.ToString()); }
         }
      
         public float GroundImpactMinSpeed
         {
         	get { return float.Parse(getFieldValue("GroundImpactMinSpeed")); }
         	set { setFieldValue("GroundImpactMinSpeed", value.ToString()); }
         }
      
         public Point3F GroundImpactShakeFreq
         {
         	get { return new Point3F(getFieldValue("GroundImpactShakeFreq")); }
         	set { setFieldValue("GroundImpactShakeFreq", value.ToString()); }
         }
      
         public Point3F GroundImpactShakeAmp
         {
         	get { return new Point3F(getFieldValue("GroundImpactShakeAmp")); }
         	set { setFieldValue("GroundImpactShakeAmp", value.ToString()); }
         }
      
         public float GroundImpactShakeDuration
         {
         	get { return float.Parse(getFieldValue("GroundImpactShakeDuration")); }
         	set { setFieldValue("GroundImpactShakeDuration", value.ToString()); }
         }
      
         public float GroundImpactShakeFalloff
         {
         	get { return float.Parse(getFieldValue("GroundImpactShakeFalloff")); }
         	set { setFieldValue("GroundImpactShakeFalloff", value.ToString()); }
         }
      
         public string PhysicsPlayerType
         {
         	get { return getFieldValue("PhysicsPlayerType"); }
         	set { setFieldValue("PhysicsPlayerType", value); }
         }
      
         public string ImageAnimPrefixFP
         {
         	get { return getFieldValue("ImageAnimPrefixFP"); }
         	set { setFieldValue("ImageAnimPrefixFP", value); }
         }
      
         public DynamicFieldVector<string> ShapeNameFP
         {
         	get { return new DynamicFieldVector<string>(this, "ShapeNameFP", 4, val => val, obj => obj); }
         }
      
         public string ImageAnimPrefix
         {
         	get { return getFieldValue("ImageAnimPrefix"); }
         	set { setFieldValue("ImageAnimPrefix", value); }
         }
      
         public bool AllowImageStateAnimation
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowImageStateAnimation")); }
         	set { setFieldValue("AllowImageStateAnimation", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}