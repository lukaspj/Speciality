using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class CreatorTree : GuiArrayCtrl
	{
		public CreatorTree(bool pRegister = false)
			: base(pRegister)
		{
		}

		public CreatorTree(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public CreatorTree(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public CreatorTree(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public CreatorTree(SimObject pObj) : base(pObj)
		{
		}

		public CreatorTree(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.CreatorTree_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _addGroup(IntPtr thisPtr, int group, [MarshalAs(UnmanagedType.LPWStr)]string name, [MarshalAs(UnmanagedType.LPWStr)]string value);
         private static _addGroup _addGroupFunc;
         internal static int addGroup(IntPtr thisPtr, int group, [MarshalAs(UnmanagedType.LPWStr)]string name, [MarshalAs(UnmanagedType.LPWStr)]string value)
         {
         	if (_addGroupFunc == null)
         	{
         		_addGroupFunc =
         			(_addGroup)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCreatorTree_addGroup"), typeof(_addGroup));
         	}
         
         	return  _addGroupFunc(thisPtr, group, name, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _addItem(IntPtr thisPtr, int group, [MarshalAs(UnmanagedType.LPWStr)]string name, [MarshalAs(UnmanagedType.LPWStr)]string value);
         private static _addItem _addItemFunc;
         internal static int addItem(IntPtr thisPtr, int group, [MarshalAs(UnmanagedType.LPWStr)]string name, [MarshalAs(UnmanagedType.LPWStr)]string value)
         {
         	if (_addItemFunc == null)
         	{
         		_addItemFunc =
         			(_addItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCreatorTree_addItem"), typeof(_addItem));
         	}
         
         	return  _addItemFunc(thisPtr, group, name, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _fileNameMatch(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string world, [MarshalAs(UnmanagedType.LPWStr)]string type, [MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _fileNameMatch _fileNameMatchFunc;
         internal static bool fileNameMatch(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string world, [MarshalAs(UnmanagedType.LPWStr)]string type, [MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_fileNameMatchFunc == null)
         	{
         		_fileNameMatchFunc =
         			(_fileNameMatch)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCreatorTree_fileNameMatch"), typeof(_fileNameMatch));
         	}
         
         	return  _fileNameMatchFunc(thisPtr, world, type, filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSelected(IntPtr thisPtr);
         private static _getSelected _getSelectedFunc;
         internal static int getSelected(IntPtr thisPtr)
         {
         	if (_getSelectedFunc == null)
         	{
         		_getSelectedFunc =
         			(_getSelected)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCreatorTree_getSelected"), typeof(_getSelected));
         	}
         
         	return  _getSelectedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isGroup(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string group);
         private static _isGroup _isGroupFunc;
         internal static bool isGroup(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string group)
         {
         	if (_isGroupFunc == null)
         	{
         		_isGroupFunc =
         			(_isGroup)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCreatorTree_isGroup"), typeof(_isGroup));
         	}
         
         	return  _isGroupFunc(thisPtr, group);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string item);
         private static _getName _getNameFunc;
         internal static IntPtr getName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string item)
         {
         	if (_getNameFunc == null)
         	{
         		_getNameFunc =
         			(_getName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCreatorTree_getName"), typeof(_getName));
         	}
         
         	return  _getNameFunc(thisPtr, item);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getValue(IntPtr thisPtr, int nodeValue);
         private static _getValue _getValueFunc;
         internal static IntPtr getValue(IntPtr thisPtr, int nodeValue)
         {
         	if (_getValueFunc == null)
         	{
         		_getValueFunc =
         			(_getValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCreatorTree_getValue"), typeof(_getValue));
         	}
         
         	return  _getValueFunc(thisPtr, nodeValue);
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
         				"fnCreatorTree_clear"), typeof(_clear));
         	}
         
         	 _clearFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getParent(IntPtr thisPtr, int nodeValue);
         private static _getParent _getParentFunc;
         internal static int getParent(IntPtr thisPtr, int nodeValue)
         {
         	if (_getParentFunc == null)
         	{
         		_getParentFunc =
         			(_getParent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCreatorTree_getParent"), typeof(_getParent));
         	}
         
         	return  _getParentFunc(thisPtr, nodeValue);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _CreatorTree_create();
         private static _CreatorTree_create _CreatorTree_createFunc;
         internal static IntPtr CreatorTree_create()
         {
         	if (_CreatorTree_createFunc == null)
         	{
         		_CreatorTree_createFunc =
         			(_CreatorTree_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CreatorTree_create"), typeof(_CreatorTree_create));
         	}
         
         	return  _CreatorTree_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int addGroup(int group, string name, string value)
         {
            return InternalUnsafeMethods.addGroup(ObjectPtr, group, name, value);
         }
      
         public virtual int addItem(int group, string name, string value)
         {
            return InternalUnsafeMethods.addItem(ObjectPtr, group, name, value);
         }
      
         public virtual bool fileNameMatch(string world, string type, string filename)
         {
            return InternalUnsafeMethods.fileNameMatch(ObjectPtr, world, type, filename);
         }
      
         public virtual int getSelected()
         {
            return InternalUnsafeMethods.getSelected(ObjectPtr);
         }
      
         public virtual bool isGroup(string group)
         {
            return InternalUnsafeMethods.isGroup(ObjectPtr, group);
         }
      
         public virtual string getName(string item)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getName(ObjectPtr, item));
         }
      
         public virtual string getValue(int nodeValue)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getValue(ObjectPtr, nodeValue));
         }
      
         public virtual void clear()
         {
            InternalUnsafeMethods.clear(ObjectPtr);
         }
      
         public virtual int getParent(int nodeValue)
         {
            return InternalUnsafeMethods.getParent(ObjectPtr, nodeValue);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}