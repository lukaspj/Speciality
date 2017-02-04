using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ArrayObject : SimObject
	{
		public ArrayObject(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ArrayObject(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ArrayObject(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ArrayObject(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ArrayObject(SimObject pObj) : base(pObj)
		{
		}

		public ArrayObject(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ArrayObject_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getIndexFromValue(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string value);
         private static _getIndexFromValue _getIndexFromValueFunc;
         internal static int getIndexFromValue(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string value)
         {
         	if (_getIndexFromValueFunc == null)
         	{
         		_getIndexFromValueFunc =
         			(_getIndexFromValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_getIndexFromValue"), typeof(_getIndexFromValue));
         	}
         
         	return  _getIndexFromValueFunc(thisPtr, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getIndexFromKey(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string key);
         private static _getIndexFromKey _getIndexFromKeyFunc;
         internal static int getIndexFromKey(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string key)
         {
         	if (_getIndexFromKeyFunc == null)
         	{
         		_getIndexFromKeyFunc =
         			(_getIndexFromKey)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_getIndexFromKey"), typeof(_getIndexFromKey));
         	}
         
         	return  _getIndexFromKeyFunc(thisPtr, key);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getValue(IntPtr thisPtr, int index);
         private static _getValue _getValueFunc;
         internal static IntPtr getValue(IntPtr thisPtr, int index)
         {
         	if (_getValueFunc == null)
         	{
         		_getValueFunc =
         			(_getValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_getValue"), typeof(_getValue));
         	}
         
         	return  _getValueFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getKey(IntPtr thisPtr, int index);
         private static _getKey _getKeyFunc;
         internal static IntPtr getKey(IntPtr thisPtr, int index)
         {
         	if (_getKeyFunc == null)
         	{
         		_getKeyFunc =
         			(_getKey)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_getKey"), typeof(_getKey));
         	}
         
         	return  _getKeyFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setKey(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string key, int index);
         private static _setKey _setKeyFunc;
         internal static void setKey(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string key, int index)
         {
         	if (_setKeyFunc == null)
         	{
         		_setKeyFunc =
         			(_setKey)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_setKey"), typeof(_setKey));
         	}
         
         	 _setKeyFunc(thisPtr, key, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setValue(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string value, int index);
         private static _setValue _setValueFunc;
         internal static void setValue(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string value, int index)
         {
         	if (_setValueFunc == null)
         	{
         		_setValueFunc =
         			(_setValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_setValue"), typeof(_setValue));
         	}
         
         	 _setValueFunc(thisPtr, value, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _count(IntPtr thisPtr);
         private static _count _countFunc;
         internal static int count(IntPtr thisPtr)
         {
         	if (_countFunc == null)
         	{
         		_countFunc =
         			(_count)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_count"), typeof(_count));
         	}
         
         	return  _countFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _countValue(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string value);
         private static _countValue _countValueFunc;
         internal static int countValue(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string value)
         {
         	if (_countValueFunc == null)
         	{
         		_countValueFunc =
         			(_countValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_countValue"), typeof(_countValue));
         	}
         
         	return  _countValueFunc(thisPtr, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _countKey(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string key);
         private static _countKey _countKeyFunc;
         internal static int countKey(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string key)
         {
         	if (_countKeyFunc == null)
         	{
         		_countKeyFunc =
         			(_countKey)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_countKey"), typeof(_countKey));
         	}
         
         	return  _countKeyFunc(thisPtr, key);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _add(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string key, [MarshalAs(UnmanagedType.LPWStr)]string value);
         private static _add _addFunc;
         internal static void add(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string key, [MarshalAs(UnmanagedType.LPWStr)]string value)
         {
         	if (_addFunc == null)
         	{
         		_addFunc =
         			(_add)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_add"), typeof(_add));
         	}
         
         	 _addFunc(thisPtr, key, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _push_back(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string key, [MarshalAs(UnmanagedType.LPWStr)]string value);
         private static _push_back _push_backFunc;
         internal static void push_back(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string key, [MarshalAs(UnmanagedType.LPWStr)]string value)
         {
         	if (_push_backFunc == null)
         	{
         		_push_backFunc =
         			(_push_back)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_push_back"), typeof(_push_back));
         	}
         
         	 _push_backFunc(thisPtr, key, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _push_front(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string key, [MarshalAs(UnmanagedType.LPWStr)]string value);
         private static _push_front _push_frontFunc;
         internal static void push_front(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string key, [MarshalAs(UnmanagedType.LPWStr)]string value)
         {
         	if (_push_frontFunc == null)
         	{
         		_push_frontFunc =
         			(_push_front)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_push_front"), typeof(_push_front));
         	}
         
         	 _push_frontFunc(thisPtr, key, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _insert(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string key, [MarshalAs(UnmanagedType.LPWStr)]string value, int index);
         private static _insert _insertFunc;
         internal static void insert(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string key, [MarshalAs(UnmanagedType.LPWStr)]string value, int index)
         {
         	if (_insertFunc == null)
         	{
         		_insertFunc =
         			(_insert)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_insert"), typeof(_insert));
         	}
         
         	 _insertFunc(thisPtr, key, value, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _pop_back(IntPtr thisPtr);
         private static _pop_back _pop_backFunc;
         internal static void pop_back(IntPtr thisPtr)
         {
         	if (_pop_backFunc == null)
         	{
         		_pop_backFunc =
         			(_pop_back)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_pop_back"), typeof(_pop_back));
         	}
         
         	 _pop_backFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _pop_front(IntPtr thisPtr);
         private static _pop_front _pop_frontFunc;
         internal static void pop_front(IntPtr thisPtr)
         {
         	if (_pop_frontFunc == null)
         	{
         		_pop_frontFunc =
         			(_pop_front)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_pop_front"), typeof(_pop_front));
         	}
         
         	 _pop_frontFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _erase(IntPtr thisPtr, int index);
         private static _erase _eraseFunc;
         internal static void erase(IntPtr thisPtr, int index)
         {
         	if (_eraseFunc == null)
         	{
         		_eraseFunc =
         			(_erase)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_erase"), typeof(_erase));
         	}
         
         	 _eraseFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _empty(IntPtr thisPtr);
         private static _empty _emptyFunc;
         internal static void empty(IntPtr thisPtr)
         {
         	if (_emptyFunc == null)
         	{
         		_emptyFunc =
         			(_empty)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_empty"), typeof(_empty));
         	}
         
         	 _emptyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _uniqueValue(IntPtr thisPtr);
         private static _uniqueValue _uniqueValueFunc;
         internal static void uniqueValue(IntPtr thisPtr)
         {
         	if (_uniqueValueFunc == null)
         	{
         		_uniqueValueFunc =
         			(_uniqueValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_uniqueValue"), typeof(_uniqueValue));
         	}
         
         	 _uniqueValueFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _uniqueKey(IntPtr thisPtr);
         private static _uniqueKey _uniqueKeyFunc;
         internal static void uniqueKey(IntPtr thisPtr)
         {
         	if (_uniqueKeyFunc == null)
         	{
         		_uniqueKeyFunc =
         			(_uniqueKey)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_uniqueKey"), typeof(_uniqueKey));
         	}
         
         	 _uniqueKeyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _duplicate(IntPtr thisPtr, IntPtr target);
         private static _duplicate _duplicateFunc;
         internal static bool duplicate(IntPtr thisPtr, IntPtr target)
         {
         	if (_duplicateFunc == null)
         	{
         		_duplicateFunc =
         			(_duplicate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_duplicate"), typeof(_duplicate));
         	}
         
         	return  _duplicateFunc(thisPtr, target);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _crop(IntPtr thisPtr, IntPtr target);
         private static _crop _cropFunc;
         internal static bool crop(IntPtr thisPtr, IntPtr target)
         {
         	if (_cropFunc == null)
         	{
         		_cropFunc =
         			(_crop)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_crop"), typeof(_crop));
         	}
         
         	return  _cropFunc(thisPtr, target);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _append(IntPtr thisPtr, IntPtr target);
         private static _append _appendFunc;
         internal static bool append(IntPtr thisPtr, IntPtr target)
         {
         	if (_appendFunc == null)
         	{
         		_appendFunc =
         			(_append)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_append"), typeof(_append));
         	}
         
         	return  _appendFunc(thisPtr, target);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sort(IntPtr thisPtr, bool ascending);
         private static _sort _sortFunc;
         internal static void sort(IntPtr thisPtr, bool ascending)
         {
         	if (_sortFunc == null)
         	{
         		_sortFunc =
         			(_sort)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_sort"), typeof(_sort));
         	}
         
         	 _sortFunc(thisPtr, ascending);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sorta(IntPtr thisPtr);
         private static _sorta _sortaFunc;
         internal static void sorta(IntPtr thisPtr)
         {
         	if (_sortaFunc == null)
         	{
         		_sortaFunc =
         			(_sorta)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_sorta"), typeof(_sorta));
         	}
         
         	 _sortaFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sortd(IntPtr thisPtr);
         private static _sortd _sortdFunc;
         internal static void sortd(IntPtr thisPtr)
         {
         	if (_sortdFunc == null)
         	{
         		_sortdFunc =
         			(_sortd)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_sortd"), typeof(_sortd));
         	}
         
         	 _sortdFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sortk(IntPtr thisPtr, bool ascending);
         private static _sortk _sortkFunc;
         internal static void sortk(IntPtr thisPtr, bool ascending)
         {
         	if (_sortkFunc == null)
         	{
         		_sortkFunc =
         			(_sortk)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_sortk"), typeof(_sortk));
         	}
         
         	 _sortkFunc(thisPtr, ascending);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sortka(IntPtr thisPtr);
         private static _sortka _sortkaFunc;
         internal static void sortka(IntPtr thisPtr)
         {
         	if (_sortkaFunc == null)
         	{
         		_sortkaFunc =
         			(_sortka)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_sortka"), typeof(_sortka));
         	}
         
         	 _sortkaFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sortkd(IntPtr thisPtr);
         private static _sortkd _sortkdFunc;
         internal static void sortkd(IntPtr thisPtr)
         {
         	if (_sortkdFunc == null)
         	{
         		_sortkdFunc =
         			(_sortkd)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_sortkd"), typeof(_sortkd));
         	}
         
         	 _sortkdFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sortn(IntPtr thisPtr, bool ascending);
         private static _sortn _sortnFunc;
         internal static void sortn(IntPtr thisPtr, bool ascending)
         {
         	if (_sortnFunc == null)
         	{
         		_sortnFunc =
         			(_sortn)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_sortn"), typeof(_sortn));
         	}
         
         	 _sortnFunc(thisPtr, ascending);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sortna(IntPtr thisPtr);
         private static _sortna _sortnaFunc;
         internal static void sortna(IntPtr thisPtr)
         {
         	if (_sortnaFunc == null)
         	{
         		_sortnaFunc =
         			(_sortna)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_sortna"), typeof(_sortna));
         	}
         
         	 _sortnaFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sortnd(IntPtr thisPtr);
         private static _sortnd _sortndFunc;
         internal static void sortnd(IntPtr thisPtr)
         {
         	if (_sortndFunc == null)
         	{
         		_sortndFunc =
         			(_sortnd)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_sortnd"), typeof(_sortnd));
         	}
         
         	 _sortndFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sortnk(IntPtr thisPtr, bool ascending);
         private static _sortnk _sortnkFunc;
         internal static void sortnk(IntPtr thisPtr, bool ascending)
         {
         	if (_sortnkFunc == null)
         	{
         		_sortnkFunc =
         			(_sortnk)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_sortnk"), typeof(_sortnk));
         	}
         
         	 _sortnkFunc(thisPtr, ascending);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sortnka(IntPtr thisPtr);
         private static _sortnka _sortnkaFunc;
         internal static void sortnka(IntPtr thisPtr)
         {
         	if (_sortnkaFunc == null)
         	{
         		_sortnkaFunc =
         			(_sortnka)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_sortnka"), typeof(_sortnka));
         	}
         
         	 _sortnkaFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sortnkd(IntPtr thisPtr);
         private static _sortnkd _sortnkdFunc;
         internal static void sortnkd(IntPtr thisPtr)
         {
         	if (_sortnkdFunc == null)
         	{
         		_sortnkdFunc =
         			(_sortnkd)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_sortnkd"), typeof(_sortnkd));
         	}
         
         	 _sortnkdFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sortf(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string functionName);
         private static _sortf _sortfFunc;
         internal static void sortf(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string functionName)
         {
         	if (_sortfFunc == null)
         	{
         		_sortfFunc =
         			(_sortf)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_sortf"), typeof(_sortf));
         	}
         
         	 _sortfFunc(thisPtr, functionName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sortfk(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string functionName);
         private static _sortfk _sortfkFunc;
         internal static void sortfk(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string functionName)
         {
         	if (_sortfkFunc == null)
         	{
         		_sortfkFunc =
         			(_sortfk)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_sortfk"), typeof(_sortfk));
         	}
         
         	 _sortfkFunc(thisPtr, functionName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sortfd(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string functionName);
         private static _sortfd _sortfdFunc;
         internal static void sortfd(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string functionName)
         {
         	if (_sortfdFunc == null)
         	{
         		_sortfdFunc =
         			(_sortfd)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_sortfd"), typeof(_sortfd));
         	}
         
         	 _sortfdFunc(thisPtr, functionName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sortfkd(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string functionName);
         private static _sortfkd _sortfkdFunc;
         internal static void sortfkd(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string functionName)
         {
         	if (_sortfkdFunc == null)
         	{
         		_sortfkdFunc =
         			(_sortfkd)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_sortfkd"), typeof(_sortfkd));
         	}
         
         	 _sortfkdFunc(thisPtr, functionName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _moveFirst(IntPtr thisPtr);
         private static _moveFirst _moveFirstFunc;
         internal static int moveFirst(IntPtr thisPtr)
         {
         	if (_moveFirstFunc == null)
         	{
         		_moveFirstFunc =
         			(_moveFirst)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_moveFirst"), typeof(_moveFirst));
         	}
         
         	return  _moveFirstFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _moveLast(IntPtr thisPtr);
         private static _moveLast _moveLastFunc;
         internal static int moveLast(IntPtr thisPtr)
         {
         	if (_moveLastFunc == null)
         	{
         		_moveLastFunc =
         			(_moveLast)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_moveLast"), typeof(_moveLast));
         	}
         
         	return  _moveLastFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _moveNext(IntPtr thisPtr);
         private static _moveNext _moveNextFunc;
         internal static int moveNext(IntPtr thisPtr)
         {
         	if (_moveNextFunc == null)
         	{
         		_moveNextFunc =
         			(_moveNext)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_moveNext"), typeof(_moveNext));
         	}
         
         	return  _moveNextFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _movePrev(IntPtr thisPtr);
         private static _movePrev _movePrevFunc;
         internal static int movePrev(IntPtr thisPtr)
         {
         	if (_movePrevFunc == null)
         	{
         		_movePrevFunc =
         			(_movePrev)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_movePrev"), typeof(_movePrev));
         	}
         
         	return  _movePrevFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getCurrent(IntPtr thisPtr);
         private static _getCurrent _getCurrentFunc;
         internal static int getCurrent(IntPtr thisPtr)
         {
         	if (_getCurrentFunc == null)
         	{
         		_getCurrentFunc =
         			(_getCurrent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_getCurrent"), typeof(_getCurrent));
         	}
         
         	return  _getCurrentFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setCurrent(IntPtr thisPtr, int index);
         private static _setCurrent _setCurrentFunc;
         internal static void setCurrent(IntPtr thisPtr, int index)
         {
         	if (_setCurrentFunc == null)
         	{
         		_setCurrentFunc =
         			(_setCurrent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_setCurrent"), typeof(_setCurrent));
         	}
         
         	 _setCurrentFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _echo(IntPtr thisPtr);
         private static _echo _echoFunc;
         internal static void echo(IntPtr thisPtr)
         {
         	if (_echoFunc == null)
         	{
         		_echoFunc =
         			(_echo)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnArrayObject_echo"), typeof(_echo));
         	}
         
         	 _echoFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ArrayObject_create();
         private static _ArrayObject_create _ArrayObject_createFunc;
         internal static IntPtr ArrayObject_create()
         {
         	if (_ArrayObject_createFunc == null)
         	{
         		_ArrayObject_createFunc =
         			(_ArrayObject_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ArrayObject_create"), typeof(_ArrayObject_create));
         	}
         
         	return  _ArrayObject_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int getIndexFromValue(string value)
         {
            return InternalUnsafeMethods.getIndexFromValue(ObjectPtr, value);
         }
      
         public virtual int getIndexFromKey(string key)
         {
            return InternalUnsafeMethods.getIndexFromKey(ObjectPtr, key);
         }
      
         public virtual string getValue(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getValue(ObjectPtr, index));
         }
      
         public virtual string getKey(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getKey(ObjectPtr, index));
         }
      
         public virtual void setKey(string key, int index)
         {
            InternalUnsafeMethods.setKey(ObjectPtr, key, index);
         }
      
         public virtual void setValue(string value, int index)
         {
            InternalUnsafeMethods.setValue(ObjectPtr, value, index);
         }
      
         public virtual int count()
         {
            return InternalUnsafeMethods.count(ObjectPtr);
         }
      
         public virtual int countValue(string value)
         {
            return InternalUnsafeMethods.countValue(ObjectPtr, value);
         }
      
         public virtual int countKey(string key)
         {
            return InternalUnsafeMethods.countKey(ObjectPtr, key);
         }
      
         public virtual void add(string key, string value = "")
         {
            InternalUnsafeMethods.add(ObjectPtr, key, value);
         }
      
         public virtual void push_back(string key, string value = "")
         {
            InternalUnsafeMethods.push_back(ObjectPtr, key, value);
         }
      
         public virtual void push_front(string key, string value = "")
         {
            InternalUnsafeMethods.push_front(ObjectPtr, key, value);
         }
      
         public virtual void insert(string key, string value, int index)
         {
            InternalUnsafeMethods.insert(ObjectPtr, key, value, index);
         }
      
         public virtual void pop_back()
         {
            InternalUnsafeMethods.pop_back(ObjectPtr);
         }
      
         public virtual void pop_front()
         {
            InternalUnsafeMethods.pop_front(ObjectPtr);
         }
      
         public virtual void erase(int index)
         {
            InternalUnsafeMethods.erase(ObjectPtr, index);
         }
      
         public virtual void empty()
         {
            InternalUnsafeMethods.empty(ObjectPtr);
         }
      
         public virtual void uniqueValue()
         {
            InternalUnsafeMethods.uniqueValue(ObjectPtr);
         }
      
         public virtual void uniqueKey()
         {
            InternalUnsafeMethods.uniqueKey(ObjectPtr);
         }
      
         public virtual bool duplicate(ArrayObject target)
         {
            return InternalUnsafeMethods.duplicate(ObjectPtr, target.ObjectPtr);
         }
      
         public virtual bool crop(ArrayObject target)
         {
            return InternalUnsafeMethods.crop(ObjectPtr, target.ObjectPtr);
         }
      
         public virtual bool append(ArrayObject target)
         {
            return InternalUnsafeMethods.append(ObjectPtr, target.ObjectPtr);
         }
      
         public virtual void sort(bool ascending = false)
         {
            InternalUnsafeMethods.sort(ObjectPtr, ascending);
         }
      
         public virtual void sorta()
         {
            InternalUnsafeMethods.sorta(ObjectPtr);
         }
      
         public virtual void sortd()
         {
            InternalUnsafeMethods.sortd(ObjectPtr);
         }
      
         public virtual void sortk(bool ascending = false)
         {
            InternalUnsafeMethods.sortk(ObjectPtr, ascending);
         }
      
         public virtual void sortka()
         {
            InternalUnsafeMethods.sortka(ObjectPtr);
         }
      
         public virtual void sortkd()
         {
            InternalUnsafeMethods.sortkd(ObjectPtr);
         }
      
         public virtual void sortn(bool ascending = false)
         {
            InternalUnsafeMethods.sortn(ObjectPtr, ascending);
         }
      
         public virtual void sortna()
         {
            InternalUnsafeMethods.sortna(ObjectPtr);
         }
      
         public virtual void sortnd()
         {
            InternalUnsafeMethods.sortnd(ObjectPtr);
         }
      
         public virtual void sortnk(bool ascending = false)
         {
            InternalUnsafeMethods.sortnk(ObjectPtr, ascending);
         }
      
         public virtual void sortnka()
         {
            InternalUnsafeMethods.sortnka(ObjectPtr);
         }
      
         public virtual void sortnkd()
         {
            InternalUnsafeMethods.sortnkd(ObjectPtr);
         }
      
         public virtual void sortf(string functionName)
         {
            InternalUnsafeMethods.sortf(ObjectPtr, functionName);
         }
      
         public virtual void sortfk(string functionName)
         {
            InternalUnsafeMethods.sortfk(ObjectPtr, functionName);
         }
      
         public virtual void sortfd(string functionName)
         {
            InternalUnsafeMethods.sortfd(ObjectPtr, functionName);
         }
      
         public virtual void sortfkd(string functionName)
         {
            InternalUnsafeMethods.sortfkd(ObjectPtr, functionName);
         }
      
         public virtual int moveFirst()
         {
            return InternalUnsafeMethods.moveFirst(ObjectPtr);
         }
      
         public virtual int moveLast()
         {
            return InternalUnsafeMethods.moveLast(ObjectPtr);
         }
      
         public virtual int moveNext()
         {
            return InternalUnsafeMethods.moveNext(ObjectPtr);
         }
      
         public virtual int movePrev()
         {
            return InternalUnsafeMethods.movePrev(ObjectPtr);
         }
      
         public virtual int getCurrent()
         {
            return InternalUnsafeMethods.getCurrent(ObjectPtr);
         }
      
         public virtual void setCurrent(int index)
         {
            InternalUnsafeMethods.setCurrent(ObjectPtr, index);
         }
      
         public virtual void echo()
         {
            InternalUnsafeMethods.echo(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool CaseSensitive
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CaseSensitive")); }
         	set { setFieldValue("CaseSensitive", value ? "1" : "0"); }
         }
      
         public string Key
         {
         	get { return getFieldValue("Key"); }
         	set { setFieldValue("Key", value); }
         }
      
      
      #endregion

	}
}