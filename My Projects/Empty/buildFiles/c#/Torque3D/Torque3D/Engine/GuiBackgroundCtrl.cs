using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiBackgroundCtrl : GuiControl
	{
		public GuiBackgroundCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiBackgroundCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiBackgroundCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiBackgroundCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiBackgroundCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiBackgroundCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiBackgroundCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiBackgroundCtrl_create();
         private static _GuiBackgroundCtrl_create _GuiBackgroundCtrl_createFunc;
         internal static IntPtr GuiBackgroundCtrl_create()
         {
         	if (_GuiBackgroundCtrl_createFunc == null)
         	{
         		_GuiBackgroundCtrl_createFunc =
         			(_GuiBackgroundCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiBackgroundCtrl_create"), typeof(_GuiBackgroundCtrl_create));
         	}
         
         	return  _GuiBackgroundCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}