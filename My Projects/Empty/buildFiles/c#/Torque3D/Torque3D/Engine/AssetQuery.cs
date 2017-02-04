using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class AssetQuery : SimObject
	{
		public AssetQuery(bool pRegister = false)
			: base(pRegister)
		{
		}

		public AssetQuery(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public AssetQuery(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public AssetQuery(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public AssetQuery(SimObject pObj) : base(pObj)
		{
		}

		public AssetQuery(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.AssetQuery_create();
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
         				"fnAssetQuery_clear"), typeof(_clear));
         	}
         
         	 _clearFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _set(IntPtr thisPtr, int queryId);
         private static _set _setFunc;
         internal static bool set(IntPtr thisPtr, int queryId)
         {
         	if (_setFunc == null)
         	{
         		_setFunc =
         			(_set)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetQuery_set"), typeof(_set));
         	}
         
         	return  _setFunc(thisPtr, queryId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getCount(IntPtr thisPtr);
         private static _getCount _getCountFunc;
         internal static int getCount(IntPtr thisPtr)
         {
         	if (_getCountFunc == null)
         	{
         		_getCountFunc =
         			(_getCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetQuery_getCount"), typeof(_getCount));
         	}
         
         	return  _getCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getAsset(IntPtr thisPtr, int resultIndex);
         private static _getAsset _getAssetFunc;
         internal static IntPtr getAsset(IntPtr thisPtr, int resultIndex)
         {
         	if (_getAssetFunc == null)
         	{
         		_getAssetFunc =
         			(_getAsset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetQuery_getAsset"), typeof(_getAsset));
         	}
         
         	return  _getAssetFunc(thisPtr, resultIndex);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetQuery_create();
         private static _AssetQuery_create _AssetQuery_createFunc;
         internal static IntPtr AssetQuery_create()
         {
         	if (_AssetQuery_createFunc == null)
         	{
         		_AssetQuery_createFunc =
         			(_AssetQuery_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AssetQuery_create"), typeof(_AssetQuery_create));
         	}
         
         	return  _AssetQuery_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void clear()
         {
            InternalUnsafeMethods.clear(ObjectPtr);
         }
      
         public virtual bool set(int queryId)
         {
            return InternalUnsafeMethods.set(ObjectPtr, queryId);
         }
      
         public virtual int getCount()
         {
            return InternalUnsafeMethods.getCount(ObjectPtr);
         }
      
         public virtual string getAsset(int resultIndex = -1)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getAsset(ObjectPtr, resultIndex));
         }
      
      
      #endregion


      #region Properties
      
      
         public int Count
         {
         	get { return int.Parse(getFieldValue("Count")); }
         	set { setFieldValue("Count", value.ToString()); }
         }
      
      
      #endregion

	}
}