using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SimResponseCurve : SimObject
	{
		public SimResponseCurve(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SimResponseCurve(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SimResponseCurve(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SimResponseCurve(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SimResponseCurve(SimObject pObj) : base(pObj)
		{
		}

		public SimResponseCurve(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SimResponseCurve_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addPoint(IntPtr thisPtr, float value, float time);
         private static _addPoint _addPointFunc;
         internal static void addPoint(IntPtr thisPtr, float value, float time)
         {
         	if (_addPointFunc == null)
         	{
         		_addPointFunc =
         			(_addPoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimResponseCurve_addPoint"), typeof(_addPoint));
         	}
         
         	 _addPointFunc(thisPtr, value, time);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getValue(IntPtr thisPtr, float time);
         private static _getValue _getValueFunc;
         internal static float getValue(IntPtr thisPtr, float time)
         {
         	if (_getValueFunc == null)
         	{
         		_getValueFunc =
         			(_getValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimResponseCurve_getValue"), typeof(_getValue));
         	}
         
         	return  _getValueFunc(thisPtr, time);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clear(IntPtr thisPtr);
         private static _clear _clearFunc;
         internal static void clear(IntPtr thisPtr)
         {
         	if (_clearFunc == null)
         	{
         		_clearFunc =
         			(_clear)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimResponseCurve_clear"), typeof(_clear));
         	}
         
         	 _clearFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimResponseCurve_create();
         private static _SimResponseCurve_create _SimResponseCurve_createFunc;
         internal static IntPtr SimResponseCurve_create()
         {
         	if (_SimResponseCurve_createFunc == null)
         	{
         		_SimResponseCurve_createFunc =
         			(_SimResponseCurve_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SimResponseCurve_create"), typeof(_SimResponseCurve_create));
         	}
         
         	return  _SimResponseCurve_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void addPoint(float value, float time)
         {
            InternalUnsafeMethods.addPoint(ObjectPtr, value, time);
         }
      
         public virtual float getValue(float time)
         {
            return InternalUnsafeMethods.getValue(ObjectPtr, time);
         }
      
         public virtual void clear()
         {
            InternalUnsafeMethods.clear(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}