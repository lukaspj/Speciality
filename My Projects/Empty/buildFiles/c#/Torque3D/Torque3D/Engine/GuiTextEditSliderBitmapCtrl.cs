using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiTextEditSliderBitmapCtrl : GuiTextEditCtrl
	{
		public GuiTextEditSliderBitmapCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiTextEditSliderBitmapCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiTextEditSliderBitmapCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiTextEditSliderBitmapCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiTextEditSliderBitmapCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiTextEditSliderBitmapCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiTextEditSliderBitmapCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTextEditSliderBitmapCtrl_create();
         private static _GuiTextEditSliderBitmapCtrl_create _GuiTextEditSliderBitmapCtrl_createFunc;
         internal static IntPtr GuiTextEditSliderBitmapCtrl_create()
         {
         	if (_GuiTextEditSliderBitmapCtrl_createFunc == null)
         	{
         		_GuiTextEditSliderBitmapCtrl_createFunc =
         			(_GuiTextEditSliderBitmapCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiTextEditSliderBitmapCtrl_create"), typeof(_GuiTextEditSliderBitmapCtrl_create));
         	}
         
         	return  _GuiTextEditSliderBitmapCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string Format
         {
         	get { return getFieldValue("Format"); }
         	set { setFieldValue("Format", value); }
         }
      
         public Point2F Range
         {
         	get { return new Point2F(getFieldValue("Range")); }
         	set { setFieldValue("Range", value.ToString()); }
         }
      
         public float Increment
         {
         	get { return float.Parse(getFieldValue("Increment")); }
         	set { setFieldValue("Increment", value.ToString()); }
         }
      
         public bool FocusOnMouseWheel
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FocusOnMouseWheel")); }
         	set { setFieldValue("FocusOnMouseWheel", value ? "1" : "0"); }
         }
      
         public string Bitmap
         {
         	get { return getFieldValue("Bitmap"); }
         	set { setFieldValue("Bitmap", value); }
         }
      
      
      #endregion

	}
}