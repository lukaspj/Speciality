using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiScriptNotifyCtrl : GuiControl
	{
		public GuiScriptNotifyCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiScriptNotifyCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiScriptNotifyCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiScriptNotifyCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiScriptNotifyCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiScriptNotifyCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiScriptNotifyCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiScriptNotifyCtrl_create();
         private static _GuiScriptNotifyCtrl_create _GuiScriptNotifyCtrl_createFunc;
         internal static IntPtr GuiScriptNotifyCtrl_create()
         {
         	if (_GuiScriptNotifyCtrl_createFunc == null)
         	{
         		_GuiScriptNotifyCtrl_createFunc =
         			(_GuiScriptNotifyCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiScriptNotifyCtrl_create"), typeof(_GuiScriptNotifyCtrl_create));
         	}
         
         	return  _GuiScriptNotifyCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public bool OnChildAdded
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OnChildAdded")); }
         	set { setFieldValue("OnChildAdded", value ? "1" : "0"); }
         }
      
         public bool OnChildRemoved
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OnChildRemoved")); }
         	set { setFieldValue("OnChildRemoved", value ? "1" : "0"); }
         }
      
         public bool OnChildResized
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OnChildResized")); }
         	set { setFieldValue("OnChildResized", value ? "1" : "0"); }
         }
      
         public bool OnParentResized
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OnParentResized")); }
         	set { setFieldValue("OnParentResized", value ? "1" : "0"); }
         }
      
         public bool OnResize
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OnResize")); }
         	set { setFieldValue("OnResize", value ? "1" : "0"); }
         }
      
         public bool OnLoseFirstResponder
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OnLoseFirstResponder")); }
         	set { setFieldValue("OnLoseFirstResponder", value ? "1" : "0"); }
         }
      
         public bool OnGainFirstResponder
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OnGainFirstResponder")); }
         	set { setFieldValue("OnGainFirstResponder", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}