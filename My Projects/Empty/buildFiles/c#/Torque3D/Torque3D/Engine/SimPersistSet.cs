using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SimPersistSet : SimSet
	{
		public SimPersistSet(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SimPersistSet(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SimPersistSet(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SimPersistSet(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SimPersistSet(SimObject pObj) : base(pObj)
		{
		}

		public SimPersistSet(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SimPersistSet_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _resolvePersistentIds(IntPtr thisPtr);
         private static _resolvePersistentIds _resolvePersistentIdsFunc;
         internal static void resolvePersistentIds(IntPtr thisPtr)
         {
         	if (_resolvePersistentIdsFunc == null)
         	{
         		_resolvePersistentIdsFunc =
         			(_resolvePersistentIds)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimPersistSet_resolvePersistentIds"), typeof(_resolvePersistentIds));
         	}
         
         	 _resolvePersistentIdsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimPersistSet_create();
         private static _SimPersistSet_create _SimPersistSet_createFunc;
         internal static IntPtr SimPersistSet_create()
         {
         	if (_SimPersistSet_createFunc == null)
         	{
         		_SimPersistSet_createFunc =
         			(_SimPersistSet_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SimPersistSet_create"), typeof(_SimPersistSet_create));
         	}
         
         	return  _SimPersistSet_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void resolvePersistentIds()
         {
            InternalUnsafeMethods.resolvePersistentIds(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}