using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RibbonData : GameBaseData
	{
		public RibbonData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RibbonData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RibbonData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RibbonData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RibbonData(SimObject pObj) : base(pObj)
		{
		}

		public RibbonData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RibbonData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RibbonData_create();
         private static _RibbonData_create _RibbonData_createFunc;
         internal static IntPtr RibbonData_create()
         {
         	if (_RibbonData_createFunc == null)
         	{
         		_RibbonData_createFunc =
         			(_RibbonData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RibbonData_create"), typeof(_RibbonData_create));
         	}
         
         	return  _RibbonData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public DynamicFieldVector<float> Size
         {
         	get { return new DynamicFieldVector<float>(this, "Size", 4, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<ColorF> Color
         {
         	get { return new DynamicFieldVector<ColorF>(this, "Color", 4, val => new ColorF(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> Position
         {
         	get { return new DynamicFieldVector<float>(this, "Position", 4, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public int RibbonLength
         {
         	get { return int.Parse(getFieldValue("RibbonLength")); }
         	set { setFieldValue("RibbonLength", value.ToString()); }
         }
      
         public int SegmentsPerUpdate
         {
         	get { return int.Parse(getFieldValue("SegmentsPerUpdate")); }
         	set { setFieldValue("SegmentsPerUpdate", value.ToString()); }
         }
      
         public int SkipAmount
         {
         	get { return int.Parse(getFieldValue("SkipAmount")); }
         	set { setFieldValue("SkipAmount", value.ToString()); }
         }
      
         public bool UseFadeOut
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseFadeOut")); }
         	set { setFieldValue("UseFadeOut", value ? "1" : "0"); }
         }
      
         public float FadeAwayStep
         {
         	get { return float.Parse(getFieldValue("FadeAwayStep")); }
         	set { setFieldValue("FadeAwayStep", value.ToString()); }
         }
      
         public string RibbonMaterial
         {
         	get { return getFieldValue("RibbonMaterial"); }
         	set { setFieldValue("RibbonMaterial", value); }
         }
      
         public float TileScale
         {
         	get { return float.Parse(getFieldValue("TileScale")); }
         	set { setFieldValue("TileScale", value.ToString()); }
         }
      
         public bool FixedTexcoords
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FixedTexcoords")); }
         	set { setFieldValue("FixedTexcoords", value ? "1" : "0"); }
         }
      
         public bool TexcoordsRelativeToDistance
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("TexcoordsRelativeToDistance")); }
         	set { setFieldValue("TexcoordsRelativeToDistance", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}