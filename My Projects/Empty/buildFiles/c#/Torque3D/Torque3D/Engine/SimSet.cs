using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SimSet : SimObject
	{
		public SimSet(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SimSet(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SimSet(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SimSet(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SimSet(SimObject pObj) : base(pObj)
		{
		}

		public SimSet(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SimSet_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _listObjects(IntPtr thisPtr);
         private static _listObjects _listObjectsFunc;
         internal static void listObjects(IntPtr thisPtr)
         {
         	if (_listObjectsFunc == null)
         	{
         		_listObjectsFunc =
         			(_listObjects)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimSet_listObjects"), typeof(_listObjects));
         	}
         
         	 _listObjectsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _add(IntPtr thisPtr, int argc, string[] argv);
         private static _add _addFunc;
         internal static void add(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_addFunc == null)
         	{
         		_addFunc =
         			(_add)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimSet_add"), typeof(_add));
         	}
         
         	 _addFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _remove(IntPtr thisPtr, int argc, string[] argv);
         private static _remove _removeFunc;
         internal static void remove(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_removeFunc == null)
         	{
         		_removeFunc =
         			(_remove)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimSet_remove"), typeof(_remove));
         	}
         
         	 _removeFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clear(IntPtr thisPtr);
         private static _clear _clearFunc;
         internal static void clear(IntPtr thisPtr)
         {
         	if (_clearFunc == null)
         	{
         		_clearFunc =
         			(_clear)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimSet_clear"), typeof(_clear));
         	}
         
         	 _clearFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deleteAllObjects(IntPtr thisPtr);
         private static _deleteAllObjects _deleteAllObjectsFunc;
         internal static void deleteAllObjects(IntPtr thisPtr)
         {
         	if (_deleteAllObjectsFunc == null)
         	{
         		_deleteAllObjectsFunc =
         			(_deleteAllObjects)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimSet_deleteAllObjects"), typeof(_deleteAllObjects));
         	}
         
         	 _deleteAllObjectsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getRandom(IntPtr thisPtr);
         private static _getRandom _getRandomFunc;
         internal static IntPtr getRandom(IntPtr thisPtr)
         {
         	if (_getRandomFunc == null)
         	{
         		_getRandomFunc =
         			(_getRandom)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimSet_getRandom"), typeof(_getRandom));
         	}
         
         	return  _getRandomFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _callOnChildren(IntPtr thisPtr, int argc, string[] argv);
         private static _callOnChildren _callOnChildrenFunc;
         internal static void callOnChildren(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_callOnChildrenFunc == null)
         	{
         		_callOnChildrenFunc =
         			(_callOnChildren)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimSet_callOnChildren"), typeof(_callOnChildren));
         	}
         
         	 _callOnChildrenFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _callOnChildrenNoRecurse(IntPtr thisPtr, int argc, string[] argv);
         private static _callOnChildrenNoRecurse _callOnChildrenNoRecurseFunc;
         internal static void callOnChildrenNoRecurse(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_callOnChildrenNoRecurseFunc == null)
         	{
         		_callOnChildrenNoRecurseFunc =
         			(_callOnChildrenNoRecurse)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimSet_callOnChildrenNoRecurse"), typeof(_callOnChildrenNoRecurse));
         	}
         
         	 _callOnChildrenNoRecurseFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _reorderChild(IntPtr thisPtr, IntPtr child1, IntPtr child2);
         private static _reorderChild _reorderChildFunc;
         internal static void reorderChild(IntPtr thisPtr, IntPtr child1, IntPtr child2)
         {
         	if (_reorderChildFunc == null)
         	{
         		_reorderChildFunc =
         			(_reorderChild)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimSet_reorderChild"), typeof(_reorderChild));
         	}
         
         	 _reorderChildFunc(thisPtr, child1, child2);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getCount(IntPtr thisPtr);
         private static _getCount _getCountFunc;
         internal static int getCount(IntPtr thisPtr)
         {
         	if (_getCountFunc == null)
         	{
         		_getCountFunc =
         			(_getCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimSet_getCount"), typeof(_getCount));
         	}
         
         	return  _getCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getFullCount(IntPtr thisPtr);
         private static _getFullCount _getFullCountFunc;
         internal static int getFullCount(IntPtr thisPtr)
         {
         	if (_getFullCountFunc == null)
         	{
         		_getFullCountFunc =
         			(_getFullCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimSet_getFullCount"), typeof(_getFullCount));
         	}
         
         	return  _getFullCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getObject(IntPtr thisPtr, uint index);
         private static _getObject _getObjectFunc;
         internal static IntPtr getObject(IntPtr thisPtr, uint index)
         {
         	if (_getObjectFunc == null)
         	{
         		_getObjectFunc =
         			(_getObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimSet_getObject"), typeof(_getObject));
         	}
         
         	return  _getObjectFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getObjectIndex(IntPtr thisPtr, IntPtr obj);
         private static _getObjectIndex _getObjectIndexFunc;
         internal static int getObjectIndex(IntPtr thisPtr, IntPtr obj)
         {
         	if (_getObjectIndexFunc == null)
         	{
         		_getObjectIndexFunc =
         			(_getObjectIndex)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimSet_getObjectIndex"), typeof(_getObjectIndex));
         	}
         
         	return  _getObjectIndexFunc(thisPtr, obj);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isMember(IntPtr thisPtr, IntPtr obj);
         private static _isMember _isMemberFunc;
         internal static bool isMember(IntPtr thisPtr, IntPtr obj)
         {
         	if (_isMemberFunc == null)
         	{
         		_isMemberFunc =
         			(_isMember)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimSet_isMember"), typeof(_isMember));
         	}
         
         	return  _isMemberFunc(thisPtr, obj);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _findObjectByInternalName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string internalName, bool searchChildren);
         private static _findObjectByInternalName _findObjectByInternalNameFunc;
         internal static IntPtr findObjectByInternalName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string internalName, bool searchChildren)
         {
         	if (_findObjectByInternalNameFunc == null)
         	{
         		_findObjectByInternalNameFunc =
         			(_findObjectByInternalName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimSet_findObjectByInternalName"), typeof(_findObjectByInternalName));
         	}
         
         	return  _findObjectByInternalNameFunc(thisPtr, internalName, searchChildren);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _bringToFront(IntPtr thisPtr, IntPtr obj);
         private static _bringToFront _bringToFrontFunc;
         internal static void bringToFront(IntPtr thisPtr, IntPtr obj)
         {
         	if (_bringToFrontFunc == null)
         	{
         		_bringToFrontFunc =
         			(_bringToFront)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimSet_bringToFront"), typeof(_bringToFront));
         	}
         
         	 _bringToFrontFunc(thisPtr, obj);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _pushToBack(IntPtr thisPtr, IntPtr obj);
         private static _pushToBack _pushToBackFunc;
         internal static void pushToBack(IntPtr thisPtr, IntPtr obj)
         {
         	if (_pushToBackFunc == null)
         	{
         		_pushToBackFunc =
         			(_pushToBack)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimSet_pushToBack"), typeof(_pushToBack));
         	}
         
         	 _pushToBackFunc(thisPtr, obj);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sort(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string callbackFunction);
         private static _sort _sortFunc;
         internal static void sort(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string callbackFunction)
         {
         	if (_sortFunc == null)
         	{
         		_sortFunc =
         			(_sort)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimSet_sort"), typeof(_sort));
         	}
         
         	 _sortFunc(thisPtr, callbackFunction);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _acceptsAsChild(IntPtr thisPtr, IntPtr obj);
         private static _acceptsAsChild _acceptsAsChildFunc;
         internal static bool acceptsAsChild(IntPtr thisPtr, IntPtr obj)
         {
         	if (_acceptsAsChildFunc == null)
         	{
         		_acceptsAsChildFunc =
         			(_acceptsAsChild)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimSet_acceptsAsChild"), typeof(_acceptsAsChild));
         	}
         
         	return  _acceptsAsChildFunc(thisPtr, obj);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimSet_create();
         private static _SimSet_create _SimSet_createFunc;
         internal static IntPtr SimSet_create()
         {
         	if (_SimSet_createFunc == null)
         	{
         		_SimSet_createFunc =
         			(_SimSet_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SimSet_create"), typeof(_SimSet_create));
         	}
         
         	return  _SimSet_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void listObjects()
         {
            InternalUnsafeMethods.listObjects(ObjectPtr);
         }
      
         public virtual void add(params SimObject[] objects)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.AddRange(objects.Select(x => x.getId().ToString()));
                  InternalUnsafeMethods.add(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void remove(params SimObject[] objects)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.AddRange(objects.Select(x => x.getId().ToString()));
                  InternalUnsafeMethods.remove(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void clear()
         {
            InternalUnsafeMethods.clear(ObjectPtr);
         }
      
         public virtual void deleteAllObjects()
         {
            InternalUnsafeMethods.deleteAllObjects(ObjectPtr);
         }
      
         public virtual SimObject getRandom()
         {
            return new SimObject(InternalUnsafeMethods.getRandom(ObjectPtr));
         }
      
         public virtual void callOnChildren(string method, params string[] args)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.Add(method.ToString());
                  tmp_arg_list.AddRange(args);
                  InternalUnsafeMethods.callOnChildren(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void callOnChildrenNoRecurse(string method, params string[] args)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.Add(method.ToString());
                  tmp_arg_list.AddRange(args);
                  InternalUnsafeMethods.callOnChildrenNoRecurse(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void reorderChild(SimObject child1, SimObject child2)
         {
            InternalUnsafeMethods.reorderChild(ObjectPtr, child1.ObjectPtr, child2.ObjectPtr);
         }
      
         public virtual int getCount()
         {
            return InternalUnsafeMethods.getCount(ObjectPtr);
         }
      
         public virtual int getFullCount()
         {
            return InternalUnsafeMethods.getFullCount(ObjectPtr);
         }
      
         public virtual SimObject getObject(uint index)
         {
            return new SimObject(InternalUnsafeMethods.getObject(ObjectPtr, index));
         }
      
         public virtual int getObjectIndex(SimObject obj)
         {
            return InternalUnsafeMethods.getObjectIndex(ObjectPtr, obj.ObjectPtr);
         }
      
         public virtual bool isMember(SimObject obj)
         {
            return InternalUnsafeMethods.isMember(ObjectPtr, obj.ObjectPtr);
         }
      
         public virtual SimObject findObjectByInternalName(string internalName, bool searchChildren = false)
         {
            return new SimObject(InternalUnsafeMethods.findObjectByInternalName(ObjectPtr, internalName, searchChildren));
         }
      
         public virtual void bringToFront(SimObject obj)
         {
            InternalUnsafeMethods.bringToFront(ObjectPtr, obj.ObjectPtr);
         }
      
         public virtual void pushToBack(SimObject obj)
         {
            InternalUnsafeMethods.pushToBack(ObjectPtr, obj.ObjectPtr);
         }
      
         public virtual void sort(string callbackFunction)
         {
            InternalUnsafeMethods.sort(ObjectPtr, callbackFunction);
         }
      
         public virtual bool acceptsAsChild(SimObject obj)
         {
            return InternalUnsafeMethods.acceptsAsChild(ObjectPtr, obj.ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}