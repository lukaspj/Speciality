using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class Precipitation : GameBase
	{
		public Precipitation(bool pRegister = false)
			: base(pRegister)
		{
		}

		public Precipitation(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public Precipitation(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public Precipitation(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public Precipitation(SimObject pObj) : base(pObj)
		{
		}

		public Precipitation(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Precipitation_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setPercentage(IntPtr thisPtr, float percentage);
         private static _setPercentage _setPercentageFunc;
         internal static void setPercentage(IntPtr thisPtr, float percentage)
         {
         	if (_setPercentageFunc == null)
         	{
         		_setPercentageFunc =
         			(_setPercentage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPrecipitation_setPercentage"), typeof(_setPercentage));
         	}
         
         	 _setPercentageFunc(thisPtr, percentage);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _modifyStorm(IntPtr thisPtr, float percentage, float seconds);
         private static _modifyStorm _modifyStormFunc;
         internal static void modifyStorm(IntPtr thisPtr, float percentage, float seconds)
         {
         	if (_modifyStormFunc == null)
         	{
         		_modifyStormFunc =
         			(_modifyStorm)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPrecipitation_modifyStorm"), typeof(_modifyStorm));
         	}
         
         	 _modifyStormFunc(thisPtr, percentage, seconds);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setTurbulence(IntPtr thisPtr, float max, float speed, float seconds);
         private static _setTurbulence _setTurbulenceFunc;
         internal static void setTurbulence(IntPtr thisPtr, float max, float speed, float seconds)
         {
         	if (_setTurbulenceFunc == null)
         	{
         		_setTurbulenceFunc =
         			(_setTurbulence)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPrecipitation_setTurbulence"), typeof(_setTurbulence));
         	}
         
         	 _setTurbulenceFunc(thisPtr, max, speed, seconds);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Precipitation_create();
         private static _Precipitation_create _Precipitation_createFunc;
         internal static IntPtr Precipitation_create()
         {
         	if (_Precipitation_createFunc == null)
         	{
         		_Precipitation_createFunc =
         			(_Precipitation_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Precipitation_create"), typeof(_Precipitation_create));
         	}
         
         	return  _Precipitation_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setPercentage(float percentage = 1.0f)
         {
            InternalUnsafeMethods.setPercentage(ObjectPtr, percentage);
         }
      
         public virtual void modifyStorm(float percentage = 1.0f, float seconds = 5.0f)
         {
            InternalUnsafeMethods.modifyStorm(ObjectPtr, percentage, seconds);
         }
      
         public virtual void setTurbulence(float max = 1.0f, float speed = 5.0f, float seconds = 5.0f)
         {
            InternalUnsafeMethods.setTurbulence(ObjectPtr, max, speed, seconds);
         }
      
      
      #endregion


      #region Properties
      
      
         public int NumDrops
         {
         	get { return int.Parse(getFieldValue("NumDrops")); }
         	set { setFieldValue("NumDrops", value.ToString()); }
         }
      
         public float BoxWidth
         {
         	get { return float.Parse(getFieldValue("BoxWidth")); }
         	set { setFieldValue("BoxWidth", value.ToString()); }
         }
      
         public float BoxHeight
         {
         	get { return float.Parse(getFieldValue("BoxHeight")); }
         	set { setFieldValue("BoxHeight", value.ToString()); }
         }
      
         public float DropSize
         {
         	get { return float.Parse(getFieldValue("DropSize")); }
         	set { setFieldValue("DropSize", value.ToString()); }
         }
      
         public float SplashSize
         {
         	get { return float.Parse(getFieldValue("SplashSize")); }
         	set { setFieldValue("SplashSize", value.ToString()); }
         }
      
         public int SplashMS
         {
         	get { return int.Parse(getFieldValue("SplashMS")); }
         	set { setFieldValue("SplashMS", value.ToString()); }
         }
      
         public bool AnimateSplashes
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AnimateSplashes")); }
         	set { setFieldValue("AnimateSplashes", value ? "1" : "0"); }
         }
      
         public int DropAnimateMS
         {
         	get { return int.Parse(getFieldValue("DropAnimateMS")); }
         	set { setFieldValue("DropAnimateMS", value.ToString()); }
         }
      
         public float FadeDist
         {
         	get { return float.Parse(getFieldValue("FadeDist")); }
         	set { setFieldValue("FadeDist", value.ToString()); }
         }
      
         public float FadeDistEnd
         {
         	get { return float.Parse(getFieldValue("FadeDistEnd")); }
         	set { setFieldValue("FadeDistEnd", value.ToString()); }
         }
      
         public bool UseTrueBillboards
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseTrueBillboards")); }
         	set { setFieldValue("UseTrueBillboards", value ? "1" : "0"); }
         }
      
         public bool UseLighting
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseLighting")); }
         	set { setFieldValue("UseLighting", value ? "1" : "0"); }
         }
      
         public ColorF GlowIntensity
         {
         	get { return new ColorF(getFieldValue("GlowIntensity")); }
         	set { setFieldValue("GlowIntensity", value.ToString()); }
         }
      
         public bool Reflect
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Reflect")); }
         	set { setFieldValue("Reflect", value ? "1" : "0"); }
         }
      
         public bool RotateWithCamVel
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RotateWithCamVel")); }
         	set { setFieldValue("RotateWithCamVel", value ? "1" : "0"); }
         }
      
         public bool DoCollision
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("DoCollision")); }
         	set { setFieldValue("DoCollision", value ? "1" : "0"); }
         }
      
         public bool HitPlayers
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("HitPlayers")); }
         	set { setFieldValue("HitPlayers", value ? "1" : "0"); }
         }
      
         public bool HitVehicles
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("HitVehicles")); }
         	set { setFieldValue("HitVehicles", value ? "1" : "0"); }
         }
      
         public bool FollowCam
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FollowCam")); }
         	set { setFieldValue("FollowCam", value ? "1" : "0"); }
         }
      
         public bool UseWind
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseWind")); }
         	set { setFieldValue("UseWind", value ? "1" : "0"); }
         }
      
         public float MinSpeed
         {
         	get { return float.Parse(getFieldValue("MinSpeed")); }
         	set { setFieldValue("MinSpeed", value.ToString()); }
         }
      
         public float MaxSpeed
         {
         	get { return float.Parse(getFieldValue("MaxSpeed")); }
         	set { setFieldValue("MaxSpeed", value.ToString()); }
         }
      
         public float MinMass
         {
         	get { return float.Parse(getFieldValue("MinMass")); }
         	set { setFieldValue("MinMass", value.ToString()); }
         }
      
         public float MaxMass
         {
         	get { return float.Parse(getFieldValue("MaxMass")); }
         	set { setFieldValue("MaxMass", value.ToString()); }
         }
      
         public bool UseTurbulence
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseTurbulence")); }
         	set { setFieldValue("UseTurbulence", value ? "1" : "0"); }
         }
      
         public float MaxTurbulence
         {
         	get { return float.Parse(getFieldValue("MaxTurbulence")); }
         	set { setFieldValue("MaxTurbulence", value.ToString()); }
         }
      
         public float TurbulenceSpeed
         {
         	get { return float.Parse(getFieldValue("TurbulenceSpeed")); }
         	set { setFieldValue("TurbulenceSpeed", value.ToString()); }
         }
      
      
      #endregion

	}
}