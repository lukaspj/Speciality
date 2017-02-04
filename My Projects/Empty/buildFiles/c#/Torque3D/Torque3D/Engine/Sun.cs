using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class Sun : SceneObject
	{
		public Sun(bool pRegister = false)
			: base(pRegister)
		{
		}

		public Sun(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public Sun(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public Sun(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public Sun(SimObject pObj) : base(pObj)
		{
		}

		public Sun(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Sun_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _apply(IntPtr thisPtr);
         private static _apply _applyFunc;
         internal static void apply(IntPtr thisPtr)
         {
         	if (_applyFunc == null)
         	{
         		_applyFunc =
         			(_apply)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSun_apply"), typeof(_apply));
         	}
         
         	 _applyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _animate(IntPtr thisPtr, float duration, float startAzimuth, float endAzimuth, float startElevation, float endElevation);
         private static _animate _animateFunc;
         internal static void animate(IntPtr thisPtr, float duration, float startAzimuth, float endAzimuth, float startElevation, float endElevation)
         {
         	if (_animateFunc == null)
         	{
         		_animateFunc =
         			(_animate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSun_animate"), typeof(_animate));
         	}
         
         	 _animateFunc(thisPtr, duration, startAzimuth, endAzimuth, startElevation, endElevation);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Sun_create();
         private static _Sun_create _Sun_createFunc;
         internal static IntPtr Sun_create()
         {
         	if (_Sun_createFunc == null)
         	{
         		_Sun_createFunc =
         			(_Sun_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Sun_create"), typeof(_Sun_create));
         	}
         
         	return  _Sun_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void apply()
         {
            InternalUnsafeMethods.apply(ObjectPtr);
         }
      
         public virtual void animate(float duration, float startAzimuth, float endAzimuth, float startElevation, float endElevation)
         {
            InternalUnsafeMethods.animate(ObjectPtr, duration, startAzimuth, endAzimuth, startElevation, endElevation);
         }
      
      
      #endregion


      #region Properties
      
      
         public float Azimuth
         {
         	get { return float.Parse(getFieldValue("Azimuth")); }
         	set { setFieldValue("Azimuth", value.ToString()); }
         }
      
         public float Elevation
         {
         	get { return float.Parse(getFieldValue("Elevation")); }
         	set { setFieldValue("Elevation", value.ToString()); }
         }
      
         public ColorF Color
         {
         	get { return new ColorF(getFieldValue("Color")); }
         	set { setFieldValue("Color", value.ToString()); }
         }
      
         public ColorF Ambient
         {
         	get { return new ColorF(getFieldValue("Ambient")); }
         	set { setFieldValue("Ambient", value.ToString()); }
         }
      
         public float Brightness
         {
         	get { return float.Parse(getFieldValue("Brightness")); }
         	set { setFieldValue("Brightness", value.ToString()); }
         }
      
         public bool CastShadows
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CastShadows")); }
         	set { setFieldValue("CastShadows", value ? "1" : "0"); }
         }
      
         public int StaticRefreshFreq
         {
         	get { return int.Parse(getFieldValue("StaticRefreshFreq")); }
         	set { setFieldValue("StaticRefreshFreq", value.ToString()); }
         }
      
         public int DynamicRefreshFreq
         {
         	get { return int.Parse(getFieldValue("DynamicRefreshFreq")); }
         	set { setFieldValue("DynamicRefreshFreq", value.ToString()); }
         }
      
         public bool CoronaEnabled
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CoronaEnabled")); }
         	set { setFieldValue("CoronaEnabled", value ? "1" : "0"); }
         }
      
         public string CoronaMaterial
         {
         	get { return getFieldValue("CoronaMaterial"); }
         	set { setFieldValue("CoronaMaterial", value); }
         }
      
         public float CoronaScale
         {
         	get { return float.Parse(getFieldValue("CoronaScale")); }
         	set { setFieldValue("CoronaScale", value.ToString()); }
         }
      
         public ColorF CoronaTint
         {
         	get { return new ColorF(getFieldValue("CoronaTint")); }
         	set { setFieldValue("CoronaTint", value.ToString()); }
         }
      
         public bool CoronaUseLightColor
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CoronaUseLightColor")); }
         	set { setFieldValue("CoronaUseLightColor", value ? "1" : "0"); }
         }
      
         public LightFlareData FlareType
         {
         	get { return Sim.FindObject<LightFlareData>(getFieldValue("FlareType")); }
         	set { setFieldValue("FlareType", value.getId().ToString()); }
         }
      
         public float FlareScale
         {
         	get { return float.Parse(getFieldValue("FlareScale")); }
         	set { setFieldValue("FlareScale", value.ToString()); }
         }
      
         public Point3F AttenuationRatio
         {
         	get { return new Point3F(getFieldValue("AttenuationRatio")); }
         	set { setFieldValue("AttenuationRatio", value.ToString()); }
         }
      
         public ShadowType ShadowType
         {
         	get { return (ShadowType)Enum.Parse(typeof(ShadowType), getFieldValue("ShadowType"), true); }
         	set { setFieldValue("ShadowType", value.ToString()); }
         }
      
         public string Cookie
         {
         	get { return getFieldValue("Cookie"); }
         	set { setFieldValue("Cookie", value); }
         }
      
         public int TexSize
         {
         	get { return int.Parse(getFieldValue("TexSize")); }
         	set { setFieldValue("TexSize", value.ToString()); }
         }
      
         public Point4F OverDarkFactor
         {
         	get { return new Point4F(getFieldValue("OverDarkFactor")); }
         	set { setFieldValue("OverDarkFactor", value.ToString()); }
         }
      
         public float ShadowDistance
         {
         	get { return float.Parse(getFieldValue("ShadowDistance")); }
         	set { setFieldValue("ShadowDistance", value.ToString()); }
         }
      
         public float ShadowSoftness
         {
         	get { return float.Parse(getFieldValue("ShadowSoftness")); }
         	set { setFieldValue("ShadowSoftness", value.ToString()); }
         }
      
         public int NumSplits
         {
         	get { return int.Parse(getFieldValue("NumSplits")); }
         	set { setFieldValue("NumSplits", value.ToString()); }
         }
      
         public float LogWeight
         {
         	get { return float.Parse(getFieldValue("LogWeight")); }
         	set { setFieldValue("LogWeight", value.ToString()); }
         }
      
         public float FadeStartDistance
         {
         	get { return float.Parse(getFieldValue("FadeStartDistance")); }
         	set { setFieldValue("FadeStartDistance", value.ToString()); }
         }
      
         public bool LastSplitTerrainOnly
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("LastSplitTerrainOnly")); }
         	set { setFieldValue("LastSplitTerrainOnly", value ? "1" : "0"); }
         }
      
         public bool RepresentedInLightmap
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RepresentedInLightmap")); }
         	set { setFieldValue("RepresentedInLightmap", value ? "1" : "0"); }
         }
      
         public ColorF ShadowDarkenColor
         {
         	get { return new ColorF(getFieldValue("ShadowDarkenColor")); }
         	set { setFieldValue("ShadowDarkenColor", value.ToString()); }
         }
      
         public bool IncludeLightmappedGeometryInShadow
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IncludeLightmappedGeometryInShadow")); }
         	set { setFieldValue("IncludeLightmappedGeometryInShadow", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}