using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class TCPObject : SimObject
	{
		public TCPObject(bool pRegister = false)
			: base(pRegister)
		{
		}

		public TCPObject(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public TCPObject(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public TCPObject(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public TCPObject(SimObject pObj) : base(pObj)
		{
		}

		public TCPObject(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.TCPObject_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _send(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string data);
         private static _send _sendFunc;
         internal static void send(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string data)
         {
         	if (_sendFunc == null)
         	{
         		_sendFunc =
         			(_send)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTCPObject_send"), typeof(_send));
         	}
         
         	 _sendFunc(thisPtr, data);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _sendFile(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fileName);
         private static _sendFile _sendFileFunc;
         internal static bool sendFile(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fileName)
         {
         	if (_sendFileFunc == null)
         	{
         		_sendFileFunc =
         			(_sendFile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTCPObject_sendFile"), typeof(_sendFile));
         	}
         
         	return  _sendFileFunc(thisPtr, fileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _finishLastLine(IntPtr thisPtr);
         private static _finishLastLine _finishLastLineFunc;
         internal static void finishLastLine(IntPtr thisPtr)
         {
         	if (_finishLastLineFunc == null)
         	{
         		_finishLastLineFunc =
         			(_finishLastLine)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTCPObject_finishLastLine"), typeof(_finishLastLine));
         	}
         
         	 _finishLastLineFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _listen(IntPtr thisPtr, uint port);
         private static _listen _listenFunc;
         internal static void listen(IntPtr thisPtr, uint port)
         {
         	if (_listenFunc == null)
         	{
         		_listenFunc =
         			(_listen)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTCPObject_listen"), typeof(_listen));
         	}
         
         	 _listenFunc(thisPtr, port);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _connect(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string address);
         private static _connect _connectFunc;
         internal static void connect(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string address)
         {
         	if (_connectFunc == null)
         	{
         		_connectFunc =
         			(_connect)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTCPObject_connect"), typeof(_connect));
         	}
         
         	 _connectFunc(thisPtr, address);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _disconnect(IntPtr thisPtr);
         private static _disconnect _disconnectFunc;
         internal static void disconnect(IntPtr thisPtr)
         {
         	if (_disconnectFunc == null)
         	{
         		_disconnectFunc =
         			(_disconnect)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTCPObject_disconnect"), typeof(_disconnect));
         	}
         
         	 _disconnectFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TCPObject_create();
         private static _TCPObject_create _TCPObject_createFunc;
         internal static IntPtr TCPObject_create()
         {
         	if (_TCPObject_createFunc == null)
         	{
         		_TCPObject_createFunc =
         			(_TCPObject_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_TCPObject_create"), typeof(_TCPObject_create));
         	}
         
         	return  _TCPObject_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void send(string data)
         {
            InternalUnsafeMethods.send(ObjectPtr, data);
         }
      
         public virtual bool sendFile(string fileName)
         {
            return InternalUnsafeMethods.sendFile(ObjectPtr, fileName);
         }
      
         public virtual void finishLastLine()
         {
            InternalUnsafeMethods.finishLastLine(ObjectPtr);
         }
      
         public virtual void listen(uint port)
         {
            InternalUnsafeMethods.listen(ObjectPtr, port);
         }
      
         public virtual void connect(string address)
         {
            InternalUnsafeMethods.connect(ObjectPtr, address);
         }
      
         public virtual void disconnect()
         {
            InternalUnsafeMethods.disconnect(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}