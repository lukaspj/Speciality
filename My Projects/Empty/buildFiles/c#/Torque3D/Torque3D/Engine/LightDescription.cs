using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class LightDescription : SimDataBlock
	{
		public LightDescription(bool pRegister = false)
			: base(pRegister)
		{
		}

		public LightDescription(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public LightDescription(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public LightDescription(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public LightDescription(SimObject pObj) : base(pObj)
		{
		}

		public LightDescription(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.LightDescription_create();
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
         				"fnLightDescription_apply"), typeof(_apply));
         	}
         
         	 _applyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _LightDescription_create();
         private static _LightDescription_create _LightDescription_createFunc;
         internal static IntPtr LightDescription_create()
         {
         	if (_LightDescription_createFunc == null)
         	{
         		_LightDescription_createFunc =
         			(_LightDescription_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_LightDescription_create"), typeof(_LightDescription_create));
         	}
         
         	return  _LightDescription_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void apply()
         {
            InternalUnsafeMethods.apply(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public ColorF Color
         {
         	get { return new ColorF(getFieldValue("Color")); }
         	set { setFieldValue("Color", value.ToString()); }
         }
      
         public float Brightness
         {
         	get { return float.Parse(getFieldValue("Brightness")); }
         	set { setFieldValue("Brightness", value.ToString()); }
         }
      
         public float Range
         {
         	get { return float.Parse(getFieldValue("Range")); }
         	set { setFieldValue("Range", value.ToString()); }
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
      
         public LightAnimData AnimationType
         {
         	get { return Sim.FindObject<LightAnimData>(getFieldValue("AnimationType")); }
         	set { setFieldValue("AnimationType", value.getId().ToString()); }
         }
      
         public float AnimationPeriod
         {
         	get { return float.Parse(getFieldValue("AnimationPeriod")); }
         	set { setFieldValue("AnimationPeriod", value.ToString()); }
         }
      
         public float AnimationPhase
         {
         	get { return float.Parse(getFieldValue("AnimationPhase")); }
         	set { setFieldValue("AnimationPhase", value.ToString()); }
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