using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiTextEditCtrl : GuiTextCtrl
	{
		public GuiTextEditCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiTextEditCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiTextEditCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiTextEditCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiTextEditCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiTextEditCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiTextEditCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getText(IntPtr thisPtr);
         private static _getText _getTextFunc;
         internal static IntPtr getText(IntPtr thisPtr)
         {
         	if (_getTextFunc == null)
         	{
         		_getTextFunc =
         			(_getText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextEditCtrl_getText"), typeof(_getText));
         	}
         
         	return  _getTextFunc(thisPtr);
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
         				"fnGuiTextEditCtrl_setText"), typeof(_setText));
         	}
         
         	 _setTextFunc(thisPtr, text);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getCursorPos(IntPtr thisPtr);
         private static _getCursorPos _getCursorPosFunc;
         internal static int getCursorPos(IntPtr thisPtr)
         {
         	if (_getCursorPosFunc == null)
         	{
         		_getCursorPosFunc =
         			(_getCursorPos)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextEditCtrl_getCursorPos"), typeof(_getCursorPos));
         	}
         
         	return  _getCursorPosFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setCursorPos(IntPtr thisPtr, int position);
         private static _setCursorPos _setCursorPosFunc;
         internal static void setCursorPos(IntPtr thisPtr, int position)
         {
         	if (_setCursorPosFunc == null)
         	{
         		_setCursorPosFunc =
         			(_setCursorPos)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextEditCtrl_setCursorPos"), typeof(_setCursorPos));
         	}
         
         	 _setCursorPosFunc(thisPtr, position);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isAllTextSelected(IntPtr thisPtr);
         private static _isAllTextSelected _isAllTextSelectedFunc;
         internal static bool isAllTextSelected(IntPtr thisPtr)
         {
         	if (_isAllTextSelectedFunc == null)
         	{
         		_isAllTextSelectedFunc =
         			(_isAllTextSelected)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextEditCtrl_isAllTextSelected"), typeof(_isAllTextSelected));
         	}
         
         	return  _isAllTextSelectedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _selectAllText(IntPtr thisPtr);
         private static _selectAllText _selectAllTextFunc;
         internal static void selectAllText(IntPtr thisPtr)
         {
         	if (_selectAllTextFunc == null)
         	{
         		_selectAllTextFunc =
         			(_selectAllText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextEditCtrl_selectAllText"), typeof(_selectAllText));
         	}
         
         	 _selectAllTextFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearSelectedText(IntPtr thisPtr);
         private static _clearSelectedText _clearSelectedTextFunc;
         internal static void clearSelectedText(IntPtr thisPtr)
         {
         	if (_clearSelectedTextFunc == null)
         	{
         		_clearSelectedTextFunc =
         			(_clearSelectedText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextEditCtrl_clearSelectedText"), typeof(_clearSelectedText));
         	}
         
         	 _clearSelectedTextFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _forceValidateText(IntPtr thisPtr);
         private static _forceValidateText _forceValidateTextFunc;
         internal static void forceValidateText(IntPtr thisPtr)
         {
         	if (_forceValidateTextFunc == null)
         	{
         		_forceValidateTextFunc =
         			(_forceValidateText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextEditCtrl_forceValidateText"), typeof(_forceValidateText));
         	}
         
         	 _forceValidateTextFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _invalidText(IntPtr thisPtr, bool playSound);
         private static _invalidText _invalidTextFunc;
         internal static void invalidText(IntPtr thisPtr, bool playSound)
         {
         	if (_invalidTextFunc == null)
         	{
         		_invalidTextFunc =
         			(_invalidText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextEditCtrl_invalidText"), typeof(_invalidText));
         	}
         
         	 _invalidTextFunc(thisPtr, playSound);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _validText(IntPtr thisPtr);
         private static _validText _validTextFunc;
         internal static void validText(IntPtr thisPtr)
         {
         	if (_validTextFunc == null)
         	{
         		_validTextFunc =
         			(_validText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextEditCtrl_validText"), typeof(_validText));
         	}
         
         	 _validTextFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isValidText(IntPtr thisPtr);
         private static _isValidText _isValidTextFunc;
         internal static bool isValidText(IntPtr thisPtr)
         {
         	if (_isValidTextFunc == null)
         	{
         		_isValidTextFunc =
         			(_isValidText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextEditCtrl_isValidText"), typeof(_isValidText));
         	}
         
         	return  _isValidTextFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTextEditCtrl_create();
         private static _GuiTextEditCtrl_create _GuiTextEditCtrl_createFunc;
         internal static IntPtr GuiTextEditCtrl_create()
         {
         	if (_GuiTextEditCtrl_createFunc == null)
         	{
         		_GuiTextEditCtrl_createFunc =
         			(_GuiTextEditCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiTextEditCtrl_create"), typeof(_GuiTextEditCtrl_create));
         	}
         
         	return  _GuiTextEditCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual string getText()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getText(ObjectPtr));
         }
      
         public virtual void setText(string text)
         {
            InternalUnsafeMethods.setText(ObjectPtr, text);
         }
      
         public virtual int getCursorPos()
         {
            return InternalUnsafeMethods.getCursorPos(ObjectPtr);
         }
      
         public virtual void setCursorPos(int position)
         {
            InternalUnsafeMethods.setCursorPos(ObjectPtr, position);
         }
      
         public virtual bool isAllTextSelected()
         {
            return InternalUnsafeMethods.isAllTextSelected(ObjectPtr);
         }
      
         public virtual void selectAllText()
         {
            InternalUnsafeMethods.selectAllText(ObjectPtr);
         }
      
         public virtual void clearSelectedText()
         {
            InternalUnsafeMethods.clearSelectedText(ObjectPtr);
         }
      
         public virtual void forceValidateText()
         {
            InternalUnsafeMethods.forceValidateText(ObjectPtr);
         }
      
         public virtual void invalidText(bool playSound = true)
         {
            InternalUnsafeMethods.invalidText(ObjectPtr, playSound);
         }
      
         public virtual void validText()
         {
            InternalUnsafeMethods.validText(ObjectPtr);
         }
      
         public virtual bool isValidText()
         {
            return InternalUnsafeMethods.isValidText(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public string Validate
         {
         	get { return getFieldValue("Validate"); }
         	set { setFieldValue("Validate", value); }
         }
      
         public string EscapeCommand
         {
         	get { return getFieldValue("EscapeCommand"); }
         	set { setFieldValue("EscapeCommand", value); }
         }
      
         public int HistorySize
         {
         	get { return int.Parse(getFieldValue("HistorySize")); }
         	set { setFieldValue("HistorySize", value.ToString()); }
         }
      
         public bool TabComplete
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("TabComplete")); }
         	set { setFieldValue("TabComplete", value ? "1" : "0"); }
         }
      
         public SFXTrack DeniedSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("DeniedSound")); }
         	set { setFieldValue("DeniedSound", value.getId().ToString()); }
         }
      
         public bool SinkAllKeyEvents
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SinkAllKeyEvents")); }
         	set { setFieldValue("SinkAllKeyEvents", value ? "1" : "0"); }
         }
      
         public bool Password
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Password")); }
         	set { setFieldValue("Password", value ? "1" : "0"); }
         }
      
         public string PasswordMask
         {
         	get { return getFieldValue("PasswordMask"); }
         	set { setFieldValue("PasswordMask", value); }
         }
      
      
      #endregion

	}
}