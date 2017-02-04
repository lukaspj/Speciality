using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class NetObject : SimGroup
	{
		public NetObject(bool pRegister = false)
			: base(pRegister)
		{
		}

		public NetObject(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public NetObject(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public NetObject(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public NetObject(SimObject pObj) : base(pObj)
		{
		}

		public NetObject(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.NetObject_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _scopeToClient(IntPtr thisPtr, IntPtr client);
         private static _scopeToClient _scopeToClientFunc;
         internal static void scopeToClient(IntPtr thisPtr, IntPtr client)
         {
         	if (_scopeToClientFunc == null)
         	{
         		_scopeToClientFunc =
         			(_scopeToClient)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNetObject_scopeToClient"), typeof(_scopeToClient));
         	}
         
         	 _scopeToClientFunc(thisPtr, client);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearScopeToClient(IntPtr thisPtr, IntPtr client);
         private static _clearScopeToClient _clearScopeToClientFunc;
         internal static void clearScopeToClient(IntPtr thisPtr, IntPtr client)
         {
         	if (_clearScopeToClientFunc == null)
         	{
         		_clearScopeToClientFunc =
         			(_clearScopeToClient)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNetObject_clearScopeToClient"), typeof(_clearScopeToClient));
         	}
         
         	 _clearScopeToClientFunc(thisPtr, client);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setScopeAlways(IntPtr thisPtr);
         private static _setScopeAlways _setScopeAlwaysFunc;
         internal static void setScopeAlways(IntPtr thisPtr)
         {
         	if (_setScopeAlwaysFunc == null)
         	{
         		_setScopeAlwaysFunc =
         			(_setScopeAlways)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNetObject_setScopeAlways"), typeof(_setScopeAlways));
         	}
         
         	 _setScopeAlwaysFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getGhostID(IntPtr thisPtr);
         private static _getGhostID _getGhostIDFunc;
         internal static int getGhostID(IntPtr thisPtr)
         {
         	if (_getGhostIDFunc == null)
         	{
         		_getGhostIDFunc =
         			(_getGhostID)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNetObject_getGhostID"), typeof(_getGhostID));
         	}
         
         	return  _getGhostIDFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getClientObject(IntPtr thisPtr);
         private static _getClientObject _getClientObjectFunc;
         internal static int getClientObject(IntPtr thisPtr)
         {
         	if (_getClientObjectFunc == null)
         	{
         		_getClientObjectFunc =
         			(_getClientObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNetObject_getClientObject"), typeof(_getClientObject));
         	}
         
         	return  _getClientObjectFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getServerObject(IntPtr thisPtr);
         private static _getServerObject _getServerObjectFunc;
         internal static int getServerObject(IntPtr thisPtr)
         {
         	if (_getServerObjectFunc == null)
         	{
         		_getServerObjectFunc =
         			(_getServerObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNetObject_getServerObject"), typeof(_getServerObject));
         	}
         
         	return  _getServerObjectFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isClientObject(IntPtr thisPtr);
         private static _isClientObject _isClientObjectFunc;
         internal static bool isClientObject(IntPtr thisPtr)
         {
         	if (_isClientObjectFunc == null)
         	{
         		_isClientObjectFunc =
         			(_isClientObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNetObject_isClientObject"), typeof(_isClientObject));
         	}
         
         	return  _isClientObjectFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isServerObject(IntPtr thisPtr);
         private static _isServerObject _isServerObjectFunc;
         internal static bool isServerObject(IntPtr thisPtr)
         {
         	if (_isServerObjectFunc == null)
         	{
         		_isServerObjectFunc =
         			(_isServerObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNetObject_isServerObject"), typeof(_isServerObject));
         	}
         
         	return  _isServerObjectFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _NetObject_create();
         private static _NetObject_create _NetObject_createFunc;
         internal static IntPtr NetObject_create()
         {
         	if (_NetObject_createFunc == null)
         	{
         		_NetObject_createFunc =
         			(_NetObject_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_NetObject_create"), typeof(_NetObject_create));
         	}
         
         	return  _NetObject_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void scopeToClient(NetConnection client)
         {
            InternalUnsafeMethods.scopeToClient(ObjectPtr, client.ObjectPtr);
         }
      
         public virtual void clearScopeToClient(NetConnection client)
         {
            InternalUnsafeMethods.clearScopeToClient(ObjectPtr, client.ObjectPtr);
         }
      
         public virtual void setScopeAlways()
         {
            InternalUnsafeMethods.setScopeAlways(ObjectPtr);
         }
      
         public virtual int getGhostID()
         {
            return InternalUnsafeMethods.getGhostID(ObjectPtr);
         }
      
         public virtual int getClientObject()
         {
            return InternalUnsafeMethods.getClientObject(ObjectPtr);
         }
      
         public virtual int getServerObject()
         {
            return InternalUnsafeMethods.getServerObject(ObjectPtr);
         }
      
         public virtual bool isClientObject()
         {
            return InternalUnsafeMethods.isClientObject(ObjectPtr);
         }
      
         public virtual bool isServerObject()
         {
            return InternalUnsafeMethods.isServerObject(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}