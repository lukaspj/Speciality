using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class EditManager : GuiControl
	{
		public EditManager(bool pRegister = false)
			: base(pRegister)
		{
		}

		public EditManager(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public EditManager(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public EditManager(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public EditManager(SimObject pObj) : base(pObj)
		{
		}

		public EditManager(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.EditManager_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setBookmark(IntPtr thisPtr, int val);
         private static _setBookmark _setBookmarkFunc;
         internal static void setBookmark(IntPtr thisPtr, int val)
         {
         	if (_setBookmarkFunc == null)
         	{
         		_setBookmarkFunc =
         			(_setBookmark)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEditManager_setBookmark"), typeof(_setBookmark));
         	}
         
         	 _setBookmarkFunc(thisPtr, val);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _gotoBookmark(IntPtr thisPtr, int val);
         private static _gotoBookmark _gotoBookmarkFunc;
         internal static void gotoBookmark(IntPtr thisPtr, int val)
         {
         	if (_gotoBookmarkFunc == null)
         	{
         		_gotoBookmarkFunc =
         			(_gotoBookmark)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEditManager_gotoBookmark"), typeof(_gotoBookmark));
         	}
         
         	 _gotoBookmarkFunc(thisPtr, val);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _editorEnabled(IntPtr thisPtr);
         private static _editorEnabled _editorEnabledFunc;
         internal static void editorEnabled(IntPtr thisPtr)
         {
         	if (_editorEnabledFunc == null)
         	{
         		_editorEnabledFunc =
         			(_editorEnabled)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEditManager_editorEnabled"), typeof(_editorEnabled));
         	}
         
         	 _editorEnabledFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _editorDisabled(IntPtr thisPtr);
         private static _editorDisabled _editorDisabledFunc;
         internal static void editorDisabled(IntPtr thisPtr)
         {
         	if (_editorDisabledFunc == null)
         	{
         		_editorDisabledFunc =
         			(_editorDisabled)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEditManager_editorDisabled"), typeof(_editorDisabled));
         	}
         
         	 _editorDisabledFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isEditorEnabled(IntPtr thisPtr);
         private static _isEditorEnabled _isEditorEnabledFunc;
         internal static bool isEditorEnabled(IntPtr thisPtr)
         {
         	if (_isEditorEnabledFunc == null)
         	{
         		_isEditorEnabledFunc =
         			(_isEditorEnabled)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEditManager_isEditorEnabled"), typeof(_isEditorEnabled));
         	}
         
         	return  _isEditorEnabledFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _EditManager_create();
         private static _EditManager_create _EditManager_createFunc;
         internal static IntPtr EditManager_create()
         {
         	if (_EditManager_createFunc == null)
         	{
         		_EditManager_createFunc =
         			(_EditManager_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_EditManager_create"), typeof(_EditManager_create));
         	}
         
         	return  _EditManager_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setBookmark(int val)
         {
            InternalUnsafeMethods.setBookmark(ObjectPtr, val);
         }
      
         public virtual void gotoBookmark(int val)
         {
            InternalUnsafeMethods.gotoBookmark(ObjectPtr, val);
         }
      
         public virtual void editorEnabled()
         {
            InternalUnsafeMethods.editorEnabled(ObjectPtr);
         }
      
         public virtual void editorDisabled()
         {
            InternalUnsafeMethods.editorDisabled(ObjectPtr);
         }
      
         public virtual bool isEditorEnabled()
         {
            return InternalUnsafeMethods.isEditorEnabled(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}