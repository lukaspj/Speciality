using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiGradientCtrl : GuiControl
	{
		public GuiGradientCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiGradientCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiGradientCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiGradientCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiGradientCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiGradientCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiGradientCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getColorCount(IntPtr thisPtr);
         private static _getColorCount _getColorCountFunc;
         internal static int getColorCount(IntPtr thisPtr)
         {
         	if (_getColorCountFunc == null)
         	{
         		_getColorCountFunc =
         			(_getColorCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiGradientCtrl_getColorCount"), typeof(_getColorCount));
         	}
         
         	return  _getColorCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalColorFStruct _getColor(IntPtr thisPtr, int idx);
         private static _getColor _getColorFunc;
         internal static InternalColorFStruct getColor(IntPtr thisPtr, int idx)
         {
         	if (_getColorFunc == null)
         	{
         		_getColorFunc =
         			(_getColor)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiGradientCtrl_getColor"), typeof(_getColor));
         	}
         
         	return  _getColorFunc(thisPtr, idx);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiGradientCtrl_create();
         private static _GuiGradientCtrl_create _GuiGradientCtrl_createFunc;
         internal static IntPtr GuiGradientCtrl_create()
         {
         	if (_GuiGradientCtrl_createFunc == null)
         	{
         		_GuiGradientCtrl_createFunc =
         			(_GuiGradientCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiGradientCtrl_create"), typeof(_GuiGradientCtrl_create));
         	}
         
         	return  _GuiGradientCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int getColorCount()
         {
            return InternalUnsafeMethods.getColorCount(ObjectPtr);
         }
      
         public virtual ColorF getColor(int idx)
         {
            return new ColorF(InternalUnsafeMethods.getColor(ObjectPtr, idx));
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
      
         public GuiGradientPickMode DisplayMode
         {
         	get { return (GuiGradientPickMode)Enum.Parse(typeof(GuiGradientPickMode), getFieldValue("DisplayMode"), true); }
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
      
         public int SwatchFactor
         {
         	get { return int.Parse(getFieldValue("SwatchFactor")); }
         	set { setFieldValue("SwatchFactor", value.ToString()); }
         }
      
      
      #endregion

	}
}