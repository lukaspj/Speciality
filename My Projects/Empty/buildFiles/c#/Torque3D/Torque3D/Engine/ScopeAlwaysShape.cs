using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ScopeAlwaysShape : StaticShape
	{
		public ScopeAlwaysShape(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ScopeAlwaysShape(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ScopeAlwaysShape(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ScopeAlwaysShape(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ScopeAlwaysShape(SimObject pObj) : base(pObj)
		{
		}

		public ScopeAlwaysShape(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ScopeAlwaysShape_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ScopeAlwaysShape_create();
         private static _ScopeAlwaysShape_create _ScopeAlwaysShape_createFunc;
         internal static IntPtr ScopeAlwaysShape_create()
         {
         	if (_ScopeAlwaysShape_createFunc == null)
         	{
         		_ScopeAlwaysShape_createFunc =
         			(_ScopeAlwaysShape_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ScopeAlwaysShape_create"), typeof(_ScopeAlwaysShape_create));
         	}
         
         	return  _ScopeAlwaysShape_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}