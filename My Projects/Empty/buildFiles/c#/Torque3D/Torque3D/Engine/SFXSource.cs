using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SFXSource : SimGroup
	{
		public SFXSource(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SFXSource(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SFXSource(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SFXSource(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SFXSource(SimObject pObj) : base(pObj)
		{
		}

		public SFXSource(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SFXSource_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _play(IntPtr thisPtr, float fadeInTime);
         private static _play _playFunc;
         internal static void play(IntPtr thisPtr, float fadeInTime)
         {
         	if (_playFunc == null)
         	{
         		_playFunc =
         			(_play)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSource_play"), typeof(_play));
         	}
         
         	 _playFunc(thisPtr, fadeInTime);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _stop(IntPtr thisPtr, float fadeOutTime);
         private static _stop _stopFunc;
         internal static void stop(IntPtr thisPtr, float fadeOutTime)
         {
         	if (_stopFunc == null)
         	{
         		_stopFunc =
         			(_stop)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSource_stop"), typeof(_stop));
         	}
         
         	 _stopFunc(thisPtr, fadeOutTime);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _pause(IntPtr thisPtr, float fadeOutTime);
         private static _pause _pauseFunc;
         internal static void pause(IntPtr thisPtr, float fadeOutTime)
         {
         	if (_pauseFunc == null)
         	{
         		_pauseFunc =
         			(_pause)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSource_pause"), typeof(_pause));
         	}
         
         	 _pauseFunc(thisPtr, fadeOutTime);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isPlaying(IntPtr thisPtr);
         private static _isPlaying _isPlayingFunc;
         internal static bool isPlaying(IntPtr thisPtr)
         {
         	if (_isPlayingFunc == null)
         	{
         		_isPlayingFunc =
         			(_isPlaying)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSource_isPlaying"), typeof(_isPlaying));
         	}
         
         	return  _isPlayingFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isPaused(IntPtr thisPtr);
         private static _isPaused _isPausedFunc;
         internal static bool isPaused(IntPtr thisPtr)
         {
         	if (_isPausedFunc == null)
         	{
         		_isPausedFunc =
         			(_isPaused)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSource_isPaused"), typeof(_isPaused));
         	}
         
         	return  _isPausedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isStopped(IntPtr thisPtr);
         private static _isStopped _isStoppedFunc;
         internal static bool isStopped(IntPtr thisPtr)
         {
         	if (_isStoppedFunc == null)
         	{
         		_isStoppedFunc =
         			(_isStopped)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSource_isStopped"), typeof(_isStopped));
         	}
         
         	return  _isStoppedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate SFXStatus _getStatus(IntPtr thisPtr);
         private static _getStatus _getStatusFunc;
         internal static SFXStatus getStatus(IntPtr thisPtr)
         {
         	if (_getStatusFunc == null)
         	{
         		_getStatusFunc =
         			(_getStatus)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSource_getStatus"), typeof(_getStatus));
         	}
         
         	return  _getStatusFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getVolume(IntPtr thisPtr);
         private static _getVolume _getVolumeFunc;
         internal static float getVolume(IntPtr thisPtr)
         {
         	if (_getVolumeFunc == null)
         	{
         		_getVolumeFunc =
         			(_getVolume)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSource_getVolume"), typeof(_getVolume));
         	}
         
         	return  _getVolumeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setVolume(IntPtr thisPtr, float volume);
         private static _setVolume _setVolumeFunc;
         internal static void setVolume(IntPtr thisPtr, float volume)
         {
         	if (_setVolumeFunc == null)
         	{
         		_setVolumeFunc =
         			(_setVolume)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSource_setVolume"), typeof(_setVolume));
         	}
         
         	 _setVolumeFunc(thisPtr, volume);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getAttenuatedVolume(IntPtr thisPtr);
         private static _getAttenuatedVolume _getAttenuatedVolumeFunc;
         internal static float getAttenuatedVolume(IntPtr thisPtr)
         {
         	if (_getAttenuatedVolumeFunc == null)
         	{
         		_getAttenuatedVolumeFunc =
         			(_getAttenuatedVolume)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSource_getAttenuatedVolume"), typeof(_getAttenuatedVolume));
         	}
         
         	return  _getAttenuatedVolumeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getFadeInTime(IntPtr thisPtr);
         private static _getFadeInTime _getFadeInTimeFunc;
         internal static float getFadeInTime(IntPtr thisPtr)
         {
         	if (_getFadeInTimeFunc == null)
         	{
         		_getFadeInTimeFunc =
         			(_getFadeInTime)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSource_getFadeInTime"), typeof(_getFadeInTime));
         	}
         
         	return  _getFadeInTimeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getFadeOutTime(IntPtr thisPtr);
         private static _getFadeOutTime _getFadeOutTimeFunc;
         internal static float getFadeOutTime(IntPtr thisPtr)
         {
         	if (_getFadeOutTimeFunc == null)
         	{
         		_getFadeOutTimeFunc =
         			(_getFadeOutTime)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSource_getFadeOutTime"), typeof(_getFadeOutTime));
         	}
         
         	return  _getFadeOutTimeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setFadeTimes(IntPtr thisPtr, float fadeInTime, float fadeOutTime);
         private static _setFadeTimes _setFadeTimesFunc;
         internal static void setFadeTimes(IntPtr thisPtr, float fadeInTime, float fadeOutTime)
         {
         	if (_setFadeTimesFunc == null)
         	{
         		_setFadeTimesFunc =
         			(_setFadeTimes)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSource_setFadeTimes"), typeof(_setFadeTimes));
         	}
         
         	 _setFadeTimesFunc(thisPtr, fadeInTime, fadeOutTime);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getPitch(IntPtr thisPtr);
         private static _getPitch _getPitchFunc;
         internal static float getPitch(IntPtr thisPtr)
         {
         	if (_getPitchFunc == null)
         	{
         		_getPitchFunc =
         			(_getPitch)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSource_getPitch"), typeof(_getPitch));
         	}
         
         	return  _getPitchFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setPitch(IntPtr thisPtr, float pitch);
         private static _setPitch _setPitchFunc;
         internal static void setPitch(IntPtr thisPtr, float pitch)
         {
         	if (_setPitchFunc == null)
         	{
         		_setPitchFunc =
         			(_setPitch)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSource_setPitch"), typeof(_setPitch));
         	}
         
         	 _setPitchFunc(thisPtr, pitch);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setTransform(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string position, [MarshalAs(UnmanagedType.LPWStr)]string direction);
         private static _setTransform _setTransformFunc;
         internal static void setTransform(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string position, [MarshalAs(UnmanagedType.LPWStr)]string direction)
         {
         	if (_setTransformFunc == null)
         	{
         		_setTransformFunc =
         			(_setTransform)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSource_setTransform"), typeof(_setTransform));
         	}
         
         	 _setTransformFunc(thisPtr, position, direction);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setCone(IntPtr thisPtr, float innerAngle, float outerAngle, float outsideVolume);
         private static _setCone _setConeFunc;
         internal static void setCone(IntPtr thisPtr, float innerAngle, float outerAngle, float outsideVolume)
         {
         	if (_setConeFunc == null)
         	{
         		_setConeFunc =
         			(_setCone)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSource_setCone"), typeof(_setCone));
         	}
         
         	 _setConeFunc(thisPtr, innerAngle, outerAngle, outsideVolume);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getParameterCount(IntPtr thisPtr);
         private static _getParameterCount _getParameterCountFunc;
         internal static int getParameterCount(IntPtr thisPtr)
         {
         	if (_getParameterCountFunc == null)
         	{
         		_getParameterCountFunc =
         			(_getParameterCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSource_getParameterCount"), typeof(_getParameterCount));
         	}
         
         	return  _getParameterCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addParameter(IntPtr thisPtr, IntPtr parameter);
         private static _addParameter _addParameterFunc;
         internal static void addParameter(IntPtr thisPtr, IntPtr parameter)
         {
         	if (_addParameterFunc == null)
         	{
         		_addParameterFunc =
         			(_addParameter)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSource_addParameter"), typeof(_addParameter));
         	}
         
         	 _addParameterFunc(thisPtr, parameter);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeParameter(IntPtr thisPtr, IntPtr parameter);
         private static _removeParameter _removeParameterFunc;
         internal static void removeParameter(IntPtr thisPtr, IntPtr parameter)
         {
         	if (_removeParameterFunc == null)
         	{
         		_removeParameterFunc =
         			(_removeParameter)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSource_removeParameter"), typeof(_removeParameter));
         	}
         
         	 _removeParameterFunc(thisPtr, parameter);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getParameter(IntPtr thisPtr, int index);
         private static _getParameter _getParameterFunc;
         internal static IntPtr getParameter(IntPtr thisPtr, int index)
         {
         	if (_getParameterFunc == null)
         	{
         		_getParameterFunc =
         			(_getParameter)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSource_getParameter"), typeof(_getParameter));
         	}
         
         	return  _getParameterFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addMarker(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, float pos);
         private static _addMarker _addMarkerFunc;
         internal static void addMarker(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, float pos)
         {
         	if (_addMarkerFunc == null)
         	{
         		_addMarkerFunc =
         			(_addMarker)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSource_addMarker"), typeof(_addMarker));
         	}
         
         	 _addMarkerFunc(thisPtr, name, pos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SFXSource_create();
         private static _SFXSource_create _SFXSource_createFunc;
         internal static IntPtr SFXSource_create()
         {
         	if (_SFXSource_createFunc == null)
         	{
         		_SFXSource_createFunc =
         			(_SFXSource_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SFXSource_create"), typeof(_SFXSource_create));
         	}
         
         	return  _SFXSource_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void play(float fadeInTime = -1.0f)
         {
            InternalUnsafeMethods.play(ObjectPtr, fadeInTime);
         }
      
         public virtual void stop(float fadeOutTime = -1.0f)
         {
            InternalUnsafeMethods.stop(ObjectPtr, fadeOutTime);
         }
      
         public virtual void pause(float fadeOutTime = -1.0f)
         {
            InternalUnsafeMethods.pause(ObjectPtr, fadeOutTime);
         }
      
         public virtual bool isPlaying()
         {
            return InternalUnsafeMethods.isPlaying(ObjectPtr);
         }
      
         public virtual bool isPaused()
         {
            return InternalUnsafeMethods.isPaused(ObjectPtr);
         }
      
         public virtual bool isStopped()
         {
            return InternalUnsafeMethods.isStopped(ObjectPtr);
         }
      
         public virtual SFXStatus getStatus()
         {
            return InternalUnsafeMethods.getStatus(ObjectPtr);
         }
      
         public virtual float getVolume()
         {
            return InternalUnsafeMethods.getVolume(ObjectPtr);
         }
      
         public virtual void setVolume(float volume)
         {
            InternalUnsafeMethods.setVolume(ObjectPtr, volume);
         }
      
         public virtual float getAttenuatedVolume()
         {
            return InternalUnsafeMethods.getAttenuatedVolume(ObjectPtr);
         }
      
         public virtual float getFadeInTime()
         {
            return InternalUnsafeMethods.getFadeInTime(ObjectPtr);
         }
      
         public virtual float getFadeOutTime()
         {
            return InternalUnsafeMethods.getFadeOutTime(ObjectPtr);
         }
      
         public virtual void setFadeTimes(float fadeInTime, float fadeOutTime)
         {
            InternalUnsafeMethods.setFadeTimes(ObjectPtr, fadeInTime, fadeOutTime);
         }
      
         public virtual float getPitch()
         {
            return InternalUnsafeMethods.getPitch(ObjectPtr);
         }
      
         public virtual void setPitch(float pitch)
         {
            InternalUnsafeMethods.setPitch(ObjectPtr, pitch);
         }
      
         public virtual void setTransform(string position, string direction = "")
         {
            InternalUnsafeMethods.setTransform(ObjectPtr, position, direction);
         }
      
         public virtual void setCone(float innerAngle, float outerAngle, float outsideVolume)
         {
            InternalUnsafeMethods.setCone(ObjectPtr, innerAngle, outerAngle, outsideVolume);
         }
      
         public virtual int getParameterCount()
         {
            return InternalUnsafeMethods.getParameterCount(ObjectPtr);
         }
      
         public virtual void addParameter(SFXParameter parameter)
         {
            InternalUnsafeMethods.addParameter(ObjectPtr, parameter.ObjectPtr);
         }
      
         public virtual void removeParameter(SFXParameter parameter)
         {
            InternalUnsafeMethods.removeParameter(ObjectPtr, parameter.ObjectPtr);
         }
      
         public virtual SFXParameter getParameter(int index)
         {
            return new SFXParameter(InternalUnsafeMethods.getParameter(ObjectPtr, index));
         }
      
         public virtual void addMarker(string name, float pos)
         {
            InternalUnsafeMethods.addMarker(ObjectPtr, name, pos);
         }
      
      
      #endregion


      #region Properties
      
      
         public SFXDescription Description
         {
         	get { return Sim.FindObject<SFXDescription>(getFieldValue("Description")); }
         	set { setFieldValue("Description", value.getId().ToString()); }
         }
      
         public string StatusCallback
         {
         	get { return getFieldValue("StatusCallback"); }
         	set { setFieldValue("StatusCallback", value); }
         }
      
      
      #endregion

	}
}