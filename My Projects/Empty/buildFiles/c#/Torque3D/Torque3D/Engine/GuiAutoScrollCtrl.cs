using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiAutoScrollCtrl : GuiTickCtrl
	{
		public GuiAutoScrollCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiAutoScrollCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiAutoScrollCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiAutoScrollCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiAutoScrollCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiAutoScrollCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiAutoScrollCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _reset(IntPtr thisPtr);
         private static _reset _resetFunc;
         internal static void reset(IntPtr thisPtr)
         {
         	if (_resetFunc == null)
         	{
         		_resetFunc =
         			(_reset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiAutoScrollCtrl_reset"), typeof(_reset));
         	}
         
         	 _resetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiAutoScrollCtrl_create();
         private static _GuiAutoScrollCtrl_create _GuiAutoScrollCtrl_createFunc;
         internal static IntPtr GuiAutoScrollCtrl_create()
         {
         	if (_GuiAutoScrollCtrl_createFunc == null)
         	{
         		_GuiAutoScrollCtrl_createFunc =
         			(_GuiAutoScrollCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiAutoScrollCtrl_create"), typeof(_GuiAutoScrollCtrl_create));
         	}
         
         	return  _GuiAutoScrollCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void reset()
         {
            InternalUnsafeMethods.reset(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public GuiAutoScrollDirection ScrollDirection
         {
         	get { return (GuiAutoScrollDirection)Enum.Parse(typeof(GuiAutoScrollDirection), getFieldValue("ScrollDirection"), true); }
         	set { setFieldValue("ScrollDirection", value.ToString()); }
         }
      
         public float StartDelay
         {
         	get { return float.Parse(getFieldValue("StartDelay")); }
         	set { setFieldValue("StartDelay", value.ToString()); }
         }
      
         public float ResetDelay
         {
         	get { return float.Parse(getFieldValue("ResetDelay")); }
         	set { setFieldValue("ResetDelay", value.ToString()); }
         }
      
         public int ChildBorder
         {
         	get { return int.Parse(getFieldValue("ChildBorder")); }
         	set { setFieldValue("ChildBorder", value.ToString()); }
         }
      
         public float ScrollSpeed
         {
         	get { return float.Parse(getFieldValue("ScrollSpeed")); }
         	set { setFieldValue("ScrollSpeed", value.ToString()); }
         }
      
         public bool IsLooping
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsLooping")); }
         	set { setFieldValue("IsLooping", value ? "1" : "0"); }
         }
      
         public bool ScrollOutOfSight
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ScrollOutOfSight")); }
         	set { setFieldValue("ScrollOutOfSight", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}