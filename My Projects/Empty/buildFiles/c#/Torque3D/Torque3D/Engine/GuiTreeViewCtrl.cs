using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiTreeViewCtrl : GuiArrayCtrl
	{
		public GuiTreeViewCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiTreeViewCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiTreeViewCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiTreeViewCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiTreeViewCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiTreeViewCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiTreeViewCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findItemByName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string text);
         private static _findItemByName _findItemByNameFunc;
         internal static int findItemByName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string text)
         {
         	if (_findItemByNameFunc == null)
         	{
         		_findItemByNameFunc =
         			(_findItemByName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_findItemByName"), typeof(_findItemByName));
         	}
         
         	return  _findItemByNameFunc(thisPtr, text);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findItemByValue(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string value);
         private static _findItemByValue _findItemByValueFunc;
         internal static int findItemByValue(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string value)
         {
         	if (_findItemByValueFunc == null)
         	{
         		_findItemByValueFunc =
         			(_findItemByValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_findItemByValue"), typeof(_findItemByValue));
         	}
         
         	return  _findItemByValueFunc(thisPtr, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findChildItemByName(IntPtr thisPtr, int parentId, [MarshalAs(UnmanagedType.LPWStr)]string childName);
         private static _findChildItemByName _findChildItemByNameFunc;
         internal static int findChildItemByName(IntPtr thisPtr, int parentId, [MarshalAs(UnmanagedType.LPWStr)]string childName)
         {
         	if (_findChildItemByNameFunc == null)
         	{
         		_findChildItemByNameFunc =
         			(_findChildItemByName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_findChildItemByName"), typeof(_findChildItemByName));
         	}
         
         	return  _findChildItemByNameFunc(thisPtr, parentId, childName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _insertItem(IntPtr thisPtr, int parentId, [MarshalAs(UnmanagedType.LPWStr)]string text, [MarshalAs(UnmanagedType.LPWStr)]string value, [MarshalAs(UnmanagedType.LPWStr)]string icon, int normalImage, int expandedImage);
         private static _insertItem _insertItemFunc;
         internal static int insertItem(IntPtr thisPtr, int parentId, [MarshalAs(UnmanagedType.LPWStr)]string text, [MarshalAs(UnmanagedType.LPWStr)]string value, [MarshalAs(UnmanagedType.LPWStr)]string icon, int normalImage, int expandedImage)
         {
         	if (_insertItemFunc == null)
         	{
         		_insertItemFunc =
         			(_insertItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_insertItem"), typeof(_insertItem));
         	}
         
         	return  _insertItemFunc(thisPtr, parentId, text, value, icon, normalImage, expandedImage);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _insertObject(IntPtr thisPtr, int parentId, IntPtr obj, bool OKToEdit);
         private static _insertObject _insertObjectFunc;
         internal static int insertObject(IntPtr thisPtr, int parentId, IntPtr obj, bool OKToEdit)
         {
         	if (_insertObjectFunc == null)
         	{
         		_insertObjectFunc =
         			(_insertObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_insertObject"), typeof(_insertObject));
         	}
         
         	return  _insertObjectFunc(thisPtr, parentId, obj, OKToEdit);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _lockSelection(IntPtr thisPtr, bool _lock);
         private static _lockSelection _lockSelectionFunc;
         internal static void lockSelection(IntPtr thisPtr, bool _lock)
         {
         	if (_lockSelectionFunc == null)
         	{
         		_lockSelectionFunc =
         			(_lockSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_lockSelection"), typeof(_lockSelection));
         	}
         
         	 _lockSelectionFunc(thisPtr, _lock);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _hideSelection(IntPtr thisPtr, bool state);
         private static _hideSelection _hideSelectionFunc;
         internal static void hideSelection(IntPtr thisPtr, bool state)
         {
         	if (_hideSelectionFunc == null)
         	{
         		_hideSelectionFunc =
         			(_hideSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_hideSelection"), typeof(_hideSelection));
         	}
         
         	 _hideSelectionFunc(thisPtr, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _toggleLockSelection(IntPtr thisPtr);
         private static _toggleLockSelection _toggleLockSelectionFunc;
         internal static void toggleLockSelection(IntPtr thisPtr)
         {
         	if (_toggleLockSelectionFunc == null)
         	{
         		_toggleLockSelectionFunc =
         			(_toggleLockSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_toggleLockSelection"), typeof(_toggleLockSelection));
         	}
         
         	 _toggleLockSelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _toggleHideSelection(IntPtr thisPtr);
         private static _toggleHideSelection _toggleHideSelectionFunc;
         internal static void toggleHideSelection(IntPtr thisPtr)
         {
         	if (_toggleHideSelectionFunc == null)
         	{
         		_toggleHideSelectionFunc =
         			(_toggleHideSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_toggleHideSelection"), typeof(_toggleHideSelection));
         	}
         
         	 _toggleHideSelectionFunc(thisPtr);
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
         				"fnGuiTreeViewCtrl_clearSelection"), typeof(_clearSelection));
         	}
         
         	 _clearSelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deleteSelection(IntPtr thisPtr);
         private static _deleteSelection _deleteSelectionFunc;
         internal static void deleteSelection(IntPtr thisPtr)
         {
         	if (_deleteSelectionFunc == null)
         	{
         		_deleteSelectionFunc =
         			(_deleteSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_deleteSelection"), typeof(_deleteSelection));
         	}
         
         	 _deleteSelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addSelection(IntPtr thisPtr, int id, bool isLastSelection);
         private static _addSelection _addSelectionFunc;
         internal static void addSelection(IntPtr thisPtr, int id, bool isLastSelection)
         {
         	if (_addSelectionFunc == null)
         	{
         		_addSelectionFunc =
         			(_addSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_addSelection"), typeof(_addSelection));
         	}
         
         	 _addSelectionFunc(thisPtr, id, isLastSelection);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addChildSelectionByValue(IntPtr thisPtr, int parentId, [MarshalAs(UnmanagedType.LPWStr)]string value);
         private static _addChildSelectionByValue _addChildSelectionByValueFunc;
         internal static void addChildSelectionByValue(IntPtr thisPtr, int parentId, [MarshalAs(UnmanagedType.LPWStr)]string value)
         {
         	if (_addChildSelectionByValueFunc == null)
         	{
         		_addChildSelectionByValueFunc =
         			(_addChildSelectionByValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_addChildSelectionByValue"), typeof(_addChildSelectionByValue));
         	}
         
         	 _addChildSelectionByValueFunc(thisPtr, parentId, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeSelection(IntPtr thisPtr, int itemId);
         private static _removeSelection _removeSelectionFunc;
         internal static void removeSelection(IntPtr thisPtr, int itemId)
         {
         	if (_removeSelectionFunc == null)
         	{
         		_removeSelectionFunc =
         			(_removeSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_removeSelection"), typeof(_removeSelection));
         	}
         
         	 _removeSelectionFunc(thisPtr, itemId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeChildSelectionByValue(IntPtr thisPtr, int parentId, [MarshalAs(UnmanagedType.LPWStr)]string value);
         private static _removeChildSelectionByValue _removeChildSelectionByValueFunc;
         internal static void removeChildSelectionByValue(IntPtr thisPtr, int parentId, [MarshalAs(UnmanagedType.LPWStr)]string value)
         {
         	if (_removeChildSelectionByValueFunc == null)
         	{
         		_removeChildSelectionByValueFunc =
         			(_removeChildSelectionByValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_removeChildSelectionByValue"), typeof(_removeChildSelectionByValue));
         	}
         
         	 _removeChildSelectionByValueFunc(thisPtr, parentId, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _selectItem(IntPtr thisPtr, int itemID, bool select);
         private static _selectItem _selectItemFunc;
         internal static bool selectItem(IntPtr thisPtr, int itemID, bool select)
         {
         	if (_selectItemFunc == null)
         	{
         		_selectItemFunc =
         			(_selectItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_selectItem"), typeof(_selectItem));
         	}
         
         	return  _selectItemFunc(thisPtr, itemID, select);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _expandItem(IntPtr thisPtr, int itemID, bool expand);
         private static _expandItem _expandItemFunc;
         internal static bool expandItem(IntPtr thisPtr, int itemID, bool expand)
         {
         	if (_expandItemFunc == null)
         	{
         		_expandItemFunc =
         			(_expandItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_expandItem"), typeof(_expandItem));
         	}
         
         	return  _expandItemFunc(thisPtr, itemID, expand);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _markItem(IntPtr thisPtr, int itemID, bool mark);
         private static _markItem _markItemFunc;
         internal static bool markItem(IntPtr thisPtr, int itemID, bool mark)
         {
         	if (_markItemFunc == null)
         	{
         		_markItemFunc =
         			(_markItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_markItem"), typeof(_markItem));
         	}
         
         	return  _markItemFunc(thisPtr, itemID, mark);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _scrollVisible(IntPtr thisPtr, int itemID);
         private static _scrollVisible _scrollVisibleFunc;
         internal static bool scrollVisible(IntPtr thisPtr, int itemID)
         {
         	if (_scrollVisibleFunc == null)
         	{
         		_scrollVisibleFunc =
         			(_scrollVisible)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_scrollVisible"), typeof(_scrollVisible));
         	}
         
         	return  _scrollVisibleFunc(thisPtr, itemID);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _buildIconTable(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string icons);
         private static _buildIconTable _buildIconTableFunc;
         internal static bool buildIconTable(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string icons)
         {
         	if (_buildIconTableFunc == null)
         	{
         		_buildIconTableFunc =
         			(_buildIconTable)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_buildIconTable"), typeof(_buildIconTable));
         	}
         
         	return  _buildIconTableFunc(thisPtr, icons);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _open(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName, bool okToEdit);
         private static _open _openFunc;
         internal static void open(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName, bool okToEdit)
         {
         	if (_openFunc == null)
         	{
         		_openFunc =
         			(_open)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_open"), typeof(_open));
         	}
         
         	 _openFunc(thisPtr, objName, okToEdit);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setItemTooltip(IntPtr thisPtr, int itemId, [MarshalAs(UnmanagedType.LPWStr)]string tooltip);
         private static _setItemTooltip _setItemTooltipFunc;
         internal static bool setItemTooltip(IntPtr thisPtr, int itemId, [MarshalAs(UnmanagedType.LPWStr)]string tooltip)
         {
         	if (_setItemTooltipFunc == null)
         	{
         		_setItemTooltipFunc =
         			(_setItemTooltip)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_setItemTooltip"), typeof(_setItemTooltip));
         	}
         
         	return  _setItemTooltipFunc(thisPtr, itemId, tooltip);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setItemImages(IntPtr thisPtr, int itemId, sbyte normalImage, sbyte expandedImage);
         private static _setItemImages _setItemImagesFunc;
         internal static void setItemImages(IntPtr thisPtr, int itemId, sbyte normalImage, sbyte expandedImage)
         {
         	if (_setItemImagesFunc == null)
         	{
         		_setItemImagesFunc =
         			(_setItemImages)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_setItemImages"), typeof(_setItemImages));
         	}
         
         	 _setItemImagesFunc(thisPtr, itemId, normalImage, expandedImage);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isParentItem(IntPtr thisPtr, int itemId);
         private static _isParentItem _isParentItemFunc;
         internal static bool isParentItem(IntPtr thisPtr, int itemId)
         {
         	if (_isParentItemFunc == null)
         	{
         		_isParentItemFunc =
         			(_isParentItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_isParentItem"), typeof(_isParentItem));
         	}
         
         	return  _isParentItemFunc(thisPtr, itemId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getItemText(IntPtr thisPtr, int itemId);
         private static _getItemText _getItemTextFunc;
         internal static IntPtr getItemText(IntPtr thisPtr, int itemId)
         {
         	if (_getItemTextFunc == null)
         	{
         		_getItemTextFunc =
         			(_getItemText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_getItemText"), typeof(_getItemText));
         	}
         
         	return  _getItemTextFunc(thisPtr, itemId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getItemValue(IntPtr thisPtr, int itemId);
         private static _getItemValue _getItemValueFunc;
         internal static IntPtr getItemValue(IntPtr thisPtr, int itemId)
         {
         	if (_getItemValueFunc == null)
         	{
         		_getItemValueFunc =
         			(_getItemValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_getItemValue"), typeof(_getItemValue));
         	}
         
         	return  _getItemValueFunc(thisPtr, itemId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _editItem(IntPtr thisPtr, int itemId, [MarshalAs(UnmanagedType.LPWStr)]string newText, [MarshalAs(UnmanagedType.LPWStr)]string newValue);
         private static _editItem _editItemFunc;
         internal static bool editItem(IntPtr thisPtr, int itemId, [MarshalAs(UnmanagedType.LPWStr)]string newText, [MarshalAs(UnmanagedType.LPWStr)]string newValue)
         {
         	if (_editItemFunc == null)
         	{
         		_editItemFunc =
         			(_editItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_editItem"), typeof(_editItem));
         	}
         
         	return  _editItemFunc(thisPtr, itemId, newText, newValue);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _removeItem(IntPtr thisPtr, int itemId);
         private static _removeItem _removeItemFunc;
         internal static bool removeItem(IntPtr thisPtr, int itemId)
         {
         	if (_removeItemFunc == null)
         	{
         		_removeItemFunc =
         			(_removeItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_removeItem"), typeof(_removeItem));
         	}
         
         	return  _removeItemFunc(thisPtr, itemId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeAllChildren(IntPtr thisPtr, int itemId);
         private static _removeAllChildren _removeAllChildrenFunc;
         internal static void removeAllChildren(IntPtr thisPtr, int itemId)
         {
         	if (_removeAllChildrenFunc == null)
         	{
         		_removeAllChildrenFunc =
         			(_removeAllChildren)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_removeAllChildren"), typeof(_removeAllChildren));
         	}
         
         	 _removeAllChildrenFunc(thisPtr, itemId);
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
         				"fnGuiTreeViewCtrl_clear"), typeof(_clear));
         	}
         
         	 _clearFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getFirstRootItem(IntPtr thisPtr);
         private static _getFirstRootItem _getFirstRootItemFunc;
         internal static int getFirstRootItem(IntPtr thisPtr)
         {
         	if (_getFirstRootItemFunc == null)
         	{
         		_getFirstRootItemFunc =
         			(_getFirstRootItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_getFirstRootItem"), typeof(_getFirstRootItem));
         	}
         
         	return  _getFirstRootItemFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getChild(IntPtr thisPtr, int itemId);
         private static _getChild _getChildFunc;
         internal static int getChild(IntPtr thisPtr, int itemId)
         {
         	if (_getChildFunc == null)
         	{
         		_getChildFunc =
         			(_getChild)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_getChild"), typeof(_getChild));
         	}
         
         	return  _getChildFunc(thisPtr, itemId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _buildVisibleTree(IntPtr thisPtr, bool forceFullUpdate);
         private static _buildVisibleTree _buildVisibleTreeFunc;
         internal static void buildVisibleTree(IntPtr thisPtr, bool forceFullUpdate)
         {
         	if (_buildVisibleTreeFunc == null)
         	{
         		_buildVisibleTreeFunc =
         			(_buildVisibleTree)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_buildVisibleTree"), typeof(_buildVisibleTree));
         	}
         
         	 _buildVisibleTreeFunc(thisPtr, forceFullUpdate);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getParentItem(IntPtr thisPtr, int itemId);
         private static _getParentItem _getParentItemFunc;
         internal static int getParentItem(IntPtr thisPtr, int itemId)
         {
         	if (_getParentItemFunc == null)
         	{
         		_getParentItemFunc =
         			(_getParentItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_getParentItem"), typeof(_getParentItem));
         	}
         
         	return  _getParentItemFunc(thisPtr, itemId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getNextSibling(IntPtr thisPtr, int itemId);
         private static _getNextSibling _getNextSiblingFunc;
         internal static int getNextSibling(IntPtr thisPtr, int itemId)
         {
         	if (_getNextSiblingFunc == null)
         	{
         		_getNextSiblingFunc =
         			(_getNextSibling)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_getNextSibling"), typeof(_getNextSibling));
         	}
         
         	return  _getNextSiblingFunc(thisPtr, itemId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getPrevSibling(IntPtr thisPtr, int itemId);
         private static _getPrevSibling _getPrevSiblingFunc;
         internal static int getPrevSibling(IntPtr thisPtr, int itemId)
         {
         	if (_getPrevSiblingFunc == null)
         	{
         		_getPrevSiblingFunc =
         			(_getPrevSibling)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_getPrevSibling"), typeof(_getPrevSibling));
         	}
         
         	return  _getPrevSiblingFunc(thisPtr, itemId);
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
         				"fnGuiTreeViewCtrl_getItemCount"), typeof(_getItemCount));
         	}
         
         	return  _getItemCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSelectedItem(IntPtr thisPtr, int index);
         private static _getSelectedItem _getSelectedItemFunc;
         internal static int getSelectedItem(IntPtr thisPtr, int index)
         {
         	if (_getSelectedItemFunc == null)
         	{
         		_getSelectedItemFunc =
         			(_getSelectedItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_getSelectedItem"), typeof(_getSelectedItem));
         	}
         
         	return  _getSelectedItemFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSelectedObject(IntPtr thisPtr, int index);
         private static _getSelectedObject _getSelectedObjectFunc;
         internal static int getSelectedObject(IntPtr thisPtr, int index)
         {
         	if (_getSelectedObjectFunc == null)
         	{
         		_getSelectedObjectFunc =
         			(_getSelectedObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_getSelectedObject"), typeof(_getSelectedObject));
         	}
         
         	return  _getSelectedObjectFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getSelectedObjectList(IntPtr thisPtr);
         private static _getSelectedObjectList _getSelectedObjectListFunc;
         internal static IntPtr getSelectedObjectList(IntPtr thisPtr)
         {
         	if (_getSelectedObjectListFunc == null)
         	{
         		_getSelectedObjectListFunc =
         			(_getSelectedObjectList)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_getSelectedObjectList"), typeof(_getSelectedObjectList));
         	}
         
         	return  _getSelectedObjectListFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _moveItemUp(IntPtr thisPtr, int itemId);
         private static _moveItemUp _moveItemUpFunc;
         internal static void moveItemUp(IntPtr thisPtr, int itemId)
         {
         	if (_moveItemUpFunc == null)
         	{
         		_moveItemUpFunc =
         			(_moveItemUp)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_moveItemUp"), typeof(_moveItemUp));
         	}
         
         	 _moveItemUpFunc(thisPtr, itemId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSelectedItemsCount(IntPtr thisPtr);
         private static _getSelectedItemsCount _getSelectedItemsCountFunc;
         internal static int getSelectedItemsCount(IntPtr thisPtr)
         {
         	if (_getSelectedItemsCountFunc == null)
         	{
         		_getSelectedItemsCountFunc =
         			(_getSelectedItemsCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_getSelectedItemsCount"), typeof(_getSelectedItemsCount));
         	}
         
         	return  _getSelectedItemsCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _moveItemDown(IntPtr thisPtr, int itemId);
         private static _moveItemDown _moveItemDownFunc;
         internal static void moveItemDown(IntPtr thisPtr, int itemId)
         {
         	if (_moveItemDownFunc == null)
         	{
         		_moveItemDownFunc =
         			(_moveItemDown)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_moveItemDown"), typeof(_moveItemDown));
         	}
         
         	 _moveItemDownFunc(thisPtr, itemId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getTextToRoot(IntPtr thisPtr, int itemId, [MarshalAs(UnmanagedType.LPWStr)]string delimiter);
         private static _getTextToRoot _getTextToRootFunc;
         internal static IntPtr getTextToRoot(IntPtr thisPtr, int itemId, [MarshalAs(UnmanagedType.LPWStr)]string delimiter)
         {
         	if (_getTextToRootFunc == null)
         	{
         		_getTextToRootFunc =
         			(_getTextToRoot)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_getTextToRoot"), typeof(_getTextToRoot));
         	}
         
         	return  _getTextToRootFunc(thisPtr, itemId, delimiter);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getSelectedItemList(IntPtr thisPtr);
         private static _getSelectedItemList _getSelectedItemListFunc;
         internal static IntPtr getSelectedItemList(IntPtr thisPtr)
         {
         	if (_getSelectedItemListFunc == null)
         	{
         		_getSelectedItemListFunc =
         			(_getSelectedItemList)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_getSelectedItemList"), typeof(_getSelectedItemList));
         	}
         
         	return  _getSelectedItemListFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findItemByObjectId(IntPtr thisPtr, int objectId);
         private static _findItemByObjectId _findItemByObjectIdFunc;
         internal static int findItemByObjectId(IntPtr thisPtr, int objectId)
         {
         	if (_findItemByObjectIdFunc == null)
         	{
         		_findItemByObjectIdFunc =
         			(_findItemByObjectId)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_findItemByObjectId"), typeof(_findItemByObjectId));
         	}
         
         	return  _findItemByObjectIdFunc(thisPtr, objectId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _scrollVisibleByObjectId(IntPtr thisPtr, int objectId);
         private static _scrollVisibleByObjectId _scrollVisibleByObjectIdFunc;
         internal static int scrollVisibleByObjectId(IntPtr thisPtr, int objectId)
         {
         	if (_scrollVisibleByObjectIdFunc == null)
         	{
         		_scrollVisibleByObjectIdFunc =
         			(_scrollVisibleByObjectId)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_scrollVisibleByObjectId"), typeof(_scrollVisibleByObjectId));
         	}
         
         	return  _scrollVisibleByObjectIdFunc(thisPtr, objectId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sort(IntPtr thisPtr, int parentId, bool traverseHierarchy, bool parentsFirst, bool caseSensitive);
         private static _sort _sortFunc;
         internal static void sort(IntPtr thisPtr, int parentId, bool traverseHierarchy, bool parentsFirst, bool caseSensitive)
         {
         	if (_sortFunc == null)
         	{
         		_sortFunc =
         			(_sort)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_sort"), typeof(_sort));
         	}
         
         	 _sortFunc(thisPtr, parentId, traverseHierarchy, parentsFirst, caseSensitive);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _cancelRename(IntPtr thisPtr);
         private static _cancelRename _cancelRenameFunc;
         internal static void cancelRename(IntPtr thisPtr)
         {
         	if (_cancelRenameFunc == null)
         	{
         		_cancelRenameFunc =
         			(_cancelRename)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_cancelRename"), typeof(_cancelRename));
         	}
         
         	 _cancelRenameFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _onRenameValidate(IntPtr thisPtr);
         private static _onRenameValidate _onRenameValidateFunc;
         internal static void onRenameValidate(IntPtr thisPtr)
         {
         	if (_onRenameValidateFunc == null)
         	{
         		_onRenameValidateFunc =
         			(_onRenameValidate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_onRenameValidate"), typeof(_onRenameValidate));
         	}
         
         	 _onRenameValidateFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _showItemRenameCtrl(IntPtr thisPtr, int itemId);
         private static _showItemRenameCtrl _showItemRenameCtrlFunc;
         internal static void showItemRenameCtrl(IntPtr thisPtr, int itemId)
         {
         	if (_showItemRenameCtrlFunc == null)
         	{
         		_showItemRenameCtrlFunc =
         			(_showItemRenameCtrl)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_showItemRenameCtrl"), typeof(_showItemRenameCtrl));
         	}
         
         	 _showItemRenameCtrlFunc(thisPtr, itemId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setDebug(IntPtr thisPtr, bool value);
         private static _setDebug _setDebugFunc;
         internal static void setDebug(IntPtr thisPtr, bool value)
         {
         	if (_setDebugFunc == null)
         	{
         		_setDebugFunc =
         			(_setDebug)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_setDebug"), typeof(_setDebug));
         	}
         
         	 _setDebugFunc(thisPtr, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isItemSelected(IntPtr thisPtr, int id);
         private static _isItemSelected _isItemSelectedFunc;
         internal static bool isItemSelected(IntPtr thisPtr, int id)
         {
         	if (_isItemSelectedFunc == null)
         	{
         		_isItemSelectedFunc =
         			(_isItemSelected)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_isItemSelected"), typeof(_isItemSelected));
         	}
         
         	return  _isItemSelectedFunc(thisPtr, id);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getFilterText(IntPtr thisPtr);
         private static _getFilterText _getFilterTextFunc;
         internal static IntPtr getFilterText(IntPtr thisPtr)
         {
         	if (_getFilterTextFunc == null)
         	{
         		_getFilterTextFunc =
         			(_getFilterText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_getFilterText"), typeof(_getFilterText));
         	}
         
         	return  _getFilterTextFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setFilterText(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pattern);
         private static _setFilterText _setFilterTextFunc;
         internal static void setFilterText(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pattern)
         {
         	if (_setFilterTextFunc == null)
         	{
         		_setFilterTextFunc =
         			(_setFilterText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_setFilterText"), typeof(_setFilterText));
         	}
         
         	 _setFilterTextFunc(thisPtr, pattern);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearFilterText(IntPtr thisPtr);
         private static _clearFilterText _clearFilterTextFunc;
         internal static void clearFilterText(IntPtr thisPtr)
         {
         	if (_clearFilterTextFunc == null)
         	{
         		_clearFilterTextFunc =
         			(_clearFilterText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTreeViewCtrl_clearFilterText"), typeof(_clearFilterText));
         	}
         
         	 _clearFilterTextFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTreeViewCtrl_create();
         private static _GuiTreeViewCtrl_create _GuiTreeViewCtrl_createFunc;
         internal static IntPtr GuiTreeViewCtrl_create()
         {
         	if (_GuiTreeViewCtrl_createFunc == null)
         	{
         		_GuiTreeViewCtrl_createFunc =
         			(_GuiTreeViewCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiTreeViewCtrl_create"), typeof(_GuiTreeViewCtrl_create));
         	}
         
         	return  _GuiTreeViewCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int findItemByName(string text)
         {
            return InternalUnsafeMethods.findItemByName(ObjectPtr, text);
         }
      
         public virtual int findItemByValue(string value)
         {
            return InternalUnsafeMethods.findItemByValue(ObjectPtr, value);
         }
      
         public virtual int findChildItemByName(int parentId, string childName)
         {
            return InternalUnsafeMethods.findChildItemByName(ObjectPtr, parentId, childName);
         }
      
         public virtual int insertItem(int parentId, string text, string value = "", string icon = "", int normalImage = 0, int expandedImage = 0)
         {
            return InternalUnsafeMethods.insertItem(ObjectPtr, parentId, text, value, icon, normalImage, expandedImage);
         }
      
         public virtual int insertObject(int parentId, SimObject obj, bool OKToEdit = false)
         {
            return InternalUnsafeMethods.insertObject(ObjectPtr, parentId, obj.ObjectPtr, OKToEdit);
         }
      
         public virtual void lockSelection(bool _lock = true)
         {
            InternalUnsafeMethods.lockSelection(ObjectPtr, _lock);
         }
      
         public virtual void hideSelection(bool state = true)
         {
            InternalUnsafeMethods.hideSelection(ObjectPtr, state);
         }
      
         public virtual void toggleLockSelection()
         {
            InternalUnsafeMethods.toggleLockSelection(ObjectPtr);
         }
      
         public virtual void toggleHideSelection()
         {
            InternalUnsafeMethods.toggleHideSelection(ObjectPtr);
         }
      
         public virtual void clearSelection()
         {
            InternalUnsafeMethods.clearSelection(ObjectPtr);
         }
      
         public virtual void deleteSelection()
         {
            InternalUnsafeMethods.deleteSelection(ObjectPtr);
         }
      
         public virtual void addSelection(int id, bool isLastSelection = true)
         {
            InternalUnsafeMethods.addSelection(ObjectPtr, id, isLastSelection);
         }
      
         public virtual void addChildSelectionByValue(int parentId, string value)
         {
            InternalUnsafeMethods.addChildSelectionByValue(ObjectPtr, parentId, value);
         }
      
         public virtual void removeSelection(int itemId)
         {
            InternalUnsafeMethods.removeSelection(ObjectPtr, itemId);
         }
      
         public virtual void removeChildSelectionByValue(int parentId, string value)
         {
            InternalUnsafeMethods.removeChildSelectionByValue(ObjectPtr, parentId, value);
         }
      
         public virtual bool selectItem(int itemID, bool select = true)
         {
            return InternalUnsafeMethods.selectItem(ObjectPtr, itemID, select);
         }
      
         public virtual bool expandItem(int itemID, bool expand = true)
         {
            return InternalUnsafeMethods.expandItem(ObjectPtr, itemID, expand);
         }
      
         public virtual bool markItem(int itemID, bool mark = true)
         {
            return InternalUnsafeMethods.markItem(ObjectPtr, itemID, mark);
         }
      
         public virtual bool scrollVisible(int itemID)
         {
            return InternalUnsafeMethods.scrollVisible(ObjectPtr, itemID);
         }
      
         public virtual bool buildIconTable(string icons)
         {
            return InternalUnsafeMethods.buildIconTable(ObjectPtr, icons);
         }
      
         public virtual void open(string objName, bool okToEdit = true)
         {
            InternalUnsafeMethods.open(ObjectPtr, objName, okToEdit);
         }
      
         public virtual bool setItemTooltip(int itemId, string tooltip)
         {
            return InternalUnsafeMethods.setItemTooltip(ObjectPtr, itemId, tooltip);
         }
      
         public virtual void setItemImages(int itemId, sbyte normalImage, sbyte expandedImage)
         {
            InternalUnsafeMethods.setItemImages(ObjectPtr, itemId, normalImage, expandedImage);
         }
      
         public virtual bool isParentItem(int itemId)
         {
            return InternalUnsafeMethods.isParentItem(ObjectPtr, itemId);
         }
      
         public virtual string getItemText(int itemId)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getItemText(ObjectPtr, itemId));
         }
      
         public virtual string getItemValue(int itemId)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getItemValue(ObjectPtr, itemId));
         }
      
         public virtual bool editItem(int itemId, string newText, string newValue)
         {
            return InternalUnsafeMethods.editItem(ObjectPtr, itemId, newText, newValue);
         }
      
         public virtual bool removeItem(int itemId)
         {
            return InternalUnsafeMethods.removeItem(ObjectPtr, itemId);
         }
      
         public virtual void removeAllChildren(int itemId)
         {
            InternalUnsafeMethods.removeAllChildren(ObjectPtr, itemId);
         }
      
         public virtual void clear()
         {
            InternalUnsafeMethods.clear(ObjectPtr);
         }
      
         public virtual int getFirstRootItem()
         {
            return InternalUnsafeMethods.getFirstRootItem(ObjectPtr);
         }
      
         public virtual int getChild(int itemId)
         {
            return InternalUnsafeMethods.getChild(ObjectPtr, itemId);
         }
      
         public virtual void buildVisibleTree(bool forceFullUpdate = false)
         {
            InternalUnsafeMethods.buildVisibleTree(ObjectPtr, forceFullUpdate);
         }
      
         public virtual int getParentItem(int itemId)
         {
            return InternalUnsafeMethods.getParentItem(ObjectPtr, itemId);
         }
      
         public virtual int getNextSibling(int itemId)
         {
            return InternalUnsafeMethods.getNextSibling(ObjectPtr, itemId);
         }
      
         public virtual int getPrevSibling(int itemId)
         {
            return InternalUnsafeMethods.getPrevSibling(ObjectPtr, itemId);
         }
      
         public virtual int getItemCount()
         {
            return InternalUnsafeMethods.getItemCount(ObjectPtr);
         }
      
         public virtual int getSelectedItem(int index = 0)
         {
            return InternalUnsafeMethods.getSelectedItem(ObjectPtr, index);
         }
      
         public virtual int getSelectedObject(int index = 0)
         {
            return InternalUnsafeMethods.getSelectedObject(ObjectPtr, index);
         }
      
         public virtual string getSelectedObjectList()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getSelectedObjectList(ObjectPtr));
         }
      
         public virtual void moveItemUp(int itemId)
         {
            InternalUnsafeMethods.moveItemUp(ObjectPtr, itemId);
         }
      
         public virtual int getSelectedItemsCount()
         {
            return InternalUnsafeMethods.getSelectedItemsCount(ObjectPtr);
         }
      
         public virtual void moveItemDown(int itemId)
         {
            InternalUnsafeMethods.moveItemDown(ObjectPtr, itemId);
         }
      
         public virtual string getTextToRoot(int itemId, string delimiter = "")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getTextToRoot(ObjectPtr, itemId, delimiter));
         }
      
         public virtual string getSelectedItemList()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getSelectedItemList(ObjectPtr));
         }
      
         public virtual int findItemByObjectId(int objectId)
         {
            return InternalUnsafeMethods.findItemByObjectId(ObjectPtr, objectId);
         }
      
         public virtual int scrollVisibleByObjectId(int objectId)
         {
            return InternalUnsafeMethods.scrollVisibleByObjectId(ObjectPtr, objectId);
         }
      
         public virtual void sort(int parentId = 0, bool traverseHierarchy = false, bool parentsFirst = false, bool caseSensitive = true)
         {
            InternalUnsafeMethods.sort(ObjectPtr, parentId, traverseHierarchy, parentsFirst, caseSensitive);
         }
      
         public virtual void cancelRename()
         {
            InternalUnsafeMethods.cancelRename(ObjectPtr);
         }
      
         public virtual void onRenameValidate()
         {
            InternalUnsafeMethods.onRenameValidate(ObjectPtr);
         }
      
         public virtual void showItemRenameCtrl(int itemId)
         {
            InternalUnsafeMethods.showItemRenameCtrl(ObjectPtr, itemId);
         }
      
         public virtual void setDebug(bool value = true)
         {
            InternalUnsafeMethods.setDebug(ObjectPtr, value);
         }
      
         public virtual bool isItemSelected(int id)
         {
            return InternalUnsafeMethods.isItemSelected(ObjectPtr, id);
         }
      
         public virtual string getFilterText()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getFilterText(ObjectPtr));
         }
      
         public virtual void setFilterText(string pattern)
         {
            InternalUnsafeMethods.setFilterText(ObjectPtr, pattern);
         }
      
         public virtual void clearFilterText()
         {
            InternalUnsafeMethods.clearFilterText(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public int TabSize
         {
         	get { return int.Parse(getFieldValue("TabSize")); }
         	set { setFieldValue("TabSize", value.ToString()); }
         }
      
         public int TextOffset
         {
         	get { return int.Parse(getFieldValue("TextOffset")); }
         	set { setFieldValue("TextOffset", value.ToString()); }
         }
      
         public bool FullRowSelect
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FullRowSelect")); }
         	set { setFieldValue("FullRowSelect", value ? "1" : "0"); }
         }
      
         public int ItemHeight
         {
         	get { return int.Parse(getFieldValue("ItemHeight")); }
         	set { setFieldValue("ItemHeight", value.ToString()); }
         }
      
         public bool DestroyTreeOnSleep
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("DestroyTreeOnSleep")); }
         	set { setFieldValue("DestroyTreeOnSleep", value ? "1" : "0"); }
         }
      
         public bool MouseDragging
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("MouseDragging")); }
         	set { setFieldValue("MouseDragging", value ? "1" : "0"); }
         }
      
         public bool MultipleSelections
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("MultipleSelections")); }
         	set { setFieldValue("MultipleSelections", value ? "1" : "0"); }
         }
      
         public bool DeleteObjectAllowed
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("DeleteObjectAllowed")); }
         	set { setFieldValue("DeleteObjectAllowed", value ? "1" : "0"); }
         }
      
         public bool DragToItemAllowed
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("DragToItemAllowed")); }
         	set { setFieldValue("DragToItemAllowed", value ? "1" : "0"); }
         }
      
         public bool ClearAllOnSingleSelection
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ClearAllOnSingleSelection")); }
         	set { setFieldValue("ClearAllOnSingleSelection", value ? "1" : "0"); }
         }
      
         public bool ShowRoot
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowRoot")); }
         	set { setFieldValue("ShowRoot", value ? "1" : "0"); }
         }
      
         public bool UseInspectorTooltips
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseInspectorTooltips")); }
         	set { setFieldValue("UseInspectorTooltips", value ? "1" : "0"); }
         }
      
         public bool TooltipOnWidthOnly
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("TooltipOnWidthOnly")); }
         	set { setFieldValue("TooltipOnWidthOnly", value ? "1" : "0"); }
         }
      
         public bool ShowObjectIds
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowObjectIds")); }
         	set { setFieldValue("ShowObjectIds", value ? "1" : "0"); }
         }
      
         public bool ShowClassNames
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowClassNames")); }
         	set { setFieldValue("ShowClassNames", value ? "1" : "0"); }
         }
      
         public bool ShowObjectNames
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowObjectNames")); }
         	set { setFieldValue("ShowObjectNames", value ? "1" : "0"); }
         }
      
         public bool ShowInternalNames
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowInternalNames")); }
         	set { setFieldValue("ShowInternalNames", value ? "1" : "0"); }
         }
      
         public bool ShowClassNameForUnnamedObjects
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowClassNameForUnnamedObjects")); }
         	set { setFieldValue("ShowClassNameForUnnamedObjects", value ? "1" : "0"); }
         }
      
         public bool CompareToObjectID
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CompareToObjectID")); }
         	set { setFieldValue("CompareToObjectID", value ? "1" : "0"); }
         }
      
         public bool CanRenameObjects
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CanRenameObjects")); }
         	set { setFieldValue("CanRenameObjects", value ? "1" : "0"); }
         }
      
         public bool RenameInternal
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenameInternal")); }
         	set { setFieldValue("RenameInternal", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}