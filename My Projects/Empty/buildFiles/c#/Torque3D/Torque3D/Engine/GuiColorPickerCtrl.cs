using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiColorPickerCtrl : GuiControl
	{
		public GuiColorPickerCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiColorPickerCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiColorPickerCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiColorPickerCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiColorPickerCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiColorPickerCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiColorPickerCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int[] _getSelectorPos(IntPtr thisPtr);
         private static _getSelectorPos _getSelectorPosFunc;
         internal static int[] getSelectorPos(IntPtr thisPtr)
         {
         	if (_getSelectorPosFunc == null)
         	{
         		_getSelectorPosFunc =
         			(_getSelectorPos)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiColorPickerCtrl_getSelectorPos"), typeof(_getSelectorPos));
         	}
         
         	return  _getSelectorPosFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSelectorPos(IntPtr thisPtr, int[] newPos);
         private static _setSelectorPos _setSelectorPosFunc;
         internal static void setSelectorPos(IntPtr thisPtr, int[] newPos)
         {
         	if (_setSelectorPosFunc == null)
         	{
         		_setSelectorPosFunc =
         			(_setSelectorPos)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiColorPickerCtrl_setSelectorPos"), typeof(_setSelectorPos));
         	}
         
         	 _setSelectorPosFunc(thisPtr, newPos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _updateColor(IntPtr thisPtr);
         private static _updateColor _updateColorFunc;
         internal static void updateColor(IntPtr thisPtr)
         {
         	if (_updateColorFunc == null)
         	{
         		_updateColorFunc =
         			(_updateColor)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiColorPickerCtrl_updateColor"), typeof(_updateColor));
         	}
         
         	 _updateColorFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSelectorColor(IntPtr thisPtr, InternalColorFStruct color);
         private static _setSelectorColor _setSelectorColorFunc;
         internal static void setSelectorColor(IntPtr thisPtr, InternalColorFStruct color)
         {
         	if (_setSelectorColorFunc == null)
         	{
         		_setSelectorColorFunc =
         			(_setSelectorColor)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiColorPickerCtrl_setSelectorColor"), typeof(_setSelectorColor));
         	}
         
         	 _setSelectorColorFunc(thisPtr, color);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiColorPickerCtrl_create();
         private static _GuiColorPickerCtrl_create _GuiColorPickerCtrl_createFunc;
         internal static IntPtr GuiColorPickerCtrl_create()
         {
         	if (_GuiColorPickerCtrl_createFunc == null)
         	{
         		_GuiColorPickerCtrl_createFunc =
         			(_GuiColorPickerCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiColorPickerCtrl_create"), typeof(_GuiColorPickerCtrl_create));
         	}
         
         	return  _GuiColorPickerCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual Point2I getSelectorPos()
         {
            return new Point2I(InternalUnsafeMethods.getSelectorPos(ObjectPtr));
         }
      
         public virtual void setSelectorPos(Point2I newPos)
         {
            InternalUnsafeMethods.setSelectorPos(ObjectPtr, newPos.ToArray());
         }
      
         public virtual void updateColor()
         {
            InternalUnsafeMethods.updateColor(ObjectPtr);
         }
      
         public virtual void setSelectorColor(ColorF color)
         {
            InternalUnsafeMethods.setSelectorColor(ObjectPtr, color.ToStruct());
         }
      
      
      #endregion


      #region Properties
      
      
         public ColorF BaseColor
         {
         	get { return new ColorF(getFieldValue("BaseColor")); }
         	set { setFieldValue("BaseColor", value.ToString()); }
         }
      
         public ColorF PickColor
         {
         	get { return new ColorF(getFieldValue("PickColor")); }
         	set { setFieldValue("PickColor", value.ToString()); }
         }
      
         public int SelectorGap
         {
         	get { return int.Parse(getFieldValue("SelectorGap")); }
         	set { setFieldValue("SelectorGap", value.ToString()); }
         }
      
         public GuiColorPickMode DisplayMode
         {
         	get { return (GuiColorPickMode)Enum.Parse(typeof(GuiColorPickMode), getFieldValue("DisplayMode"), true); }
         	set { setFieldValue("DisplayMode", value.ToString()); }
         }
      
         public bool ActionOnMove
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ActionOnMove")); }
         	set { setFieldValue("ActionOnMove", value ? "1" : "0"); }
         }
      
         public bool ShowReticle
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowReticle")); }
         	set { setFieldValue("ShowReticle", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}