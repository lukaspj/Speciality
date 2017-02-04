using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiTextEditSliderCtrl : GuiTextEditCtrl
	{
		public GuiTextEditSliderCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiTextEditSliderCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiTextEditSliderCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiTextEditSliderCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiTextEditSliderCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiTextEditSliderCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiTextEditSliderCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTextEditSliderCtrl_create();
         private static _GuiTextEditSliderCtrl_create _GuiTextEditSliderCtrl_createFunc;
         internal static IntPtr GuiTextEditSliderCtrl_create()
         {
         	if (_GuiTextEditSliderCtrl_createFunc == null)
         	{
         		_GuiTextEditSliderCtrl_createFunc =
         			(_GuiTextEditSliderCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiTextEditSliderCtrl_create"), typeof(_GuiTextEditSliderCtrl_create));
         	}
         
         	return  _GuiTextEditSliderCtrl_createFunc();
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
      
      
      #endregion

	}
}