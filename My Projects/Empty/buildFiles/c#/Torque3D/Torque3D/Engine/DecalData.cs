using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class DecalData : SimDataBlock
	{
		public DecalData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public DecalData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public DecalData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public DecalData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public DecalData(SimObject pObj) : base(pObj)
		{
		}

		public DecalData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.DecalData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _postApply(IntPtr thisPtr);
         private static _postApply _postApplyFunc;
         internal static void postApply(IntPtr thisPtr)
         {
         	if (_postApplyFunc == null)
         	{
         		_postApplyFunc =
         			(_postApply)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnDecalData_postApply"), typeof(_postApply));
         	}
         
         	 _postApplyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DecalData_create();
         private static _DecalData_create _DecalData_createFunc;
         internal static IntPtr DecalData_create()
         {
         	if (_DecalData_createFunc == null)
         	{
         		_DecalData_createFunc =
         			(_DecalData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_DecalData_create"), typeof(_DecalData_create));
         	}
         
         	return  _DecalData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void postApply()
         {
            InternalUnsafeMethods.postApply(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public float Size
         {
         	get { return float.Parse(getFieldValue("Size")); }
         	set { setFieldValue("Size", value.ToString()); }
         }
      
         public string Material
         {
         	get { return getFieldValue("Material"); }
         	set { setFieldValue("Material", value); }
         }
      
         public int LifeSpan
         {
         	get { return int.Parse(getFieldValue("LifeSpan")); }
         	set { setFieldValue("LifeSpan", value.ToString()); }
         }
      
         public int FadeTime
         {
         	get { return int.Parse(getFieldValue("FadeTime")); }
         	set { setFieldValue("FadeTime", value.ToString()); }
         }
      
         public float FadeStartPixelSize
         {
         	get { return float.Parse(getFieldValue("FadeStartPixelSize")); }
         	set { setFieldValue("FadeStartPixelSize", value.ToString()); }
         }
      
         public float FadeEndPixelSize
         {
         	get { return float.Parse(getFieldValue("FadeEndPixelSize")); }
         	set { setFieldValue("FadeEndPixelSize", value.ToString()); }
         }
      
         public byte RenderPriority
         {
         	get { return byte.Parse(getFieldValue("RenderPriority")); }
         	set { setFieldValue("RenderPriority", value.ToString()); }
         }
      
         public float ClippingAngle
         {
         	get { return float.Parse(getFieldValue("ClippingAngle")); }
         	set { setFieldValue("ClippingAngle", value.ToString()); }
         }
      
         public int Frame
         {
         	get { return int.Parse(getFieldValue("Frame")); }
         	set { setFieldValue("Frame", value.ToString()); }
         }
      
         public bool Randomize
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Randomize")); }
         	set { setFieldValue("Randomize", value ? "1" : "0"); }
         }
      
         public int TextureCoordCount
         {
         	get { return int.Parse(getFieldValue("TextureCoordCount")); }
         	set { setFieldValue("TextureCoordCount", value.ToString()); }
         }
      
         public int TexRows
         {
         	get { return int.Parse(getFieldValue("TexRows")); }
         	set { setFieldValue("TexRows", value.ToString()); }
         }
      
         public int TexCols
         {
         	get { return int.Parse(getFieldValue("TexCols")); }
         	set { setFieldValue("TexCols", value.ToString()); }
         }
      
         public DynamicFieldVector<RectF> TextureCoords
         {
         	get { return new DynamicFieldVector<RectF>(this, "TextureCoords", 16, val => new RectF(val), obj => obj.ToString()); }
         }
      
      
      #endregion

	}
}