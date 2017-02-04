using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiPopUpMenuCtrl : GuiTextCtrl
	{
		public GuiPopUpMenuCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiPopUpMenuCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiPopUpMenuCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiPopUpMenuCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiPopUpMenuCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiPopUpMenuCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiPopUpMenuCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _add(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, int idNum, uint scheme);
         private static _add _addFunc;
         internal static void add(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, int idNum, uint scheme)
         {
         	if (_addFunc == null)
         	{
         		_addFunc =
         			(_add)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiPopUpMenuCtrl_add"), typeof(_add));
         	}
         
         	 _addFunc(thisPtr, name, idNum, scheme);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addScheme(IntPtr thisPtr, uint id, InternalColorIStruct fontColor, InternalColorIStruct fontColorHL, InternalColorIStruct fontColorSEL);
         private static _addScheme _addSchemeFunc;
         internal static void addScheme(IntPtr thisPtr, uint id, InternalColorIStruct fontColor, InternalColorIStruct fontColorHL, InternalColorIStruct fontColorSEL)
         {
         	if (_addSchemeFunc == null)
         	{
         		_addSchemeFunc =
         			(_addScheme)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiPopUpMenuCtrl_addScheme"), typeof(_addScheme));
         	}
         
         	 _addSchemeFunc(thisPtr, id, fontColor, fontColorHL, fontColorSEL);
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
         				"fnGuiPopUpMenuCtrl_getText"), typeof(_getText));
         	}
         
         	return  _getTextFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clear(IntPtr thisPtr);
         private static _clear _clearFunc;
         internal static void clear(IntPtr thisPtr)
         {
         	if (_clearFunc == null)
         	{
         		_clearFunc =
         			(_clear)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiPopUpMenuCtrl_clear"), typeof(_clear));
         	}
         
         	 _clearFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sort(IntPtr thisPtr);
         private static _sort _sortFunc;
         internal static void sort(IntPtr thisPtr)
         {
         	if (_sortFunc == null)
         	{
         		_sortFunc =
         			(_sort)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiPopUpMenuCtrl_sort"), typeof(_sort));
         	}
         
         	 _sortFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sortID(IntPtr thisPtr);
         private static _sortID _sortIDFunc;
         internal static void sortID(IntPtr thisPtr)
         {
         	if (_sortIDFunc == null)
         	{
         		_sortIDFunc =
         			(_sortID)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiPopUpMenuCtrl_sortID"), typeof(_sortID));
         	}
         
         	 _sortIDFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _forceOnAction(IntPtr thisPtr);
         private static _forceOnAction _forceOnActionFunc;
         internal static void forceOnAction(IntPtr thisPtr)
         {
         	if (_forceOnActionFunc == null)
         	{
         		_forceOnActionFunc =
         			(_forceOnAction)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiPopUpMenuCtrl_forceOnAction"), typeof(_forceOnAction));
         	}
         
         	 _forceOnActionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _forceClose(IntPtr thisPtr);
         private static _forceClose _forceCloseFunc;
         internal static void forceClose(IntPtr thisPtr)
         {
         	if (_forceCloseFunc == null)
         	{
         		_forceCloseFunc =
         			(_forceClose)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiPopUpMenuCtrl_forceClose"), typeof(_forceClose));
         	}
         
         	 _forceCloseFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSelected(IntPtr thisPtr);
         private static _getSelected _getSelectedFunc;
         internal static int getSelected(IntPtr thisPtr)
         {
         	if (_getSelectedFunc == null)
         	{
         		_getSelectedFunc =
         			(_getSelected)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiPopUpMenuCtrl_getSelected"), typeof(_getSelected));
         	}
         
         	return  _getSelectedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSelected(IntPtr thisPtr, int id, bool scriptCallback);
         private static _setSelected _setSelectedFunc;
         internal static void setSelected(IntPtr thisPtr, int id, bool scriptCallback)
         {
         	if (_setSelectedFunc == null)
         	{
         		_setSelectedFunc =
         			(_setSelected)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiPopUpMenuCtrl_setSelected"), typeof(_setSelected));
         	}
         
         	 _setSelectedFunc(thisPtr, id, scriptCallback);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setFirstSelected(IntPtr thisPtr, bool scriptCallback);
         private static _setFirstSelected _setFirstSelectedFunc;
         internal static void setFirstSelected(IntPtr thisPtr, bool scriptCallback)
         {
         	if (_setFirstSelectedFunc == null)
         	{
         		_setFirstSelectedFunc =
         			(_setFirstSelected)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiPopUpMenuCtrl_setFirstSelected"), typeof(_setFirstSelected));
         	}
         
         	 _setFirstSelectedFunc(thisPtr, scriptCallback);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setNoneSelected(IntPtr thisPtr);
         private static _setNoneSelected _setNoneSelectedFunc;
         internal static void setNoneSelected(IntPtr thisPtr)
         {
         	if (_setNoneSelectedFunc == null)
         	{
         		_setNoneSelectedFunc =
         			(_setNoneSelected)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiPopUpMenuCtrl_setNoneSelected"), typeof(_setNoneSelected));
         	}
         
         	 _setNoneSelectedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getTextById(IntPtr thisPtr, int id);
         private static _getTextById _getTextByIdFunc;
         internal static IntPtr getTextById(IntPtr thisPtr, int id)
         {
         	if (_getTextByIdFunc == null)
         	{
         		_getTextByIdFunc =
         			(_getTextById)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiPopUpMenuCtrl_getTextById"), typeof(_getTextById));
         	}
         
         	return  _getTextByIdFunc(thisPtr, id);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _changeTextById(IntPtr thisPtr, int id, [MarshalAs(UnmanagedType.LPWStr)]string text);
         private static _changeTextById _changeTextByIdFunc;
         internal static void changeTextById(IntPtr thisPtr, int id, [MarshalAs(UnmanagedType.LPWStr)]string text)
         {
         	if (_changeTextByIdFunc == null)
         	{
         		_changeTextByIdFunc =
         			(_changeTextById)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiPopUpMenuCtrl_changeTextById"), typeof(_changeTextById));
         	}
         
         	 _changeTextByIdFunc(thisPtr, id, text);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setEnumContent(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string className, [MarshalAs(UnmanagedType.LPWStr)]string enumName);
         private static _setEnumContent _setEnumContentFunc;
         internal static void setEnumContent(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string className, [MarshalAs(UnmanagedType.LPWStr)]string enumName)
         {
         	if (_setEnumContentFunc == null)
         	{
         		_setEnumContentFunc =
         			(_setEnumContent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiPopUpMenuCtrl_setEnumContent"), typeof(_setEnumContent));
         	}
         
         	 _setEnumContentFunc(thisPtr, className, enumName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findText(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string text);
         private static _findText _findTextFunc;
         internal static int findText(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string text)
         {
         	if (_findTextFunc == null)
         	{
         		_findTextFunc =
         			(_findText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiPopUpMenuCtrl_findText"), typeof(_findText));
         	}
         
         	return  _findTextFunc(thisPtr, text);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _size(IntPtr thisPtr);
         private static _size _sizeFunc;
         internal static int size(IntPtr thisPtr)
         {
         	if (_sizeFunc == null)
         	{
         		_sizeFunc =
         			(_size)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiPopUpMenuCtrl_size"), typeof(_size));
         	}
         
         	return  _sizeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _replaceText(IntPtr thisPtr, bool doReplaceText);
         private static _replaceText _replaceTextFunc;
         internal static void replaceText(IntPtr thisPtr, bool doReplaceText)
         {
         	if (_replaceTextFunc == null)
         	{
         		_replaceTextFunc =
         			(_replaceText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiPopUpMenuCtrl_replaceText"), typeof(_replaceText));
         	}
         
         	 _replaceTextFunc(thisPtr, doReplaceText);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearEntry(IntPtr thisPtr, int entry);
         private static _clearEntry _clearEntryFunc;
         internal static void clearEntry(IntPtr thisPtr, int entry)
         {
         	if (_clearEntryFunc == null)
         	{
         		_clearEntryFunc =
         			(_clearEntry)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiPopUpMenuCtrl_clearEntry"), typeof(_clearEntry));
         	}
         
         	 _clearEntryFunc(thisPtr, entry);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiPopUpMenuCtrl_create();
         private static _GuiPopUpMenuCtrl_create _GuiPopUpMenuCtrl_createFunc;
         internal static IntPtr GuiPopUpMenuCtrl_create()
         {
         	if (_GuiPopUpMenuCtrl_createFunc == null)
         	{
         		_GuiPopUpMenuCtrl_createFunc =
         			(_GuiPopUpMenuCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiPopUpMenuCtrl_create"), typeof(_GuiPopUpMenuCtrl_create));
         	}
         
         	return  _GuiPopUpMenuCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void add(string name = "", int idNum = -1, uint scheme = 0)
         {
            InternalUnsafeMethods.add(ObjectPtr, name, idNum, scheme);
         }
      
         public virtual void addScheme(uint id, ColorI fontColor, ColorI fontColorHL, ColorI fontColorSEL)
         {
            InternalUnsafeMethods.addScheme(ObjectPtr, id, fontColor.ToStruct(), fontColorHL.ToStruct(), fontColorSEL.ToStruct());
         }
      
         public virtual string getText()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getText(ObjectPtr));
         }
      
         public virtual void clear()
         {
            InternalUnsafeMethods.clear(ObjectPtr);
         }
      
         public virtual void sort()
         {
            InternalUnsafeMethods.sort(ObjectPtr);
         }
      
         public virtual void sortID()
         {
            InternalUnsafeMethods.sortID(ObjectPtr);
         }
      
         public virtual void forceOnAction()
         {
            InternalUnsafeMethods.forceOnAction(ObjectPtr);
         }
      
         public virtual void forceClose()
         {
            InternalUnsafeMethods.forceClose(ObjectPtr);
         }
      
         public virtual int getSelected()
         {
            return InternalUnsafeMethods.getSelected(ObjectPtr);
         }
      
         public virtual void setSelected(int id, bool scriptCallback = true)
         {
            InternalUnsafeMethods.setSelected(ObjectPtr, id, scriptCallback);
         }
      
         public virtual void setFirstSelected(bool scriptCallback = true)
         {
            InternalUnsafeMethods.setFirstSelected(ObjectPtr, scriptCallback);
         }
      
         public virtual void setNoneSelected()
         {
            InternalUnsafeMethods.setNoneSelected(ObjectPtr);
         }
      
         public virtual string getTextById(int id)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getTextById(ObjectPtr, id));
         }
      
         public virtual void changeTextById(int id, string text)
         {
            InternalUnsafeMethods.changeTextById(ObjectPtr, id, text);
         }
      
         public virtual void setEnumContent(string className, string enumName)
         {
            InternalUnsafeMethods.setEnumContent(ObjectPtr, className, enumName);
         }
      
         public virtual int findText(string text)
         {
            return InternalUnsafeMethods.findText(ObjectPtr, text);
         }
      
         public virtual int size()
         {
            return InternalUnsafeMethods.size(ObjectPtr);
         }
      
         public virtual void replaceText(bool doReplaceText)
         {
            InternalUnsafeMethods.replaceText(ObjectPtr, doReplaceText);
         }
      
         public virtual void clearEntry(int entry)
         {
            InternalUnsafeMethods.clearEntry(ObjectPtr, entry);
         }
      
      
      #endregion


      #region Properties
      
      
         public int MaxPopupHeight
         {
         	get { return int.Parse(getFieldValue("MaxPopupHeight")); }
         	set { setFieldValue("MaxPopupHeight", value.ToString()); }
         }
      
         public bool SbUsesNAColor
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SbUsesNAColor")); }
         	set { setFieldValue("SbUsesNAColor", value ? "1" : "0"); }
         }
      
         public bool ReverseTextList
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ReverseTextList")); }
         	set { setFieldValue("ReverseTextList", value ? "1" : "0"); }
         }
      
         public string Bitmap
         {
         	get { return getFieldValue("Bitmap"); }
         	set { setFieldValue("Bitmap", value); }
         }
      
         public Point2I BitmapBounds
         {
         	get { return new Point2I(getFieldValue("BitmapBounds")); }
         	set { setFieldValue("BitmapBounds", value.ToString()); }
         }
      
      
      #endregion

	}
}