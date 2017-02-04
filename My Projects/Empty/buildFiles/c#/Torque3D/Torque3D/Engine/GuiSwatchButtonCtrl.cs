using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiSwatchButtonCtrl : GuiButtonBaseCtrl
	{
		public GuiSwatchButtonCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiSwatchButtonCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiSwatchButtonCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiSwatchButtonCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiSwatchButtonCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiSwatchButtonCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiSwatchButtonCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setColor(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newColor);
         private static _setColor _setColorFunc;
         internal static void setColor(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newColor)
         {
         	if (_setColorFunc == null)
         	{
         		_setColorFunc =
         			(_setColor)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiSwatchButtonCtrl_setColor"), typeof(_setColor));
         	}
         
         	 _setColorFunc(thisPtr, newColor);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiSwatchButtonCtrl_create();
         private static _GuiSwatchButtonCtrl_create _GuiSwatchButtonCtrl_createFunc;
         internal static IntPtr GuiSwatchButtonCtrl_create()
         {
         	if (_GuiSwatchButtonCtrl_createFunc == null)
         	{
         		_GuiSwatchButtonCtrl_createFunc =
         			(_GuiSwatchButtonCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiSwatchButtonCtrl_create"), typeof(_GuiSwatchButtonCtrl_create));
         	}
         
         	return  _GuiSwatchButtonCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setColor(string newColor)
         {
            InternalUnsafeMethods.setColor(ObjectPtr, newColor);
         }
      
      
      #endregion


      #region Properties
      
      
         public ColorF Color
         {
         	get { return new ColorF(getFieldValue("Color")); }
         	set { setFieldValue("Color", value.ToString()); }
         }
      
         public string GridBitmap
         {
         	get { return getFieldValue("GridBitmap"); }
         	set { setFieldValue("GridBitmap", value); }
         }
      
      
      #endregion

	}
}