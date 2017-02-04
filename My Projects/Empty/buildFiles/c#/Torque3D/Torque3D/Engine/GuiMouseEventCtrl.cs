using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiMouseEventCtrl : GuiControl
	{
		public GuiMouseEventCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiMouseEventCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiMouseEventCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiMouseEventCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiMouseEventCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiMouseEventCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiMouseEventCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiMouseEventCtrl_create();
         private static _GuiMouseEventCtrl_create _GuiMouseEventCtrl_createFunc;
         internal static IntPtr GuiMouseEventCtrl_create()
         {
         	if (_GuiMouseEventCtrl_createFunc == null)
         	{
         		_GuiMouseEventCtrl_createFunc =
         			(_GuiMouseEventCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiMouseEventCtrl_create"), typeof(_GuiMouseEventCtrl_create));
         	}
         
         	return  _GuiMouseEventCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public bool LockMouse
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("LockMouse")); }
         	set { setFieldValue("LockMouse", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}