using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ModuleMergeDefinition : SimObject
	{
		public ModuleMergeDefinition(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ModuleMergeDefinition(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ModuleMergeDefinition(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ModuleMergeDefinition(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ModuleMergeDefinition(SimObject pObj) : base(pObj)
		{
		}

		public ModuleMergeDefinition(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ModuleMergeDefinition_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleMergeDefinition_create();
         private static _ModuleMergeDefinition_create _ModuleMergeDefinition_createFunc;
         internal static IntPtr ModuleMergeDefinition_create()
         {
         	if (_ModuleMergeDefinition_createFunc == null)
         	{
         		_ModuleMergeDefinition_createFunc =
         			(_ModuleMergeDefinition_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ModuleMergeDefinition_create"), typeof(_ModuleMergeDefinition_create));
         	}
         
         	return  _ModuleMergeDefinition_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string MergePath
         {
         	get { return getFieldValue("MergePath"); }
         	set { setFieldValue("MergePath", value); }
         }
      
      
      #endregion

	}
}