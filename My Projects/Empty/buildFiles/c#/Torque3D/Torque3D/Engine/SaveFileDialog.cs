using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SaveFileDialog : FileDialog
	{
		public SaveFileDialog(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SaveFileDialog(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SaveFileDialog(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SaveFileDialog(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SaveFileDialog(SimObject pObj) : base(pObj)
		{
		}

		public SaveFileDialog(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SaveFileDialog_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SaveFileDialog_create();
         private static _SaveFileDialog_create _SaveFileDialog_createFunc;
         internal static IntPtr SaveFileDialog_create()
         {
         	if (_SaveFileDialog_createFunc == null)
         	{
         		_SaveFileDialog_createFunc =
         			(_SaveFileDialog_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SaveFileDialog_create"), typeof(_SaveFileDialog_create));
         	}
         
         	return  _SaveFileDialog_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public bool OverwritePrompt
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OverwritePrompt")); }
         	set { setFieldValue("OverwritePrompt", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}