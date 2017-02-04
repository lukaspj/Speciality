using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class AITurretShape : TurretShape
	{
		public AITurretShape(bool pRegister = false)
			: base(pRegister)
		{
		}

		public AITurretShape(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public AITurretShape(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public AITurretShape(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public AITurretShape(SimObject pObj) : base(pObj)
		{
		}

		public AITurretShape(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.AITurretShape_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addToIgnoreList(IntPtr thisPtr, IntPtr obj);
         private static _addToIgnoreList _addToIgnoreListFunc;
         internal static void addToIgnoreList(IntPtr thisPtr, IntPtr obj)
         {
         	if (_addToIgnoreListFunc == null)
         	{
         		_addToIgnoreListFunc =
         			(_addToIgnoreList)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAITurretShape_addToIgnoreList"), typeof(_addToIgnoreList));
         	}
         
         	 _addToIgnoreListFunc(thisPtr, obj);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeFromIgnoreList(IntPtr thisPtr, IntPtr obj);
         private static _removeFromIgnoreList _removeFromIgnoreListFunc;
         internal static void removeFromIgnoreList(IntPtr thisPtr, IntPtr obj)
         {
         	if (_removeFromIgnoreListFunc == null)
         	{
         		_removeFromIgnoreListFunc =
         			(_removeFromIgnoreList)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAITurretShape_removeFromIgnoreList"), typeof(_removeFromIgnoreList));
         	}
         
         	 _removeFromIgnoreListFunc(thisPtr, obj);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setTurretState(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newState, bool force);
         private static _setTurretState _setTurretStateFunc;
         internal static void setTurretState(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newState, bool force)
         {
         	if (_setTurretStateFunc == null)
         	{
         		_setTurretStateFunc =
         			(_setTurretState)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAITurretShape_setTurretState"), typeof(_setTurretState));
         	}
         
         	 _setTurretStateFunc(thisPtr, newState, force);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _activateTurret(IntPtr thisPtr);
         private static _activateTurret _activateTurretFunc;
         internal static void activateTurret(IntPtr thisPtr)
         {
         	if (_activateTurretFunc == null)
         	{
         		_activateTurretFunc =
         			(_activateTurret)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAITurretShape_activateTurret"), typeof(_activateTurret));
         	}
         
         	 _activateTurretFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deactivateTurret(IntPtr thisPtr);
         private static _deactivateTurret _deactivateTurretFunc;
         internal static void deactivateTurret(IntPtr thisPtr)
         {
         	if (_deactivateTurretFunc == null)
         	{
         		_deactivateTurretFunc =
         			(_deactivateTurret)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAITurretShape_deactivateTurret"), typeof(_deactivateTurret));
         	}
         
         	 _deactivateTurretFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _startScanForTargets(IntPtr thisPtr);
         private static _startScanForTargets _startScanForTargetsFunc;
         internal static void startScanForTargets(IntPtr thisPtr)
         {
         	if (_startScanForTargetsFunc == null)
         	{
         		_startScanForTargetsFunc =
         			(_startScanForTargets)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAITurretShape_startScanForTargets"), typeof(_startScanForTargets));
         	}
         
         	 _startScanForTargetsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _stopScanForTargets(IntPtr thisPtr);
         private static _stopScanForTargets _stopScanForTargetsFunc;
         internal static void stopScanForTargets(IntPtr thisPtr)
         {
         	if (_stopScanForTargetsFunc == null)
         	{
         		_stopScanForTargetsFunc =
         			(_stopScanForTargets)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAITurretShape_stopScanForTargets"), typeof(_stopScanForTargets));
         	}
         
         	 _stopScanForTargetsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _startTrackingTarget(IntPtr thisPtr);
         private static _startTrackingTarget _startTrackingTargetFunc;
         internal static void startTrackingTarget(IntPtr thisPtr)
         {
         	if (_startTrackingTargetFunc == null)
         	{
         		_startTrackingTargetFunc =
         			(_startTrackingTarget)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAITurretShape_startTrackingTarget"), typeof(_startTrackingTarget));
         	}
         
         	 _startTrackingTargetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _stopTrackingTarget(IntPtr thisPtr);
         private static _stopTrackingTarget _stopTrackingTargetFunc;
         internal static void stopTrackingTarget(IntPtr thisPtr)
         {
         	if (_stopTrackingTargetFunc == null)
         	{
         		_stopTrackingTargetFunc =
         			(_stopTrackingTarget)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAITurretShape_stopTrackingTarget"), typeof(_stopTrackingTarget));
         	}
         
         	 _stopTrackingTargetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _hasTarget(IntPtr thisPtr);
         private static _hasTarget _hasTargetFunc;
         internal static bool hasTarget(IntPtr thisPtr)
         {
         	if (_hasTargetFunc == null)
         	{
         		_hasTargetFunc =
         			(_hasTarget)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAITurretShape_hasTarget"), typeof(_hasTarget));
         	}
         
         	return  _hasTargetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getTarget(IntPtr thisPtr);
         private static _getTarget _getTargetFunc;
         internal static IntPtr getTarget(IntPtr thisPtr)
         {
         	if (_getTargetFunc == null)
         	{
         		_getTargetFunc =
         			(_getTarget)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAITurretShape_getTarget"), typeof(_getTarget));
         	}
         
         	return  _getTargetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _resetTarget(IntPtr thisPtr);
         private static _resetTarget _resetTargetFunc;
         internal static void resetTarget(IntPtr thisPtr)
         {
         	if (_resetTargetFunc == null)
         	{
         		_resetTargetFunc =
         			(_resetTarget)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAITurretShape_resetTarget"), typeof(_resetTarget));
         	}
         
         	 _resetTargetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setWeaponLeadVelocity(IntPtr thisPtr, float velocity);
         private static _setWeaponLeadVelocity _setWeaponLeadVelocityFunc;
         internal static void setWeaponLeadVelocity(IntPtr thisPtr, float velocity)
         {
         	if (_setWeaponLeadVelocityFunc == null)
         	{
         		_setWeaponLeadVelocityFunc =
         			(_setWeaponLeadVelocity)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAITurretShape_setWeaponLeadVelocity"), typeof(_setWeaponLeadVelocity));
         	}
         
         	 _setWeaponLeadVelocityFunc(thisPtr, velocity);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getWeaponLeadVelocity(IntPtr thisPtr);
         private static _getWeaponLeadVelocity _getWeaponLeadVelocityFunc;
         internal static float getWeaponLeadVelocity(IntPtr thisPtr)
         {
         	if (_getWeaponLeadVelocityFunc == null)
         	{
         		_getWeaponLeadVelocityFunc =
         			(_getWeaponLeadVelocity)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAITurretShape_getWeaponLeadVelocity"), typeof(_getWeaponLeadVelocity));
         	}
         
         	return  _getWeaponLeadVelocityFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setAllGunsFiring(IntPtr thisPtr, bool fire);
         private static _setAllGunsFiring _setAllGunsFiringFunc;
         internal static void setAllGunsFiring(IntPtr thisPtr, bool fire)
         {
         	if (_setAllGunsFiringFunc == null)
         	{
         		_setAllGunsFiringFunc =
         			(_setAllGunsFiring)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAITurretShape_setAllGunsFiring"), typeof(_setAllGunsFiring));
         	}
         
         	 _setAllGunsFiringFunc(thisPtr, fire);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setGunSlotFiring(IntPtr thisPtr, int slot, bool fire);
         private static _setGunSlotFiring _setGunSlotFiringFunc;
         internal static void setGunSlotFiring(IntPtr thisPtr, int slot, bool fire)
         {
         	if (_setGunSlotFiringFunc == null)
         	{
         		_setGunSlotFiringFunc =
         			(_setGunSlotFiring)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAITurretShape_setGunSlotFiring"), typeof(_setGunSlotFiring));
         	}
         
         	 _setGunSlotFiringFunc(thisPtr, slot, fire);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _recenterTurret(IntPtr thisPtr);
         private static _recenterTurret _recenterTurretFunc;
         internal static void recenterTurret(IntPtr thisPtr)
         {
         	if (_recenterTurretFunc == null)
         	{
         		_recenterTurretFunc =
         			(_recenterTurret)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAITurretShape_recenterTurret"), typeof(_recenterTurret));
         	}
         
         	 _recenterTurretFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AITurretShape_create();
         private static _AITurretShape_create _AITurretShape_createFunc;
         internal static IntPtr AITurretShape_create()
         {
         	if (_AITurretShape_createFunc == null)
         	{
         		_AITurretShape_createFunc =
         			(_AITurretShape_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AITurretShape_create"), typeof(_AITurretShape_create));
         	}
         
         	return  _AITurretShape_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void addToIgnoreList(ShapeBase obj)
         {
            InternalUnsafeMethods.addToIgnoreList(ObjectPtr, obj.ObjectPtr);
         }
      
         public virtual void removeFromIgnoreList(ShapeBase obj)
         {
            InternalUnsafeMethods.removeFromIgnoreList(ObjectPtr, obj.ObjectPtr);
         }
      
         public virtual void setTurretState(string newState, bool force = false)
         {
            InternalUnsafeMethods.setTurretState(ObjectPtr, newState, force);
         }
      
         public virtual void activateTurret()
         {
            InternalUnsafeMethods.activateTurret(ObjectPtr);
         }
      
         public virtual void deactivateTurret()
         {
            InternalUnsafeMethods.deactivateTurret(ObjectPtr);
         }
      
         public virtual void startScanForTargets()
         {
            InternalUnsafeMethods.startScanForTargets(ObjectPtr);
         }
      
         public virtual void stopScanForTargets()
         {
            InternalUnsafeMethods.stopScanForTargets(ObjectPtr);
         }
      
         public virtual void startTrackingTarget()
         {
            InternalUnsafeMethods.startTrackingTarget(ObjectPtr);
         }
      
         public virtual void stopTrackingTarget()
         {
            InternalUnsafeMethods.stopTrackingTarget(ObjectPtr);
         }
      
         public virtual bool hasTarget()
         {
            return InternalUnsafeMethods.hasTarget(ObjectPtr);
         }
      
         public virtual SimObject getTarget()
         {
            return new SimObject(InternalUnsafeMethods.getTarget(ObjectPtr));
         }
      
         public virtual void resetTarget()
         {
            InternalUnsafeMethods.resetTarget(ObjectPtr);
         }
      
         public virtual void setWeaponLeadVelocity(float velocity)
         {
            InternalUnsafeMethods.setWeaponLeadVelocity(ObjectPtr, velocity);
         }
      
         public virtual float getWeaponLeadVelocity()
         {
            return InternalUnsafeMethods.getWeaponLeadVelocity(ObjectPtr);
         }
      
         public virtual void setAllGunsFiring(bool fire)
         {
            InternalUnsafeMethods.setAllGunsFiring(ObjectPtr, fire);
         }
      
         public virtual void setGunSlotFiring(int slot, bool fire)
         {
            InternalUnsafeMethods.setGunSlotFiring(ObjectPtr, slot, fire);
         }
      
         public virtual void recenterTurret()
         {
            InternalUnsafeMethods.recenterTurret(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}