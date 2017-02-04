using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiFormCtrl : GuiPanel
	{
		public GuiFormCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiFormCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiFormCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiFormCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiFormCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiFormCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiFormCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getMenuID(IntPtr thisPtr);
         private static _getMenuID _getMenuIDFunc;
         internal static int getMenuID(IntPtr thisPtr)
         {
         	if (_getMenuIDFunc == null)
         	{
         		_getMenuIDFunc =
         			(_getMenuID)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFormCtrl_getMenuID"), typeof(_getMenuID));
         	}
         
         	return  _getMenuIDFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setCaption(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string caption);
         private static _setCaption _setCaptionFunc;
         internal static void setCaption(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string caption)
         {
         	if (_setCaptionFunc == null)
         	{
         		_setCaptionFunc =
         			(_setCaption)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFormCtrl_setCaption"), typeof(_setCaption));
         	}
         
         	 _setCaptionFunc(thisPtr, caption);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiFormCtrl_create();
         private static _GuiFormCtrl_create _GuiFormCtrl_createFunc;
         internal static IntPtr GuiFormCtrl_create()
         {
         	if (_GuiFormCtrl_createFunc == null)
         	{
         		_GuiFormCtrl_createFunc =
         			(_GuiFormCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiFormCtrl_create"), typeof(_GuiFormCtrl_create));
         	}
         
         	return  _GuiFormCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int getMenuID()
         {
            return InternalUnsafeMethods.getMenuID(ObjectPtr);
         }
      
         public virtual void setCaption(string caption)
         {
            InternalUnsafeMethods.setCaption(ObjectPtr, caption);
         }
      
      
      #endregion


      #region Properties
      
      
         public string Caption
         {
         	get { return getFieldValue("Caption"); }
         	set { setFieldValue("Caption", value); }
         }
      
         public string ContentLibrary
         {
         	get { return getFieldValue("ContentLibrary"); }
         	set { setFieldValue("ContentLibrary", value); }
         }
      
         public string Content
         {
         	get { return getFieldValue("Content"); }
         	set { setFieldValue("Content", value); }
         }
      
         public bool Movable
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Movable")); }
         	set { setFieldValue("Movable", value ? "1" : "0"); }
         }
      
         public bool HasMenu
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("HasMenu")); }
         	set { setFieldValue("HasMenu", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}