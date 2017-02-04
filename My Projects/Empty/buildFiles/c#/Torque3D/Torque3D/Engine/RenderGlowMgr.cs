using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RenderGlowMgr : RenderTexTargetBinManager
	{
		public RenderGlowMgr(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RenderGlowMgr(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RenderGlowMgr(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RenderGlowMgr(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RenderGlowMgr(SimObject pObj) : base(pObj)
		{
		}

		public RenderGlowMgr(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RenderGlowMgr_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RenderGlowMgr_create();
         private static _RenderGlowMgr_create _RenderGlowMgr_createFunc;
         internal static IntPtr RenderGlowMgr_create()
         {
         	if (_RenderGlowMgr_createFunc == null)
         	{
         		_RenderGlowMgr_createFunc =
         			(_RenderGlowMgr_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RenderGlowMgr_create"), typeof(_RenderGlowMgr_create));
         	}
         
         	return  _RenderGlowMgr_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}