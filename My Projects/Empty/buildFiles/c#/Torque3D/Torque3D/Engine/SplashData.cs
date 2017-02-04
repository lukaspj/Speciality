using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SplashData : GameBaseData
	{
		public SplashData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SplashData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SplashData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SplashData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SplashData(SimObject pObj) : base(pObj)
		{
		}

		public SplashData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SplashData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SplashData_create();
         private static _SplashData_create _SplashData_createFunc;
         internal static IntPtr SplashData_create()
         {
         	if (_SplashData_createFunc == null)
         	{
         		_SplashData_createFunc =
         			(_SplashData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SplashData_create"), typeof(_SplashData_create));
         	}
         
         	return  _SplashData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public SFXProfile SoundProfile
         {
         	get { return Sim.FindObject<SFXProfile>(getFieldValue("SoundProfile")); }
         	set { setFieldValue("SoundProfile", value.getId().ToString()); }
         }
      
         public Point3F Scale
         {
         	get { return new Point3F(getFieldValue("Scale")); }
         	set { setFieldValue("Scale", value.ToString()); }
         }
      
         public DynamicFieldVector<ParticleEmitterData> Emitter
         {
         	get { return new DynamicFieldVector<ParticleEmitterData>(this, "Emitter", 3, val => Sim.FindObject<ParticleEmitterData>(val), obj => obj.getId().ToString()); }
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
      
         public float Width
         {
         	get { return float.Parse(getFieldValue("Width")); }
         	set { setFieldValue("Width", value.ToString()); }
         }
      
         public int NumSegments
         {
         	get { return int.Parse(getFieldValue("NumSegments")); }
         	set { setFieldValue("NumSegments", value.ToString()); }
         }
      
         public float Velocity
         {
         	get { return float.Parse(getFieldValue("Velocity")); }
         	set { setFieldValue("Velocity", value.ToString()); }
         }
      
         public float Height
         {
         	get { return float.Parse(getFieldValue("Height")); }
         	set { setFieldValue("Height", value.ToString()); }
         }
      
         public float Acceleration
         {
         	get { return float.Parse(getFieldValue("Acceleration")); }
         	set { setFieldValue("Acceleration", value.ToString()); }
         }
      
         public DynamicFieldVector<float> Times
         {
         	get { return new DynamicFieldVector<float>(this, "Times", 4, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<ColorF> Colors
         {
         	get { return new DynamicFieldVector<ColorF>(this, "Colors", 4, val => new ColorF(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<string> Texture
         {
         	get { return new DynamicFieldVector<string>(this, "Texture", 2, val => val, obj => obj); }
         }
      
         public float TexWrap
         {
         	get { return float.Parse(getFieldValue("TexWrap")); }
         	set { setFieldValue("TexWrap", value.ToString()); }
         }
      
         public float TexFactor
         {
         	get { return float.Parse(getFieldValue("TexFactor")); }
         	set { setFieldValue("TexFactor", value.ToString()); }
         }
      
         public float EjectionFreq
         {
         	get { return float.Parse(getFieldValue("EjectionFreq")); }
         	set { setFieldValue("EjectionFreq", value.ToString()); }
         }
      
         public float EjectionAngle
         {
         	get { return float.Parse(getFieldValue("EjectionAngle")); }
         	set { setFieldValue("EjectionAngle", value.ToString()); }
         }
      
         public float RingLifetime
         {
         	get { return float.Parse(getFieldValue("RingLifetime")); }
         	set { setFieldValue("RingLifetime", value.ToString()); }
         }
      
         public float StartRadius
         {
         	get { return float.Parse(getFieldValue("StartRadius")); }
         	set { setFieldValue("StartRadius", value.ToString()); }
         }
      
         public ExplosionData Explosion
         {
         	get { return Sim.FindObject<ExplosionData>(getFieldValue("Explosion")); }
         	set { setFieldValue("Explosion", value.getId().ToString()); }
         }
      
      
      #endregion

	}
}