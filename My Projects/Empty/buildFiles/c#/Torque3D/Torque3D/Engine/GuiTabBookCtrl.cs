using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiTabBookCtrl : GuiContainer
	{
		public GuiTabBookCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiTabBookCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiTabBookCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiTabBookCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiTabBookCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiTabBookCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiTabBookCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addPage(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string title);
         private static _addPage _addPageFunc;
         internal static void addPage(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string title)
         {
         	if (_addPageFunc == null)
         	{
         		_addPageFunc =
         			(_addPage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTabBookCtrl_addPage"), typeof(_addPage));
         	}
         
         	 _addPageFunc(thisPtr, title);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _selectPage(IntPtr thisPtr, int index);
         private static _selectPage _selectPageFunc;
         internal static void selectPage(IntPtr thisPtr, int index)
         {
         	if (_selectPageFunc == null)
         	{
         		_selectPageFunc =
         			(_selectPage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTabBookCtrl_selectPage"), typeof(_selectPage));
         	}
         
         	 _selectPageFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSelectedPage(IntPtr thisPtr);
         private static _getSelectedPage _getSelectedPageFunc;
         internal static int getSelectedPage(IntPtr thisPtr)
         {
         	if (_getSelectedPageFunc == null)
         	{
         		_getSelectedPageFunc =
         			(_getSelectedPage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTabBookCtrl_getSelectedPage"), typeof(_getSelectedPage));
         	}
         
         	return  _getSelectedPageFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTabBookCtrl_create();
         private static _GuiTabBookCtrl_create _GuiTabBookCtrl_createFunc;
         internal static IntPtr GuiTabBookCtrl_create()
         {
         	if (_GuiTabBookCtrl_createFunc == null)
         	{
         		_GuiTabBookCtrl_createFunc =
         			(_GuiTabBookCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiTabBookCtrl_create"), typeof(_GuiTabBookCtrl_create));
         	}
         
         	return  _GuiTabBookCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void addPage(string title = "")
         {
            InternalUnsafeMethods.addPage(ObjectPtr, title);
         }
      
         public virtual void selectPage(int index)
         {
            InternalUnsafeMethods.selectPage(ObjectPtr, index);
         }
      
         public virtual int getSelectedPage()
         {
            return InternalUnsafeMethods.getSelectedPage(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public GuiTabPosition TabPosition
         {
         	get { return (GuiTabPosition)Enum.Parse(typeof(GuiTabPosition), getFieldValue("TabPosition"), true); }
         	set { setFieldValue("TabPosition", value.ToString()); }
         }
      
         public int TabMargin
         {
         	get { return int.Parse(getFieldValue("TabMargin")); }
         	set { setFieldValue("TabMargin", value.ToString()); }
         }
      
         public int MinTabWidth
         {
         	get { return int.Parse(getFieldValue("MinTabWidth")); }
         	set { setFieldValue("MinTabWidth", value.ToString()); }
         }
      
         public int TabHeight
         {
         	get { return int.Parse(getFieldValue("TabHeight")); }
         	set { setFieldValue("TabHeight", value.ToString()); }
         }
      
         public bool AllowReorder
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowReorder")); }
         	set { setFieldValue("AllowReorder", value ? "1" : "0"); }
         }
      
         public int DefaultPage
         {
         	get { return int.Parse(getFieldValue("DefaultPage")); }
         	set { setFieldValue("DefaultPage", value.ToString()); }
         }
      
         public int SelectedPage
         {
         	get { return int.Parse(getFieldValue("SelectedPage")); }
         	set { setFieldValue("SelectedPage", value.ToString()); }
         }
      
         public int FrontTabPadding
         {
         	get { return int.Parse(getFieldValue("FrontTabPadding")); }
         	set { setFieldValue("FrontTabPadding", value.ToString()); }
         }
      
      
      #endregion

	}
}