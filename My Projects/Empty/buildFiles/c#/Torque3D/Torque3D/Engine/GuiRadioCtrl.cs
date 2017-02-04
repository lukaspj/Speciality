using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiRadioCtrl : GuiCheckBoxCtrl
	{
		public GuiRadioCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiRadioCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiRadioCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiRadioCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiRadioCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiRadioCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiRadioCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiRadioCtrl_create();
         private static _GuiRadioCtrl_create _GuiRadioCtrl_createFunc;
         internal static IntPtr GuiRadioCtrl_create()
         {
         	if (_GuiRadioCtrl_createFunc == null)
         	{
         		_GuiRadioCtrl_createFunc =
         			(_GuiRadioCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiRadioCtrl_create"), typeof(_GuiRadioCtrl_create));
         	}
         
         	return  _GuiRadioCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}