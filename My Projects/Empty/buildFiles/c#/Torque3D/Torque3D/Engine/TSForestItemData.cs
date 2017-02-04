using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class TSForestItemData : ForestItemData
	{
		public TSForestItemData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public TSForestItemData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public TSForestItemData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public TSForestItemData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public TSForestItemData(SimObject pObj) : base(pObj)
		{
		}

		public TSForestItemData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.TSForestItemData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TSForestItemData_create();
         private static _TSForestItemData_create _TSForestItemData_createFunc;
         internal static IntPtr TSForestItemData_create()
         {
         	if (_TSForestItemData_createFunc == null)
         	{
         		_TSForestItemData_createFunc =
         			(_TSForestItemData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_TSForestItemData_create"), typeof(_TSForestItemData_create));
         	}
         
         	return  _TSForestItemData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}