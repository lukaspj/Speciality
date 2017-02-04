using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class PersistenceManager : SimObject
	{
		public PersistenceManager(bool pRegister = false)
			: base(pRegister)
		{
		}

		public PersistenceManager(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public PersistenceManager(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public PersistenceManager(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public PersistenceManager(SimObject pObj) : base(pObj)
		{
		}

		public PersistenceManager(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.PersistenceManager_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deleteObjectsFromFile(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fileName);
         private static _deleteObjectsFromFile _deleteObjectsFromFileFunc;
         internal static void deleteObjectsFromFile(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fileName)
         {
         	if (_deleteObjectsFromFileFunc == null)
         	{
         		_deleteObjectsFromFileFunc =
         			(_deleteObjectsFromFile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPersistenceManager_deleteObjectsFromFile"), typeof(_deleteObjectsFromFile));
         	}
         
         	 _deleteObjectsFromFileFunc(thisPtr, fileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setDirty(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName, [MarshalAs(UnmanagedType.LPWStr)]string fileName);
         private static _setDirty _setDirtyFunc;
         internal static void setDirty(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName, [MarshalAs(UnmanagedType.LPWStr)]string fileName)
         {
         	if (_setDirtyFunc == null)
         	{
         		_setDirtyFunc =
         			(_setDirty)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPersistenceManager_setDirty"), typeof(_setDirty));
         	}
         
         	 _setDirtyFunc(thisPtr, objName, fileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeDirty(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName);
         private static _removeDirty _removeDirtyFunc;
         internal static void removeDirty(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName)
         {
         	if (_removeDirtyFunc == null)
         	{
         		_removeDirtyFunc =
         			(_removeDirty)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPersistenceManager_removeDirty"), typeof(_removeDirty));
         	}
         
         	 _removeDirtyFunc(thisPtr, objName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isDirty(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName);
         private static _isDirty _isDirtyFunc;
         internal static bool isDirty(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName)
         {
         	if (_isDirtyFunc == null)
         	{
         		_isDirtyFunc =
         			(_isDirty)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPersistenceManager_isDirty"), typeof(_isDirty));
         	}
         
         	return  _isDirtyFunc(thisPtr, objName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _hasDirty(IntPtr thisPtr);
         private static _hasDirty _hasDirtyFunc;
         internal static bool hasDirty(IntPtr thisPtr)
         {
         	if (_hasDirtyFunc == null)
         	{
         		_hasDirtyFunc =
         			(_hasDirty)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPersistenceManager_hasDirty"), typeof(_hasDirty));
         	}
         
         	return  _hasDirtyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getDirtyObjectCount(IntPtr thisPtr);
         private static _getDirtyObjectCount _getDirtyObjectCountFunc;
         internal static int getDirtyObjectCount(IntPtr thisPtr)
         {
         	if (_getDirtyObjectCountFunc == null)
         	{
         		_getDirtyObjectCountFunc =
         			(_getDirtyObjectCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPersistenceManager_getDirtyObjectCount"), typeof(_getDirtyObjectCount));
         	}
         
         	return  _getDirtyObjectCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getDirtyObject(IntPtr thisPtr, int index);
         private static _getDirtyObject _getDirtyObjectFunc;
         internal static int getDirtyObject(IntPtr thisPtr, int index)
         {
         	if (_getDirtyObjectFunc == null)
         	{
         		_getDirtyObjectFunc =
         			(_getDirtyObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPersistenceManager_getDirtyObject"), typeof(_getDirtyObject));
         	}
         
         	return  _getDirtyObjectFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _listDirty(IntPtr thisPtr);
         private static _listDirty _listDirtyFunc;
         internal static void listDirty(IntPtr thisPtr)
         {
         	if (_listDirtyFunc == null)
         	{
         		_listDirtyFunc =
         			(_listDirty)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPersistenceManager_listDirty"), typeof(_listDirty));
         	}
         
         	 _listDirtyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _saveDirty(IntPtr thisPtr);
         private static _saveDirty _saveDirtyFunc;
         internal static bool saveDirty(IntPtr thisPtr)
         {
         	if (_saveDirtyFunc == null)
         	{
         		_saveDirtyFunc =
         			(_saveDirty)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPersistenceManager_saveDirty"), typeof(_saveDirty));
         	}
         
         	return  _saveDirtyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _saveDirtyObject(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName);
         private static _saveDirtyObject _saveDirtyObjectFunc;
         internal static bool saveDirtyObject(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName)
         {
         	if (_saveDirtyObjectFunc == null)
         	{
         		_saveDirtyObjectFunc =
         			(_saveDirtyObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPersistenceManager_saveDirtyObject"), typeof(_saveDirtyObject));
         	}
         
         	return  _saveDirtyObjectFunc(thisPtr, objName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearAll(IntPtr thisPtr);
         private static _clearAll _clearAllFunc;
         internal static void clearAll(IntPtr thisPtr)
         {
         	if (_clearAllFunc == null)
         	{
         		_clearAllFunc =
         			(_clearAll)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPersistenceManager_clearAll"), typeof(_clearAll));
         	}
         
         	 _clearAllFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeObjectFromFile(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName, [MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _removeObjectFromFile _removeObjectFromFileFunc;
         internal static void removeObjectFromFile(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName, [MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_removeObjectFromFileFunc == null)
         	{
         		_removeObjectFromFileFunc =
         			(_removeObjectFromFile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPersistenceManager_removeObjectFromFile"), typeof(_removeObjectFromFile));
         	}
         
         	 _removeObjectFromFileFunc(thisPtr, objName, filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeField(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName, [MarshalAs(UnmanagedType.LPWStr)]string fieldName);
         private static _removeField _removeFieldFunc;
         internal static void removeField(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName, [MarshalAs(UnmanagedType.LPWStr)]string fieldName)
         {
         	if (_removeFieldFunc == null)
         	{
         		_removeFieldFunc =
         			(_removeField)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPersistenceManager_removeField"), typeof(_removeField));
         	}
         
         	 _removeFieldFunc(thisPtr, objName, fieldName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _PersistenceManager_create();
         private static _PersistenceManager_create _PersistenceManager_createFunc;
         internal static IntPtr PersistenceManager_create()
         {
         	if (_PersistenceManager_createFunc == null)
         	{
         		_PersistenceManager_createFunc =
         			(_PersistenceManager_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PersistenceManager_create"), typeof(_PersistenceManager_create));
         	}
         
         	return  _PersistenceManager_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void deleteObjectsFromFile(string fileName)
         {
            InternalUnsafeMethods.deleteObjectsFromFile(ObjectPtr, fileName);
         }
      
         public virtual void setDirty(string objName, string fileName = "")
         {
            InternalUnsafeMethods.setDirty(ObjectPtr, objName, fileName);
         }
      
         public virtual void removeDirty(string objName)
         {
            InternalUnsafeMethods.removeDirty(ObjectPtr, objName);
         }
      
         public virtual bool isDirty(string objName)
         {
            return InternalUnsafeMethods.isDirty(ObjectPtr, objName);
         }
      
         public virtual bool hasDirty()
         {
            return InternalUnsafeMethods.hasDirty(ObjectPtr);
         }
      
         public virtual int getDirtyObjectCount()
         {
            return InternalUnsafeMethods.getDirtyObjectCount(ObjectPtr);
         }
      
         public virtual int getDirtyObject(int index)
         {
            return InternalUnsafeMethods.getDirtyObject(ObjectPtr, index);
         }
      
         public virtual void listDirty()
         {
            InternalUnsafeMethods.listDirty(ObjectPtr);
         }
      
         public virtual bool saveDirty()
         {
            return InternalUnsafeMethods.saveDirty(ObjectPtr);
         }
      
         public virtual bool saveDirtyObject(string objName)
         {
            return InternalUnsafeMethods.saveDirtyObject(ObjectPtr, objName);
         }
      
         public virtual void clearAll()
         {
            InternalUnsafeMethods.clearAll(ObjectPtr);
         }
      
         public virtual void removeObjectFromFile(string objName, string filename = "")
         {
            InternalUnsafeMethods.removeObjectFromFile(ObjectPtr, objName, filename);
         }
      
         public virtual void removeField(string objName, string fieldName)
         {
            InternalUnsafeMethods.removeField(ObjectPtr, objName, fieldName);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}