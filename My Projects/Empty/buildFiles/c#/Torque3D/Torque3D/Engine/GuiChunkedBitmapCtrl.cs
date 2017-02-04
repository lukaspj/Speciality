using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiChunkedBitmapCtrl : GuiControl
	{
		public GuiChunkedBitmapCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiChunkedBitmapCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiChunkedBitmapCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiChunkedBitmapCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiChunkedBitmapCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiChunkedBitmapCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiChunkedBitmapCtrl_create();
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
         				"fnGuiChunkedBitmapCtrl_setBitmap"), typeof(_setBitmap));
         	}
         
         	 _setBitmapFunc(thisPtr, filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiChunkedBitmapCtrl_create();
         private static _GuiChunkedBitmapCtrl_create _GuiChunkedBitmapCtrl_createFunc;
         internal static IntPtr GuiChunkedBitmapCtrl_create()
         {
         	if (_GuiChunkedBitmapCtrl_createFunc == null)
         	{
         		_GuiChunkedBitmapCtrl_createFunc =
         			(_GuiChunkedBitmapCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiChunkedBitmapCtrl_create"), typeof(_GuiChunkedBitmapCtrl_create));
         	}
         
         	return  _GuiChunkedBitmapCtrl_createFunc();
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
      
         public bool UseVariable
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseVariable")); }
         	set { setFieldValue("UseVariable", value ? "1" : "0"); }
         }
      
         public bool Tile
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Tile")); }
         	set { setFieldValue("Tile", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}