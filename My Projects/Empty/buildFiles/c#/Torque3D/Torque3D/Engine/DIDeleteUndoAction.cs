using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class DIDeleteUndoAction : UndoAction
	{
		public DIDeleteUndoAction(bool pRegister = false)
			: base(pRegister)
		{
		}

		public DIDeleteUndoAction(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public DIDeleteUndoAction(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public DIDeleteUndoAction(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public DIDeleteUndoAction(SimObject pObj) : base(pObj)
		{
		}

		public DIDeleteUndoAction(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.DIDeleteUndoAction_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DIDeleteUndoAction_create();
         private static _DIDeleteUndoAction_create _DIDeleteUndoAction_createFunc;
         internal static IntPtr DIDeleteUndoAction_create()
         {
         	if (_DIDeleteUndoAction_createFunc == null)
         	{
         		_DIDeleteUndoAction_createFunc =
         			(_DIDeleteUndoAction_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_DIDeleteUndoAction_create"), typeof(_DIDeleteUndoAction_create));
         	}
         
         	return  _DIDeleteUndoAction_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}