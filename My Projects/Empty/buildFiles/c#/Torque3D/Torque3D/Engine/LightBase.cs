using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class LightBase : SceneObject
	{
		public LightBase(bool pRegister = false)
			: base(pRegister)
		{
		}

		public LightBase(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public LightBase(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public LightBase(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public LightBase(SimObject pObj) : base(pObj)
		{
		}

		public LightBase(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.LightBase_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setLightEnabled(IntPtr thisPtr, bool state);
         private static _setLightEnabled _setLightEnabledFunc;
         internal static void setLightEnabled(IntPtr thisPtr, bool state)
         {
         	if (_setLightEnabledFunc == null)
         	{
         		_setLightEnabledFunc =
         			(_setLightEnabled)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnLightBase_setLightEnabled"), typeof(_setLightEnabled));
         	}
         
         	 _setLightEnabledFunc(thisPtr, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _playAnimation(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string anim);
         private static _playAnimation _playAnimationFunc;
         internal static void playAnimation(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string anim)
         {
         	if (_playAnimationFunc == null)
         	{
         		_playAnimationFunc =
         			(_playAnimation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnLightBase_playAnimation"), typeof(_playAnimation));
         	}
         
         	 _playAnimationFunc(thisPtr, anim);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _pauseAnimation(IntPtr thisPtr);
         private static _pauseAnimation _pauseAnimationFunc;
         internal static void pauseAnimation(IntPtr thisPtr)
         {
         	if (_pauseAnimationFunc == null)
         	{
         		_pauseAnimationFunc =
         			(_pauseAnimation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnLightBase_pauseAnimation"), typeof(_pauseAnimation));
         	}
         
         	 _pauseAnimationFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _LightBase_create();
         private static _LightBase_create _LightBase_createFunc;
         internal static IntPtr LightBase_create()
         {
         	if (_LightBase_createFunc == null)
         	{
         		_LightBase_createFunc =
         			(_LightBase_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_LightBase_create"), typeof(_LightBase_create));
         	}
         
         	return  _LightBase_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setLightEnabled(bool state)
         {
            InternalUnsafeMethods.setLightEnabled(ObjectPtr, state);
         }
      
         public virtual void playAnimation(string anim = "")
         {
            InternalUnsafeMethods.playAnimation(ObjectPtr, anim);
         }
      
         public virtual void pauseAnimation()
         {
            InternalUnsafeMethods.pauseAnimation(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool IsEnabled
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsEnabled")); }
         	set { setFieldValue("IsEnabled", value ? "1" : "0"); }
         }
      
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
      
         public float Priority
         {
         	get { return float.Parse(getFieldValue("Priority")); }
         	set { setFieldValue("Priority", value.ToString()); }
         }
      
         public bool Animate
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Animate")); }
         	set { setFieldValue("Animate", value ? "1" : "0"); }
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