using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class PopupMenu : SimObject
	{
		public PopupMenu(bool pRegister = false)
			: base(pRegister)
		{
		}

		public PopupMenu(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public PopupMenu(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public PopupMenu(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public PopupMenu(SimObject pObj) : base(pObj)
		{
		}

		public PopupMenu(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.PopupMenu_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _insertItem(IntPtr thisPtr, int pos, [MarshalAs(UnmanagedType.LPWStr)]string title, [MarshalAs(UnmanagedType.LPWStr)]string accelerator, [MarshalAs(UnmanagedType.LPWStr)]string cmd);
         private static _insertItem _insertItemFunc;
         internal static int insertItem(IntPtr thisPtr, int pos, [MarshalAs(UnmanagedType.LPWStr)]string title, [MarshalAs(UnmanagedType.LPWStr)]string accelerator, [MarshalAs(UnmanagedType.LPWStr)]string cmd)
         {
         	if (_insertItemFunc == null)
         	{
         		_insertItemFunc =
         			(_insertItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPopupMenu_insertItem"), typeof(_insertItem));
         	}
         
         	return  _insertItemFunc(thisPtr, pos, title, accelerator, cmd);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeItem(IntPtr thisPtr, int pos);
         private static _removeItem _removeItemFunc;
         internal static void removeItem(IntPtr thisPtr, int pos)
         {
         	if (_removeItemFunc == null)
         	{
         		_removeItemFunc =
         			(_removeItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPopupMenu_removeItem"), typeof(_removeItem));
         	}
         
         	 _removeItemFunc(thisPtr, pos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _insertSubMenu(IntPtr thisPtr, int pos, [MarshalAs(UnmanagedType.LPWStr)]string title, [MarshalAs(UnmanagedType.LPWStr)]string subMenu);
         private static _insertSubMenu _insertSubMenuFunc;
         internal static int insertSubMenu(IntPtr thisPtr, int pos, [MarshalAs(UnmanagedType.LPWStr)]string title, [MarshalAs(UnmanagedType.LPWStr)]string subMenu)
         {
         	if (_insertSubMenuFunc == null)
         	{
         		_insertSubMenuFunc =
         			(_insertSubMenu)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPopupMenu_insertSubMenu"), typeof(_insertSubMenu));
         	}
         
         	return  _insertSubMenuFunc(thisPtr, pos, title, subMenu);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setItem(IntPtr thisPtr, int pos, [MarshalAs(UnmanagedType.LPWStr)]string title, [MarshalAs(UnmanagedType.LPWStr)]string accelerator, [MarshalAs(UnmanagedType.LPWStr)]string cmd);
         private static _setItem _setItemFunc;
         internal static bool setItem(IntPtr thisPtr, int pos, [MarshalAs(UnmanagedType.LPWStr)]string title, [MarshalAs(UnmanagedType.LPWStr)]string accelerator, [MarshalAs(UnmanagedType.LPWStr)]string cmd)
         {
         	if (_setItemFunc == null)
         	{
         		_setItemFunc =
         			(_setItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPopupMenu_setItem"), typeof(_setItem));
         	}
         
         	return  _setItemFunc(thisPtr, pos, title, accelerator, cmd);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _enableItem(IntPtr thisPtr, int pos, bool enabled);
         private static _enableItem _enableItemFunc;
         internal static void enableItem(IntPtr thisPtr, int pos, bool enabled)
         {
         	if (_enableItemFunc == null)
         	{
         		_enableItemFunc =
         			(_enableItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPopupMenu_enableItem"), typeof(_enableItem));
         	}
         
         	 _enableItemFunc(thisPtr, pos, enabled);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _checkItem(IntPtr thisPtr, int pos, bool _checked);
         private static _checkItem _checkItemFunc;
         internal static void checkItem(IntPtr thisPtr, int pos, bool _checked)
         {
         	if (_checkItemFunc == null)
         	{
         		_checkItemFunc =
         			(_checkItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPopupMenu_checkItem"), typeof(_checkItem));
         	}
         
         	 _checkItemFunc(thisPtr, pos, _checked);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _checkRadioItem(IntPtr thisPtr, int firstPos, int lastPos, int checkPos);
         private static _checkRadioItem _checkRadioItemFunc;
         internal static void checkRadioItem(IntPtr thisPtr, int firstPos, int lastPos, int checkPos)
         {
         	if (_checkRadioItemFunc == null)
         	{
         		_checkRadioItemFunc =
         			(_checkRadioItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPopupMenu_checkRadioItem"), typeof(_checkRadioItem));
         	}
         
         	 _checkRadioItemFunc(thisPtr, firstPos, lastPos, checkPos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isItemChecked(IntPtr thisPtr, int pos);
         private static _isItemChecked _isItemCheckedFunc;
         internal static bool isItemChecked(IntPtr thisPtr, int pos)
         {
         	if (_isItemCheckedFunc == null)
         	{
         		_isItemCheckedFunc =
         			(_isItemChecked)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPopupMenu_isItemChecked"), typeof(_isItemChecked));
         	}
         
         	return  _isItemCheckedFunc(thisPtr, pos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getItemCount(IntPtr thisPtr);
         private static _getItemCount _getItemCountFunc;
         internal static int getItemCount(IntPtr thisPtr)
         {
         	if (_getItemCountFunc == null)
         	{
         		_getItemCountFunc =
         			(_getItemCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPopupMenu_getItemCount"), typeof(_getItemCount));
         	}
         
         	return  _getItemCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _attachToMenuBar(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string canvasName, int pos, [MarshalAs(UnmanagedType.LPWStr)]string title);
         private static _attachToMenuBar _attachToMenuBarFunc;
         internal static void attachToMenuBar(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string canvasName, int pos, [MarshalAs(UnmanagedType.LPWStr)]string title)
         {
         	if (_attachToMenuBarFunc == null)
         	{
         		_attachToMenuBarFunc =
         			(_attachToMenuBar)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPopupMenu_attachToMenuBar"), typeof(_attachToMenuBar));
         	}
         
         	 _attachToMenuBarFunc(thisPtr, canvasName, pos, title);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeFromMenuBar(IntPtr thisPtr);
         private static _removeFromMenuBar _removeFromMenuBarFunc;
         internal static void removeFromMenuBar(IntPtr thisPtr)
         {
         	if (_removeFromMenuBarFunc == null)
         	{
         		_removeFromMenuBarFunc =
         			(_removeFromMenuBar)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPopupMenu_removeFromMenuBar"), typeof(_removeFromMenuBar));
         	}
         
         	 _removeFromMenuBarFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _showPopup(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string canvasName, int x, int y);
         private static _showPopup _showPopupFunc;
         internal static void showPopup(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string canvasName, int x, int y)
         {
         	if (_showPopupFunc == null)
         	{
         		_showPopupFunc =
         			(_showPopup)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPopupMenu_showPopup"), typeof(_showPopup));
         	}
         
         	 _showPopupFunc(thisPtr, canvasName, x, y);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _PopupMenu_create();
         private static _PopupMenu_create _PopupMenu_createFunc;
         internal static IntPtr PopupMenu_create()
         {
         	if (_PopupMenu_createFunc == null)
         	{
         		_PopupMenu_createFunc =
         			(_PopupMenu_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PopupMenu_create"), typeof(_PopupMenu_create));
         	}
         
         	return  _PopupMenu_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int insertItem(int pos, string title = "", string accelerator = "", string cmd = "")
         {
            return InternalUnsafeMethods.insertItem(ObjectPtr, pos, title, accelerator, cmd);
         }
      
         public virtual void removeItem(int pos)
         {
            InternalUnsafeMethods.removeItem(ObjectPtr, pos);
         }
      
         public virtual int insertSubMenu(int pos, string title, string subMenu)
         {
            return InternalUnsafeMethods.insertSubMenu(ObjectPtr, pos, title, subMenu);
         }
      
         public virtual bool setItem(int pos, string title, string accelerator, string cmd = "")
         {
            return InternalUnsafeMethods.setItem(ObjectPtr, pos, title, accelerator, cmd);
         }
      
         public virtual void enableItem(int pos, bool enabled)
         {
            InternalUnsafeMethods.enableItem(ObjectPtr, pos, enabled);
         }
      
         public virtual void checkItem(int pos, bool _checked)
         {
            InternalUnsafeMethods.checkItem(ObjectPtr, pos, _checked);
         }
      
         public virtual void checkRadioItem(int firstPos, int lastPos, int checkPos)
         {
            InternalUnsafeMethods.checkRadioItem(ObjectPtr, firstPos, lastPos, checkPos);
         }
      
         public virtual bool isItemChecked(int pos)
         {
            return InternalUnsafeMethods.isItemChecked(ObjectPtr, pos);
         }
      
         public virtual int getItemCount()
         {
            return InternalUnsafeMethods.getItemCount(ObjectPtr);
         }
      
         public virtual void attachToMenuBar(string canvasName, int pos, string title)
         {
            InternalUnsafeMethods.attachToMenuBar(ObjectPtr, canvasName, pos, title);
         }
      
         public virtual void removeFromMenuBar()
         {
            InternalUnsafeMethods.removeFromMenuBar(ObjectPtr);
         }
      
         public virtual void showPopup(string canvasName, int x = -1, int y = -1)
         {
            InternalUnsafeMethods.showPopup(ObjectPtr, canvasName, x, y);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool IsPopup
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsPopup")); }
         	set { setFieldValue("IsPopup", value ? "1" : "0"); }
         }
      
         public string BarTitle
         {
         	get { return getFieldValue("BarTitle"); }
         	set { setFieldValue("BarTitle", value); }
         }
      
      
      #endregion

	}
}