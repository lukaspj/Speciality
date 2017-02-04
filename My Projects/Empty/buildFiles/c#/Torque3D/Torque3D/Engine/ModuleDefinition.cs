using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ModuleDefinition : SimSet
	{
		public ModuleDefinition(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ModuleDefinition(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ModuleDefinition(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ModuleDefinition(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ModuleDefinition(SimObject pObj) : base(pObj)
		{
		}

		public ModuleDefinition(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ModuleDefinition_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _save(IntPtr thisPtr);
         private static _save _saveFunc;
         internal static bool save(IntPtr thisPtr)
         {
         	if (_saveFunc == null)
         	{
         		_saveFunc =
         			(_save)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleDefinition_save"), typeof(_save));
         	}
         
         	return  _saveFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getModuleManager(IntPtr thisPtr);
         private static _getModuleManager _getModuleManagerFunc;
         internal static int getModuleManager(IntPtr thisPtr)
         {
         	if (_getModuleManagerFunc == null)
         	{
         		_getModuleManagerFunc =
         			(_getModuleManager)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleDefinition_getModuleManager"), typeof(_getModuleManager));
         	}
         
         	return  _getModuleManagerFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getDependencyCount(IntPtr thisPtr);
         private static _getDependencyCount _getDependencyCountFunc;
         internal static int getDependencyCount(IntPtr thisPtr)
         {
         	if (_getDependencyCountFunc == null)
         	{
         		_getDependencyCountFunc =
         			(_getDependencyCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleDefinition_getDependencyCount"), typeof(_getDependencyCount));
         	}
         
         	return  _getDependencyCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getDependency(IntPtr thisPtr, uint dependencyIndex);
         private static _getDependency _getDependencyFunc;
         internal static IntPtr getDependency(IntPtr thisPtr, uint dependencyIndex)
         {
         	if (_getDependencyFunc == null)
         	{
         		_getDependencyFunc =
         			(_getDependency)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleDefinition_getDependency"), typeof(_getDependency));
         	}
         
         	return  _getDependencyFunc(thisPtr, dependencyIndex);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _addDependency(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pModuleId, uint versionId);
         private static _addDependency _addDependencyFunc;
         internal static bool addDependency(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pModuleId, uint versionId)
         {
         	if (_addDependencyFunc == null)
         	{
         		_addDependencyFunc =
         			(_addDependency)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleDefinition_addDependency"), typeof(_addDependency));
         	}
         
         	return  _addDependencyFunc(thisPtr, pModuleId, versionId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _removeDependency(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pModuleId);
         private static _removeDependency _removeDependencyFunc;
         internal static bool removeDependency(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pModuleId)
         {
         	if (_removeDependencyFunc == null)
         	{
         		_removeDependencyFunc =
         			(_removeDependency)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnModuleDefinition_removeDependency"), typeof(_removeDependency));
         	}
         
         	return  _removeDependencyFunc(thisPtr, pModuleId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleDefinition_create();
         private static _ModuleDefinition_create _ModuleDefinition_createFunc;
         internal static IntPtr ModuleDefinition_create()
         {
         	if (_ModuleDefinition_createFunc == null)
         	{
         		_ModuleDefinition_createFunc =
         			(_ModuleDefinition_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ModuleDefinition_create"), typeof(_ModuleDefinition_create));
         	}
         
         	return  _ModuleDefinition_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool save()
         {
            return InternalUnsafeMethods.save(ObjectPtr);
         }
      
         public virtual int getModuleManager()
         {
            return InternalUnsafeMethods.getModuleManager(ObjectPtr);
         }
      
         public virtual int getDependencyCount()
         {
            return InternalUnsafeMethods.getDependencyCount(ObjectPtr);
         }
      
         public virtual string getDependency(uint dependencyIndex = 0)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getDependency(ObjectPtr, dependencyIndex));
         }
      
         public virtual bool addDependency(string pModuleId = "", uint versionId = 0)
         {
            return InternalUnsafeMethods.addDependency(ObjectPtr, pModuleId, versionId);
         }
      
         public virtual bool removeDependency(string pModuleId = "")
         {
            return InternalUnsafeMethods.removeDependency(ObjectPtr, pModuleId);
         }
      
      
      #endregion


      #region Properties
      
      
         public string ModuleId
         {
         	get { return getFieldValue("ModuleId"); }
         	set { setFieldValue("ModuleId", value); }
         }
      
         public int VersionId
         {
         	get { return int.Parse(getFieldValue("VersionId")); }
         	set { setFieldValue("VersionId", value.ToString()); }
         }
      
         public int BuildId
         {
         	get { return int.Parse(getFieldValue("BuildId")); }
         	set { setFieldValue("BuildId", value.ToString()); }
         }
      
         public bool Enabled
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Enabled")); }
         	set { setFieldValue("Enabled", value ? "1" : "0"); }
         }
      
         public bool Synchronized
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Synchronized")); }
         	set { setFieldValue("Synchronized", value ? "1" : "0"); }
         }
      
         public bool Deprecated
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Deprecated")); }
         	set { setFieldValue("Deprecated", value ? "1" : "0"); }
         }
      
         public bool CriticalMerge
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CriticalMerge")); }
         	set { setFieldValue("CriticalMerge", value ? "1" : "0"); }
         }
      
         public string Description
         {
         	get { return getFieldValue("Description"); }
         	set { setFieldValue("Description", value); }
         }
      
         public string Author
         {
         	get { return getFieldValue("Author"); }
         	set { setFieldValue("Author", value); }
         }
      
         public string Group
         {
         	get { return getFieldValue("Group"); }
         	set { setFieldValue("Group", value); }
         }
      
         public string Type
         {
         	get { return getFieldValue("Type"); }
         	set { setFieldValue("Type", value); }
         }
      
         public string Dependencies
         {
         	get { return getFieldValue("Dependencies"); }
         	set { setFieldValue("Dependencies", value); }
         }
      
         public string ScriptFile
         {
         	get { return getFieldValue("ScriptFile"); }
         	set { setFieldValue("ScriptFile", value); }
         }
      
         public string CreateFunction
         {
         	get { return getFieldValue("CreateFunction"); }
         	set { setFieldValue("CreateFunction", value); }
         }
      
         public string DestroyFunction
         {
         	get { return getFieldValue("DestroyFunction"); }
         	set { setFieldValue("DestroyFunction", value); }
         }
      
         public string AssetTagsManifest
         {
         	get { return getFieldValue("AssetTagsManifest"); }
         	set { setFieldValue("AssetTagsManifest", value); }
         }
      
         public int ScopeSet
         {
         	get { return int.Parse(getFieldValue("ScopeSet")); }
         	set { setFieldValue("ScopeSet", value.ToString()); }
         }
      
         public string ModulePath
         {
         	get { return getFieldValue("ModulePath"); }
         	set { setFieldValue("ModulePath", value); }
         }
      
         public string ModuleFile
         {
         	get { return getFieldValue("ModuleFile"); }
         	set { setFieldValue("ModuleFile", value); }
         }
      
         public string ModuleFilePath
         {
         	get { return getFieldValue("ModuleFilePath"); }
         	set { setFieldValue("ModuleFilePath", value); }
         }
      
         public string ModuleScriptFilePath
         {
         	get { return getFieldValue("ModuleScriptFilePath"); }
         	set { setFieldValue("ModuleScriptFilePath", value); }
         }
      
         public string Signature
         {
         	get { return getFieldValue("Signature"); }
         	set { setFieldValue("Signature", value); }
         }
      
      
      #endregion

	}
}