using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RenderTranslucentMgr : RenderBinManager
	{
		public RenderTranslucentMgr(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RenderTranslucentMgr(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RenderTranslucentMgr(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RenderTranslucentMgr(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RenderTranslucentMgr(SimObject pObj) : base(pObj)
		{
		}

		public RenderTranslucentMgr(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RenderTranslucentMgr_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RenderTranslucentMgr_create();
         private static _RenderTranslucentMgr_create _RenderTranslucentMgr_createFunc;
         internal static IntPtr RenderTranslucentMgr_create()
         {
         	if (_RenderTranslucentMgr_createFunc == null)
         	{
         		_RenderTranslucentMgr_createFunc =
         			(_RenderTranslucentMgr_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RenderTranslucentMgr_create"), typeof(_RenderTranslucentMgr_create));
         	}
         
         	return  _RenderTranslucentMgr_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}