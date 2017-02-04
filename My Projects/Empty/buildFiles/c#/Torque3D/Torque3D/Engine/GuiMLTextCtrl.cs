using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiMLTextCtrl : GuiControl
	{
		public GuiMLTextCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiMLTextCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiMLTextCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiMLTextCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiMLTextCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiMLTextCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiMLTextCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setText(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string text);
         private static _setText _setTextFunc;
         internal static void setText(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string text)
         {
         	if (_setTextFunc == null)
         	{
         		_setTextFunc =
         			(_setText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMLTextCtrl_setText"), typeof(_setText));
         	}
         
         	 _setTextFunc(thisPtr, text);
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
         				"fnGuiMLTextCtrl_getText"), typeof(_getText));
         	}
         
         	return  _getTextFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addText(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string text, bool reformat);
         private static _addText _addTextFunc;
         internal static void addText(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string text, bool reformat)
         {
         	if (_addTextFunc == null)
         	{
         		_addTextFunc =
         			(_addText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMLTextCtrl_addText"), typeof(_addText));
         	}
         
         	 _addTextFunc(thisPtr, text, reformat);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setCursorPosition(IntPtr thisPtr, int newPos);
         private static _setCursorPosition _setCursorPositionFunc;
         internal static bool setCursorPosition(IntPtr thisPtr, int newPos)
         {
         	if (_setCursorPositionFunc == null)
         	{
         		_setCursorPositionFunc =
         			(_setCursorPosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMLTextCtrl_setCursorPosition"), typeof(_setCursorPosition));
         	}
         
         	return  _setCursorPositionFunc(thisPtr, newPos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _scrollToTag(IntPtr thisPtr, int tagID);
         private static _scrollToTag _scrollToTagFunc;
         internal static void scrollToTag(IntPtr thisPtr, int tagID)
         {
         	if (_scrollToTagFunc == null)
         	{
         		_scrollToTagFunc =
         			(_scrollToTag)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMLTextCtrl_scrollToTag"), typeof(_scrollToTag));
         	}
         
         	 _scrollToTagFunc(thisPtr, tagID);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _scrollToTop(IntPtr thisPtr);
         private static _scrollToTop _scrollToTopFunc;
         internal static void scrollToTop(IntPtr thisPtr)
         {
         	if (_scrollToTopFunc == null)
         	{
         		_scrollToTopFunc =
         			(_scrollToTop)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMLTextCtrl_scrollToTop"), typeof(_scrollToTop));
         	}
         
         	 _scrollToTopFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _scrollToBottom(IntPtr thisPtr);
         private static _scrollToBottom _scrollToBottomFunc;
         internal static void scrollToBottom(IntPtr thisPtr)
         {
         	if (_scrollToBottomFunc == null)
         	{
         		_scrollToBottomFunc =
         			(_scrollToBottom)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMLTextCtrl_scrollToBottom"), typeof(_scrollToBottom));
         	}
         
         	 _scrollToBottomFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _forceReflow(IntPtr thisPtr);
         private static _forceReflow _forceReflowFunc;
         internal static void forceReflow(IntPtr thisPtr)
         {
         	if (_forceReflowFunc == null)
         	{
         		_forceReflowFunc =
         			(_forceReflow)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMLTextCtrl_forceReflow"), typeof(_forceReflow));
         	}
         
         	 _forceReflowFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setAlpha(IntPtr thisPtr, float alphaVal);
         private static _setAlpha _setAlphaFunc;
         internal static void setAlpha(IntPtr thisPtr, float alphaVal)
         {
         	if (_setAlphaFunc == null)
         	{
         		_setAlphaFunc =
         			(_setAlpha)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMLTextCtrl_setAlpha"), typeof(_setAlpha));
         	}
         
         	 _setAlphaFunc(thisPtr, alphaVal);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiMLTextCtrl_create();
         private static _GuiMLTextCtrl_create _GuiMLTextCtrl_createFunc;
         internal static IntPtr GuiMLTextCtrl_create()
         {
         	if (_GuiMLTextCtrl_createFunc == null)
         	{
         		_GuiMLTextCtrl_createFunc =
         			(_GuiMLTextCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiMLTextCtrl_create"), typeof(_GuiMLTextCtrl_create));
         	}
         
         	return  _GuiMLTextCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setText(string text)
         {
            InternalUnsafeMethods.setText(ObjectPtr, text);
         }
      
         public virtual string getText()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getText(ObjectPtr));
         }
      
         public virtual void addText(string text, bool reformat = true)
         {
            InternalUnsafeMethods.addText(ObjectPtr, text, reformat);
         }
      
         public virtual bool setCursorPosition(int newPos)
         {
            return InternalUnsafeMethods.setCursorPosition(ObjectPtr, newPos);
         }
      
         public virtual void scrollToTag(int tagID)
         {
            InternalUnsafeMethods.scrollToTag(ObjectPtr, tagID);
         }
      
         public virtual void scrollToTop()
         {
            InternalUnsafeMethods.scrollToTop(ObjectPtr);
         }
      
         public virtual void scrollToBottom()
         {
            InternalUnsafeMethods.scrollToBottom(ObjectPtr);
         }
      
         public virtual void forceReflow()
         {
            InternalUnsafeMethods.forceReflow(ObjectPtr);
         }
      
         public virtual void setAlpha(float alphaVal)
         {
            InternalUnsafeMethods.setAlpha(ObjectPtr, alphaVal);
         }
      
      
      #endregion


      #region Properties
      
      
         public int LineSpacing
         {
         	get { return int.Parse(getFieldValue("LineSpacing")); }
         	set { setFieldValue("LineSpacing", value.ToString()); }
         }
      
         public bool AllowColorChars
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowColorChars")); }
         	set { setFieldValue("AllowColorChars", value ? "1" : "0"); }
         }
      
         public int MaxChars
         {
         	get { return int.Parse(getFieldValue("MaxChars")); }
         	set { setFieldValue("MaxChars", value.ToString()); }
         }
      
         public SFXTrack DeniedSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("DeniedSound")); }
         	set { setFieldValue("DeniedSound", value.getId().ToString()); }
         }
      
         public string Text
         {
         	get { return getFieldValue("Text"); }
         	set { setFieldValue("Text", value); }
         }
      
         public bool UseURLMouseCursor
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseURLMouseCursor")); }
         	set { setFieldValue("UseURLMouseCursor", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}