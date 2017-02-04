using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class StreamObject : SimObject
	{
		public StreamObject(bool pRegister = false)
			: base(pRegister)
		{
		}

		public StreamObject(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public StreamObject(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public StreamObject(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public StreamObject(SimObject pObj) : base(pObj)
		{
		}

		public StreamObject(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.StreamObject_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getStatus(IntPtr thisPtr);
         private static _getStatus _getStatusFunc;
         internal static IntPtr getStatus(IntPtr thisPtr)
         {
         	if (_getStatusFunc == null)
         	{
         		_getStatusFunc =
         			(_getStatus)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnStreamObject_getStatus"), typeof(_getStatus));
         	}
         
         	return  _getStatusFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isEOS(IntPtr thisPtr);
         private static _isEOS _isEOSFunc;
         internal static bool isEOS(IntPtr thisPtr)
         {
         	if (_isEOSFunc == null)
         	{
         		_isEOSFunc =
         			(_isEOS)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnStreamObject_isEOS"), typeof(_isEOS));
         	}
         
         	return  _isEOSFunc(thisPtr);
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
         				"fnStreamObject_isEOF"), typeof(_isEOF));
         	}
         
         	return  _isEOFFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getPosition(IntPtr thisPtr);
         private static _getPosition _getPositionFunc;
         internal static int getPosition(IntPtr thisPtr)
         {
         	if (_getPositionFunc == null)
         	{
         		_getPositionFunc =
         			(_getPosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnStreamObject_getPosition"), typeof(_getPosition));
         	}
         
         	return  _getPositionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setPosition(IntPtr thisPtr, int newPosition);
         private static _setPosition _setPositionFunc;
         internal static bool setPosition(IntPtr thisPtr, int newPosition)
         {
         	if (_setPositionFunc == null)
         	{
         		_setPositionFunc =
         			(_setPosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnStreamObject_setPosition"), typeof(_setPosition));
         	}
         
         	return  _setPositionFunc(thisPtr, newPosition);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getStreamSize(IntPtr thisPtr);
         private static _getStreamSize _getStreamSizeFunc;
         internal static int getStreamSize(IntPtr thisPtr)
         {
         	if (_getStreamSizeFunc == null)
         	{
         		_getStreamSizeFunc =
         			(_getStreamSize)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnStreamObject_getStreamSize"), typeof(_getStreamSize));
         	}
         
         	return  _getStreamSizeFunc(thisPtr);
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
         				"fnStreamObject_readLine"), typeof(_readLine));
         	}
         
         	return  _readLineFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _writeLine(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string line);
         private static _writeLine _writeLineFunc;
         internal static void writeLine(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string line)
         {
         	if (_writeLineFunc == null)
         	{
         		_writeLineFunc =
         			(_writeLine)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnStreamObject_writeLine"), typeof(_writeLine));
         	}
         
         	 _writeLineFunc(thisPtr, line);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _readSTString(IntPtr thisPtr, bool caseSensitive);
         private static _readSTString _readSTStringFunc;
         internal static IntPtr readSTString(IntPtr thisPtr, bool caseSensitive)
         {
         	if (_readSTStringFunc == null)
         	{
         		_readSTStringFunc =
         			(_readSTString)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnStreamObject_readSTString"), typeof(_readSTString));
         	}
         
         	return  _readSTStringFunc(thisPtr, caseSensitive);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _readString(IntPtr thisPtr);
         private static _readString _readStringFunc;
         internal static IntPtr readString(IntPtr thisPtr)
         {
         	if (_readStringFunc == null)
         	{
         		_readStringFunc =
         			(_readString)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnStreamObject_readString"), typeof(_readString));
         	}
         
         	return  _readStringFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _readLongString(IntPtr thisPtr, int maxLength);
         private static _readLongString _readLongStringFunc;
         internal static IntPtr readLongString(IntPtr thisPtr, int maxLength)
         {
         	if (_readLongStringFunc == null)
         	{
         		_readLongStringFunc =
         			(_readLongString)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnStreamObject_readLongString"), typeof(_readLongString));
         	}
         
         	return  _readLongStringFunc(thisPtr, maxLength);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _writeLongString(IntPtr thisPtr, int maxLength, [MarshalAs(UnmanagedType.LPWStr)]string _string);
         private static _writeLongString _writeLongStringFunc;
         internal static void writeLongString(IntPtr thisPtr, int maxLength, [MarshalAs(UnmanagedType.LPWStr)]string _string)
         {
         	if (_writeLongStringFunc == null)
         	{
         		_writeLongStringFunc =
         			(_writeLongString)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnStreamObject_writeLongString"), typeof(_writeLongString));
         	}
         
         	 _writeLongStringFunc(thisPtr, maxLength, _string);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _writeString(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string _string, int maxLength);
         private static _writeString _writeStringFunc;
         internal static void writeString(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string _string, int maxLength)
         {
         	if (_writeStringFunc == null)
         	{
         		_writeStringFunc =
         			(_writeString)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnStreamObject_writeString"), typeof(_writeString));
         	}
         
         	 _writeStringFunc(thisPtr, _string, maxLength);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _copyFrom(IntPtr thisPtr, IntPtr other);
         private static _copyFrom _copyFromFunc;
         internal static bool copyFrom(IntPtr thisPtr, IntPtr other)
         {
         	if (_copyFromFunc == null)
         	{
         		_copyFromFunc =
         			(_copyFrom)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnStreamObject_copyFrom"), typeof(_copyFrom));
         	}
         
         	return  _copyFromFunc(thisPtr, other);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _StreamObject_create();
         private static _StreamObject_create _StreamObject_createFunc;
         internal static IntPtr StreamObject_create()
         {
         	if (_StreamObject_createFunc == null)
         	{
         		_StreamObject_createFunc =
         			(_StreamObject_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_StreamObject_create"), typeof(_StreamObject_create));
         	}
         
         	return  _StreamObject_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual string getStatus()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getStatus(ObjectPtr));
         }
      
         public virtual bool isEOS()
         {
            return InternalUnsafeMethods.isEOS(ObjectPtr);
         }
      
         public virtual bool isEOF()
         {
            return InternalUnsafeMethods.isEOF(ObjectPtr);
         }
      
         public virtual int getPosition()
         {
            return InternalUnsafeMethods.getPosition(ObjectPtr);
         }
      
         public virtual bool setPosition(int newPosition)
         {
            return InternalUnsafeMethods.setPosition(ObjectPtr, newPosition);
         }
      
         public virtual int getStreamSize()
         {
            return InternalUnsafeMethods.getStreamSize(ObjectPtr);
         }
      
         public virtual string readLine()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.readLine(ObjectPtr));
         }
      
         public virtual void writeLine(string line)
         {
            InternalUnsafeMethods.writeLine(ObjectPtr, line);
         }
      
         public virtual string readSTString(bool caseSensitive = false)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.readSTString(ObjectPtr, caseSensitive));
         }
      
         public virtual string readString()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.readString(ObjectPtr));
         }
      
         public virtual string readLongString(int maxLength)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.readLongString(ObjectPtr, maxLength));
         }
      
         public virtual void writeLongString(int maxLength, string _string)
         {
            InternalUnsafeMethods.writeLongString(ObjectPtr, maxLength, _string);
         }
      
         public virtual void writeString(string _string, int maxLength = 256)
         {
            InternalUnsafeMethods.writeString(ObjectPtr, _string, maxLength);
         }
      
         public virtual bool copyFrom(SimObject other)
         {
            return InternalUnsafeMethods.copyFrom(ObjectPtr, other.ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}