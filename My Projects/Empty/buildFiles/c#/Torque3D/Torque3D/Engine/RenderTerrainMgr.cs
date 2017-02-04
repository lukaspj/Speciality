using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RenderTerrainMgr : RenderBinManager
	{
		public RenderTerrainMgr(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RenderTerrainMgr(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RenderTerrainMgr(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RenderTerrainMgr(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RenderTerrainMgr(SimObject pObj) : base(pObj)
		{
		}

		public RenderTerrainMgr(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RenderTerrainMgr_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RenderTerrainMgr_create();
         private static _RenderTerrainMgr_create _RenderTerrainMgr_createFunc;
         internal static IntPtr RenderTerrainMgr_create()
         {
         	if (_RenderTerrainMgr_createFunc == null)
         	{
         		_RenderTerrainMgr_createFunc =
         			(_RenderTerrainMgr_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RenderTerrainMgr_create"), typeof(_RenderTerrainMgr_create));
         	}
         
         	return  _RenderTerrainMgr_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}