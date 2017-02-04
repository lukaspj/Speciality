using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class DBRetargetUndoAction : UndoAction
	{
		public DBRetargetUndoAction(bool pRegister = false)
			: base(pRegister)
		{
		}

		public DBRetargetUndoAction(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public DBRetargetUndoAction(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public DBRetargetUndoAction(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public DBRetargetUndoAction(SimObject pObj) : base(pObj)
		{
		}

		public DBRetargetUndoAction(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.DBRetargetUndoAction_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DBRetargetUndoAction_create();
         private static _DBRetargetUndoAction_create _DBRetargetUndoAction_createFunc;
         internal static IntPtr DBRetargetUndoAction_create()
         {
         	if (_DBRetargetUndoAction_createFunc == null)
         	{
         		_DBRetargetUndoAction_createFunc =
         			(_DBRetargetUndoAction_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_DBRetargetUndoAction_create"), typeof(_DBRetargetUndoAction_create));
         	}
         
         	return  _DBRetargetUndoAction_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}