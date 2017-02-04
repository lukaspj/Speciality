using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class AssetTagsManifest : SimObject
	{
		public AssetTagsManifest(bool pRegister = false)
			: base(pRegister)
		{
		}

		public AssetTagsManifest(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public AssetTagsManifest(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public AssetTagsManifest(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public AssetTagsManifest(SimObject pObj) : base(pObj)
		{
		}

		public AssetTagsManifest(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.AssetTagsManifest_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _createTag(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string tagName);
         private static _createTag _createTagFunc;
         internal static void createTag(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string tagName)
         {
         	if (_createTagFunc == null)
         	{
         		_createTagFunc =
         			(_createTag)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetTagsManifest_createTag"), typeof(_createTag));
         	}
         
         	 _createTagFunc(thisPtr, tagName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _renameTag(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string oldTagName, [MarshalAs(UnmanagedType.LPWStr)]string newTagName);
         private static _renameTag _renameTagFunc;
         internal static bool renameTag(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string oldTagName, [MarshalAs(UnmanagedType.LPWStr)]string newTagName)
         {
         	if (_renameTagFunc == null)
         	{
         		_renameTagFunc =
         			(_renameTag)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetTagsManifest_renameTag"), typeof(_renameTag));
         	}
         
         	return  _renameTagFunc(thisPtr, oldTagName, newTagName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _deleteTag(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string tagName);
         private static _deleteTag _deleteTagFunc;
         internal static bool deleteTag(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string tagName)
         {
         	if (_deleteTagFunc == null)
         	{
         		_deleteTagFunc =
         			(_deleteTag)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetTagsManifest_deleteTag"), typeof(_deleteTag));
         	}
         
         	return  _deleteTagFunc(thisPtr, tagName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isTag(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string tagName);
         private static _isTag _isTagFunc;
         internal static bool isTag(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string tagName)
         {
         	if (_isTagFunc == null)
         	{
         		_isTagFunc =
         			(_isTag)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetTagsManifest_isTag"), typeof(_isTag));
         	}
         
         	return  _isTagFunc(thisPtr, tagName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getTagCount(IntPtr thisPtr);
         private static _getTagCount _getTagCountFunc;
         internal static int getTagCount(IntPtr thisPtr)
         {
         	if (_getTagCountFunc == null)
         	{
         		_getTagCountFunc =
         			(_getTagCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetTagsManifest_getTagCount"), typeof(_getTagCount));
         	}
         
         	return  _getTagCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getTag(IntPtr thisPtr, int tagIndex);
         private static _getTag _getTagFunc;
         internal static IntPtr getTag(IntPtr thisPtr, int tagIndex)
         {
         	if (_getTagFunc == null)
         	{
         		_getTagFunc =
         			(_getTag)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetTagsManifest_getTag"), typeof(_getTag));
         	}
         
         	return  _getTagFunc(thisPtr, tagIndex);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getAssetTagCount(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId);
         private static _getAssetTagCount _getAssetTagCountFunc;
         internal static int getAssetTagCount(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId)
         {
         	if (_getAssetTagCountFunc == null)
         	{
         		_getAssetTagCountFunc =
         			(_getAssetTagCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetTagsManifest_getAssetTagCount"), typeof(_getAssetTagCount));
         	}
         
         	return  _getAssetTagCountFunc(thisPtr, assetId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getAssetTag(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId, int tagIndex);
         private static _getAssetTag _getAssetTagFunc;
         internal static IntPtr getAssetTag(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId, int tagIndex)
         {
         	if (_getAssetTagFunc == null)
         	{
         		_getAssetTagFunc =
         			(_getAssetTag)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetTagsManifest_getAssetTag"), typeof(_getAssetTag));
         	}
         
         	return  _getAssetTagFunc(thisPtr, assetId, tagIndex);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _tag(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId, [MarshalAs(UnmanagedType.LPWStr)]string tagName);
         private static _tag _tagFunc;
         internal static bool tag(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId, [MarshalAs(UnmanagedType.LPWStr)]string tagName)
         {
         	if (_tagFunc == null)
         	{
         		_tagFunc =
         			(_tag)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetTagsManifest_tag"), typeof(_tag));
         	}
         
         	return  _tagFunc(thisPtr, assetId, tagName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _untag(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId, [MarshalAs(UnmanagedType.LPWStr)]string tagName);
         private static _untag _untagFunc;
         internal static bool untag(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId, [MarshalAs(UnmanagedType.LPWStr)]string tagName)
         {
         	if (_untagFunc == null)
         	{
         		_untagFunc =
         			(_untag)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetTagsManifest_untag"), typeof(_untag));
         	}
         
         	return  _untagFunc(thisPtr, assetId, tagName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _hasTag(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId, [MarshalAs(UnmanagedType.LPWStr)]string tagName);
         private static _hasTag _hasTagFunc;
         internal static bool hasTag(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId, [MarshalAs(UnmanagedType.LPWStr)]string tagName)
         {
         	if (_hasTagFunc == null)
         	{
         		_hasTagFunc =
         			(_hasTag)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetTagsManifest_hasTag"), typeof(_hasTag));
         	}
         
         	return  _hasTagFunc(thisPtr, assetId, tagName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetTagsManifest_create();
         private static _AssetTagsManifest_create _AssetTagsManifest_createFunc;
         internal static IntPtr AssetTagsManifest_create()
         {
         	if (_AssetTagsManifest_createFunc == null)
         	{
         		_AssetTagsManifest_createFunc =
         			(_AssetTagsManifest_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AssetTagsManifest_create"), typeof(_AssetTagsManifest_create));
         	}
         
         	return  _AssetTagsManifest_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void createTag(string tagName = "")
         {
            InternalUnsafeMethods.createTag(ObjectPtr, tagName);
         }
      
         public virtual bool renameTag(string oldTagName, string newTagName)
         {
            return InternalUnsafeMethods.renameTag(ObjectPtr, oldTagName, newTagName);
         }
      
         public virtual bool deleteTag(string tagName)
         {
            return InternalUnsafeMethods.deleteTag(ObjectPtr, tagName);
         }
      
         public virtual bool isTag(string tagName)
         {
            return InternalUnsafeMethods.isTag(ObjectPtr, tagName);
         }
      
         public virtual int getTagCount()
         {
            return InternalUnsafeMethods.getTagCount(ObjectPtr);
         }
      
         public virtual string getTag(int tagIndex)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getTag(ObjectPtr, tagIndex));
         }
      
         public virtual int getAssetTagCount(string assetId)
         {
            return InternalUnsafeMethods.getAssetTagCount(ObjectPtr, assetId);
         }
      
         public virtual string getAssetTag(string assetId, int tagIndex)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getAssetTag(ObjectPtr, assetId, tagIndex));
         }
      
         public virtual bool tag(string assetId, string tagName)
         {
            return InternalUnsafeMethods.tag(ObjectPtr, assetId, tagName);
         }
      
         public virtual bool untag(string assetId, string tagName)
         {
            return InternalUnsafeMethods.untag(ObjectPtr, assetId, tagName);
         }
      
         public virtual bool hasTag(string assetId, string tagName)
         {
            return InternalUnsafeMethods.hasTag(ObjectPtr, assetId, tagName);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}