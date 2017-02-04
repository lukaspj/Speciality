using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ScatterSky : SceneObject
	{
		public ScatterSky(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ScatterSky(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ScatterSky(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ScatterSky(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ScatterSky(SimObject pObj) : base(pObj)
		{
		}

		public ScatterSky(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ScatterSky_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _applyChanges(IntPtr thisPtr);
         private static _applyChanges _applyChangesFunc;
         internal static void applyChanges(IntPtr thisPtr)
         {
         	if (_applyChangesFunc == null)
         	{
         		_applyChangesFunc =
         			(_applyChanges)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnScatterSky_applyChanges"), typeof(_applyChanges));
         	}
         
         	 _applyChangesFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ScatterSky_create();
         private static _ScatterSky_create _ScatterSky_createFunc;
         internal static IntPtr ScatterSky_create()
         {
         	if (_ScatterSky_createFunc == null)
         	{
         		_ScatterSky_createFunc =
         			(_ScatterSky_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ScatterSky_create"), typeof(_ScatterSky_create));
         	}
         
         	return  _ScatterSky_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void applyChanges()
         {
            InternalUnsafeMethods.applyChanges(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public float SkyBrightness
         {
         	get { return float.Parse(getFieldValue("SkyBrightness")); }
         	set { setFieldValue("SkyBrightness", value.ToString()); }
         }
      
         public float SunSize
         {
         	get { return float.Parse(getFieldValue("SunSize")); }
         	set { setFieldValue("SunSize", value.ToString()); }
         }
      
         public float ColorizeAmount
         {
         	get { return float.Parse(getFieldValue("ColorizeAmount")); }
         	set { setFieldValue("ColorizeAmount", value.ToString()); }
         }
      
         public ColorF Colorize
         {
         	get { return new ColorF(getFieldValue("Colorize")); }
         	set { setFieldValue("Colorize", value.ToString()); }
         }
      
         public float RayleighScattering
         {
         	get { return float.Parse(getFieldValue("RayleighScattering")); }
         	set { setFieldValue("RayleighScattering", value.ToString()); }
         }
      
         public ColorF SunScale
         {
         	get { return new ColorF(getFieldValue("SunScale")); }
         	set { setFieldValue("SunScale", value.ToString()); }
         }
      
         public ColorF AmbientScale
         {
         	get { return new ColorF(getFieldValue("AmbientScale")); }
         	set { setFieldValue("AmbientScale", value.ToString()); }
         }
      
         public ColorF FogScale
         {
         	get { return new ColorF(getFieldValue("FogScale")); }
         	set { setFieldValue("FogScale", value.ToString()); }
         }
      
         public float Exposure
         {
         	get { return float.Parse(getFieldValue("Exposure")); }
         	set { setFieldValue("Exposure", value.ToString()); }
         }
      
         public float ZOffset
         {
         	get { return float.Parse(getFieldValue("ZOffset")); }
         	set { setFieldValue("ZOffset", value.ToString()); }
         }
      
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
      
         public float MoonAzimuth
         {
         	get { return float.Parse(getFieldValue("MoonAzimuth")); }
         	set { setFieldValue("MoonAzimuth", value.ToString()); }
         }
      
         public float MoonElevation
         {
         	get { return float.Parse(getFieldValue("MoonElevation")); }
         	set { setFieldValue("MoonElevation", value.ToString()); }
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
      
         public float Brightness
         {
         	get { return float.Parse(getFieldValue("Brightness")); }
         	set { setFieldValue("Brightness", value.ToString()); }
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
      
         public ColorF NightColor
         {
         	get { return new ColorF(getFieldValue("NightColor")); }
         	set { setFieldValue("NightColor", value.ToString()); }
         }
      
         public ColorF NightFogColor
         {
         	get { return new ColorF(getFieldValue("NightFogColor")); }
         	set { setFieldValue("NightFogColor", value.ToString()); }
         }
      
         public bool MoonEnabled
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("MoonEnabled")); }
         	set { setFieldValue("MoonEnabled", value ? "1" : "0"); }
         }
      
         public string MoonMat
         {
         	get { return getFieldValue("MoonMat"); }
         	set { setFieldValue("MoonMat", value); }
         }
      
         public float MoonScale
         {
         	get { return float.Parse(getFieldValue("MoonScale")); }
         	set { setFieldValue("MoonScale", value.ToString()); }
         }
      
         public ColorF MoonLightColor
         {
         	get { return new ColorF(getFieldValue("MoonLightColor")); }
         	set { setFieldValue("MoonLightColor", value.ToString()); }
         }
      
         public bool UseNightCubemap
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseNightCubemap")); }
         	set { setFieldValue("UseNightCubemap", value ? "1" : "0"); }
         }
      
         public string NightCubemap
         {
         	get { return getFieldValue("NightCubemap"); }
         	set { setFieldValue("NightCubemap", value); }
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