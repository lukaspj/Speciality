using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiProgressBitmapCtrl : GuiTextCtrl
	{
		public GuiProgressBitmapCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiProgressBitmapCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiProgressBitmapCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiProgressBitmapCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiProgressBitmapCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiProgressBitmapCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiProgressBitmapCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setBitmap(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _setBitmap _setBitmapFunc;
         internal static void setBitmap(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_setBitmapFunc == null)
         	{
         		_setBitmapFunc =
         			(_setBitmap)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiProgressBitmapCtrl_setBitmap"), typeof(_setBitmap));
         	}
         
         	 _setBitmapFunc(thisPtr, filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiProgressBitmapCtrl_create();
         private static _GuiProgressBitmapCtrl_create _GuiProgressBitmapCtrl_createFunc;
         internal static IntPtr GuiProgressBitmapCtrl_create()
         {
         	if (_GuiProgressBitmapCtrl_createFunc == null)
         	{
         		_GuiProgressBitmapCtrl_createFunc =
         			(_GuiProgressBitmapCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiProgressBitmapCtrl_create"), typeof(_GuiProgressBitmapCtrl_create));
         	}
         
         	return  _GuiProgressBitmapCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setBitmap(string filename)
         {
            InternalUnsafeMethods.setBitmap(ObjectPtr, filename);
         }
      
      
      #endregion


      #region Properties
      
      
         public string Bitmap
         {
         	get { return getFieldValue("Bitmap"); }
         	set { setFieldValue("Bitmap", value); }
         }
      
      
      #endregion

	}
}