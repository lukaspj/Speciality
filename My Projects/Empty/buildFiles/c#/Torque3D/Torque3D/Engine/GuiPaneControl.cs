using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiPaneControl : GuiControl
	{
		public GuiPaneControl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiPaneControl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiPaneControl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiPaneControl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiPaneControl(SimObject pObj) : base(pObj)
		{
		}

		public GuiPaneControl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiPaneControl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setCollapsed(IntPtr thisPtr, bool collapse);
         private static _setCollapsed _setCollapsedFunc;
         internal static void setCollapsed(IntPtr thisPtr, bool collapse)
         {
         	if (_setCollapsedFunc == null)
         	{
         		_setCollapsedFunc =
         			(_setCollapsed)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiPaneControl_setCollapsed"), typeof(_setCollapsed));
         	}
         
         	 _setCollapsedFunc(thisPtr, collapse);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiPaneControl_create();
         private static _GuiPaneControl_create _GuiPaneControl_createFunc;
         internal static IntPtr GuiPaneControl_create()
         {
         	if (_GuiPaneControl_createFunc == null)
         	{
         		_GuiPaneControl_createFunc =
         			(_GuiPaneControl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiPaneControl_create"), typeof(_GuiPaneControl_create));
         	}
         
         	return  _GuiPaneControl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setCollapsed(bool collapse)
         {
            InternalUnsafeMethods.setCollapsed(ObjectPtr, collapse);
         }
      
      
      #endregion


      #region Properties
      
      
         public string Caption
         {
         	get { return getFieldValue("Caption"); }
         	set { setFieldValue("Caption", value); }
         }
      
         public string CaptionID
         {
         	get { return getFieldValue("CaptionID"); }
         	set { setFieldValue("CaptionID", value); }
         }
      
         public bool Collapsable
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Collapsable")); }
         	set { setFieldValue("Collapsable", value ? "1" : "0"); }
         }
      
         public bool BarBehindText
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("BarBehindText")); }
         	set { setFieldValue("BarBehindText", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}