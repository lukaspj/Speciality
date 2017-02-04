using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ActionMap : SimObject
	{
		public ActionMap(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ActionMap(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ActionMap(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ActionMap(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ActionMap(SimObject pObj) : base(pObj)
		{
		}

		public ActionMap(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ActionMap_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _bind(IntPtr thisPtr, int argc, string[] argv);
         private static _bind _bindFunc;
         internal static bool bind(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_bindFunc == null)
         	{
         		_bindFunc =
         			(_bind)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnActionMap_bind"), typeof(_bind));
         	}
         
         	return  _bindFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _bindObj(IntPtr thisPtr, int argc, string[] argv);
         private static _bindObj _bindObjFunc;
         internal static bool bindObj(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_bindObjFunc == null)
         	{
         		_bindObjFunc =
         			(_bindObj)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnActionMap_bindObj"), typeof(_bindObj));
         	}
         
         	return  _bindObjFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _bindCmd(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string device, [MarshalAs(UnmanagedType.LPWStr)]string action, [MarshalAs(UnmanagedType.LPWStr)]string makeCmd, [MarshalAs(UnmanagedType.LPWStr)]string breakCmd);
         private static _bindCmd _bindCmdFunc;
         internal static bool bindCmd(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string device, [MarshalAs(UnmanagedType.LPWStr)]string action, [MarshalAs(UnmanagedType.LPWStr)]string makeCmd, [MarshalAs(UnmanagedType.LPWStr)]string breakCmd)
         {
         	if (_bindCmdFunc == null)
         	{
         		_bindCmdFunc =
         			(_bindCmd)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnActionMap_bindCmd"), typeof(_bindCmd));
         	}
         
         	return  _bindCmdFunc(thisPtr, device, action, makeCmd, breakCmd);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _unbind(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string device, [MarshalAs(UnmanagedType.LPWStr)]string action);
         private static _unbind _unbindFunc;
         internal static bool unbind(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string device, [MarshalAs(UnmanagedType.LPWStr)]string action)
         {
         	if (_unbindFunc == null)
         	{
         		_unbindFunc =
         			(_unbind)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnActionMap_unbind"), typeof(_unbind));
         	}
         
         	return  _unbindFunc(thisPtr, device, action);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _unbindObj(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string device, [MarshalAs(UnmanagedType.LPWStr)]string action, [MarshalAs(UnmanagedType.LPWStr)]string obj);
         private static _unbindObj _unbindObjFunc;
         internal static bool unbindObj(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string device, [MarshalAs(UnmanagedType.LPWStr)]string action, [MarshalAs(UnmanagedType.LPWStr)]string obj)
         {
         	if (_unbindObjFunc == null)
         	{
         		_unbindObjFunc =
         			(_unbindObj)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnActionMap_unbindObj"), typeof(_unbindObj));
         	}
         
         	return  _unbindObjFunc(thisPtr, device, action, obj);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _save(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fileName, bool append);
         private static _save _saveFunc;
         internal static void save(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fileName, bool append)
         {
         	if (_saveFunc == null)
         	{
         		_saveFunc =
         			(_save)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnActionMap_save"), typeof(_save));
         	}
         
         	 _saveFunc(thisPtr, fileName, append);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _push(IntPtr thisPtr);
         private static _push _pushFunc;
         internal static void push(IntPtr thisPtr)
         {
         	if (_pushFunc == null)
         	{
         		_pushFunc =
         			(_push)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnActionMap_push"), typeof(_push));
         	}
         
         	 _pushFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _pop(IntPtr thisPtr);
         private static _pop _popFunc;
         internal static void pop(IntPtr thisPtr)
         {
         	if (_popFunc == null)
         	{
         		_popFunc =
         			(_pop)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnActionMap_pop"), typeof(_pop));
         	}
         
         	 _popFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getBinding(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string command);
         private static _getBinding _getBindingFunc;
         internal static IntPtr getBinding(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string command)
         {
         	if (_getBindingFunc == null)
         	{
         		_getBindingFunc =
         			(_getBinding)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnActionMap_getBinding"), typeof(_getBinding));
         	}
         
         	return  _getBindingFunc(thisPtr, command);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getCommand(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string device, [MarshalAs(UnmanagedType.LPWStr)]string action);
         private static _getCommand _getCommandFunc;
         internal static IntPtr getCommand(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string device, [MarshalAs(UnmanagedType.LPWStr)]string action)
         {
         	if (_getCommandFunc == null)
         	{
         		_getCommandFunc =
         			(_getCommand)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnActionMap_getCommand"), typeof(_getCommand));
         	}
         
         	return  _getCommandFunc(thisPtr, device, action);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isInverted(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string device, [MarshalAs(UnmanagedType.LPWStr)]string action);
         private static _isInverted _isInvertedFunc;
         internal static bool isInverted(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string device, [MarshalAs(UnmanagedType.LPWStr)]string action)
         {
         	if (_isInvertedFunc == null)
         	{
         		_isInvertedFunc =
         			(_isInverted)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnActionMap_isInverted"), typeof(_isInverted));
         	}
         
         	return  _isInvertedFunc(thisPtr, device, action);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getScale(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string device, [MarshalAs(UnmanagedType.LPWStr)]string action);
         private static _getScale _getScaleFunc;
         internal static float getScale(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string device, [MarshalAs(UnmanagedType.LPWStr)]string action)
         {
         	if (_getScaleFunc == null)
         	{
         		_getScaleFunc =
         			(_getScale)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnActionMap_getScale"), typeof(_getScale));
         	}
         
         	return  _getScaleFunc(thisPtr, device, action);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getDeadZone(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string device, [MarshalAs(UnmanagedType.LPWStr)]string action);
         private static _getDeadZone _getDeadZoneFunc;
         internal static IntPtr getDeadZone(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string device, [MarshalAs(UnmanagedType.LPWStr)]string action)
         {
         	if (_getDeadZoneFunc == null)
         	{
         		_getDeadZoneFunc =
         			(_getDeadZone)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnActionMap_getDeadZone"), typeof(_getDeadZone));
         	}
         
         	return  _getDeadZoneFunc(thisPtr, device, action);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ActionMap_create();
         private static _ActionMap_create _ActionMap_createFunc;
         internal static IntPtr ActionMap_create()
         {
         	if (_ActionMap_createFunc == null)
         	{
         		_ActionMap_createFunc =
         			(_ActionMap_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ActionMap_create"), typeof(_ActionMap_create));
         	}
         
         	return  _ActionMap_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool bind(params string[] args)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
         tmp_arg_list.AddRange(args);
                  return InternalUnsafeMethods.bind(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual bool bindObj(params string[] args)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
         tmp_arg_list.AddRange(args);
         return InternalUnsafeMethods.bindObj(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual bool bindCmd(string device, string action, string makeCmd, string breakCmd = "")
         {
            return InternalUnsafeMethods.bindCmd(ObjectPtr, device, action, makeCmd, breakCmd);
         }
      
         public virtual bool unbind(string device, string action)
         {
            return InternalUnsafeMethods.unbind(ObjectPtr, device, action);
         }
      
         public virtual bool unbindObj(string device, string action, string obj)
         {
            return InternalUnsafeMethods.unbindObj(ObjectPtr, device, action, obj);
         }
      
         public virtual void save(string fileName = null, bool append = false)
         {
            InternalUnsafeMethods.save(ObjectPtr, fileName, append);
         }
      
         public virtual void push()
         {
            InternalUnsafeMethods.push(ObjectPtr);
         }
      
         public virtual void pop()
         {
            InternalUnsafeMethods.pop(ObjectPtr);
         }
      
         public virtual string getBinding(string command)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getBinding(ObjectPtr, command));
         }
      
         public virtual string getCommand(string device, string action)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getCommand(ObjectPtr, device, action));
         }
      
         public virtual bool isInverted(string device, string action)
         {
            return InternalUnsafeMethods.isInverted(ObjectPtr, device, action);
         }
      
         public virtual float getScale(string device, string action)
         {
            return InternalUnsafeMethods.getScale(ObjectPtr, device, action);
         }
      
         public virtual string getDeadZone(string device, string action)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getDeadZone(ObjectPtr, device, action));
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}