using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class AssetBase : SimObject
	{
		public AssetBase(bool pRegister = false)
			: base(pRegister)
		{
		}

		public AssetBase(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public AssetBase(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public AssetBase(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public AssetBase(SimObject pObj) : base(pObj)
		{
		}

		public AssetBase(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.AssetBase_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _refreshAsset(IntPtr thisPtr);
         private static _refreshAsset _refreshAssetFunc;
         internal static void refreshAsset(IntPtr thisPtr)
         {
         	if (_refreshAssetFunc == null)
         	{
         		_refreshAssetFunc =
         			(_refreshAsset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetBase_refreshAsset"), typeof(_refreshAsset));
         	}
         
         	 _refreshAssetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getAssetId(IntPtr thisPtr);
         private static _getAssetId _getAssetIdFunc;
         internal static IntPtr getAssetId(IntPtr thisPtr)
         {
         	if (_getAssetIdFunc == null)
         	{
         		_getAssetIdFunc =
         			(_getAssetId)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetBase_getAssetId"), typeof(_getAssetId));
         	}
         
         	return  _getAssetIdFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetBase_create();
         private static _AssetBase_create _AssetBase_createFunc;
         internal static IntPtr AssetBase_create()
         {
         	if (_AssetBase_createFunc == null)
         	{
         		_AssetBase_createFunc =
         			(_AssetBase_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AssetBase_create"), typeof(_AssetBase_create));
         	}
         
         	return  _AssetBase_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void refreshAsset()
         {
            InternalUnsafeMethods.refreshAsset(ObjectPtr);
         }
      
         public virtual string getAssetId()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getAssetId(ObjectPtr));
         }
      
      
      #endregion


      #region Properties
      
      
         public string AssetName
         {
         	get { return getFieldValue("AssetName"); }
         	set { setFieldValue("AssetName", value); }
         }
      
         public string AssetDescription
         {
         	get { return getFieldValue("AssetDescription"); }
         	set { setFieldValue("AssetDescription", value); }
         }
      
         public string AssetCategory
         {
         	get { return getFieldValue("AssetCategory"); }
         	set { setFieldValue("AssetCategory", value); }
         }
      
         public bool AssetAutoUnload
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AssetAutoUnload")); }
         	set { setFieldValue("AssetAutoUnload", value ? "1" : "0"); }
         }
      
         public bool AssetInternal
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AssetInternal")); }
         	set { setFieldValue("AssetInternal", value ? "1" : "0"); }
         }
      
         public bool AssetPrivate
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AssetPrivate")); }
         	set { setFieldValue("AssetPrivate", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}