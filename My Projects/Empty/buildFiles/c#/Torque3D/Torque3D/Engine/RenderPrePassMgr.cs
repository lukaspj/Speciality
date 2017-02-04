using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RenderPrePassMgr : RenderTexTargetBinManager
	{
		public RenderPrePassMgr(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RenderPrePassMgr(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RenderPrePassMgr(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RenderPrePassMgr(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RenderPrePassMgr(SimObject pObj) : base(pObj)
		{
		}

		public RenderPrePassMgr(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RenderPrePassMgr_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RenderPrePassMgr_create();
         private static _RenderPrePassMgr_create _RenderPrePassMgr_createFunc;
         internal static IntPtr RenderPrePassMgr_create()
         {
         	if (_RenderPrePassMgr_createFunc == null)
         	{
         		_RenderPrePassMgr_createFunc =
         			(_RenderPrePassMgr_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RenderPrePassMgr_create"), typeof(_RenderPrePassMgr_create));
         	}
         
         	return  _RenderPrePassMgr_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}