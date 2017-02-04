using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiTextCtrl : GuiContainer
	{
		public GuiTextCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiTextCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiTextCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiTextCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiTextCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiTextCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiTextCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setText(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string text);
         private static _setText _setTextFunc;
         internal static void setText(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string text)
         {
         	if (_setTextFunc == null)
         	{
         		_setTextFunc =
         			(_setText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextCtrl_setText"), typeof(_setText));
         	}
         
         	 _setTextFunc(thisPtr, text);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setTextID(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string textID);
         private static _setTextID _setTextIDFunc;
         internal static void setTextID(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string textID)
         {
         	if (_setTextIDFunc == null)
         	{
         		_setTextIDFunc =
         			(_setTextID)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTextCtrl_setTextID"), typeof(_setTextID));
         	}
         
         	 _setTextIDFunc(thisPtr, textID);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTextCtrl_create();
         private static _GuiTextCtrl_create _GuiTextCtrl_createFunc;
         internal static IntPtr GuiTextCtrl_create()
         {
         	if (_GuiTextCtrl_createFunc == null)
         	{
         		_GuiTextCtrl_createFunc =
         			(_GuiTextCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiTextCtrl_create"), typeof(_GuiTextCtrl_create));
         	}
         
         	return  _GuiTextCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setText(string text)
         {
            InternalUnsafeMethods.setText(ObjectPtr, text);
         }
      
         public virtual void setTextID(string textID)
         {
            InternalUnsafeMethods.setTextID(ObjectPtr, textID);
         }
      
      
      #endregion


      #region Properties
      
      
         public string Text
         {
         	get { return getFieldValue("Text"); }
         	set { setFieldValue("Text", value); }
         }
      
         public string TextID
         {
         	get { return getFieldValue("TextID"); }
         	set { setFieldValue("TextID", value); }
         }
      
         public int MaxLength
         {
         	get { return int.Parse(getFieldValue("MaxLength")); }
         	set { setFieldValue("MaxLength", value.ToString()); }
         }
      
      
      #endregion

	}
}