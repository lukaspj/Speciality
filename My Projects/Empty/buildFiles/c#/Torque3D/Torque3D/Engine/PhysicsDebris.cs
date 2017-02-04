using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class PhysicsDebris : GameBase
	{
		public PhysicsDebris(bool pRegister = false)
			: base(pRegister)
		{
		}

		public PhysicsDebris(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public PhysicsDebris(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public PhysicsDebris(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public PhysicsDebris(SimObject pObj) : base(pObj)
		{
		}

		public PhysicsDebris(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.PhysicsDebris_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _PhysicsDebris_create();
         private static _PhysicsDebris_create _PhysicsDebris_createFunc;
         internal static IntPtr PhysicsDebris_create()
         {
         	if (_PhysicsDebris_createFunc == null)
         	{
         		_PhysicsDebris_createFunc =
         			(_PhysicsDebris_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PhysicsDebris_create"), typeof(_PhysicsDebris_create));
         	}
         
         	return  _PhysicsDebris_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}