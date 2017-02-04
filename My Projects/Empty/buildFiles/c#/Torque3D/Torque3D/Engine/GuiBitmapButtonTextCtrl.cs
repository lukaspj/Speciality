using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiBitmapButtonTextCtrl : GuiBitmapButtonCtrl
	{
		public GuiBitmapButtonTextCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiBitmapButtonTextCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiBitmapButtonTextCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiBitmapButtonTextCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiBitmapButtonTextCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiBitmapButtonTextCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiBitmapButtonTextCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiBitmapButtonTextCtrl_create();
         private static _GuiBitmapButtonTextCtrl_create _GuiBitmapButtonTextCtrl_createFunc;
         internal static IntPtr GuiBitmapButtonTextCtrl_create()
         {
         	if (_GuiBitmapButtonTextCtrl_createFunc == null)
         	{
         		_GuiBitmapButtonTextCtrl_createFunc =
         			(_GuiBitmapButtonTextCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiBitmapButtonTextCtrl_create"), typeof(_GuiBitmapButtonTextCtrl_create));
         	}
         
         	return  _GuiBitmapButtonTextCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}