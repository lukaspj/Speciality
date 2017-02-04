using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RenderMeshMgr : RenderBinManager
	{
		public RenderMeshMgr(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RenderMeshMgr(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RenderMeshMgr(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RenderMeshMgr(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RenderMeshMgr(SimObject pObj) : base(pObj)
		{
		}

		public RenderMeshMgr(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RenderMeshMgr_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RenderMeshMgr_create();
         private static _RenderMeshMgr_create _RenderMeshMgr_createFunc;
         internal static IntPtr RenderMeshMgr_create()
         {
         	if (_RenderMeshMgr_createFunc == null)
         	{
         		_RenderMeshMgr_createFunc =
         			(_RenderMeshMgr_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RenderMeshMgr_create"), typeof(_RenderMeshMgr_create));
         	}
         
         	return  _RenderMeshMgr_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}