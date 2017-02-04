using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ModuleManager : SimObject
	{
		public ModuleManager(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ModuleManager(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ModuleManager(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ModuleManager(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ModuleManager(SimObject pObj) : base(pObj)
		{
		}

		public ModuleManager(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ModuleManager_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setModuleExtension(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string moduleExtension);
         private static _setModuleExtension _setModuleExtensionFunc;
         internal static bool setModuleExtension(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string moduleExtension)
         {
         	if (_setModuleExtensionFunc == null)
         	{
         		_setModuleExtensionFunc =
         			(_setModuleExtension)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleManager_setModuleExtension"), typeof(_setModuleExtension));
         	}
         
         	return  _setModuleExtensionFunc(thisPtr, moduleExtension);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _scanModules(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pRootPath, bool rootOnly);
         private static _scanModules _scanModulesFunc;
         internal static bool scanModules(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pRootPath, bool rootOnly)
         {
         	if (_scanModulesFunc == null)
         	{
         		_scanModulesFunc =
         			(_scanModules)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleManager_scanModules"), typeof(_scanModules));
         	}
         
         	return  _scanModulesFunc(thisPtr, pRootPath, rootOnly);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _unregisterModule(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pModuleId, bool versionId);
         private static _unregisterModule _unregisterModuleFunc;
         internal static bool unregisterModule(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pModuleId, bool versionId)
         {
         	if (_unregisterModuleFunc == null)
         	{
         		_unregisterModuleFunc =
         			(_unregisterModule)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleManager_unregisterModule"), typeof(_unregisterModule));
         	}
         
         	return  _unregisterModuleFunc(thisPtr, pModuleId, versionId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _loadGroup(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pModuleGroup);
         private static _loadGroup _loadGroupFunc;
         internal static bool loadGroup(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pModuleGroup)
         {
         	if (_loadGroupFunc == null)
         	{
         		_loadGroupFunc =
         			(_loadGroup)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleManager_loadGroup"), typeof(_loadGroup));
         	}
         
         	return  _loadGroupFunc(thisPtr, pModuleGroup);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _unloadGroup(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pModuleGroup);
         private static _unloadGroup _unloadGroupFunc;
         internal static bool unloadGroup(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pModuleGroup)
         {
         	if (_unloadGroupFunc == null)
         	{
         		_unloadGroupFunc =
         			(_unloadGroup)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleManager_unloadGroup"), typeof(_unloadGroup));
         	}
         
         	return  _unloadGroupFunc(thisPtr, pModuleGroup);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _loadExplicit(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pModuleId, int pVersionId);
         private static _loadExplicit _loadExplicitFunc;
         internal static bool loadExplicit(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pModuleId, int pVersionId)
         {
         	if (_loadExplicitFunc == null)
         	{
         		_loadExplicitFunc =
         			(_loadExplicit)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleManager_loadExplicit"), typeof(_loadExplicit));
         	}
         
         	return  _loadExplicitFunc(thisPtr, pModuleId, pVersionId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _unloadExplicit(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pModuleId);
         private static _unloadExplicit _unloadExplicitFunc;
         internal static bool unloadExplicit(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pModuleId)
         {
         	if (_unloadExplicitFunc == null)
         	{
         		_unloadExplicitFunc =
         			(_unloadExplicit)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleManager_unloadExplicit"), typeof(_unloadExplicit));
         	}
         
         	return  _unloadExplicitFunc(thisPtr, pModuleId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _findModule(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pModuleId, uint pVersionId);
         private static _findModule _findModuleFunc;
         internal static IntPtr findModule(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pModuleId, uint pVersionId)
         {
         	if (_findModuleFunc == null)
         	{
         		_findModuleFunc =
         			(_findModule)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleManager_findModule"), typeof(_findModule));
         	}
         
         	return  _findModuleFunc(thisPtr, pModuleId, pVersionId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _findModules(IntPtr thisPtr, bool loadedOnly);
         private static _findModules _findModulesFunc;
         internal static IntPtr findModules(IntPtr thisPtr, bool loadedOnly)
         {
         	if (_findModulesFunc == null)
         	{
         		_findModulesFunc =
         			(_findModules)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleManager_findModules"), typeof(_findModules));
         	}
         
         	return  _findModulesFunc(thisPtr, loadedOnly);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _findModuleTypes(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pModuleType, bool loadedOnly);
         private static _findModuleTypes _findModuleTypesFunc;
         internal static IntPtr findModuleTypes(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pModuleType, bool loadedOnly)
         {
         	if (_findModuleTypesFunc == null)
         	{
         		_findModuleTypesFunc =
         			(_findModuleTypes)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleManager_findModuleTypes"), typeof(_findModuleTypes));
         	}
         
         	return  _findModuleTypesFunc(thisPtr, pModuleType, loadedOnly);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _copyModule(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string sourceModuleDefinition, [MarshalAs(UnmanagedType.LPWStr)]string pTargetModuleId, [MarshalAs(UnmanagedType.LPWStr)]string pTargetPath, bool useVersionPathing);
         private static _copyModule _copyModuleFunc;
         internal static IntPtr copyModule(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string sourceModuleDefinition, [MarshalAs(UnmanagedType.LPWStr)]string pTargetModuleId, [MarshalAs(UnmanagedType.LPWStr)]string pTargetPath, bool useVersionPathing)
         {
         	if (_copyModuleFunc == null)
         	{
         		_copyModuleFunc =
         			(_copyModule)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleManager_copyModule"), typeof(_copyModule));
         	}
         
         	return  _copyModuleFunc(thisPtr, sourceModuleDefinition, pTargetModuleId, pTargetPath, useVersionPathing);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _synchronizeDependencies(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string rootModuleDefinition, [MarshalAs(UnmanagedType.LPWStr)]string pTargetDependencyFolder);
         private static _synchronizeDependencies _synchronizeDependenciesFunc;
         internal static bool synchronizeDependencies(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string rootModuleDefinition, [MarshalAs(UnmanagedType.LPWStr)]string pTargetDependencyFolder)
         {
         	if (_synchronizeDependenciesFunc == null)
         	{
         		_synchronizeDependenciesFunc =
         			(_synchronizeDependencies)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleManager_synchronizeDependencies"), typeof(_synchronizeDependencies));
         	}
         
         	return  _synchronizeDependenciesFunc(thisPtr, rootModuleDefinition, pTargetDependencyFolder);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isModuleMergeAvailable(IntPtr thisPtr);
         private static _isModuleMergeAvailable _isModuleMergeAvailableFunc;
         internal static bool isModuleMergeAvailable(IntPtr thisPtr)
         {
         	if (_isModuleMergeAvailableFunc == null)
         	{
         		_isModuleMergeAvailableFunc =
         			(_isModuleMergeAvailable)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleManager_isModuleMergeAvailable"), typeof(_isModuleMergeAvailable));
         	}
         
         	return  _isModuleMergeAvailableFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _canMergeModules(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string mergeSourcePath);
         private static _canMergeModules _canMergeModulesFunc;
         internal static bool canMergeModules(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string mergeSourcePath)
         {
         	if (_canMergeModulesFunc == null)
         	{
         		_canMergeModulesFunc =
         			(_canMergeModules)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleManager_canMergeModules"), typeof(_canMergeModules));
         	}
         
         	return  _canMergeModulesFunc(thisPtr, mergeSourcePath);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _mergeModules(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pMergeTargetPath, bool removeMergeDefinition, bool registerNewModules);
         private static _mergeModules _mergeModulesFunc;
         internal static bool mergeModules(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pMergeTargetPath, bool removeMergeDefinition, bool registerNewModules)
         {
         	if (_mergeModulesFunc == null)
         	{
         		_mergeModulesFunc =
         			(_mergeModules)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleManager_mergeModules"), typeof(_mergeModules));
         	}
         
         	return  _mergeModulesFunc(thisPtr, pMergeTargetPath, removeMergeDefinition, registerNewModules);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addListener(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string listenerObject);
         private static _addListener _addListenerFunc;
         internal static void addListener(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string listenerObject)
         {
         	if (_addListenerFunc == null)
         	{
         		_addListenerFunc =
         			(_addListener)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleManager_addListener"), typeof(_addListener));
         	}
         
         	 _addListenerFunc(thisPtr, listenerObject);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeListener(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string listenerObject);
         private static _removeListener _removeListenerFunc;
         internal static void removeListener(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string listenerObject)
         {
         	if (_removeListenerFunc == null)
         	{
         		_removeListenerFunc =
         			(_removeListener)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleManager_removeListener"), typeof(_removeListener));
         	}
         
         	 _removeListenerFunc(thisPtr, listenerObject);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleManager_create();
         private static _ModuleManager_create _ModuleManager_createFunc;
         internal static IntPtr ModuleManager_create()
         {
         	if (_ModuleManager_createFunc == null)
         	{
         		_ModuleManager_createFunc =
         			(_ModuleManager_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ModuleManager_create"), typeof(_ModuleManager_create));
         	}
         
         	return  _ModuleManager_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool setModuleExtension(string moduleExtension = "")
         {
            return InternalUnsafeMethods.setModuleExtension(ObjectPtr, moduleExtension);
         }
      
         public virtual bool scanModules(string pRootPath = "", bool rootOnly = false)
         {
            return InternalUnsafeMethods.scanModules(ObjectPtr, pRootPath, rootOnly);
         }
      
         public virtual bool unregisterModule(string pModuleId = "", bool versionId = false)
         {
            return InternalUnsafeMethods.unregisterModule(ObjectPtr, pModuleId, versionId);
         }
      
         public virtual bool loadGroup(string pModuleGroup = "")
         {
            return InternalUnsafeMethods.loadGroup(ObjectPtr, pModuleGroup);
         }
      
         public virtual bool unloadGroup(string pModuleGroup = "")
         {
            return InternalUnsafeMethods.unloadGroup(ObjectPtr, pModuleGroup);
         }
      
         public virtual bool loadExplicit(string pModuleId = "", int pVersionId = -1)
         {
            return InternalUnsafeMethods.loadExplicit(ObjectPtr, pModuleId, pVersionId);
         }
      
         public virtual bool unloadExplicit(string pModuleId = "")
         {
            return InternalUnsafeMethods.unloadExplicit(ObjectPtr, pModuleId);
         }
      
         public virtual string findModule(string pModuleId = "", uint pVersionId = 0)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.findModule(ObjectPtr, pModuleId, pVersionId));
         }
      
         public virtual string findModules(bool loadedOnly = false)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.findModules(ObjectPtr, loadedOnly));
         }
      
         public virtual string findModuleTypes(string pModuleType = "", bool loadedOnly = false)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.findModuleTypes(ObjectPtr, pModuleType, loadedOnly));
         }
      
         public virtual string copyModule(string sourceModuleDefinition = "", string pTargetModuleId = "", string pTargetPath = "", bool useVersionPathing = false)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.copyModule(ObjectPtr, sourceModuleDefinition, pTargetModuleId, pTargetPath, useVersionPathing));
         }
      
         public virtual bool synchronizeDependencies(string rootModuleDefinition = "", string pTargetDependencyFolder = "")
         {
            return InternalUnsafeMethods.synchronizeDependencies(ObjectPtr, rootModuleDefinition, pTargetDependencyFolder);
         }
      
         public virtual bool isModuleMergeAvailable()
         {
            return InternalUnsafeMethods.isModuleMergeAvailable(ObjectPtr);
         }
      
         public virtual bool canMergeModules(string mergeSourcePath = "")
         {
            return InternalUnsafeMethods.canMergeModules(ObjectPtr, mergeSourcePath);
         }
      
         public virtual bool mergeModules(string pMergeTargetPath = "", bool removeMergeDefinition = false, bool registerNewModules = false)
         {
            return InternalUnsafeMethods.mergeModules(ObjectPtr, pMergeTargetPath, removeMergeDefinition, registerNewModules);
         }
      
         public virtual void addListener(string listenerObject = "")
         {
            InternalUnsafeMethods.addListener(ObjectPtr, listenerObject);
         }
      
         public virtual void removeListener(string listenerObject = "")
         {
            InternalUnsafeMethods.removeListener(ObjectPtr, listenerObject);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool EnforceDependencies
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("EnforceDependencies")); }
         	set { setFieldValue("EnforceDependencies", value ? "1" : "0"); }
         }
      
         public bool EchoInfo
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("EchoInfo")); }
         	set { setFieldValue("EchoInfo", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}