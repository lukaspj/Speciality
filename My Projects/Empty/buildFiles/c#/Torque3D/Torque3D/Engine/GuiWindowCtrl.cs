using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiWindowCtrl : GuiContainer
	{
		public GuiWindowCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiWindowCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiWindowCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiWindowCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiWindowCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiWindowCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiWindowCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _selectWindow(IntPtr thisPtr);
         private static _selectWindow _selectWindowFunc;
         internal static void selectWindow(IntPtr thisPtr)
         {
         	if (_selectWindowFunc == null)
         	{
         		_selectWindowFunc =
         			(_selectWindow)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiWindowCtrl_selectWindow"), typeof(_selectWindow));
         	}
         
         	 _selectWindowFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setCollapseGroup(IntPtr thisPtr, bool state);
         private static _setCollapseGroup _setCollapseGroupFunc;
         internal static void setCollapseGroup(IntPtr thisPtr, bool state)
         {
         	if (_setCollapseGroupFunc == null)
         	{
         		_setCollapseGroupFunc =
         			(_setCollapseGroup)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiWindowCtrl_setCollapseGroup"), typeof(_setCollapseGroup));
         	}
         
         	 _setCollapseGroupFunc(thisPtr, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _toggleCollapseGroup(IntPtr thisPtr);
         private static _toggleCollapseGroup _toggleCollapseGroupFunc;
         internal static void toggleCollapseGroup(IntPtr thisPtr)
         {
         	if (_toggleCollapseGroupFunc == null)
         	{
         		_toggleCollapseGroupFunc =
         			(_toggleCollapseGroup)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiWindowCtrl_toggleCollapseGroup"), typeof(_toggleCollapseGroup));
         	}
         
         	 _toggleCollapseGroupFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _attachTo(IntPtr thisPtr, IntPtr window);
         private static _attachTo _attachToFunc;
         internal static void attachTo(IntPtr thisPtr, IntPtr window)
         {
         	if (_attachToFunc == null)
         	{
         		_attachToFunc =
         			(_attachTo)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiWindowCtrl_attachTo"), typeof(_attachTo));
         	}
         
         	 _attachToFunc(thisPtr, window);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _attach(IntPtr thisPtr, IntPtr bottomWindow, IntPtr topWindow);
         private static _attach _attachFunc;
         internal static void attach(IntPtr thisPtr, IntPtr bottomWindow, IntPtr topWindow)
         {
         	if (_attachFunc == null)
         	{
         		_attachFunc =
         			(_attach)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiWindowCtrl_attach"), typeof(_attach));
         	}
         
         	 _attachFunc(thisPtr, bottomWindow, topWindow);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiWindowCtrl_create();
         private static _GuiWindowCtrl_create _GuiWindowCtrl_createFunc;
         internal static IntPtr GuiWindowCtrl_create()
         {
         	if (_GuiWindowCtrl_createFunc == null)
         	{
         		_GuiWindowCtrl_createFunc =
         			(_GuiWindowCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiWindowCtrl_create"), typeof(_GuiWindowCtrl_create));
         	}
         
         	return  _GuiWindowCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void selectWindow()
         {
            InternalUnsafeMethods.selectWindow(ObjectPtr);
         }
      
         public virtual void setCollapseGroup(bool state)
         {
            InternalUnsafeMethods.setCollapseGroup(ObjectPtr, state);
         }
      
         public virtual void toggleCollapseGroup()
         {
            InternalUnsafeMethods.toggleCollapseGroup(ObjectPtr);
         }
      
         public virtual void attachTo(GuiWindowCtrl window)
         {
            InternalUnsafeMethods.attachTo(ObjectPtr, window.ObjectPtr);
         }
      
         public virtual void attach(GuiWindowCtrl bottomWindow, GuiWindowCtrl topWindow)
         {
            InternalUnsafeMethods.attach(ObjectPtr, bottomWindow.ObjectPtr, topWindow.ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public string Text
         {
         	get { return getFieldValue("Text"); }
         	set { setFieldValue("Text", value); }
         }
      
         public bool ResizeWidth
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ResizeWidth")); }
         	set { setFieldValue("ResizeWidth", value ? "1" : "0"); }
         }
      
         public bool ResizeHeight
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ResizeHeight")); }
         	set { setFieldValue("ResizeHeight", value ? "1" : "0"); }
         }
      
         public bool CanMove
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CanMove")); }
         	set { setFieldValue("CanMove", value ? "1" : "0"); }
         }
      
         public bool CanClose
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CanClose")); }
         	set { setFieldValue("CanClose", value ? "1" : "0"); }
         }
      
         public bool CanMinimize
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CanMinimize")); }
         	set { setFieldValue("CanMinimize", value ? "1" : "0"); }
         }
      
         public bool CanMaximize
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CanMaximize")); }
         	set { setFieldValue("CanMaximize", value ? "1" : "0"); }
         }
      
         public bool CanCollapse
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CanCollapse")); }
         	set { setFieldValue("CanCollapse", value ? "1" : "0"); }
         }
      
         public string CloseCommand
         {
         	get { return getFieldValue("CloseCommand"); }
         	set { setFieldValue("CloseCommand", value); }
         }
      
         public bool EdgeSnap
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("EdgeSnap")); }
         	set { setFieldValue("EdgeSnap", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}