using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class VolumetricFog : SceneObject
	{
		public VolumetricFog(bool pRegister = false)
			: base(pRegister)
		{
		}

		public VolumetricFog(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public VolumetricFog(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public VolumetricFog(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public VolumetricFog(SimObject pObj) : base(pObj)
		{
		}

		public VolumetricFog(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.VolumetricFog_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SetFogColorF(IntPtr thisPtr, InternalColorFStruct new_color);
         private static _SetFogColorF _SetFogColorFFunc;
         internal static void SetFogColorF(IntPtr thisPtr, InternalColorFStruct new_color)
         {
         	if (_SetFogColorFFunc == null)
         	{
         		_SetFogColorFFunc =
         			(_SetFogColorF)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnVolumetricFog_SetFogColorF"), typeof(_SetFogColorF));
         	}
         
         	 _SetFogColorFFunc(thisPtr, new_color);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SetFogColor(IntPtr thisPtr, InternalColorIStruct new_color);
         private static _SetFogColor _SetFogColorFunc;
         internal static void SetFogColor(IntPtr thisPtr, InternalColorIStruct new_color)
         {
         	if (_SetFogColorFunc == null)
         	{
         		_SetFogColorFunc =
         			(_SetFogColor)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnVolumetricFog_SetFogColor"), typeof(_SetFogColor));
         	}
         
         	 _SetFogColorFunc(thisPtr, new_color);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SetFogDensity(IntPtr thisPtr, float new_density);
         private static _SetFogDensity _SetFogDensityFunc;
         internal static void SetFogDensity(IntPtr thisPtr, float new_density)
         {
         	if (_SetFogDensityFunc == null)
         	{
         		_SetFogDensityFunc =
         			(_SetFogDensity)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnVolumetricFog_SetFogDensity"), typeof(_SetFogDensity));
         	}
         
         	 _SetFogDensityFunc(thisPtr, new_density);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SetFogModulation(IntPtr thisPtr, float new_strenght, InternalPoint2FStruct new_speed1, InternalPoint2FStruct new_speed2);
         private static _SetFogModulation _SetFogModulationFunc;
         internal static void SetFogModulation(IntPtr thisPtr, float new_strenght, InternalPoint2FStruct new_speed1, InternalPoint2FStruct new_speed2)
         {
         	if (_SetFogModulationFunc == null)
         	{
         		_SetFogModulationFunc =
         			(_SetFogModulation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnVolumetricFog_SetFogModulation"), typeof(_SetFogModulation));
         	}
         
         	 _SetFogModulationFunc(thisPtr, new_strenght, new_speed1, new_speed2);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SetFogGlow(IntPtr thisPtr, bool on_off, float strength);
         private static _SetFogGlow _SetFogGlowFunc;
         internal static void SetFogGlow(IntPtr thisPtr, bool on_off, float strength)
         {
         	if (_SetFogGlowFunc == null)
         	{
         		_SetFogGlowFunc =
         			(_SetFogGlow)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnVolumetricFog_SetFogGlow"), typeof(_SetFogGlow));
         	}
         
         	 _SetFogGlowFunc(thisPtr, on_off, strength);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SetFogLightray(IntPtr thisPtr, bool on_off, float strength);
         private static _SetFogLightray _SetFogLightrayFunc;
         internal static void SetFogLightray(IntPtr thisPtr, bool on_off, float strength)
         {
         	if (_SetFogLightrayFunc == null)
         	{
         		_SetFogLightrayFunc =
         			(_SetFogLightray)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnVolumetricFog_SetFogLightray"), typeof(_SetFogLightray));
         	}
         
         	 _SetFogLightrayFunc(thisPtr, on_off, strength);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isInsideFog(IntPtr thisPtr);
         private static _isInsideFog _isInsideFogFunc;
         internal static bool isInsideFog(IntPtr thisPtr)
         {
         	if (_isInsideFogFunc == null)
         	{
         		_isInsideFogFunc =
         			(_isInsideFog)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnVolumetricFog_isInsideFog"), typeof(_isInsideFog));
         	}
         
         	return  _isInsideFogFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _VolumetricFog_create();
         private static _VolumetricFog_create _VolumetricFog_createFunc;
         internal static IntPtr VolumetricFog_create()
         {
         	if (_VolumetricFog_createFunc == null)
         	{
         		_VolumetricFog_createFunc =
         			(_VolumetricFog_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_VolumetricFog_create"), typeof(_VolumetricFog_create));
         	}
         
         	return  _VolumetricFog_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void SetFogColorF(ColorF new_color)
         {
            InternalUnsafeMethods.SetFogColorF(ObjectPtr, new_color.ToStruct());
         }
      
         public virtual void SetFogColor(ColorI new_color)
         {
            InternalUnsafeMethods.SetFogColor(ObjectPtr, new_color.ToStruct());
         }
      
         public virtual void SetFogDensity(float new_density)
         {
            InternalUnsafeMethods.SetFogDensity(ObjectPtr, new_density);
         }
      
         public virtual void SetFogModulation(float new_strenght, Point2F new_speed1, Point2F new_speed2)
         {
            InternalUnsafeMethods.SetFogModulation(ObjectPtr, new_strenght, new_speed1.ToStruct(), new_speed2.ToStruct());
         }
      
         public virtual void SetFogGlow(bool on_off, float strength)
         {
            InternalUnsafeMethods.SetFogGlow(ObjectPtr, on_off, strength);
         }
      
         public virtual void SetFogLightray(bool on_off, float strength)
         {
            InternalUnsafeMethods.SetFogLightray(ObjectPtr, on_off, strength);
         }
      
         public virtual bool isInsideFog()
         {
            return InternalUnsafeMethods.isInsideFog(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public string ShapeName
         {
         	get { return getFieldValue("ShapeName"); }
         	set { setFieldValue("ShapeName", value); }
         }
      
         public ColorI FogColor
         {
         	get { return new ColorI(getFieldValue("FogColor")); }
         	set { setFieldValue("FogColor", value.ToString()); }
         }
      
         public float FogDensity
         {
         	get { return float.Parse(getFieldValue("FogDensity")); }
         	set { setFieldValue("FogDensity", value.ToString()); }
         }
      
         public bool IgnoreWater
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IgnoreWater")); }
         	set { setFieldValue("IgnoreWater", value ? "1" : "0"); }
         }
      
         public float MinSize
         {
         	get { return float.Parse(getFieldValue("MinSize")); }
         	set { setFieldValue("MinSize", value.ToString()); }
         }
      
         public float FadeSize
         {
         	get { return float.Parse(getFieldValue("FadeSize")); }
         	set { setFieldValue("FadeSize", value.ToString()); }
         }
      
         public string Texture
         {
         	get { return getFieldValue("Texture"); }
         	set { setFieldValue("Texture", value); }
         }
      
         public float Tiles
         {
         	get { return float.Parse(getFieldValue("Tiles")); }
         	set { setFieldValue("Tiles", value.ToString()); }
         }
      
         public float ModStrength
         {
         	get { return float.Parse(getFieldValue("ModStrength")); }
         	set { setFieldValue("ModStrength", value.ToString()); }
         }
      
         public Point2F PrimSpeed
         {
         	get { return new Point2F(getFieldValue("PrimSpeed")); }
         	set { setFieldValue("PrimSpeed", value.ToString()); }
         }
      
         public Point2F SecSpeed
         {
         	get { return new Point2F(getFieldValue("SecSpeed")); }
         	set { setFieldValue("SecSpeed", value.ToString()); }
         }
      
         public bool Reflectable
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Reflectable")); }
         	set { setFieldValue("Reflectable", value ? "1" : "0"); }
         }
      
         public float ReflectStrength
         {
         	get { return float.Parse(getFieldValue("ReflectStrength")); }
         	set { setFieldValue("ReflectStrength", value.ToString()); }
         }
      
         public bool UseGlow
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseGlow")); }
         	set { setFieldValue("UseGlow", value ? "1" : "0"); }
         }
      
         public float GlowStrength
         {
         	get { return float.Parse(getFieldValue("GlowStrength")); }
         	set { setFieldValue("GlowStrength", value.ToString()); }
         }
      
         public bool ModLightRay
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ModLightRay")); }
         	set { setFieldValue("ModLightRay", value ? "1" : "0"); }
         }
      
         public float LightRayMod
         {
         	get { return float.Parse(getFieldValue("LightRayMod")); }
         	set { setFieldValue("LightRayMod", value.ToString()); }
         }
      
      
      #endregion

	}
}