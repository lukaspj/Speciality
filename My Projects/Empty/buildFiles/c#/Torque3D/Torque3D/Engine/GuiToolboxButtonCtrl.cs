using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiToolboxButtonCtrl : GuiButtonCtrl
	{
		public GuiToolboxButtonCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiToolboxButtonCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiToolboxButtonCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiToolboxButtonCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiToolboxButtonCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiToolboxButtonCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiToolboxButtonCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setNormalBitmap(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _setNormalBitmap _setNormalBitmapFunc;
         internal static void setNormalBitmap(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_setNormalBitmapFunc == null)
         	{
         		_setNormalBitmapFunc =
         			(_setNormalBitmap)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiToolboxButtonCtrl_setNormalBitmap"), typeof(_setNormalBitmap));
         	}
         
         	 _setNormalBitmapFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setLoweredBitmap(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _setLoweredBitmap _setLoweredBitmapFunc;
         internal static void setLoweredBitmap(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_setLoweredBitmapFunc == null)
         	{
         		_setLoweredBitmapFunc =
         			(_setLoweredBitmap)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiToolboxButtonCtrl_setLoweredBitmap"), typeof(_setLoweredBitmap));
         	}
         
         	 _setLoweredBitmapFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setHoverBitmap(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _setHoverBitmap _setHoverBitmapFunc;
         internal static void setHoverBitmap(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_setHoverBitmapFunc == null)
         	{
         		_setHoverBitmapFunc =
         			(_setHoverBitmap)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiToolboxButtonCtrl_setHoverBitmap"), typeof(_setHoverBitmap));
         	}
         
         	 _setHoverBitmapFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiToolboxButtonCtrl_create();
         private static _GuiToolboxButtonCtrl_create _GuiToolboxButtonCtrl_createFunc;
         internal static IntPtr GuiToolboxButtonCtrl_create()
         {
         	if (_GuiToolboxButtonCtrl_createFunc == null)
         	{
         		_GuiToolboxButtonCtrl_createFunc =
         			(_GuiToolboxButtonCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiToolboxButtonCtrl_create"), typeof(_GuiToolboxButtonCtrl_create));
         	}
         
         	return  _GuiToolboxButtonCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setNormalBitmap(string name)
         {
            InternalUnsafeMethods.setNormalBitmap(ObjectPtr, name);
         }
      
         public virtual void setLoweredBitmap(string name)
         {
            InternalUnsafeMethods.setLoweredBitmap(ObjectPtr, name);
         }
      
         public virtual void setHoverBitmap(string name)
         {
            InternalUnsafeMethods.setHoverBitmap(ObjectPtr, name);
         }
      
      
      #endregion


      #region Properties
      
      
         public string NormalBitmap
         {
         	get { return getFieldValue("NormalBitmap"); }
         	set { setFieldValue("NormalBitmap", value); }
         }
      
         public string LoweredBitmap
         {
         	get { return getFieldValue("LoweredBitmap"); }
         	set { setFieldValue("LoweredBitmap", value); }
         }
      
         public string HoverBitmap
         {
         	get { return getFieldValue("HoverBitmap"); }
         	set { setFieldValue("HoverBitmap", value); }
         }
      
      
      #endregion

	}
}