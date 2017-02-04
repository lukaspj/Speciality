using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiBorderButtonCtrl : GuiButtonBaseCtrl
	{
		public GuiBorderButtonCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiBorderButtonCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiBorderButtonCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiBorderButtonCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiBorderButtonCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiBorderButtonCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiBorderButtonCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiBorderButtonCtrl_create();
         private static _GuiBorderButtonCtrl_create _GuiBorderButtonCtrl_createFunc;
         internal static IntPtr GuiBorderButtonCtrl_create()
         {
         	if (_GuiBorderButtonCtrl_createFunc == null)
         	{
         		_GuiBorderButtonCtrl_createFunc =
         			(_GuiBorderButtonCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiBorderButtonCtrl_create"), typeof(_GuiBorderButtonCtrl_create));
         	}
         
         	return  _GuiBorderButtonCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}