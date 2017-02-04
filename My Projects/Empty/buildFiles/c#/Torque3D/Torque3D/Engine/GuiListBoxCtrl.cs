using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiListBoxCtrl : GuiControl
	{
		public GuiListBoxCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiListBoxCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiListBoxCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiListBoxCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiListBoxCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiListBoxCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiListBoxCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMultipleSelection(IntPtr thisPtr, bool allowMultSelections);
         private static _setMultipleSelection _setMultipleSelectionFunc;
         internal static void setMultipleSelection(IntPtr thisPtr, bool allowMultSelections)
         {
         	if (_setMultipleSelectionFunc == null)
         	{
         		_setMultipleSelectionFunc =
         			(_setMultipleSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_setMultipleSelection"), typeof(_setMultipleSelection));
         	}
         
         	 _setMultipleSelectionFunc(thisPtr, allowMultSelections);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearItems(IntPtr thisPtr);
         private static _clearItems _clearItemsFunc;
         internal static void clearItems(IntPtr thisPtr)
         {
         	if (_clearItemsFunc == null)
         	{
         		_clearItemsFunc =
         			(_clearItems)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_clearItems"), typeof(_clearItems));
         	}
         
         	 _clearItemsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearSelection(IntPtr thisPtr);
         private static _clearSelection _clearSelectionFunc;
         internal static void clearSelection(IntPtr thisPtr)
         {
         	if (_clearSelectionFunc == null)
         	{
         		_clearSelectionFunc =
         			(_clearSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_clearSelection"), typeof(_clearSelection));
         	}
         
         	 _clearSelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSelected(IntPtr thisPtr, int index, bool setSelected);
         private static _setSelected _setSelectedFunc;
         internal static void setSelected(IntPtr thisPtr, int index, bool setSelected)
         {
         	if (_setSelectedFunc == null)
         	{
         		_setSelectedFunc =
         			(_setSelected)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_setSelected"), typeof(_setSelected));
         	}
         
         	 _setSelectedFunc(thisPtr, index, setSelected);
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
         				"fnGuiListBoxCtrl_getItemCount"), typeof(_getItemCount));
         	}
         
         	return  _getItemCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSelCount(IntPtr thisPtr);
         private static _getSelCount _getSelCountFunc;
         internal static int getSelCount(IntPtr thisPtr)
         {
         	if (_getSelCountFunc == null)
         	{
         		_getSelCountFunc =
         			(_getSelCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_getSelCount"), typeof(_getSelCount));
         	}
         
         	return  _getSelCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSelectedItem(IntPtr thisPtr);
         private static _getSelectedItem _getSelectedItemFunc;
         internal static int getSelectedItem(IntPtr thisPtr)
         {
         	if (_getSelectedItemFunc == null)
         	{
         		_getSelectedItemFunc =
         			(_getSelectedItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_getSelectedItem"), typeof(_getSelectedItem));
         	}
         
         	return  _getSelectedItemFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getSelectedItems(IntPtr thisPtr);
         private static _getSelectedItems _getSelectedItemsFunc;
         internal static IntPtr getSelectedItems(IntPtr thisPtr)
         {
         	if (_getSelectedItemsFunc == null)
         	{
         		_getSelectedItemsFunc =
         			(_getSelectedItems)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_getSelectedItems"), typeof(_getSelectedItems));
         	}
         
         	return  _getSelectedItemsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findItemText(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string findText, bool bCaseSensitive);
         private static _findItemText _findItemTextFunc;
         internal static int findItemText(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string findText, bool bCaseSensitive)
         {
         	if (_findItemTextFunc == null)
         	{
         		_findItemTextFunc =
         			(_findItemText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_findItemText"), typeof(_findItemText));
         	}
         
         	return  _findItemTextFunc(thisPtr, findText, bCaseSensitive);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setCurSel(IntPtr thisPtr, int indexId);
         private static _setCurSel _setCurSelFunc;
         internal static void setCurSel(IntPtr thisPtr, int indexId)
         {
         	if (_setCurSelFunc == null)
         	{
         		_setCurSelFunc =
         			(_setCurSel)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_setCurSel"), typeof(_setCurSel));
         	}
         
         	 _setCurSelFunc(thisPtr, indexId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setCurSelRange(IntPtr thisPtr, int indexStart, int indexStop);
         private static _setCurSelRange _setCurSelRangeFunc;
         internal static void setCurSelRange(IntPtr thisPtr, int indexStart, int indexStop)
         {
         	if (_setCurSelRangeFunc == null)
         	{
         		_setCurSelRangeFunc =
         			(_setCurSelRange)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_setCurSelRange"), typeof(_setCurSelRange));
         	}
         
         	 _setCurSelRangeFunc(thisPtr, indexStart, indexStop);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _addItem(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newItem, [MarshalAs(UnmanagedType.LPWStr)]string color);
         private static _addItem _addItemFunc;
         internal static int addItem(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newItem, [MarshalAs(UnmanagedType.LPWStr)]string color)
         {
         	if (_addItemFunc == null)
         	{
         		_addItemFunc =
         			(_addItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_addItem"), typeof(_addItem));
         	}
         
         	return  _addItemFunc(thisPtr, newItem, color);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setItemColor(IntPtr thisPtr, int index, InternalColorFStruct color);
         private static _setItemColor _setItemColorFunc;
         internal static void setItemColor(IntPtr thisPtr, int index, InternalColorFStruct color)
         {
         	if (_setItemColorFunc == null)
         	{
         		_setItemColorFunc =
         			(_setItemColor)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_setItemColor"), typeof(_setItemColor));
         	}
         
         	 _setItemColorFunc(thisPtr, index, color);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearItemColor(IntPtr thisPtr, int index);
         private static _clearItemColor _clearItemColorFunc;
         internal static void clearItemColor(IntPtr thisPtr, int index)
         {
         	if (_clearItemColorFunc == null)
         	{
         		_clearItemColorFunc =
         			(_clearItemColor)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_clearItemColor"), typeof(_clearItemColor));
         	}
         
         	 _clearItemColorFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _insertItem(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string text, int index);
         private static _insertItem _insertItemFunc;
         internal static void insertItem(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string text, int index)
         {
         	if (_insertItemFunc == null)
         	{
         		_insertItemFunc =
         			(_insertItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_insertItem"), typeof(_insertItem));
         	}
         
         	 _insertItemFunc(thisPtr, text, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deleteItem(IntPtr thisPtr, int itemIndex);
         private static _deleteItem _deleteItemFunc;
         internal static void deleteItem(IntPtr thisPtr, int itemIndex)
         {
         	if (_deleteItemFunc == null)
         	{
         		_deleteItemFunc =
         			(_deleteItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_deleteItem"), typeof(_deleteItem));
         	}
         
         	 _deleteItemFunc(thisPtr, itemIndex);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getItemText(IntPtr thisPtr, int index);
         private static _getItemText _getItemTextFunc;
         internal static IntPtr getItemText(IntPtr thisPtr, int index)
         {
         	if (_getItemTextFunc == null)
         	{
         		_getItemTextFunc =
         			(_getItemText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_getItemText"), typeof(_getItemText));
         	}
         
         	return  _getItemTextFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getItemObject(IntPtr thisPtr, int index);
         private static _getItemObject _getItemObjectFunc;
         internal static IntPtr getItemObject(IntPtr thisPtr, int index)
         {
         	if (_getItemObjectFunc == null)
         	{
         		_getItemObjectFunc =
         			(_getItemObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_getItemObject"), typeof(_getItemObject));
         	}
         
         	return  _getItemObjectFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setItemText(IntPtr thisPtr, int index, [MarshalAs(UnmanagedType.LPWStr)]string newtext);
         private static _setItemText _setItemTextFunc;
         internal static void setItemText(IntPtr thisPtr, int index, [MarshalAs(UnmanagedType.LPWStr)]string newtext)
         {
         	if (_setItemTextFunc == null)
         	{
         		_setItemTextFunc =
         			(_setItemText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_setItemText"), typeof(_setItemText));
         	}
         
         	 _setItemTextFunc(thisPtr, index, newtext);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setItemTooltip(IntPtr thisPtr, int index, [MarshalAs(UnmanagedType.LPWStr)]string text);
         private static _setItemTooltip _setItemTooltipFunc;
         internal static void setItemTooltip(IntPtr thisPtr, int index, [MarshalAs(UnmanagedType.LPWStr)]string text)
         {
         	if (_setItemTooltipFunc == null)
         	{
         		_setItemTooltipFunc =
         			(_setItemTooltip)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_setItemTooltip"), typeof(_setItemTooltip));
         	}
         
         	 _setItemTooltipFunc(thisPtr, index, text);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getLastClickItem(IntPtr thisPtr);
         private static _getLastClickItem _getLastClickItemFunc;
         internal static int getLastClickItem(IntPtr thisPtr)
         {
         	if (_getLastClickItemFunc == null)
         	{
         		_getLastClickItemFunc =
         			(_getLastClickItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_getLastClickItem"), typeof(_getLastClickItem));
         	}
         
         	return  _getLastClickItemFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _doMirror(IntPtr thisPtr);
         private static _doMirror _doMirrorFunc;
         internal static void doMirror(IntPtr thisPtr)
         {
         	if (_doMirrorFunc == null)
         	{
         		_doMirrorFunc =
         			(_doMirror)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_doMirror"), typeof(_doMirror));
         	}
         
         	 _doMirrorFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addFilteredItem(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newItem);
         private static _addFilteredItem _addFilteredItemFunc;
         internal static void addFilteredItem(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newItem)
         {
         	if (_addFilteredItemFunc == null)
         	{
         		_addFilteredItemFunc =
         			(_addFilteredItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_addFilteredItem"), typeof(_addFilteredItem));
         	}
         
         	 _addFilteredItemFunc(thisPtr, newItem);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeFilteredItem(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string itemName);
         private static _removeFilteredItem _removeFilteredItemFunc;
         internal static void removeFilteredItem(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string itemName)
         {
         	if (_removeFilteredItemFunc == null)
         	{
         		_removeFilteredItemFunc =
         			(_removeFilteredItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiListBoxCtrl_removeFilteredItem"), typeof(_removeFilteredItem));
         	}
         
         	 _removeFilteredItemFunc(thisPtr, itemName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiListBoxCtrl_create();
         private static _GuiListBoxCtrl_create _GuiListBoxCtrl_createFunc;
         internal static IntPtr GuiListBoxCtrl_create()
         {
         	if (_GuiListBoxCtrl_createFunc == null)
         	{
         		_GuiListBoxCtrl_createFunc =
         			(_GuiListBoxCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiListBoxCtrl_create"), typeof(_GuiListBoxCtrl_create));
         	}
         
         	return  _GuiListBoxCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setMultipleSelection(bool allowMultSelections)
         {
            InternalUnsafeMethods.setMultipleSelection(ObjectPtr, allowMultSelections);
         }
      
         public virtual void clearItems()
         {
            InternalUnsafeMethods.clearItems(ObjectPtr);
         }
      
         public virtual void clearSelection()
         {
            InternalUnsafeMethods.clearSelection(ObjectPtr);
         }
      
         public virtual void setSelected(int index, bool setSelected = true)
         {
            InternalUnsafeMethods.setSelected(ObjectPtr, index, setSelected);
         }
      
         public virtual int getItemCount()
         {
            return InternalUnsafeMethods.getItemCount(ObjectPtr);
         }
      
         public virtual int getSelCount()
         {
            return InternalUnsafeMethods.getSelCount(ObjectPtr);
         }
      
         public virtual int getSelectedItem()
         {
            return InternalUnsafeMethods.getSelectedItem(ObjectPtr);
         }
      
         public virtual string getSelectedItems()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getSelectedItems(ObjectPtr));
         }
      
         public virtual int findItemText(string findText, bool bCaseSensitive = false)
         {
            return InternalUnsafeMethods.findItemText(ObjectPtr, findText, bCaseSensitive);
         }
      
         public virtual void setCurSel(int indexId)
         {
            InternalUnsafeMethods.setCurSel(ObjectPtr, indexId);
         }
      
         public virtual void setCurSelRange(int indexStart, int indexStop = 999999)
         {
            InternalUnsafeMethods.setCurSelRange(ObjectPtr, indexStart, indexStop);
         }
      
         public virtual int addItem(string newItem, string color = "")
         {
            return InternalUnsafeMethods.addItem(ObjectPtr, newItem, color);
         }
      
         public virtual void setItemColor(int index, ColorF color)
         {
            InternalUnsafeMethods.setItemColor(ObjectPtr, index, color.ToStruct());
         }
      
         public virtual void clearItemColor(int index)
         {
            InternalUnsafeMethods.clearItemColor(ObjectPtr, index);
         }
      
         public virtual void insertItem(string text, int index)
         {
            InternalUnsafeMethods.insertItem(ObjectPtr, text, index);
         }
      
         public virtual void deleteItem(int itemIndex)
         {
            InternalUnsafeMethods.deleteItem(ObjectPtr, itemIndex);
         }
      
         public virtual string getItemText(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getItemText(ObjectPtr, index));
         }
      
         public virtual string getItemObject(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getItemObject(ObjectPtr, index));
         }
      
         public virtual void setItemText(int index, string newtext)
         {
            InternalUnsafeMethods.setItemText(ObjectPtr, index, newtext);
         }
      
         public virtual void setItemTooltip(int index, string text)
         {
            InternalUnsafeMethods.setItemTooltip(ObjectPtr, index, text);
         }
      
         public virtual int getLastClickItem()
         {
            return InternalUnsafeMethods.getLastClickItem(ObjectPtr);
         }
      
         public virtual void doMirror()
         {
            InternalUnsafeMethods.doMirror(ObjectPtr);
         }
      
         public virtual void addFilteredItem(string newItem)
         {
            InternalUnsafeMethods.addFilteredItem(ObjectPtr, newItem);
         }
      
         public virtual void removeFilteredItem(string itemName)
         {
            InternalUnsafeMethods.removeFilteredItem(ObjectPtr, itemName);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool AllowMultipleSelections
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowMultipleSelections")); }
         	set { setFieldValue("AllowMultipleSelections", value ? "1" : "0"); }
         }
      
         public bool FitParentWidth
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FitParentWidth")); }
         	set { setFieldValue("FitParentWidth", value ? "1" : "0"); }
         }
      
         public bool ColorBullet
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ColorBullet")); }
         	set { setFieldValue("ColorBullet", value ? "1" : "0"); }
         }
      
         public string MirrorSet
         {
         	get { return getFieldValue("MirrorSet"); }
         	set { setFieldValue("MirrorSet", value); }
         }
      
         public string MakeNameCallback
         {
         	get { return getFieldValue("MakeNameCallback"); }
         	set { setFieldValue("MakeNameCallback", value); }
         }
      
      
      #endregion

	}
}