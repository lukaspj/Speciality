using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SimObject : IDisposable
	{
		//public Sim.SimObjectPtr* ObjectPtr { get; protected set; }
		public IntPtr ObjectPtr { get; protected set; }

		public SimObject(bool pRegister = false)
		{
			CreateSimObjectPtr();
			if (pRegister) registerObject();
		}

		public SimObject(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SimObject(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SimObject(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SimObject(SimObject pObj)
		{
         SetPointerFromObject(pObj);
		   SimDictionary.RegisterObject(this);
		}

		public SimObject(IntPtr pObjPtr)
		{
		   ObjectPtr = pObjPtr;
		   SimDictionary.RegisterObject(this);
		}

		public void SetPointerFromObject(SimObject pObj)
		{
		   if (!SimDictionary.Contains(pObj)) SimDictionary.RegisterObject(pObj);
			ObjectPtr = pObj.ObjectPtr;
		}

		public void SetPointer(IntPtr pObjPtr)
		{
			ObjectPtr = pObjPtr;
		   SimDictionary.RegisterObject(this);
      }

      public T As<T>() where T : SimObject
      {
         return (T)SimDictionary.CreateInstance(typeof(T), this);
		}

      public SimObject As(Type t)
		{
         if (!typeof(SimObject).IsAssignableFrom(t)) return null;
         
         return (SimObject)SimDictionary.CreateInstance(t, this);
      }

		public bool IsDead()
		{
			return SimDictionary.IsDead(ObjectPtr);
		}

		protected virtual void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SimObject_create();
		}

		#region IDisposable

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool pDisposing)
		{
			/*if (((IntPtr)ObjectPtr->RefPtr) != IntPtr.Zero)
			{
			Marshal.FreeHGlobal((IntPtr) ObjectPtr);
			}*/

		   SimDictionary.UnregisterObjectPtr(ObjectPtr);
		}

		~SimObject()
		{
			Dispose(false);
		}

		#endregion

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dumpGroupHierarchy(IntPtr thisPtr);
         private static _dumpGroupHierarchy _dumpGroupHierarchyFunc;
         internal static void dumpGroupHierarchy(IntPtr thisPtr)
         {
         	if (_dumpGroupHierarchyFunc == null)
         	{
         		_dumpGroupHierarchyFunc =
         			(_dumpGroupHierarchy)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_dumpGroupHierarchy"), typeof(_dumpGroupHierarchy));
         	}
         
         	 _dumpGroupHierarchyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isMethod(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string methodName);
         private static _isMethod _isMethodFunc;
         internal static bool isMethod(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string methodName)
         {
         	if (_isMethodFunc == null)
         	{
         		_isMethodFunc =
         			(_isMethod)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_isMethod"), typeof(_isMethod));
         	}
         
         	return  _isMethodFunc(thisPtr, methodName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isChildOfGroup(IntPtr thisPtr, IntPtr group);
         private static _isChildOfGroup _isChildOfGroupFunc;
         internal static bool isChildOfGroup(IntPtr thisPtr, IntPtr group)
         {
         	if (_isChildOfGroupFunc == null)
         	{
         		_isChildOfGroupFunc =
         			(_isChildOfGroup)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_isChildOfGroup"), typeof(_isChildOfGroup));
         	}
         
         	return  _isChildOfGroupFunc(thisPtr, group);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getClassNamespace(IntPtr thisPtr);
         private static _getClassNamespace _getClassNamespaceFunc;
         internal static IntPtr getClassNamespace(IntPtr thisPtr)
         {
         	if (_getClassNamespaceFunc == null)
         	{
         		_getClassNamespaceFunc =
         			(_getClassNamespace)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_getClassNamespace"), typeof(_getClassNamespace));
         	}
         
         	return  _getClassNamespaceFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getSuperClassNamespace(IntPtr thisPtr);
         private static _getSuperClassNamespace _getSuperClassNamespaceFunc;
         internal static IntPtr getSuperClassNamespace(IntPtr thisPtr)
         {
         	if (_getSuperClassNamespaceFunc == null)
         	{
         		_getSuperClassNamespaceFunc =
         			(_getSuperClassNamespace)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_getSuperClassNamespace"), typeof(_getSuperClassNamespace));
         	}
         
         	return  _getSuperClassNamespaceFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setClassNamespace(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _setClassNamespace _setClassNamespaceFunc;
         internal static void setClassNamespace(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_setClassNamespaceFunc == null)
         	{
         		_setClassNamespaceFunc =
         			(_setClassNamespace)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_setClassNamespace"), typeof(_setClassNamespace));
         	}
         
         	 _setClassNamespaceFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSuperClassNamespace(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _setSuperClassNamespace _setSuperClassNamespaceFunc;
         internal static void setSuperClassNamespace(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_setSuperClassNamespaceFunc == null)
         	{
         		_setSuperClassNamespaceFunc =
         			(_setSuperClassNamespace)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_setSuperClassNamespace"), typeof(_setSuperClassNamespace));
         	}
         
         	 _setSuperClassNamespaceFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isSelected(IntPtr thisPtr);
         private static _isSelected _isSelectedFunc;
         internal static bool isSelected(IntPtr thisPtr)
         {
         	if (_isSelectedFunc == null)
         	{
         		_isSelectedFunc =
         			(_isSelected)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_isSelected"), typeof(_isSelected));
         	}
         
         	return  _isSelectedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setIsSelected(IntPtr thisPtr, bool state);
         private static _setIsSelected _setIsSelectedFunc;
         internal static void setIsSelected(IntPtr thisPtr, bool state)
         {
         	if (_setIsSelectedFunc == null)
         	{
         		_setIsSelectedFunc =
         			(_setIsSelected)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_setIsSelected"), typeof(_setIsSelected));
         	}
         
         	 _setIsSelectedFunc(thisPtr, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isExpanded(IntPtr thisPtr);
         private static _isExpanded _isExpandedFunc;
         internal static bool isExpanded(IntPtr thisPtr)
         {
         	if (_isExpandedFunc == null)
         	{
         		_isExpandedFunc =
         			(_isExpanded)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_isExpanded"), typeof(_isExpanded));
         	}
         
         	return  _isExpandedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setIsExpanded(IntPtr thisPtr, bool state);
         private static _setIsExpanded _setIsExpandedFunc;
         internal static void setIsExpanded(IntPtr thisPtr, bool state)
         {
         	if (_setIsExpandedFunc == null)
         	{
         		_setIsExpandedFunc =
         			(_setIsExpanded)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_setIsExpanded"), typeof(_setIsExpanded));
         	}
         
         	 _setIsExpandedFunc(thisPtr, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getFilename(IntPtr thisPtr);
         private static _getFilename _getFilenameFunc;
         internal static IntPtr getFilename(IntPtr thisPtr)
         {
         	if (_getFilenameFunc == null)
         	{
         		_getFilenameFunc =
         			(_getFilename)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_getFilename"), typeof(_getFilename));
         	}
         
         	return  _getFilenameFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setFilename(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fileName);
         private static _setFilename _setFilenameFunc;
         internal static void setFilename(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fileName)
         {
         	if (_setFilenameFunc == null)
         	{
         		_setFilenameFunc =
         			(_setFilename)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_setFilename"), typeof(_setFilename));
         	}
         
         	 _setFilenameFunc(thisPtr, fileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getDeclarationLine(IntPtr thisPtr);
         private static _getDeclarationLine _getDeclarationLineFunc;
         internal static int getDeclarationLine(IntPtr thisPtr)
         {
         	if (_getDeclarationLineFunc == null)
         	{
         		_getDeclarationLineFunc =
         			(_getDeclarationLine)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_getDeclarationLine"), typeof(_getDeclarationLine));
         	}
         
         	return  _getDeclarationLineFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _assignFieldsFrom(IntPtr thisPtr, IntPtr fromObject);
         private static _assignFieldsFrom _assignFieldsFromFunc;
         internal static void assignFieldsFrom(IntPtr thisPtr, IntPtr fromObject)
         {
         	if (_assignFieldsFromFunc == null)
         	{
         		_assignFieldsFromFunc =
         			(_assignFieldsFrom)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_assignFieldsFrom"), typeof(_assignFieldsFrom));
         	}
         
         	 _assignFieldsFromFunc(thisPtr, fromObject);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _assignPersistentId(IntPtr thisPtr);
         private static _assignPersistentId _assignPersistentIdFunc;
         internal static void assignPersistentId(IntPtr thisPtr)
         {
         	if (_assignPersistentIdFunc == null)
         	{
         		_assignPersistentIdFunc =
         			(_assignPersistentId)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_assignPersistentId"), typeof(_assignPersistentId));
         	}
         
         	 _assignPersistentIdFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getCanSave(IntPtr thisPtr);
         private static _getCanSave _getCanSaveFunc;
         internal static bool getCanSave(IntPtr thisPtr)
         {
         	if (_getCanSaveFunc == null)
         	{
         		_getCanSaveFunc =
         			(_getCanSave)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_getCanSave"), typeof(_getCanSave));
         	}
         
         	return  _getCanSaveFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setCanSave(IntPtr thisPtr, bool value);
         private static _setCanSave _setCanSaveFunc;
         internal static void setCanSave(IntPtr thisPtr, bool value)
         {
         	if (_setCanSaveFunc == null)
         	{
         		_setCanSaveFunc =
         			(_setCanSave)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_setCanSave"), typeof(_setCanSave));
         	}
         
         	 _setCanSaveFunc(thisPtr, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isEditorOnly(IntPtr thisPtr);
         private static _isEditorOnly _isEditorOnlyFunc;
         internal static bool isEditorOnly(IntPtr thisPtr)
         {
         	if (_isEditorOnlyFunc == null)
         	{
         		_isEditorOnlyFunc =
         			(_isEditorOnly)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_isEditorOnly"), typeof(_isEditorOnly));
         	}
         
         	return  _isEditorOnlyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setEditorOnly(IntPtr thisPtr, bool value);
         private static _setEditorOnly _setEditorOnlyFunc;
         internal static void setEditorOnly(IntPtr thisPtr, bool value)
         {
         	if (_setEditorOnlyFunc == null)
         	{
         		_setEditorOnlyFunc =
         			(_setEditorOnly)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_setEditorOnly"), typeof(_setEditorOnly));
         	}
         
         	 _setEditorOnlyFunc(thisPtr, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isNameChangeAllowed(IntPtr thisPtr);
         private static _isNameChangeAllowed _isNameChangeAllowedFunc;
         internal static bool isNameChangeAllowed(IntPtr thisPtr)
         {
         	if (_isNameChangeAllowedFunc == null)
         	{
         		_isNameChangeAllowedFunc =
         			(_isNameChangeAllowed)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_isNameChangeAllowed"), typeof(_isNameChangeAllowed));
         	}
         
         	return  _isNameChangeAllowedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setNameChangeAllowed(IntPtr thisPtr, bool value);
         private static _setNameChangeAllowed _setNameChangeAllowedFunc;
         internal static void setNameChangeAllowed(IntPtr thisPtr, bool value)
         {
         	if (_setNameChangeAllowedFunc == null)
         	{
         		_setNameChangeAllowedFunc =
         			(_setNameChangeAllowed)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_setNameChangeAllowed"), typeof(_setNameChangeAllowed));
         	}
         
         	 _setNameChangeAllowedFunc(thisPtr, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _clone(IntPtr thisPtr);
         private static _clone _cloneFunc;
         internal static IntPtr clone(IntPtr thisPtr)
         {
         	if (_cloneFunc == null)
         	{
         		_cloneFunc =
         			(_clone)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_clone"), typeof(_clone));
         	}
         
         	return  _cloneFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _deepClone(IntPtr thisPtr);
         private static _deepClone _deepCloneFunc;
         internal static IntPtr deepClone(IntPtr thisPtr)
         {
         	if (_deepCloneFunc == null)
         	{
         		_deepCloneFunc =
         			(_deepClone)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_deepClone"), typeof(_deepClone));
         	}
         
         	return  _deepCloneFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setLocked(IntPtr thisPtr, bool value);
         private static _setLocked _setLockedFunc;
         internal static void setLocked(IntPtr thisPtr, bool value)
         {
         	if (_setLockedFunc == null)
         	{
         		_setLockedFunc =
         			(_setLocked)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_setLocked"), typeof(_setLocked));
         	}
         
         	 _setLockedFunc(thisPtr, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setHidden(IntPtr thisPtr, bool value);
         private static _setHidden _setHiddenFunc;
         internal static void setHidden(IntPtr thisPtr, bool value)
         {
         	if (_setHiddenFunc == null)
         	{
         		_setHiddenFunc =
         			(_setHidden)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_setHidden"), typeof(_setHidden));
         	}
         
         	 _setHiddenFunc(thisPtr, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _dumpMethods(IntPtr thisPtr);
         private static _dumpMethods _dumpMethodsFunc;
         internal static IntPtr dumpMethods(IntPtr thisPtr)
         {
         	if (_dumpMethodsFunc == null)
         	{
         		_dumpMethodsFunc =
         			(_dumpMethods)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_dumpMethods"), typeof(_dumpMethods));
         	}
         
         	return  _dumpMethodsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dump(IntPtr thisPtr, bool detailed);
         private static _dump _dumpFunc;
         internal static void dump(IntPtr thisPtr, bool detailed)
         {
         	if (_dumpFunc == null)
         	{
         		_dumpFunc =
         			(_dump)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_dump"), typeof(_dump));
         	}
         
         	 _dumpFunc(thisPtr, detailed);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _save(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fileName, bool selectedOnly, [MarshalAs(UnmanagedType.LPWStr)]string preAppendString);
         private static _save _saveFunc;
         internal static bool save(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fileName, bool selectedOnly, [MarshalAs(UnmanagedType.LPWStr)]string preAppendString)
         {
         	if (_saveFunc == null)
         	{
         		_saveFunc =
         			(_save)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_save"), typeof(_save));
         	}
         
         	return  _saveFunc(thisPtr, fileName, selectedOnly, preAppendString);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newName);
         private static _setName _setNameFunc;
         internal static void setName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newName)
         {
         	if (_setNameFunc == null)
         	{
         		_setNameFunc =
         			(_setName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_setName"), typeof(_setName));
         	}
         
         	 _setNameFunc(thisPtr, newName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getName(IntPtr thisPtr);
         private static _getName _getNameFunc;
         internal static IntPtr getName(IntPtr thisPtr)
         {
         	if (_getNameFunc == null)
         	{
         		_getNameFunc =
         			(_getName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_getName"), typeof(_getName));
         	}
         
         	return  _getNameFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getClassName(IntPtr thisPtr);
         private static _getClassName _getClassNameFunc;
         internal static IntPtr getClassName(IntPtr thisPtr)
         {
         	if (_getClassNameFunc == null)
         	{
         		_getClassNameFunc =
         			(_getClassName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_getClassName"), typeof(_getClassName));
         	}
         
         	return  _getClassNameFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isField(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fieldName);
         private static _isField _isFieldFunc;
         internal static bool isField(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fieldName)
         {
         	if (_isFieldFunc == null)
         	{
         		_isFieldFunc =
         			(_isField)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_isField"), typeof(_isField));
         	}
         
         	return  _isFieldFunc(thisPtr, fieldName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getFieldValue(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPStr)]string fieldName, int index);
         private static _getFieldValue _getFieldValueFunc;
         internal static IntPtr getFieldValue(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPStr)]string fieldName, int index)
         {
         	if (_getFieldValueFunc == null)
         	{
         		_getFieldValueFunc =
         			(_getFieldValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_getFieldValue"), typeof(_getFieldValue));
         	}
         
         	return  _getFieldValueFunc(thisPtr, fieldName, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setFieldValue(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fieldName, [MarshalAs(UnmanagedType.LPWStr)]string value, int index);
         private static _setFieldValue _setFieldValueFunc;
         internal static bool setFieldValue(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fieldName, [MarshalAs(UnmanagedType.LPWStr)]string value, int index)
         {
         	if (_setFieldValueFunc == null)
         	{
         		_setFieldValueFunc =
         			(_setFieldValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_setFieldValue"), typeof(_setFieldValue));
         	}
         
         	return  _setFieldValueFunc(thisPtr, fieldName, value, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getFieldType(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fieldName);
         private static _getFieldType _getFieldTypeFunc;
         internal static IntPtr getFieldType(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fieldName)
         {
         	if (_getFieldTypeFunc == null)
         	{
         		_getFieldTypeFunc =
         			(_getFieldType)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_getFieldType"), typeof(_getFieldType));
         	}
         
         	return  _getFieldTypeFunc(thisPtr, fieldName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setFieldType(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fieldName, [MarshalAs(UnmanagedType.LPWStr)]string type);
         private static _setFieldType _setFieldTypeFunc;
         internal static void setFieldType(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fieldName, [MarshalAs(UnmanagedType.LPWStr)]string type)
         {
         	if (_setFieldTypeFunc == null)
         	{
         		_setFieldTypeFunc =
         			(_setFieldType)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_setFieldType"), typeof(_setFieldType));
         	}
         
         	 _setFieldTypeFunc(thisPtr, fieldName, type);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _call(IntPtr thisPtr, int argc, string[] argv);
         private static _call _callFunc;
         internal static IntPtr call(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_callFunc == null)
         	{
         		_callFunc =
         			(_call)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_call"), typeof(_call));
         	}
         
         	return  _callFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setInternalName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newInternalName);
         private static _setInternalName _setInternalNameFunc;
         internal static void setInternalName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newInternalName)
         {
         	if (_setInternalNameFunc == null)
         	{
         		_setInternalNameFunc =
         			(_setInternalName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_setInternalName"), typeof(_setInternalName));
         	}
         
         	 _setInternalNameFunc(thisPtr, newInternalName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getInternalName(IntPtr thisPtr);
         private static _getInternalName _getInternalNameFunc;
         internal static IntPtr getInternalName(IntPtr thisPtr)
         {
         	if (_getInternalNameFunc == null)
         	{
         		_getInternalNameFunc =
         			(_getInternalName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_getInternalName"), typeof(_getInternalName));
         	}
         
         	return  _getInternalNameFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dumpClassHierarchy(IntPtr thisPtr);
         private static _dumpClassHierarchy _dumpClassHierarchyFunc;
         internal static void dumpClassHierarchy(IntPtr thisPtr)
         {
         	if (_dumpClassHierarchyFunc == null)
         	{
         		_dumpClassHierarchyFunc =
         			(_dumpClassHierarchy)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_dumpClassHierarchy"), typeof(_dumpClassHierarchy));
         	}
         
         	 _dumpClassHierarchyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isMemberOfClass(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string className);
         private static _isMemberOfClass _isMemberOfClassFunc;
         internal static bool isMemberOfClass(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string className)
         {
         	if (_isMemberOfClassFunc == null)
         	{
         		_isMemberOfClassFunc =
         			(_isMemberOfClass)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_isMemberOfClass"), typeof(_isMemberOfClass));
         	}
         
         	return  _isMemberOfClassFunc(thisPtr, className);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isInNamespaceHierarchy(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _isInNamespaceHierarchy _isInNamespaceHierarchyFunc;
         internal static bool isInNamespaceHierarchy(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_isInNamespaceHierarchyFunc == null)
         	{
         		_isInNamespaceHierarchyFunc =
         			(_isInNamespaceHierarchy)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_isInNamespaceHierarchy"), typeof(_isInNamespaceHierarchy));
         	}
         
         	return  _isInNamespaceHierarchyFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getId(IntPtr thisPtr);
         private static _getId _getIdFunc;
         internal static int getId(IntPtr thisPtr)
         {
         	if (_getIdFunc == null)
         	{
         		_getIdFunc =
         			(_getId)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_getId"), typeof(_getId));
         	}
         
         	return  _getIdFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getGroup(IntPtr thisPtr);
         private static _getGroup _getGroupFunc;
         internal static IntPtr getGroup(IntPtr thisPtr)
         {
         	if (_getGroupFunc == null)
         	{
         		_getGroupFunc =
         			(_getGroup)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_getGroup"), typeof(_getGroup));
         	}
         
         	return  _getGroupFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _delete(IntPtr thisPtr);
         private static _delete _deleteFunc;
         internal static void delete(IntPtr thisPtr)
         {
         	if (_deleteFunc == null)
         	{
         		_deleteFunc =
         			(_delete)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_delete"), typeof(_delete));
         	}
         
         	 _deleteFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _schedule(IntPtr thisPtr, int argc, string[] argv);
         private static _schedule _scheduleFunc;
         internal static int schedule(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_scheduleFunc == null)
         	{
         		_scheduleFunc =
         			(_schedule)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_schedule"), typeof(_schedule));
         	}
         
         	return  _scheduleFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getDynamicFieldCount(IntPtr thisPtr);
         private static _getDynamicFieldCount _getDynamicFieldCountFunc;
         internal static int getDynamicFieldCount(IntPtr thisPtr)
         {
         	if (_getDynamicFieldCountFunc == null)
         	{
         		_getDynamicFieldCountFunc =
         			(_getDynamicFieldCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_getDynamicFieldCount"), typeof(_getDynamicFieldCount));
         	}
         
         	return  _getDynamicFieldCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getDynamicField(IntPtr thisPtr, int index);
         private static _getDynamicField _getDynamicFieldFunc;
         internal static IntPtr getDynamicField(IntPtr thisPtr, int index)
         {
         	if (_getDynamicFieldFunc == null)
         	{
         		_getDynamicFieldFunc =
         			(_getDynamicField)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_getDynamicField"), typeof(_getDynamicField));
         	}
         
         	return  _getDynamicFieldFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getFieldCount(IntPtr thisPtr);
         private static _getFieldCount _getFieldCountFunc;
         internal static int getFieldCount(IntPtr thisPtr)
         {
         	if (_getFieldCountFunc == null)
         	{
         		_getFieldCountFunc =
         			(_getFieldCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_getFieldCount"), typeof(_getFieldCount));
         	}
         
         	return  _getFieldCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getField(IntPtr thisPtr, int index);
         private static _getField _getFieldFunc;
         internal static IntPtr getField(IntPtr thisPtr, int index)
         {
         	if (_getFieldFunc == null)
         	{
         		_getFieldFunc =
         			(_getField)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_getField"), typeof(_getField));
         	}
         
         	return  _getFieldFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getDebugInfo(IntPtr thisPtr);
         private static _getDebugInfo _getDebugInfoFunc;
         internal static IntPtr getDebugInfo(IntPtr thisPtr)
         {
         	if (_getDebugInfoFunc == null)
         	{
         		_getDebugInfoFunc =
         			(_getDebugInfo)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_getDebugInfo"), typeof(_getDebugInfo));
         	}
         
         	return  _getDebugInfoFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimObject_create();
         private static _SimObject_create _SimObject_createFunc;
         internal static IntPtr SimObject_create()
         {
         	if (_SimObject_createFunc == null)
         	{
         		_SimObject_createFunc =
         			(_SimObject_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SimObject_create"), typeof(_SimObject_create));
         	}
         
         	return  _SimObject_createFunc();
         }
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _registerObject(IntPtr thisPtr);
         private static _registerObject _registerObjectFunc;
         internal static bool registerObject(IntPtr thisPtr)
         {
         	if (_registerObjectFunc == null)
         	{
         		_registerObjectFunc =
         			(_registerObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_registerObject"), typeof(_registerObject));
         	}
         
         	return  _registerObjectFunc(thisPtr);
         }
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _CopyFrom(IntPtr thisPtr, IntPtr parent);
         private static _CopyFrom _CopyFromFunc;
         internal static void CopyFrom(IntPtr thisPtr, IntPtr parent)
         {
         	if (_CopyFromFunc == null)
         	{
         		_CopyFromFunc =
         			(_CopyFrom)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_CopyFrom"), typeof(_CopyFrom));
         	}
         
         	 _CopyFromFunc(thisPtr, parent);
         }
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SetMods(IntPtr thisPtr, bool modStaticFields, bool modDynamicFields);
         private static _SetMods _SetModsFunc;
         internal static void SetMods(IntPtr thisPtr, bool modStaticFields, bool modDynamicFields)
         {
         	if (_SetModsFunc == null)
         	{
         		_SetModsFunc =
         			(_SetMods)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimObject_SetMods"), typeof(_SetMods));
         	}
         
         	 _SetModsFunc(thisPtr, modStaticFields, modDynamicFields);
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void dumpGroupHierarchy()
         {
            InternalUnsafeMethods.dumpGroupHierarchy(ObjectPtr);
         }
      
         public virtual bool isMethod(string methodName)
         {
            return InternalUnsafeMethods.isMethod(ObjectPtr, methodName);
         }
      
         public virtual bool isChildOfGroup(SimGroup group)
         {
            return InternalUnsafeMethods.isChildOfGroup(ObjectPtr, group.ObjectPtr);
         }
      
         public virtual string getClassNamespace()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getClassNamespace(ObjectPtr));
         }
      
         public virtual string getSuperClassNamespace()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getSuperClassNamespace(ObjectPtr));
         }
      
         public virtual void setClassNamespace(string name)
         {
            InternalUnsafeMethods.setClassNamespace(ObjectPtr, name);
         }
      
         public virtual void setSuperClassNamespace(string name)
         {
            InternalUnsafeMethods.setSuperClassNamespace(ObjectPtr, name);
         }
      
         public virtual bool isSelected()
         {
            return InternalUnsafeMethods.isSelected(ObjectPtr);
         }
      
         public virtual void setIsSelected(bool state = true)
         {
            InternalUnsafeMethods.setIsSelected(ObjectPtr, state);
         }
      
         public virtual bool isExpanded()
         {
            return InternalUnsafeMethods.isExpanded(ObjectPtr);
         }
      
         public virtual void setIsExpanded(bool state = true)
         {
            InternalUnsafeMethods.setIsExpanded(ObjectPtr, state);
         }
      
         public virtual string getFilename()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getFilename(ObjectPtr));
         }
      
         public virtual void setFilename(string fileName)
         {
            InternalUnsafeMethods.setFilename(ObjectPtr, fileName);
         }
      
         public virtual int getDeclarationLine()
         {
            return InternalUnsafeMethods.getDeclarationLine(ObjectPtr);
         }
      
         public virtual void assignFieldsFrom(SimObject fromObject)
         {
            InternalUnsafeMethods.assignFieldsFrom(ObjectPtr, fromObject.ObjectPtr);
         }
      
         public virtual void assignPersistentId()
         {
            InternalUnsafeMethods.assignPersistentId(ObjectPtr);
         }
      
         public virtual bool getCanSave()
         {
            return InternalUnsafeMethods.getCanSave(ObjectPtr);
         }
      
         public virtual void setCanSave(bool value = true)
         {
            InternalUnsafeMethods.setCanSave(ObjectPtr, value);
         }
      
         public virtual bool isEditorOnly()
         {
            return InternalUnsafeMethods.isEditorOnly(ObjectPtr);
         }
      
         public virtual void setEditorOnly(bool value = true)
         {
            InternalUnsafeMethods.setEditorOnly(ObjectPtr, value);
         }
      
         public virtual bool isNameChangeAllowed()
         {
            return InternalUnsafeMethods.isNameChangeAllowed(ObjectPtr);
         }
      
         public virtual void setNameChangeAllowed(bool value = true)
         {
            InternalUnsafeMethods.setNameChangeAllowed(ObjectPtr, value);
         }
      
         public virtual SimObject clone()
         {
            return new SimObject(InternalUnsafeMethods.clone(ObjectPtr));
         }
      
         public virtual SimObject deepClone()
         {
            return new SimObject(InternalUnsafeMethods.deepClone(ObjectPtr));
         }
      
         public virtual void setLocked(bool value = true)
         {
            InternalUnsafeMethods.setLocked(ObjectPtr, value);
         }
      
         public virtual void setHidden(bool value = true)
         {
            InternalUnsafeMethods.setHidden(ObjectPtr, value);
         }
      
         public virtual ArrayObject dumpMethods()
         {
            return new ArrayObject(InternalUnsafeMethods.dumpMethods(ObjectPtr));
         }
      
         public virtual void dump(bool detailed = false)
         {
            InternalUnsafeMethods.dump(ObjectPtr, detailed);
         }
      
         public virtual bool save(string fileName, bool selectedOnly = false, string preAppendString = "")
         {
            return InternalUnsafeMethods.save(ObjectPtr, fileName, selectedOnly, preAppendString);
         }
      
         public virtual void setName(string newName)
         {
            InternalUnsafeMethods.setName(ObjectPtr, newName);
         }
      
         public virtual string getName()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getName(ObjectPtr));
         }
      
         public virtual string getClassName()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getClassName(ObjectPtr));
         }
      
         public virtual bool isField(string fieldName)
         {
            return InternalUnsafeMethods.isField(ObjectPtr, fieldName);
         }
      
         public virtual string getFieldValue(string fieldName, int index = -1)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getFieldValue(ObjectPtr, fieldName, index));
         }
      
         public virtual bool setFieldValue(string fieldName, string value, int index = -1)
         {
            return InternalUnsafeMethods.setFieldValue(ObjectPtr, fieldName, value, index);
         }
      
         public virtual string getFieldType(string fieldName)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getFieldType(ObjectPtr, fieldName));
         }
      
         public virtual void setFieldType(string fieldName, string type)
         {
            InternalUnsafeMethods.setFieldType(ObjectPtr, fieldName, type);
         }
      
         public virtual string call(string method, params string[] args)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.Add(method.ToString());
                  tmp_arg_list.AddRange(args);
                  return Marshal.PtrToStringAnsi(InternalUnsafeMethods.call(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
         public virtual void setInternalName(string newInternalName)
         {
            InternalUnsafeMethods.setInternalName(ObjectPtr, newInternalName);
         }
      
         public virtual string getInternalName()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getInternalName(ObjectPtr));
         }
      
         public virtual void dumpClassHierarchy()
         {
            InternalUnsafeMethods.dumpClassHierarchy(ObjectPtr);
         }
      
         public virtual bool isMemberOfClass(string className)
         {
            return InternalUnsafeMethods.isMemberOfClass(ObjectPtr, className);
         }
      
         public virtual bool isInNamespaceHierarchy(string name)
         {
            return InternalUnsafeMethods.isInNamespaceHierarchy(ObjectPtr, name);
         }
      
         public virtual int getId()
         {
            return InternalUnsafeMethods.getId(ObjectPtr);
         }
      
         public virtual SimGroup getGroup()
         {
            return new SimGroup(InternalUnsafeMethods.getGroup(ObjectPtr));
         }
      
         public virtual void delete()
         {
            InternalUnsafeMethods.delete(ObjectPtr);
         }
      
         public virtual int schedule(float time, string method, params string[] args)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.Add(time.ToString());
                  tmp_arg_list.Add(method.ToString());
                  tmp_arg_list.AddRange(args);
                  return InternalUnsafeMethods.schedule(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual int getDynamicFieldCount()
         {
            return InternalUnsafeMethods.getDynamicFieldCount(ObjectPtr);
         }
      
         public virtual string getDynamicField(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getDynamicField(ObjectPtr, index));
         }
      
         public virtual int getFieldCount()
         {
            return InternalUnsafeMethods.getFieldCount(ObjectPtr);
         }
      
         public virtual string getField(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getField(ObjectPtr, index));
         }
      
         public virtual ArrayObject getDebugInfo()
         {
            return new ArrayObject(InternalUnsafeMethods.getDebugInfo(ObjectPtr));
         }
      
         public virtual bool registerObject()
         {
            bool registered = InternalUnsafeMethods.registerObject(ObjectPtr);
            if (registered) SimDictionary.RegisterObject(this);
            return registered;
         }
      
         public virtual bool registerSingleton()
         {
            return registerObject();
         }
      
         public virtual void CopyFrom(SimObject parent)
         {
            InternalUnsafeMethods.CopyFrom(ObjectPtr, parent.ObjectPtr);
         }
      
         public virtual void SetMods(bool modStaticFields, bool modDynamicFields)
         {
            InternalUnsafeMethods.SetMods(ObjectPtr, modStaticFields, modDynamicFields);
         }
      
      
      #endregion


      #region Properties
      
      
         public string Name
         {
         	get { return getFieldValue("Name"); }
         	set { setFieldValue("Name", value); }
         }
      
         public string InternalName
         {
         	get { return getFieldValue("InternalName"); }
         	set { setFieldValue("InternalName", value); }
         }
      
         public SimObject ParentGroup
         {
         	get { return Sim.FindObject<SimObject>(getFieldValue("ParentGroup")); }
         	set { setFieldValue("ParentGroup", value.getId().ToString()); }
         }
      
         public string Class
         {
         	get { return getFieldValue("Class"); }
         	set { setFieldValue("Class", value); }
         }
      
         public string SuperClass
         {
         	get { return getFieldValue("SuperClass"); }
         	set { setFieldValue("SuperClass", value); }
         }
      
         public string ClassName
         {
         	get { return getFieldValue("ClassName"); }
         	set { setFieldValue("ClassName", value); }
         }
      
         public bool Hidden
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Hidden")); }
         	set { setFieldValue("Hidden", value ? "1" : "0"); }
         }
      
         public bool Locked
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Locked")); }
         	set { setFieldValue("Locked", value ? "1" : "0"); }
         }
      
         public bool CanSave
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CanSave")); }
         	set { setFieldValue("CanSave", value ? "1" : "0"); }
         }
      
         public bool CanSaveDynamicFields
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CanSaveDynamicFields")); }
         	set { setFieldValue("CanSaveDynamicFields", value ? "1" : "0"); }
         }
      
         public string PersistentId
         {
         	get { return getFieldValue("PersistentId"); }
         	set { setFieldValue("PersistentId", value); }
         }


      #endregion

	   #region Implicits and operators

	   public static bool operator ==(SimObject obj, string str)
	   {
	      if (str == null) return ReferenceEquals(obj, null);
	      if (ReferenceEquals(obj, null)) return false;
	      return obj.Name == str || obj.getId().ToString().Equals(str);
	   }

	   public static bool operator !=(SimObject obj, string str)
	   {
	      return !(obj == str);
      }

      public static bool operator ==(SimObject obj, object other)
      {
         if (ReferenceEquals(other, null)) return ReferenceEquals(obj, null);
         if (ReferenceEquals(obj, null)) return false;
         string str = other as string;
         if (str != null)
         {
            return obj.Name == str || obj.getId().ToString().Equals(str);
         }
         SimObject sobj = other as SimObject;
         if(sobj != null)
            return obj.ObjectPtr == sobj.ObjectPtr;
         return obj.Equals(other);
      }

      public static bool operator !=(SimObject obj, object other)
      {
         return !(obj == other);
      }

      #endregion
   }
}