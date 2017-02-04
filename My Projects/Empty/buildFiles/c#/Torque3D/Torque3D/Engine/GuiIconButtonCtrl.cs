using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiIconButtonCtrl : GuiButtonCtrl
	{
		public GuiIconButtonCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiIconButtonCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiIconButtonCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiIconButtonCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiIconButtonCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiIconButtonCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiIconButtonCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setBitmap(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string buttonFilename);
         private static _setBitmap _setBitmapFunc;
         internal static void setBitmap(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string buttonFilename)
         {
         	if (_setBitmapFunc == null)
         	{
         		_setBitmapFunc =
         			(_setBitmap)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiIconButtonCtrl_setBitmap"), typeof(_setBitmap));
         	}
         
         	 _setBitmapFunc(thisPtr, buttonFilename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiIconButtonCtrl_create();
         private static _GuiIconButtonCtrl_create _GuiIconButtonCtrl_createFunc;
         internal static IntPtr GuiIconButtonCtrl_create()
         {
         	if (_GuiIconButtonCtrl_createFunc == null)
         	{
         		_GuiIconButtonCtrl_createFunc =
         			(_GuiIconButtonCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiIconButtonCtrl_create"), typeof(_GuiIconButtonCtrl_create));
         	}
         
         	return  _GuiIconButtonCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setBitmap(string buttonFilename)
         {
            InternalUnsafeMethods.setBitmap(ObjectPtr, buttonFilename);
         }
      
      
      #endregion


      #region Properties
      
      
         public Point2I ButtonMargin
         {
         	get { return new Point2I(getFieldValue("ButtonMargin")); }
         	set { setFieldValue("ButtonMargin", value.ToString()); }
         }
      
         public string IconBitmap
         {
         	get { return getFieldValue("IconBitmap"); }
         	set { setFieldValue("IconBitmap", value); }
         }
      
         public GuiIconButtonIconLocation IconLocation
         {
         	get { return (GuiIconButtonIconLocation)Enum.Parse(typeof(GuiIconButtonIconLocation), getFieldValue("IconLocation"), true); }
         	set { setFieldValue("IconLocation", value.ToString()); }
         }
      
         public bool SizeIconToButton
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SizeIconToButton")); }
         	set { setFieldValue("SizeIconToButton", value ? "1" : "0"); }
         }
      
         public bool MakeIconSquare
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("MakeIconSquare")); }
         	set { setFieldValue("MakeIconSquare", value ? "1" : "0"); }
         }
      
         public GuiIconButtonTextLocation TextLocation
         {
         	get { return (GuiIconButtonTextLocation)Enum.Parse(typeof(GuiIconButtonTextLocation), getFieldValue("TextLocation"), true); }
         	set { setFieldValue("TextLocation", value.ToString()); }
         }
      
         public int TextMargin
         {
         	get { return int.Parse(getFieldValue("TextMargin")); }
         	set { setFieldValue("TextMargin", value.ToString()); }
         }
      
         public bool AutoSize
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AutoSize")); }
         	set { setFieldValue("AutoSize", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}