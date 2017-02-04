using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiConsoleEditCtrl : GuiTextEditCtrl
	{
		public GuiConsoleEditCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiConsoleEditCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiConsoleEditCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiConsoleEditCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiConsoleEditCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiConsoleEditCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiConsoleEditCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiConsoleEditCtrl_create();
         private static _GuiConsoleEditCtrl_create _GuiConsoleEditCtrl_createFunc;
         internal static IntPtr GuiConsoleEditCtrl_create()
         {
         	if (_GuiConsoleEditCtrl_createFunc == null)
         	{
         		_GuiConsoleEditCtrl_createFunc =
         			(_GuiConsoleEditCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiConsoleEditCtrl_create"), typeof(_GuiConsoleEditCtrl_create));
         	}
         
         	return  _GuiConsoleEditCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public bool UseSiblingScroller
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseSiblingScroller")); }
         	set { setFieldValue("UseSiblingScroller", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}