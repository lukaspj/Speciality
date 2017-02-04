using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiFileTreeCtrl : GuiTreeViewCtrl
	{
		public GuiFileTreeCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiFileTreeCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiFileTreeCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiFileTreeCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiFileTreeCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiFileTreeCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiFileTreeCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getSelectedPath(IntPtr thisPtr);
         private static _getSelectedPath _getSelectedPathFunc;
         internal static IntPtr getSelectedPath(IntPtr thisPtr)
         {
         	if (_getSelectedPathFunc == null)
         	{
         		_getSelectedPathFunc =
         			(_getSelectedPath)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFileTreeCtrl_getSelectedPath"), typeof(_getSelectedPath));
         	}
         
         	return  _getSelectedPathFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setSelectedPath(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string path);
         private static _setSelectedPath _setSelectedPathFunc;
         internal static bool setSelectedPath(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string path)
         {
         	if (_setSelectedPathFunc == null)
         	{
         		_setSelectedPathFunc =
         			(_setSelectedPath)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFileTreeCtrl_setSelectedPath"), typeof(_setSelectedPath));
         	}
         
         	return  _setSelectedPathFunc(thisPtr, path);
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
         				"fnGuiFileTreeCtrl_reload"), typeof(_reload));
         	}
         
         	 _reloadFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiFileTreeCtrl_create();
         private static _GuiFileTreeCtrl_create _GuiFileTreeCtrl_createFunc;
         internal static IntPtr GuiFileTreeCtrl_create()
         {
         	if (_GuiFileTreeCtrl_createFunc == null)
         	{
         		_GuiFileTreeCtrl_createFunc =
         			(_GuiFileTreeCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiFileTreeCtrl_create"), typeof(_GuiFileTreeCtrl_create));
         	}
         
         	return  _GuiFileTreeCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual string getSelectedPath()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getSelectedPath(ObjectPtr));
         }
      
         public virtual bool setSelectedPath(string path)
         {
            return InternalUnsafeMethods.setSelectedPath(ObjectPtr, path);
         }
      
         public virtual void reload()
         {
            InternalUnsafeMethods.reload(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public string RootPath
         {
         	get { return getFieldValue("RootPath"); }
         	set { setFieldValue("RootPath", value); }
         }
      
         public string FileFilter
         {
         	get { return getFieldValue("FileFilter"); }
         	set { setFieldValue("FileFilter", value); }
         }
      
      
      #endregion

	}
}