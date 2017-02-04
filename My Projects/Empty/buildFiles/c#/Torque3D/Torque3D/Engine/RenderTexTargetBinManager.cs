using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RenderTexTargetBinManager : RenderBinManager
	{
		public RenderTexTargetBinManager(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RenderTexTargetBinManager(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RenderTexTargetBinManager(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RenderTexTargetBinManager(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RenderTexTargetBinManager(SimObject pObj) : base(pObj)
		{
		}

		public RenderTexTargetBinManager(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RenderTexTargetBinManager_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RenderTexTargetBinManager_create();
         private static _RenderTexTargetBinManager_create _RenderTexTargetBinManager_createFunc;
         internal static IntPtr RenderTexTargetBinManager_create()
         {
         	if (_RenderTexTargetBinManager_createFunc == null)
         	{
         		_RenderTexTargetBinManager_createFunc =
         			(_RenderTexTargetBinManager_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RenderTexTargetBinManager_create"), typeof(_RenderTexTargetBinManager_create));
         	}
         
         	return  _RenderTexTargetBinManager_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}