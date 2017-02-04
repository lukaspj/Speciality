using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RenderObjectMgr : RenderBinManager
	{
		public RenderObjectMgr(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RenderObjectMgr(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RenderObjectMgr(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RenderObjectMgr(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RenderObjectMgr(SimObject pObj) : base(pObj)
		{
		}

		public RenderObjectMgr(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RenderObjectMgr_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RenderObjectMgr_create();
         private static _RenderObjectMgr_create _RenderObjectMgr_createFunc;
         internal static IntPtr RenderObjectMgr_create()
         {
         	if (_RenderObjectMgr_createFunc == null)
         	{
         		_RenderObjectMgr_createFunc =
         			(_RenderObjectMgr_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RenderObjectMgr_create"), typeof(_RenderObjectMgr_create));
         	}
         
         	return  _RenderObjectMgr_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}