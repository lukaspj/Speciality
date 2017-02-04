using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GFXStateBlockData : SimObject
	{
		public GFXStateBlockData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GFXStateBlockData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GFXStateBlockData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GFXStateBlockData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GFXStateBlockData(SimObject pObj) : base(pObj)
		{
		}

		public GFXStateBlockData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GFXStateBlockData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GFXStateBlockData_create();
         private static _GFXStateBlockData_create _GFXStateBlockData_createFunc;
         internal static IntPtr GFXStateBlockData_create()
         {
         	if (_GFXStateBlockData_createFunc == null)
         	{
         		_GFXStateBlockData_createFunc =
         			(_GFXStateBlockData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GFXStateBlockData_create"), typeof(_GFXStateBlockData_create));
         	}
         
         	return  _GFXStateBlockData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public bool BlendDefined
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("BlendDefined")); }
         	set { setFieldValue("BlendDefined", value ? "1" : "0"); }
         }
      
         public bool BlendEnable
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("BlendEnable")); }
         	set { setFieldValue("BlendEnable", value ? "1" : "0"); }
         }
      
         public GFXBlend BlendSrc
         {
         	get { return (GFXBlend)Enum.Parse(typeof(GFXBlend), getFieldValue("BlendSrc"), true); }
         	set { setFieldValue("BlendSrc", value.ToString()); }
         }
      
         public GFXBlend BlendDest
         {
         	get { return (GFXBlend)Enum.Parse(typeof(GFXBlend), getFieldValue("BlendDest"), true); }
         	set { setFieldValue("BlendDest", value.ToString()); }
         }
      
         public GFXBlendOp BlendOp
         {
         	get { return (GFXBlendOp)Enum.Parse(typeof(GFXBlendOp), getFieldValue("BlendOp"), true); }
         	set { setFieldValue("BlendOp", value.ToString()); }
         }
      
         public bool SeparateAlphaBlendDefined
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SeparateAlphaBlendDefined")); }
         	set { setFieldValue("SeparateAlphaBlendDefined", value ? "1" : "0"); }
         }
      
         public bool SeparateAlphaBlendEnable
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SeparateAlphaBlendEnable")); }
         	set { setFieldValue("SeparateAlphaBlendEnable", value ? "1" : "0"); }
         }
      
         public GFXBlend SeparateAlphaBlendSrc
         {
         	get { return (GFXBlend)Enum.Parse(typeof(GFXBlend), getFieldValue("SeparateAlphaBlendSrc"), true); }
         	set { setFieldValue("SeparateAlphaBlendSrc", value.ToString()); }
         }
      
         public GFXBlend SeparateAlphaBlendDest
         {
         	get { return (GFXBlend)Enum.Parse(typeof(GFXBlend), getFieldValue("SeparateAlphaBlendDest"), true); }
         	set { setFieldValue("SeparateAlphaBlendDest", value.ToString()); }
         }
      
         public GFXBlendOp SeparateAlphaBlendOp
         {
         	get { return (GFXBlendOp)Enum.Parse(typeof(GFXBlendOp), getFieldValue("SeparateAlphaBlendOp"), true); }
         	set { setFieldValue("SeparateAlphaBlendOp", value.ToString()); }
         }
      
         public bool AlphaDefined
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AlphaDefined")); }
         	set { setFieldValue("AlphaDefined", value ? "1" : "0"); }
         }
      
         public bool AlphaTestEnable
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AlphaTestEnable")); }
         	set { setFieldValue("AlphaTestEnable", value ? "1" : "0"); }
         }
      
         public GFXCmpFunc AlphaTestFunc
         {
         	get { return (GFXCmpFunc)Enum.Parse(typeof(GFXCmpFunc), getFieldValue("AlphaTestFunc"), true); }
         	set { setFieldValue("AlphaTestFunc", value.ToString()); }
         }
      
         public int AlphaTestRef
         {
         	get { return int.Parse(getFieldValue("AlphaTestRef")); }
         	set { setFieldValue("AlphaTestRef", value.ToString()); }
         }
      
         public bool ColorWriteDefined
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ColorWriteDefined")); }
         	set { setFieldValue("ColorWriteDefined", value ? "1" : "0"); }
         }
      
         public bool ColorWriteRed
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ColorWriteRed")); }
         	set { setFieldValue("ColorWriteRed", value ? "1" : "0"); }
         }
      
         public bool ColorWriteBlue
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ColorWriteBlue")); }
         	set { setFieldValue("ColorWriteBlue", value ? "1" : "0"); }
         }
      
         public bool ColorWriteGreen
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ColorWriteGreen")); }
         	set { setFieldValue("ColorWriteGreen", value ? "1" : "0"); }
         }
      
         public bool ColorWriteAlpha
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ColorWriteAlpha")); }
         	set { setFieldValue("ColorWriteAlpha", value ? "1" : "0"); }
         }
      
         public bool CullDefined
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CullDefined")); }
         	set { setFieldValue("CullDefined", value ? "1" : "0"); }
         }
      
         public GFXCullMode CullMode
         {
         	get { return (GFXCullMode)Enum.Parse(typeof(GFXCullMode), getFieldValue("CullMode"), true); }
         	set { setFieldValue("CullMode", value.ToString()); }
         }
      
         public bool ZDefined
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ZDefined")); }
         	set { setFieldValue("ZDefined", value ? "1" : "0"); }
         }
      
         public bool ZEnable
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ZEnable")); }
         	set { setFieldValue("ZEnable", value ? "1" : "0"); }
         }
      
         public bool ZWriteEnable
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ZWriteEnable")); }
         	set { setFieldValue("ZWriteEnable", value ? "1" : "0"); }
         }
      
         public GFXCmpFunc ZFunc
         {
         	get { return (GFXCmpFunc)Enum.Parse(typeof(GFXCmpFunc), getFieldValue("ZFunc"), true); }
         	set { setFieldValue("ZFunc", value.ToString()); }
         }
      
         public float ZBias
         {
         	get { return float.Parse(getFieldValue("ZBias")); }
         	set { setFieldValue("ZBias", value.ToString()); }
         }
      
         public float ZSlopeBias
         {
         	get { return float.Parse(getFieldValue("ZSlopeBias")); }
         	set { setFieldValue("ZSlopeBias", value.ToString()); }
         }
      
         public bool StencilDefined
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("StencilDefined")); }
         	set { setFieldValue("StencilDefined", value ? "1" : "0"); }
         }
      
         public bool StencilEnable
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("StencilEnable")); }
         	set { setFieldValue("StencilEnable", value ? "1" : "0"); }
         }
      
         public GFXStencilOp StencilFailOp
         {
         	get { return (GFXStencilOp)Enum.Parse(typeof(GFXStencilOp), getFieldValue("StencilFailOp"), true); }
         	set { setFieldValue("StencilFailOp", value.ToString()); }
         }
      
         public GFXStencilOp StencilZFailOp
         {
         	get { return (GFXStencilOp)Enum.Parse(typeof(GFXStencilOp), getFieldValue("StencilZFailOp"), true); }
         	set { setFieldValue("StencilZFailOp", value.ToString()); }
         }
      
         public GFXStencilOp StencilPassOp
         {
         	get { return (GFXStencilOp)Enum.Parse(typeof(GFXStencilOp), getFieldValue("StencilPassOp"), true); }
         	set { setFieldValue("StencilPassOp", value.ToString()); }
         }
      
         public GFXCmpFunc StencilFunc
         {
         	get { return (GFXCmpFunc)Enum.Parse(typeof(GFXCmpFunc), getFieldValue("StencilFunc"), true); }
         	set { setFieldValue("StencilFunc", value.ToString()); }
         }
      
         public int StencilRef
         {
         	get { return int.Parse(getFieldValue("StencilRef")); }
         	set { setFieldValue("StencilRef", value.ToString()); }
         }
      
         public int StencilMask
         {
         	get { return int.Parse(getFieldValue("StencilMask")); }
         	set { setFieldValue("StencilMask", value.ToString()); }
         }
      
         public int StencilWriteMask
         {
         	get { return int.Parse(getFieldValue("StencilWriteMask")); }
         	set { setFieldValue("StencilWriteMask", value.ToString()); }
         }
      
         public bool FfLighting
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FfLighting")); }
         	set { setFieldValue("FfLighting", value ? "1" : "0"); }
         }
      
         public bool VertexColorEnable
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("VertexColorEnable")); }
         	set { setFieldValue("VertexColorEnable", value ? "1" : "0"); }
         }
      
         public bool SamplersDefined
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SamplersDefined")); }
         	set { setFieldValue("SamplersDefined", value ? "1" : "0"); }
         }
      
         public DynamicFieldVector<GFXSamplerStateData> SamplerStates
         {
         	get { return new DynamicFieldVector<GFXSamplerStateData>(this, "SamplerStates", 16, val => Sim.FindObject<GFXSamplerStateData>(val), obj => obj.getId().ToString()); }
         }
      
         public ColorI TextureFactor
         {
         	get { return new ColorI(getFieldValue("TextureFactor")); }
         	set { setFieldValue("TextureFactor", value.ToString()); }
         }
      
      
      #endregion

	}
}