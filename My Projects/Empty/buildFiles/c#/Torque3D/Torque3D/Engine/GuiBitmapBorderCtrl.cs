using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiBitmapBorderCtrl : GuiControl
	{
		public GuiBitmapBorderCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiBitmapBorderCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiBitmapBorderCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiBitmapBorderCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiBitmapBorderCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiBitmapBorderCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiBitmapBorderCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiBitmapBorderCtrl_create();
         private static _GuiBitmapBorderCtrl_create _GuiBitmapBorderCtrl_createFunc;
         internal static IntPtr GuiBitmapBorderCtrl_create()
         {
         	if (_GuiBitmapBorderCtrl_createFunc == null)
         	{
         		_GuiBitmapBorderCtrl_createFunc =
         			(_GuiBitmapBorderCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiBitmapBorderCtrl_create"), typeof(_GuiBitmapBorderCtrl_create));
         	}
         
         	return  _GuiBitmapBorderCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}