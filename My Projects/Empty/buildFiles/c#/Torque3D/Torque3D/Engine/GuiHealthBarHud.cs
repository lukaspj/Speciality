using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiHealthBarHud : GuiControl
	{
		public GuiHealthBarHud(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiHealthBarHud(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiHealthBarHud(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiHealthBarHud(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiHealthBarHud(SimObject pObj) : base(pObj)
		{
		}

		public GuiHealthBarHud(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiHealthBarHud_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiHealthBarHud_create();
         private static _GuiHealthBarHud_create _GuiHealthBarHud_createFunc;
         internal static IntPtr GuiHealthBarHud_create()
         {
         	if (_GuiHealthBarHud_createFunc == null)
         	{
         		_GuiHealthBarHud_createFunc =
         			(_GuiHealthBarHud_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiHealthBarHud_create"), typeof(_GuiHealthBarHud_create));
         	}
         
         	return  _GuiHealthBarHud_createFunc();
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
      
         public ColorF DamageFillColor
         {
         	get { return new ColorF(getFieldValue("DamageFillColor")); }
         	set { setFieldValue("DamageFillColor", value.ToString()); }
         }
      
         public int PulseRate
         {
         	get { return int.Parse(getFieldValue("PulseRate")); }
         	set { setFieldValue("PulseRate", value.ToString()); }
         }
      
         public float PulseThreshold
         {
         	get { return float.Parse(getFieldValue("PulseThreshold")); }
         	set { setFieldValue("PulseThreshold", value.ToString()); }
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
      
         public bool DisplayEnergy
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("DisplayEnergy")); }
         	set { setFieldValue("DisplayEnergy", value ? "1" : "0"); }
         }
      
         public bool Flip
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Flip")); }
         	set { setFieldValue("Flip", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}