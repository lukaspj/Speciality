using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class fxShapeReplicatedStatic : SceneObject
	{
		public fxShapeReplicatedStatic(bool pRegister = false)
			: base(pRegister)
		{
		}

		public fxShapeReplicatedStatic(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public fxShapeReplicatedStatic(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public fxShapeReplicatedStatic(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public fxShapeReplicatedStatic(SimObject pObj) : base(pObj)
		{
		}

		public fxShapeReplicatedStatic(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.fxShapeReplicatedStatic_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _fxShapeReplicatedStatic_create();
         private static _fxShapeReplicatedStatic_create _fxShapeReplicatedStatic_createFunc;
         internal static IntPtr fxShapeReplicatedStatic_create()
         {
         	if (_fxShapeReplicatedStatic_createFunc == null)
         	{
         		_fxShapeReplicatedStatic_createFunc =
         			(_fxShapeReplicatedStatic_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_fxShapeReplicatedStatic_create"), typeof(_fxShapeReplicatedStatic_create));
         	}
         
         	return  _fxShapeReplicatedStatic_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string ShapeName
         {
         	get { return getFieldValue("ShapeName"); }
         	set { setFieldValue("ShapeName", value); }
         }
      
         public string Skin
         {
         	get { return getFieldValue("Skin"); }
         	set { setFieldValue("Skin", value); }
         }
      
         public bool PlayAmbient
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("PlayAmbient")); }
         	set { setFieldValue("PlayAmbient", value ? "1" : "0"); }
         }
      
         public bool MeshCulling
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("MeshCulling")); }
         	set { setFieldValue("MeshCulling", value ? "1" : "0"); }
         }
      
         public bool OriginSort
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OriginSort")); }
         	set { setFieldValue("OriginSort", value ? "1" : "0"); }
         }
      
         public string CubeReflectorDesc
         {
         	get { return getFieldValue("CubeReflectorDesc"); }
         	set { setFieldValue("CubeReflectorDesc", value); }
         }
      
         public TSMeshType CollisionType
         {
         	get { return (TSMeshType)Enum.Parse(typeof(TSMeshType), getFieldValue("CollisionType"), true); }
         	set { setFieldValue("CollisionType", value.ToString()); }
         }
      
         public TSMeshType DecalType
         {
         	get { return (TSMeshType)Enum.Parse(typeof(TSMeshType), getFieldValue("DecalType"), true); }
         	set { setFieldValue("DecalType", value.ToString()); }
         }
      
         public bool AllowPlayerStep
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowPlayerStep")); }
         	set { setFieldValue("AllowPlayerStep", value ? "1" : "0"); }
         }
      
         public bool AlphaFadeEnable
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AlphaFadeEnable")); }
         	set { setFieldValue("AlphaFadeEnable", value ? "1" : "0"); }
         }
      
         public float AlphaFadeStart
         {
         	get { return float.Parse(getFieldValue("AlphaFadeStart")); }
         	set { setFieldValue("AlphaFadeStart", value.ToString()); }
         }
      
         public float AlphaFadeEnd
         {
         	get { return float.Parse(getFieldValue("AlphaFadeEnd")); }
         	set { setFieldValue("AlphaFadeEnd", value.ToString()); }
         }
      
         public bool AlphaFadeInverse
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AlphaFadeInverse")); }
         	set { setFieldValue("AlphaFadeInverse", value ? "1" : "0"); }
         }
      
         public float RenderNormals
         {
         	get { return float.Parse(getFieldValue("RenderNormals")); }
         	set { setFieldValue("RenderNormals", value.ToString()); }
         }
      
         public int ForceDetail
         {
         	get { return int.Parse(getFieldValue("ForceDetail")); }
         	set { setFieldValue("ForceDetail", value.ToString()); }
         }
      
      
      #endregion

	}
}