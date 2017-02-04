using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ReferencedAssets : SimObject
	{
		public ReferencedAssets(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ReferencedAssets(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ReferencedAssets(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ReferencedAssets(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ReferencedAssets(SimObject pObj) : base(pObj)
		{
		}

		public ReferencedAssets(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ReferencedAssets_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ReferencedAssets_create();
         private static _ReferencedAssets_create _ReferencedAssets_createFunc;
         internal static IntPtr ReferencedAssets_create()
         {
         	if (_ReferencedAssets_createFunc == null)
         	{
         		_ReferencedAssets_createFunc =
         			(_ReferencedAssets_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ReferencedAssets_create"), typeof(_ReferencedAssets_create));
         	}
         
         	return  _ReferencedAssets_createFunc();
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