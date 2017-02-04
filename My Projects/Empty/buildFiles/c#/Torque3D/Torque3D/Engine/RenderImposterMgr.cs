using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RenderImposterMgr : RenderBinManager
	{
		public RenderImposterMgr(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RenderImposterMgr(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RenderImposterMgr(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RenderImposterMgr(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RenderImposterMgr(SimObject pObj) : base(pObj)
		{
		}

		public RenderImposterMgr(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RenderImposterMgr_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RenderImposterMgr_create();
         private static _RenderImposterMgr_create _RenderImposterMgr_createFunc;
         internal static IntPtr RenderImposterMgr_create()
         {
         	if (_RenderImposterMgr_createFunc == null)
         	{
         		_RenderImposterMgr_createFunc =
         			(_RenderImposterMgr_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RenderImposterMgr_create"), typeof(_RenderImposterMgr_create));
         	}
         
         	return  _RenderImposterMgr_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}