using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiConvexEditorCtrl : EditTSCtrl
	{
		public GuiConvexEditorCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiConvexEditorCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiConvexEditorCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiConvexEditorCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiConvexEditorCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiConvexEditorCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiConvexEditorCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _hollowSelection(IntPtr thisPtr);
         private static _hollowSelection _hollowSelectionFunc;
         internal static void hollowSelection(IntPtr thisPtr)
         {
         	if (_hollowSelectionFunc == null)
         	{
         		_hollowSelectionFunc =
         			(_hollowSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiConvexEditorCtrl_hollowSelection"), typeof(_hollowSelection));
         	}
         
         	 _hollowSelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _recenterSelection(IntPtr thisPtr);
         private static _recenterSelection _recenterSelectionFunc;
         internal static void recenterSelection(IntPtr thisPtr)
         {
         	if (_recenterSelectionFunc == null)
         	{
         		_recenterSelectionFunc =
         			(_recenterSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiConvexEditorCtrl_recenterSelection"), typeof(_recenterSelection));
         	}
         
         	 _recenterSelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _hasSelection(IntPtr thisPtr);
         private static _hasSelection _hasSelectionFunc;
         internal static int hasSelection(IntPtr thisPtr)
         {
         	if (_hasSelectionFunc == null)
         	{
         		_hasSelectionFunc =
         			(_hasSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiConvexEditorCtrl_hasSelection"), typeof(_hasSelection));
         	}
         
         	return  _hasSelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _handleDelete(IntPtr thisPtr);
         private static _handleDelete _handleDeleteFunc;
         internal static void handleDelete(IntPtr thisPtr)
         {
         	if (_handleDeleteFunc == null)
         	{
         		_handleDeleteFunc =
         			(_handleDelete)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiConvexEditorCtrl_handleDelete"), typeof(_handleDelete));
         	}
         
         	 _handleDeleteFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _handleDeselect(IntPtr thisPtr);
         private static _handleDeselect _handleDeselectFunc;
         internal static void handleDeselect(IntPtr thisPtr)
         {
         	if (_handleDeselectFunc == null)
         	{
         		_handleDeselectFunc =
         			(_handleDeselect)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiConvexEditorCtrl_handleDeselect"), typeof(_handleDeselect));
         	}
         
         	 _handleDeselectFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dropSelectionAtScreenCenter(IntPtr thisPtr);
         private static _dropSelectionAtScreenCenter _dropSelectionAtScreenCenterFunc;
         internal static void dropSelectionAtScreenCenter(IntPtr thisPtr)
         {
         	if (_dropSelectionAtScreenCenterFunc == null)
         	{
         		_dropSelectionAtScreenCenterFunc =
         			(_dropSelectionAtScreenCenter)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiConvexEditorCtrl_dropSelectionAtScreenCenter"), typeof(_dropSelectionAtScreenCenter));
         	}
         
         	 _dropSelectionAtScreenCenterFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _selectConvex(IntPtr thisPtr, IntPtr convex);
         private static _selectConvex _selectConvexFunc;
         internal static void selectConvex(IntPtr thisPtr, IntPtr convex)
         {
         	if (_selectConvexFunc == null)
         	{
         		_selectConvexFunc =
         			(_selectConvex)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiConvexEditorCtrl_selectConvex"), typeof(_selectConvex));
         	}
         
         	 _selectConvexFunc(thisPtr, convex);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _splitSelectedFace(IntPtr thisPtr);
         private static _splitSelectedFace _splitSelectedFaceFunc;
         internal static void splitSelectedFace(IntPtr thisPtr)
         {
         	if (_splitSelectedFaceFunc == null)
         	{
         		_splitSelectedFaceFunc =
         			(_splitSelectedFace)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiConvexEditorCtrl_splitSelectedFace"), typeof(_splitSelectedFace));
         	}
         
         	 _splitSelectedFaceFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiConvexEditorCtrl_create();
         private static _GuiConvexEditorCtrl_create _GuiConvexEditorCtrl_createFunc;
         internal static IntPtr GuiConvexEditorCtrl_create()
         {
         	if (_GuiConvexEditorCtrl_createFunc == null)
         	{
         		_GuiConvexEditorCtrl_createFunc =
         			(_GuiConvexEditorCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiConvexEditorCtrl_create"), typeof(_GuiConvexEditorCtrl_create));
         	}
         
         	return  _GuiConvexEditorCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void hollowSelection()
         {
            InternalUnsafeMethods.hollowSelection(ObjectPtr);
         }
      
         public virtual void recenterSelection()
         {
            InternalUnsafeMethods.recenterSelection(ObjectPtr);
         }
      
         public virtual int hasSelection()
         {
            return InternalUnsafeMethods.hasSelection(ObjectPtr);
         }
      
         public virtual void handleDelete()
         {
            InternalUnsafeMethods.handleDelete(ObjectPtr);
         }
      
         public virtual void handleDeselect()
         {
            InternalUnsafeMethods.handleDeselect(ObjectPtr);
         }
      
         public virtual void dropSelectionAtScreenCenter()
         {
            InternalUnsafeMethods.dropSelectionAtScreenCenter(ObjectPtr);
         }
      
         public virtual void selectConvex(ConvexShape convex)
         {
            InternalUnsafeMethods.selectConvex(ObjectPtr, convex.ObjectPtr);
         }
      
         public virtual void splitSelectedFace()
         {
            InternalUnsafeMethods.splitSelectedFace(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool IsDirty
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsDirty")); }
         	set { setFieldValue("IsDirty", value ? "1" : "0"); }
         }
      
         public string MaterialName
         {
         	get { return getFieldValue("MaterialName"); }
         	set { setFieldValue("MaterialName", value); }
         }
      
      
      #endregion

	}
}