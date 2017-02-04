using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GFXSamplerStateData : SimObject
	{
		public GFXSamplerStateData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GFXSamplerStateData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GFXSamplerStateData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GFXSamplerStateData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GFXSamplerStateData(SimObject pObj) : base(pObj)
		{
		}

		public GFXSamplerStateData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GFXSamplerStateData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GFXSamplerStateData_create();
         private static _GFXSamplerStateData_create _GFXSamplerStateData_createFunc;
         internal static IntPtr GFXSamplerStateData_create()
         {
         	if (_GFXSamplerStateData_createFunc == null)
         	{
         		_GFXSamplerStateData_createFunc =
         			(_GFXSamplerStateData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GFXSamplerStateData_create"), typeof(_GFXSamplerStateData_create));
         	}
         
         	return  _GFXSamplerStateData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public GFXTextureOp TextureColorOp
         {
         	get { return (GFXTextureOp)Enum.Parse(typeof(GFXTextureOp), getFieldValue("TextureColorOp"), true); }
         	set { setFieldValue("TextureColorOp", value.ToString()); }
         }
      
         public GFXTextureArgument ColorArg1
         {
         	get { return (GFXTextureArgument)Enum.Parse(typeof(GFXTextureArgument), getFieldValue("ColorArg1"), true); }
         	set { setFieldValue("ColorArg1", value.ToString()); }
         }
      
         public GFXTextureArgument ColorArg2
         {
         	get { return (GFXTextureArgument)Enum.Parse(typeof(GFXTextureArgument), getFieldValue("ColorArg2"), true); }
         	set { setFieldValue("ColorArg2", value.ToString()); }
         }
      
         public GFXTextureArgument ColorArg3
         {
         	get { return (GFXTextureArgument)Enum.Parse(typeof(GFXTextureArgument), getFieldValue("ColorArg3"), true); }
         	set { setFieldValue("ColorArg3", value.ToString()); }
         }
      
         public GFXTextureOp AlphaOp
         {
         	get { return (GFXTextureOp)Enum.Parse(typeof(GFXTextureOp), getFieldValue("AlphaOp"), true); }
         	set { setFieldValue("AlphaOp", value.ToString()); }
         }
      
         public GFXTextureArgument AlphaArg1
         {
         	get { return (GFXTextureArgument)Enum.Parse(typeof(GFXTextureArgument), getFieldValue("AlphaArg1"), true); }
         	set { setFieldValue("AlphaArg1", value.ToString()); }
         }
      
         public GFXTextureArgument AlphaArg2
         {
         	get { return (GFXTextureArgument)Enum.Parse(typeof(GFXTextureArgument), getFieldValue("AlphaArg2"), true); }
         	set { setFieldValue("AlphaArg2", value.ToString()); }
         }
      
         public GFXTextureArgument AlphaArg3
         {
         	get { return (GFXTextureArgument)Enum.Parse(typeof(GFXTextureArgument), getFieldValue("AlphaArg3"), true); }
         	set { setFieldValue("AlphaArg3", value.ToString()); }
         }
      
         public GFXTextureAddressMode AddressModeU
         {
         	get { return (GFXTextureAddressMode)Enum.Parse(typeof(GFXTextureAddressMode), getFieldValue("AddressModeU"), true); }
         	set { setFieldValue("AddressModeU", value.ToString()); }
         }
      
         public GFXTextureAddressMode AddressModeV
         {
         	get { return (GFXTextureAddressMode)Enum.Parse(typeof(GFXTextureAddressMode), getFieldValue("AddressModeV"), true); }
         	set { setFieldValue("AddressModeV", value.ToString()); }
         }
      
         public GFXTextureAddressMode AddressModeW
         {
         	get { return (GFXTextureAddressMode)Enum.Parse(typeof(GFXTextureAddressMode), getFieldValue("AddressModeW"), true); }
         	set { setFieldValue("AddressModeW", value.ToString()); }
         }
      
         public GFXTextureFilterType MagFilter
         {
         	get { return (GFXTextureFilterType)Enum.Parse(typeof(GFXTextureFilterType), getFieldValue("MagFilter"), true); }
         	set { setFieldValue("MagFilter", value.ToString()); }
         }
      
         public GFXTextureFilterType MinFilter
         {
         	get { return (GFXTextureFilterType)Enum.Parse(typeof(GFXTextureFilterType), getFieldValue("MinFilter"), true); }
         	set { setFieldValue("MinFilter", value.ToString()); }
         }
      
         public GFXTextureFilterType MipFilter
         {
         	get { return (GFXTextureFilterType)Enum.Parse(typeof(GFXTextureFilterType), getFieldValue("MipFilter"), true); }
         	set { setFieldValue("MipFilter", value.ToString()); }
         }
      
         public float MipLODBias
         {
         	get { return float.Parse(getFieldValue("MipLODBias")); }
         	set { setFieldValue("MipLODBias", value.ToString()); }
         }
      
         public int MaxAnisotropy
         {
         	get { return int.Parse(getFieldValue("MaxAnisotropy")); }
         	set { setFieldValue("MaxAnisotropy", value.ToString()); }
         }
      
         public GFXTextureTransformFlags TextureTransform
         {
         	get { return (GFXTextureTransformFlags)Enum.Parse(typeof(GFXTextureTransformFlags), getFieldValue("TextureTransform"), true); }
         	set { setFieldValue("TextureTransform", value.ToString()); }
         }
      
         public GFXTextureArgument ResultArg
         {
         	get { return (GFXTextureArgument)Enum.Parse(typeof(GFXTextureArgument), getFieldValue("ResultArg"), true); }
         	set { setFieldValue("ResultArg", value.ToString()); }
         }
      
      
      #endregion

	}
}