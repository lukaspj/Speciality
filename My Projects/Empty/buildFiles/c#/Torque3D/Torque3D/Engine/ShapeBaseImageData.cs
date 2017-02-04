using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ShapeBaseImageData : GameBaseData
	{
		public ShapeBaseImageData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ShapeBaseImageData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ShapeBaseImageData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ShapeBaseImageData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ShapeBaseImageData(SimObject pObj) : base(pObj)
		{
		}

		public ShapeBaseImageData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ShapeBaseImageData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ShapeBaseImageData_create();
         private static _ShapeBaseImageData_create _ShapeBaseImageData_createFunc;
         internal static IntPtr ShapeBaseImageData_create()
         {
         	if (_ShapeBaseImageData_createFunc == null)
         	{
         		_ShapeBaseImageData_createFunc =
         			(_ShapeBaseImageData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ShapeBaseImageData_create"), typeof(_ShapeBaseImageData_create));
         	}
         
         	return  _ShapeBaseImageData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public bool Emap
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Emap")); }
         	set { setFieldValue("Emap", value ? "1" : "0"); }
         }
      
         public string ShapeFile
         {
         	get { return getFieldValue("ShapeFile"); }
         	set { setFieldValue("ShapeFile", value); }
         }
      
         public string ShapeFileFP
         {
         	get { return getFieldValue("ShapeFileFP"); }
         	set { setFieldValue("ShapeFileFP", value); }
         }
      
         public string ImageAnimPrefix
         {
         	get { return getFieldValue("ImageAnimPrefix"); }
         	set { setFieldValue("ImageAnimPrefix", value); }
         }
      
         public string ImageAnimPrefixFP
         {
         	get { return getFieldValue("ImageAnimPrefixFP"); }
         	set { setFieldValue("ImageAnimPrefixFP", value); }
         }
      
         public bool AnimateAllShapes
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AnimateAllShapes")); }
         	set { setFieldValue("AnimateAllShapes", value ? "1" : "0"); }
         }
      
         public bool AnimateOnServer
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AnimateOnServer")); }
         	set { setFieldValue("AnimateOnServer", value ? "1" : "0"); }
         }
      
         public float ScriptAnimTransitionTime
         {
         	get { return float.Parse(getFieldValue("ScriptAnimTransitionTime")); }
         	set { setFieldValue("ScriptAnimTransitionTime", value.ToString()); }
         }
      
         public ProjectileData Projectile
         {
         	get { return Sim.FindObject<ProjectileData>(getFieldValue("Projectile")); }
         	set { setFieldValue("Projectile", value.getId().ToString()); }
         }
      
         public bool Cloakable
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Cloakable")); }
         	set { setFieldValue("Cloakable", value ? "1" : "0"); }
         }
      
         public int MountPoint
         {
         	get { return int.Parse(getFieldValue("MountPoint")); }
         	set { setFieldValue("MountPoint", value.ToString()); }
         }
      
         public Point3F Offset
         {
         	get { return new Point3F(getFieldValue("Offset")); }
         	set { setFieldValue("Offset", value.ToString()); }
         }
      
         public Point3F Rotation
         {
         	get { return new Point3F(getFieldValue("Rotation")); }
         	set { setFieldValue("Rotation", value.ToString()); }
         }
      
         public Point3F EyeOffset
         {
         	get { return new Point3F(getFieldValue("EyeOffset")); }
         	set { setFieldValue("EyeOffset", value.ToString()); }
         }
      
         public Point3F EyeRotation
         {
         	get { return new Point3F(getFieldValue("EyeRotation")); }
         	set { setFieldValue("EyeRotation", value.ToString()); }
         }
      
         public bool UseEyeNode
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseEyeNode")); }
         	set { setFieldValue("UseEyeNode", value ? "1" : "0"); }
         }
      
         public bool CorrectMuzzleVector
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CorrectMuzzleVector")); }
         	set { setFieldValue("CorrectMuzzleVector", value ? "1" : "0"); }
         }
      
         public bool CorrectMuzzleVectorTP
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CorrectMuzzleVectorTP")); }
         	set { setFieldValue("CorrectMuzzleVectorTP", value ? "1" : "0"); }
         }
      
         public bool FirstPerson
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FirstPerson")); }
         	set { setFieldValue("FirstPerson", value ? "1" : "0"); }
         }
      
         public float Mass
         {
         	get { return float.Parse(getFieldValue("Mass")); }
         	set { setFieldValue("Mass", value.ToString()); }
         }
      
         public bool UsesEnergy
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UsesEnergy")); }
         	set { setFieldValue("UsesEnergy", value ? "1" : "0"); }
         }
      
         public float MinEnergy
         {
         	get { return float.Parse(getFieldValue("MinEnergy")); }
         	set { setFieldValue("MinEnergy", value.ToString()); }
         }
      
         public bool AccuFire
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AccuFire")); }
         	set { setFieldValue("AccuFire", value ? "1" : "0"); }
         }
      
         public ShapeBaseImageLightType LightType
         {
         	get { return (ShapeBaseImageLightType)Enum.Parse(typeof(ShapeBaseImageLightType), getFieldValue("LightType"), true); }
         	set { setFieldValue("LightType", value.ToString()); }
         }
      
         public ColorF LightColor
         {
         	get { return new ColorF(getFieldValue("LightColor")); }
         	set { setFieldValue("LightColor", value.ToString()); }
         }
      
         public int LightDuration
         {
         	get { return int.Parse(getFieldValue("LightDuration")); }
         	set { setFieldValue("LightDuration", value.ToString()); }
         }
      
         public float LightRadius
         {
         	get { return float.Parse(getFieldValue("LightRadius")); }
         	set { setFieldValue("LightRadius", value.ToString()); }
         }
      
         public float LightBrightness
         {
         	get { return float.Parse(getFieldValue("LightBrightness")); }
         	set { setFieldValue("LightBrightness", value.ToString()); }
         }
      
         public bool ShakeCamera
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShakeCamera")); }
         	set { setFieldValue("ShakeCamera", value ? "1" : "0"); }
         }
      
         public Point3F CamShakeFreq
         {
         	get { return new Point3F(getFieldValue("CamShakeFreq")); }
         	set { setFieldValue("CamShakeFreq", value.ToString()); }
         }
      
         public Point3F CamShakeAmp
         {
         	get { return new Point3F(getFieldValue("CamShakeAmp")); }
         	set { setFieldValue("CamShakeAmp", value.ToString()); }
         }
      
         public float CamShakeDuration
         {
         	get { return float.Parse(getFieldValue("CamShakeDuration")); }
         	set { setFieldValue("CamShakeDuration", value.ToString()); }
         }
      
         public float CamShakeRadius
         {
         	get { return float.Parse(getFieldValue("CamShakeRadius")); }
         	set { setFieldValue("CamShakeRadius", value.ToString()); }
         }
      
         public float CamShakeFalloff
         {
         	get { return float.Parse(getFieldValue("CamShakeFalloff")); }
         	set { setFieldValue("CamShakeFalloff", value.ToString()); }
         }
      
         public DebrisData Casing
         {
         	get { return Sim.FindObject<DebrisData>(getFieldValue("Casing")); }
         	set { setFieldValue("Casing", value.getId().ToString()); }
         }
      
         public Point3F ShellExitDir
         {
         	get { return new Point3F(getFieldValue("ShellExitDir")); }
         	set { setFieldValue("ShellExitDir", value.ToString()); }
         }
      
         public float ShellExitVariance
         {
         	get { return float.Parse(getFieldValue("ShellExitVariance")); }
         	set { setFieldValue("ShellExitVariance", value.ToString()); }
         }
      
         public float ShellVelocity
         {
         	get { return float.Parse(getFieldValue("ShellVelocity")); }
         	set { setFieldValue("ShellVelocity", value.ToString()); }
         }
      
         public DynamicFieldVector<string> StateName
         {
         	get { return new DynamicFieldVector<string>(this, "StateName", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionOnLoaded
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionOnLoaded", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionOnNotLoaded
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionOnNotLoaded", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionOnAmmo
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionOnAmmo", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionOnNoAmmo
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionOnNoAmmo", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionOnTarget
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionOnTarget", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionOnNoTarget
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionOnNoTarget", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionOnWet
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionOnWet", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionOnNotWet
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionOnNotWet", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionOnMotion
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionOnMotion", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionOnNoMotion
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionOnNoMotion", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionOnTriggerUp
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionOnTriggerUp", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionOnTriggerDown
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionOnTriggerDown", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionOnAltTriggerUp
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionOnAltTriggerUp", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionOnAltTriggerDown
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionOnAltTriggerDown", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionOnTimeout
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionOnTimeout", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionGeneric0In
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionGeneric0In", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionGeneric0Out
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionGeneric0Out", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionGeneric1In
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionGeneric1In", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionGeneric1Out
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionGeneric1Out", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionGeneric2In
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionGeneric2In", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionGeneric2Out
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionGeneric2Out", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionGeneric3In
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionGeneric3In", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionGeneric3Out
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionGeneric3Out", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<float> StateTimeoutValue
         {
         	get { return new DynamicFieldVector<float>(this, "StateTimeoutValue", 31, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<bool> StateWaitForTimeout
         {
         	get { return new DynamicFieldVector<bool>(this, "StateWaitForTimeout", 31, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<bool> StateFire
         {
         	get { return new DynamicFieldVector<bool>(this, "StateFire", 31, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<bool> StateAlternateFire
         {
         	get { return new DynamicFieldVector<bool>(this, "StateAlternateFire", 31, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<bool> StateReload
         {
         	get { return new DynamicFieldVector<bool>(this, "StateReload", 31, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<bool> StateEjectShell
         {
         	get { return new DynamicFieldVector<bool>(this, "StateEjectShell", 31, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<float> StateEnergyDrain
         {
         	get { return new DynamicFieldVector<float>(this, "StateEnergyDrain", 31, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<bool> StateAllowImageChange
         {
         	get { return new DynamicFieldVector<bool>(this, "StateAllowImageChange", 31, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<bool> StateDirection
         {
         	get { return new DynamicFieldVector<bool>(this, "StateDirection", 31, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<ShapeBaseImageLoadedState> StateLoadedFlag
         {
         	get { return new DynamicFieldVector<ShapeBaseImageLoadedState>(this, "StateLoadedFlag", 31, val => (ShapeBaseImageLoadedState)Enum.Parse(typeof(ShapeBaseImageLoadedState), val, true), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<ShapeBaseImageSpinState> StateSpinThread
         {
         	get { return new DynamicFieldVector<ShapeBaseImageSpinState>(this, "StateSpinThread", 31, val => (ShapeBaseImageSpinState)Enum.Parse(typeof(ShapeBaseImageSpinState), val, true), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<ShapeBaseImageRecoilState> StateRecoil
         {
         	get { return new DynamicFieldVector<ShapeBaseImageRecoilState>(this, "StateRecoil", 31, val => (ShapeBaseImageRecoilState)Enum.Parse(typeof(ShapeBaseImageRecoilState), val, true), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<string> StateSequence
         {
         	get { return new DynamicFieldVector<string>(this, "StateSequence", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<bool> StateSequenceRandomFlash
         {
         	get { return new DynamicFieldVector<bool>(this, "StateSequenceRandomFlash", 31, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<bool> StateScaleAnimation
         {
         	get { return new DynamicFieldVector<bool>(this, "StateScaleAnimation", 31, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<bool> StateScaleAnimationFP
         {
         	get { return new DynamicFieldVector<bool>(this, "StateScaleAnimationFP", 31, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<bool> StateSequenceTransitionIn
         {
         	get { return new DynamicFieldVector<bool>(this, "StateSequenceTransitionIn", 31, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<bool> StateSequenceTransitionOut
         {
         	get { return new DynamicFieldVector<bool>(this, "StateSequenceTransitionOut", 31, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<bool> StateSequenceNeverTransition
         {
         	get { return new DynamicFieldVector<bool>(this, "StateSequenceNeverTransition", 31, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<float> StateSequenceTransitionTime
         {
         	get { return new DynamicFieldVector<float>(this, "StateSequenceTransitionTime", 31, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<string> StateShapeSequence
         {
         	get { return new DynamicFieldVector<string>(this, "StateShapeSequence", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<bool> StateScaleShapeSequence
         {
         	get { return new DynamicFieldVector<bool>(this, "StateScaleShapeSequence", 31, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<SFXTrack> StateSound
         {
         	get { return new DynamicFieldVector<SFXTrack>(this, "StateSound", 31, val => Sim.FindObject<SFXTrack>(val), obj => obj.getId().ToString()); }
         }
      
         public DynamicFieldVector<string> StateScript
         {
         	get { return new DynamicFieldVector<string>(this, "StateScript", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<ParticleEmitterData> StateEmitter
         {
         	get { return new DynamicFieldVector<ParticleEmitterData>(this, "StateEmitter", 31, val => Sim.FindObject<ParticleEmitterData>(val), obj => obj.getId().ToString()); }
         }
      
         public DynamicFieldVector<float> StateEmitterTime
         {
         	get { return new DynamicFieldVector<float>(this, "StateEmitterTime", 31, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<string> StateEmitterNode
         {
         	get { return new DynamicFieldVector<string>(this, "StateEmitterNode", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<bool> StateIgnoreLoadedForReady
         {
         	get { return new DynamicFieldVector<bool>(this, "StateIgnoreLoadedForReady", 31, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public bool ComputeCRC
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ComputeCRC")); }
         	set { setFieldValue("ComputeCRC", value ? "1" : "0"); }
         }
      
         public int MaxConcurrentSounds
         {
         	get { return int.Parse(getFieldValue("MaxConcurrentSounds")); }
         	set { setFieldValue("MaxConcurrentSounds", value.ToString()); }
         }
      
         public bool UseRemainderDT
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseRemainderDT")); }
         	set { setFieldValue("UseRemainderDT", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}