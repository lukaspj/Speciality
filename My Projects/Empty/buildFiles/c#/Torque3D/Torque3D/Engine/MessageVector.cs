using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class MessageVector : SimObject
	{
		public MessageVector(bool pRegister = false)
			: base(pRegister)
		{
		}

		public MessageVector(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public MessageVector(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public MessageVector(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public MessageVector(SimObject pObj) : base(pObj)
		{
		}

		public MessageVector(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.MessageVector_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clear(IntPtr thisPtr);
         private static _clear _clearFunc;
         internal static void clear(IntPtr thisPtr)
         {
         	if (_clearFunc == null)
         	{
         		_clearFunc =
         			(_clear)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMessageVector_clear"), typeof(_clear));
         	}
         
         	 _clearFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _pushBackLine(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string msg, int tag);
         private static _pushBackLine _pushBackLineFunc;
         internal static void pushBackLine(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string msg, int tag)
         {
         	if (_pushBackLineFunc == null)
         	{
         		_pushBackLineFunc =
         			(_pushBackLine)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMessageVector_pushBackLine"), typeof(_pushBackLine));
         	}
         
         	 _pushBackLineFunc(thisPtr, msg, tag);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _popBackLine(IntPtr thisPtr);
         private static _popBackLine _popBackLineFunc;
         internal static bool popBackLine(IntPtr thisPtr)
         {
         	if (_popBackLineFunc == null)
         	{
         		_popBackLineFunc =
         			(_popBackLine)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMessageVector_popBackLine"), typeof(_popBackLine));
         	}
         
         	return  _popBackLineFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _pushFrontLine(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string msg, int tag);
         private static _pushFrontLine _pushFrontLineFunc;
         internal static void pushFrontLine(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string msg, int tag)
         {
         	if (_pushFrontLineFunc == null)
         	{
         		_pushFrontLineFunc =
         			(_pushFrontLine)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMessageVector_pushFrontLine"), typeof(_pushFrontLine));
         	}
         
         	 _pushFrontLineFunc(thisPtr, msg, tag);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _popFrontLine(IntPtr thisPtr);
         private static _popFrontLine _popFrontLineFunc;
         internal static bool popFrontLine(IntPtr thisPtr)
         {
         	if (_popFrontLineFunc == null)
         	{
         		_popFrontLineFunc =
         			(_popFrontLine)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMessageVector_popFrontLine"), typeof(_popFrontLine));
         	}
         
         	return  _popFrontLineFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _insertLine(IntPtr thisPtr, int insertPos, [MarshalAs(UnmanagedType.LPWStr)]string msg, int tag);
         private static _insertLine _insertLineFunc;
         internal static bool insertLine(IntPtr thisPtr, int insertPos, [MarshalAs(UnmanagedType.LPWStr)]string msg, int tag)
         {
         	if (_insertLineFunc == null)
         	{
         		_insertLineFunc =
         			(_insertLine)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMessageVector_insertLine"), typeof(_insertLine));
         	}
         
         	return  _insertLineFunc(thisPtr, insertPos, msg, tag);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _deleteLine(IntPtr thisPtr, int deletePos);
         private static _deleteLine _deleteLineFunc;
         internal static bool deleteLine(IntPtr thisPtr, int deletePos)
         {
         	if (_deleteLineFunc == null)
         	{
         		_deleteLineFunc =
         			(_deleteLine)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMessageVector_deleteLine"), typeof(_deleteLine));
         	}
         
         	return  _deleteLineFunc(thisPtr, deletePos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dump(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename, [MarshalAs(UnmanagedType.LPWStr)]string header);
         private static _dump _dumpFunc;
         internal static void dump(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename, [MarshalAs(UnmanagedType.LPWStr)]string header)
         {
         	if (_dumpFunc == null)
         	{
         		_dumpFunc =
         			(_dump)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMessageVector_dump"), typeof(_dump));
         	}
         
         	 _dumpFunc(thisPtr, filename, header);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getNumLines(IntPtr thisPtr);
         private static _getNumLines _getNumLinesFunc;
         internal static int getNumLines(IntPtr thisPtr)
         {
         	if (_getNumLinesFunc == null)
         	{
         		_getNumLinesFunc =
         			(_getNumLines)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMessageVector_getNumLines"), typeof(_getNumLines));
         	}
         
         	return  _getNumLinesFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getLineTextByTag(IntPtr thisPtr, int tag);
         private static _getLineTextByTag _getLineTextByTagFunc;
         internal static IntPtr getLineTextByTag(IntPtr thisPtr, int tag)
         {
         	if (_getLineTextByTagFunc == null)
         	{
         		_getLineTextByTagFunc =
         			(_getLineTextByTag)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMessageVector_getLineTextByTag"), typeof(_getLineTextByTag));
         	}
         
         	return  _getLineTextByTagFunc(thisPtr, tag);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getLineIndexByTag(IntPtr thisPtr, int tag);
         private static _getLineIndexByTag _getLineIndexByTagFunc;
         internal static int getLineIndexByTag(IntPtr thisPtr, int tag)
         {
         	if (_getLineIndexByTagFunc == null)
         	{
         		_getLineIndexByTagFunc =
         			(_getLineIndexByTag)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMessageVector_getLineIndexByTag"), typeof(_getLineIndexByTag));
         	}
         
         	return  _getLineIndexByTagFunc(thisPtr, tag);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getLineText(IntPtr thisPtr, int pos);
         private static _getLineText _getLineTextFunc;
         internal static IntPtr getLineText(IntPtr thisPtr, int pos)
         {
         	if (_getLineTextFunc == null)
         	{
         		_getLineTextFunc =
         			(_getLineText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMessageVector_getLineText"), typeof(_getLineText));
         	}
         
         	return  _getLineTextFunc(thisPtr, pos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getLineTag(IntPtr thisPtr, int pos);
         private static _getLineTag _getLineTagFunc;
         internal static int getLineTag(IntPtr thisPtr, int pos)
         {
         	if (_getLineTagFunc == null)
         	{
         		_getLineTagFunc =
         			(_getLineTag)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMessageVector_getLineTag"), typeof(_getLineTag));
         	}
         
         	return  _getLineTagFunc(thisPtr, pos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MessageVector_create();
         private static _MessageVector_create _MessageVector_createFunc;
         internal static IntPtr MessageVector_create()
         {
         	if (_MessageVector_createFunc == null)
         	{
         		_MessageVector_createFunc =
         			(_MessageVector_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_MessageVector_create"), typeof(_MessageVector_create));
         	}
         
         	return  _MessageVector_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void clear()
         {
            InternalUnsafeMethods.clear(ObjectPtr);
         }
      
         public virtual void pushBackLine(string msg, int tag)
         {
            InternalUnsafeMethods.pushBackLine(ObjectPtr, msg, tag);
         }
      
         public virtual bool popBackLine()
         {
            return InternalUnsafeMethods.popBackLine(ObjectPtr);
         }
      
         public virtual void pushFrontLine(string msg, int tag)
         {
            InternalUnsafeMethods.pushFrontLine(ObjectPtr, msg, tag);
         }
      
         public virtual bool popFrontLine()
         {
            return InternalUnsafeMethods.popFrontLine(ObjectPtr);
         }
      
         public virtual bool insertLine(int insertPos, string msg, int tag)
         {
            return InternalUnsafeMethods.insertLine(ObjectPtr, insertPos, msg, tag);
         }
      
         public virtual bool deleteLine(int deletePos)
         {
            return InternalUnsafeMethods.deleteLine(ObjectPtr, deletePos);
         }
      
         public virtual void dump(string filename, string header = "")
         {
            InternalUnsafeMethods.dump(ObjectPtr, filename, header);
         }
      
         public virtual int getNumLines()
         {
            return InternalUnsafeMethods.getNumLines(ObjectPtr);
         }
      
         public virtual string getLineTextByTag(int tag)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getLineTextByTag(ObjectPtr, tag));
         }
      
         public virtual int getLineIndexByTag(int tag)
         {
            return InternalUnsafeMethods.getLineIndexByTag(ObjectPtr, tag);
         }
      
         public virtual string getLineText(int pos)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getLineText(ObjectPtr, pos));
         }
      
         public virtual int getLineTag(int pos)
         {
            return InternalUnsafeMethods.getLineTag(ObjectPtr, pos);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}