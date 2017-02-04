using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiRolloutCtrl : GuiControl
	{
		public GuiRolloutCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiRolloutCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiRolloutCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiRolloutCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiRolloutCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiRolloutCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiRolloutCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isExpanded(IntPtr thisPtr);
         private static _isExpanded _isExpandedFunc;
         internal static bool isExpanded(IntPtr thisPtr)
         {
         	if (_isExpandedFunc == null)
         	{
         		_isExpandedFunc =
         			(_isExpanded)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiRolloutCtrl_isExpanded"), typeof(_isExpanded));
         	}
         
         	return  _isExpandedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _collapse(IntPtr thisPtr);
         private static _collapse _collapseFunc;
         internal static void collapse(IntPtr thisPtr)
         {
         	if (_collapseFunc == null)
         	{
         		_collapseFunc =
         			(_collapse)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiRolloutCtrl_collapse"), typeof(_collapse));
         	}
         
         	 _collapseFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _expand(IntPtr thisPtr);
         private static _expand _expandFunc;
         internal static void expand(IntPtr thisPtr)
         {
         	if (_expandFunc == null)
         	{
         		_expandFunc =
         			(_expand)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiRolloutCtrl_expand"), typeof(_expand));
         	}
         
         	 _expandFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _toggleCollapse(IntPtr thisPtr);
         private static _toggleCollapse _toggleCollapseFunc;
         internal static void toggleCollapse(IntPtr thisPtr)
         {
         	if (_toggleCollapseFunc == null)
         	{
         		_toggleCollapseFunc =
         			(_toggleCollapse)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiRolloutCtrl_toggleCollapse"), typeof(_toggleCollapse));
         	}
         
         	 _toggleCollapseFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _toggleExpanded(IntPtr thisPtr, bool instantly);
         private static _toggleExpanded _toggleExpandedFunc;
         internal static void toggleExpanded(IntPtr thisPtr, bool instantly)
         {
         	if (_toggleExpandedFunc == null)
         	{
         		_toggleExpandedFunc =
         			(_toggleExpanded)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiRolloutCtrl_toggleExpanded"), typeof(_toggleExpanded));
         	}
         
         	 _toggleExpandedFunc(thisPtr, instantly);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _instantCollapse(IntPtr thisPtr);
         private static _instantCollapse _instantCollapseFunc;
         internal static void instantCollapse(IntPtr thisPtr)
         {
         	if (_instantCollapseFunc == null)
         	{
         		_instantCollapseFunc =
         			(_instantCollapse)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiRolloutCtrl_instantCollapse"), typeof(_instantCollapse));
         	}
         
         	 _instantCollapseFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _instantExpand(IntPtr thisPtr);
         private static _instantExpand _instantExpandFunc;
         internal static void instantExpand(IntPtr thisPtr)
         {
         	if (_instantExpandFunc == null)
         	{
         		_instantExpandFunc =
         			(_instantExpand)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiRolloutCtrl_instantExpand"), typeof(_instantExpand));
         	}
         
         	 _instantExpandFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sizeToContents(IntPtr thisPtr);
         private static _sizeToContents _sizeToContentsFunc;
         internal static void sizeToContents(IntPtr thisPtr)
         {
         	if (_sizeToContentsFunc == null)
         	{
         		_sizeToContentsFunc =
         			(_sizeToContents)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiRolloutCtrl_sizeToContents"), typeof(_sizeToContents));
         	}
         
         	 _sizeToContentsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiRolloutCtrl_create();
         private static _GuiRolloutCtrl_create _GuiRolloutCtrl_createFunc;
         internal static IntPtr GuiRolloutCtrl_create()
         {
         	if (_GuiRolloutCtrl_createFunc == null)
         	{
         		_GuiRolloutCtrl_createFunc =
         			(_GuiRolloutCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiRolloutCtrl_create"), typeof(_GuiRolloutCtrl_create));
         	}
         
         	return  _GuiRolloutCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool isExpanded()
         {
            return InternalUnsafeMethods.isExpanded(ObjectPtr);
         }
      
         public virtual void collapse()
         {
            InternalUnsafeMethods.collapse(ObjectPtr);
         }
      
         public virtual void expand()
         {
            InternalUnsafeMethods.expand(ObjectPtr);
         }
      
         public virtual void toggleCollapse()
         {
            InternalUnsafeMethods.toggleCollapse(ObjectPtr);
         }
      
         public virtual void toggleExpanded(bool instantly = false)
         {
            InternalUnsafeMethods.toggleExpanded(ObjectPtr, instantly);
         }
      
         public virtual void instantCollapse()
         {
            InternalUnsafeMethods.instantCollapse(ObjectPtr);
         }
      
         public virtual void instantExpand()
         {
            InternalUnsafeMethods.instantExpand(ObjectPtr);
         }
      
         public virtual void sizeToContents()
         {
            InternalUnsafeMethods.sizeToContents(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public string Caption
         {
         	get { return getFieldValue("Caption"); }
         	set { setFieldValue("Caption", value); }
         }
      
         public RectI Margin
         {
         	get { return new RectI(getFieldValue("Margin")); }
         	set { setFieldValue("Margin", value.ToString()); }
         }
      
         public int DefaultHeight
         {
         	get { return int.Parse(getFieldValue("DefaultHeight")); }
         	set { setFieldValue("DefaultHeight", value.ToString()); }
         }
      
         public bool Expanded
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Expanded")); }
         	set { setFieldValue("Expanded", value ? "1" : "0"); }
         }
      
         public bool ClickCollapse
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ClickCollapse")); }
         	set { setFieldValue("ClickCollapse", value ? "1" : "0"); }
         }
      
         public bool HideHeader
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("HideHeader")); }
         	set { setFieldValue("HideHeader", value ? "1" : "0"); }
         }
      
         public bool AutoCollapseSiblings
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AutoCollapseSiblings")); }
         	set { setFieldValue("AutoCollapseSiblings", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}