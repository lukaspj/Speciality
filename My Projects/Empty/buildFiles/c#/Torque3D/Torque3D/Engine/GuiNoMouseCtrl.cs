using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiNoMouseCtrl : GuiControl
	{
		public GuiNoMouseCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiNoMouseCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiNoMouseCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiNoMouseCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiNoMouseCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiNoMouseCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiNoMouseCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiNoMouseCtrl_create();
         private static _GuiNoMouseCtrl_create _GuiNoMouseCtrl_createFunc;
         internal static IntPtr GuiNoMouseCtrl_create()
         {
         	if (_GuiNoMouseCtrl_createFunc == null)
         	{
         		_GuiNoMouseCtrl_createFunc =
         			(_GuiNoMouseCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiNoMouseCtrl_create"), typeof(_GuiNoMouseCtrl_create));
         	}
         
         	return  _GuiNoMouseCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}