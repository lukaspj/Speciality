using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiFilterCtrl : GuiControl
	{
		public GuiFilterCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiFilterCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiFilterCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiFilterCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiFilterCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiFilterCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiFilterCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getValue(IntPtr thisPtr);
         private static _getValue _getValueFunc;
         internal static IntPtr getValue(IntPtr thisPtr)
         {
         	if (_getValueFunc == null)
         	{
         		_getValueFunc =
         			(_getValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFilterCtrl_getValue"), typeof(_getValue));
         	}
         
         	return  _getValueFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setValue(IntPtr thisPtr, int argc, string[] argv);
         private static _setValue _setValueFunc;
         internal static void setValue(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_setValueFunc == null)
         	{
         		_setValueFunc =
         			(_setValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFilterCtrl_setValue"), typeof(_setValue));
         	}
         
         	 _setValueFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _identity(IntPtr thisPtr);
         private static _identity _identityFunc;
         internal static void identity(IntPtr thisPtr)
         {
         	if (_identityFunc == null)
         	{
         		_identityFunc =
         			(_identity)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFilterCtrl_identity"), typeof(_identity));
         	}
         
         	 _identityFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiFilterCtrl_create();
         private static _GuiFilterCtrl_create _GuiFilterCtrl_createFunc;
         internal static IntPtr GuiFilterCtrl_create()
         {
         	if (_GuiFilterCtrl_createFunc == null)
         	{
         		_GuiFilterCtrl_createFunc =
         			(_GuiFilterCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiFilterCtrl_create"), typeof(_GuiFilterCtrl_create));
         	}
         
         	return  _GuiFilterCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual string getValue()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getValue(ObjectPtr));
         }
      
         public virtual void setValue()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.setValue(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void identity()
         {
            InternalUnsafeMethods.identity(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public int ControlPoints
         {
         	get { return int.Parse(getFieldValue("ControlPoints")); }
         	set { setFieldValue("ControlPoints", value.ToString()); }
         }
      
         public string Filter
         {
         	get { return getFieldValue("Filter"); }
         	set { setFieldValue("Filter", value); }
         }
      
         public bool ShowIdentity
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowIdentity")); }
         	set { setFieldValue("ShowIdentity", value ? "1" : "0"); }
         }
      
         public Point2F Identity
         {
         	get { return new Point2F(getFieldValue("Identity")); }
         	set { setFieldValue("Identity", value.ToString()); }
         }
      
      
      #endregion

	}
}