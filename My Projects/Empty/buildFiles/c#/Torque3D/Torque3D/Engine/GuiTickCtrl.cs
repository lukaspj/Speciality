using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiTickCtrl : GuiControl
	{
		public GuiTickCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiTickCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiTickCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiTickCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiTickCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiTickCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiTickCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setProcessTicks(IntPtr thisPtr, bool tick);
         private static _setProcessTicks _setProcessTicksFunc;
         internal static void setProcessTicks(IntPtr thisPtr, bool tick)
         {
         	if (_setProcessTicksFunc == null)
         	{
         		_setProcessTicksFunc =
         			(_setProcessTicks)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTickCtrl_setProcessTicks"), typeof(_setProcessTicks));
         	}
         
         	 _setProcessTicksFunc(thisPtr, tick);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTickCtrl_create();
         private static _GuiTickCtrl_create _GuiTickCtrl_createFunc;
         internal static IntPtr GuiTickCtrl_create()
         {
         	if (_GuiTickCtrl_createFunc == null)
         	{
         		_GuiTickCtrl_createFunc =
         			(_GuiTickCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiTickCtrl_create"), typeof(_GuiTickCtrl_create));
         	}
         
         	return  _GuiTickCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setProcessTicks(bool tick = true)
         {
            InternalUnsafeMethods.setProcessTicks(ObjectPtr, tick);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}