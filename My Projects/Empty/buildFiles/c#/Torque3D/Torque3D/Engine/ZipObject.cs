using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ZipObject : SimObject
	{
		public ZipObject(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ZipObject(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ZipObject(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ZipObject(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ZipObject(SimObject pObj) : base(pObj)
		{
		}

		public ZipObject(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ZipObject_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _openArchive(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename, [MarshalAs(UnmanagedType.LPWStr)]string accessMode);
         private static _openArchive _openArchiveFunc;
         internal static bool openArchive(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename, [MarshalAs(UnmanagedType.LPWStr)]string accessMode)
         {
         	if (_openArchiveFunc == null)
         	{
         		_openArchiveFunc =
         			(_openArchive)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnZipObject_openArchive"), typeof(_openArchive));
         	}
         
         	return  _openArchiveFunc(thisPtr, filename, accessMode);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _closeArchive(IntPtr thisPtr);
         private static _closeArchive _closeArchiveFunc;
         internal static void closeArchive(IntPtr thisPtr)
         {
         	if (_closeArchiveFunc == null)
         	{
         		_closeArchiveFunc =
         			(_closeArchive)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnZipObject_closeArchive"), typeof(_closeArchive));
         	}
         
         	 _closeArchiveFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _openFileForRead(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _openFileForRead _openFileForReadFunc;
         internal static IntPtr openFileForRead(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_openFileForReadFunc == null)
         	{
         		_openFileForReadFunc =
         			(_openFileForRead)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnZipObject_openFileForRead"), typeof(_openFileForRead));
         	}
         
         	return  _openFileForReadFunc(thisPtr, filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _openFileForWrite(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _openFileForWrite _openFileForWriteFunc;
         internal static IntPtr openFileForWrite(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_openFileForWriteFunc == null)
         	{
         		_openFileForWriteFunc =
         			(_openFileForWrite)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnZipObject_openFileForWrite"), typeof(_openFileForWrite));
         	}
         
         	return  _openFileForWriteFunc(thisPtr, filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _closeFile(IntPtr thisPtr, IntPtr stream);
         private static _closeFile _closeFileFunc;
         internal static void closeFile(IntPtr thisPtr, IntPtr stream)
         {
         	if (_closeFileFunc == null)
         	{
         		_closeFileFunc =
         			(_closeFile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnZipObject_closeFile"), typeof(_closeFile));
         	}
         
         	 _closeFileFunc(thisPtr, stream);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _addFile(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename, [MarshalAs(UnmanagedType.LPWStr)]string pathInZip, bool replace);
         private static _addFile _addFileFunc;
         internal static bool addFile(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename, [MarshalAs(UnmanagedType.LPWStr)]string pathInZip, bool replace)
         {
         	if (_addFileFunc == null)
         	{
         		_addFileFunc =
         			(_addFile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnZipObject_addFile"), typeof(_addFile));
         	}
         
         	return  _addFileFunc(thisPtr, filename, pathInZip, replace);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _extractFile(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pathInZip, [MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _extractFile _extractFileFunc;
         internal static bool extractFile(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pathInZip, [MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_extractFileFunc == null)
         	{
         		_extractFileFunc =
         			(_extractFile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnZipObject_extractFile"), typeof(_extractFile));
         	}
         
         	return  _extractFileFunc(thisPtr, pathInZip, filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _deleteFile(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pathInZip);
         private static _deleteFile _deleteFileFunc;
         internal static bool deleteFile(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pathInZip)
         {
         	if (_deleteFileFunc == null)
         	{
         		_deleteFileFunc =
         			(_deleteFile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnZipObject_deleteFile"), typeof(_deleteFile));
         	}
         
         	return  _deleteFileFunc(thisPtr, pathInZip);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getFileEntryCount(IntPtr thisPtr);
         private static _getFileEntryCount _getFileEntryCountFunc;
         internal static int getFileEntryCount(IntPtr thisPtr)
         {
         	if (_getFileEntryCountFunc == null)
         	{
         		_getFileEntryCountFunc =
         			(_getFileEntryCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnZipObject_getFileEntryCount"), typeof(_getFileEntryCount));
         	}
         
         	return  _getFileEntryCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getFileEntry(IntPtr thisPtr, int index);
         private static _getFileEntry _getFileEntryFunc;
         internal static IntPtr getFileEntry(IntPtr thisPtr, int index)
         {
         	if (_getFileEntryFunc == null)
         	{
         		_getFileEntryFunc =
         			(_getFileEntry)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnZipObject_getFileEntry"), typeof(_getFileEntry));
         	}
         
         	return  _getFileEntryFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ZipObject_create();
         private static _ZipObject_create _ZipObject_createFunc;
         internal static IntPtr ZipObject_create()
         {
         	if (_ZipObject_createFunc == null)
         	{
         		_ZipObject_createFunc =
         			(_ZipObject_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ZipObject_create"), typeof(_ZipObject_create));
         	}
         
         	return  _ZipObject_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool openArchive(string filename, string accessMode = "read")
         {
            return InternalUnsafeMethods.openArchive(ObjectPtr, filename, accessMode);
         }
      
         public virtual void closeArchive()
         {
            InternalUnsafeMethods.closeArchive(ObjectPtr);
         }
      
         public virtual SimObject openFileForRead(string filename)
         {
            return new SimObject(InternalUnsafeMethods.openFileForRead(ObjectPtr, filename));
         }
      
         public virtual SimObject openFileForWrite(string filename)
         {
            return new SimObject(InternalUnsafeMethods.openFileForWrite(ObjectPtr, filename));
         }
      
         public virtual void closeFile(SimObject stream)
         {
            InternalUnsafeMethods.closeFile(ObjectPtr, stream.ObjectPtr);
         }
      
         public virtual bool addFile(string filename, string pathInZip, bool replace = true)
         {
            return InternalUnsafeMethods.addFile(ObjectPtr, filename, pathInZip, replace);
         }
      
         public virtual bool extractFile(string pathInZip, string filename)
         {
            return InternalUnsafeMethods.extractFile(ObjectPtr, pathInZip, filename);
         }
      
         public virtual bool deleteFile(string pathInZip)
         {
            return InternalUnsafeMethods.deleteFile(ObjectPtr, pathInZip);
         }
      
         public virtual int getFileEntryCount()
         {
            return InternalUnsafeMethods.getFileEntryCount(ObjectPtr);
         }
      
         public virtual string getFileEntry(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getFileEntry(ObjectPtr, index));
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}