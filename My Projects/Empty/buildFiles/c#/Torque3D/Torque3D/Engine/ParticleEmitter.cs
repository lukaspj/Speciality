using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ParticleEmitter : GameBase
	{
		public ParticleEmitter(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ParticleEmitter(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ParticleEmitter(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ParticleEmitter(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ParticleEmitter(SimObject pObj) : base(pObj)
		{
		}

		public ParticleEmitter(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ParticleEmitter_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ParticleEmitter_create();
         private static _ParticleEmitter_create _ParticleEmitter_createFunc;
         internal static IntPtr ParticleEmitter_create()
         {
         	if (_ParticleEmitter_createFunc == null)
         	{
         		_ParticleEmitter_createFunc =
         			(_ParticleEmitter_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ParticleEmitter_create"), typeof(_ParticleEmitter_create));
         	}
         
         	return  _ParticleEmitter_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}