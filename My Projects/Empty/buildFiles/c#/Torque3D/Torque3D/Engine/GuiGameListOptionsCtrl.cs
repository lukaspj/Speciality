using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiGameListOptionsCtrl : GuiGameListMenuCtrl
	{
		public GuiGameListOptionsCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiGameListOptionsCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiGameListOptionsCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiGameListOptionsCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiGameListOptionsCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiGameListOptionsCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiGameListOptionsCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addRow(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string label, [MarshalAs(UnmanagedType.LPWStr)]string options, bool wrapOptions, [MarshalAs(UnmanagedType.LPWStr)]string callback, int icon, int yPad, bool enabled);
         private static _addRow _addRowFunc;
         internal static void addRow(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string label, [MarshalAs(UnmanagedType.LPWStr)]string options, bool wrapOptions, [MarshalAs(UnmanagedType.LPWStr)]string callback, int icon, int yPad, bool enabled)
         {
         	if (_addRowFunc == null)
         	{
         		_addRowFunc =
         			(_addRow)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiGameListOptionsCtrl_addRow"), typeof(_addRow));
         	}
         
         	 _addRowFunc(thisPtr, label, options, wrapOptions, callback, icon, yPad, enabled);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getCurrentOption(IntPtr thisPtr, int row);
         private static _getCurrentOption _getCurrentOptionFunc;
         internal static IntPtr getCurrentOption(IntPtr thisPtr, int row)
         {
         	if (_getCurrentOptionFunc == null)
         	{
         		_getCurrentOptionFunc =
         			(_getCurrentOption)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiGameListOptionsCtrl_getCurrentOption"), typeof(_getCurrentOption));
         	}
         
         	return  _getCurrentOptionFunc(thisPtr, row);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _selectOption(IntPtr thisPtr, int row, [MarshalAs(UnmanagedType.LPWStr)]string option);
         private static _selectOption _selectOptionFunc;
         internal static bool selectOption(IntPtr thisPtr, int row, [MarshalAs(UnmanagedType.LPWStr)]string option)
         {
         	if (_selectOptionFunc == null)
         	{
         		_selectOptionFunc =
         			(_selectOption)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiGameListOptionsCtrl_selectOption"), typeof(_selectOption));
         	}
         
         	return  _selectOptionFunc(thisPtr, row, option);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setOptions(IntPtr thisPtr, int row, [MarshalAs(UnmanagedType.LPWStr)]string optionsList);
         private static _setOptions _setOptionsFunc;
         internal static void setOptions(IntPtr thisPtr, int row, [MarshalAs(UnmanagedType.LPWStr)]string optionsList)
         {
         	if (_setOptionsFunc == null)
         	{
         		_setOptionsFunc =
         			(_setOptions)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiGameListOptionsCtrl_setOptions"), typeof(_setOptions));
         	}
         
         	 _setOptionsFunc(thisPtr, row, optionsList);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiGameListOptionsCtrl_create();
         private static _GuiGameListOptionsCtrl_create _GuiGameListOptionsCtrl_createFunc;
         internal static IntPtr GuiGameListOptionsCtrl_create()
         {
         	if (_GuiGameListOptionsCtrl_createFunc == null)
         	{
         		_GuiGameListOptionsCtrl_createFunc =
         			(_GuiGameListOptionsCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiGameListOptionsCtrl_create"), typeof(_GuiGameListOptionsCtrl_create));
         	}
         
         	return  _GuiGameListOptionsCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void addRow(string label, string options, bool wrapOptions, string callback, int icon = -1, int yPad = 0, bool enabled = true)
         {
            InternalUnsafeMethods.addRow(ObjectPtr, label, options, wrapOptions, callback, icon, yPad, enabled);
         }
      
         public virtual string getCurrentOption(int row)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getCurrentOption(ObjectPtr, row));
         }
      
         public virtual bool selectOption(int row, string option)
         {
            return InternalUnsafeMethods.selectOption(ObjectPtr, row, option);
         }
      
         public virtual void setOptions(int row, string optionsList)
         {
            InternalUnsafeMethods.setOptions(ObjectPtr, row, optionsList);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}