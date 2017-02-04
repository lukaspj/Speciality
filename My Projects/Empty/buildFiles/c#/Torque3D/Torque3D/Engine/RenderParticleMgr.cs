using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RenderParticleMgr : RenderTexTargetBinManager
	{
		public RenderParticleMgr(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RenderParticleMgr(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RenderParticleMgr(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RenderParticleMgr(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RenderParticleMgr(SimObject pObj) : base(pObj)
		{
		}

		public RenderParticleMgr(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RenderParticleMgr_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RenderParticleMgr_create();
         private static _RenderParticleMgr_create _RenderParticleMgr_createFunc;
         internal static IntPtr RenderParticleMgr_create()
         {
         	if (_RenderParticleMgr_createFunc == null)
         	{
         		_RenderParticleMgr_createFunc =
         			(_RenderParticleMgr_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RenderParticleMgr_create"), typeof(_RenderParticleMgr_create));
         	}
         
         	return  _RenderParticleMgr_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}