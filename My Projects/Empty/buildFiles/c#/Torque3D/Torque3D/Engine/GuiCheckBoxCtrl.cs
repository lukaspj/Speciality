using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiCheckBoxCtrl : GuiButtonBaseCtrl
	{
		public GuiCheckBoxCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiCheckBoxCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiCheckBoxCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiCheckBoxCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiCheckBoxCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiCheckBoxCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiCheckBoxCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setStateOn(IntPtr thisPtr, bool newState);
         private static _setStateOn _setStateOnFunc;
         internal static void setStateOn(IntPtr thisPtr, bool newState)
         {
         	if (_setStateOnFunc == null)
         	{
         		_setStateOnFunc =
         			(_setStateOn)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCheckBoxCtrl_setStateOn"), typeof(_setStateOn));
         	}
         
         	 _setStateOnFunc(thisPtr, newState);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isStateOn(IntPtr thisPtr);
         private static _isStateOn _isStateOnFunc;
         internal static bool isStateOn(IntPtr thisPtr)
         {
         	if (_isStateOnFunc == null)
         	{
         		_isStateOnFunc =
         			(_isStateOn)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCheckBoxCtrl_isStateOn"), typeof(_isStateOn));
         	}
         
         	return  _isStateOnFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiCheckBoxCtrl_create();
         private static _GuiCheckBoxCtrl_create _GuiCheckBoxCtrl_createFunc;
         internal static IntPtr GuiCheckBoxCtrl_create()
         {
         	if (_GuiCheckBoxCtrl_createFunc == null)
         	{
         		_GuiCheckBoxCtrl_createFunc =
         			(_GuiCheckBoxCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiCheckBoxCtrl_create"), typeof(_GuiCheckBoxCtrl_create));
         	}
         
         	return  _GuiCheckBoxCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setStateOn(bool newState)
         {
            InternalUnsafeMethods.setStateOn(ObjectPtr, newState);
         }
      
         public virtual bool isStateOn()
         {
            return InternalUnsafeMethods.isStateOn(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}