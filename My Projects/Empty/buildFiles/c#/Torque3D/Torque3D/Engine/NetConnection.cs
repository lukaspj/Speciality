using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class NetConnection : SimGroup
	{
		public NetConnection(bool pRegister = false)
			: base(pRegister)
		{
		}

		public NetConnection(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public NetConnection(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public NetConnection(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public NetConnection(SimObject pObj) : base(pObj)
		{
		}

		public NetConnection(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.NetConnection_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _transmitPaths(IntPtr thisPtr);
         private static _transmitPaths _transmitPathsFunc;
         internal static void transmitPaths(IntPtr thisPtr)
         {
         	if (_transmitPathsFunc == null)
         	{
         		_transmitPathsFunc =
         			(_transmitPaths)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNetConnection_transmitPaths"), typeof(_transmitPaths));
         	}
         
         	 _transmitPathsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearPaths(IntPtr thisPtr);
         private static _clearPaths _clearPathsFunc;
         internal static void clearPaths(IntPtr thisPtr)
         {
         	if (_clearPathsFunc == null)
         	{
         		_clearPathsFunc =
         			(_clearPaths)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNetConnection_clearPaths"), typeof(_clearPaths));
         	}
         
         	 _clearPathsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getAddress(IntPtr thisPtr);
         private static _getAddress _getAddressFunc;
         internal static IntPtr getAddress(IntPtr thisPtr)
         {
         	if (_getAddressFunc == null)
         	{
         		_getAddressFunc =
         			(_getAddress)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNetConnection_getAddress"), typeof(_getAddress));
         	}
         
         	return  _getAddressFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSimulatedNetParams(IntPtr thisPtr, float packetLoss, int delay);
         private static _setSimulatedNetParams _setSimulatedNetParamsFunc;
         internal static void setSimulatedNetParams(IntPtr thisPtr, float packetLoss, int delay)
         {
         	if (_setSimulatedNetParamsFunc == null)
         	{
         		_setSimulatedNetParamsFunc =
         			(_setSimulatedNetParams)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNetConnection_setSimulatedNetParams"), typeof(_setSimulatedNetParams));
         	}
         
         	 _setSimulatedNetParamsFunc(thisPtr, packetLoss, delay);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getPing(IntPtr thisPtr);
         private static _getPing _getPingFunc;
         internal static int getPing(IntPtr thisPtr)
         {
         	if (_getPingFunc == null)
         	{
         		_getPingFunc =
         			(_getPing)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNetConnection_getPing"), typeof(_getPing));
         	}
         
         	return  _getPingFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getPacketLoss(IntPtr thisPtr);
         private static _getPacketLoss _getPacketLossFunc;
         internal static int getPacketLoss(IntPtr thisPtr)
         {
         	if (_getPacketLossFunc == null)
         	{
         		_getPacketLossFunc =
         			(_getPacketLoss)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNetConnection_getPacketLoss"), typeof(_getPacketLoss));
         	}
         
         	return  _getPacketLossFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _checkMaxRate(IntPtr thisPtr);
         private static _checkMaxRate _checkMaxRateFunc;
         internal static void checkMaxRate(IntPtr thisPtr)
         {
         	if (_checkMaxRateFunc == null)
         	{
         		_checkMaxRateFunc =
         			(_checkMaxRate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNetConnection_checkMaxRate"), typeof(_checkMaxRate));
         	}
         
         	 _checkMaxRateFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _resolveGhostID(IntPtr thisPtr, int ghostID);
         private static _resolveGhostID _resolveGhostIDFunc;
         internal static int resolveGhostID(IntPtr thisPtr, int ghostID)
         {
         	if (_resolveGhostIDFunc == null)
         	{
         		_resolveGhostIDFunc =
         			(_resolveGhostID)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNetConnection_resolveGhostID"), typeof(_resolveGhostID));
         	}
         
         	return  _resolveGhostIDFunc(thisPtr, ghostID);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _resolveObjectFromGhostIndex(IntPtr thisPtr, int ghostID);
         private static _resolveObjectFromGhostIndex _resolveObjectFromGhostIndexFunc;
         internal static int resolveObjectFromGhostIndex(IntPtr thisPtr, int ghostID)
         {
         	if (_resolveObjectFromGhostIndexFunc == null)
         	{
         		_resolveObjectFromGhostIndexFunc =
         			(_resolveObjectFromGhostIndex)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNetConnection_resolveObjectFromGhostIndex"), typeof(_resolveObjectFromGhostIndex));
         	}
         
         	return  _resolveObjectFromGhostIndexFunc(thisPtr, ghostID);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getGhostID(IntPtr thisPtr, int realID);
         private static _getGhostID _getGhostIDFunc;
         internal static int getGhostID(IntPtr thisPtr, int realID)
         {
         	if (_getGhostIDFunc == null)
         	{
         		_getGhostIDFunc =
         			(_getGhostID)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNetConnection_getGhostID"), typeof(_getGhostID));
         	}
         
         	return  _getGhostIDFunc(thisPtr, realID);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _connect(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string remoteAddress);
         private static _connect _connectFunc;
         internal static void connect(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string remoteAddress)
         {
         	if (_connectFunc == null)
         	{
         		_connectFunc =
         			(_connect)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNetConnection_connect"), typeof(_connect));
         	}
         
         	 _connectFunc(thisPtr, remoteAddress);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _connectLocal(IntPtr thisPtr);
         private static _connectLocal _connectLocalFunc;
         internal static IntPtr connectLocal(IntPtr thisPtr)
         {
         	if (_connectLocalFunc == null)
         	{
         		_connectLocalFunc =
         			(_connectLocal)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNetConnection_connectLocal"), typeof(_connectLocal));
         	}
         
         	return  _connectLocalFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getGhostsActive(IntPtr thisPtr);
         private static _getGhostsActive _getGhostsActiveFunc;
         internal static int getGhostsActive(IntPtr thisPtr)
         {
         	if (_getGhostsActiveFunc == null)
         	{
         		_getGhostsActiveFunc =
         			(_getGhostsActive)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNetConnection_getGhostsActive"), typeof(_getGhostsActive));
         	}
         
         	return  _getGhostsActiveFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _NetConnection_create();
         private static _NetConnection_create _NetConnection_createFunc;
         internal static IntPtr NetConnection_create()
         {
         	if (_NetConnection_createFunc == null)
         	{
         		_NetConnection_createFunc =
         			(_NetConnection_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_NetConnection_create"), typeof(_NetConnection_create));
         	}
         
         	return  _NetConnection_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void transmitPaths()
         {
            InternalUnsafeMethods.transmitPaths(ObjectPtr);
         }
      
         public virtual void clearPaths()
         {
            InternalUnsafeMethods.clearPaths(ObjectPtr);
         }
      
         public virtual string getAddress()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getAddress(ObjectPtr));
         }
      
         public virtual void setSimulatedNetParams(float packetLoss, int delay)
         {
            InternalUnsafeMethods.setSimulatedNetParams(ObjectPtr, packetLoss, delay);
         }
      
         public virtual int getPing()
         {
            return InternalUnsafeMethods.getPing(ObjectPtr);
         }
      
         public virtual int getPacketLoss()
         {
            return InternalUnsafeMethods.getPacketLoss(ObjectPtr);
         }
      
         public virtual void checkMaxRate()
         {
            InternalUnsafeMethods.checkMaxRate(ObjectPtr);
         }
      
         public virtual int resolveGhostID(int ghostID)
         {
            return InternalUnsafeMethods.resolveGhostID(ObjectPtr, ghostID);
         }
      
         public virtual int resolveObjectFromGhostIndex(int ghostID)
         {
            return InternalUnsafeMethods.resolveObjectFromGhostIndex(ObjectPtr, ghostID);
         }
      
         public virtual int getGhostID(int realID)
         {
            return InternalUnsafeMethods.getGhostID(ObjectPtr, realID);
         }
      
         public virtual void connect(string remoteAddress)
         {
            InternalUnsafeMethods.connect(ObjectPtr, remoteAddress);
         }
      
         public virtual string connectLocal()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.connectLocal(ObjectPtr));
         }
      
         public virtual int getGhostsActive()
         {
            return InternalUnsafeMethods.getGhostsActive(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}