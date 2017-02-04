using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiSeparatorCtrl : GuiControl
	{
		public GuiSeparatorCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiSeparatorCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiSeparatorCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiSeparatorCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiSeparatorCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiSeparatorCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiSeparatorCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiSeparatorCtrl_create();
         private static _GuiSeparatorCtrl_create _GuiSeparatorCtrl_createFunc;
         internal static IntPtr GuiSeparatorCtrl_create()
         {
         	if (_GuiSeparatorCtrl_createFunc == null)
         	{
         		_GuiSeparatorCtrl_createFunc =
         			(_GuiSeparatorCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiSeparatorCtrl_create"), typeof(_GuiSeparatorCtrl_create));
         	}
         
         	return  _GuiSeparatorCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string Caption
         {
         	get { return getFieldValue("Caption"); }
         	set { setFieldValue("Caption", value); }
         }
      
         public GuiSeparatorType Type
         {
         	get { return (GuiSeparatorType)Enum.Parse(typeof(GuiSeparatorType), getFieldValue("Type"), true); }
         	set { setFieldValue("Type", value.ToString()); }
         }
      
         public int BorderMargin
         {
         	get { return int.Parse(getFieldValue("BorderMargin")); }
         	set { setFieldValue("BorderMargin", value.ToString()); }
         }
      
         public bool Invisible
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Invisible")); }
         	set { setFieldValue("Invisible", value ? "1" : "0"); }
         }
      
         public int LeftMargin
         {
         	get { return int.Parse(getFieldValue("LeftMargin")); }
         	set { setFieldValue("LeftMargin", value.ToString()); }
         }
      
      
      #endregion

	}
}