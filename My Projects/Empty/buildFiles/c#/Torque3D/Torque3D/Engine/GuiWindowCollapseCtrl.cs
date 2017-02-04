using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiWindowCollapseCtrl : GuiWindowCtrl
	{
		public GuiWindowCollapseCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiWindowCollapseCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiWindowCollapseCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiWindowCollapseCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiWindowCollapseCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiWindowCollapseCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiWindowCollapseCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiWindowCollapseCtrl_create();
         private static _GuiWindowCollapseCtrl_create _GuiWindowCollapseCtrl_createFunc;
         internal static IntPtr GuiWindowCollapseCtrl_create()
         {
         	if (_GuiWindowCollapseCtrl_createFunc == null)
         	{
         		_GuiWindowCollapseCtrl_createFunc =
         			(_GuiWindowCollapseCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiWindowCollapseCtrl_create"), typeof(_GuiWindowCollapseCtrl_create));
         	}
         
         	return  _GuiWindowCollapseCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}