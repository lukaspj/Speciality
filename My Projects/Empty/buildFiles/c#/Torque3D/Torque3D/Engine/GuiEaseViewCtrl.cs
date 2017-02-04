using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiEaseViewCtrl : GuiControl
	{
		public GuiEaseViewCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiEaseViewCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiEaseViewCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiEaseViewCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiEaseViewCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiEaseViewCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiEaseViewCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiEaseViewCtrl_create();
         private static _GuiEaseViewCtrl_create _GuiEaseViewCtrl_createFunc;
         internal static IntPtr GuiEaseViewCtrl_create()
         {
         	if (_GuiEaseViewCtrl_createFunc == null)
         	{
         		_GuiEaseViewCtrl_createFunc =
         			(_GuiEaseViewCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiEaseViewCtrl_create"), typeof(_GuiEaseViewCtrl_create));
         	}
         
         	return  _GuiEaseViewCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public EaseF Ease
         {
         	get { return new EaseF(getFieldValue("Ease")); }
         	set { setFieldValue("Ease", value.ToString()); }
         }
      
         public ColorF EaseColor
         {
         	get { return new ColorF(getFieldValue("EaseColor")); }
         	set { setFieldValue("EaseColor", value.ToString()); }
         }
      
         public float EaseWidth
         {
         	get { return float.Parse(getFieldValue("EaseWidth")); }
         	set { setFieldValue("EaseWidth", value.ToString()); }
         }
      
         public ColorF AxisColor
         {
         	get { return new ColorF(getFieldValue("AxisColor")); }
         	set { setFieldValue("AxisColor", value.ToString()); }
         }
      
      
      #endregion

	}
}