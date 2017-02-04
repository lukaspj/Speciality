using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class FileStreamObject : StreamObject
	{
		public FileStreamObject(bool pRegister = false)
			: base(pRegister)
		{
		}

		public FileStreamObject(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public FileStreamObject(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public FileStreamObject(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public FileStreamObject(SimObject pObj) : base(pObj)
		{
		}

		public FileStreamObject(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.FileStreamObject_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _open(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename, [MarshalAs(UnmanagedType.LPWStr)]string openMode);
         private static _open _openFunc;
         internal static bool open(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename, [MarshalAs(UnmanagedType.LPWStr)]string openMode)
         {
         	if (_openFunc == null)
         	{
         		_openFunc =
         			(_open)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnFileStreamObject_open"), typeof(_open));
         	}
         
         	return  _openFunc(thisPtr, filename, openMode);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _close(IntPtr thisPtr);
         private static _close _closeFunc;
         internal static void close(IntPtr thisPtr)
         {
         	if (_closeFunc == null)
         	{
         		_closeFunc =
         			(_close)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnFileStreamObject_close"), typeof(_close));
         	}
         
         	 _closeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FileStreamObject_create();
         private static _FileStreamObject_create _FileStreamObject_createFunc;
         internal static IntPtr FileStreamObject_create()
         {
         	if (_FileStreamObject_createFunc == null)
         	{
         		_FileStreamObject_createFunc =
         			(_FileStreamObject_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_FileStreamObject_create"), typeof(_FileStreamObject_create));
         	}
         
         	return  _FileStreamObject_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool open(string filename, string openMode)
         {
            return InternalUnsafeMethods.open(ObjectPtr, filename, openMode);
         }
      
         public virtual void close()
         {
            InternalUnsafeMethods.close(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}