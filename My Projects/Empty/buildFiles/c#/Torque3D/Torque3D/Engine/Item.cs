using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class Item : ShapeBase
	{
		public Item(bool pRegister = false)
			: base(pRegister)
		{
		}

		public Item(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public Item(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public Item(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public Item(SimObject pObj) : base(pObj)
		{
		}

		public Item(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Item_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isStatic(IntPtr thisPtr);
         private static _isStatic _isStaticFunc;
         internal static bool isStatic(IntPtr thisPtr)
         {
         	if (_isStaticFunc == null)
         	{
         		_isStaticFunc =
         			(_isStatic)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnItem_isStatic"), typeof(_isStatic));
         	}
         
         	return  _isStaticFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isAtRest(IntPtr thisPtr);
         private static _isAtRest _isAtRestFunc;
         internal static bool isAtRest(IntPtr thisPtr)
         {
         	if (_isAtRestFunc == null)
         	{
         		_isAtRestFunc =
         			(_isAtRest)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnItem_isAtRest"), typeof(_isAtRest));
         	}
         
         	return  _isAtRestFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isRotating(IntPtr thisPtr);
         private static _isRotating _isRotatingFunc;
         internal static bool isRotating(IntPtr thisPtr)
         {
         	if (_isRotatingFunc == null)
         	{
         		_isRotatingFunc =
         			(_isRotating)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnItem_isRotating"), typeof(_isRotating));
         	}
         
         	return  _isRotatingFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setCollisionTimeout(IntPtr thisPtr, int ignoreColObj);
         private static _setCollisionTimeout _setCollisionTimeoutFunc;
         internal static bool setCollisionTimeout(IntPtr thisPtr, int ignoreColObj)
         {
         	if (_setCollisionTimeoutFunc == null)
         	{
         		_setCollisionTimeoutFunc =
         			(_setCollisionTimeout)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnItem_setCollisionTimeout"), typeof(_setCollisionTimeout));
         	}
         
         	return  _setCollisionTimeoutFunc(thisPtr, ignoreColObj);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getLastStickyPos(IntPtr thisPtr);
         private static _getLastStickyPos _getLastStickyPosFunc;
         internal static IntPtr getLastStickyPos(IntPtr thisPtr)
         {
         	if (_getLastStickyPosFunc == null)
         	{
         		_getLastStickyPosFunc =
         			(_getLastStickyPos)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnItem_getLastStickyPos"), typeof(_getLastStickyPos));
         	}
         
         	return  _getLastStickyPosFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getLastStickyNormal(IntPtr thisPtr);
         private static _getLastStickyNormal _getLastStickyNormalFunc;
         internal static IntPtr getLastStickyNormal(IntPtr thisPtr)
         {
         	if (_getLastStickyNormalFunc == null)
         	{
         		_getLastStickyNormalFunc =
         			(_getLastStickyNormal)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnItem_getLastStickyNormal"), typeof(_getLastStickyNormal));
         	}
         
         	return  _getLastStickyNormalFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Item_create();
         private static _Item_create _Item_createFunc;
         internal static IntPtr Item_create()
         {
         	if (_Item_createFunc == null)
         	{
         		_Item_createFunc =
         			(_Item_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Item_create"), typeof(_Item_create));
         	}
         
         	return  _Item_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool isStatic()
         {
            return InternalUnsafeMethods.isStatic(ObjectPtr);
         }
      
         public virtual bool isAtRest()
         {
            return InternalUnsafeMethods.isAtRest(ObjectPtr);
         }
      
         public virtual bool isRotating()
         {
            return InternalUnsafeMethods.isRotating(ObjectPtr);
         }
      
         public virtual bool setCollisionTimeout(int ignoreColObj)
         {
            return InternalUnsafeMethods.setCollisionTimeout(ObjectPtr, ignoreColObj);
         }
      
         public virtual string getLastStickyPos()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getLastStickyPos(ObjectPtr));
         }
      
         public virtual string getLastStickyNormal()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getLastStickyNormal(ObjectPtr));
         }
      
      
      #endregion


      #region Properties
      
      
         public bool Static
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Static")); }
         	set { setFieldValue("Static", value ? "1" : "0"); }
         }
      
         public bool Rotate
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Rotate")); }
         	set { setFieldValue("Rotate", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}