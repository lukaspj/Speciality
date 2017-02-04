using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiDecoyCtrl : GuiControl
	{
		public GuiDecoyCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiDecoyCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiDecoyCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiDecoyCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiDecoyCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiDecoyCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiDecoyCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiDecoyCtrl_create();
         private static _GuiDecoyCtrl_create _GuiDecoyCtrl_createFunc;
         internal static IntPtr GuiDecoyCtrl_create()
         {
         	if (_GuiDecoyCtrl_createFunc == null)
         	{
         		_GuiDecoyCtrl_createFunc =
         			(_GuiDecoyCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiDecoyCtrl_create"), typeof(_GuiDecoyCtrl_create));
         	}
         
         	return  _GuiDecoyCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public bool IsDecoy
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsDecoy")); }
         	set { setFieldValue("IsDecoy", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}