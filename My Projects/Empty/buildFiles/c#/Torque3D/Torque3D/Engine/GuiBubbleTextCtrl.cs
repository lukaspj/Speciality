using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiBubbleTextCtrl : GuiTextCtrl
	{
		public GuiBubbleTextCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiBubbleTextCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiBubbleTextCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiBubbleTextCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiBubbleTextCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiBubbleTextCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiBubbleTextCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiBubbleTextCtrl_create();
         private static _GuiBubbleTextCtrl_create _GuiBubbleTextCtrl_createFunc;
         internal static IntPtr GuiBubbleTextCtrl_create()
         {
         	if (_GuiBubbleTextCtrl_createFunc == null)
         	{
         		_GuiBubbleTextCtrl_createFunc =
         			(_GuiBubbleTextCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiBubbleTextCtrl_create"), typeof(_GuiBubbleTextCtrl_create));
         	}
         
         	return  _GuiBubbleTextCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}