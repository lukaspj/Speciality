using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class TerrainMaterial : SimObject
	{
		public TerrainMaterial(bool pRegister = false)
			: base(pRegister)
		{
		}

		public TerrainMaterial(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public TerrainMaterial(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public TerrainMaterial(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public TerrainMaterial(SimObject pObj) : base(pObj)
		{
		}

		public TerrainMaterial(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.TerrainMaterial_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TerrainMaterial_create();
         private static _TerrainMaterial_create _TerrainMaterial_createFunc;
         internal static IntPtr TerrainMaterial_create()
         {
         	if (_TerrainMaterial_createFunc == null)
         	{
         		_TerrainMaterial_createFunc =
         			(_TerrainMaterial_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_TerrainMaterial_create"), typeof(_TerrainMaterial_create));
         	}
         
         	return  _TerrainMaterial_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string DiffuseMap
         {
         	get { return getFieldValue("DiffuseMap"); }
         	set { setFieldValue("DiffuseMap", value); }
         }
      
         public float DiffuseSize
         {
         	get { return float.Parse(getFieldValue("DiffuseSize")); }
         	set { setFieldValue("DiffuseSize", value.ToString()); }
         }
      
         public string NormalMap
         {
         	get { return getFieldValue("NormalMap"); }
         	set { setFieldValue("NormalMap", value); }
         }
      
         public string DetailMap
         {
         	get { return getFieldValue("DetailMap"); }
         	set { setFieldValue("DetailMap", value); }
         }
      
         public float DetailSize
         {
         	get { return float.Parse(getFieldValue("DetailSize")); }
         	set { setFieldValue("DetailSize", value.ToString()); }
         }
      
         public float DetailStrength
         {
         	get { return float.Parse(getFieldValue("DetailStrength")); }
         	set { setFieldValue("DetailStrength", value.ToString()); }
         }
      
         public float DetailDistance
         {
         	get { return float.Parse(getFieldValue("DetailDistance")); }
         	set { setFieldValue("DetailDistance", value.ToString()); }
         }
      
         public bool UseSideProjection
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseSideProjection")); }
         	set { setFieldValue("UseSideProjection", value ? "1" : "0"); }
         }
      
         public string MacroMap
         {
         	get { return getFieldValue("MacroMap"); }
         	set { setFieldValue("MacroMap", value); }
         }
      
         public float MacroSize
         {
         	get { return float.Parse(getFieldValue("MacroSize")); }
         	set { setFieldValue("MacroSize", value.ToString()); }
         }
      
         public float MacroStrength
         {
         	get { return float.Parse(getFieldValue("MacroStrength")); }
         	set { setFieldValue("MacroStrength", value.ToString()); }
         }
      
         public float MacroDistance
         {
         	get { return float.Parse(getFieldValue("MacroDistance")); }
         	set { setFieldValue("MacroDistance", value.ToString()); }
         }
      
         public float ParallaxScale
         {
         	get { return float.Parse(getFieldValue("ParallaxScale")); }
         	set { setFieldValue("ParallaxScale", value.ToString()); }
         }
      
      
      #endregion

	}
}