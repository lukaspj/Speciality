using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class MenuBar : SimSet
	{
		public MenuBar(bool pRegister = false)
			: base(pRegister)
		{
		}

		public MenuBar(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public MenuBar(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public MenuBar(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public MenuBar(SimObject pObj) : base(pObj)
		{
		}

		public MenuBar(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.MenuBar_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _attachToCanvas(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string canvas, int pos);
         private static _attachToCanvas _attachToCanvasFunc;
         internal static void attachToCanvas(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string canvas, int pos)
         {
         	if (_attachToCanvasFunc == null)
         	{
         		_attachToCanvasFunc =
         			(_attachToCanvas)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMenuBar_attachToCanvas"), typeof(_attachToCanvas));
         	}
         
         	 _attachToCanvasFunc(thisPtr, canvas, pos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeFromCanvas(IntPtr thisPtr);
         private static _removeFromCanvas _removeFromCanvasFunc;
         internal static void removeFromCanvas(IntPtr thisPtr)
         {
         	if (_removeFromCanvasFunc == null)
         	{
         		_removeFromCanvasFunc =
         			(_removeFromCanvas)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMenuBar_removeFromCanvas"), typeof(_removeFromCanvas));
         	}
         
         	 _removeFromCanvasFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _insert(IntPtr thisPtr, IntPtr pObject, int pos);
         private static _insert _insertFunc;
         internal static void insert(IntPtr thisPtr, IntPtr pObject, int pos)
         {
         	if (_insertFunc == null)
         	{
         		_insertFunc =
         			(_insert)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMenuBar_insert"), typeof(_insert));
         	}
         
         	 _insertFunc(thisPtr, pObject, pos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MenuBar_create();
         private static _MenuBar_create _MenuBar_createFunc;
         internal static IntPtr MenuBar_create()
         {
         	if (_MenuBar_createFunc == null)
         	{
         		_MenuBar_createFunc =
         			(_MenuBar_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_MenuBar_create"), typeof(_MenuBar_create));
         	}
         
         	return  _MenuBar_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void attachToCanvas(string canvas, int pos)
         {
            InternalUnsafeMethods.attachToCanvas(ObjectPtr, canvas, pos);
         }
      
         public virtual void removeFromCanvas()
         {
            InternalUnsafeMethods.removeFromCanvas(ObjectPtr);
         }
      
         public virtual void insert(SimObject pObject, int pos)
         {
            InternalUnsafeMethods.insert(ObjectPtr, pObject.ObjectPtr, pos);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}