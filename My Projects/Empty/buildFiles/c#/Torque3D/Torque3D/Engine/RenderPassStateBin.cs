using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RenderPassStateBin : RenderBinManager
	{
		public RenderPassStateBin(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RenderPassStateBin(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RenderPassStateBin(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RenderPassStateBin(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RenderPassStateBin(SimObject pObj) : base(pObj)
		{
		}

		public RenderPassStateBin(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RenderPassStateBin_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RenderPassStateBin_create();
         private static _RenderPassStateBin_create _RenderPassStateBin_createFunc;
         internal static IntPtr RenderPassStateBin_create()
         {
         	if (_RenderPassStateBin_createFunc == null)
         	{
         		_RenderPassStateBin_createFunc =
         			(_RenderPassStateBin_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RenderPassStateBin_create"), typeof(_RenderPassStateBin_create));
         	}
         
         	return  _RenderPassStateBin_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public RenderPassStateToken StateToken
         {
         	get { return Sim.FindObject<RenderPassStateToken>(getFieldValue("StateToken")); }
         	set { setFieldValue("StateToken", value.getId().ToString()); }
         }
      
      
      #endregion

	}
}