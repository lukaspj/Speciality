using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiBitmapButtonCtrl : GuiButtonCtrl
	{
		public GuiBitmapButtonCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiBitmapButtonCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiBitmapButtonCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiBitmapButtonCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiBitmapButtonCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiBitmapButtonCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiBitmapButtonCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setBitmap(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string path);
         private static _setBitmap _setBitmapFunc;
         internal static void setBitmap(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string path)
         {
         	if (_setBitmapFunc == null)
         	{
         		_setBitmapFunc =
         			(_setBitmap)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiBitmapButtonCtrl_setBitmap"), typeof(_setBitmap));
         	}
         
         	 _setBitmapFunc(thisPtr, path);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiBitmapButtonCtrl_create();
         private static _GuiBitmapButtonCtrl_create _GuiBitmapButtonCtrl_createFunc;
         internal static IntPtr GuiBitmapButtonCtrl_create()
         {
         	if (_GuiBitmapButtonCtrl_createFunc == null)
         	{
         		_GuiBitmapButtonCtrl_createFunc =
         			(_GuiBitmapButtonCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiBitmapButtonCtrl_create"), typeof(_GuiBitmapButtonCtrl_create));
         	}
         
         	return  _GuiBitmapButtonCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setBitmap(string path)
         {
            InternalUnsafeMethods.setBitmap(ObjectPtr, path);
         }
      
      
      #endregion


      #region Properties
      
      
         public string Bitmap
         {
         	get { return getFieldValue("Bitmap"); }
         	set { setFieldValue("Bitmap", value); }
         }
      
         public GuiBitmapMode BitmapMode
         {
         	get { return (GuiBitmapMode)Enum.Parse(typeof(GuiBitmapMode), getFieldValue("BitmapMode"), true); }
         	set { setFieldValue("BitmapMode", value.ToString()); }
         }
      
         public bool AutoFitExtents
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AutoFitExtents")); }
         	set { setFieldValue("AutoFitExtents", value ? "1" : "0"); }
         }
      
         public bool UseModifiers
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseModifiers")); }
         	set { setFieldValue("UseModifiers", value ? "1" : "0"); }
         }
      
         public bool UseStates
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseStates")); }
         	set { setFieldValue("UseStates", value ? "1" : "0"); }
         }
      
         public bool Masked
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Masked")); }
         	set { setFieldValue("Masked", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}