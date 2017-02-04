using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiStackControl : GuiControl
	{
		public GuiStackControl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiStackControl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiStackControl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiStackControl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiStackControl(SimObject pObj) : base(pObj)
		{
		}

		public GuiStackControl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiStackControl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isFrozen(IntPtr thisPtr);
         private static _isFrozen _isFrozenFunc;
         internal static bool isFrozen(IntPtr thisPtr)
         {
         	if (_isFrozenFunc == null)
         	{
         		_isFrozenFunc =
         			(_isFrozen)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiStackControl_isFrozen"), typeof(_isFrozen));
         	}
         
         	return  _isFrozenFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _freeze(IntPtr thisPtr, bool freeze);
         private static _freeze _freezeFunc;
         internal static void freeze(IntPtr thisPtr, bool freeze)
         {
         	if (_freezeFunc == null)
         	{
         		_freezeFunc =
         			(_freeze)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiStackControl_freeze"), typeof(_freeze));
         	}
         
         	 _freezeFunc(thisPtr, freeze);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _updateStack(IntPtr thisPtr);
         private static _updateStack _updateStackFunc;
         internal static void updateStack(IntPtr thisPtr)
         {
         	if (_updateStackFunc == null)
         	{
         		_updateStackFunc =
         			(_updateStack)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiStackControl_updateStack"), typeof(_updateStack));
         	}
         
         	 _updateStackFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiStackControl_create();
         private static _GuiStackControl_create _GuiStackControl_createFunc;
         internal static IntPtr GuiStackControl_create()
         {
         	if (_GuiStackControl_createFunc == null)
         	{
         		_GuiStackControl_createFunc =
         			(_GuiStackControl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiStackControl_create"), typeof(_GuiStackControl_create));
         	}
         
         	return  _GuiStackControl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool isFrozen()
         {
            return InternalUnsafeMethods.isFrozen(ObjectPtr);
         }
      
         public virtual void freeze(bool freeze)
         {
            InternalUnsafeMethods.freeze(ObjectPtr, freeze);
         }
      
         public virtual void updateStack()
         {
            InternalUnsafeMethods.updateStack(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public GuiStackingType StackingType
         {
         	get { return (GuiStackingType)Enum.Parse(typeof(GuiStackingType), getFieldValue("StackingType"), true); }
         	set { setFieldValue("StackingType", value.ToString()); }
         }
      
         public GuiHorizontalStackingType HorizStacking
         {
         	get { return (GuiHorizontalStackingType)Enum.Parse(typeof(GuiHorizontalStackingType), getFieldValue("HorizStacking"), true); }
         	set { setFieldValue("HorizStacking", value.ToString()); }
         }
      
         public GuiVerticalStackingType VertStacking
         {
         	get { return (GuiVerticalStackingType)Enum.Parse(typeof(GuiVerticalStackingType), getFieldValue("VertStacking"), true); }
         	set { setFieldValue("VertStacking", value.ToString()); }
         }
      
         public int Padding
         {
         	get { return int.Parse(getFieldValue("Padding")); }
         	set { setFieldValue("Padding", value.ToString()); }
         }
      
         public bool DynamicSize
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("DynamicSize")); }
         	set { setFieldValue("DynamicSize", value ? "1" : "0"); }
         }
      
         public bool DynamicNonStackExtent
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("DynamicNonStackExtent")); }
         	set { setFieldValue("DynamicNonStackExtent", value ? "1" : "0"); }
         }
      
         public bool DynamicPos
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("DynamicPos")); }
         	set { setFieldValue("DynamicPos", value ? "1" : "0"); }
         }
      
         public bool ChangeChildSizeToFit
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ChangeChildSizeToFit")); }
         	set { setFieldValue("ChangeChildSizeToFit", value ? "1" : "0"); }
         }
      
         public bool ChangeChildPosition
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ChangeChildPosition")); }
         	set { setFieldValue("ChangeChildPosition", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}