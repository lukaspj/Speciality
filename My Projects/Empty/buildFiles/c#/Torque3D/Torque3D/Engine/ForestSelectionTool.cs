using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ForestSelectionTool : ForestTool
	{
		public ForestSelectionTool(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ForestSelectionTool(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ForestSelectionTool(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ForestSelectionTool(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ForestSelectionTool(SimObject pObj) : base(pObj)
		{
		}

		public ForestSelectionTool(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ForestSelectionTool_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSelectionCount(IntPtr thisPtr);
         private static _getSelectionCount _getSelectionCountFunc;
         internal static int getSelectionCount(IntPtr thisPtr)
         {
         	if (_getSelectionCountFunc == null)
         	{
         		_getSelectionCountFunc =
         			(_getSelectionCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnForestSelectionTool_getSelectionCount"), typeof(_getSelectionCount));
         	}
         
         	return  _getSelectionCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deleteSelection(IntPtr thisPtr);
         private static _deleteSelection _deleteSelectionFunc;
         internal static void deleteSelection(IntPtr thisPtr)
         {
         	if (_deleteSelectionFunc == null)
         	{
         		_deleteSelectionFunc =
         			(_deleteSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnForestSelectionTool_deleteSelection"), typeof(_deleteSelection));
         	}
         
         	 _deleteSelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearSelection(IntPtr thisPtr);
         private static _clearSelection _clearSelectionFunc;
         internal static void clearSelection(IntPtr thisPtr)
         {
         	if (_clearSelectionFunc == null)
         	{
         		_clearSelectionFunc =
         			(_clearSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnForestSelectionTool_clearSelection"), typeof(_clearSelection));
         	}
         
         	 _clearSelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _cutSelection(IntPtr thisPtr);
         private static _cutSelection _cutSelectionFunc;
         internal static void cutSelection(IntPtr thisPtr)
         {
         	if (_cutSelectionFunc == null)
         	{
         		_cutSelectionFunc =
         			(_cutSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnForestSelectionTool_cutSelection"), typeof(_cutSelection));
         	}
         
         	 _cutSelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _copySelection(IntPtr thisPtr);
         private static _copySelection _copySelectionFunc;
         internal static void copySelection(IntPtr thisPtr)
         {
         	if (_copySelectionFunc == null)
         	{
         		_copySelectionFunc =
         			(_copySelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnForestSelectionTool_copySelection"), typeof(_copySelection));
         	}
         
         	 _copySelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _pasteSelection(IntPtr thisPtr);
         private static _pasteSelection _pasteSelectionFunc;
         internal static void pasteSelection(IntPtr thisPtr)
         {
         	if (_pasteSelectionFunc == null)
         	{
         		_pasteSelectionFunc =
         			(_pasteSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnForestSelectionTool_pasteSelection"), typeof(_pasteSelection));
         	}
         
         	 _pasteSelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ForestSelectionTool_create();
         private static _ForestSelectionTool_create _ForestSelectionTool_createFunc;
         internal static IntPtr ForestSelectionTool_create()
         {
         	if (_ForestSelectionTool_createFunc == null)
         	{
         		_ForestSelectionTool_createFunc =
         			(_ForestSelectionTool_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ForestSelectionTool_create"), typeof(_ForestSelectionTool_create));
         	}
         
         	return  _ForestSelectionTool_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int getSelectionCount()
         {
            return InternalUnsafeMethods.getSelectionCount(ObjectPtr);
         }
      
         public virtual void deleteSelection()
         {
            InternalUnsafeMethods.deleteSelection(ObjectPtr);
         }
      
         public virtual void clearSelection()
         {
            InternalUnsafeMethods.clearSelection(ObjectPtr);
         }
      
         public virtual void cutSelection()
         {
            InternalUnsafeMethods.cutSelection(ObjectPtr);
         }
      
         public virtual void copySelection()
         {
            InternalUnsafeMethods.copySelection(ObjectPtr);
         }
      
         public virtual void pasteSelection()
         {
            InternalUnsafeMethods.pasteSelection(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}