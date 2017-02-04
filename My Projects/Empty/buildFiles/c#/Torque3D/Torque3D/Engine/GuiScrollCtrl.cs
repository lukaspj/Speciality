using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiScrollCtrl : GuiContainer
	{
		public GuiScrollCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiScrollCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiScrollCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiScrollCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiScrollCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiScrollCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiScrollCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _scrollToTop(IntPtr thisPtr);
         private static _scrollToTop _scrollToTopFunc;
         internal static void scrollToTop(IntPtr thisPtr)
         {
         	if (_scrollToTopFunc == null)
         	{
         		_scrollToTopFunc =
         			(_scrollToTop)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiScrollCtrl_scrollToTop"), typeof(_scrollToTop));
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
         				"fnGuiScrollCtrl_scrollToBottom"), typeof(_scrollToBottom));
         	}
         
         	 _scrollToBottomFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setScrollPosition(IntPtr thisPtr, int x, int y);
         private static _setScrollPosition _setScrollPositionFunc;
         internal static void setScrollPosition(IntPtr thisPtr, int x, int y)
         {
         	if (_setScrollPositionFunc == null)
         	{
         		_setScrollPositionFunc =
         			(_setScrollPosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiScrollCtrl_setScrollPosition"), typeof(_setScrollPosition));
         	}
         
         	 _setScrollPositionFunc(thisPtr, x, y);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _scrollToObject(IntPtr thisPtr, IntPtr control);
         private static _scrollToObject _scrollToObjectFunc;
         internal static void scrollToObject(IntPtr thisPtr, IntPtr control)
         {
         	if (_scrollToObjectFunc == null)
         	{
         		_scrollToObjectFunc =
         			(_scrollToObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiScrollCtrl_scrollToObject"), typeof(_scrollToObject));
         	}
         
         	 _scrollToObjectFunc(thisPtr, control);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int[] _getScrollPosition(IntPtr thisPtr);
         private static _getScrollPosition _getScrollPositionFunc;
         internal static int[] getScrollPosition(IntPtr thisPtr)
         {
         	if (_getScrollPositionFunc == null)
         	{
         		_getScrollPositionFunc =
         			(_getScrollPosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiScrollCtrl_getScrollPosition"), typeof(_getScrollPosition));
         	}
         
         	return  _getScrollPositionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getScrollPositionX(IntPtr thisPtr);
         private static _getScrollPositionX _getScrollPositionXFunc;
         internal static int getScrollPositionX(IntPtr thisPtr)
         {
         	if (_getScrollPositionXFunc == null)
         	{
         		_getScrollPositionXFunc =
         			(_getScrollPositionX)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiScrollCtrl_getScrollPositionX"), typeof(_getScrollPositionX));
         	}
         
         	return  _getScrollPositionXFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getScrollPositionY(IntPtr thisPtr);
         private static _getScrollPositionY _getScrollPositionYFunc;
         internal static int getScrollPositionY(IntPtr thisPtr)
         {
         	if (_getScrollPositionYFunc == null)
         	{
         		_getScrollPositionYFunc =
         			(_getScrollPositionY)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiScrollCtrl_getScrollPositionY"), typeof(_getScrollPositionY));
         	}
         
         	return  _getScrollPositionYFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _computeSizes(IntPtr thisPtr);
         private static _computeSizes _computeSizesFunc;
         internal static void computeSizes(IntPtr thisPtr)
         {
         	if (_computeSizesFunc == null)
         	{
         		_computeSizesFunc =
         			(_computeSizes)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiScrollCtrl_computeSizes"), typeof(_computeSizes));
         	}
         
         	 _computeSizesFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiScrollCtrl_create();
         private static _GuiScrollCtrl_create _GuiScrollCtrl_createFunc;
         internal static IntPtr GuiScrollCtrl_create()
         {
         	if (_GuiScrollCtrl_createFunc == null)
         	{
         		_GuiScrollCtrl_createFunc =
         			(_GuiScrollCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiScrollCtrl_create"), typeof(_GuiScrollCtrl_create));
         	}
         
         	return  _GuiScrollCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void scrollToTop()
         {
            InternalUnsafeMethods.scrollToTop(ObjectPtr);
         }
      
         public virtual void scrollToBottom()
         {
            InternalUnsafeMethods.scrollToBottom(ObjectPtr);
         }
      
         public virtual void setScrollPosition(int x, int y)
         {
            InternalUnsafeMethods.setScrollPosition(ObjectPtr, x, y);
         }
      
         public virtual void scrollToObject(GuiControl control)
         {
            InternalUnsafeMethods.scrollToObject(ObjectPtr, control.ObjectPtr);
         }
      
         public virtual Point2I getScrollPosition()
         {
            return new Point2I(InternalUnsafeMethods.getScrollPosition(ObjectPtr));
         }
      
         public virtual int getScrollPositionX()
         {
            return InternalUnsafeMethods.getScrollPositionX(ObjectPtr);
         }
      
         public virtual int getScrollPositionY()
         {
            return InternalUnsafeMethods.getScrollPositionY(ObjectPtr);
         }
      
         public virtual void computeSizes()
         {
            InternalUnsafeMethods.computeSizes(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool WillFirstRespond
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("WillFirstRespond")); }
         	set { setFieldValue("WillFirstRespond", value ? "1" : "0"); }
         }
      
         public GuiScrollBarBehavior HScrollBar
         {
         	get { return (GuiScrollBarBehavior)Enum.Parse(typeof(GuiScrollBarBehavior), getFieldValue("HScrollBar"), true); }
         	set { setFieldValue("HScrollBar", value.ToString()); }
         }
      
         public GuiScrollBarBehavior VScrollBar
         {
         	get { return (GuiScrollBarBehavior)Enum.Parse(typeof(GuiScrollBarBehavior), getFieldValue("VScrollBar"), true); }
         	set { setFieldValue("VScrollBar", value.ToString()); }
         }
      
         public bool LockHorizScroll
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("LockHorizScroll")); }
         	set { setFieldValue("LockHorizScroll", value ? "1" : "0"); }
         }
      
         public bool LockVertScroll
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("LockVertScroll")); }
         	set { setFieldValue("LockVertScroll", value ? "1" : "0"); }
         }
      
         public bool ConstantThumbHeight
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ConstantThumbHeight")); }
         	set { setFieldValue("ConstantThumbHeight", value ? "1" : "0"); }
         }
      
         public Point2I ChildMargin
         {
         	get { return new Point2I(getFieldValue("ChildMargin")); }
         	set { setFieldValue("ChildMargin", value.ToString()); }
         }
      
         public int MouseWheelScrollSpeed
         {
         	get { return int.Parse(getFieldValue("MouseWheelScrollSpeed")); }
         	set { setFieldValue("MouseWheelScrollSpeed", value.ToString()); }
         }
      
      
      #endregion

	}
}