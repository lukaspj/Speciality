using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class CompoundUndoAction : UndoAction
	{
		public CompoundUndoAction(bool pRegister = false)
			: base(pRegister)
		{
		}

		public CompoundUndoAction(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public CompoundUndoAction(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public CompoundUndoAction(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public CompoundUndoAction(SimObject pObj) : base(pObj)
		{
		}

		public CompoundUndoAction(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.CompoundUndoAction_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addAction(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName);
         private static _addAction _addActionFunc;
         internal static void addAction(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName)
         {
         	if (_addActionFunc == null)
         	{
         		_addActionFunc =
         			(_addAction)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCompoundUndoAction_addAction"), typeof(_addAction));
         	}
         
         	 _addActionFunc(thisPtr, objName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _CompoundUndoAction_create();
         private static _CompoundUndoAction_create _CompoundUndoAction_createFunc;
         internal static IntPtr CompoundUndoAction_create()
         {
         	if (_CompoundUndoAction_createFunc == null)
         	{
         		_CompoundUndoAction_createFunc =
         			(_CompoundUndoAction_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CompoundUndoAction_create"), typeof(_CompoundUndoAction_create));
         	}
         
         	return  _CompoundUndoAction_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void addAction(string objName)
         {
            InternalUnsafeMethods.addAction(ObjectPtr, objName);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}