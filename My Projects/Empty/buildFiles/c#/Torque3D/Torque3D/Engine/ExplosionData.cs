using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ExplosionData : GameBaseData
	{
		public ExplosionData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ExplosionData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ExplosionData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ExplosionData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ExplosionData(SimObject pObj) : base(pObj)
		{
		}

		public ExplosionData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ExplosionData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ExplosionData_create();
         private static _ExplosionData_create _ExplosionData_createFunc;
         internal static IntPtr ExplosionData_create()
         {
         	if (_ExplosionData_createFunc == null)
         	{
         		_ExplosionData_createFunc =
         			(_ExplosionData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ExplosionData_create"), typeof(_ExplosionData_create));
         	}
         
         	return  _ExplosionData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string ExplosionShape
         {
         	get { return getFieldValue("ExplosionShape"); }
         	set { setFieldValue("ExplosionShape", value); }
         }
      
         public Point3F ExplosionScale
         {
         	get { return new Point3F(getFieldValue("ExplosionScale")); }
         	set { setFieldValue("ExplosionScale", value.ToString()); }
         }
      
         public float PlaySpeed
         {
         	get { return float.Parse(getFieldValue("PlaySpeed")); }
         	set { setFieldValue("PlaySpeed", value.ToString()); }
         }
      
         public SFXTrack SoundProfile
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("SoundProfile")); }
         	set { setFieldValue("SoundProfile", value.getId().ToString()); }
         }
      
         public bool FaceViewer
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FaceViewer")); }
         	set { setFieldValue("FaceViewer", value ? "1" : "0"); }
         }
      
         public ParticleEmitterData ParticleEmitter
         {
         	get { return Sim.FindObject<ParticleEmitterData>(getFieldValue("ParticleEmitter")); }
         	set { setFieldValue("ParticleEmitter", value.getId().ToString()); }
         }
      
         public int ParticleDensity
         {
         	get { return int.Parse(getFieldValue("ParticleDensity")); }
         	set { setFieldValue("ParticleDensity", value.ToString()); }
         }
      
         public float ParticleRadius
         {
         	get { return float.Parse(getFieldValue("ParticleRadius")); }
         	set { setFieldValue("ParticleRadius", value.ToString()); }
         }
      
         public DynamicFieldVector<ParticleEmitterData> Emitter
         {
         	get { return new DynamicFieldVector<ParticleEmitterData>(this, "Emitter", 4, val => Sim.FindObject<ParticleEmitterData>(val), obj => obj.getId().ToString()); }
         }
      
         public DebrisData Debris
         {
         	get { return Sim.FindObject<DebrisData>(getFieldValue("Debris")); }
         	set { setFieldValue("Debris", value.getId().ToString()); }
         }
      
         public float DebrisThetaMin
         {
         	get { return float.Parse(getFieldValue("DebrisThetaMin")); }
         	set { setFieldValue("DebrisThetaMin", value.ToString()); }
         }
      
         public float DebrisThetaMax
         {
         	get { return float.Parse(getFieldValue("DebrisThetaMax")); }
         	set { setFieldValue("DebrisThetaMax", value.ToString()); }
         }
      
         public float DebrisPhiMin
         {
         	get { return float.Parse(getFieldValue("DebrisPhiMin")); }
         	set { setFieldValue("DebrisPhiMin", value.ToString()); }
         }
      
         public float DebrisPhiMax
         {
         	get { return float.Parse(getFieldValue("DebrisPhiMax")); }
         	set { setFieldValue("DebrisPhiMax", value.ToString()); }
         }
      
         public int DebrisNum
         {
         	get { return int.Parse(getFieldValue("DebrisNum")); }
         	set { setFieldValue("DebrisNum", value.ToString()); }
         }
      
         public int DebrisNumVariance
         {
         	get { return int.Parse(getFieldValue("DebrisNumVariance")); }
         	set { setFieldValue("DebrisNumVariance", value.ToString()); }
         }
      
         public float DebrisVelocity
         {
         	get { return float.Parse(getFieldValue("DebrisVelocity")); }
         	set { setFieldValue("DebrisVelocity", value.ToString()); }
         }
      
         public float DebrisVelocityVariance
         {
         	get { return float.Parse(getFieldValue("DebrisVelocityVariance")); }
         	set { setFieldValue("DebrisVelocityVariance", value.ToString()); }
         }
      
         public DynamicFieldVector<ExplosionData> SubExplosion
         {
         	get { return new DynamicFieldVector<ExplosionData>(this, "SubExplosion", 5, val => Sim.FindObject<ExplosionData>(val), obj => obj.getId().ToString()); }
         }
      
         public int DelayMS
         {
         	get { return int.Parse(getFieldValue("DelayMS")); }
         	set { setFieldValue("DelayMS", value.ToString()); }
         }
      
         public int DelayVariance
         {
         	get { return int.Parse(getFieldValue("DelayVariance")); }
         	set { setFieldValue("DelayVariance", value.ToString()); }
         }
      
         public int LifetimeMS
         {
         	get { return int.Parse(getFieldValue("LifetimeMS")); }
         	set { setFieldValue("LifetimeMS", value.ToString()); }
         }
      
         public int LifetimeVariance
         {
         	get { return int.Parse(getFieldValue("LifetimeVariance")); }
         	set { setFieldValue("LifetimeVariance", value.ToString()); }
         }
      
         public float Offset
         {
         	get { return float.Parse(getFieldValue("Offset")); }
         	set { setFieldValue("Offset", value.ToString()); }
         }
      
         public DynamicFieldVector<float> Times
         {
         	get { return new DynamicFieldVector<float>(this, "Times", 4, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<Point3F> Sizes
         {
         	get { return new DynamicFieldVector<Point3F>(this, "Sizes", 4, val => new Point3F(val), obj => obj.ToString()); }
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
      
         public float LightStartRadius
         {
         	get { return float.Parse(getFieldValue("LightStartRadius")); }
         	set { setFieldValue("LightStartRadius", value.ToString()); }
         }
      
         public float LightEndRadius
         {
         	get { return float.Parse(getFieldValue("LightEndRadius")); }
         	set { setFieldValue("LightEndRadius", value.ToString()); }
         }
      
         public ColorF LightStartColor
         {
         	get { return new ColorF(getFieldValue("LightStartColor")); }
         	set { setFieldValue("LightStartColor", value.ToString()); }
         }
      
         public ColorF LightEndColor
         {
         	get { return new ColorF(getFieldValue("LightEndColor")); }
         	set { setFieldValue("LightEndColor", value.ToString()); }
         }
      
         public float LightStartBrightness
         {
         	get { return float.Parse(getFieldValue("LightStartBrightness")); }
         	set { setFieldValue("LightStartBrightness", value.ToString()); }
         }
      
         public float LightEndBrightness
         {
         	get { return float.Parse(getFieldValue("LightEndBrightness")); }
         	set { setFieldValue("LightEndBrightness", value.ToString()); }
         }
      
         public float LightNormalOffset
         {
         	get { return float.Parse(getFieldValue("LightNormalOffset")); }
         	set { setFieldValue("LightNormalOffset", value.ToString()); }
         }
      
      
      #endregion

	}
}