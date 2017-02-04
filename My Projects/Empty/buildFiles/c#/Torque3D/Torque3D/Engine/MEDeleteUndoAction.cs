using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class MEDeleteUndoAction : UndoAction
	{
		public MEDeleteUndoAction(bool pRegister = false)
			: base(pRegister)
		{
		}

		public MEDeleteUndoAction(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public MEDeleteUndoAction(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public MEDeleteUndoAction(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public MEDeleteUndoAction(SimObject pObj) : base(pObj)
		{
		}

		public MEDeleteUndoAction(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.MEDeleteUndoAction_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deleteObject(IntPtr thisPtr, IntPtr obj);
         private static _deleteObject _deleteObjectFunc;
         internal static void deleteObject(IntPtr thisPtr, IntPtr obj)
         {
         	if (_deleteObjectFunc == null)
         	{
         		_deleteObjectFunc =
         			(_deleteObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMEDeleteUndoAction_deleteObject"), typeof(_deleteObject));
         	}
         
         	 _deleteObjectFunc(thisPtr, obj);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MEDeleteUndoAction_create();
         private static _MEDeleteUndoAction_create _MEDeleteUndoAction_createFunc;
         internal static IntPtr MEDeleteUndoAction_create()
         {
         	if (_MEDeleteUndoAction_createFunc == null)
         	{
         		_MEDeleteUndoAction_createFunc =
         			(_MEDeleteUndoAction_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_MEDeleteUndoAction_create"), typeof(_MEDeleteUndoAction_create));
         	}
         
         	return  _MEDeleteUndoAction_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void deleteObject(SimObject obj)
         {
            InternalUnsafeMethods.deleteObject(ObjectPtr, obj.ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}