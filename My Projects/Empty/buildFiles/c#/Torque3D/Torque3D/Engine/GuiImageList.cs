using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiImageList : SimObject
	{
		public GuiImageList(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiImageList(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiImageList(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiImageList(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiImageList(SimObject pObj) : base(pObj)
		{
		}

		public GuiImageList(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiImageList_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getImage(IntPtr thisPtr, int index);
         private static _getImage _getImageFunc;
         internal static IntPtr getImage(IntPtr thisPtr, int index)
         {
         	if (_getImageFunc == null)
         	{
         		_getImageFunc =
         			(_getImage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiImageList_getImage"), typeof(_getImage));
         	}
         
         	return  _getImageFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _clear(IntPtr thisPtr);
         private static _clear _clearFunc;
         internal static bool clear(IntPtr thisPtr)
         {
         	if (_clearFunc == null)
         	{
         		_clearFunc =
         			(_clear)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiImageList_clear"), typeof(_clear));
         	}
         
         	return  _clearFunc(thisPtr);
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
         				"fnGuiImageList_count"), typeof(_count));
         	}
         
         	return  _countFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _remove(IntPtr thisPtr, int index);
         private static _remove _removeFunc;
         internal static bool remove(IntPtr thisPtr, int index)
         {
         	if (_removeFunc == null)
         	{
         		_removeFunc =
         			(_remove)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiImageList_remove"), typeof(_remove));
         	}
         
         	return  _removeFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getIndex(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string imagePath);
         private static _getIndex _getIndexFunc;
         internal static int getIndex(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string imagePath)
         {
         	if (_getIndexFunc == null)
         	{
         		_getIndexFunc =
         			(_getIndex)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiImageList_getIndex"), typeof(_getIndex));
         	}
         
         	return  _getIndexFunc(thisPtr, imagePath);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _insert(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string imagePath);
         private static _insert _insertFunc;
         internal static int insert(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string imagePath)
         {
         	if (_insertFunc == null)
         	{
         		_insertFunc =
         			(_insert)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiImageList_insert"), typeof(_insert));
         	}
         
         	return  _insertFunc(thisPtr, imagePath);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiImageList_create();
         private static _GuiImageList_create _GuiImageList_createFunc;
         internal static IntPtr GuiImageList_create()
         {
         	if (_GuiImageList_createFunc == null)
         	{
         		_GuiImageList_createFunc =
         			(_GuiImageList_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiImageList_create"), typeof(_GuiImageList_create));
         	}
         
         	return  _GuiImageList_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual string getImage(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getImage(ObjectPtr, index));
         }
      
         public virtual bool clear()
         {
            return InternalUnsafeMethods.clear(ObjectPtr);
         }
      
         public virtual int count()
         {
            return InternalUnsafeMethods.count(ObjectPtr);
         }
      
         public virtual bool remove(int index)
         {
            return InternalUnsafeMethods.remove(ObjectPtr, index);
         }
      
         public virtual int getIndex(string imagePath)
         {
            return InternalUnsafeMethods.getIndex(ObjectPtr, imagePath);
         }
      
         public virtual int insert(string imagePath)
         {
            return InternalUnsafeMethods.insert(ObjectPtr, imagePath);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}