using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class UndoAction : SimObject
	{
		public UndoAction(bool pRegister = false)
			: base(pRegister)
		{
		}

		public UndoAction(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public UndoAction(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public UndoAction(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public UndoAction(SimObject pObj) : base(pObj)
		{
		}

		public UndoAction(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.UndoAction_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addToManager(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string undoManager);
         private static _addToManager _addToManagerFunc;
         internal static void addToManager(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string undoManager)
         {
         	if (_addToManagerFunc == null)
         	{
         		_addToManagerFunc =
         			(_addToManager)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnUndoAction_addToManager"), typeof(_addToManager));
         	}
         
         	 _addToManagerFunc(thisPtr, undoManager);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _undo(IntPtr thisPtr);
         private static _undo _undoFunc;
         internal static void undo(IntPtr thisPtr)
         {
         	if (_undoFunc == null)
         	{
         		_undoFunc =
         			(_undo)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnUndoAction_undo"), typeof(_undo));
         	}
         
         	 _undoFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _redo(IntPtr thisPtr);
         private static _redo _redoFunc;
         internal static void redo(IntPtr thisPtr)
         {
         	if (_redoFunc == null)
         	{
         		_redoFunc =
         			(_redo)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnUndoAction_redo"), typeof(_redo));
         	}
         
         	 _redoFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _UndoAction_create();
         private static _UndoAction_create _UndoAction_createFunc;
         internal static IntPtr UndoAction_create()
         {
         	if (_UndoAction_createFunc == null)
         	{
         		_UndoAction_createFunc =
         			(_UndoAction_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_UndoAction_create"), typeof(_UndoAction_create));
         	}
         
         	return  _UndoAction_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void addToManager(string undoManager = "")
         {
            InternalUnsafeMethods.addToManager(ObjectPtr, undoManager);
         }
      
         public virtual void undo()
         {
            InternalUnsafeMethods.undo(ObjectPtr);
         }
      
         public virtual void redo()
         {
            InternalUnsafeMethods.redo(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public string ActionName
         {
         	get { return getFieldValue("ActionName"); }
         	set { setFieldValue("ActionName", value); }
         }
      
      
      #endregion

	}
}