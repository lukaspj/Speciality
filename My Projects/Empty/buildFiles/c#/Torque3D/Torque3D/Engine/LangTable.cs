using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class LangTable : SimObject
	{
		public LangTable(bool pRegister = false)
			: base(pRegister)
		{
		}

		public LangTable(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public LangTable(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public LangTable(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public LangTable(SimObject pObj) : base(pObj)
		{
		}

		public LangTable(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.LangTable_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _addLanguage(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename, [MarshalAs(UnmanagedType.LPWStr)]string languageName);
         private static _addLanguage _addLanguageFunc;
         internal static int addLanguage(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename, [MarshalAs(UnmanagedType.LPWStr)]string languageName)
         {
         	if (_addLanguageFunc == null)
         	{
         		_addLanguageFunc =
         			(_addLanguage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnLangTable_addLanguage"), typeof(_addLanguage));
         	}
         
         	return  _addLanguageFunc(thisPtr, filename, languageName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getString(IntPtr thisPtr, uint id);
         private static _getString _getStringFunc;
         internal static IntPtr getString(IntPtr thisPtr, uint id)
         {
         	if (_getStringFunc == null)
         	{
         		_getStringFunc =
         			(_getString)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnLangTable_getString"), typeof(_getString));
         	}
         
         	return  _getStringFunc(thisPtr, id);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setDefaultLanguage(IntPtr thisPtr, int langId);
         private static _setDefaultLanguage _setDefaultLanguageFunc;
         internal static void setDefaultLanguage(IntPtr thisPtr, int langId)
         {
         	if (_setDefaultLanguageFunc == null)
         	{
         		_setDefaultLanguageFunc =
         			(_setDefaultLanguage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnLangTable_setDefaultLanguage"), typeof(_setDefaultLanguage));
         	}
         
         	 _setDefaultLanguageFunc(thisPtr, langId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setCurrentLanguage(IntPtr thisPtr, int langId);
         private static _setCurrentLanguage _setCurrentLanguageFunc;
         internal static void setCurrentLanguage(IntPtr thisPtr, int langId)
         {
         	if (_setCurrentLanguageFunc == null)
         	{
         		_setCurrentLanguageFunc =
         			(_setCurrentLanguage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnLangTable_setCurrentLanguage"), typeof(_setCurrentLanguage));
         	}
         
         	 _setCurrentLanguageFunc(thisPtr, langId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getCurrentLanguage(IntPtr thisPtr);
         private static _getCurrentLanguage _getCurrentLanguageFunc;
         internal static int getCurrentLanguage(IntPtr thisPtr)
         {
         	if (_getCurrentLanguageFunc == null)
         	{
         		_getCurrentLanguageFunc =
         			(_getCurrentLanguage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnLangTable_getCurrentLanguage"), typeof(_getCurrentLanguage));
         	}
         
         	return  _getCurrentLanguageFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getLangName(IntPtr thisPtr, int langId);
         private static _getLangName _getLangNameFunc;
         internal static IntPtr getLangName(IntPtr thisPtr, int langId)
         {
         	if (_getLangNameFunc == null)
         	{
         		_getLangNameFunc =
         			(_getLangName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnLangTable_getLangName"), typeof(_getLangName));
         	}
         
         	return  _getLangNameFunc(thisPtr, langId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getNumLang(IntPtr thisPtr);
         private static _getNumLang _getNumLangFunc;
         internal static int getNumLang(IntPtr thisPtr)
         {
         	if (_getNumLangFunc == null)
         	{
         		_getNumLangFunc =
         			(_getNumLang)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnLangTable_getNumLang"), typeof(_getNumLang));
         	}
         
         	return  _getNumLangFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _LangTable_create();
         private static _LangTable_create _LangTable_createFunc;
         internal static IntPtr LangTable_create()
         {
         	if (_LangTable_createFunc == null)
         	{
         		_LangTable_createFunc =
         			(_LangTable_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_LangTable_create"), typeof(_LangTable_create));
         	}
         
         	return  _LangTable_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int addLanguage(string filename = "", string languageName = "")
         {
            return InternalUnsafeMethods.addLanguage(ObjectPtr, filename, languageName);
         }
      
         public virtual string getString(uint id)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getString(ObjectPtr, id));
         }
      
         public virtual void setDefaultLanguage(int langId)
         {
            InternalUnsafeMethods.setDefaultLanguage(ObjectPtr, langId);
         }
      
         public virtual void setCurrentLanguage(int langId)
         {
            InternalUnsafeMethods.setCurrentLanguage(ObjectPtr, langId);
         }
      
         public virtual int getCurrentLanguage()
         {
            return InternalUnsafeMethods.getCurrentLanguage(ObjectPtr);
         }
      
         public virtual string getLangName(int langId)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getLangName(ObjectPtr, langId));
         }
      
         public virtual int getNumLang()
         {
            return InternalUnsafeMethods.getNumLang(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}