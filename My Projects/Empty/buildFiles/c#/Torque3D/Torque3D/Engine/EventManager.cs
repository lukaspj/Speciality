using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class EventManager : SimObject
	{
		public EventManager(bool pRegister = false)
			: base(pRegister)
		{
		}

		public EventManager(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public EventManager(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public EventManager(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public EventManager(SimObject pObj) : base(pObj)
		{
		}

		public EventManager(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.EventManager_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _registerEvent(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string evt);
         private static _registerEvent _registerEventFunc;
         internal static bool registerEvent(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string evt)
         {
         	if (_registerEventFunc == null)
         	{
         		_registerEventFunc =
         			(_registerEvent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEventManager_registerEvent"), typeof(_registerEvent));
         	}
         
         	return  _registerEventFunc(thisPtr, evt);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _unregisterEvent(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string evt);
         private static _unregisterEvent _unregisterEventFunc;
         internal static void unregisterEvent(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string evt)
         {
         	if (_unregisterEventFunc == null)
         	{
         		_unregisterEventFunc =
         			(_unregisterEvent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEventManager_unregisterEvent"), typeof(_unregisterEvent));
         	}
         
         	 _unregisterEventFunc(thisPtr, evt);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isRegisteredEvent(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string evt);
         private static _isRegisteredEvent _isRegisteredEventFunc;
         internal static bool isRegisteredEvent(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string evt)
         {
         	if (_isRegisteredEventFunc == null)
         	{
         		_isRegisteredEventFunc =
         			(_isRegisteredEvent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEventManager_isRegisteredEvent"), typeof(_isRegisteredEvent));
         	}
         
         	return  _isRegisteredEventFunc(thisPtr, evt);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _postEvent(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string evt, [MarshalAs(UnmanagedType.LPWStr)]string data);
         private static _postEvent _postEventFunc;
         internal static bool postEvent(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string evt, [MarshalAs(UnmanagedType.LPWStr)]string data)
         {
         	if (_postEventFunc == null)
         	{
         		_postEventFunc =
         			(_postEvent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEventManager_postEvent"), typeof(_postEvent));
         	}
         
         	return  _postEventFunc(thisPtr, evt, data);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _subscribe(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string listenerName, [MarshalAs(UnmanagedType.LPWStr)]string evt, [MarshalAs(UnmanagedType.LPWStr)]string callback);
         private static _subscribe _subscribeFunc;
         internal static bool subscribe(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string listenerName, [MarshalAs(UnmanagedType.LPWStr)]string evt, [MarshalAs(UnmanagedType.LPWStr)]string callback)
         {
         	if (_subscribeFunc == null)
         	{
         		_subscribeFunc =
         			(_subscribe)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEventManager_subscribe"), typeof(_subscribe));
         	}
         
         	return  _subscribeFunc(thisPtr, listenerName, evt, callback);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _remove(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string listenerName, [MarshalAs(UnmanagedType.LPWStr)]string evt);
         private static _remove _removeFunc;
         internal static void remove(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string listenerName, [MarshalAs(UnmanagedType.LPWStr)]string evt)
         {
         	if (_removeFunc == null)
         	{
         		_removeFunc =
         			(_remove)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEventManager_remove"), typeof(_remove));
         	}
         
         	 _removeFunc(thisPtr, listenerName, evt);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeAll(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string listenerName);
         private static _removeAll _removeAllFunc;
         internal static void removeAll(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string listenerName)
         {
         	if (_removeAllFunc == null)
         	{
         		_removeAllFunc =
         			(_removeAll)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEventManager_removeAll"), typeof(_removeAll));
         	}
         
         	 _removeAllFunc(thisPtr, listenerName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dumpEvents(IntPtr thisPtr);
         private static _dumpEvents _dumpEventsFunc;
         internal static void dumpEvents(IntPtr thisPtr)
         {
         	if (_dumpEventsFunc == null)
         	{
         		_dumpEventsFunc =
         			(_dumpEvents)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEventManager_dumpEvents"), typeof(_dumpEvents));
         	}
         
         	 _dumpEventsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dumpSubscribers(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string listenerName);
         private static _dumpSubscribers _dumpSubscribersFunc;
         internal static void dumpSubscribers(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string listenerName)
         {
         	if (_dumpSubscribersFunc == null)
         	{
         		_dumpSubscribersFunc =
         			(_dumpSubscribers)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEventManager_dumpSubscribers"), typeof(_dumpSubscribers));
         	}
         
         	 _dumpSubscribersFunc(thisPtr, listenerName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _EventManager_create();
         private static _EventManager_create _EventManager_createFunc;
         internal static IntPtr EventManager_create()
         {
         	if (_EventManager_createFunc == null)
         	{
         		_EventManager_createFunc =
         			(_EventManager_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_EventManager_create"), typeof(_EventManager_create));
         	}
         
         	return  _EventManager_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool registerEvent(string evt)
         {
            return InternalUnsafeMethods.registerEvent(ObjectPtr, evt);
         }
      
         public virtual void unregisterEvent(string evt)
         {
            InternalUnsafeMethods.unregisterEvent(ObjectPtr, evt);
         }
      
         public virtual bool isRegisteredEvent(string evt)
         {
            return InternalUnsafeMethods.isRegisteredEvent(ObjectPtr, evt);
         }
      
         public virtual bool postEvent(string evt, string data = "")
         {
            return InternalUnsafeMethods.postEvent(ObjectPtr, evt, data);
         }
      
         public virtual bool subscribe(string listenerName, string evt, string callback = "")
         {
            return InternalUnsafeMethods.subscribe(ObjectPtr, listenerName, evt, callback);
         }
      
         public virtual void remove(string listenerName, string evt)
         {
            InternalUnsafeMethods.remove(ObjectPtr, listenerName, evt);
         }
      
         public virtual void removeAll(string listenerName)
         {
            InternalUnsafeMethods.removeAll(ObjectPtr, listenerName);
         }
      
         public virtual void dumpEvents()
         {
            InternalUnsafeMethods.dumpEvents(ObjectPtr);
         }
      
         public virtual void dumpSubscribers(string listenerName = "")
         {
            InternalUnsafeMethods.dumpSubscribers(ObjectPtr, listenerName);
         }
      
      
      #endregion


      #region Properties
      
      
         public string Queue
         {
         	get { return getFieldValue("Queue"); }
         	set { setFieldValue("Queue", value); }
         }
      
      
      #endregion

	}
}