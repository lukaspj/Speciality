using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiGameListMenuCtrl : GuiControl
	{
		public GuiGameListMenuCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiGameListMenuCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiGameListMenuCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiGameListMenuCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiGameListMenuCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiGameListMenuCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiGameListMenuCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addRow(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string label, [MarshalAs(UnmanagedType.LPWStr)]string callback, int icon, int yPad, bool useHighlightIcon, bool enabled);
         private static _addRow _addRowFunc;
         internal static void addRow(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string label, [MarshalAs(UnmanagedType.LPWStr)]string callback, int icon, int yPad, bool useHighlightIcon, bool enabled)
         {
         	if (_addRowFunc == null)
         	{
         		_addRowFunc =
         			(_addRow)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiGameListMenuCtrl_addRow"), typeof(_addRow));
         	}
         
         	 _addRowFunc(thisPtr, label, callback, icon, yPad, useHighlightIcon, enabled);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isRowEnabled(IntPtr thisPtr, int row);
         private static _isRowEnabled _isRowEnabledFunc;
         internal static bool isRowEnabled(IntPtr thisPtr, int row)
         {
         	if (_isRowEnabledFunc == null)
         	{
         		_isRowEnabledFunc =
         			(_isRowEnabled)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiGameListMenuCtrl_isRowEnabled"), typeof(_isRowEnabled));
         	}
         
         	return  _isRowEnabledFunc(thisPtr, row);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setRowEnabled(IntPtr thisPtr, int row, bool enabled);
         private static _setRowEnabled _setRowEnabledFunc;
         internal static void setRowEnabled(IntPtr thisPtr, int row, bool enabled)
         {
         	if (_setRowEnabledFunc == null)
         	{
         		_setRowEnabledFunc =
         			(_setRowEnabled)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiGameListMenuCtrl_setRowEnabled"), typeof(_setRowEnabled));
         	}
         
         	 _setRowEnabledFunc(thisPtr, row, enabled);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _activateRow(IntPtr thisPtr);
         private static _activateRow _activateRowFunc;
         internal static void activateRow(IntPtr thisPtr)
         {
         	if (_activateRowFunc == null)
         	{
         		_activateRowFunc =
         			(_activateRow)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiGameListMenuCtrl_activateRow"), typeof(_activateRow));
         	}
         
         	 _activateRowFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getRowCount(IntPtr thisPtr);
         private static _getRowCount _getRowCountFunc;
         internal static int getRowCount(IntPtr thisPtr)
         {
         	if (_getRowCountFunc == null)
         	{
         		_getRowCountFunc =
         			(_getRowCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiGameListMenuCtrl_getRowCount"), typeof(_getRowCount));
         	}
         
         	return  _getRowCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getRowLabel(IntPtr thisPtr, int row);
         private static _getRowLabel _getRowLabelFunc;
         internal static IntPtr getRowLabel(IntPtr thisPtr, int row)
         {
         	if (_getRowLabelFunc == null)
         	{
         		_getRowLabelFunc =
         			(_getRowLabel)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiGameListMenuCtrl_getRowLabel"), typeof(_getRowLabel));
         	}
         
         	return  _getRowLabelFunc(thisPtr, row);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setRowLabel(IntPtr thisPtr, int row, [MarshalAs(UnmanagedType.LPWStr)]string label);
         private static _setRowLabel _setRowLabelFunc;
         internal static void setRowLabel(IntPtr thisPtr, int row, [MarshalAs(UnmanagedType.LPWStr)]string label)
         {
         	if (_setRowLabelFunc == null)
         	{
         		_setRowLabelFunc =
         			(_setRowLabel)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiGameListMenuCtrl_setRowLabel"), typeof(_setRowLabel));
         	}
         
         	 _setRowLabelFunc(thisPtr, row, label);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSelected(IntPtr thisPtr, int row);
         private static _setSelected _setSelectedFunc;
         internal static void setSelected(IntPtr thisPtr, int row)
         {
         	if (_setSelectedFunc == null)
         	{
         		_setSelectedFunc =
         			(_setSelected)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiGameListMenuCtrl_setSelected"), typeof(_setSelected));
         	}
         
         	 _setSelectedFunc(thisPtr, row);
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
         				"fnGuiGameListMenuCtrl_getSelectedRow"), typeof(_getSelectedRow));
         	}
         
         	return  _getSelectedRowFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiGameListMenuCtrl_create();
         private static _GuiGameListMenuCtrl_create _GuiGameListMenuCtrl_createFunc;
         internal static IntPtr GuiGameListMenuCtrl_create()
         {
         	if (_GuiGameListMenuCtrl_createFunc == null)
         	{
         		_GuiGameListMenuCtrl_createFunc =
         			(_GuiGameListMenuCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiGameListMenuCtrl_create"), typeof(_GuiGameListMenuCtrl_create));
         	}
         
         	return  _GuiGameListMenuCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void addRow(string label, string callback, int icon = -1, int yPad = 0, bool useHighlightIcon = true, bool enabled = true)
         {
            InternalUnsafeMethods.addRow(ObjectPtr, label, callback, icon, yPad, useHighlightIcon, enabled);
         }
      
         public virtual bool isRowEnabled(int row)
         {
            return InternalUnsafeMethods.isRowEnabled(ObjectPtr, row);
         }
      
         public virtual void setRowEnabled(int row, bool enabled)
         {
            InternalUnsafeMethods.setRowEnabled(ObjectPtr, row, enabled);
         }
      
         public virtual void activateRow()
         {
            InternalUnsafeMethods.activateRow(ObjectPtr);
         }
      
         public virtual int getRowCount()
         {
            return InternalUnsafeMethods.getRowCount(ObjectPtr);
         }
      
         public virtual string getRowLabel(int row)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getRowLabel(ObjectPtr, row));
         }
      
         public virtual void setRowLabel(int row, string label)
         {
            InternalUnsafeMethods.setRowLabel(ObjectPtr, row, label);
         }
      
         public virtual void setSelected(int row)
         {
            InternalUnsafeMethods.setSelected(ObjectPtr, row);
         }
      
         public virtual int getSelectedRow()
         {
            return InternalUnsafeMethods.getSelectedRow(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool DebugRender
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("DebugRender")); }
         	set { setFieldValue("DebugRender", value ? "1" : "0"); }
         }
      
         public string CallbackOnA
         {
         	get { return getFieldValue("CallbackOnA"); }
         	set { setFieldValue("CallbackOnA", value); }
         }
      
         public string CallbackOnB
         {
         	get { return getFieldValue("CallbackOnB"); }
         	set { setFieldValue("CallbackOnB", value); }
         }
      
         public string CallbackOnX
         {
         	get { return getFieldValue("CallbackOnX"); }
         	set { setFieldValue("CallbackOnX", value); }
         }
      
         public string CallbackOnY
         {
         	get { return getFieldValue("CallbackOnY"); }
         	set { setFieldValue("CallbackOnY", value); }
         }
      
      
      #endregion

	}
}