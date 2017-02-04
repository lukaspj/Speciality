using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ShapeBase : GameBase
	{
		public ShapeBase(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ShapeBase(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ShapeBase(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ShapeBase(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ShapeBase(SimObject pObj) : base(pObj)
		{
		}

		public ShapeBase(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ShapeBase_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setHidden(IntPtr thisPtr, bool show);
         private static _setHidden _setHiddenFunc;
         internal static void setHidden(IntPtr thisPtr, bool show)
         {
         	if (_setHiddenFunc == null)
         	{
         		_setHiddenFunc =
         			(_setHidden)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setHidden"), typeof(_setHidden));
         	}
         
         	 _setHiddenFunc(thisPtr, show);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isHidden(IntPtr thisPtr);
         private static _isHidden _isHiddenFunc;
         internal static bool isHidden(IntPtr thisPtr)
         {
         	if (_isHiddenFunc == null)
         	{
         		_isHiddenFunc =
         			(_isHidden)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_isHidden"), typeof(_isHidden));
         	}
         
         	return  _isHiddenFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _playAudio(IntPtr thisPtr, int slot, IntPtr track);
         private static _playAudio _playAudioFunc;
         internal static bool playAudio(IntPtr thisPtr, int slot, IntPtr track)
         {
         	if (_playAudioFunc == null)
         	{
         		_playAudioFunc =
         			(_playAudio)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_playAudio"), typeof(_playAudio));
         	}
         
         	return  _playAudioFunc(thisPtr, slot, track);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _stopAudio(IntPtr thisPtr, int slot);
         private static _stopAudio _stopAudioFunc;
         internal static bool stopAudio(IntPtr thisPtr, int slot)
         {
         	if (_stopAudioFunc == null)
         	{
         		_stopAudioFunc =
         			(_stopAudio)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_stopAudio"), typeof(_stopAudio));
         	}
         
         	return  _stopAudioFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _playThread(IntPtr thisPtr, int slot, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _playThread _playThreadFunc;
         internal static bool playThread(IntPtr thisPtr, int slot, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_playThreadFunc == null)
         	{
         		_playThreadFunc =
         			(_playThread)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_playThread"), typeof(_playThread));
         	}
         
         	return  _playThreadFunc(thisPtr, slot, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setThreadDir(IntPtr thisPtr, int slot, bool fwd);
         private static _setThreadDir _setThreadDirFunc;
         internal static bool setThreadDir(IntPtr thisPtr, int slot, bool fwd)
         {
         	if (_setThreadDirFunc == null)
         	{
         		_setThreadDirFunc =
         			(_setThreadDir)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setThreadDir"), typeof(_setThreadDir));
         	}
         
         	return  _setThreadDirFunc(thisPtr, slot, fwd);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setThreadTimeScale(IntPtr thisPtr, int slot, float scale);
         private static _setThreadTimeScale _setThreadTimeScaleFunc;
         internal static bool setThreadTimeScale(IntPtr thisPtr, int slot, float scale)
         {
         	if (_setThreadTimeScaleFunc == null)
         	{
         		_setThreadTimeScaleFunc =
         			(_setThreadTimeScale)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setThreadTimeScale"), typeof(_setThreadTimeScale));
         	}
         
         	return  _setThreadTimeScaleFunc(thisPtr, slot, scale);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setThreadPosition(IntPtr thisPtr, int slot, float pos);
         private static _setThreadPosition _setThreadPositionFunc;
         internal static bool setThreadPosition(IntPtr thisPtr, int slot, float pos)
         {
         	if (_setThreadPositionFunc == null)
         	{
         		_setThreadPositionFunc =
         			(_setThreadPosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setThreadPosition"), typeof(_setThreadPosition));
         	}
         
         	return  _setThreadPositionFunc(thisPtr, slot, pos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _stopThread(IntPtr thisPtr, int slot);
         private static _stopThread _stopThreadFunc;
         internal static bool stopThread(IntPtr thisPtr, int slot)
         {
         	if (_stopThreadFunc == null)
         	{
         		_stopThreadFunc =
         			(_stopThread)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_stopThread"), typeof(_stopThread));
         	}
         
         	return  _stopThreadFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _destroyThread(IntPtr thisPtr, int slot);
         private static _destroyThread _destroyThreadFunc;
         internal static bool destroyThread(IntPtr thisPtr, int slot)
         {
         	if (_destroyThreadFunc == null)
         	{
         		_destroyThreadFunc =
         			(_destroyThread)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_destroyThread"), typeof(_destroyThread));
         	}
         
         	return  _destroyThreadFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _pauseThread(IntPtr thisPtr, int slot);
         private static _pauseThread _pauseThreadFunc;
         internal static bool pauseThread(IntPtr thisPtr, int slot)
         {
         	if (_pauseThreadFunc == null)
         	{
         		_pauseThreadFunc =
         			(_pauseThread)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_pauseThread"), typeof(_pauseThread));
         	}
         
         	return  _pauseThreadFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _mountImage(IntPtr thisPtr, IntPtr image, int slot, bool loaded, [MarshalAs(UnmanagedType.LPWStr)]string skinTag);
         private static _mountImage _mountImageFunc;
         internal static bool mountImage(IntPtr thisPtr, IntPtr image, int slot, bool loaded, [MarshalAs(UnmanagedType.LPWStr)]string skinTag)
         {
         	if (_mountImageFunc == null)
         	{
         		_mountImageFunc =
         			(_mountImage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_mountImage"), typeof(_mountImage));
         	}
         
         	return  _mountImageFunc(thisPtr, image, slot, loaded, skinTag);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _unmountImage(IntPtr thisPtr, int slot);
         private static _unmountImage _unmountImageFunc;
         internal static bool unmountImage(IntPtr thisPtr, int slot)
         {
         	if (_unmountImageFunc == null)
         	{
         		_unmountImageFunc =
         			(_unmountImage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_unmountImage"), typeof(_unmountImage));
         	}
         
         	return  _unmountImageFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getMountedImage(IntPtr thisPtr, int slot);
         private static _getMountedImage _getMountedImageFunc;
         internal static int getMountedImage(IntPtr thisPtr, int slot)
         {
         	if (_getMountedImageFunc == null)
         	{
         		_getMountedImageFunc =
         			(_getMountedImage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getMountedImage"), typeof(_getMountedImage));
         	}
         
         	return  _getMountedImageFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getPendingImage(IntPtr thisPtr, int slot);
         private static _getPendingImage _getPendingImageFunc;
         internal static int getPendingImage(IntPtr thisPtr, int slot)
         {
         	if (_getPendingImageFunc == null)
         	{
         		_getPendingImageFunc =
         			(_getPendingImage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getPendingImage"), typeof(_getPendingImage));
         	}
         
         	return  _getPendingImageFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isImageFiring(IntPtr thisPtr, int slot);
         private static _isImageFiring _isImageFiringFunc;
         internal static bool isImageFiring(IntPtr thisPtr, int slot)
         {
         	if (_isImageFiringFunc == null)
         	{
         		_isImageFiringFunc =
         			(_isImageFiring)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_isImageFiring"), typeof(_isImageFiring));
         	}
         
         	return  _isImageFiringFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isImageMounted(IntPtr thisPtr, IntPtr image);
         private static _isImageMounted _isImageMountedFunc;
         internal static bool isImageMounted(IntPtr thisPtr, IntPtr image)
         {
         	if (_isImageMountedFunc == null)
         	{
         		_isImageMountedFunc =
         			(_isImageMounted)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_isImageMounted"), typeof(_isImageMounted));
         	}
         
         	return  _isImageMountedFunc(thisPtr, image);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getMountSlot(IntPtr thisPtr, IntPtr image);
         private static _getMountSlot _getMountSlotFunc;
         internal static int getMountSlot(IntPtr thisPtr, IntPtr image)
         {
         	if (_getMountSlotFunc == null)
         	{
         		_getMountSlotFunc =
         			(_getMountSlot)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getMountSlot"), typeof(_getMountSlot));
         	}
         
         	return  _getMountSlotFunc(thisPtr, image);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getImageSkinTag(IntPtr thisPtr, int slot);
         private static _getImageSkinTag _getImageSkinTagFunc;
         internal static int getImageSkinTag(IntPtr thisPtr, int slot)
         {
         	if (_getImageSkinTagFunc == null)
         	{
         		_getImageSkinTagFunc =
         			(_getImageSkinTag)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getImageSkinTag"), typeof(_getImageSkinTag));
         	}
         
         	return  _getImageSkinTagFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getImageState(IntPtr thisPtr, int slot);
         private static _getImageState _getImageStateFunc;
         internal static IntPtr getImageState(IntPtr thisPtr, int slot)
         {
         	if (_getImageStateFunc == null)
         	{
         		_getImageStateFunc =
         			(_getImageState)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getImageState"), typeof(_getImageState));
         	}
         
         	return  _getImageStateFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _hasImageState(IntPtr thisPtr, int slot, [MarshalAs(UnmanagedType.LPWStr)]string state);
         private static _hasImageState _hasImageStateFunc;
         internal static bool hasImageState(IntPtr thisPtr, int slot, [MarshalAs(UnmanagedType.LPWStr)]string state)
         {
         	if (_hasImageStateFunc == null)
         	{
         		_hasImageStateFunc =
         			(_hasImageState)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_hasImageState"), typeof(_hasImageState));
         	}
         
         	return  _hasImageStateFunc(thisPtr, slot, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getImageTrigger(IntPtr thisPtr, int slot);
         private static _getImageTrigger _getImageTriggerFunc;
         internal static bool getImageTrigger(IntPtr thisPtr, int slot)
         {
         	if (_getImageTriggerFunc == null)
         	{
         		_getImageTriggerFunc =
         			(_getImageTrigger)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getImageTrigger"), typeof(_getImageTrigger));
         	}
         
         	return  _getImageTriggerFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setImageTrigger(IntPtr thisPtr, int slot, bool state);
         private static _setImageTrigger _setImageTriggerFunc;
         internal static bool setImageTrigger(IntPtr thisPtr, int slot, bool state)
         {
         	if (_setImageTriggerFunc == null)
         	{
         		_setImageTriggerFunc =
         			(_setImageTrigger)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setImageTrigger"), typeof(_setImageTrigger));
         	}
         
         	return  _setImageTriggerFunc(thisPtr, slot, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getImageGenericTrigger(IntPtr thisPtr, int slot, int trigger);
         private static _getImageGenericTrigger _getImageGenericTriggerFunc;
         internal static bool getImageGenericTrigger(IntPtr thisPtr, int slot, int trigger)
         {
         	if (_getImageGenericTriggerFunc == null)
         	{
         		_getImageGenericTriggerFunc =
         			(_getImageGenericTrigger)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getImageGenericTrigger"), typeof(_getImageGenericTrigger));
         	}
         
         	return  _getImageGenericTriggerFunc(thisPtr, slot, trigger);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _setImageGenericTrigger(IntPtr thisPtr, int slot, int trigger, bool state);
         private static _setImageGenericTrigger _setImageGenericTriggerFunc;
         internal static int setImageGenericTrigger(IntPtr thisPtr, int slot, int trigger, bool state)
         {
         	if (_setImageGenericTriggerFunc == null)
         	{
         		_setImageGenericTriggerFunc =
         			(_setImageGenericTrigger)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setImageGenericTrigger"), typeof(_setImageGenericTrigger));
         	}
         
         	return  _setImageGenericTriggerFunc(thisPtr, slot, trigger, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getImageAltTrigger(IntPtr thisPtr, int slot);
         private static _getImageAltTrigger _getImageAltTriggerFunc;
         internal static bool getImageAltTrigger(IntPtr thisPtr, int slot)
         {
         	if (_getImageAltTriggerFunc == null)
         	{
         		_getImageAltTriggerFunc =
         			(_getImageAltTrigger)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getImageAltTrigger"), typeof(_getImageAltTrigger));
         	}
         
         	return  _getImageAltTriggerFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setImageAltTrigger(IntPtr thisPtr, int slot, bool state);
         private static _setImageAltTrigger _setImageAltTriggerFunc;
         internal static bool setImageAltTrigger(IntPtr thisPtr, int slot, bool state)
         {
         	if (_setImageAltTriggerFunc == null)
         	{
         		_setImageAltTriggerFunc =
         			(_setImageAltTrigger)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setImageAltTrigger"), typeof(_setImageAltTrigger));
         	}
         
         	return  _setImageAltTriggerFunc(thisPtr, slot, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getImageAmmo(IntPtr thisPtr, int slot);
         private static _getImageAmmo _getImageAmmoFunc;
         internal static bool getImageAmmo(IntPtr thisPtr, int slot)
         {
         	if (_getImageAmmoFunc == null)
         	{
         		_getImageAmmoFunc =
         			(_getImageAmmo)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getImageAmmo"), typeof(_getImageAmmo));
         	}
         
         	return  _getImageAmmoFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setImageAmmo(IntPtr thisPtr, int slot, bool state);
         private static _setImageAmmo _setImageAmmoFunc;
         internal static bool setImageAmmo(IntPtr thisPtr, int slot, bool state)
         {
         	if (_setImageAmmoFunc == null)
         	{
         		_setImageAmmoFunc =
         			(_setImageAmmo)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setImageAmmo"), typeof(_setImageAmmo));
         	}
         
         	return  _setImageAmmoFunc(thisPtr, slot, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getImageLoaded(IntPtr thisPtr, int slot);
         private static _getImageLoaded _getImageLoadedFunc;
         internal static bool getImageLoaded(IntPtr thisPtr, int slot)
         {
         	if (_getImageLoadedFunc == null)
         	{
         		_getImageLoadedFunc =
         			(_getImageLoaded)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getImageLoaded"), typeof(_getImageLoaded));
         	}
         
         	return  _getImageLoadedFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setImageLoaded(IntPtr thisPtr, int slot, bool state);
         private static _setImageLoaded _setImageLoadedFunc;
         internal static bool setImageLoaded(IntPtr thisPtr, int slot, bool state)
         {
         	if (_setImageLoadedFunc == null)
         	{
         		_setImageLoadedFunc =
         			(_setImageLoaded)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setImageLoaded"), typeof(_setImageLoaded));
         	}
         
         	return  _setImageLoadedFunc(thisPtr, slot, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getImageTarget(IntPtr thisPtr, int slot);
         private static _getImageTarget _getImageTargetFunc;
         internal static bool getImageTarget(IntPtr thisPtr, int slot)
         {
         	if (_getImageTargetFunc == null)
         	{
         		_getImageTargetFunc =
         			(_getImageTarget)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getImageTarget"), typeof(_getImageTarget));
         	}
         
         	return  _getImageTargetFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setImageTarget(IntPtr thisPtr, int slot, bool state);
         private static _setImageTarget _setImageTargetFunc;
         internal static bool setImageTarget(IntPtr thisPtr, int slot, bool state)
         {
         	if (_setImageTargetFunc == null)
         	{
         		_setImageTargetFunc =
         			(_setImageTarget)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setImageTarget"), typeof(_setImageTarget));
         	}
         
         	return  _setImageTargetFunc(thisPtr, slot, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getImageScriptAnimPrefix(IntPtr thisPtr, int slot);
         private static _getImageScriptAnimPrefix _getImageScriptAnimPrefixFunc;
         internal static IntPtr getImageScriptAnimPrefix(IntPtr thisPtr, int slot)
         {
         	if (_getImageScriptAnimPrefixFunc == null)
         	{
         		_getImageScriptAnimPrefixFunc =
         			(_getImageScriptAnimPrefix)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getImageScriptAnimPrefix"), typeof(_getImageScriptAnimPrefix));
         	}
         
         	return  _getImageScriptAnimPrefixFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setImageScriptAnimPrefix(IntPtr thisPtr, int slot, [MarshalAs(UnmanagedType.LPWStr)]string prefix);
         private static _setImageScriptAnimPrefix _setImageScriptAnimPrefixFunc;
         internal static void setImageScriptAnimPrefix(IntPtr thisPtr, int slot, [MarshalAs(UnmanagedType.LPWStr)]string prefix)
         {
         	if (_setImageScriptAnimPrefixFunc == null)
         	{
         		_setImageScriptAnimPrefixFunc =
         			(_setImageScriptAnimPrefix)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setImageScriptAnimPrefix"), typeof(_setImageScriptAnimPrefix));
         	}
         
         	 _setImageScriptAnimPrefixFunc(thisPtr, slot, prefix);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getMuzzleVector(IntPtr thisPtr, int slot);
         private static _getMuzzleVector _getMuzzleVectorFunc;
         internal static InternalPoint3FStruct getMuzzleVector(IntPtr thisPtr, int slot)
         {
         	if (_getMuzzleVectorFunc == null)
         	{
         		_getMuzzleVectorFunc =
         			(_getMuzzleVector)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getMuzzleVector"), typeof(_getMuzzleVector));
         	}
         
         	return  _getMuzzleVectorFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getMuzzlePoint(IntPtr thisPtr, int slot);
         private static _getMuzzlePoint _getMuzzlePointFunc;
         internal static InternalPoint3FStruct getMuzzlePoint(IntPtr thisPtr, int slot)
         {
         	if (_getMuzzlePointFunc == null)
         	{
         		_getMuzzlePointFunc =
         			(_getMuzzlePoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getMuzzlePoint"), typeof(_getMuzzlePoint));
         	}
         
         	return  _getMuzzlePointFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalTransformFStruct _getSlotTransform(IntPtr thisPtr, int slot);
         private static _getSlotTransform _getSlotTransformFunc;
         internal static InternalTransformFStruct getSlotTransform(IntPtr thisPtr, int slot)
         {
         	if (_getSlotTransformFunc == null)
         	{
         		_getSlotTransformFunc =
         			(_getSlotTransform)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getSlotTransform"), typeof(_getSlotTransform));
         	}
         
         	return  _getSlotTransformFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getAIRepairPoint(IntPtr thisPtr);
         private static _getAIRepairPoint _getAIRepairPointFunc;
         internal static InternalPoint3FStruct getAIRepairPoint(IntPtr thisPtr)
         {
         	if (_getAIRepairPointFunc == null)
         	{
         		_getAIRepairPointFunc =
         			(_getAIRepairPoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getAIRepairPoint"), typeof(_getAIRepairPoint));
         	}
         
         	return  _getAIRepairPointFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getVelocity(IntPtr thisPtr);
         private static _getVelocity _getVelocityFunc;
         internal static InternalPoint3FStruct getVelocity(IntPtr thisPtr)
         {
         	if (_getVelocityFunc == null)
         	{
         		_getVelocityFunc =
         			(_getVelocity)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getVelocity"), typeof(_getVelocity));
         	}
         
         	return  _getVelocityFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setVelocity(IntPtr thisPtr, InternalPoint3FStruct vel);
         private static _setVelocity _setVelocityFunc;
         internal static bool setVelocity(IntPtr thisPtr, InternalPoint3FStruct vel)
         {
         	if (_setVelocityFunc == null)
         	{
         		_setVelocityFunc =
         			(_setVelocity)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setVelocity"), typeof(_setVelocity));
         	}
         
         	return  _setVelocityFunc(thisPtr, vel);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _applyImpulse(IntPtr thisPtr, InternalPoint3FStruct pos, InternalPoint3FStruct vec);
         private static _applyImpulse _applyImpulseFunc;
         internal static bool applyImpulse(IntPtr thisPtr, InternalPoint3FStruct pos, InternalPoint3FStruct vec)
         {
         	if (_applyImpulseFunc == null)
         	{
         		_applyImpulseFunc =
         			(_applyImpulse)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_applyImpulse"), typeof(_applyImpulse));
         	}
         
         	return  _applyImpulseFunc(thisPtr, pos, vec);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getEyeVector(IntPtr thisPtr);
         private static _getEyeVector _getEyeVectorFunc;
         internal static InternalPoint3FStruct getEyeVector(IntPtr thisPtr)
         {
         	if (_getEyeVectorFunc == null)
         	{
         		_getEyeVectorFunc =
         			(_getEyeVector)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getEyeVector"), typeof(_getEyeVector));
         	}
         
         	return  _getEyeVectorFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getEyePoint(IntPtr thisPtr);
         private static _getEyePoint _getEyePointFunc;
         internal static InternalPoint3FStruct getEyePoint(IntPtr thisPtr)
         {
         	if (_getEyePointFunc == null)
         	{
         		_getEyePointFunc =
         			(_getEyePoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getEyePoint"), typeof(_getEyePoint));
         	}
         
         	return  _getEyePointFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalTransformFStruct _getEyeTransform(IntPtr thisPtr);
         private static _getEyeTransform _getEyeTransformFunc;
         internal static InternalTransformFStruct getEyeTransform(IntPtr thisPtr)
         {
         	if (_getEyeTransformFunc == null)
         	{
         		_getEyeTransformFunc =
         			(_getEyeTransform)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getEyeTransform"), typeof(_getEyeTransform));
         	}
         
         	return  _getEyeTransformFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getLookAtPoint(IntPtr thisPtr, float distance, uint typeMask);
         private static _getLookAtPoint _getLookAtPointFunc;
         internal static IntPtr getLookAtPoint(IntPtr thisPtr, float distance, uint typeMask)
         {
         	if (_getLookAtPointFunc == null)
         	{
         		_getLookAtPointFunc =
         			(_getLookAtPoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getLookAtPoint"), typeof(_getLookAtPoint));
         	}
         
         	return  _getLookAtPointFunc(thisPtr, distance, typeMask);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setEnergyLevel(IntPtr thisPtr, float level);
         private static _setEnergyLevel _setEnergyLevelFunc;
         internal static void setEnergyLevel(IntPtr thisPtr, float level)
         {
         	if (_setEnergyLevelFunc == null)
         	{
         		_setEnergyLevelFunc =
         			(_setEnergyLevel)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setEnergyLevel"), typeof(_setEnergyLevel));
         	}
         
         	 _setEnergyLevelFunc(thisPtr, level);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getEnergyLevel(IntPtr thisPtr);
         private static _getEnergyLevel _getEnergyLevelFunc;
         internal static float getEnergyLevel(IntPtr thisPtr)
         {
         	if (_getEnergyLevelFunc == null)
         	{
         		_getEnergyLevelFunc =
         			(_getEnergyLevel)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getEnergyLevel"), typeof(_getEnergyLevel));
         	}
         
         	return  _getEnergyLevelFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getEnergyPercent(IntPtr thisPtr);
         private static _getEnergyPercent _getEnergyPercentFunc;
         internal static float getEnergyPercent(IntPtr thisPtr)
         {
         	if (_getEnergyPercentFunc == null)
         	{
         		_getEnergyPercentFunc =
         			(_getEnergyPercent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getEnergyPercent"), typeof(_getEnergyPercent));
         	}
         
         	return  _getEnergyPercentFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setDamageLevel(IntPtr thisPtr, float level);
         private static _setDamageLevel _setDamageLevelFunc;
         internal static void setDamageLevel(IntPtr thisPtr, float level)
         {
         	if (_setDamageLevelFunc == null)
         	{
         		_setDamageLevelFunc =
         			(_setDamageLevel)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setDamageLevel"), typeof(_setDamageLevel));
         	}
         
         	 _setDamageLevelFunc(thisPtr, level);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getDamageLevel(IntPtr thisPtr);
         private static _getDamageLevel _getDamageLevelFunc;
         internal static float getDamageLevel(IntPtr thisPtr)
         {
         	if (_getDamageLevelFunc == null)
         	{
         		_getDamageLevelFunc =
         			(_getDamageLevel)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getDamageLevel"), typeof(_getDamageLevel));
         	}
         
         	return  _getDamageLevelFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getDamagePercent(IntPtr thisPtr);
         private static _getDamagePercent _getDamagePercentFunc;
         internal static float getDamagePercent(IntPtr thisPtr)
         {
         	if (_getDamagePercentFunc == null)
         	{
         		_getDamagePercentFunc =
         			(_getDamagePercent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getDamagePercent"), typeof(_getDamagePercent));
         	}
         
         	return  _getDamagePercentFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getMaxDamage(IntPtr thisPtr);
         private static _getMaxDamage _getMaxDamageFunc;
         internal static float getMaxDamage(IntPtr thisPtr)
         {
         	if (_getMaxDamageFunc == null)
         	{
         		_getMaxDamageFunc =
         			(_getMaxDamage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getMaxDamage"), typeof(_getMaxDamage));
         	}
         
         	return  _getMaxDamageFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setDamageState(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string state);
         private static _setDamageState _setDamageStateFunc;
         internal static bool setDamageState(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string state)
         {
         	if (_setDamageStateFunc == null)
         	{
         		_setDamageStateFunc =
         			(_setDamageState)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setDamageState"), typeof(_setDamageState));
         	}
         
         	return  _setDamageStateFunc(thisPtr, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getDamageState(IntPtr thisPtr);
         private static _getDamageState _getDamageStateFunc;
         internal static IntPtr getDamageState(IntPtr thisPtr)
         {
         	if (_getDamageStateFunc == null)
         	{
         		_getDamageStateFunc =
         			(_getDamageState)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getDamageState"), typeof(_getDamageState));
         	}
         
         	return  _getDamageStateFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isDestroyed(IntPtr thisPtr);
         private static _isDestroyed _isDestroyedFunc;
         internal static bool isDestroyed(IntPtr thisPtr)
         {
         	if (_isDestroyedFunc == null)
         	{
         		_isDestroyedFunc =
         			(_isDestroyed)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_isDestroyed"), typeof(_isDestroyed));
         	}
         
         	return  _isDestroyedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isDisabled(IntPtr thisPtr);
         private static _isDisabled _isDisabledFunc;
         internal static bool isDisabled(IntPtr thisPtr)
         {
         	if (_isDisabledFunc == null)
         	{
         		_isDisabledFunc =
         			(_isDisabled)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_isDisabled"), typeof(_isDisabled));
         	}
         
         	return  _isDisabledFunc(thisPtr);
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
         				"fnShapeBase_isEnabled"), typeof(_isEnabled));
         	}
         
         	return  _isEnabledFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _blowUp(IntPtr thisPtr);
         private static _blowUp _blowUpFunc;
         internal static void blowUp(IntPtr thisPtr)
         {
         	if (_blowUpFunc == null)
         	{
         		_blowUpFunc =
         			(_blowUp)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_blowUp"), typeof(_blowUp));
         	}
         
         	 _blowUpFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _applyDamage(IntPtr thisPtr, float amount);
         private static _applyDamage _applyDamageFunc;
         internal static void applyDamage(IntPtr thisPtr, float amount)
         {
         	if (_applyDamageFunc == null)
         	{
         		_applyDamageFunc =
         			(_applyDamage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_applyDamage"), typeof(_applyDamage));
         	}
         
         	 _applyDamageFunc(thisPtr, amount);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _applyRepair(IntPtr thisPtr, float amount);
         private static _applyRepair _applyRepairFunc;
         internal static void applyRepair(IntPtr thisPtr, float amount)
         {
         	if (_applyRepairFunc == null)
         	{
         		_applyRepairFunc =
         			(_applyRepair)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_applyRepair"), typeof(_applyRepair));
         	}
         
         	 _applyRepairFunc(thisPtr, amount);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setRepairRate(IntPtr thisPtr, float rate);
         private static _setRepairRate _setRepairRateFunc;
         internal static void setRepairRate(IntPtr thisPtr, float rate)
         {
         	if (_setRepairRateFunc == null)
         	{
         		_setRepairRateFunc =
         			(_setRepairRate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setRepairRate"), typeof(_setRepairRate));
         	}
         
         	 _setRepairRateFunc(thisPtr, rate);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getRepairRate(IntPtr thisPtr);
         private static _getRepairRate _getRepairRateFunc;
         internal static float getRepairRate(IntPtr thisPtr)
         {
         	if (_getRepairRateFunc == null)
         	{
         		_getRepairRateFunc =
         			(_getRepairRate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getRepairRate"), typeof(_getRepairRate));
         	}
         
         	return  _getRepairRateFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setRechargeRate(IntPtr thisPtr, float rate);
         private static _setRechargeRate _setRechargeRateFunc;
         internal static void setRechargeRate(IntPtr thisPtr, float rate)
         {
         	if (_setRechargeRateFunc == null)
         	{
         		_setRechargeRateFunc =
         			(_setRechargeRate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setRechargeRate"), typeof(_setRechargeRate));
         	}
         
         	 _setRechargeRateFunc(thisPtr, rate);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getRechargeRate(IntPtr thisPtr);
         private static _getRechargeRate _getRechargeRateFunc;
         internal static float getRechargeRate(IntPtr thisPtr)
         {
         	if (_getRechargeRateFunc == null)
         	{
         		_getRechargeRateFunc =
         			(_getRechargeRate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getRechargeRate"), typeof(_getRechargeRate));
         	}
         
         	return  _getRechargeRateFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getControllingClient(IntPtr thisPtr);
         private static _getControllingClient _getControllingClientFunc;
         internal static int getControllingClient(IntPtr thisPtr)
         {
         	if (_getControllingClientFunc == null)
         	{
         		_getControllingClientFunc =
         			(_getControllingClient)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getControllingClient"), typeof(_getControllingClient));
         	}
         
         	return  _getControllingClientFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getControllingObject(IntPtr thisPtr);
         private static _getControllingObject _getControllingObjectFunc;
         internal static int getControllingObject(IntPtr thisPtr)
         {
         	if (_getControllingObjectFunc == null)
         	{
         		_getControllingObjectFunc =
         			(_getControllingObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getControllingObject"), typeof(_getControllingObject));
         	}
         
         	return  _getControllingObjectFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _canCloak(IntPtr thisPtr);
         private static _canCloak _canCloakFunc;
         internal static bool canCloak(IntPtr thisPtr)
         {
         	if (_canCloakFunc == null)
         	{
         		_canCloakFunc =
         			(_canCloak)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_canCloak"), typeof(_canCloak));
         	}
         
         	return  _canCloakFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setCloaked(IntPtr thisPtr, bool cloak);
         private static _setCloaked _setCloakedFunc;
         internal static void setCloaked(IntPtr thisPtr, bool cloak)
         {
         	if (_setCloakedFunc == null)
         	{
         		_setCloakedFunc =
         			(_setCloaked)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setCloaked"), typeof(_setCloaked));
         	}
         
         	 _setCloakedFunc(thisPtr, cloak);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isCloaked(IntPtr thisPtr);
         private static _isCloaked _isCloakedFunc;
         internal static bool isCloaked(IntPtr thisPtr)
         {
         	if (_isCloakedFunc == null)
         	{
         		_isCloakedFunc =
         			(_isCloaked)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_isCloaked"), typeof(_isCloaked));
         	}
         
         	return  _isCloakedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setDamageFlash(IntPtr thisPtr, float level);
         private static _setDamageFlash _setDamageFlashFunc;
         internal static void setDamageFlash(IntPtr thisPtr, float level)
         {
         	if (_setDamageFlashFunc == null)
         	{
         		_setDamageFlashFunc =
         			(_setDamageFlash)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setDamageFlash"), typeof(_setDamageFlash));
         	}
         
         	 _setDamageFlashFunc(thisPtr, level);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getDamageFlash(IntPtr thisPtr);
         private static _getDamageFlash _getDamageFlashFunc;
         internal static float getDamageFlash(IntPtr thisPtr)
         {
         	if (_getDamageFlashFunc == null)
         	{
         		_getDamageFlashFunc =
         			(_getDamageFlash)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getDamageFlash"), typeof(_getDamageFlash));
         	}
         
         	return  _getDamageFlashFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setWhiteOut(IntPtr thisPtr, float level);
         private static _setWhiteOut _setWhiteOutFunc;
         internal static void setWhiteOut(IntPtr thisPtr, float level)
         {
         	if (_setWhiteOutFunc == null)
         	{
         		_setWhiteOutFunc =
         			(_setWhiteOut)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setWhiteOut"), typeof(_setWhiteOut));
         	}
         
         	 _setWhiteOutFunc(thisPtr, level);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getWhiteOut(IntPtr thisPtr);
         private static _getWhiteOut _getWhiteOutFunc;
         internal static float getWhiteOut(IntPtr thisPtr)
         {
         	if (_getWhiteOutFunc == null)
         	{
         		_getWhiteOutFunc =
         			(_getWhiteOut)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getWhiteOut"), typeof(_getWhiteOut));
         	}
         
         	return  _getWhiteOutFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getDefaultCameraFov(IntPtr thisPtr);
         private static _getDefaultCameraFov _getDefaultCameraFovFunc;
         internal static float getDefaultCameraFov(IntPtr thisPtr)
         {
         	if (_getDefaultCameraFovFunc == null)
         	{
         		_getDefaultCameraFovFunc =
         			(_getDefaultCameraFov)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getDefaultCameraFov"), typeof(_getDefaultCameraFov));
         	}
         
         	return  _getDefaultCameraFovFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getCameraFov(IntPtr thisPtr);
         private static _getCameraFov _getCameraFovFunc;
         internal static float getCameraFov(IntPtr thisPtr)
         {
         	if (_getCameraFovFunc == null)
         	{
         		_getCameraFovFunc =
         			(_getCameraFov)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getCameraFov"), typeof(_getCameraFov));
         	}
         
         	return  _getCameraFovFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setCameraFov(IntPtr thisPtr, float fov);
         private static _setCameraFov _setCameraFovFunc;
         internal static void setCameraFov(IntPtr thisPtr, float fov)
         {
         	if (_setCameraFovFunc == null)
         	{
         		_setCameraFovFunc =
         			(_setCameraFov)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setCameraFov"), typeof(_setCameraFov));
         	}
         
         	 _setCameraFovFunc(thisPtr, fov);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _startFade(IntPtr thisPtr, int time, int delay, bool fadeOut);
         private static _startFade _startFadeFunc;
         internal static void startFade(IntPtr thisPtr, int time, int delay, bool fadeOut)
         {
         	if (_startFadeFunc == null)
         	{
         		_startFadeFunc =
         			(_startFade)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_startFade"), typeof(_startFade));
         	}
         
         	 _startFadeFunc(thisPtr, time, delay, fadeOut);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setDamageVector(IntPtr thisPtr, InternalPoint3FStruct vec);
         private static _setDamageVector _setDamageVectorFunc;
         internal static void setDamageVector(IntPtr thisPtr, InternalPoint3FStruct vec)
         {
         	if (_setDamageVectorFunc == null)
         	{
         		_setDamageVectorFunc =
         			(_setDamageVector)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setDamageVector"), typeof(_setDamageVector));
         	}
         
         	 _setDamageVectorFunc(thisPtr, vec);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setShapeName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _setShapeName _setShapeNameFunc;
         internal static void setShapeName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_setShapeNameFunc == null)
         	{
         		_setShapeNameFunc =
         			(_setShapeName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setShapeName"), typeof(_setShapeName));
         	}
         
         	 _setShapeNameFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getShapeName(IntPtr thisPtr);
         private static _getShapeName _getShapeNameFunc;
         internal static IntPtr getShapeName(IntPtr thisPtr)
         {
         	if (_getShapeNameFunc == null)
         	{
         		_getShapeNameFunc =
         			(_getShapeName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getShapeName"), typeof(_getShapeName));
         	}
         
         	return  _getShapeNameFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSkinName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _setSkinName _setSkinNameFunc;
         internal static void setSkinName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_setSkinNameFunc == null)
         	{
         		_setSkinNameFunc =
         			(_setSkinName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setSkinName"), typeof(_setSkinName));
         	}
         
         	 _setSkinNameFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getSkinName(IntPtr thisPtr);
         private static _getSkinName _getSkinNameFunc;
         internal static IntPtr getSkinName(IntPtr thisPtr)
         {
         	if (_getSkinNameFunc == null)
         	{
         		_getSkinNameFunc =
         			(_getSkinName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getSkinName"), typeof(_getSkinName));
         	}
         
         	return  _getSkinNameFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setAllMeshesHidden(IntPtr thisPtr, bool hide);
         private static _setAllMeshesHidden _setAllMeshesHiddenFunc;
         internal static void setAllMeshesHidden(IntPtr thisPtr, bool hide)
         {
         	if (_setAllMeshesHiddenFunc == null)
         	{
         		_setAllMeshesHiddenFunc =
         			(_setAllMeshesHidden)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setAllMeshesHidden"), typeof(_setAllMeshesHidden));
         	}
         
         	 _setAllMeshesHiddenFunc(thisPtr, hide);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMeshHidden(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, bool hide);
         private static _setMeshHidden _setMeshHiddenFunc;
         internal static void setMeshHidden(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, bool hide)
         {
         	if (_setMeshHiddenFunc == null)
         	{
         		_setMeshHiddenFunc =
         			(_setMeshHidden)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_setMeshHidden"), typeof(_setMeshHidden));
         	}
         
         	 _setMeshHiddenFunc(thisPtr, name, hide);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dumpMeshVisibility(IntPtr thisPtr);
         private static _dumpMeshVisibility _dumpMeshVisibilityFunc;
         internal static void dumpMeshVisibility(IntPtr thisPtr)
         {
         	if (_dumpMeshVisibilityFunc == null)
         	{
         		_dumpMeshVisibilityFunc =
         			(_dumpMeshVisibility)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_dumpMeshVisibility"), typeof(_dumpMeshVisibility));
         	}
         
         	 _dumpMeshVisibilityFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getTargetName(IntPtr thisPtr, int index);
         private static _getTargetName _getTargetNameFunc;
         internal static IntPtr getTargetName(IntPtr thisPtr, int index)
         {
         	if (_getTargetNameFunc == null)
         	{
         		_getTargetNameFunc =
         			(_getTargetName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getTargetName"), typeof(_getTargetName));
         	}
         
         	return  _getTargetNameFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getTargetCount(IntPtr thisPtr);
         private static _getTargetCount _getTargetCountFunc;
         internal static int getTargetCount(IntPtr thisPtr)
         {
         	if (_getTargetCountFunc == null)
         	{
         		_getTargetCountFunc =
         			(_getTargetCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getTargetCount"), typeof(_getTargetCount));
         	}
         
         	return  _getTargetCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _changeMaterial(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string mapTo, IntPtr oldMat, IntPtr newMat);
         private static _changeMaterial _changeMaterialFunc;
         internal static void changeMaterial(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string mapTo, IntPtr oldMat, IntPtr newMat)
         {
         	if (_changeMaterialFunc == null)
         	{
         		_changeMaterialFunc =
         			(_changeMaterial)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_changeMaterial"), typeof(_changeMaterial));
         	}
         
         	 _changeMaterialFunc(thisPtr, mapTo, oldMat, newMat);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getModelFile(IntPtr thisPtr);
         private static _getModelFile _getModelFileFunc;
         internal static IntPtr getModelFile(IntPtr thisPtr)
         {
         	if (_getModelFileFunc == null)
         	{
         		_getModelFileFunc =
         			(_getModelFile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBase_getModelFile"), typeof(_getModelFile));
         	}
         
         	return  _getModelFileFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ShapeBase_create();
         private static _ShapeBase_create _ShapeBase_createFunc;
         internal static IntPtr ShapeBase_create()
         {
         	if (_ShapeBase_createFunc == null)
         	{
         		_ShapeBase_createFunc =
         			(_ShapeBase_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ShapeBase_create"), typeof(_ShapeBase_create));
         	}
         
         	return  _ShapeBase_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setHidden(bool show)
         {
            InternalUnsafeMethods.setHidden(ObjectPtr, show);
         }
      
         public virtual bool isHidden()
         {
            return InternalUnsafeMethods.isHidden(ObjectPtr);
         }
      
         public virtual bool playAudio(int slot, SFXTrack track)
         {
            return InternalUnsafeMethods.playAudio(ObjectPtr, slot, track.ObjectPtr);
         }
      
         public virtual bool stopAudio(int slot)
         {
            return InternalUnsafeMethods.stopAudio(ObjectPtr, slot);
         }
      
         public virtual bool playThread(int slot, string name = "")
         {
            return InternalUnsafeMethods.playThread(ObjectPtr, slot, name);
         }
      
         public virtual bool setThreadDir(int slot, bool fwd)
         {
            return InternalUnsafeMethods.setThreadDir(ObjectPtr, slot, fwd);
         }
      
         public virtual bool setThreadTimeScale(int slot, float scale)
         {
            return InternalUnsafeMethods.setThreadTimeScale(ObjectPtr, slot, scale);
         }
      
         public virtual bool setThreadPosition(int slot, float pos)
         {
            return InternalUnsafeMethods.setThreadPosition(ObjectPtr, slot, pos);
         }
      
         public virtual bool stopThread(int slot)
         {
            return InternalUnsafeMethods.stopThread(ObjectPtr, slot);
         }
      
         public virtual bool destroyThread(int slot)
         {
            return InternalUnsafeMethods.destroyThread(ObjectPtr, slot);
         }
      
         public virtual bool pauseThread(int slot)
         {
            return InternalUnsafeMethods.pauseThread(ObjectPtr, slot);
         }
      
         public virtual bool mountImage(ShapeBaseImageData image, int slot, bool loaded = true, string skinTag = "")
         {
            return InternalUnsafeMethods.mountImage(ObjectPtr, image.ObjectPtr, slot, loaded, skinTag);
         }
      
         public virtual bool unmountImage(int slot)
         {
            return InternalUnsafeMethods.unmountImage(ObjectPtr, slot);
         }
      
         public virtual int getMountedImage(int slot)
         {
            return InternalUnsafeMethods.getMountedImage(ObjectPtr, slot);
         }
      
         public virtual int getPendingImage(int slot)
         {
            return InternalUnsafeMethods.getPendingImage(ObjectPtr, slot);
         }
      
         public virtual bool isImageFiring(int slot)
         {
            return InternalUnsafeMethods.isImageFiring(ObjectPtr, slot);
         }
      
         public virtual bool isImageMounted(ShapeBaseImageData image)
         {
            return InternalUnsafeMethods.isImageMounted(ObjectPtr, image.ObjectPtr);
         }
      
         public virtual int getMountSlot(ShapeBaseImageData image)
         {
            return InternalUnsafeMethods.getMountSlot(ObjectPtr, image.ObjectPtr);
         }
      
         public virtual int getImageSkinTag(int slot)
         {
            return InternalUnsafeMethods.getImageSkinTag(ObjectPtr, slot);
         }
      
         public virtual string getImageState(int slot)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getImageState(ObjectPtr, slot));
         }
      
         public virtual bool hasImageState(int slot, string state)
         {
            return InternalUnsafeMethods.hasImageState(ObjectPtr, slot, state);
         }
      
         public virtual bool getImageTrigger(int slot)
         {
            return InternalUnsafeMethods.getImageTrigger(ObjectPtr, slot);
         }
      
         public virtual bool setImageTrigger(int slot, bool state)
         {
            return InternalUnsafeMethods.setImageTrigger(ObjectPtr, slot, state);
         }
      
         public virtual bool getImageGenericTrigger(int slot, int trigger)
         {
            return InternalUnsafeMethods.getImageGenericTrigger(ObjectPtr, slot, trigger);
         }
      
         public virtual int setImageGenericTrigger(int slot, int trigger, bool state)
         {
            return InternalUnsafeMethods.setImageGenericTrigger(ObjectPtr, slot, trigger, state);
         }
      
         public virtual bool getImageAltTrigger(int slot)
         {
            return InternalUnsafeMethods.getImageAltTrigger(ObjectPtr, slot);
         }
      
         public virtual bool setImageAltTrigger(int slot, bool state)
         {
            return InternalUnsafeMethods.setImageAltTrigger(ObjectPtr, slot, state);
         }
      
         public virtual bool getImageAmmo(int slot)
         {
            return InternalUnsafeMethods.getImageAmmo(ObjectPtr, slot);
         }
      
         public virtual bool setImageAmmo(int slot, bool state)
         {
            return InternalUnsafeMethods.setImageAmmo(ObjectPtr, slot, state);
         }
      
         public virtual bool getImageLoaded(int slot)
         {
            return InternalUnsafeMethods.getImageLoaded(ObjectPtr, slot);
         }
      
         public virtual bool setImageLoaded(int slot, bool state)
         {
            return InternalUnsafeMethods.setImageLoaded(ObjectPtr, slot, state);
         }
      
         public virtual bool getImageTarget(int slot)
         {
            return InternalUnsafeMethods.getImageTarget(ObjectPtr, slot);
         }
      
         public virtual bool setImageTarget(int slot, bool state)
         {
            return InternalUnsafeMethods.setImageTarget(ObjectPtr, slot, state);
         }
      
         public virtual string getImageScriptAnimPrefix(int slot)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getImageScriptAnimPrefix(ObjectPtr, slot));
         }
      
         public virtual void setImageScriptAnimPrefix(int slot, string prefix)
         {
            InternalUnsafeMethods.setImageScriptAnimPrefix(ObjectPtr, slot, prefix);
         }
      
         public virtual VectorF getMuzzleVector(int slot)
         {
            return new VectorF(InternalUnsafeMethods.getMuzzleVector(ObjectPtr, slot));
         }
      
         public virtual Point3F getMuzzlePoint(int slot)
         {
            return new Point3F(InternalUnsafeMethods.getMuzzlePoint(ObjectPtr, slot));
         }
      
         public virtual TransformF getSlotTransform(int slot)
         {
            return new TransformF(InternalUnsafeMethods.getSlotTransform(ObjectPtr, slot));
         }
      
         public virtual Point3F getAIRepairPoint()
         {
            return new Point3F(InternalUnsafeMethods.getAIRepairPoint(ObjectPtr));
         }
      
         public virtual VectorF getVelocity()
         {
            return new VectorF(InternalUnsafeMethods.getVelocity(ObjectPtr));
         }
      
         public virtual bool setVelocity(Point3F vel)
         {
            return InternalUnsafeMethods.setVelocity(ObjectPtr, vel.ToStruct());
         }
      
         public virtual bool applyImpulse(Point3F pos, Point3F vec)
         {
            return InternalUnsafeMethods.applyImpulse(ObjectPtr, pos.ToStruct(), vec.ToStruct());
         }
      
         public virtual VectorF getEyeVector()
         {
            return new VectorF(InternalUnsafeMethods.getEyeVector(ObjectPtr));
         }
      
         public virtual Point3F getEyePoint()
         {
            return new Point3F(InternalUnsafeMethods.getEyePoint(ObjectPtr));
         }
      
         public virtual TransformF getEyeTransform()
         {
            return new TransformF(InternalUnsafeMethods.getEyeTransform(ObjectPtr));
         }
      
         public virtual string getLookAtPoint(float distance = 2000, uint typeMask = 0xFFFFFFFF)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getLookAtPoint(ObjectPtr, distance, typeMask));
         }
      
         public virtual void setEnergyLevel(float level)
         {
            InternalUnsafeMethods.setEnergyLevel(ObjectPtr, level);
         }
      
         public virtual float getEnergyLevel()
         {
            return InternalUnsafeMethods.getEnergyLevel(ObjectPtr);
         }
      
         public virtual float getEnergyPercent()
         {
            return InternalUnsafeMethods.getEnergyPercent(ObjectPtr);
         }
      
         public virtual void setDamageLevel(float level)
         {
            InternalUnsafeMethods.setDamageLevel(ObjectPtr, level);
         }
      
         public virtual float getDamageLevel()
         {
            return InternalUnsafeMethods.getDamageLevel(ObjectPtr);
         }
      
         public virtual float getDamagePercent()
         {
            return InternalUnsafeMethods.getDamagePercent(ObjectPtr);
         }
      
         public virtual float getMaxDamage()
         {
            return InternalUnsafeMethods.getMaxDamage(ObjectPtr);
         }
      
         public virtual bool setDamageState(string state)
         {
            return InternalUnsafeMethods.setDamageState(ObjectPtr, state);
         }
      
         public virtual string getDamageState()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getDamageState(ObjectPtr));
         }
      
         public virtual bool isDestroyed()
         {
            return InternalUnsafeMethods.isDestroyed(ObjectPtr);
         }
      
         public virtual bool isDisabled()
         {
            return InternalUnsafeMethods.isDisabled(ObjectPtr);
         }
      
         public virtual bool isEnabled()
         {
            return InternalUnsafeMethods.isEnabled(ObjectPtr);
         }
      
         public virtual void blowUp()
         {
            InternalUnsafeMethods.blowUp(ObjectPtr);
         }
      
         public virtual void applyDamage(float amount)
         {
            InternalUnsafeMethods.applyDamage(ObjectPtr, amount);
         }
      
         public virtual void applyRepair(float amount)
         {
            InternalUnsafeMethods.applyRepair(ObjectPtr, amount);
         }
      
         public virtual void setRepairRate(float rate)
         {
            InternalUnsafeMethods.setRepairRate(ObjectPtr, rate);
         }
      
         public virtual float getRepairRate()
         {
            return InternalUnsafeMethods.getRepairRate(ObjectPtr);
         }
      
         public virtual void setRechargeRate(float rate)
         {
            InternalUnsafeMethods.setRechargeRate(ObjectPtr, rate);
         }
      
         public virtual float getRechargeRate()
         {
            return InternalUnsafeMethods.getRechargeRate(ObjectPtr);
         }
      
         public virtual int getControllingClient()
         {
            return InternalUnsafeMethods.getControllingClient(ObjectPtr);
         }
      
         public virtual int getControllingObject()
         {
            return InternalUnsafeMethods.getControllingObject(ObjectPtr);
         }
      
         public virtual bool canCloak()
         {
            return InternalUnsafeMethods.canCloak(ObjectPtr);
         }
      
         public virtual void setCloaked(bool cloak)
         {
            InternalUnsafeMethods.setCloaked(ObjectPtr, cloak);
         }
      
         public virtual bool isCloaked()
         {
            return InternalUnsafeMethods.isCloaked(ObjectPtr);
         }
      
         public virtual void setDamageFlash(float level)
         {
            InternalUnsafeMethods.setDamageFlash(ObjectPtr, level);
         }
      
         public virtual float getDamageFlash()
         {
            return InternalUnsafeMethods.getDamageFlash(ObjectPtr);
         }
      
         public virtual void setWhiteOut(float level)
         {
            InternalUnsafeMethods.setWhiteOut(ObjectPtr, level);
         }
      
         public virtual float getWhiteOut()
         {
            return InternalUnsafeMethods.getWhiteOut(ObjectPtr);
         }
      
         public virtual float getDefaultCameraFov()
         {
            return InternalUnsafeMethods.getDefaultCameraFov(ObjectPtr);
         }
      
         public virtual float getCameraFov()
         {
            return InternalUnsafeMethods.getCameraFov(ObjectPtr);
         }
      
         public virtual void setCameraFov(float fov)
         {
            InternalUnsafeMethods.setCameraFov(ObjectPtr, fov);
         }
      
         public virtual void startFade(int time, int delay, bool fadeOut)
         {
            InternalUnsafeMethods.startFade(ObjectPtr, time, delay, fadeOut);
         }
      
         public virtual void setDamageVector(Point3F vec)
         {
            InternalUnsafeMethods.setDamageVector(ObjectPtr, vec.ToStruct());
         }
      
         public virtual void setShapeName(string name)
         {
            InternalUnsafeMethods.setShapeName(ObjectPtr, name);
         }
      
         public virtual string getShapeName()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getShapeName(ObjectPtr));
         }
      
         public virtual void setSkinName(string name)
         {
            InternalUnsafeMethods.setSkinName(ObjectPtr, name);
         }
      
         public virtual string getSkinName()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getSkinName(ObjectPtr));
         }
      
         public virtual void setAllMeshesHidden(bool hide)
         {
            InternalUnsafeMethods.setAllMeshesHidden(ObjectPtr, hide);
         }
      
         public virtual void setMeshHidden(string name, bool hide)
         {
            InternalUnsafeMethods.setMeshHidden(ObjectPtr, name, hide);
         }
      
         public virtual void dumpMeshVisibility()
         {
            InternalUnsafeMethods.dumpMeshVisibility(ObjectPtr);
         }
      
         public virtual string getTargetName(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getTargetName(ObjectPtr, index));
         }
      
         public virtual int getTargetCount()
         {
            return InternalUnsafeMethods.getTargetCount(ObjectPtr);
         }
      
         public virtual void changeMaterial(string mapTo, Material oldMat, Material newMat)
         {
            InternalUnsafeMethods.changeMaterial(ObjectPtr, mapTo, oldMat.ObjectPtr, newMat.ObjectPtr);
         }
      
         public virtual string getModelFile()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getModelFile(ObjectPtr));
         }
      
      
      #endregion


      #region Properties
      
      
         public string Skin
         {
         	get { return getFieldValue("Skin"); }
         	set { setFieldValue("Skin", value); }
         }
      
         public bool IsAIControlled
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsAIControlled")); }
         	set { setFieldValue("IsAIControlled", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}