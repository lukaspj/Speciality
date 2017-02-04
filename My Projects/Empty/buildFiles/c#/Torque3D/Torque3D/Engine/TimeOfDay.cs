using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class TimeOfDay : SceneObject
	{
		public TimeOfDay(bool pRegister = false)
			: base(pRegister)
		{
		}

		public TimeOfDay(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public TimeOfDay(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public TimeOfDay(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public TimeOfDay(SimObject pObj) : base(pObj)
		{
		}

		public TimeOfDay(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.TimeOfDay_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addTimeOfDayEvent(IntPtr thisPtr, float elevation, [MarshalAs(UnmanagedType.LPWStr)]string identifier);
         private static _addTimeOfDayEvent _addTimeOfDayEventFunc;
         internal static void addTimeOfDayEvent(IntPtr thisPtr, float elevation, [MarshalAs(UnmanagedType.LPWStr)]string identifier)
         {
         	if (_addTimeOfDayEventFunc == null)
         	{
         		_addTimeOfDayEventFunc =
         			(_addTimeOfDayEvent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTimeOfDay_addTimeOfDayEvent"), typeof(_addTimeOfDayEvent));
         	}
         
         	 _addTimeOfDayEventFunc(thisPtr, elevation, identifier);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setTimeOfDay(IntPtr thisPtr, float time);
         private static _setTimeOfDay _setTimeOfDayFunc;
         internal static void setTimeOfDay(IntPtr thisPtr, float time)
         {
         	if (_setTimeOfDayFunc == null)
         	{
         		_setTimeOfDayFunc =
         			(_setTimeOfDay)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTimeOfDay_setTimeOfDay"), typeof(_setTimeOfDay));
         	}
         
         	 _setTimeOfDayFunc(thisPtr, time);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setPlay(IntPtr thisPtr, bool enabled);
         private static _setPlay _setPlayFunc;
         internal static void setPlay(IntPtr thisPtr, bool enabled)
         {
         	if (_setPlayFunc == null)
         	{
         		_setPlayFunc =
         			(_setPlay)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTimeOfDay_setPlay"), typeof(_setPlay));
         	}
         
         	 _setPlayFunc(thisPtr, enabled);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setDayLength(IntPtr thisPtr, float seconds);
         private static _setDayLength _setDayLengthFunc;
         internal static void setDayLength(IntPtr thisPtr, float seconds)
         {
         	if (_setDayLengthFunc == null)
         	{
         		_setDayLengthFunc =
         			(_setDayLength)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTimeOfDay_setDayLength"), typeof(_setDayLength));
         	}
         
         	 _setDayLengthFunc(thisPtr, seconds);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _animate(IntPtr thisPtr, float elevation, float degreesPerSecond);
         private static _animate _animateFunc;
         internal static void animate(IntPtr thisPtr, float elevation, float degreesPerSecond)
         {
         	if (_animateFunc == null)
         	{
         		_animateFunc =
         			(_animate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTimeOfDay_animate"), typeof(_animate));
         	}
         
         	 _animateFunc(thisPtr, elevation, degreesPerSecond);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TimeOfDay_create();
         private static _TimeOfDay_create _TimeOfDay_createFunc;
         internal static IntPtr TimeOfDay_create()
         {
         	if (_TimeOfDay_createFunc == null)
         	{
         		_TimeOfDay_createFunc =
         			(_TimeOfDay_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_TimeOfDay_create"), typeof(_TimeOfDay_create));
         	}
         
         	return  _TimeOfDay_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void addTimeOfDayEvent(float elevation, string identifier)
         {
            InternalUnsafeMethods.addTimeOfDayEvent(ObjectPtr, elevation, identifier);
         }
      
         public virtual void setTimeOfDay(float time)
         {
            InternalUnsafeMethods.setTimeOfDay(ObjectPtr, time);
         }
      
         public virtual void setPlay(bool enabled)
         {
            InternalUnsafeMethods.setPlay(ObjectPtr, enabled);
         }
      
         public virtual void setDayLength(float seconds)
         {
            InternalUnsafeMethods.setDayLength(ObjectPtr, seconds);
         }
      
         public virtual void animate(float elevation, float degreesPerSecond)
         {
            InternalUnsafeMethods.animate(ObjectPtr, elevation, degreesPerSecond);
         }
      
      
      #endregion


      #region Properties
      
      
         public float AxisTilt
         {
         	get { return float.Parse(getFieldValue("AxisTilt")); }
         	set { setFieldValue("AxisTilt", value.ToString()); }
         }
      
         public float DayLength
         {
         	get { return float.Parse(getFieldValue("DayLength")); }
         	set { setFieldValue("DayLength", value.ToString()); }
         }
      
         public float StartTime
         {
         	get { return float.Parse(getFieldValue("StartTime")); }
         	set { setFieldValue("StartTime", value.ToString()); }
         }
      
         public float Time
         {
         	get { return float.Parse(getFieldValue("Time")); }
         	set { setFieldValue("Time", value.ToString()); }
         }
      
         public bool Play
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Play")); }
         	set { setFieldValue("Play", value ? "1" : "0"); }
         }
      
         public float AzimuthOverride
         {
         	get { return float.Parse(getFieldValue("AzimuthOverride")); }
         	set { setFieldValue("AzimuthOverride", value.ToString()); }
         }
      
         public float DayScale
         {
         	get { return float.Parse(getFieldValue("DayScale")); }
         	set { setFieldValue("DayScale", value.ToString()); }
         }
      
         public float NightScale
         {
         	get { return float.Parse(getFieldValue("NightScale")); }
         	set { setFieldValue("NightScale", value.ToString()); }
         }
      
      
      #endregion

	}
}