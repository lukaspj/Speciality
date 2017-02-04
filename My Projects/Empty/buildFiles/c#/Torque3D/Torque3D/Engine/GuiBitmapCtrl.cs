using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiBitmapCtrl : GuiControl
	{
		public GuiBitmapCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiBitmapCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiBitmapCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiBitmapCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiBitmapCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiBitmapCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiBitmapCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setValue(IntPtr thisPtr, int x, int y);
         private static _setValue _setValueFunc;
         internal static void setValue(IntPtr thisPtr, int x, int y)
         {
         	if (_setValueFunc == null)
         	{
         		_setValueFunc =
         			(_setValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiBitmapCtrl_setValue"), typeof(_setValue));
         	}
         
         	 _setValueFunc(thisPtr, x, y);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setBitmap(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fileRoot, bool resize);
         private static _setBitmap _setBitmapFunc;
         internal static void setBitmap(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fileRoot, bool resize)
         {
         	if (_setBitmapFunc == null)
         	{
         		_setBitmapFunc =
         			(_setBitmap)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiBitmapCtrl_setBitmap"), typeof(_setBitmap));
         	}
         
         	 _setBitmapFunc(thisPtr, fileRoot, resize);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setNamedTexture(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string namedtexture);
         private static _setNamedTexture _setNamedTextureFunc;
         internal static bool setNamedTexture(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string namedtexture)
         {
         	if (_setNamedTextureFunc == null)
         	{
         		_setNamedTextureFunc =
         			(_setNamedTexture)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiBitmapCtrl_setNamedTexture"), typeof(_setNamedTexture));
         	}
         
         	return  _setNamedTextureFunc(thisPtr, namedtexture);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiBitmapCtrl_create();
         private static _GuiBitmapCtrl_create _GuiBitmapCtrl_createFunc;
         internal static IntPtr GuiBitmapCtrl_create()
         {
         	if (_GuiBitmapCtrl_createFunc == null)
         	{
         		_GuiBitmapCtrl_createFunc =
         			(_GuiBitmapCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiBitmapCtrl_create"), typeof(_GuiBitmapCtrl_create));
         	}
         
         	return  _GuiBitmapCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setValue(int x, int y)
         {
            InternalUnsafeMethods.setValue(ObjectPtr, x, y);
         }
      
         public virtual void setBitmap(string fileRoot, bool resize = false)
         {
            InternalUnsafeMethods.setBitmap(ObjectPtr, fileRoot, resize);
         }
      
         public virtual bool setNamedTexture(string namedtexture)
         {
            return InternalUnsafeMethods.setNamedTexture(ObjectPtr, namedtexture);
         }
      
      
      #endregion


      #region Properties
      
      
         public string Bitmap
         {
         	get { return getFieldValue("Bitmap"); }
         	set { setFieldValue("Bitmap", value); }
         }
      
         public ColorI Color
         {
         	get { return new ColorI(getFieldValue("Color")); }
         	set { setFieldValue("Color", value.ToString()); }
         }
      
         public bool Wrap
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Wrap")); }
         	set { setFieldValue("Wrap", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}