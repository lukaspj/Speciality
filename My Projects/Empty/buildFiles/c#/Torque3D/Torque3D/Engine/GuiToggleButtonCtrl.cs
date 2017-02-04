using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiToggleButtonCtrl : GuiButtonCtrl
	{
		public GuiToggleButtonCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiToggleButtonCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiToggleButtonCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiToggleButtonCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiToggleButtonCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiToggleButtonCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiToggleButtonCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiToggleButtonCtrl_create();
         private static _GuiToggleButtonCtrl_create _GuiToggleButtonCtrl_createFunc;
         internal static IntPtr GuiToggleButtonCtrl_create()
         {
         	if (_GuiToggleButtonCtrl_createFunc == null)
         	{
         		_GuiToggleButtonCtrl_createFunc =
         			(_GuiToggleButtonCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiToggleButtonCtrl_create"), typeof(_GuiToggleButtonCtrl_create));
         	}
         
         	return  _GuiToggleButtonCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}