using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SFXSound : SFXSource
	{
		public SFXSound(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SFXSound(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SFXSound(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SFXSound(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SFXSound(SimObject pObj) : base(pObj)
		{
		}

		public SFXSound(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SFXSound_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isReady(IntPtr thisPtr);
         private static _isReady _isReadyFunc;
         internal static bool isReady(IntPtr thisPtr)
         {
         	if (_isReadyFunc == null)
         	{
         		_isReadyFunc =
         			(_isReady)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSound_isReady"), typeof(_isReady));
         	}
         
         	return  _isReadyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getPosition(IntPtr thisPtr);
         private static _getPosition _getPositionFunc;
         internal static float getPosition(IntPtr thisPtr)
         {
         	if (_getPositionFunc == null)
         	{
         		_getPositionFunc =
         			(_getPosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSound_getPosition"), typeof(_getPosition));
         	}
         
         	return  _getPositionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setPosition(IntPtr thisPtr, float position);
         private static _setPosition _setPositionFunc;
         internal static void setPosition(IntPtr thisPtr, float position)
         {
         	if (_setPositionFunc == null)
         	{
         		_setPositionFunc =
         			(_setPosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSound_setPosition"), typeof(_setPosition));
         	}
         
         	 _setPositionFunc(thisPtr, position);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getDuration(IntPtr thisPtr);
         private static _getDuration _getDurationFunc;
         internal static float getDuration(IntPtr thisPtr)
         {
         	if (_getDurationFunc == null)
         	{
         		_getDurationFunc =
         			(_getDuration)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXSound_getDuration"), typeof(_getDuration));
         	}
         
         	return  _getDurationFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SFXSound_create();
         private static _SFXSound_create _SFXSound_createFunc;
         internal static IntPtr SFXSound_create()
         {
         	if (_SFXSound_createFunc == null)
         	{
         		_SFXSound_createFunc =
         			(_SFXSound_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SFXSound_create"), typeof(_SFXSound_create));
         	}
         
         	return  _SFXSound_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool isReady()
         {
            return InternalUnsafeMethods.isReady(ObjectPtr);
         }
      
         public virtual float getPosition()
         {
            return InternalUnsafeMethods.getPosition(ObjectPtr);
         }
      
         public virtual void setPosition(float position)
         {
            InternalUnsafeMethods.setPosition(ObjectPtr, position);
         }
      
         public virtual float getDuration()
         {
            return InternalUnsafeMethods.getDuration(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}