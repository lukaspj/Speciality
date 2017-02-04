using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ShapeAsset : AssetBase
	{
		public ShapeAsset(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ShapeAsset(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ShapeAsset(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ShapeAsset(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ShapeAsset(SimObject pObj) : base(pObj)
		{
		}

		public ShapeAsset(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ShapeAsset_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ShapeAsset_create();
         private static _ShapeAsset_create _ShapeAsset_createFunc;
         internal static IntPtr ShapeAsset_create()
         {
         	if (_ShapeAsset_createFunc == null)
         	{
         		_ShapeAsset_createFunc =
         			(_ShapeAsset_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ShapeAsset_create"), typeof(_ShapeAsset_create));
         	}
         
         	return  _ShapeAsset_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string FileName
         {
         	get { return getFieldValue("FileName"); }
         	set { setFieldValue("FileName", value); }
         }
      
      
      #endregion

	}
}