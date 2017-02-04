using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class fxShapeReplicator : SceneObject
	{
		public fxShapeReplicator(bool pRegister = false)
			: base(pRegister)
		{
		}

		public fxShapeReplicator(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public fxShapeReplicator(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public fxShapeReplicator(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public fxShapeReplicator(SimObject pObj) : base(pObj)
		{
		}

		public fxShapeReplicator(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.fxShapeReplicator_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _fxShapeReplicator_create();
         private static _fxShapeReplicator_create _fxShapeReplicator_createFunc;
         internal static IntPtr fxShapeReplicator_create()
         {
         	if (_fxShapeReplicator_createFunc == null)
         	{
         		_fxShapeReplicator_createFunc =
         			(_fxShapeReplicator_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_fxShapeReplicator_create"), typeof(_fxShapeReplicator_create));
         	}
         
         	return  _fxShapeReplicator_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public bool HideReplications
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("HideReplications")); }
         	set { setFieldValue("HideReplications", value ? "1" : "0"); }
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
      
         public string ShapeFile
         {
         	get { return getFieldValue("ShapeFile"); }
         	set { setFieldValue("ShapeFile", value); }
         }
      
         public int Seed
         {
         	get { return int.Parse(getFieldValue("Seed")); }
         	set { setFieldValue("Seed", value.ToString()); }
         }
      
         public int ShapeCount
         {
         	get { return int.Parse(getFieldValue("ShapeCount")); }
         	set { setFieldValue("ShapeCount", value.ToString()); }
         }
      
         public int ShapeRetries
         {
         	get { return int.Parse(getFieldValue("ShapeRetries")); }
         	set { setFieldValue("ShapeRetries", value.ToString()); }
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
      
         public bool AlignToTerrain
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AlignToTerrain")); }
         	set { setFieldValue("AlignToTerrain", value ? "1" : "0"); }
         }
      
         public bool Interactions
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Interactions")); }
         	set { setFieldValue("Interactions", value ? "1" : "0"); }
         }
      
         public int AllowedTerrainSlope
         {
         	get { return int.Parse(getFieldValue("AllowedTerrainSlope")); }
         	set { setFieldValue("AllowedTerrainSlope", value.ToString()); }
         }
      
         public Point3F TerrainAlignment
         {
         	get { return new Point3F(getFieldValue("TerrainAlignment")); }
         	set { setFieldValue("TerrainAlignment", value.ToString()); }
         }
      
         public Point3F ShapeScaleMin
         {
         	get { return new Point3F(getFieldValue("ShapeScaleMin")); }
         	set { setFieldValue("ShapeScaleMin", value.ToString()); }
         }
      
         public Point3F ShapeScaleMax
         {
         	get { return new Point3F(getFieldValue("ShapeScaleMax")); }
         	set { setFieldValue("ShapeScaleMax", value.ToString()); }
         }
      
         public Point3F ShapeRotateMin
         {
         	get { return new Point3F(getFieldValue("ShapeRotateMin")); }
         	set { setFieldValue("ShapeRotateMin", value.ToString()); }
         }
      
         public Point3F ShapeRotateMax
         {
         	get { return new Point3F(getFieldValue("ShapeRotateMax")); }
         	set { setFieldValue("ShapeRotateMax", value.ToString()); }
         }
      
         public int OffsetZ
         {
         	get { return int.Parse(getFieldValue("OffsetZ")); }
         	set { setFieldValue("OffsetZ", value.ToString()); }
         }
      
      
      #endregion

	}
}