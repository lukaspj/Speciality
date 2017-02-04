using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiButtonBaseCtrl : GuiControl
	{
		public GuiButtonBaseCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiButtonBaseCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiButtonBaseCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiButtonBaseCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiButtonBaseCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiButtonBaseCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiButtonBaseCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _performClick(IntPtr thisPtr);
         private static _performClick _performClickFunc;
         internal static void performClick(IntPtr thisPtr)
         {
         	if (_performClickFunc == null)
         	{
         		_performClickFunc =
         			(_performClick)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiButtonBaseCtrl_performClick"), typeof(_performClick));
         	}
         
         	 _performClickFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setText(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string text);
         private static _setText _setTextFunc;
         internal static void setText(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string text)
         {
         	if (_setTextFunc == null)
         	{
         		_setTextFunc =
         			(_setText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiButtonBaseCtrl_setText"), typeof(_setText));
         	}
         
         	 _setTextFunc(thisPtr, text);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setTextID(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string id);
         private static _setTextID _setTextIDFunc;
         internal static void setTextID(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string id)
         {
         	if (_setTextIDFunc == null)
         	{
         		_setTextIDFunc =
         			(_setTextID)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiButtonBaseCtrl_setTextID"), typeof(_setTextID));
         	}
         
         	 _setTextIDFunc(thisPtr, id);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getText(IntPtr thisPtr);
         private static _getText _getTextFunc;
         internal static IntPtr getText(IntPtr thisPtr)
         {
         	if (_getTextFunc == null)
         	{
         		_getTextFunc =
         			(_getText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiButtonBaseCtrl_getText"), typeof(_getText));
         	}
         
         	return  _getTextFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setStateOn(IntPtr thisPtr, bool isOn);
         private static _setStateOn _setStateOnFunc;
         internal static void setStateOn(IntPtr thisPtr, bool isOn)
         {
         	if (_setStateOnFunc == null)
         	{
         		_setStateOnFunc =
         			(_setStateOn)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiButtonBaseCtrl_setStateOn"), typeof(_setStateOn));
         	}
         
         	 _setStateOnFunc(thisPtr, isOn);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _resetState(IntPtr thisPtr);
         private static _resetState _resetStateFunc;
         internal static void resetState(IntPtr thisPtr)
         {
         	if (_resetStateFunc == null)
         	{
         		_resetStateFunc =
         			(_resetState)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiButtonBaseCtrl_resetState"), typeof(_resetState));
         	}
         
         	 _resetStateFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiButtonBaseCtrl_create();
         private static _GuiButtonBaseCtrl_create _GuiButtonBaseCtrl_createFunc;
         internal static IntPtr GuiButtonBaseCtrl_create()
         {
         	if (_GuiButtonBaseCtrl_createFunc == null)
         	{
         		_GuiButtonBaseCtrl_createFunc =
         			(_GuiButtonBaseCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiButtonBaseCtrl_create"), typeof(_GuiButtonBaseCtrl_create));
         	}
         
         	return  _GuiButtonBaseCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void performClick()
         {
            InternalUnsafeMethods.performClick(ObjectPtr);
         }
      
         public virtual void setText(string text)
         {
            InternalUnsafeMethods.setText(ObjectPtr, text);
         }
      
         public virtual void setTextID(string id)
         {
            InternalUnsafeMethods.setTextID(ObjectPtr, id);
         }
      
         public virtual string getText()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getText(ObjectPtr));
         }
      
         public virtual void setStateOn(bool isOn = true)
         {
            InternalUnsafeMethods.setStateOn(ObjectPtr, isOn);
         }
      
         public virtual void resetState()
         {
            InternalUnsafeMethods.resetState(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public string Text
         {
         	get { return getFieldValue("Text"); }
         	set { setFieldValue("Text", value); }
         }
      
         public string TextID
         {
         	get { return getFieldValue("TextID"); }
         	set { setFieldValue("TextID", value); }
         }
      
         public int GroupNum
         {
         	get { return int.Parse(getFieldValue("GroupNum")); }
         	set { setFieldValue("GroupNum", value.ToString()); }
         }
      
         public GuiButtonType ButtonType
         {
         	get { return (GuiButtonType)Enum.Parse(typeof(GuiButtonType), getFieldValue("ButtonType"), true); }
         	set { setFieldValue("ButtonType", value.ToString()); }
         }
      
         public bool UseMouseEvents
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseMouseEvents")); }
         	set { setFieldValue("UseMouseEvents", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}