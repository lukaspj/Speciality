using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GroundCover : SceneObject
	{
		public GroundCover(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GroundCover(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GroundCover(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GroundCover(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GroundCover(SimObject pObj) : base(pObj)
		{
		}

		public GroundCover(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GroundCover_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GroundCover_create();
         private static _GroundCover_create _GroundCover_createFunc;
         internal static IntPtr GroundCover_create()
         {
         	if (_GroundCover_createFunc == null)
         	{
         		_GroundCover_createFunc =
         			(_GroundCover_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GroundCover_create"), typeof(_GroundCover_create));
         	}
         
         	return  _GroundCover_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string Material
         {
         	get { return getFieldValue("Material"); }
         	set { setFieldValue("Material", value); }
         }
      
         public float Radius
         {
         	get { return float.Parse(getFieldValue("Radius")); }
         	set { setFieldValue("Radius", value.ToString()); }
         }
      
         public float DissolveRadius
         {
         	get { return float.Parse(getFieldValue("DissolveRadius")); }
         	set { setFieldValue("DissolveRadius", value.ToString()); }
         }
      
         public float ReflectScale
         {
         	get { return float.Parse(getFieldValue("ReflectScale")); }
         	set { setFieldValue("ReflectScale", value.ToString()); }
         }
      
         public int GridSize
         {
         	get { return int.Parse(getFieldValue("GridSize")); }
         	set { setFieldValue("GridSize", value.ToString()); }
         }
      
         public float ZOffset
         {
         	get { return float.Parse(getFieldValue("ZOffset")); }
         	set { setFieldValue("ZOffset", value.ToString()); }
         }
      
         public int Seed
         {
         	get { return int.Parse(getFieldValue("Seed")); }
         	set { setFieldValue("Seed", value.ToString()); }
         }
      
         public int MaxElements
         {
         	get { return int.Parse(getFieldValue("MaxElements")); }
         	set { setFieldValue("MaxElements", value.ToString()); }
         }
      
         public float MaxBillboardTiltAngle
         {
         	get { return float.Parse(getFieldValue("MaxBillboardTiltAngle")); }
         	set { setFieldValue("MaxBillboardTiltAngle", value.ToString()); }
         }
      
         public float ShapeCullRadius
         {
         	get { return float.Parse(getFieldValue("ShapeCullRadius")); }
         	set { setFieldValue("ShapeCullRadius", value.ToString()); }
         }
      
         public bool ShapesCastShadows
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShapesCastShadows")); }
         	set { setFieldValue("ShapesCastShadows", value ? "1" : "0"); }
         }
      
         public DynamicFieldVector<RectF> BillboardUVs
         {
         	get { return new DynamicFieldVector<RectF>(this, "BillboardUVs", 8, val => new RectF(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<string> ShapeFilename
         {
         	get { return new DynamicFieldVector<string>(this, "ShapeFilename", 8, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> Layer
         {
         	get { return new DynamicFieldVector<string>(this, "Layer", 8, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<bool> InvertLayer
         {
         	get { return new DynamicFieldVector<bool>(this, "InvertLayer", 8, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<float> Probability
         {
         	get { return new DynamicFieldVector<float>(this, "Probability", 8, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> SizeMin
         {
         	get { return new DynamicFieldVector<float>(this, "SizeMin", 8, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> SizeMax
         {
         	get { return new DynamicFieldVector<float>(this, "SizeMax", 8, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> SizeExponent
         {
         	get { return new DynamicFieldVector<float>(this, "SizeExponent", 8, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> WindScale
         {
         	get { return new DynamicFieldVector<float>(this, "WindScale", 8, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> MaxSlope
         {
         	get { return new DynamicFieldVector<float>(this, "MaxSlope", 8, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> MinElevation
         {
         	get { return new DynamicFieldVector<float>(this, "MinElevation", 8, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> MaxElevation
         {
         	get { return new DynamicFieldVector<float>(this, "MaxElevation", 8, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<int> MinClumpCount
         {
         	get { return new DynamicFieldVector<int>(this, "MinClumpCount", 8, val => int.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<int> MaxClumpCount
         {
         	get { return new DynamicFieldVector<int>(this, "MaxClumpCount", 8, val => int.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> ClumpExponent
         {
         	get { return new DynamicFieldVector<float>(this, "ClumpExponent", 8, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> ClumpRadius
         {
         	get { return new DynamicFieldVector<float>(this, "ClumpRadius", 8, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public Point2F WindDirection
         {
         	get { return new Point2F(getFieldValue("WindDirection")); }
         	set { setFieldValue("WindDirection", value.ToString()); }
         }
      
         public float WindGustLength
         {
         	get { return float.Parse(getFieldValue("WindGustLength")); }
         	set { setFieldValue("WindGustLength", value.ToString()); }
         }
      
         public float WindGustFrequency
         {
         	get { return float.Parse(getFieldValue("WindGustFrequency")); }
         	set { setFieldValue("WindGustFrequency", value.ToString()); }
         }
      
         public float WindGustStrength
         {
         	get { return float.Parse(getFieldValue("WindGustStrength")); }
         	set { setFieldValue("WindGustStrength", value.ToString()); }
         }
      
         public float WindTurbulenceFrequency
         {
         	get { return float.Parse(getFieldValue("WindTurbulenceFrequency")); }
         	set { setFieldValue("WindTurbulenceFrequency", value.ToString()); }
         }
      
         public float WindTurbulenceStrength
         {
         	get { return float.Parse(getFieldValue("WindTurbulenceStrength")); }
         	set { setFieldValue("WindTurbulenceStrength", value.ToString()); }
         }
      
         public bool LockFrustum
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("LockFrustum")); }
         	set { setFieldValue("LockFrustum", value ? "1" : "0"); }
         }
      
         public bool RenderCells
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderCells")); }
         	set { setFieldValue("RenderCells", value ? "1" : "0"); }
         }
      
         public bool NoBillboards
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("NoBillboards")); }
         	set { setFieldValue("NoBillboards", value ? "1" : "0"); }
         }
      
         public bool NoShapes
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("NoShapes")); }
         	set { setFieldValue("NoShapes", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}