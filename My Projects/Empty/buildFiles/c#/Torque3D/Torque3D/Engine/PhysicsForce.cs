using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class PhysicsForce : SceneObject
	{
		public PhysicsForce(bool pRegister = false)
			: base(pRegister)
		{
		}

		public PhysicsForce(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public PhysicsForce(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public PhysicsForce(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public PhysicsForce(SimObject pObj) : base(pObj)
		{
		}

		public PhysicsForce(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.PhysicsForce_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _attach(IntPtr thisPtr, InternalPoint3FStruct start, InternalPoint3FStruct direction, float maxDist);
         private static _attach _attachFunc;
         internal static void attach(IntPtr thisPtr, InternalPoint3FStruct start, InternalPoint3FStruct direction, float maxDist)
         {
         	if (_attachFunc == null)
         	{
         		_attachFunc =
         			(_attach)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPhysicsForce_attach"), typeof(_attach));
         	}
         
         	 _attachFunc(thisPtr, start, direction, maxDist);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _detach(IntPtr thisPtr, InternalPoint3FStruct force);
         private static _detach _detachFunc;
         internal static void detach(IntPtr thisPtr, InternalPoint3FStruct force)
         {
         	if (_detachFunc == null)
         	{
         		_detachFunc =
         			(_detach)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPhysicsForce_detach"), typeof(_detach));
         	}
         
         	 _detachFunc(thisPtr, force);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isAttached(IntPtr thisPtr);
         private static _isAttached _isAttachedFunc;
         internal static bool isAttached(IntPtr thisPtr)
         {
         	if (_isAttachedFunc == null)
         	{
         		_isAttachedFunc =
         			(_isAttached)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPhysicsForce_isAttached"), typeof(_isAttached));
         	}
         
         	return  _isAttachedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _PhysicsForce_create();
         private static _PhysicsForce_create _PhysicsForce_createFunc;
         internal static IntPtr PhysicsForce_create()
         {
         	if (_PhysicsForce_createFunc == null)
         	{
         		_PhysicsForce_createFunc =
         			(_PhysicsForce_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PhysicsForce_create"), typeof(_PhysicsForce_create));
         	}
         
         	return  _PhysicsForce_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void attach(Point3F start, Point3F direction, float maxDist)
         {
            InternalUnsafeMethods.attach(ObjectPtr, start.ToStruct(), direction.ToStruct(), maxDist);
         }
      
         public virtual void detach(Point3F force = null)
         {
            if (force == null) force = Point3F.Zero;
                  InternalUnsafeMethods.detach(ObjectPtr, force.ToStruct());
         }
      
         public virtual bool isAttached()
         {
            return InternalUnsafeMethods.isAttached(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}