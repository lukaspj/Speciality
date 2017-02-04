using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiShapeNameHud : GuiControl
	{
		public GuiShapeNameHud(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiShapeNameHud(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiShapeNameHud(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiShapeNameHud(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiShapeNameHud(SimObject pObj) : base(pObj)
		{
		}

		public GuiShapeNameHud(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiShapeNameHud_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiShapeNameHud_create();
         private static _GuiShapeNameHud_create _GuiShapeNameHud_createFunc;
         internal static IntPtr GuiShapeNameHud_create()
         {
         	if (_GuiShapeNameHud_createFunc == null)
         	{
         		_GuiShapeNameHud_createFunc =
         			(_GuiShapeNameHud_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiShapeNameHud_create"), typeof(_GuiShapeNameHud_create));
         	}
         
         	return  _GuiShapeNameHud_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public ColorF FillColor
         {
         	get { return new ColorF(getFieldValue("FillColor")); }
         	set { setFieldValue("FillColor", value.ToString()); }
         }
      
         public ColorF FrameColor
         {
         	get { return new ColorF(getFieldValue("FrameColor")); }
         	set { setFieldValue("FrameColor", value.ToString()); }
         }
      
         public ColorF TextColor
         {
         	get { return new ColorF(getFieldValue("TextColor")); }
         	set { setFieldValue("TextColor", value.ToString()); }
         }
      
         public ColorF LabelFillColor
         {
         	get { return new ColorF(getFieldValue("LabelFillColor")); }
         	set { setFieldValue("LabelFillColor", value.ToString()); }
         }
      
         public ColorF LabelFrameColor
         {
         	get { return new ColorF(getFieldValue("LabelFrameColor")); }
         	set { setFieldValue("LabelFrameColor", value.ToString()); }
         }
      
         public bool ShowFill
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowFill")); }
         	set { setFieldValue("ShowFill", value ? "1" : "0"); }
         }
      
         public bool ShowFrame
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowFrame")); }
         	set { setFieldValue("ShowFrame", value ? "1" : "0"); }
         }
      
         public bool ShowLabelFill
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowLabelFill")); }
         	set { setFieldValue("ShowLabelFill", value ? "1" : "0"); }
         }
      
         public bool ShowLabelFrame
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowLabelFrame")); }
         	set { setFieldValue("ShowLabelFrame", value ? "1" : "0"); }
         }
      
         public Point2I LabelPadding
         {
         	get { return new Point2I(getFieldValue("LabelPadding")); }
         	set { setFieldValue("LabelPadding", value.ToString()); }
         }
      
         public float VerticalOffset
         {
         	get { return float.Parse(getFieldValue("VerticalOffset")); }
         	set { setFieldValue("VerticalOffset", value.ToString()); }
         }
      
         public float DistanceFade
         {
         	get { return float.Parse(getFieldValue("DistanceFade")); }
         	set { setFieldValue("DistanceFade", value.ToString()); }
         }
      
      
      #endregion

	}
}