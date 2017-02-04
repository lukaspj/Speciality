using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiMLTextEditCtrl : GuiMLTextCtrl
	{
		public GuiMLTextEditCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiMLTextEditCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiMLTextEditCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiMLTextEditCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiMLTextEditCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiMLTextEditCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiMLTextEditCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiMLTextEditCtrl_create();
         private static _GuiMLTextEditCtrl_create _GuiMLTextEditCtrl_createFunc;
         internal static IntPtr GuiMLTextEditCtrl_create()
         {
         	if (_GuiMLTextEditCtrl_createFunc == null)
         	{
         		_GuiMLTextEditCtrl_createFunc =
         			(_GuiMLTextEditCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiMLTextEditCtrl_create"), typeof(_GuiMLTextEditCtrl_create));
         	}
         
         	return  _GuiMLTextEditCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string EscapeCommand
         {
         	get { return getFieldValue("EscapeCommand"); }
         	set { setFieldValue("EscapeCommand", value); }
         }
      
      
      #endregion

	}
}