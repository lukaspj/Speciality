using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiDynamicCtrlArrayControl : GuiControl
	{
		public GuiDynamicCtrlArrayControl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiDynamicCtrlArrayControl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiDynamicCtrlArrayControl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiDynamicCtrlArrayControl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiDynamicCtrlArrayControl(SimObject pObj) : base(pObj)
		{
		}

		public GuiDynamicCtrlArrayControl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiDynamicCtrlArrayControl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _refresh(IntPtr thisPtr);
         private static _refresh _refreshFunc;
         internal static void refresh(IntPtr thisPtr)
         {
         	if (_refreshFunc == null)
         	{
         		_refreshFunc =
         			(_refresh)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiDynamicCtrlArrayControl_refresh"), typeof(_refresh));
         	}
         
         	 _refreshFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiDynamicCtrlArrayControl_create();
         private static _GuiDynamicCtrlArrayControl_create _GuiDynamicCtrlArrayControl_createFunc;
         internal static IntPtr GuiDynamicCtrlArrayControl_create()
         {
         	if (_GuiDynamicCtrlArrayControl_createFunc == null)
         	{
         		_GuiDynamicCtrlArrayControl_createFunc =
         			(_GuiDynamicCtrlArrayControl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiDynamicCtrlArrayControl_create"), typeof(_GuiDynamicCtrlArrayControl_create));
         	}
         
         	return  _GuiDynamicCtrlArrayControl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void refresh()
         {
            InternalUnsafeMethods.refresh(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public int ColCount
         {
         	get { return int.Parse(getFieldValue("ColCount")); }
         	set { setFieldValue("ColCount", value.ToString()); }
         }
      
         public int ColSize
         {
         	get { return int.Parse(getFieldValue("ColSize")); }
         	set { setFieldValue("ColSize", value.ToString()); }
         }
      
         public int RowCount
         {
         	get { return int.Parse(getFieldValue("RowCount")); }
         	set { setFieldValue("RowCount", value.ToString()); }
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
      
         public bool Frozen
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Frozen")); }
         	set { setFieldValue("Frozen", value ? "1" : "0"); }
         }
      
         public bool AutoCellSize
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AutoCellSize")); }
         	set { setFieldValue("AutoCellSize", value ? "1" : "0"); }
         }
      
         public bool FillRowFirst
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FillRowFirst")); }
         	set { setFieldValue("FillRowFirst", value ? "1" : "0"); }
         }
      
         public bool DynamicSize
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("DynamicSize")); }
         	set { setFieldValue("DynamicSize", value ? "1" : "0"); }
         }
      
         public RectSpacingI Padding
         {
         	get { return new RectSpacingI(getFieldValue("Padding")); }
         	set { setFieldValue("Padding", value.ToString()); }
         }
      
      
      #endregion

	}
}