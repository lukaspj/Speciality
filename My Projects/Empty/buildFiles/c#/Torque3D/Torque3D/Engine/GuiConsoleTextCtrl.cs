using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiConsoleTextCtrl : GuiControl
	{
		public GuiConsoleTextCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiConsoleTextCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiConsoleTextCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiConsoleTextCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiConsoleTextCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiConsoleTextCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiConsoleTextCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiConsoleTextCtrl_create();
         private static _GuiConsoleTextCtrl_create _GuiConsoleTextCtrl_createFunc;
         internal static IntPtr GuiConsoleTextCtrl_create()
         {
         	if (_GuiConsoleTextCtrl_createFunc == null)
         	{
         		_GuiConsoleTextCtrl_createFunc =
         			(_GuiConsoleTextCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiConsoleTextCtrl_create"), typeof(_GuiConsoleTextCtrl_create));
         	}
         
         	return  _GuiConsoleTextCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string Expression
         {
         	get { return getFieldValue("Expression"); }
         	set { setFieldValue("Expression", value); }
         }
      
      
      #endregion

	}
}