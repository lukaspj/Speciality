using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class DICreateUndoAction : UndoAction
	{
		public DICreateUndoAction(bool pRegister = false)
			: base(pRegister)
		{
		}

		public DICreateUndoAction(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public DICreateUndoAction(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public DICreateUndoAction(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public DICreateUndoAction(SimObject pObj) : base(pObj)
		{
		}

		public DICreateUndoAction(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.DICreateUndoAction_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DICreateUndoAction_create();
         private static _DICreateUndoAction_create _DICreateUndoAction_createFunc;
         internal static IntPtr DICreateUndoAction_create()
         {
         	if (_DICreateUndoAction_createFunc == null)
         	{
         		_DICreateUndoAction_createFunc =
         			(_DICreateUndoAction_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_DICreateUndoAction_create"), typeof(_DICreateUndoAction_create));
         	}
         
         	return  _DICreateUndoAction_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}