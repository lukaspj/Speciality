using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SFXState : SimDataBlock
	{
		public SFXState(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SFXState(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SFXState(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SFXState(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SFXState(SimObject pObj) : base(pObj)
		{
		}

		public SFXState(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SFXState_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isActive(IntPtr thisPtr);
         private static _isActive _isActiveFunc;
         internal static bool isActive(IntPtr thisPtr)
         {
         	if (_isActiveFunc == null)
         	{
         		_isActiveFunc =
         			(_isActive)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXState_isActive"), typeof(_isActive));
         	}
         
         	return  _isActiveFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _activate(IntPtr thisPtr);
         private static _activate _activateFunc;
         internal static void activate(IntPtr thisPtr)
         {
         	if (_activateFunc == null)
         	{
         		_activateFunc =
         			(_activate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXState_activate"), typeof(_activate));
         	}
         
         	 _activateFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deactivate(IntPtr thisPtr);
         private static _deactivate _deactivateFunc;
         internal static void deactivate(IntPtr thisPtr)
         {
         	if (_deactivateFunc == null)
         	{
         		_deactivateFunc =
         			(_deactivate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXState_deactivate"), typeof(_deactivate));
         	}
         
         	 _deactivateFunc(thisPtr);
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
         				"fnSFXState_isDisabled"), typeof(_isDisabled));
         	}
         
         	return  _isDisabledFunc(thisPtr);
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
         				"fnSFXState_disable"), typeof(_disable));
         	}
         
         	 _disableFunc(thisPtr);
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
         				"fnSFXState_enable"), typeof(_enable));
         	}
         
         	 _enableFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SFXState_create();
         private static _SFXState_create _SFXState_createFunc;
         internal static IntPtr SFXState_create()
         {
         	if (_SFXState_createFunc == null)
         	{
         		_SFXState_createFunc =
         			(_SFXState_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SFXState_create"), typeof(_SFXState_create));
         	}
         
         	return  _SFXState_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool isActive()
         {
            return InternalUnsafeMethods.isActive(ObjectPtr);
         }
      
         public virtual void activate()
         {
            InternalUnsafeMethods.activate(ObjectPtr);
         }
      
         public virtual void deactivate()
         {
            InternalUnsafeMethods.deactivate(ObjectPtr);
         }
      
         public virtual bool isDisabled()
         {
            return InternalUnsafeMethods.isDisabled(ObjectPtr);
         }
      
         public virtual void disable()
         {
            InternalUnsafeMethods.disable(ObjectPtr);
         }
      
         public virtual void enable()
         {
            InternalUnsafeMethods.enable(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public DynamicFieldVector<SFXState> IncludedStates
         {
         	get { return new DynamicFieldVector<SFXState>(this, "IncludedStates", 4, val => Sim.FindObject<SFXState>(val), obj => obj.getId().ToString()); }
         }
      
         public DynamicFieldVector<SFXState> ExcludedStates
         {
         	get { return new DynamicFieldVector<SFXState>(this, "ExcludedStates", 4, val => Sim.FindObject<SFXState>(val), obj => obj.getId().ToString()); }
         }
      
      
      #endregion

	}
}