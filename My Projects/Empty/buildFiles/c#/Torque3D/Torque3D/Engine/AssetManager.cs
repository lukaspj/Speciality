using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class AssetManager : SimObject
	{
		public AssetManager(bool pRegister = false)
			: base(pRegister)
		{
		}

		public AssetManager(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public AssetManager(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public AssetManager(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public AssetManager(SimObject pObj) : base(pObj)
		{
		}

		public AssetManager(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.AssetManager_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _compileReferencedAssets(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string moduleDefinition);
         private static _compileReferencedAssets _compileReferencedAssetsFunc;
         internal static bool compileReferencedAssets(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string moduleDefinition)
         {
         	if (_compileReferencedAssetsFunc == null)
         	{
         		_compileReferencedAssetsFunc =
         			(_compileReferencedAssets)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_compileReferencedAssets"), typeof(_compileReferencedAssets));
         	}
         
         	return  _compileReferencedAssetsFunc(thisPtr, moduleDefinition);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _addModuleDeclaredAssets(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string moduleDefinition);
         private static _addModuleDeclaredAssets _addModuleDeclaredAssetsFunc;
         internal static bool addModuleDeclaredAssets(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string moduleDefinition)
         {
         	if (_addModuleDeclaredAssetsFunc == null)
         	{
         		_addModuleDeclaredAssetsFunc =
         			(_addModuleDeclaredAssets)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_addModuleDeclaredAssets"), typeof(_addModuleDeclaredAssets));
         	}
         
         	return  _addModuleDeclaredAssetsFunc(thisPtr, moduleDefinition);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _addDeclaredAsset(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string moduleDefinition, [MarshalAs(UnmanagedType.LPWStr)]string assetFilePath);
         private static _addDeclaredAsset _addDeclaredAssetFunc;
         internal static bool addDeclaredAsset(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string moduleDefinition, [MarshalAs(UnmanagedType.LPWStr)]string assetFilePath)
         {
         	if (_addDeclaredAssetFunc == null)
         	{
         		_addDeclaredAssetFunc =
         			(_addDeclaredAsset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_addDeclaredAsset"), typeof(_addDeclaredAsset));
         	}
         
         	return  _addDeclaredAssetFunc(thisPtr, moduleDefinition, assetFilePath);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _addPrivateAsset(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetObject);
         private static _addPrivateAsset _addPrivateAssetFunc;
         internal static IntPtr addPrivateAsset(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetObject)
         {
         	if (_addPrivateAssetFunc == null)
         	{
         		_addPrivateAssetFunc =
         			(_addPrivateAsset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_addPrivateAsset"), typeof(_addPrivateAsset));
         	}
         
         	return  _addPrivateAssetFunc(thisPtr, assetObject);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _removeDeclaredAssets(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string moduleDefinition);
         private static _removeDeclaredAssets _removeDeclaredAssetsFunc;
         internal static bool removeDeclaredAssets(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string moduleDefinition)
         {
         	if (_removeDeclaredAssetsFunc == null)
         	{
         		_removeDeclaredAssetsFunc =
         			(_removeDeclaredAssets)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_removeDeclaredAssets"), typeof(_removeDeclaredAssets));
         	}
         
         	return  _removeDeclaredAssetsFunc(thisPtr, moduleDefinition);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _removeDeclaredAsset(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId);
         private static _removeDeclaredAsset _removeDeclaredAssetFunc;
         internal static bool removeDeclaredAsset(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId)
         {
         	if (_removeDeclaredAssetFunc == null)
         	{
         		_removeDeclaredAssetFunc =
         			(_removeDeclaredAsset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_removeDeclaredAsset"), typeof(_removeDeclaredAsset));
         	}
         
         	return  _removeDeclaredAssetFunc(thisPtr, assetId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getAssetName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId);
         private static _getAssetName _getAssetNameFunc;
         internal static IntPtr getAssetName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId)
         {
         	if (_getAssetNameFunc == null)
         	{
         		_getAssetNameFunc =
         			(_getAssetName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_getAssetName"), typeof(_getAssetName));
         	}
         
         	return  _getAssetNameFunc(thisPtr, assetId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getAssetDescription(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId);
         private static _getAssetDescription _getAssetDescriptionFunc;
         internal static IntPtr getAssetDescription(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId)
         {
         	if (_getAssetDescriptionFunc == null)
         	{
         		_getAssetDescriptionFunc =
         			(_getAssetDescription)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_getAssetDescription"), typeof(_getAssetDescription));
         	}
         
         	return  _getAssetDescriptionFunc(thisPtr, assetId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getAssetCategory(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId);
         private static _getAssetCategory _getAssetCategoryFunc;
         internal static IntPtr getAssetCategory(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId)
         {
         	if (_getAssetCategoryFunc == null)
         	{
         		_getAssetCategoryFunc =
         			(_getAssetCategory)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_getAssetCategory"), typeof(_getAssetCategory));
         	}
         
         	return  _getAssetCategoryFunc(thisPtr, assetId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getAssetType(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId);
         private static _getAssetType _getAssetTypeFunc;
         internal static IntPtr getAssetType(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId)
         {
         	if (_getAssetTypeFunc == null)
         	{
         		_getAssetTypeFunc =
         			(_getAssetType)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_getAssetType"), typeof(_getAssetType));
         	}
         
         	return  _getAssetTypeFunc(thisPtr, assetId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getAssetFilePath(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId);
         private static _getAssetFilePath _getAssetFilePathFunc;
         internal static IntPtr getAssetFilePath(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId)
         {
         	if (_getAssetFilePathFunc == null)
         	{
         		_getAssetFilePathFunc =
         			(_getAssetFilePath)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_getAssetFilePath"), typeof(_getAssetFilePath));
         	}
         
         	return  _getAssetFilePathFunc(thisPtr, assetId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getAssetPath(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId);
         private static _getAssetPath _getAssetPathFunc;
         internal static IntPtr getAssetPath(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId)
         {
         	if (_getAssetPathFunc == null)
         	{
         		_getAssetPathFunc =
         			(_getAssetPath)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_getAssetPath"), typeof(_getAssetPath));
         	}
         
         	return  _getAssetPathFunc(thisPtr, assetId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getAssetModule(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId);
         private static _getAssetModule _getAssetModuleFunc;
         internal static IntPtr getAssetModule(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId)
         {
         	if (_getAssetModuleFunc == null)
         	{
         		_getAssetModuleFunc =
         			(_getAssetModule)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_getAssetModule"), typeof(_getAssetModule));
         	}
         
         	return  _getAssetModuleFunc(thisPtr, assetId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isAssetInternal(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId);
         private static _isAssetInternal _isAssetInternalFunc;
         internal static bool isAssetInternal(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId)
         {
         	if (_isAssetInternalFunc == null)
         	{
         		_isAssetInternalFunc =
         			(_isAssetInternal)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_isAssetInternal"), typeof(_isAssetInternal));
         	}
         
         	return  _isAssetInternalFunc(thisPtr, assetId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isAssetPrivate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId);
         private static _isAssetPrivate _isAssetPrivateFunc;
         internal static bool isAssetPrivate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId)
         {
         	if (_isAssetPrivateFunc == null)
         	{
         		_isAssetPrivateFunc =
         			(_isAssetPrivate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_isAssetPrivate"), typeof(_isAssetPrivate));
         	}
         
         	return  _isAssetPrivateFunc(thisPtr, assetId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isAssetAutoUnload(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId);
         private static _isAssetAutoUnload _isAssetAutoUnloadFunc;
         internal static bool isAssetAutoUnload(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId)
         {
         	if (_isAssetAutoUnloadFunc == null)
         	{
         		_isAssetAutoUnloadFunc =
         			(_isAssetAutoUnload)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_isAssetAutoUnload"), typeof(_isAssetAutoUnload));
         	}
         
         	return  _isAssetAutoUnloadFunc(thisPtr, assetId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isAssetLoaded(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId);
         private static _isAssetLoaded _isAssetLoadedFunc;
         internal static bool isAssetLoaded(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId)
         {
         	if (_isAssetLoadedFunc == null)
         	{
         		_isAssetLoadedFunc =
         			(_isAssetLoaded)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_isAssetLoaded"), typeof(_isAssetLoaded));
         	}
         
         	return  _isAssetLoadedFunc(thisPtr, assetId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isDeclaredAsset(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId);
         private static _isDeclaredAsset _isDeclaredAssetFunc;
         internal static bool isDeclaredAsset(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId)
         {
         	if (_isDeclaredAssetFunc == null)
         	{
         		_isDeclaredAssetFunc =
         			(_isDeclaredAsset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_isDeclaredAsset"), typeof(_isDeclaredAsset));
         	}
         
         	return  _isDeclaredAssetFunc(thisPtr, assetId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isReferencedAsset(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId);
         private static _isReferencedAsset _isReferencedAssetFunc;
         internal static bool isReferencedAsset(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId)
         {
         	if (_isReferencedAssetFunc == null)
         	{
         		_isReferencedAssetFunc =
         			(_isReferencedAsset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_isReferencedAsset"), typeof(_isReferencedAsset));
         	}
         
         	return  _isReferencedAssetFunc(thisPtr, assetId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _renameDeclaredAsset(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetIdFrom, [MarshalAs(UnmanagedType.LPWStr)]string assetIdTo);
         private static _renameDeclaredAsset _renameDeclaredAssetFunc;
         internal static bool renameDeclaredAsset(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetIdFrom, [MarshalAs(UnmanagedType.LPWStr)]string assetIdTo)
         {
         	if (_renameDeclaredAssetFunc == null)
         	{
         		_renameDeclaredAssetFunc =
         			(_renameDeclaredAsset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_renameDeclaredAsset"), typeof(_renameDeclaredAsset));
         	}
         
         	return  _renameDeclaredAssetFunc(thisPtr, assetIdFrom, assetIdTo);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _renameReferencedAsset(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetIdFrom, [MarshalAs(UnmanagedType.LPWStr)]string assetIdTo);
         private static _renameReferencedAsset _renameReferencedAssetFunc;
         internal static bool renameReferencedAsset(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetIdFrom, [MarshalAs(UnmanagedType.LPWStr)]string assetIdTo)
         {
         	if (_renameReferencedAssetFunc == null)
         	{
         		_renameReferencedAssetFunc =
         			(_renameReferencedAsset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_renameReferencedAsset"), typeof(_renameReferencedAsset));
         	}
         
         	return  _renameReferencedAssetFunc(thisPtr, assetIdFrom, assetIdTo);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _acquireAsset(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId, bool asPrivate);
         private static _acquireAsset _acquireAssetFunc;
         internal static IntPtr acquireAsset(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId, bool asPrivate)
         {
         	if (_acquireAssetFunc == null)
         	{
         		_acquireAssetFunc =
         			(_acquireAsset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_acquireAsset"), typeof(_acquireAsset));
         	}
         
         	return  _acquireAssetFunc(thisPtr, assetId, asPrivate);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _releaseAsset(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId);
         private static _releaseAsset _releaseAssetFunc;
         internal static bool releaseAsset(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId)
         {
         	if (_releaseAssetFunc == null)
         	{
         		_releaseAssetFunc =
         			(_releaseAsset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_releaseAsset"), typeof(_releaseAsset));
         	}
         
         	return  _releaseAssetFunc(thisPtr, assetId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _purgeAssets(IntPtr thisPtr);
         private static _purgeAssets _purgeAssetsFunc;
         internal static void purgeAssets(IntPtr thisPtr)
         {
         	if (_purgeAssetsFunc == null)
         	{
         		_purgeAssetsFunc =
         			(_purgeAssets)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_purgeAssets"), typeof(_purgeAssets));
         	}
         
         	 _purgeAssetsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _deleteAsset(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId, bool deleteLooseFiles, bool deleteDependencies);
         private static _deleteAsset _deleteAssetFunc;
         internal static bool deleteAsset(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId, bool deleteLooseFiles, bool deleteDependencies)
         {
         	if (_deleteAssetFunc == null)
         	{
         		_deleteAssetFunc =
         			(_deleteAsset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_deleteAsset"), typeof(_deleteAsset));
         	}
         
         	return  _deleteAssetFunc(thisPtr, assetId, deleteLooseFiles, deleteDependencies);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _refreshAsset(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId);
         private static _refreshAsset _refreshAssetFunc;
         internal static void refreshAsset(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetId)
         {
         	if (_refreshAssetFunc == null)
         	{
         		_refreshAssetFunc =
         			(_refreshAsset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_refreshAsset"), typeof(_refreshAsset));
         	}
         
         	 _refreshAssetFunc(thisPtr, assetId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _refreshAllAssets(IntPtr thisPtr, bool includeUnloaded);
         private static _refreshAllAssets _refreshAllAssetsFunc;
         internal static void refreshAllAssets(IntPtr thisPtr, bool includeUnloaded)
         {
         	if (_refreshAllAssetsFunc == null)
         	{
         		_refreshAllAssetsFunc =
         			(_refreshAllAssets)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_refreshAllAssets"), typeof(_refreshAllAssets));
         	}
         
         	 _refreshAllAssetsFunc(thisPtr, includeUnloaded);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _saveAssetTags(IntPtr thisPtr);
         private static _saveAssetTags _saveAssetTagsFunc;
         internal static bool saveAssetTags(IntPtr thisPtr)
         {
         	if (_saveAssetTagsFunc == null)
         	{
         		_saveAssetTagsFunc =
         			(_saveAssetTags)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_saveAssetTags"), typeof(_saveAssetTags));
         	}
         
         	return  _saveAssetTagsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _restoreAssetTags(IntPtr thisPtr);
         private static _restoreAssetTags _restoreAssetTagsFunc;
         internal static bool restoreAssetTags(IntPtr thisPtr)
         {
         	if (_restoreAssetTagsFunc == null)
         	{
         		_restoreAssetTagsFunc =
         			(_restoreAssetTags)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_restoreAssetTags"), typeof(_restoreAssetTags));
         	}
         
         	return  _restoreAssetTagsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getAssetTags(IntPtr thisPtr);
         private static _getAssetTags _getAssetTagsFunc;
         internal static int getAssetTags(IntPtr thisPtr)
         {
         	if (_getAssetTagsFunc == null)
         	{
         		_getAssetTagsFunc =
         			(_getAssetTags)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_getAssetTags"), typeof(_getAssetTags));
         	}
         
         	return  _getAssetTagsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findAllAssets(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery, bool ignoreInternal, bool ignorePrivate);
         private static _findAllAssets _findAllAssetsFunc;
         internal static int findAllAssets(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery, bool ignoreInternal, bool ignorePrivate)
         {
         	if (_findAllAssetsFunc == null)
         	{
         		_findAllAssetsFunc =
         			(_findAllAssets)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_findAllAssets"), typeof(_findAllAssets));
         	}
         
         	return  _findAllAssetsFunc(thisPtr, assetQuery, ignoreInternal, ignorePrivate);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findAssetName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery, [MarshalAs(UnmanagedType.LPWStr)]string assetName, bool partialName);
         private static _findAssetName _findAssetNameFunc;
         internal static int findAssetName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery, [MarshalAs(UnmanagedType.LPWStr)]string assetName, bool partialName)
         {
         	if (_findAssetNameFunc == null)
         	{
         		_findAssetNameFunc =
         			(_findAssetName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_findAssetName"), typeof(_findAssetName));
         	}
         
         	return  _findAssetNameFunc(thisPtr, assetQuery, assetName, partialName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findAssetCategory(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery, [MarshalAs(UnmanagedType.LPWStr)]string assetCategory, bool assetQueryAsSource);
         private static _findAssetCategory _findAssetCategoryFunc;
         internal static int findAssetCategory(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery, [MarshalAs(UnmanagedType.LPWStr)]string assetCategory, bool assetQueryAsSource)
         {
         	if (_findAssetCategoryFunc == null)
         	{
         		_findAssetCategoryFunc =
         			(_findAssetCategory)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_findAssetCategory"), typeof(_findAssetCategory));
         	}
         
         	return  _findAssetCategoryFunc(thisPtr, assetQuery, assetCategory, assetQueryAsSource);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findAssetAutoUnload(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery, bool assetAutoUnload, bool assetQueryAsSource);
         private static _findAssetAutoUnload _findAssetAutoUnloadFunc;
         internal static int findAssetAutoUnload(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery, bool assetAutoUnload, bool assetQueryAsSource)
         {
         	if (_findAssetAutoUnloadFunc == null)
         	{
         		_findAssetAutoUnloadFunc =
         			(_findAssetAutoUnload)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_findAssetAutoUnload"), typeof(_findAssetAutoUnload));
         	}
         
         	return  _findAssetAutoUnloadFunc(thisPtr, assetQuery, assetAutoUnload, assetQueryAsSource);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findAssetInternal(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery, bool assetInternal, bool assetQueryAsSource);
         private static _findAssetInternal _findAssetInternalFunc;
         internal static int findAssetInternal(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery, bool assetInternal, bool assetQueryAsSource)
         {
         	if (_findAssetInternalFunc == null)
         	{
         		_findAssetInternalFunc =
         			(_findAssetInternal)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_findAssetInternal"), typeof(_findAssetInternal));
         	}
         
         	return  _findAssetInternalFunc(thisPtr, assetQuery, assetInternal, assetQueryAsSource);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findAssetPrivate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery, bool assetPrivate, bool assetQueryAsSource);
         private static _findAssetPrivate _findAssetPrivateFunc;
         internal static int findAssetPrivate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery, bool assetPrivate, bool assetQueryAsSource)
         {
         	if (_findAssetPrivateFunc == null)
         	{
         		_findAssetPrivateFunc =
         			(_findAssetPrivate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_findAssetPrivate"), typeof(_findAssetPrivate));
         	}
         
         	return  _findAssetPrivateFunc(thisPtr, assetQuery, assetPrivate, assetQueryAsSource);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findAssetType(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery, [MarshalAs(UnmanagedType.LPWStr)]string assetType, bool assetQueryAsSource);
         private static _findAssetType _findAssetTypeFunc;
         internal static int findAssetType(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery, [MarshalAs(UnmanagedType.LPWStr)]string assetType, bool assetQueryAsSource)
         {
         	if (_findAssetTypeFunc == null)
         	{
         		_findAssetTypeFunc =
         			(_findAssetType)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_findAssetType"), typeof(_findAssetType));
         	}
         
         	return  _findAssetTypeFunc(thisPtr, assetQuery, assetType, assetQueryAsSource);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findAssetDependsOn(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery, [MarshalAs(UnmanagedType.LPWStr)]string assetId);
         private static _findAssetDependsOn _findAssetDependsOnFunc;
         internal static int findAssetDependsOn(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery, [MarshalAs(UnmanagedType.LPWStr)]string assetId)
         {
         	if (_findAssetDependsOnFunc == null)
         	{
         		_findAssetDependsOnFunc =
         			(_findAssetDependsOn)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_findAssetDependsOn"), typeof(_findAssetDependsOn));
         	}
         
         	return  _findAssetDependsOnFunc(thisPtr, assetQuery, assetId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findAssetIsDependedOn(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery, [MarshalAs(UnmanagedType.LPWStr)]string assetId);
         private static _findAssetIsDependedOn _findAssetIsDependedOnFunc;
         internal static int findAssetIsDependedOn(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery, [MarshalAs(UnmanagedType.LPWStr)]string assetId)
         {
         	if (_findAssetIsDependedOnFunc == null)
         	{
         		_findAssetIsDependedOnFunc =
         			(_findAssetIsDependedOn)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_findAssetIsDependedOn"), typeof(_findAssetIsDependedOn));
         	}
         
         	return  _findAssetIsDependedOnFunc(thisPtr, assetQuery, assetId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findInvalidAssetReferences(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery);
         private static _findInvalidAssetReferences _findInvalidAssetReferencesFunc;
         internal static int findInvalidAssetReferences(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery)
         {
         	if (_findInvalidAssetReferencesFunc == null)
         	{
         		_findInvalidAssetReferencesFunc =
         			(_findInvalidAssetReferences)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_findInvalidAssetReferences"), typeof(_findInvalidAssetReferences));
         	}
         
         	return  _findInvalidAssetReferencesFunc(thisPtr, assetQuery);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findTaggedAssets(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery, [MarshalAs(UnmanagedType.LPWStr)]string assetTagNames, bool assetQueryAsSource);
         private static _findTaggedAssets _findTaggedAssetsFunc;
         internal static int findTaggedAssets(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery, [MarshalAs(UnmanagedType.LPWStr)]string assetTagNames, bool assetQueryAsSource)
         {
         	if (_findTaggedAssetsFunc == null)
         	{
         		_findTaggedAssetsFunc =
         			(_findTaggedAssets)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_findTaggedAssets"), typeof(_findTaggedAssets));
         	}
         
         	return  _findTaggedAssetsFunc(thisPtr, assetQuery, assetTagNames, assetQueryAsSource);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findAssetLooseFile(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery, [MarshalAs(UnmanagedType.LPWStr)]string assetLooseFile, bool assetQueryAsSource);
         private static _findAssetLooseFile _findAssetLooseFileFunc;
         internal static int findAssetLooseFile(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string assetQuery, [MarshalAs(UnmanagedType.LPWStr)]string assetLooseFile, bool assetQueryAsSource)
         {
         	if (_findAssetLooseFileFunc == null)
         	{
         		_findAssetLooseFileFunc =
         			(_findAssetLooseFile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_findAssetLooseFile"), typeof(_findAssetLooseFile));
         	}
         
         	return  _findAssetLooseFileFunc(thisPtr, assetQuery, assetLooseFile, assetQueryAsSource);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getDeclaredAssetCount(IntPtr thisPtr);
         private static _getDeclaredAssetCount _getDeclaredAssetCountFunc;
         internal static bool getDeclaredAssetCount(IntPtr thisPtr)
         {
         	if (_getDeclaredAssetCountFunc == null)
         	{
         		_getDeclaredAssetCountFunc =
         			(_getDeclaredAssetCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_getDeclaredAssetCount"), typeof(_getDeclaredAssetCount));
         	}
         
         	return  _getDeclaredAssetCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getReferencedAssetCount(IntPtr thisPtr);
         private static _getReferencedAssetCount _getReferencedAssetCountFunc;
         internal static bool getReferencedAssetCount(IntPtr thisPtr)
         {
         	if (_getReferencedAssetCountFunc == null)
         	{
         		_getReferencedAssetCountFunc =
         			(_getReferencedAssetCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_getReferencedAssetCount"), typeof(_getReferencedAssetCount));
         	}
         
         	return  _getReferencedAssetCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getLoadedInternalAssetCount(IntPtr thisPtr);
         private static _getLoadedInternalAssetCount _getLoadedInternalAssetCountFunc;
         internal static bool getLoadedInternalAssetCount(IntPtr thisPtr)
         {
         	if (_getLoadedInternalAssetCountFunc == null)
         	{
         		_getLoadedInternalAssetCountFunc =
         			(_getLoadedInternalAssetCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_getLoadedInternalAssetCount"), typeof(_getLoadedInternalAssetCount));
         	}
         
         	return  _getLoadedInternalAssetCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getMaxLoadedInternalAssetCount(IntPtr thisPtr);
         private static _getMaxLoadedInternalAssetCount _getMaxLoadedInternalAssetCountFunc;
         internal static bool getMaxLoadedInternalAssetCount(IntPtr thisPtr)
         {
         	if (_getMaxLoadedInternalAssetCountFunc == null)
         	{
         		_getMaxLoadedInternalAssetCountFunc =
         			(_getMaxLoadedInternalAssetCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_getMaxLoadedInternalAssetCount"), typeof(_getMaxLoadedInternalAssetCount));
         	}
         
         	return  _getMaxLoadedInternalAssetCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getLoadedExternalAssetCount(IntPtr thisPtr);
         private static _getLoadedExternalAssetCount _getLoadedExternalAssetCountFunc;
         internal static bool getLoadedExternalAssetCount(IntPtr thisPtr)
         {
         	if (_getLoadedExternalAssetCountFunc == null)
         	{
         		_getLoadedExternalAssetCountFunc =
         			(_getLoadedExternalAssetCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_getLoadedExternalAssetCount"), typeof(_getLoadedExternalAssetCount));
         	}
         
         	return  _getLoadedExternalAssetCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getMaxLoadedExternalAssetCount(IntPtr thisPtr);
         private static _getMaxLoadedExternalAssetCount _getMaxLoadedExternalAssetCountFunc;
         internal static bool getMaxLoadedExternalAssetCount(IntPtr thisPtr)
         {
         	if (_getMaxLoadedExternalAssetCountFunc == null)
         	{
         		_getMaxLoadedExternalAssetCountFunc =
         			(_getMaxLoadedExternalAssetCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_getMaxLoadedExternalAssetCount"), typeof(_getMaxLoadedExternalAssetCount));
         	}
         
         	return  _getMaxLoadedExternalAssetCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dumpDeclaredAssets(IntPtr thisPtr);
         private static _dumpDeclaredAssets _dumpDeclaredAssetsFunc;
         internal static void dumpDeclaredAssets(IntPtr thisPtr)
         {
         	if (_dumpDeclaredAssetsFunc == null)
         	{
         		_dumpDeclaredAssetsFunc =
         			(_dumpDeclaredAssets)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAssetManager_dumpDeclaredAssets"), typeof(_dumpDeclaredAssets));
         	}
         
         	 _dumpDeclaredAssetsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AssetManager_create();
         private static _AssetManager_create _AssetManager_createFunc;
         internal static IntPtr AssetManager_create()
         {
         	if (_AssetManager_createFunc == null)
         	{
         		_AssetManager_createFunc =
         			(_AssetManager_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AssetManager_create"), typeof(_AssetManager_create));
         	}
         
         	return  _AssetManager_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool compileReferencedAssets(string moduleDefinition = "")
         {
            return InternalUnsafeMethods.compileReferencedAssets(ObjectPtr, moduleDefinition);
         }
      
         public virtual bool addModuleDeclaredAssets(string moduleDefinition = "")
         {
            return InternalUnsafeMethods.addModuleDeclaredAssets(ObjectPtr, moduleDefinition);
         }
      
         public virtual bool addDeclaredAsset(string moduleDefinition = "", string assetFilePath = "")
         {
            return InternalUnsafeMethods.addDeclaredAsset(ObjectPtr, moduleDefinition, assetFilePath);
         }
      
         public virtual string addPrivateAsset(string assetObject = "")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.addPrivateAsset(ObjectPtr, assetObject));
         }
      
         public virtual bool removeDeclaredAssets(string moduleDefinition = "")
         {
            return InternalUnsafeMethods.removeDeclaredAssets(ObjectPtr, moduleDefinition);
         }
      
         public virtual bool removeDeclaredAsset(string assetId = "")
         {
            return InternalUnsafeMethods.removeDeclaredAsset(ObjectPtr, assetId);
         }
      
         public virtual string getAssetName(string assetId = "")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getAssetName(ObjectPtr, assetId));
         }
      
         public virtual string getAssetDescription(string assetId = "")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getAssetDescription(ObjectPtr, assetId));
         }
      
         public virtual string getAssetCategory(string assetId = "")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getAssetCategory(ObjectPtr, assetId));
         }
      
         public virtual string getAssetType(string assetId = "")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getAssetType(ObjectPtr, assetId));
         }
      
         public virtual string getAssetFilePath(string assetId = "")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getAssetFilePath(ObjectPtr, assetId));
         }
      
         public virtual string getAssetPath(string assetId = "")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getAssetPath(ObjectPtr, assetId));
         }
      
         public virtual string getAssetModule(string assetId = "")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getAssetModule(ObjectPtr, assetId));
         }
      
         public virtual bool isAssetInternal(string assetId = "")
         {
            return InternalUnsafeMethods.isAssetInternal(ObjectPtr, assetId);
         }
      
         public virtual bool isAssetPrivate(string assetId = "")
         {
            return InternalUnsafeMethods.isAssetPrivate(ObjectPtr, assetId);
         }
      
         public virtual bool isAssetAutoUnload(string assetId = "")
         {
            return InternalUnsafeMethods.isAssetAutoUnload(ObjectPtr, assetId);
         }
      
         public virtual bool isAssetLoaded(string assetId = "")
         {
            return InternalUnsafeMethods.isAssetLoaded(ObjectPtr, assetId);
         }
      
         public virtual bool isDeclaredAsset(string assetId = "")
         {
            return InternalUnsafeMethods.isDeclaredAsset(ObjectPtr, assetId);
         }
      
         public virtual bool isReferencedAsset(string assetId = "")
         {
            return InternalUnsafeMethods.isReferencedAsset(ObjectPtr, assetId);
         }
      
         public virtual bool renameDeclaredAsset(string assetIdFrom = "", string assetIdTo = "")
         {
            return InternalUnsafeMethods.renameDeclaredAsset(ObjectPtr, assetIdFrom, assetIdTo);
         }
      
         public virtual bool renameReferencedAsset(string assetIdFrom = "", string assetIdTo = "")
         {
            return InternalUnsafeMethods.renameReferencedAsset(ObjectPtr, assetIdFrom, assetIdTo);
         }
      
         public virtual string acquireAsset(string assetId = "", bool asPrivate = false)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.acquireAsset(ObjectPtr, assetId, asPrivate));
         }
      
         public virtual bool releaseAsset(string assetId = "")
         {
            return InternalUnsafeMethods.releaseAsset(ObjectPtr, assetId);
         }
      
         public virtual void purgeAssets()
         {
            InternalUnsafeMethods.purgeAssets(ObjectPtr);
         }
      
         public virtual bool deleteAsset(string assetId = "", bool deleteLooseFiles = false, bool deleteDependencies = false)
         {
            return InternalUnsafeMethods.deleteAsset(ObjectPtr, assetId, deleteLooseFiles, deleteDependencies);
         }
      
         public virtual void refreshAsset(string assetId = "")
         {
            InternalUnsafeMethods.refreshAsset(ObjectPtr, assetId);
         }
      
         public virtual void refreshAllAssets(bool includeUnloaded = false)
         {
            InternalUnsafeMethods.refreshAllAssets(ObjectPtr, includeUnloaded);
         }
      
         public virtual bool saveAssetTags()
         {
            return InternalUnsafeMethods.saveAssetTags(ObjectPtr);
         }
      
         public virtual bool restoreAssetTags()
         {
            return InternalUnsafeMethods.restoreAssetTags(ObjectPtr);
         }
      
         public virtual int getAssetTags()
         {
            return InternalUnsafeMethods.getAssetTags(ObjectPtr);
         }
      
         public virtual int findAllAssets(string assetQuery = "", bool ignoreInternal = true, bool ignorePrivate = true)
         {
            return InternalUnsafeMethods.findAllAssets(ObjectPtr, assetQuery, ignoreInternal, ignorePrivate);
         }
      
         public virtual int findAssetName(string assetQuery = "", string assetName = "", bool partialName = false)
         {
            return InternalUnsafeMethods.findAssetName(ObjectPtr, assetQuery, assetName, partialName);
         }
      
         public virtual int findAssetCategory(string assetQuery = "", string assetCategory = "", bool assetQueryAsSource = false)
         {
            return InternalUnsafeMethods.findAssetCategory(ObjectPtr, assetQuery, assetCategory, assetQueryAsSource);
         }
      
         public virtual int findAssetAutoUnload(string assetQuery = "", bool assetAutoUnload = false, bool assetQueryAsSource = false)
         {
            return InternalUnsafeMethods.findAssetAutoUnload(ObjectPtr, assetQuery, assetAutoUnload, assetQueryAsSource);
         }
      
         public virtual int findAssetInternal(string assetQuery = "", bool assetInternal = false, bool assetQueryAsSource = false)
         {
            return InternalUnsafeMethods.findAssetInternal(ObjectPtr, assetQuery, assetInternal, assetQueryAsSource);
         }
      
         public virtual int findAssetPrivate(string assetQuery = "", bool assetPrivate = false, bool assetQueryAsSource = false)
         {
            return InternalUnsafeMethods.findAssetPrivate(ObjectPtr, assetQuery, assetPrivate, assetQueryAsSource);
         }
      
         public virtual int findAssetType(string assetQuery = "", string assetType = "", bool assetQueryAsSource = false)
         {
            return InternalUnsafeMethods.findAssetType(ObjectPtr, assetQuery, assetType, assetQueryAsSource);
         }
      
         public virtual int findAssetDependsOn(string assetQuery = "", string assetId = "")
         {
            return InternalUnsafeMethods.findAssetDependsOn(ObjectPtr, assetQuery, assetId);
         }
      
         public virtual int findAssetIsDependedOn(string assetQuery = "", string assetId = "")
         {
            return InternalUnsafeMethods.findAssetIsDependedOn(ObjectPtr, assetQuery, assetId);
         }
      
         public virtual int findInvalidAssetReferences(string assetQuery = "")
         {
            return InternalUnsafeMethods.findInvalidAssetReferences(ObjectPtr, assetQuery);
         }
      
         public virtual int findTaggedAssets(string assetQuery = "", string assetTagNames = "", bool assetQueryAsSource = false)
         {
            return InternalUnsafeMethods.findTaggedAssets(ObjectPtr, assetQuery, assetTagNames, assetQueryAsSource);
         }
      
         public virtual int findAssetLooseFile(string assetQuery = "", string assetLooseFile = "", bool assetQueryAsSource = false)
         {
            return InternalUnsafeMethods.findAssetLooseFile(ObjectPtr, assetQuery, assetLooseFile, assetQueryAsSource);
         }
      
         public virtual bool getDeclaredAssetCount()
         {
            return InternalUnsafeMethods.getDeclaredAssetCount(ObjectPtr);
         }
      
         public virtual bool getReferencedAssetCount()
         {
            return InternalUnsafeMethods.getReferencedAssetCount(ObjectPtr);
         }
      
         public virtual bool getLoadedInternalAssetCount()
         {
            return InternalUnsafeMethods.getLoadedInternalAssetCount(ObjectPtr);
         }
      
         public virtual bool getMaxLoadedInternalAssetCount()
         {
            return InternalUnsafeMethods.getMaxLoadedInternalAssetCount(ObjectPtr);
         }
      
         public virtual bool getLoadedExternalAssetCount()
         {
            return InternalUnsafeMethods.getLoadedExternalAssetCount(ObjectPtr);
         }
      
         public virtual bool getMaxLoadedExternalAssetCount()
         {
            return InternalUnsafeMethods.getMaxLoadedExternalAssetCount(ObjectPtr);
         }
      
         public virtual void dumpDeclaredAssets()
         {
            InternalUnsafeMethods.dumpDeclaredAssets(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool EchoInfo
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("EchoInfo")); }
         	set { setFieldValue("EchoInfo", value ? "1" : "0"); }
         }
      
         public bool IgnoreAutoUnload
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IgnoreAutoUnload")); }
         	set { setFieldValue("IgnoreAutoUnload", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}