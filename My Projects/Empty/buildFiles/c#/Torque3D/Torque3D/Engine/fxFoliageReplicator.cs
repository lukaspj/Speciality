using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class fxFoliageReplicator : SceneObject
	{
		public fxFoliageReplicator(bool pRegister = false)
			: base(pRegister)
		{
		}

		public fxFoliageReplicator(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public fxFoliageReplicator(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public fxFoliageReplicator(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public fxFoliageReplicator(SimObject pObj) : base(pObj)
		{
		}

		public fxFoliageReplicator(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.fxFoliageReplicator_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _fxFoliageReplicator_create();
         private static _fxFoliageReplicator_create _fxFoliageReplicator_createFunc;
         internal static IntPtr fxFoliageReplicator_create()
         {
         	if (_fxFoliageReplicator_createFunc == null)
         	{
         		_fxFoliageReplicator_createFunc =
         			(_fxFoliageReplicator_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_fxFoliageReplicator_create"), typeof(_fxFoliageReplicator_create));
         	}
         
         	return  _fxFoliageReplicator_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public bool UseDebugInfo
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseDebugInfo")); }
         	set { setFieldValue("UseDebugInfo", value ? "1" : "0"); }
         }
      
         public float DebugBoxHeight
         {
         	get { return float.Parse(getFieldValue("DebugBoxHeight")); }
         	set { setFieldValue("DebugBoxHeight", value.ToString()); }
         }
      
         public bool HideFoliage
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("HideFoliage")); }
         	set { setFieldValue("HideFoliage", value ? "1" : "0"); }
         }
      
         public bool ShowPlacementArea
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowPlacementArea")); }
         	set { setFieldValue("ShowPlacementArea", value ? "1" : "0"); }
         }
      
         public int PlacementAreaHeight
         {
         	get { return int.Parse(getFieldValue("PlacementAreaHeight")); }
         	set { setFieldValue("PlacementAreaHeight", value.ToString()); }
         }
      
         public ColorF PlacementColour
         {
         	get { return new ColorF(getFieldValue("PlacementColour")); }
         	set { setFieldValue("PlacementColour", value.ToString()); }
         }
      
         public int Seed
         {
         	get { return int.Parse(getFieldValue("Seed")); }
         	set { setFieldValue("Seed", value.ToString()); }
         }
      
         public string FoliageFile
         {
         	get { return getFieldValue("FoliageFile"); }
         	set { setFieldValue("FoliageFile", value); }
         }
      
         public int FoliageCount
         {
         	get { return int.Parse(getFieldValue("FoliageCount")); }
         	set { setFieldValue("FoliageCount", value.ToString()); }
         }
      
         public int FoliageRetries
         {
         	get { return int.Parse(getFieldValue("FoliageRetries")); }
         	set { setFieldValue("FoliageRetries", value.ToString()); }
         }
      
         public int InnerRadiusX
         {
         	get { return int.Parse(getFieldValue("InnerRadiusX")); }
         	set { setFieldValue("InnerRadiusX", value.ToString()); }
         }
      
         public int InnerRadiusY
         {
         	get { return int.Parse(getFieldValue("InnerRadiusY")); }
         	set { setFieldValue("InnerRadiusY", value.ToString()); }
         }
      
         public int OuterRadiusX
         {
         	get { return int.Parse(getFieldValue("OuterRadiusX")); }
         	set { setFieldValue("OuterRadiusX", value.ToString()); }
         }
      
         public int OuterRadiusY
         {
         	get { return int.Parse(getFieldValue("OuterRadiusY")); }
         	set { setFieldValue("OuterRadiusY", value.ToString()); }
         }
      
         public float MinWidth
         {
         	get { return float.Parse(getFieldValue("MinWidth")); }
         	set { setFieldValue("MinWidth", value.ToString()); }
         }
      
         public float MaxWidth
         {
         	get { return float.Parse(getFieldValue("MaxWidth")); }
         	set { setFieldValue("MaxWidth", value.ToString()); }
         }
      
         public float MinHeight
         {
         	get { return float.Parse(getFieldValue("MinHeight")); }
         	set { setFieldValue("MinHeight", value.ToString()); }
         }
      
         public float MaxHeight
         {
         	get { return float.Parse(getFieldValue("MaxHeight")); }
         	set { setFieldValue("MaxHeight", value.ToString()); }
         }
      
         public bool FixAspectRatio
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FixAspectRatio")); }
         	set { setFieldValue("FixAspectRatio", value ? "1" : "0"); }
         }
      
         public bool FixSizeToMax
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FixSizeToMax")); }
         	set { setFieldValue("FixSizeToMax", value ? "1" : "0"); }
         }
      
         public float OffsetZ
         {
         	get { return float.Parse(getFieldValue("OffsetZ")); }
         	set { setFieldValue("OffsetZ", value.ToString()); }
         }
      
         public bool RandomFlip
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RandomFlip")); }
         	set { setFieldValue("RandomFlip", value ? "1" : "0"); }
         }
      
         public bool UseTrueBillboards
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseTrueBillboards")); }
         	set { setFieldValue("UseTrueBillboards", value ? "1" : "0"); }
         }
      
         public bool UseCulling
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseCulling")); }
         	set { setFieldValue("UseCulling", value ? "1" : "0"); }
         }
      
         public int CullResolution
         {
         	get { return int.Parse(getFieldValue("CullResolution")); }
         	set { setFieldValue("CullResolution", value.ToString()); }
         }
      
         public float ViewDistance
         {
         	get { return float.Parse(getFieldValue("ViewDistance")); }
         	set { setFieldValue("ViewDistance", value.ToString()); }
         }
      
         public float ViewClosest
         {
         	get { return float.Parse(getFieldValue("ViewClosest")); }
         	set { setFieldValue("ViewClosest", value.ToString()); }
         }
      
         public float FadeInRegion
         {
         	get { return float.Parse(getFieldValue("FadeInRegion")); }
         	set { setFieldValue("FadeInRegion", value.ToString()); }
         }
      
         public float FadeOutRegion
         {
         	get { return float.Parse(getFieldValue("FadeOutRegion")); }
         	set { setFieldValue("FadeOutRegion", value.ToString()); }
         }
      
         public float AlphaCutoff
         {
         	get { return float.Parse(getFieldValue("AlphaCutoff")); }
         	set { setFieldValue("AlphaCutoff", value.ToString()); }
         }
      
         public float GroundAlpha
         {
         	get { return float.Parse(getFieldValue("GroundAlpha")); }
         	set { setFieldValue("GroundAlpha", value.ToString()); }
         }
      
         public bool SwayOn
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SwayOn")); }
         	set { setFieldValue("SwayOn", value ? "1" : "0"); }
         }
      
         public bool SwaySync
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SwaySync")); }
         	set { setFieldValue("SwaySync", value ? "1" : "0"); }
         }
      
         public float SwayMagSide
         {
         	get { return float.Parse(getFieldValue("SwayMagSide")); }
         	set { setFieldValue("SwayMagSide", value.ToString()); }
         }
      
         public float SwayMagFront
         {
         	get { return float.Parse(getFieldValue("SwayMagFront")); }
         	set { setFieldValue("SwayMagFront", value.ToString()); }
         }
      
         public float MinSwayTime
         {
         	get { return float.Parse(getFieldValue("MinSwayTime")); }
         	set { setFieldValue("MinSwayTime", value.ToString()); }
         }
      
         public float MaxSwayTime
         {
         	get { return float.Parse(getFieldValue("MaxSwayTime")); }
         	set { setFieldValue("MaxSwayTime", value.ToString()); }
         }
      
         public bool LightOn
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("LightOn")); }
         	set { setFieldValue("LightOn", value ? "1" : "0"); }
         }
      
         public bool LightSync
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("LightSync")); }
         	set { setFieldValue("LightSync", value ? "1" : "0"); }
         }
      
         public float MinLuminance
         {
         	get { return float.Parse(getFieldValue("MinLuminance")); }
         	set { setFieldValue("MinLuminance", value.ToString()); }
         }
      
         public float MaxLuminance
         {
         	get { return float.Parse(getFieldValue("MaxLuminance")); }
         	set { setFieldValue("MaxLuminance", value.ToString()); }
         }
      
         public float LightTime
         {
         	get { return float.Parse(getFieldValue("LightTime")); }
         	set { setFieldValue("LightTime", value.ToString()); }
         }
      
         public bool AllowOnTerrain
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowOnTerrain")); }
         	set { setFieldValue("AllowOnTerrain", value ? "1" : "0"); }
         }
      
         public bool AllowOnStatics
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowOnStatics")); }
         	set { setFieldValue("AllowOnStatics", value ? "1" : "0"); }
         }
      
         public bool AllowOnWater
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowOnWater")); }
         	set { setFieldValue("AllowOnWater", value ? "1" : "0"); }
         }
      
         public bool AllowWaterSurface
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowWaterSurface")); }
         	set { setFieldValue("AllowWaterSurface", value ? "1" : "0"); }
         }
      
         public int AllowedTerrainSlope
         {
         	get { return int.Parse(getFieldValue("AllowedTerrainSlope")); }
         	set { setFieldValue("AllowedTerrainSlope", value.ToString()); }
         }
      
      
      #endregion

	}
}