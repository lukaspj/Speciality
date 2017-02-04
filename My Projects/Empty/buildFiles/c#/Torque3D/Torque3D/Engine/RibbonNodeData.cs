using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RibbonNodeData : GameBaseData
	{
		public RibbonNodeData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RibbonNodeData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RibbonNodeData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RibbonNodeData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RibbonNodeData(SimObject pObj) : base(pObj)
		{
		}

		public RibbonNodeData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RibbonNodeData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RibbonNodeData_create();
         private static _RibbonNodeData_create _RibbonNodeData_createFunc;
         internal static IntPtr RibbonNodeData_create()
         {
         	if (_RibbonNodeData_createFunc == null)
         	{
         		_RibbonNodeData_createFunc =
         			(_RibbonNodeData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RibbonNodeData_create"), typeof(_RibbonNodeData_create));
         	}
         
         	return  _RibbonNodeData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}