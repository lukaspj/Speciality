using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiClockHud : GuiControl
	{
		public GuiClockHud(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiClockHud(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiClockHud(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiClockHud(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiClockHud(SimObject pObj) : base(pObj)
		{
		}

		public GuiClockHud(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiClockHud_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setTime(IntPtr thisPtr, float timeInSeconds);
         private static _setTime _setTimeFunc;
         internal static void setTime(IntPtr thisPtr, float timeInSeconds)
         {
         	if (_setTimeFunc == null)
         	{
         		_setTimeFunc =
         			(_setTime)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiClockHud_setTime"), typeof(_setTime));
         	}
         
         	 _setTimeFunc(thisPtr, timeInSeconds);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setReverseTime(IntPtr thisPtr, float timeInSeconds);
         private static _setReverseTime _setReverseTimeFunc;
         internal static void setReverseTime(IntPtr thisPtr, float timeInSeconds)
         {
         	if (_setReverseTimeFunc == null)
         	{
         		_setReverseTimeFunc =
         			(_setReverseTime)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiClockHud_setReverseTime"), typeof(_setReverseTime));
         	}
         
         	 _setReverseTimeFunc(thisPtr, timeInSeconds);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getTime(IntPtr thisPtr);
         private static _getTime _getTimeFunc;
         internal static float getTime(IntPtr thisPtr)
         {
         	if (_getTimeFunc == null)
         	{
         		_getTimeFunc =
         			(_getTime)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiClockHud_getTime"), typeof(_getTime));
         	}
         
         	return  _getTimeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiClockHud_create();
         private static _GuiClockHud_create _GuiClockHud_createFunc;
         internal static IntPtr GuiClockHud_create()
         {
         	if (_GuiClockHud_createFunc == null)
         	{
         		_GuiClockHud_createFunc =
         			(_GuiClockHud_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiClockHud_create"), typeof(_GuiClockHud_create));
         	}
         
         	return  _GuiClockHud_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setTime(float timeInSeconds = 60)
         {
            InternalUnsafeMethods.setTime(ObjectPtr, timeInSeconds);
         }
      
         public virtual void setReverseTime(float timeInSeconds = 60)
         {
            InternalUnsafeMethods.setReverseTime(ObjectPtr, timeInSeconds);
         }
      
         public virtual float getTime()
         {
            return InternalUnsafeMethods.getTime(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
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
      
      
      #endregion

	}
}