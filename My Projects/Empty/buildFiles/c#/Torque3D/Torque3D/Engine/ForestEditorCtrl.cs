using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ForestEditorCtrl : EditTSCtrl
	{
		public ForestEditorCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ForestEditorCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ForestEditorCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ForestEditorCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ForestEditorCtrl(SimObject pObj) : base(pObj)
		{
		}

		public ForestEditorCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ForestEditorCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _updateActiveForest(IntPtr thisPtr);
         private static _updateActiveForest _updateActiveForestFunc;
         internal static void updateActiveForest(IntPtr thisPtr)
         {
         	if (_updateActiveForestFunc == null)
         	{
         		_updateActiveForestFunc =
         			(_updateActiveForest)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnForestEditorCtrl_updateActiveForest"), typeof(_updateActiveForest));
         	}
         
         	 _updateActiveForestFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setActiveTool(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string toolName);
         private static _setActiveTool _setActiveToolFunc;
         internal static void setActiveTool(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string toolName)
         {
         	if (_setActiveToolFunc == null)
         	{
         		_setActiveToolFunc =
         			(_setActiveTool)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnForestEditorCtrl_setActiveTool"), typeof(_setActiveTool));
         	}
         
         	 _setActiveToolFunc(thisPtr, toolName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getActiveTool(IntPtr thisPtr);
         private static _getActiveTool _getActiveToolFunc;
         internal static int getActiveTool(IntPtr thisPtr)
         {
         	if (_getActiveToolFunc == null)
         	{
         		_getActiveToolFunc =
         			(_getActiveTool)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnForestEditorCtrl_getActiveTool"), typeof(_getActiveTool));
         	}
         
         	return  _getActiveToolFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deleteMeshSafe(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string obj);
         private static _deleteMeshSafe _deleteMeshSafeFunc;
         internal static void deleteMeshSafe(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string obj)
         {
         	if (_deleteMeshSafeFunc == null)
         	{
         		_deleteMeshSafeFunc =
         			(_deleteMeshSafe)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnForestEditorCtrl_deleteMeshSafe"), typeof(_deleteMeshSafe));
         	}
         
         	 _deleteMeshSafeFunc(thisPtr, obj);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isDirty(IntPtr thisPtr);
         private static _isDirty _isDirtyFunc;
         internal static bool isDirty(IntPtr thisPtr)
         {
         	if (_isDirtyFunc == null)
         	{
         		_isDirtyFunc =
         			(_isDirty)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnForestEditorCtrl_isDirty"), typeof(_isDirty));
         	}
         
         	return  _isDirtyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setActiveForest(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string obj);
         private static _setActiveForest _setActiveForestFunc;
         internal static void setActiveForest(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string obj)
         {
         	if (_setActiveForestFunc == null)
         	{
         		_setActiveForestFunc =
         			(_setActiveForest)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnForestEditorCtrl_setActiveForest"), typeof(_setActiveForest));
         	}
         
         	 _setActiveForestFunc(thisPtr, obj);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ForestEditorCtrl_create();
         private static _ForestEditorCtrl_create _ForestEditorCtrl_createFunc;
         internal static IntPtr ForestEditorCtrl_create()
         {
         	if (_ForestEditorCtrl_createFunc == null)
         	{
         		_ForestEditorCtrl_createFunc =
         			(_ForestEditorCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ForestEditorCtrl_create"), typeof(_ForestEditorCtrl_create));
         	}
         
         	return  _ForestEditorCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void updateActiveForest()
         {
            InternalUnsafeMethods.updateActiveForest(ObjectPtr);
         }
      
         public virtual void setActiveTool(string toolName)
         {
            InternalUnsafeMethods.setActiveTool(ObjectPtr, toolName);
         }
      
         public virtual int getActiveTool()
         {
            return InternalUnsafeMethods.getActiveTool(ObjectPtr);
         }
      
         public virtual void deleteMeshSafe(string obj)
         {
            InternalUnsafeMethods.deleteMeshSafe(ObjectPtr, obj);
         }
      
         public virtual bool isDirty()
         {
            return InternalUnsafeMethods.isDirty(ObjectPtr);
         }
      
         public virtual void setActiveForest(string obj)
         {
            InternalUnsafeMethods.setActiveForest(ObjectPtr, obj);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}