using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class AdvancedLightBinManager : RenderTexTargetBinManager
	{
		public AdvancedLightBinManager(bool pRegister = false)
			: base(pRegister)
		{
		}

		public AdvancedLightBinManager(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public AdvancedLightBinManager(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public AdvancedLightBinManager(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public AdvancedLightBinManager(SimObject pObj) : base(pObj)
		{
		}

		public AdvancedLightBinManager(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.AdvancedLightBinManager_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AdvancedLightBinManager_create();
         private static _AdvancedLightBinManager_create _AdvancedLightBinManager_createFunc;
         internal static IntPtr AdvancedLightBinManager_create()
         {
         	if (_AdvancedLightBinManager_createFunc == null)
         	{
         		_AdvancedLightBinManager_createFunc =
         			(_AdvancedLightBinManager_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AdvancedLightBinManager_create"), typeof(_AdvancedLightBinManager_create));
         	}
         
         	return  _AdvancedLightBinManager_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}