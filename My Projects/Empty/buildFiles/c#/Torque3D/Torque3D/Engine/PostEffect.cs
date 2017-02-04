using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class PostEffect : SimGroup
	{
		public PostEffect(bool pRegister = false)
			: base(pRegister)
		{
		}

		public PostEffect(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public PostEffect(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public PostEffect(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public PostEffect(SimObject pObj) : base(pObj)
		{
		}

		public PostEffect(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.PostEffect_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _reload(IntPtr thisPtr);
         private static _reload _reloadFunc;
         internal static void reload(IntPtr thisPtr)
         {
         	if (_reloadFunc == null)
         	{
         		_reloadFunc =
         			(_reload)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPostEffect_reload"), typeof(_reload));
         	}
         
         	 _reloadFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _enable(IntPtr thisPtr);
         private static _enable _enableFunc;
         internal static void enable(IntPtr thisPtr)
         {
         	if (_enableFunc == null)
         	{
         		_enableFunc =
         			(_enable)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPostEffect_enable"), typeof(_enable));
         	}
         
         	 _enableFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _disable(IntPtr thisPtr);
         private static _disable _disableFunc;
         internal static void disable(IntPtr thisPtr)
         {
         	if (_disableFunc == null)
         	{
         		_disableFunc =
         			(_disable)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPostEffect_disable"), typeof(_disable));
         	}
         
         	 _disableFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _toggle(IntPtr thisPtr);
         private static _toggle _toggleFunc;
         internal static bool toggle(IntPtr thisPtr)
         {
         	if (_toggleFunc == null)
         	{
         		_toggleFunc =
         			(_toggle)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPostEffect_toggle"), typeof(_toggle));
         	}
         
         	return  _toggleFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isEnabled(IntPtr thisPtr);
         private static _isEnabled _isEnabledFunc;
         internal static bool isEnabled(IntPtr thisPtr)
         {
         	if (_isEnabledFunc == null)
         	{
         		_isEnabledFunc =
         			(_isEnabled)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPostEffect_isEnabled"), typeof(_isEnabled));
         	}
         
         	return  _isEnabledFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setTexture(IntPtr thisPtr, int index, [MarshalAs(UnmanagedType.LPWStr)]string filePath);
         private static _setTexture _setTextureFunc;
         internal static void setTexture(IntPtr thisPtr, int index, [MarshalAs(UnmanagedType.LPWStr)]string filePath)
         {
         	if (_setTextureFunc == null)
         	{
         		_setTextureFunc =
         			(_setTexture)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPostEffect_setTexture"), typeof(_setTexture));
         	}
         
         	 _setTextureFunc(thisPtr, index, filePath);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setShaderConst(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, [MarshalAs(UnmanagedType.LPWStr)]string value);
         private static _setShaderConst _setShaderConstFunc;
         internal static void setShaderConst(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, [MarshalAs(UnmanagedType.LPWStr)]string value)
         {
         	if (_setShaderConstFunc == null)
         	{
         		_setShaderConstFunc =
         			(_setShaderConst)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPostEffect_setShaderConst"), typeof(_setShaderConst));
         	}
         
         	 _setShaderConstFunc(thisPtr, name, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getAspectRatio(IntPtr thisPtr);
         private static _getAspectRatio _getAspectRatioFunc;
         internal static float getAspectRatio(IntPtr thisPtr)
         {
         	if (_getAspectRatioFunc == null)
         	{
         		_getAspectRatioFunc =
         			(_getAspectRatio)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPostEffect_getAspectRatio"), typeof(_getAspectRatio));
         	}
         
         	return  _getAspectRatioFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _dumpShaderDisassembly(IntPtr thisPtr);
         private static _dumpShaderDisassembly _dumpShaderDisassemblyFunc;
         internal static IntPtr dumpShaderDisassembly(IntPtr thisPtr)
         {
         	if (_dumpShaderDisassemblyFunc == null)
         	{
         		_dumpShaderDisassemblyFunc =
         			(_dumpShaderDisassembly)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPostEffect_dumpShaderDisassembly"), typeof(_dumpShaderDisassembly));
         	}
         
         	return  _dumpShaderDisassemblyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setShaderMacro(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string key, [MarshalAs(UnmanagedType.LPWStr)]string value);
         private static _setShaderMacro _setShaderMacroFunc;
         internal static void setShaderMacro(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string key, [MarshalAs(UnmanagedType.LPWStr)]string value)
         {
         	if (_setShaderMacroFunc == null)
         	{
         		_setShaderMacroFunc =
         			(_setShaderMacro)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPostEffect_setShaderMacro"), typeof(_setShaderMacro));
         	}
         
         	 _setShaderMacroFunc(thisPtr, key, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeShaderMacro(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string key);
         private static _removeShaderMacro _removeShaderMacroFunc;
         internal static void removeShaderMacro(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string key)
         {
         	if (_removeShaderMacroFunc == null)
         	{
         		_removeShaderMacroFunc =
         			(_removeShaderMacro)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPostEffect_removeShaderMacro"), typeof(_removeShaderMacro));
         	}
         
         	 _removeShaderMacroFunc(thisPtr, key);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearShaderMacros(IntPtr thisPtr);
         private static _clearShaderMacros _clearShaderMacrosFunc;
         internal static void clearShaderMacros(IntPtr thisPtr)
         {
         	if (_clearShaderMacrosFunc == null)
         	{
         		_clearShaderMacrosFunc =
         			(_clearShaderMacros)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPostEffect_clearShaderMacros"), typeof(_clearShaderMacros));
         	}
         
         	 _clearShaderMacrosFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _PostEffect_create();
         private static _PostEffect_create _PostEffect_createFunc;
         internal static IntPtr PostEffect_create()
         {
         	if (_PostEffect_createFunc == null)
         	{
         		_PostEffect_createFunc =
         			(_PostEffect_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PostEffect_create"), typeof(_PostEffect_create));
         	}
         
         	return  _PostEffect_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void reload()
         {
            InternalUnsafeMethods.reload(ObjectPtr);
         }
      
         public virtual void enable()
         {
            InternalUnsafeMethods.enable(ObjectPtr);
         }
      
         public virtual void disable()
         {
            InternalUnsafeMethods.disable(ObjectPtr);
         }
      
         public virtual bool toggle()
         {
            return InternalUnsafeMethods.toggle(ObjectPtr);
         }
      
         public virtual bool isEnabled()
         {
            return InternalUnsafeMethods.isEnabled(ObjectPtr);
         }
      
         public virtual void setTexture(int index, string filePath)
         {
            InternalUnsafeMethods.setTexture(ObjectPtr, index, filePath);
         }
      
         public virtual void setShaderConst(string name, string value)
         {
            InternalUnsafeMethods.setShaderConst(ObjectPtr, name, value);
         }
      
         public virtual float getAspectRatio()
         {
            return InternalUnsafeMethods.getAspectRatio(ObjectPtr);
         }
      
         public virtual string dumpShaderDisassembly()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.dumpShaderDisassembly(ObjectPtr));
         }
      
         public virtual void setShaderMacro(string key, string value = "")
         {
            InternalUnsafeMethods.setShaderMacro(ObjectPtr, key, value);
         }
      
         public virtual void removeShaderMacro(string key)
         {
            InternalUnsafeMethods.removeShaderMacro(ObjectPtr, key);
         }
      
         public virtual void clearShaderMacros()
         {
            InternalUnsafeMethods.clearShaderMacros(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public string Shader
         {
         	get { return getFieldValue("Shader"); }
         	set { setFieldValue("Shader", value); }
         }
      
         public GFXStateBlockData StateBlock
         {
         	get { return Sim.FindObject<GFXStateBlockData>(getFieldValue("StateBlock")); }
         	set { setFieldValue("StateBlock", value.getId().ToString()); }
         }
      
         public string Target
         {
         	get { return getFieldValue("Target"); }
         	set { setFieldValue("Target", value); }
         }
      
         public string TargetDepthStencil
         {
         	get { return getFieldValue("TargetDepthStencil"); }
         	set { setFieldValue("TargetDepthStencil", value); }
         }
      
         public Point2F TargetScale
         {
         	get { return new Point2F(getFieldValue("TargetScale")); }
         	set { setFieldValue("TargetScale", value.ToString()); }
         }
      
         public Point2I TargetSize
         {
         	get { return new Point2I(getFieldValue("TargetSize")); }
         	set { setFieldValue("TargetSize", value.ToString()); }
         }
      
         public GFXFormat TargetFormat
         {
         	get { return (GFXFormat)Enum.Parse(typeof(GFXFormat), getFieldValue("TargetFormat"), true); }
         	set { setFieldValue("TargetFormat", value.ToString()); }
         }
      
         public ColorF TargetClearColor
         {
         	get { return new ColorF(getFieldValue("TargetClearColor")); }
         	set { setFieldValue("TargetClearColor", value.ToString()); }
         }
      
         public PFXTargetClear TargetClear
         {
         	get { return (PFXTargetClear)Enum.Parse(typeof(PFXTargetClear), getFieldValue("TargetClear"), true); }
         	set { setFieldValue("TargetClear", value.ToString()); }
         }
      
         public PFXTargetViewport TargetViewport
         {
         	get { return (PFXTargetViewport)Enum.Parse(typeof(PFXTargetViewport), getFieldValue("TargetViewport"), true); }
         	set { setFieldValue("TargetViewport", value.ToString()); }
         }
      
         public DynamicFieldVector<string> Texture
         {
         	get { return new DynamicFieldVector<string>(this, "Texture", 8, val => val, obj => obj); }
         }
      
         public PFXRenderTime RenderTime
         {
         	get { return (PFXRenderTime)Enum.Parse(typeof(PFXRenderTime), getFieldValue("RenderTime"), true); }
         	set { setFieldValue("RenderTime", value.ToString()); }
         }
      
         public string RenderBin
         {
         	get { return getFieldValue("RenderBin"); }
         	set { setFieldValue("RenderBin", value); }
         }
      
         public float RenderPriority
         {
         	get { return float.Parse(getFieldValue("RenderPriority")); }
         	set { setFieldValue("RenderPriority", value.ToString()); }
         }
      
         public bool AllowReflectPass
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowReflectPass")); }
         	set { setFieldValue("AllowReflectPass", value ? "1" : "0"); }
         }
      
         public bool IsEnabled
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsEnabled")); }
         	set { setFieldValue("IsEnabled", value ? "1" : "0"); }
         }
      
         public bool OnThisFrame
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OnThisFrame")); }
         	set { setFieldValue("OnThisFrame", value ? "1" : "0"); }
         }
      
         public bool OneFrameOnly
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OneFrameOnly")); }
         	set { setFieldValue("OneFrameOnly", value ? "1" : "0"); }
         }
      
         public bool Skip
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Skip")); }
         	set { setFieldValue("Skip", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}