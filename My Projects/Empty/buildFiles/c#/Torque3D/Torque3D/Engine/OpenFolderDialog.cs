using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class OpenFolderDialog : OpenFileDialog
	{
		public OpenFolderDialog(bool pRegister = false)
			: base(pRegister)
		{
		}

		public OpenFolderDialog(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public OpenFolderDialog(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public OpenFolderDialog(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public OpenFolderDialog(SimObject pObj) : base(pObj)
		{
		}

		public OpenFolderDialog(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.OpenFolderDialog_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _OpenFolderDialog_create();
         private static _OpenFolderDialog_create _OpenFolderDialog_createFunc;
         internal static IntPtr OpenFolderDialog_create()
         {
         	if (_OpenFolderDialog_createFunc == null)
         	{
         		_OpenFolderDialog_createFunc =
         			(_OpenFolderDialog_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_OpenFolderDialog_create"), typeof(_OpenFolderDialog_create));
         	}
         
         	return  _OpenFolderDialog_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string FileMustExist
         {
         	get { return getFieldValue("FileMustExist"); }
         	set { setFieldValue("FileMustExist", value); }
         }
      
      
      #endregion

	}
}