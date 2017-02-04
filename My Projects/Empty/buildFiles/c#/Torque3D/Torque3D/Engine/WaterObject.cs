using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class WaterObject : SceneObject
	{
		public WaterObject(bool pRegister = false)
			: base(pRegister)
		{
		}

		public WaterObject(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public WaterObject(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public WaterObject(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public WaterObject(SimObject pObj) : base(pObj)
		{
		}

		public WaterObject(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.WaterObject_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _WaterObject_create();
         private static _WaterObject_create _WaterObject_createFunc;
         internal static IntPtr WaterObject_create()
         {
         	if (_WaterObject_createFunc == null)
         	{
         		_WaterObject_createFunc =
         			(_WaterObject_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_WaterObject_create"), typeof(_WaterObject_create));
         	}
         
         	return  _WaterObject_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float Density
         {
         	get { return float.Parse(getFieldValue("Density")); }
         	set { setFieldValue("Density", value.ToString()); }
         }
      
         public float Viscosity
         {
         	get { return float.Parse(getFieldValue("Viscosity")); }
         	set { setFieldValue("Viscosity", value.ToString()); }
         }
      
         public string LiquidType
         {
         	get { return getFieldValue("LiquidType"); }
         	set { setFieldValue("LiquidType", value); }
         }
      
         public ColorI BaseColor
         {
         	get { return new ColorI(getFieldValue("BaseColor")); }
         	set { setFieldValue("BaseColor", value.ToString()); }
         }
      
         public float FresnelBias
         {
         	get { return float.Parse(getFieldValue("FresnelBias")); }
         	set { setFieldValue("FresnelBias", value.ToString()); }
         }
      
         public float FresnelPower
         {
         	get { return float.Parse(getFieldValue("FresnelPower")); }
         	set { setFieldValue("FresnelPower", value.ToString()); }
         }
      
         public float SpecularPower
         {
         	get { return float.Parse(getFieldValue("SpecularPower")); }
         	set { setFieldValue("SpecularPower", value.ToString()); }
         }
      
         public ColorF SpecularColor
         {
         	get { return new ColorF(getFieldValue("SpecularColor")); }
         	set { setFieldValue("SpecularColor", value.ToString()); }
         }
      
         public bool Emissive
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Emissive")); }
         	set { setFieldValue("Emissive", value ? "1" : "0"); }
         }
      
         public DynamicFieldVector<Point2F> WaveDir
         {
         	get { return new DynamicFieldVector<Point2F>(this, "WaveDir", 3, val => new Point2F(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> WaveSpeed
         {
         	get { return new DynamicFieldVector<float>(this, "WaveSpeed", 3, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> WaveMagnitude
         {
         	get { return new DynamicFieldVector<float>(this, "WaveMagnitude", 3, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public float OverallWaveMagnitude
         {
         	get { return float.Parse(getFieldValue("OverallWaveMagnitude")); }
         	set { setFieldValue("OverallWaveMagnitude", value.ToString()); }
         }
      
         public string RippleTex
         {
         	get { return getFieldValue("RippleTex"); }
         	set { setFieldValue("RippleTex", value); }
         }
      
         public DynamicFieldVector<Point2F> RippleDir
         {
         	get { return new DynamicFieldVector<Point2F>(this, "RippleDir", 3, val => new Point2F(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> RippleSpeed
         {
         	get { return new DynamicFieldVector<float>(this, "RippleSpeed", 3, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<Point2F> RippleTexScale
         {
         	get { return new DynamicFieldVector<Point2F>(this, "RippleTexScale", 3, val => new Point2F(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> RippleMagnitude
         {
         	get { return new DynamicFieldVector<float>(this, "RippleMagnitude", 3, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public float OverallRippleMagnitude
         {
         	get { return float.Parse(getFieldValue("OverallRippleMagnitude")); }
         	set { setFieldValue("OverallRippleMagnitude", value.ToString()); }
         }
      
         public string FoamTex
         {
         	get { return getFieldValue("FoamTex"); }
         	set { setFieldValue("FoamTex", value); }
         }
      
         public DynamicFieldVector<Point2F> FoamDir
         {
         	get { return new DynamicFieldVector<Point2F>(this, "FoamDir", 2, val => new Point2F(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> FoamSpeed
         {
         	get { return new DynamicFieldVector<float>(this, "FoamSpeed", 2, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<Point2F> FoamTexScale
         {
         	get { return new DynamicFieldVector<Point2F>(this, "FoamTexScale", 2, val => new Point2F(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> FoamOpacity
         {
         	get { return new DynamicFieldVector<float>(this, "FoamOpacity", 2, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public float OverallFoamOpacity
         {
         	get { return float.Parse(getFieldValue("OverallFoamOpacity")); }
         	set { setFieldValue("OverallFoamOpacity", value.ToString()); }
         }
      
         public float FoamMaxDepth
         {
         	get { return float.Parse(getFieldValue("FoamMaxDepth")); }
         	set { setFieldValue("FoamMaxDepth", value.ToString()); }
         }
      
         public float FoamAmbientLerp
         {
         	get { return float.Parse(getFieldValue("FoamAmbientLerp")); }
         	set { setFieldValue("FoamAmbientLerp", value.ToString()); }
         }
      
         public float FoamRippleInfluence
         {
         	get { return float.Parse(getFieldValue("FoamRippleInfluence")); }
         	set { setFieldValue("FoamRippleInfluence", value.ToString()); }
         }
      
         public string Cubemap
         {
         	get { return getFieldValue("Cubemap"); }
         	set { setFieldValue("Cubemap", value); }
         }
      
         public bool FullReflect
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FullReflect")); }
         	set { setFieldValue("FullReflect", value ? "1" : "0"); }
         }
      
         public float Reflectivity
         {
         	get { return float.Parse(getFieldValue("Reflectivity")); }
         	set { setFieldValue("Reflectivity", value.ToString()); }
         }
      
         public float ReflectPriority
         {
         	get { return float.Parse(getFieldValue("ReflectPriority")); }
         	set { setFieldValue("ReflectPriority", value.ToString()); }
         }
      
         public int ReflectMaxRateMs
         {
         	get { return int.Parse(getFieldValue("ReflectMaxRateMs")); }
         	set { setFieldValue("ReflectMaxRateMs", value.ToString()); }
         }
      
         public float ReflectDetailAdjust
         {
         	get { return float.Parse(getFieldValue("ReflectDetailAdjust")); }
         	set { setFieldValue("ReflectDetailAdjust", value.ToString()); }
         }
      
         public bool ReflectNormalUp
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ReflectNormalUp")); }
         	set { setFieldValue("ReflectNormalUp", value ? "1" : "0"); }
         }
      
         public bool UseOcclusionQuery
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseOcclusionQuery")); }
         	set { setFieldValue("UseOcclusionQuery", value ? "1" : "0"); }
         }
      
         public int ReflectTexSize
         {
         	get { return int.Parse(getFieldValue("ReflectTexSize")); }
         	set { setFieldValue("ReflectTexSize", value.ToString()); }
         }
      
         public float WaterFogDensity
         {
         	get { return float.Parse(getFieldValue("WaterFogDensity")); }
         	set { setFieldValue("WaterFogDensity", value.ToString()); }
         }
      
         public float WaterFogDensityOffset
         {
         	get { return float.Parse(getFieldValue("WaterFogDensityOffset")); }
         	set { setFieldValue("WaterFogDensityOffset", value.ToString()); }
         }
      
         public float WetDepth
         {
         	get { return float.Parse(getFieldValue("WetDepth")); }
         	set { setFieldValue("WetDepth", value.ToString()); }
         }
      
         public float WetDarkening
         {
         	get { return float.Parse(getFieldValue("WetDarkening")); }
         	set { setFieldValue("WetDarkening", value.ToString()); }
         }
      
         public string DepthGradientTex
         {
         	get { return getFieldValue("DepthGradientTex"); }
         	set { setFieldValue("DepthGradientTex", value); }
         }
      
         public float DepthGradientMax
         {
         	get { return float.Parse(getFieldValue("DepthGradientMax")); }
         	set { setFieldValue("DepthGradientMax", value.ToString()); }
         }
      
         public float DistortStartDist
         {
         	get { return float.Parse(getFieldValue("DistortStartDist")); }
         	set { setFieldValue("DistortStartDist", value.ToString()); }
         }
      
         public float DistortEndDist
         {
         	get { return float.Parse(getFieldValue("DistortEndDist")); }
         	set { setFieldValue("DistortEndDist", value.ToString()); }
         }
      
         public float DistortFullDepth
         {
         	get { return float.Parse(getFieldValue("DistortFullDepth")); }
         	set { setFieldValue("DistortFullDepth", value.ToString()); }
         }
      
         public float Clarity
         {
         	get { return float.Parse(getFieldValue("Clarity")); }
         	set { setFieldValue("Clarity", value.ToString()); }
         }
      
         public ColorI UnderwaterColor
         {
         	get { return new ColorI(getFieldValue("UnderwaterColor")); }
         	set { setFieldValue("UnderwaterColor", value.ToString()); }
         }
      
         public SFXAmbience SoundAmbience
         {
         	get { return Sim.FindObject<SFXAmbience>(getFieldValue("SoundAmbience")); }
         	set { setFieldValue("SoundAmbience", value.getId().ToString()); }
         }
      
      
      #endregion

	}
}