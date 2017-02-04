using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RenderOcclusionMgr : RenderBinManager
	{
		public RenderOcclusionMgr(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RenderOcclusionMgr(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RenderOcclusionMgr(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RenderOcclusionMgr(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RenderOcclusionMgr(SimObject pObj) : base(pObj)
		{
		}

		public RenderOcclusionMgr(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RenderOcclusionMgr_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RenderOcclusionMgr_create();
         private static _RenderOcclusionMgr_create _RenderOcclusionMgr_createFunc;
         internal static IntPtr RenderOcclusionMgr_create()
         {
         	if (_RenderOcclusionMgr_createFunc == null)
         	{
         		_RenderOcclusionMgr_createFunc =
         			(_RenderOcclusionMgr_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RenderOcclusionMgr_create"), typeof(_RenderOcclusionMgr_create));
         	}
         
         	return  _RenderOcclusionMgr_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}