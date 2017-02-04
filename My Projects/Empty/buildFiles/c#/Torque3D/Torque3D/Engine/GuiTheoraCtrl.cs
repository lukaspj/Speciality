using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiTheoraCtrl : GuiControl
	{
		public GuiTheoraCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiTheoraCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiTheoraCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiTheoraCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiTheoraCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiTheoraCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiTheoraCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setFile(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _setFile _setFileFunc;
         internal static void setFile(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_setFileFunc == null)
         	{
         		_setFileFunc =
         			(_setFile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTheoraCtrl_setFile"), typeof(_setFile));
         	}
         
         	 _setFileFunc(thisPtr, filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _play(IntPtr thisPtr);
         private static _play _playFunc;
         internal static void play(IntPtr thisPtr)
         {
         	if (_playFunc == null)
         	{
         		_playFunc =
         			(_play)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTheoraCtrl_play"), typeof(_play));
         	}
         
         	 _playFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _pause(IntPtr thisPtr);
         private static _pause _pauseFunc;
         internal static void pause(IntPtr thisPtr)
         {
         	if (_pauseFunc == null)
         	{
         		_pauseFunc =
         			(_pause)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTheoraCtrl_pause"), typeof(_pause));
         	}
         
         	 _pauseFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _stop(IntPtr thisPtr);
         private static _stop _stopFunc;
         internal static void stop(IntPtr thisPtr)
         {
         	if (_stopFunc == null)
         	{
         		_stopFunc =
         			(_stop)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTheoraCtrl_stop"), typeof(_stop));
         	}
         
         	 _stopFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getCurrentTime(IntPtr thisPtr);
         private static _getCurrentTime _getCurrentTimeFunc;
         internal static float getCurrentTime(IntPtr thisPtr)
         {
         	if (_getCurrentTimeFunc == null)
         	{
         		_getCurrentTimeFunc =
         			(_getCurrentTime)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTheoraCtrl_getCurrentTime"), typeof(_getCurrentTime));
         	}
         
         	return  _getCurrentTimeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isPlaybackDone(IntPtr thisPtr);
         private static _isPlaybackDone _isPlaybackDoneFunc;
         internal static bool isPlaybackDone(IntPtr thisPtr)
         {
         	if (_isPlaybackDoneFunc == null)
         	{
         		_isPlaybackDoneFunc =
         			(_isPlaybackDone)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTheoraCtrl_isPlaybackDone"), typeof(_isPlaybackDone));
         	}
         
         	return  _isPlaybackDoneFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTheoraCtrl_create();
         private static _GuiTheoraCtrl_create _GuiTheoraCtrl_createFunc;
         internal static IntPtr GuiTheoraCtrl_create()
         {
         	if (_GuiTheoraCtrl_createFunc == null)
         	{
         		_GuiTheoraCtrl_createFunc =
         			(_GuiTheoraCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiTheoraCtrl_create"), typeof(_GuiTheoraCtrl_create));
         	}
         
         	return  _GuiTheoraCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setFile(string filename)
         {
            InternalUnsafeMethods.setFile(ObjectPtr, filename);
         }
      
         public virtual void play()
         {
            InternalUnsafeMethods.play(ObjectPtr);
         }
      
         public virtual void pause()
         {
            InternalUnsafeMethods.pause(ObjectPtr);
         }
      
         public virtual void stop()
         {
            InternalUnsafeMethods.stop(ObjectPtr);
         }
      
         public virtual float getCurrentTime()
         {
            return InternalUnsafeMethods.getCurrentTime(ObjectPtr);
         }
      
         public virtual bool isPlaybackDone()
         {
            return InternalUnsafeMethods.isPlaybackDone(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public string TheoraFile
         {
         	get { return getFieldValue("TheoraFile"); }
         	set { setFieldValue("TheoraFile", value); }
         }
      
         public ColorI BackgroundColor
         {
         	get { return new ColorI(getFieldValue("BackgroundColor")); }
         	set { setFieldValue("BackgroundColor", value.ToString()); }
         }
      
         public bool PlayOnWake
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("PlayOnWake")); }
         	set { setFieldValue("PlayOnWake", value ? "1" : "0"); }
         }
      
         public bool Loop
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Loop")); }
         	set { setFieldValue("Loop", value ? "1" : "0"); }
         }
      
         public bool StopOnSleep
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("StopOnSleep")); }
         	set { setFieldValue("StopOnSleep", value ? "1" : "0"); }
         }
      
         public bool MatchVideoSize
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("MatchVideoSize")); }
         	set { setFieldValue("MatchVideoSize", value ? "1" : "0"); }
         }
      
         public bool RenderDebugInfo
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderDebugInfo")); }
         	set { setFieldValue("RenderDebugInfo", value ? "1" : "0"); }
         }
      
         public GuiTheoraTranscoder Transcoder
         {
         	get { return (GuiTheoraTranscoder)Enum.Parse(typeof(GuiTheoraTranscoder), getFieldValue("Transcoder"), true); }
         	set { setFieldValue("Transcoder", value.ToString()); }
         }
      
      
      #endregion

	}
}