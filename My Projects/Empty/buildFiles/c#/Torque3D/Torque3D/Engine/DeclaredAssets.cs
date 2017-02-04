using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class DeclaredAssets : SimObject
	{
		public DeclaredAssets(bool pRegister = false)
			: base(pRegister)
		{
		}

		public DeclaredAssets(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public DeclaredAssets(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public DeclaredAssets(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public DeclaredAssets(SimObject pObj) : base(pObj)
		{
		}

		public DeclaredAssets(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.DeclaredAssets_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DeclaredAssets_create();
         private static _DeclaredAssets_create _DeclaredAssets_createFunc;
         internal static IntPtr DeclaredAssets_create()
         {
         	if (_DeclaredAssets_createFunc == null)
         	{
         		_DeclaredAssets_createFunc =
         			(_DeclaredAssets_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_DeclaredAssets_create"), typeof(_DeclaredAssets_create));
         	}
         
         	return  _DeclaredAssets_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string Path
         {
         	get { return getFieldValue("Path"); }
         	set { setFieldValue("Path", value); }
         }
      
         public string Extension
         {
         	get { return getFieldValue("Extension"); }
         	set { setFieldValue("Extension", value); }
         }
      
         public bool Recurse
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Recurse")); }
         	set { setFieldValue("Recurse", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}