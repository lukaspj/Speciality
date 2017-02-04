using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class LevelInfo : NetObject
	{
		public LevelInfo(bool pRegister = false)
			: base(pRegister)
		{
		}

		public LevelInfo(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public LevelInfo(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public LevelInfo(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public LevelInfo(SimObject pObj) : base(pObj)
		{
		}

		public LevelInfo(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.LevelInfo_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _LevelInfo_create();
         private static _LevelInfo_create _LevelInfo_createFunc;
         internal static IntPtr LevelInfo_create()
         {
         	if (_LevelInfo_createFunc == null)
         	{
         		_LevelInfo_createFunc =
         			(_LevelInfo_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_LevelInfo_create"), typeof(_LevelInfo_create));
         	}
         
         	return  _LevelInfo_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float NearClip
         {
         	get { return float.Parse(getFieldValue("NearClip")); }
         	set { setFieldValue("NearClip", value.ToString()); }
         }
      
         public float VisibleDistance
         {
         	get { return float.Parse(getFieldValue("VisibleDistance")); }
         	set { setFieldValue("VisibleDistance", value.ToString()); }
         }
      
         public float VisibleGhostDistance
         {
         	get { return float.Parse(getFieldValue("VisibleGhostDistance")); }
         	set { setFieldValue("VisibleGhostDistance", value.ToString()); }
         }
      
         public float DecalBias
         {
         	get { return float.Parse(getFieldValue("DecalBias")); }
         	set { setFieldValue("DecalBias", value.ToString()); }
         }
      
         public ColorF FogColor
         {
         	get { return new ColorF(getFieldValue("FogColor")); }
         	set { setFieldValue("FogColor", value.ToString()); }
         }
      
         public float FogDensity
         {
         	get { return float.Parse(getFieldValue("FogDensity")); }
         	set { setFieldValue("FogDensity", value.ToString()); }
         }
      
         public float FogDensityOffset
         {
         	get { return float.Parse(getFieldValue("FogDensityOffset")); }
         	set { setFieldValue("FogDensityOffset", value.ToString()); }
         }
      
         public float FogAtmosphereHeight
         {
         	get { return float.Parse(getFieldValue("FogAtmosphereHeight")); }
         	set { setFieldValue("FogAtmosphereHeight", value.ToString()); }
         }
      
         public ColorI CanvasClearColor
         {
         	get { return new ColorI(getFieldValue("CanvasClearColor")); }
         	set { setFieldValue("CanvasClearColor", value.ToString()); }
         }
      
         public float AmbientLightBlendPhase
         {
         	get { return float.Parse(getFieldValue("AmbientLightBlendPhase")); }
         	set { setFieldValue("AmbientLightBlendPhase", value.ToString()); }
         }
      
         public EaseF AmbientLightBlendCurve
         {
         	get { return new EaseF(getFieldValue("AmbientLightBlendCurve")); }
         	set { setFieldValue("AmbientLightBlendCurve", value.ToString()); }
         }
      
         public bool AdvancedLightmapSupport
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AdvancedLightmapSupport")); }
         	set { setFieldValue("AdvancedLightmapSupport", value ? "1" : "0"); }
         }
      
         public string AccuTexture
         {
         	get { return getFieldValue("AccuTexture"); }
         	set { setFieldValue("AccuTexture", value); }
         }
      
         public SFXAmbience SoundAmbience
         {
         	get { return Sim.FindObject<SFXAmbience>(getFieldValue("SoundAmbience")); }
         	set { setFieldValue("SoundAmbience", value.getId().ToString()); }
         }
      
         public SFXDistanceModel SoundDistanceModel
         {
         	get { return (SFXDistanceModel)Enum.Parse(typeof(SFXDistanceModel), getFieldValue("SoundDistanceModel"), true); }
         	set { setFieldValue("SoundDistanceModel", value.ToString()); }
         }
      
      
      #endregion

	}
}