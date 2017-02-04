using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiHealthTextHud : GuiControl
	{
		public GuiHealthTextHud(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiHealthTextHud(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiHealthTextHud(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiHealthTextHud(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiHealthTextHud(SimObject pObj) : base(pObj)
		{
		}

		public GuiHealthTextHud(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiHealthTextHud_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiHealthTextHud_create();
         private static _GuiHealthTextHud_create _GuiHealthTextHud_createFunc;
         internal static IntPtr GuiHealthTextHud_create()
         {
         	if (_GuiHealthTextHud_createFunc == null)
         	{
         		_GuiHealthTextHud_createFunc =
         			(_GuiHealthTextHud_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiHealthTextHud_create"), typeof(_GuiHealthTextHud_create));
         	}
         
         	return  _GuiHealthTextHud_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public ColorF FillColor
         {
         	get { return new ColorF(getFieldValue("FillColor")); }
         	set { setFieldValue("FillColor", value.ToString()); }
         }
      
         public ColorF FrameColor
         {
         	get { return new ColorF(getFieldValue("FrameColor")); }
         	set { setFieldValue("FrameColor", value.ToString()); }
         }
      
         public ColorF TextColor
         {
         	get { return new ColorF(getFieldValue("TextColor")); }
         	set { setFieldValue("TextColor", value.ToString()); }
         }
      
         public ColorF WarningColor
         {
         	get { return new ColorF(getFieldValue("WarningColor")); }
         	set { setFieldValue("WarningColor", value.ToString()); }
         }
      
         public bool ShowFill
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowFill")); }
         	set { setFieldValue("ShowFill", value ? "1" : "0"); }
         }
      
         public bool ShowFrame
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowFrame")); }
         	set { setFieldValue("ShowFrame", value ? "1" : "0"); }
         }
      
         public bool ShowTrueValue
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowTrueValue")); }
         	set { setFieldValue("ShowTrueValue", value ? "1" : "0"); }
         }
      
         public bool ShowEnergy
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowEnergy")); }
         	set { setFieldValue("ShowEnergy", value ? "1" : "0"); }
         }
      
         public float WarnThreshold
         {
         	get { return float.Parse(getFieldValue("WarnThreshold")); }
         	set { setFieldValue("WarnThreshold", value.ToString()); }
         }
      
         public float PulseThreshold
         {
         	get { return float.Parse(getFieldValue("PulseThreshold")); }
         	set { setFieldValue("PulseThreshold", value.ToString()); }
         }
      
         public int PulseRate
         {
         	get { return int.Parse(getFieldValue("PulseRate")); }
         	set { setFieldValue("PulseRate", value.ToString()); }
         }
      
      
      #endregion

	}
}