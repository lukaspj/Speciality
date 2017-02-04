using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ExampleAsset : AssetBase
	{
		public ExampleAsset(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ExampleAsset(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ExampleAsset(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ExampleAsset(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ExampleAsset(SimObject pObj) : base(pObj)
		{
		}

		public ExampleAsset(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ExampleAsset_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ExampleAsset_create();
         private static _ExampleAsset_create _ExampleAsset_createFunc;
         internal static IntPtr ExampleAsset_create()
         {
         	if (_ExampleAsset_createFunc == null)
         	{
         		_ExampleAsset_createFunc =
         			(_ExampleAsset_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ExampleAsset_create"), typeof(_ExampleAsset_create));
         	}
         
         	return  _ExampleAsset_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}