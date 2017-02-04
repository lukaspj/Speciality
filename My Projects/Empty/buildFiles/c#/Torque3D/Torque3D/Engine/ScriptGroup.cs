using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ScriptGroup : SimGroup
	{
		public ScriptGroup(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ScriptGroup(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ScriptGroup(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ScriptGroup(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ScriptGroup(SimObject pObj) : base(pObj)
		{
		}

		public ScriptGroup(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ScriptGroup_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ScriptGroup_create();
         private static _ScriptGroup_create _ScriptGroup_createFunc;
         internal static IntPtr ScriptGroup_create()
         {
         	if (_ScriptGroup_createFunc == null)
         	{
         		_ScriptGroup_createFunc =
         			(_ScriptGroup_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ScriptGroup_create"), typeof(_ScriptGroup_create));
         	}
         
         	return  _ScriptGroup_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}