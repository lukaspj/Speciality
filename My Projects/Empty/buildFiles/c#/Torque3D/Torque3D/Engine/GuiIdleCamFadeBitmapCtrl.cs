using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiIdleCamFadeBitmapCtrl : GuiBitmapCtrl
	{
		public GuiIdleCamFadeBitmapCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiIdleCamFadeBitmapCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiIdleCamFadeBitmapCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiIdleCamFadeBitmapCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiIdleCamFadeBitmapCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiIdleCamFadeBitmapCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiIdleCamFadeBitmapCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _fadeIn(IntPtr thisPtr);
         private static _fadeIn _fadeInFunc;
         internal static void fadeIn(IntPtr thisPtr)
         {
         	if (_fadeInFunc == null)
         	{
         		_fadeInFunc =
         			(_fadeIn)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiIdleCamFadeBitmapCtrl_fadeIn"), typeof(_fadeIn));
         	}
         
         	 _fadeInFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _fadeOut(IntPtr thisPtr);
         private static _fadeOut _fadeOutFunc;
         internal static void fadeOut(IntPtr thisPtr)
         {
         	if (_fadeOutFunc == null)
         	{
         		_fadeOutFunc =
         			(_fadeOut)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiIdleCamFadeBitmapCtrl_fadeOut"), typeof(_fadeOut));
         	}
         
         	 _fadeOutFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiIdleCamFadeBitmapCtrl_create();
         private static _GuiIdleCamFadeBitmapCtrl_create _GuiIdleCamFadeBitmapCtrl_createFunc;
         internal static IntPtr GuiIdleCamFadeBitmapCtrl_create()
         {
         	if (_GuiIdleCamFadeBitmapCtrl_createFunc == null)
         	{
         		_GuiIdleCamFadeBitmapCtrl_createFunc =
         			(_GuiIdleCamFadeBitmapCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiIdleCamFadeBitmapCtrl_create"), typeof(_GuiIdleCamFadeBitmapCtrl_create));
         	}
         
         	return  _GuiIdleCamFadeBitmapCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void fadeIn()
         {
            InternalUnsafeMethods.fadeIn(ObjectPtr);
         }
      
         public virtual void fadeOut()
         {
            InternalUnsafeMethods.fadeOut(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public int FadeInTime
         {
         	get { return int.Parse(getFieldValue("FadeInTime")); }
         	set { setFieldValue("FadeInTime", value.ToString()); }
         }
      
         public int FadeOutTime
         {
         	get { return int.Parse(getFieldValue("FadeOutTime")); }
         	set { setFieldValue("FadeOutTime", value.ToString()); }
         }
      
         public bool Done
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Done")); }
         	set { setFieldValue("Done", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}