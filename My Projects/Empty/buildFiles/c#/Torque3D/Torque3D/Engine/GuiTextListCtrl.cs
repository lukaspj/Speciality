using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiTextListCtrl : GuiArrayCtrl
	{
		public GuiTextListCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiTextListCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiTextListCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiTextListCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiTextListCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiTextListCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiTextListCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSelectedId(IntPtr thisPtr);
         private static _getSelectedId _getSelectedIdFunc;
         internal static int getSelectedId(IntPtr thisPtr)
         {
         	if (_getSelectedIdFunc == null)
         	{
         		_getSelectedIdFunc =
         			(_getSelectedId)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextListCtrl_getSelectedId"), typeof(_getSelectedId));
         	}
         
         	return  _getSelectedIdFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSelectedById(IntPtr thisPtr, int id);
         private static _setSelectedById _setSelectedByIdFunc;
         internal static void setSelectedById(IntPtr thisPtr, int id)
         {
         	if (_setSelectedByIdFunc == null)
         	{
         		_setSelectedByIdFunc =
         			(_setSelectedById)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextListCtrl_setSelectedById"), typeof(_setSelectedById));
         	}
         
         	 _setSelectedByIdFunc(thisPtr, id);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSelectedRow(IntPtr thisPtr, int rowNum);
         private static _setSelectedRow _setSelectedRowFunc;
         internal static void setSelectedRow(IntPtr thisPtr, int rowNum)
         {
         	if (_setSelectedRowFunc == null)
         	{
         		_setSelectedRowFunc =
         			(_setSelectedRow)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextListCtrl_setSelectedRow"), typeof(_setSelectedRow));
         	}
         
         	 _setSelectedRowFunc(thisPtr, rowNum);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSelectedRow(IntPtr thisPtr);
         private static _getSelectedRow _getSelectedRowFunc;
         internal static int getSelectedRow(IntPtr thisPtr)
         {
         	if (_getSelectedRowFunc == null)
         	{
         		_getSelectedRowFunc =
         			(_getSelectedRow)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextListCtrl_getSelectedRow"), typeof(_getSelectedRow));
         	}
         
         	return  _getSelectedRowFunc(thisPtr);
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
         				"fnGuiTextListCtrl_clearSelection"), typeof(_clearSelection));
         	}
         
         	 _clearSelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _addRow(IntPtr thisPtr, int id, [MarshalAs(UnmanagedType.LPWStr)]string text, int index);
         private static _addRow _addRowFunc;
         internal static int addRow(IntPtr thisPtr, int id, [MarshalAs(UnmanagedType.LPWStr)]string text, int index)
         {
         	if (_addRowFunc == null)
         	{
         		_addRowFunc =
         			(_addRow)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextListCtrl_addRow"), typeof(_addRow));
         	}
         
         	return  _addRowFunc(thisPtr, id, text, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setRowById(IntPtr thisPtr, int id, [MarshalAs(UnmanagedType.LPWStr)]string text);
         private static _setRowById _setRowByIdFunc;
         internal static void setRowById(IntPtr thisPtr, int id, [MarshalAs(UnmanagedType.LPWStr)]string text)
         {
         	if (_setRowByIdFunc == null)
         	{
         		_setRowByIdFunc =
         			(_setRowById)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextListCtrl_setRowById"), typeof(_setRowById));
         	}
         
         	 _setRowByIdFunc(thisPtr, id, text);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sort(IntPtr thisPtr, int columnId, bool increasing);
         private static _sort _sortFunc;
         internal static void sort(IntPtr thisPtr, int columnId, bool increasing)
         {
         	if (_sortFunc == null)
         	{
         		_sortFunc =
         			(_sort)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextListCtrl_sort"), typeof(_sort));
         	}
         
         	 _sortFunc(thisPtr, columnId, increasing);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sortNumerical(IntPtr thisPtr, int columnID, bool increasing);
         private static _sortNumerical _sortNumericalFunc;
         internal static void sortNumerical(IntPtr thisPtr, int columnID, bool increasing)
         {
         	if (_sortNumericalFunc == null)
         	{
         		_sortNumericalFunc =
         			(_sortNumerical)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextListCtrl_sortNumerical"), typeof(_sortNumerical));
         	}
         
         	 _sortNumericalFunc(thisPtr, columnID, increasing);
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
         				"fnGuiTextListCtrl_clear"), typeof(_clear));
         	}
         
         	 _clearFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _rowCount(IntPtr thisPtr);
         private static _rowCount _rowCountFunc;
         internal static int rowCount(IntPtr thisPtr)
         {
         	if (_rowCountFunc == null)
         	{
         		_rowCountFunc =
         			(_rowCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextListCtrl_rowCount"), typeof(_rowCount));
         	}
         
         	return  _rowCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getRowId(IntPtr thisPtr, int index);
         private static _getRowId _getRowIdFunc;
         internal static int getRowId(IntPtr thisPtr, int index)
         {
         	if (_getRowIdFunc == null)
         	{
         		_getRowIdFunc =
         			(_getRowId)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextListCtrl_getRowId"), typeof(_getRowId));
         	}
         
         	return  _getRowIdFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getRowTextById(IntPtr thisPtr, int id);
         private static _getRowTextById _getRowTextByIdFunc;
         internal static IntPtr getRowTextById(IntPtr thisPtr, int id)
         {
         	if (_getRowTextByIdFunc == null)
         	{
         		_getRowTextByIdFunc =
         			(_getRowTextById)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextListCtrl_getRowTextById"), typeof(_getRowTextById));
         	}
         
         	return  _getRowTextByIdFunc(thisPtr, id);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getRowNumById(IntPtr thisPtr, int id);
         private static _getRowNumById _getRowNumByIdFunc;
         internal static int getRowNumById(IntPtr thisPtr, int id)
         {
         	if (_getRowNumByIdFunc == null)
         	{
         		_getRowNumByIdFunc =
         			(_getRowNumById)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextListCtrl_getRowNumById"), typeof(_getRowNumById));
         	}
         
         	return  _getRowNumByIdFunc(thisPtr, id);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getRowText(IntPtr thisPtr, int index);
         private static _getRowText _getRowTextFunc;
         internal static IntPtr getRowText(IntPtr thisPtr, int index)
         {
         	if (_getRowTextFunc == null)
         	{
         		_getRowTextFunc =
         			(_getRowText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextListCtrl_getRowText"), typeof(_getRowText));
         	}
         
         	return  _getRowTextFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeRowById(IntPtr thisPtr, int id);
         private static _removeRowById _removeRowByIdFunc;
         internal static void removeRowById(IntPtr thisPtr, int id)
         {
         	if (_removeRowByIdFunc == null)
         	{
         		_removeRowByIdFunc =
         			(_removeRowById)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextListCtrl_removeRowById"), typeof(_removeRowById));
         	}
         
         	 _removeRowByIdFunc(thisPtr, id);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeRow(IntPtr thisPtr, int index);
         private static _removeRow _removeRowFunc;
         internal static void removeRow(IntPtr thisPtr, int index)
         {
         	if (_removeRowFunc == null)
         	{
         		_removeRowFunc =
         			(_removeRow)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextListCtrl_removeRow"), typeof(_removeRow));
         	}
         
         	 _removeRowFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _scrollVisible(IntPtr thisPtr, int rowNum);
         private static _scrollVisible _scrollVisibleFunc;
         internal static void scrollVisible(IntPtr thisPtr, int rowNum)
         {
         	if (_scrollVisibleFunc == null)
         	{
         		_scrollVisibleFunc =
         			(_scrollVisible)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextListCtrl_scrollVisible"), typeof(_scrollVisible));
         	}
         
         	 _scrollVisibleFunc(thisPtr, rowNum);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findTextIndex(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string needle);
         private static _findTextIndex _findTextIndexFunc;
         internal static int findTextIndex(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string needle)
         {
         	if (_findTextIndexFunc == null)
         	{
         		_findTextIndexFunc =
         			(_findTextIndex)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextListCtrl_findTextIndex"), typeof(_findTextIndex));
         	}
         
         	return  _findTextIndexFunc(thisPtr, needle);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setRowActive(IntPtr thisPtr, int rowNum, bool active);
         private static _setRowActive _setRowActiveFunc;
         internal static void setRowActive(IntPtr thisPtr, int rowNum, bool active)
         {
         	if (_setRowActiveFunc == null)
         	{
         		_setRowActiveFunc =
         			(_setRowActive)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextListCtrl_setRowActive"), typeof(_setRowActive));
         	}
         
         	 _setRowActiveFunc(thisPtr, rowNum, active);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isRowActive(IntPtr thisPtr, int rowNum);
         private static _isRowActive _isRowActiveFunc;
         internal static bool isRowActive(IntPtr thisPtr, int rowNum)
         {
         	if (_isRowActiveFunc == null)
         	{
         		_isRowActiveFunc =
         			(_isRowActive)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextListCtrl_isRowActive"), typeof(_isRowActive));
         	}
         
         	return  _isRowActiveFunc(thisPtr, rowNum);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTextListCtrl_create();
         private static _GuiTextListCtrl_create _GuiTextListCtrl_createFunc;
         internal static IntPtr GuiTextListCtrl_create()
         {
         	if (_GuiTextListCtrl_createFunc == null)
         	{
         		_GuiTextListCtrl_createFunc =
         			(_GuiTextListCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiTextListCtrl_create"), typeof(_GuiTextListCtrl_create));
         	}
         
         	return  _GuiTextListCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int getSelectedId()
         {
            return InternalUnsafeMethods.getSelectedId(ObjectPtr);
         }
      
         public virtual void setSelectedById(int id)
         {
            InternalUnsafeMethods.setSelectedById(ObjectPtr, id);
         }
      
         public virtual void setSelectedRow(int rowNum)
         {
            InternalUnsafeMethods.setSelectedRow(ObjectPtr, rowNum);
         }
      
         public virtual int getSelectedRow()
         {
            return InternalUnsafeMethods.getSelectedRow(ObjectPtr);
         }
      
         public virtual void clearSelection()
         {
            InternalUnsafeMethods.clearSelection(ObjectPtr);
         }
      
         public virtual int addRow(int id = 0, string text = "", int index = -1)
         {
            return InternalUnsafeMethods.addRow(ObjectPtr, id, text, index);
         }
      
         public virtual void setRowById(int id, string text)
         {
            InternalUnsafeMethods.setRowById(ObjectPtr, id, text);
         }
      
         public virtual void sort(int columnId, bool increasing = true)
         {
            InternalUnsafeMethods.sort(ObjectPtr, columnId, increasing);
         }
      
         public virtual void sortNumerical(int columnID, bool increasing = true)
         {
            InternalUnsafeMethods.sortNumerical(ObjectPtr, columnID, increasing);
         }
      
         public virtual void clear()
         {
            InternalUnsafeMethods.clear(ObjectPtr);
         }
      
         public virtual int rowCount()
         {
            return InternalUnsafeMethods.rowCount(ObjectPtr);
         }
      
         public virtual int getRowId(int index)
         {
            return InternalUnsafeMethods.getRowId(ObjectPtr, index);
         }
      
         public virtual string getRowTextById(int id)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getRowTextById(ObjectPtr, id));
         }
      
         public virtual int getRowNumById(int id)
         {
            return InternalUnsafeMethods.getRowNumById(ObjectPtr, id);
         }
      
         public virtual string getRowText(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getRowText(ObjectPtr, index));
         }
      
         public virtual void removeRowById(int id)
         {
            InternalUnsafeMethods.removeRowById(ObjectPtr, id);
         }
      
         public virtual void removeRow(int index)
         {
            InternalUnsafeMethods.removeRow(ObjectPtr, index);
         }
      
         public virtual void scrollVisible(int rowNum)
         {
            InternalUnsafeMethods.scrollVisible(ObjectPtr, rowNum);
         }
      
         public virtual int findTextIndex(string needle)
         {
            return InternalUnsafeMethods.findTextIndex(ObjectPtr, needle);
         }
      
         public virtual void setRowActive(int rowNum, bool active)
         {
            InternalUnsafeMethods.setRowActive(ObjectPtr, rowNum, active);
         }
      
         public virtual bool isRowActive(int rowNum)
         {
            return InternalUnsafeMethods.isRowActive(ObjectPtr, rowNum);
         }
      
      
      #endregion


      #region Properties
      
      
         public string Columns
         {
         	get { return getFieldValue("Columns"); }
         	set { setFieldValue("Columns", value); }
         }
      
         public bool FitParentWidth
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FitParentWidth")); }
         	set { setFieldValue("FitParentWidth", value ? "1" : "0"); }
         }
      
         public bool ClipColumnText
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ClipColumnText")); }
         	set { setFieldValue("ClipColumnText", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}