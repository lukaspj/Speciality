using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class UndoManager : SimObject
	{
		public UndoManager(bool pRegister = false)
			: base(pRegister)
		{
		}

		public UndoManager(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public UndoManager(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public UndoManager(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public UndoManager(SimObject pObj) : base(pObj)
		{
		}

		public UndoManager(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.UndoManager_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearAll(IntPtr thisPtr);
         private static _clearAll _clearAllFunc;
         internal static void clearAll(IntPtr thisPtr)
         {
         	if (_clearAllFunc == null)
         	{
         		_clearAllFunc =
         			(_clearAll)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnUndoManager_clearAll"), typeof(_clearAll));
         	}
         
         	 _clearAllFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getUndoCount(IntPtr thisPtr);
         private static _getUndoCount _getUndoCountFunc;
         internal static int getUndoCount(IntPtr thisPtr)
         {
         	if (_getUndoCountFunc == null)
         	{
         		_getUndoCountFunc =
         			(_getUndoCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnUndoManager_getUndoCount"), typeof(_getUndoCount));
         	}
         
         	return  _getUndoCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getUndoName(IntPtr thisPtr, int index);
         private static _getUndoName _getUndoNameFunc;
         internal static IntPtr getUndoName(IntPtr thisPtr, int index)
         {
         	if (_getUndoNameFunc == null)
         	{
         		_getUndoNameFunc =
         			(_getUndoName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnUndoManager_getUndoName"), typeof(_getUndoName));
         	}
         
         	return  _getUndoNameFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getUndoAction(IntPtr thisPtr, int index);
         private static _getUndoAction _getUndoActionFunc;
         internal static int getUndoAction(IntPtr thisPtr, int index)
         {
         	if (_getUndoActionFunc == null)
         	{
         		_getUndoActionFunc =
         			(_getUndoAction)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnUndoManager_getUndoAction"), typeof(_getUndoAction));
         	}
         
         	return  _getUndoActionFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getRedoCount(IntPtr thisPtr);
         private static _getRedoCount _getRedoCountFunc;
         internal static int getRedoCount(IntPtr thisPtr)
         {
         	if (_getRedoCountFunc == null)
         	{
         		_getRedoCountFunc =
         			(_getRedoCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnUndoManager_getRedoCount"), typeof(_getRedoCount));
         	}
         
         	return  _getRedoCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getRedoName(IntPtr thisPtr, int index);
         private static _getRedoName _getRedoNameFunc;
         internal static IntPtr getRedoName(IntPtr thisPtr, int index)
         {
         	if (_getRedoNameFunc == null)
         	{
         		_getRedoNameFunc =
         			(_getRedoName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnUndoManager_getRedoName"), typeof(_getRedoName));
         	}
         
         	return  _getRedoNameFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getRedoAction(IntPtr thisPtr, int index);
         private static _getRedoAction _getRedoActionFunc;
         internal static int getRedoAction(IntPtr thisPtr, int index)
         {
         	if (_getRedoActionFunc == null)
         	{
         		_getRedoActionFunc =
         			(_getRedoAction)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnUndoManager_getRedoAction"), typeof(_getRedoAction));
         	}
         
         	return  _getRedoActionFunc(thisPtr, index);
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
         				"fnUndoManager_undo"), typeof(_undo));
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
         				"fnUndoManager_redo"), typeof(_redo));
         	}
         
         	 _redoFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getNextUndoName(IntPtr thisPtr);
         private static _getNextUndoName _getNextUndoNameFunc;
         internal static IntPtr getNextUndoName(IntPtr thisPtr)
         {
         	if (_getNextUndoNameFunc == null)
         	{
         		_getNextUndoNameFunc =
         			(_getNextUndoName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnUndoManager_getNextUndoName"), typeof(_getNextUndoName));
         	}
         
         	return  _getNextUndoNameFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getNextRedoName(IntPtr thisPtr);
         private static _getNextRedoName _getNextRedoNameFunc;
         internal static IntPtr getNextRedoName(IntPtr thisPtr)
         {
         	if (_getNextRedoNameFunc == null)
         	{
         		_getNextRedoNameFunc =
         			(_getNextRedoName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnUndoManager_getNextRedoName"), typeof(_getNextRedoName));
         	}
         
         	return  _getNextRedoNameFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _pushCompound(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _pushCompound _pushCompoundFunc;
         internal static IntPtr pushCompound(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_pushCompoundFunc == null)
         	{
         		_pushCompoundFunc =
         			(_pushCompound)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnUndoManager_pushCompound"), typeof(_pushCompound));
         	}
         
         	return  _pushCompoundFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _popCompound(IntPtr thisPtr, bool discard);
         private static _popCompound _popCompoundFunc;
         internal static void popCompound(IntPtr thisPtr, bool discard)
         {
         	if (_popCompoundFunc == null)
         	{
         		_popCompoundFunc =
         			(_popCompound)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnUndoManager_popCompound"), typeof(_popCompound));
         	}
         
         	 _popCompoundFunc(thisPtr, discard);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _UndoManager_create();
         private static _UndoManager_create _UndoManager_createFunc;
         internal static IntPtr UndoManager_create()
         {
         	if (_UndoManager_createFunc == null)
         	{
         		_UndoManager_createFunc =
         			(_UndoManager_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_UndoManager_create"), typeof(_UndoManager_create));
         	}
         
         	return  _UndoManager_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void clearAll()
         {
            InternalUnsafeMethods.clearAll(ObjectPtr);
         }
      
         public virtual int getUndoCount()
         {
            return InternalUnsafeMethods.getUndoCount(ObjectPtr);
         }
      
         public virtual string getUndoName(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getUndoName(ObjectPtr, index));
         }
      
         public virtual int getUndoAction(int index)
         {
            return InternalUnsafeMethods.getUndoAction(ObjectPtr, index);
         }
      
         public virtual int getRedoCount()
         {
            return InternalUnsafeMethods.getRedoCount(ObjectPtr);
         }
      
         public virtual string getRedoName(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getRedoName(ObjectPtr, index));
         }
      
         public virtual int getRedoAction(int index)
         {
            return InternalUnsafeMethods.getRedoAction(ObjectPtr, index);
         }
      
         public virtual void undo()
         {
            InternalUnsafeMethods.undo(ObjectPtr);
         }
      
         public virtual void redo()
         {
            InternalUnsafeMethods.redo(ObjectPtr);
         }
      
         public virtual string getNextUndoName()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getNextUndoName(ObjectPtr));
         }
      
         public virtual string getNextRedoName()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getNextRedoName(ObjectPtr));
         }
      
         public virtual string pushCompound(string name = "\"\"")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.pushCompound(ObjectPtr, name));
         }
      
         public virtual void popCompound(bool discard = false)
         {
            InternalUnsafeMethods.popCompound(ObjectPtr, discard);
         }
      
      
      #endregion


      #region Properties
      
      
         public int NumLevels
         {
         	get { return int.Parse(getFieldValue("NumLevels")); }
         	set { setFieldValue("NumLevels", value.ToString()); }
         }
      
      
      #endregion

	}
}