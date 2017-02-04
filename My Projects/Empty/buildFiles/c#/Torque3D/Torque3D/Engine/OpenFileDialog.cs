using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class OpenFileDialog : FileDialog
	{
		public OpenFileDialog(bool pRegister = false)
			: base(pRegister)
		{
		}

		public OpenFileDialog(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public OpenFileDialog(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public OpenFileDialog(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public OpenFileDialog(SimObject pObj) : base(pObj)
		{
		}

		public OpenFileDialog(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.OpenFileDialog_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _OpenFileDialog_create();
         private static _OpenFileDialog_create _OpenFileDialog_createFunc;
         internal static IntPtr OpenFileDialog_create()
         {
         	if (_OpenFileDialog_createFunc == null)
         	{
         		_OpenFileDialog_createFunc =
         			(_OpenFileDialog_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_OpenFileDialog_create"), typeof(_OpenFileDialog_create));
         	}
         
         	return  _OpenFileDialog_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public bool MustExist
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("MustExist")); }
         	set { setFieldValue("MustExist", value ? "1" : "0"); }
         }
      
         public bool MultipleFiles
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("MultipleFiles")); }
         	set { setFieldValue("MultipleFiles", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}