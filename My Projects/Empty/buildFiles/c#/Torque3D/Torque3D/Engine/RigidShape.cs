using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RigidShape : ShapeBase
	{
		public RigidShape(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RigidShape(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RigidShape(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RigidShape(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RigidShape(SimObject pObj) : base(pObj)
		{
		}

		public RigidShape(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RigidShape_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _reset(IntPtr thisPtr);
         private static _reset _resetFunc;
         internal static void reset(IntPtr thisPtr)
         {
         	if (_resetFunc == null)
         	{
         		_resetFunc =
         			(_reset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnRigidShape_reset"), typeof(_reset));
         	}
         
         	 _resetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _freezeSim(IntPtr thisPtr, bool isFrozen);
         private static _freezeSim _freezeSimFunc;
         internal static void freezeSim(IntPtr thisPtr, bool isFrozen)
         {
         	if (_freezeSimFunc == null)
         	{
         		_freezeSimFunc =
         			(_freezeSim)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnRigidShape_freezeSim"), typeof(_freezeSim));
         	}
         
         	 _freezeSimFunc(thisPtr, isFrozen);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _forceClientTransform(IntPtr thisPtr);
         private static _forceClientTransform _forceClientTransformFunc;
         internal static void forceClientTransform(IntPtr thisPtr)
         {
         	if (_forceClientTransformFunc == null)
         	{
         		_forceClientTransformFunc =
         			(_forceClientTransform)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnRigidShape_forceClientTransform"), typeof(_forceClientTransform));
         	}
         
         	 _forceClientTransformFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RigidShape_create();
         private static _RigidShape_create _RigidShape_createFunc;
         internal static IntPtr RigidShape_create()
         {
         	if (_RigidShape_createFunc == null)
         	{
         		_RigidShape_createFunc =
         			(_RigidShape_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RigidShape_create"), typeof(_RigidShape_create));
         	}
         
         	return  _RigidShape_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void reset()
         {
            InternalUnsafeMethods.reset(ObjectPtr);
         }
      
         public virtual void freezeSim(bool isFrozen)
         {
            InternalUnsafeMethods.freezeSim(ObjectPtr, isFrozen);
         }
      
         public virtual void forceClientTransform()
         {
            InternalUnsafeMethods.forceClientTransform(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}