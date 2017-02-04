using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class DBDeleteUndoAction : UndoAction
	{
		public DBDeleteUndoAction(bool pRegister = false)
			: base(pRegister)
		{
		}

		public DBDeleteUndoAction(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public DBDeleteUndoAction(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public DBDeleteUndoAction(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public DBDeleteUndoAction(SimObject pObj) : base(pObj)
		{
		}

		public DBDeleteUndoAction(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.DBDeleteUndoAction_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DBDeleteUndoAction_create();
         private static _DBDeleteUndoAction_create _DBDeleteUndoAction_createFunc;
         internal static IntPtr DBDeleteUndoAction_create()
         {
         	if (_DBDeleteUndoAction_createFunc == null)
         	{
         		_DBDeleteUndoAction_createFunc =
         			(_DBDeleteUndoAction_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_DBDeleteUndoAction_create"), typeof(_DBDeleteUndoAction_create));
         	}
         
         	return  _DBDeleteUndoAction_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}