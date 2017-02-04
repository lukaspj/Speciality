using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiControlArrayControl : GuiControl
	{
		public GuiControlArrayControl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiControlArrayControl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiControlArrayControl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiControlArrayControl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiControlArrayControl(SimObject pObj) : base(pObj)
		{
		}

		public GuiControlArrayControl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiControlArrayControl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiControlArrayControl_create();
         private static _GuiControlArrayControl_create _GuiControlArrayControl_createFunc;
         internal static IntPtr GuiControlArrayControl_create()
         {
         	if (_GuiControlArrayControl_createFunc == null)
         	{
         		_GuiControlArrayControl_createFunc =
         			(_GuiControlArrayControl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiControlArrayControl_create"), typeof(_GuiControlArrayControl_create));
         	}
         
         	return  _GuiControlArrayControl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public int ColCount
         {
         	get { return int.Parse(getFieldValue("ColCount")); }
         	set { setFieldValue("ColCount", value.ToString()); }
         }
      
         public string ColSizes
         {
         	get { return getFieldValue("ColSizes"); }
         	set { setFieldValue("ColSizes", value); }
         }
      
         public int RowSize
         {
         	get { return int.Parse(getFieldValue("RowSize")); }
         	set { setFieldValue("RowSize", value.ToString()); }
         }
      
         public int RowSpacing
         {
         	get { return int.Parse(getFieldValue("RowSpacing")); }
         	set { setFieldValue("RowSpacing", value.ToString()); }
         }
      
         public int ColSpacing
         {
         	get { return int.Parse(getFieldValue("ColSpacing")); }
         	set { setFieldValue("ColSpacing", value.ToString()); }
         }
      
      
      #endregion

	}
}