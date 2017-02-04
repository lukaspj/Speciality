using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiEditCtrl : GuiControl
	{
		public GuiEditCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiEditCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiEditCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiEditCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiEditCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiEditCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiEditCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getContentControl(IntPtr thisPtr);
         private static _getContentControl _getContentControlFunc;
         internal static int getContentControl(IntPtr thisPtr)
         {
         	if (_getContentControlFunc == null)
         	{
         		_getContentControlFunc =
         			(_getContentControl)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_getContentControl"), typeof(_getContentControl));
         	}
         
         	return  _getContentControlFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setContentControl(IntPtr thisPtr, IntPtr ctrl);
         private static _setContentControl _setContentControlFunc;
         internal static void setContentControl(IntPtr thisPtr, IntPtr ctrl)
         {
         	if (_setContentControlFunc == null)
         	{
         		_setContentControlFunc =
         			(_setContentControl)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_setContentControl"), typeof(_setContentControl));
         	}
         
         	 _setContentControlFunc(thisPtr, ctrl);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addNewCtrl(IntPtr thisPtr, IntPtr ctrl);
         private static _addNewCtrl _addNewCtrlFunc;
         internal static void addNewCtrl(IntPtr thisPtr, IntPtr ctrl)
         {
         	if (_addNewCtrlFunc == null)
         	{
         		_addNewCtrlFunc =
         			(_addNewCtrl)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_addNewCtrl"), typeof(_addNewCtrl));
         	}
         
         	 _addNewCtrlFunc(thisPtr, ctrl);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addSelection(IntPtr thisPtr, int id);
         private static _addSelection _addSelectionFunc;
         internal static void addSelection(IntPtr thisPtr, int id)
         {
         	if (_addSelectionFunc == null)
         	{
         		_addSelectionFunc =
         			(_addSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_addSelection"), typeof(_addSelection));
         	}
         
         	 _addSelectionFunc(thisPtr, id);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeSelection(IntPtr thisPtr, int id);
         private static _removeSelection _removeSelectionFunc;
         internal static void removeSelection(IntPtr thisPtr, int id)
         {
         	if (_removeSelectionFunc == null)
         	{
         		_removeSelectionFunc =
         			(_removeSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_removeSelection"), typeof(_removeSelection));
         	}
         
         	 _removeSelectionFunc(thisPtr, id);
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
         				"fnGuiEditCtrl_clearSelection"), typeof(_clearSelection));
         	}
         
         	 _clearSelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _select(IntPtr thisPtr, IntPtr ctrl);
         private static _select _selectFunc;
         internal static void select(IntPtr thisPtr, IntPtr ctrl)
         {
         	if (_selectFunc == null)
         	{
         		_selectFunc =
         			(_select)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_select"), typeof(_select));
         	}
         
         	 _selectFunc(thisPtr, ctrl);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setCurrentAddSet(IntPtr thisPtr, IntPtr addSet);
         private static _setCurrentAddSet _setCurrentAddSetFunc;
         internal static void setCurrentAddSet(IntPtr thisPtr, IntPtr addSet)
         {
         	if (_setCurrentAddSetFunc == null)
         	{
         		_setCurrentAddSetFunc =
         			(_setCurrentAddSet)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_setCurrentAddSet"), typeof(_setCurrentAddSet));
         	}
         
         	 _setCurrentAddSetFunc(thisPtr, addSet);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getCurrentAddSet(IntPtr thisPtr);
         private static _getCurrentAddSet _getCurrentAddSetFunc;
         internal static int getCurrentAddSet(IntPtr thisPtr)
         {
         	if (_getCurrentAddSetFunc == null)
         	{
         		_getCurrentAddSetFunc =
         			(_getCurrentAddSet)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_getCurrentAddSet"), typeof(_getCurrentAddSet));
         	}
         
         	return  _getCurrentAddSetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _toggle(IntPtr thisPtr);
         private static _toggle _toggleFunc;
         internal static void toggle(IntPtr thisPtr)
         {
         	if (_toggleFunc == null)
         	{
         		_toggleFunc =
         			(_toggle)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_toggle"), typeof(_toggle));
         	}
         
         	 _toggleFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _justify(IntPtr thisPtr, uint mode);
         private static _justify _justifyFunc;
         internal static void justify(IntPtr thisPtr, uint mode)
         {
         	if (_justifyFunc == null)
         	{
         		_justifyFunc =
         			(_justify)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_justify"), typeof(_justify));
         	}
         
         	 _justifyFunc(thisPtr, mode);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _bringToFront(IntPtr thisPtr);
         private static _bringToFront _bringToFrontFunc;
         internal static void bringToFront(IntPtr thisPtr)
         {
         	if (_bringToFrontFunc == null)
         	{
         		_bringToFrontFunc =
         			(_bringToFront)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_bringToFront"), typeof(_bringToFront));
         	}
         
         	 _bringToFrontFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _pushToBack(IntPtr thisPtr);
         private static _pushToBack _pushToBackFunc;
         internal static void pushToBack(IntPtr thisPtr)
         {
         	if (_pushToBackFunc == null)
         	{
         		_pushToBackFunc =
         			(_pushToBack)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_pushToBack"), typeof(_pushToBack));
         	}
         
         	 _pushToBackFunc(thisPtr);
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
         				"fnGuiEditCtrl_deleteSelection"), typeof(_deleteSelection));
         	}
         
         	 _deleteSelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _moveSelection(IntPtr thisPtr, int dx, int dy);
         private static _moveSelection _moveSelectionFunc;
         internal static void moveSelection(IntPtr thisPtr, int dx, int dy)
         {
         	if (_moveSelectionFunc == null)
         	{
         		_moveSelectionFunc =
         			(_moveSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_moveSelection"), typeof(_moveSelection));
         	}
         
         	 _moveSelectionFunc(thisPtr, dx, dy);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _saveSelection(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _saveSelection _saveSelectionFunc;
         internal static void saveSelection(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_saveSelectionFunc == null)
         	{
         		_saveSelectionFunc =
         			(_saveSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_saveSelection"), typeof(_saveSelection));
         	}
         
         	 _saveSelectionFunc(thisPtr, filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _loadSelection(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _loadSelection _loadSelectionFunc;
         internal static void loadSelection(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_loadSelectionFunc == null)
         	{
         		_loadSelectionFunc =
         			(_loadSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_loadSelection"), typeof(_loadSelection));
         	}
         
         	 _loadSelectionFunc(thisPtr, filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _selectAll(IntPtr thisPtr);
         private static _selectAll _selectAllFunc;
         internal static void selectAll(IntPtr thisPtr)
         {
         	if (_selectAllFunc == null)
         	{
         		_selectAllFunc =
         			(_selectAll)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_selectAll"), typeof(_selectAll));
         	}
         
         	 _selectAllFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getSelection(IntPtr thisPtr);
         private static _getSelection _getSelectionFunc;
         internal static IntPtr getSelection(IntPtr thisPtr)
         {
         	if (_getSelectionFunc == null)
         	{
         		_getSelectionFunc =
         			(_getSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_getSelection"), typeof(_getSelection));
         	}
         
         	return  _getSelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getNumSelected(IntPtr thisPtr);
         private static _getNumSelected _getNumSelectedFunc;
         internal static int getNumSelected(IntPtr thisPtr)
         {
         	if (_getNumSelectedFunc == null)
         	{
         		_getNumSelectedFunc =
         			(_getNumSelected)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_getNumSelected"), typeof(_getNumSelected));
         	}
         
         	return  _getNumSelectedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getSelectionGlobalBounds(IntPtr thisPtr);
         private static _getSelectionGlobalBounds _getSelectionGlobalBoundsFunc;
         internal static IntPtr getSelectionGlobalBounds(IntPtr thisPtr)
         {
         	if (_getSelectionGlobalBoundsFunc == null)
         	{
         		_getSelectionGlobalBoundsFunc =
         			(_getSelectionGlobalBounds)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_getSelectionGlobalBounds"), typeof(_getSelectionGlobalBounds));
         	}
         
         	return  _getSelectionGlobalBoundsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _selectParents(IntPtr thisPtr, bool addToSelection);
         private static _selectParents _selectParentsFunc;
         internal static void selectParents(IntPtr thisPtr, bool addToSelection)
         {
         	if (_selectParentsFunc == null)
         	{
         		_selectParentsFunc =
         			(_selectParents)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_selectParents"), typeof(_selectParents));
         	}
         
         	 _selectParentsFunc(thisPtr, addToSelection);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _selectChildren(IntPtr thisPtr, bool addToSelection);
         private static _selectChildren _selectChildrenFunc;
         internal static void selectChildren(IntPtr thisPtr, bool addToSelection)
         {
         	if (_selectChildrenFunc == null)
         	{
         		_selectChildrenFunc =
         			(_selectChildren)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_selectChildren"), typeof(_selectChildren));
         	}
         
         	 _selectChildrenFunc(thisPtr, addToSelection);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getTrash(IntPtr thisPtr);
         private static _getTrash _getTrashFunc;
         internal static IntPtr getTrash(IntPtr thisPtr)
         {
         	if (_getTrashFunc == null)
         	{
         		_getTrashFunc =
         			(_getTrash)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_getTrash"), typeof(_getTrash));
         	}
         
         	return  _getTrashFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSnapToGrid(IntPtr thisPtr, uint gridsize);
         private static _setSnapToGrid _setSnapToGridFunc;
         internal static void setSnapToGrid(IntPtr thisPtr, uint gridsize)
         {
         	if (_setSnapToGridFunc == null)
         	{
         		_setSnapToGridFunc =
         			(_setSnapToGrid)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_setSnapToGrid"), typeof(_setSnapToGrid));
         	}
         
         	 _setSnapToGridFunc(thisPtr, gridsize);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _readGuides(IntPtr thisPtr, IntPtr ctrl, int axis);
         private static _readGuides _readGuidesFunc;
         internal static void readGuides(IntPtr thisPtr, IntPtr ctrl, int axis)
         {
         	if (_readGuidesFunc == null)
         	{
         		_readGuidesFunc =
         			(_readGuides)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_readGuides"), typeof(_readGuides));
         	}
         
         	 _readGuidesFunc(thisPtr, ctrl, axis);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _writeGuides(IntPtr thisPtr, IntPtr ctrl, int axis);
         private static _writeGuides _writeGuidesFunc;
         internal static void writeGuides(IntPtr thisPtr, IntPtr ctrl, int axis)
         {
         	if (_writeGuidesFunc == null)
         	{
         		_writeGuidesFunc =
         			(_writeGuides)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_writeGuides"), typeof(_writeGuides));
         	}
         
         	 _writeGuidesFunc(thisPtr, ctrl, axis);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearGuides(IntPtr thisPtr, int axis);
         private static _clearGuides _clearGuidesFunc;
         internal static void clearGuides(IntPtr thisPtr, int axis)
         {
         	if (_clearGuidesFunc == null)
         	{
         		_clearGuidesFunc =
         			(_clearGuides)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_clearGuides"), typeof(_clearGuides));
         	}
         
         	 _clearGuidesFunc(thisPtr, axis);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _fitIntoParents(IntPtr thisPtr, bool width, bool height);
         private static _fitIntoParents _fitIntoParentsFunc;
         internal static void fitIntoParents(IntPtr thisPtr, bool width, bool height)
         {
         	if (_fitIntoParentsFunc == null)
         	{
         		_fitIntoParentsFunc =
         			(_fitIntoParents)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_fitIntoParents"), typeof(_fitIntoParents));
         	}
         
         	 _fitIntoParentsFunc(thisPtr, width, height);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getMouseMode(IntPtr thisPtr);
         private static _getMouseMode _getMouseModeFunc;
         internal static IntPtr getMouseMode(IntPtr thisPtr)
         {
         	if (_getMouseModeFunc == null)
         	{
         		_getMouseModeFunc =
         			(_getMouseMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiEditCtrl_getMouseMode"), typeof(_getMouseMode));
         	}
         
         	return  _getMouseModeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiEditCtrl_create();
         private static _GuiEditCtrl_create _GuiEditCtrl_createFunc;
         internal static IntPtr GuiEditCtrl_create()
         {
         	if (_GuiEditCtrl_createFunc == null)
         	{
         		_GuiEditCtrl_createFunc =
         			(_GuiEditCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiEditCtrl_create"), typeof(_GuiEditCtrl_create));
         	}
         
         	return  _GuiEditCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int getContentControl()
         {
            return InternalUnsafeMethods.getContentControl(ObjectPtr);
         }
      
         public virtual void setContentControl(GuiControl ctrl)
         {
            InternalUnsafeMethods.setContentControl(ObjectPtr, ctrl.ObjectPtr);
         }
      
         public virtual void addNewCtrl(GuiControl ctrl)
         {
            InternalUnsafeMethods.addNewCtrl(ObjectPtr, ctrl.ObjectPtr);
         }
      
         public virtual void addSelection(int id)
         {
            InternalUnsafeMethods.addSelection(ObjectPtr, id);
         }
      
         public virtual void removeSelection(int id)
         {
            InternalUnsafeMethods.removeSelection(ObjectPtr, id);
         }
      
         public virtual void clearSelection()
         {
            InternalUnsafeMethods.clearSelection(ObjectPtr);
         }
      
         public virtual void select(GuiControl ctrl)
         {
            InternalUnsafeMethods.select(ObjectPtr, ctrl.ObjectPtr);
         }
      
         public virtual void setCurrentAddSet(GuiControl addSet)
         {
            InternalUnsafeMethods.setCurrentAddSet(ObjectPtr, addSet.ObjectPtr);
         }
      
         public virtual int getCurrentAddSet()
         {
            return InternalUnsafeMethods.getCurrentAddSet(ObjectPtr);
         }
      
         public virtual void toggle()
         {
            InternalUnsafeMethods.toggle(ObjectPtr);
         }
      
         public virtual void justify(uint mode)
         {
            InternalUnsafeMethods.justify(ObjectPtr, mode);
         }
      
         public virtual void bringToFront()
         {
            InternalUnsafeMethods.bringToFront(ObjectPtr);
         }
      
         public virtual void pushToBack()
         {
            InternalUnsafeMethods.pushToBack(ObjectPtr);
         }
      
         public virtual void deleteSelection()
         {
            InternalUnsafeMethods.deleteSelection(ObjectPtr);
         }
      
         public virtual void moveSelection(int dx, int dy)
         {
            InternalUnsafeMethods.moveSelection(ObjectPtr, dx, dy);
         }
      
         public virtual void saveSelection(string filename = null)
         {
            InternalUnsafeMethods.saveSelection(ObjectPtr, filename);
         }
      
         public virtual void loadSelection(string filename = null)
         {
            InternalUnsafeMethods.loadSelection(ObjectPtr, filename);
         }
      
         public virtual void selectAll()
         {
            InternalUnsafeMethods.selectAll(ObjectPtr);
         }
      
         public virtual SimSet getSelection()
         {
            return new SimSet(InternalUnsafeMethods.getSelection(ObjectPtr));
         }
      
         public virtual int getNumSelected()
         {
            return InternalUnsafeMethods.getNumSelected(ObjectPtr);
         }
      
         public virtual string getSelectionGlobalBounds()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getSelectionGlobalBounds(ObjectPtr));
         }
      
         public virtual void selectParents(bool addToSelection = false)
         {
            InternalUnsafeMethods.selectParents(ObjectPtr, addToSelection);
         }
      
         public virtual void selectChildren(bool addToSelection = false)
         {
            InternalUnsafeMethods.selectChildren(ObjectPtr, addToSelection);
         }
      
         public virtual SimGroup getTrash()
         {
            return new SimGroup(InternalUnsafeMethods.getTrash(ObjectPtr));
         }
      
         public virtual void setSnapToGrid(uint gridsize)
         {
            InternalUnsafeMethods.setSnapToGrid(ObjectPtr, gridsize);
         }
      
         public virtual void readGuides(GuiControl ctrl, int axis = -1)
         {
            InternalUnsafeMethods.readGuides(ObjectPtr, ctrl.ObjectPtr, axis);
         }
      
         public virtual void writeGuides(GuiControl ctrl, int axis = -1)
         {
            InternalUnsafeMethods.writeGuides(ObjectPtr, ctrl.ObjectPtr, axis);
         }
      
         public virtual void clearGuides(int axis = -1)
         {
            InternalUnsafeMethods.clearGuides(ObjectPtr, axis);
         }
      
         public virtual void fitIntoParents(bool width = true, bool height = true)
         {
            InternalUnsafeMethods.fitIntoParents(ObjectPtr, width, height);
         }
      
         public virtual string getMouseMode()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getMouseMode(ObjectPtr));
         }
      
      
      #endregion


      #region Properties
      
      
         public bool SnapToControls
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SnapToControls")); }
         	set { setFieldValue("SnapToControls", value ? "1" : "0"); }
         }
      
         public bool SnapToGuides
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SnapToGuides")); }
         	set { setFieldValue("SnapToGuides", value ? "1" : "0"); }
         }
      
         public bool SnapToCanvas
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SnapToCanvas")); }
         	set { setFieldValue("SnapToCanvas", value ? "1" : "0"); }
         }
      
         public bool SnapToEdges
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SnapToEdges")); }
         	set { setFieldValue("SnapToEdges", value ? "1" : "0"); }
         }
      
         public bool SnapToCenters
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SnapToCenters")); }
         	set { setFieldValue("SnapToCenters", value ? "1" : "0"); }
         }
      
         public int SnapSensitivity
         {
         	get { return int.Parse(getFieldValue("SnapSensitivity")); }
         	set { setFieldValue("SnapSensitivity", value.ToString()); }
         }
      
         public bool FullBoxSelection
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FullBoxSelection")); }
         	set { setFieldValue("FullBoxSelection", value ? "1" : "0"); }
         }
      
         public bool DrawBorderLines
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("DrawBorderLines")); }
         	set { setFieldValue("DrawBorderLines", value ? "1" : "0"); }
         }
      
         public bool DrawGuides
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("DrawGuides")); }
         	set { setFieldValue("DrawGuides", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}