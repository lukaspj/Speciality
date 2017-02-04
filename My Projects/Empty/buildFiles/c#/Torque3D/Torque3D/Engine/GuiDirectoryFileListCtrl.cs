using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiDirectoryFileListCtrl : GuiListBoxCtrl
	{
		public GuiDirectoryFileListCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiDirectoryFileListCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiDirectoryFileListCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiDirectoryFileListCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiDirectoryFileListCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiDirectoryFileListCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiDirectoryFileListCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setFilter(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filter);
         private static _setFilter _setFilterFunc;
         internal static void setFilter(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filter)
         {
         	if (_setFilterFunc == null)
         	{
         		_setFilterFunc =
         			(_setFilter)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiDirectoryFileListCtrl_setFilter"), typeof(_setFilter));
         	}
         
         	 _setFilterFunc(thisPtr, filter);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _reload(IntPtr thisPtr);
         private static _reload _reloadFunc;
         internal static void reload(IntPtr thisPtr)
         {
         	if (_reloadFunc == null)
         	{
         		_reloadFunc =
         			(_reload)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiDirectoryFileListCtrl_reload"), typeof(_reload));
         	}
         
         	 _reloadFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setPath(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string path, [MarshalAs(UnmanagedType.LPWStr)]string filter);
         private static _setPath _setPathFunc;
         internal static bool setPath(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string path, [MarshalAs(UnmanagedType.LPWStr)]string filter)
         {
         	if (_setPathFunc == null)
         	{
         		_setPathFunc =
         			(_setPath)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiDirectoryFileListCtrl_setPath"), typeof(_setPath));
         	}
         
         	return  _setPathFunc(thisPtr, path, filter);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getSelectedFiles(IntPtr thisPtr);
         private static _getSelectedFiles _getSelectedFilesFunc;
         internal static IntPtr getSelectedFiles(IntPtr thisPtr)
         {
         	if (_getSelectedFilesFunc == null)
         	{
         		_getSelectedFilesFunc =
         			(_getSelectedFiles)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiDirectoryFileListCtrl_getSelectedFiles"), typeof(_getSelectedFiles));
         	}
         
         	return  _getSelectedFilesFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getSelectedFile(IntPtr thisPtr);
         private static _getSelectedFile _getSelectedFileFunc;
         internal static IntPtr getSelectedFile(IntPtr thisPtr)
         {
         	if (_getSelectedFileFunc == null)
         	{
         		_getSelectedFileFunc =
         			(_getSelectedFile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiDirectoryFileListCtrl_getSelectedFile"), typeof(_getSelectedFile));
         	}
         
         	return  _getSelectedFileFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiDirectoryFileListCtrl_create();
         private static _GuiDirectoryFileListCtrl_create _GuiDirectoryFileListCtrl_createFunc;
         internal static IntPtr GuiDirectoryFileListCtrl_create()
         {
         	if (_GuiDirectoryFileListCtrl_createFunc == null)
         	{
         		_GuiDirectoryFileListCtrl_createFunc =
         			(_GuiDirectoryFileListCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiDirectoryFileListCtrl_create"), typeof(_GuiDirectoryFileListCtrl_create));
         	}
         
         	return  _GuiDirectoryFileListCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setFilter(string filter)
         {
            InternalUnsafeMethods.setFilter(ObjectPtr, filter);
         }
      
         public virtual void reload()
         {
            InternalUnsafeMethods.reload(ObjectPtr);
         }
      
         public virtual bool setPath(string path, string filter)
         {
            return InternalUnsafeMethods.setPath(ObjectPtr, path, filter);
         }
      
         public virtual string getSelectedFiles()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getSelectedFiles(ObjectPtr));
         }
      
         public virtual string getSelectedFile()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getSelectedFile(ObjectPtr));
         }
      
      
      #endregion


      #region Properties
      
      
         public string FilePath
         {
         	get { return getFieldValue("FilePath"); }
         	set { setFieldValue("FilePath", value); }
         }
      
         public string FileFilter
         {
         	get { return getFieldValue("FileFilter"); }
         	set { setFieldValue("FileFilter", value); }
         }
      
      
      #endregion

	}
}