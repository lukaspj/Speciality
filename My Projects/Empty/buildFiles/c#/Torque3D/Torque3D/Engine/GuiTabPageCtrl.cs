using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiTabPageCtrl : GuiTextCtrl
	{
		public GuiTabPageCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiTabPageCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiTabPageCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiTabPageCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiTabPageCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiTabPageCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiTabPageCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _select(IntPtr thisPtr);
         private static _select _selectFunc;
         internal static void select(IntPtr thisPtr)
         {
         	if (_selectFunc == null)
         	{
         		_selectFunc =
         			(_select)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTabPageCtrl_select"), typeof(_select));
         	}
         
         	 _selectFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTabPageCtrl_create();
         private static _GuiTabPageCtrl_create _GuiTabPageCtrl_createFunc;
         internal static IntPtr GuiTabPageCtrl_create()
         {
         	if (_GuiTabPageCtrl_createFunc == null)
         	{
         		_GuiTabPageCtrl_createFunc =
         			(_GuiTabPageCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiTabPageCtrl_create"), typeof(_GuiTabPageCtrl_create));
         	}
         
         	return  _GuiTabPageCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void select()
         {
            InternalUnsafeMethods.select(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool FitBook
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FitBook")); }
         	set { setFieldValue("FitBook", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}