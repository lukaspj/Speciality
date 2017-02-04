using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiGradientSwatchCtrl : GuiSwatchButtonCtrl
	{
		public GuiGradientSwatchCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiGradientSwatchCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiGradientSwatchCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiGradientSwatchCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiGradientSwatchCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiGradientSwatchCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiGradientSwatchCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiGradientSwatchCtrl_create();
         private static _GuiGradientSwatchCtrl_create _GuiGradientSwatchCtrl_createFunc;
         internal static IntPtr GuiGradientSwatchCtrl_create()
         {
         	if (_GuiGradientSwatchCtrl_createFunc == null)
         	{
         		_GuiGradientSwatchCtrl_createFunc =
         			(_GuiGradientSwatchCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiGradientSwatchCtrl_create"), typeof(_GuiGradientSwatchCtrl_create));
         	}
         
         	return  _GuiGradientSwatchCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}