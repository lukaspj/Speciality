using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class FileObject : SimObject
	{
		public FileObject(bool pRegister = false)
			: base(pRegister)
		{
		}

		public FileObject(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public FileObject(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public FileObject(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public FileObject(SimObject pObj) : base(pObj)
		{
		}

		public FileObject(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.FileObject_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _openForRead(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _openForRead _openForReadFunc;
         internal static bool openForRead(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_openForReadFunc == null)
         	{
         		_openForReadFunc =
         			(_openForRead)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnFileObject_openForRead"), typeof(_openForRead));
         	}
         
         	return  _openForReadFunc(thisPtr, filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _openForWrite(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _openForWrite _openForWriteFunc;
         internal static bool openForWrite(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_openForWriteFunc == null)
         	{
         		_openForWriteFunc =
         			(_openForWrite)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnFileObject_openForWrite"), typeof(_openForWrite));
         	}
         
         	return  _openForWriteFunc(thisPtr, filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _openForAppend(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _openForAppend _openForAppendFunc;
         internal static bool openForAppend(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_openForAppendFunc == null)
         	{
         		_openForAppendFunc =
         			(_openForAppend)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnFileObject_openForAppend"), typeof(_openForAppend));
         	}
         
         	return  _openForAppendFunc(thisPtr, filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isEOF(IntPtr thisPtr);
         private static _isEOF _isEOFFunc;
         internal static bool isEOF(IntPtr thisPtr)
         {
         	if (_isEOFFunc == null)
         	{
         		_isEOFFunc =
         			(_isEOF)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnFileObject_isEOF"), typeof(_isEOF));
         	}
         
         	return  _isEOFFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _readLine(IntPtr thisPtr);
         private static _readLine _readLineFunc;
         internal static IntPtr readLine(IntPtr thisPtr)
         {
         	if (_readLineFunc == null)
         	{
         		_readLineFunc =
         			(_readLine)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnFileObject_readLine"), typeof(_readLine));
         	}
         
         	return  _readLineFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _peekLine(IntPtr thisPtr);
         private static _peekLine _peekLineFunc;
         internal static IntPtr peekLine(IntPtr thisPtr)
         {
         	if (_peekLineFunc == null)
         	{
         		_peekLineFunc =
         			(_peekLine)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnFileObject_peekLine"), typeof(_peekLine));
         	}
         
         	return  _peekLineFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _writeLine(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string text);
         private static _writeLine _writeLineFunc;
         internal static void writeLine(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string text)
         {
         	if (_writeLineFunc == null)
         	{
         		_writeLineFunc =
         			(_writeLine)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnFileObject_writeLine"), typeof(_writeLine));
         	}
         
         	 _writeLineFunc(thisPtr, text);
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
         				"fnFileObject_close"), typeof(_close));
         	}
         
         	 _closeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _writeObject(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string simName, [MarshalAs(UnmanagedType.LPWStr)]string objName);
         private static _writeObject _writeObjectFunc;
         internal static void writeObject(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string simName, [MarshalAs(UnmanagedType.LPWStr)]string objName)
         {
         	if (_writeObjectFunc == null)
         	{
         		_writeObjectFunc =
         			(_writeObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnFileObject_writeObject"), typeof(_writeObject));
         	}
         
         	 _writeObjectFunc(thisPtr, simName, objName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FileObject_create();
         private static _FileObject_create _FileObject_createFunc;
         internal static IntPtr FileObject_create()
         {
         	if (_FileObject_createFunc == null)
         	{
         		_FileObject_createFunc =
         			(_FileObject_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_FileObject_create"), typeof(_FileObject_create));
         	}
         
         	return  _FileObject_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool openForRead(string filename)
         {
            return InternalUnsafeMethods.openForRead(ObjectPtr, filename);
         }
      
         public virtual bool openForWrite(string filename)
         {
            return InternalUnsafeMethods.openForWrite(ObjectPtr, filename);
         }
      
         public virtual bool openForAppend(string filename)
         {
            return InternalUnsafeMethods.openForAppend(ObjectPtr, filename);
         }
      
         public virtual bool isEOF()
         {
            return InternalUnsafeMethods.isEOF(ObjectPtr);
         }
      
         public virtual string readLine()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.readLine(ObjectPtr));
         }
      
         public virtual string peekLine()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.peekLine(ObjectPtr));
         }
      
         public virtual void writeLine(string text)
         {
            InternalUnsafeMethods.writeLine(ObjectPtr, text);
         }
      
         public virtual void close()
         {
            InternalUnsafeMethods.close(ObjectPtr);
         }
      
         public virtual void writeObject(string simName, string objName = "")
         {
            InternalUnsafeMethods.writeObject(ObjectPtr, simName, objName);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}