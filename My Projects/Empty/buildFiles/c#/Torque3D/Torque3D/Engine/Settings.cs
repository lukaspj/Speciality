using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class Settings : SimObject
	{
		public Settings(bool pRegister = false)
			: base(pRegister)
		{
		}

		public Settings(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public Settings(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public Settings(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public Settings(SimObject pObj) : base(pObj)
		{
		}

		public Settings(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Settings_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _findFirstValue(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pattern, bool deepSearch, bool includeDefaults);
         private static _findFirstValue _findFirstValueFunc;
         internal static IntPtr findFirstValue(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pattern, bool deepSearch, bool includeDefaults)
         {
         	if (_findFirstValueFunc == null)
         	{
         		_findFirstValueFunc =
         			(_findFirstValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSettings_findFirstValue"), typeof(_findFirstValue));
         	}
         
         	return  _findFirstValueFunc(thisPtr, pattern, deepSearch, includeDefaults);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _findNextValue(IntPtr thisPtr);
         private static _findNextValue _findNextValueFunc;
         internal static IntPtr findNextValue(IntPtr thisPtr)
         {
         	if (_findNextValueFunc == null)
         	{
         		_findNextValueFunc =
         			(_findNextValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSettings_findNextValue"), typeof(_findNextValue));
         	}
         
         	return  _findNextValueFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setValue(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string settingName, [MarshalAs(UnmanagedType.LPWStr)]string value);
         private static _setValue _setValueFunc;
         internal static void setValue(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string settingName, [MarshalAs(UnmanagedType.LPWStr)]string value)
         {
         	if (_setValueFunc == null)
         	{
         		_setValueFunc =
         			(_setValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSettings_setValue"), typeof(_setValue));
         	}
         
         	 _setValueFunc(thisPtr, settingName, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setDefaultValue(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string settingName, [MarshalAs(UnmanagedType.LPWStr)]string value);
         private static _setDefaultValue _setDefaultValueFunc;
         internal static void setDefaultValue(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string settingName, [MarshalAs(UnmanagedType.LPWStr)]string value)
         {
         	if (_setDefaultValueFunc == null)
         	{
         		_setDefaultValueFunc =
         			(_setDefaultValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSettings_setDefaultValue"), typeof(_setDefaultValue));
         	}
         
         	 _setDefaultValueFunc(thisPtr, settingName, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _value(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string settingName, [MarshalAs(UnmanagedType.LPWStr)]string defaultValue);
         private static _value _valueFunc;
         internal static IntPtr value(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string settingName, [MarshalAs(UnmanagedType.LPWStr)]string defaultValue)
         {
         	if (_valueFunc == null)
         	{
         		_valueFunc =
         			(_value)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSettings_value"), typeof(_value));
         	}
         
         	return  _valueFunc(thisPtr, settingName, defaultValue);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _remove(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string settingName, bool includeDefaults);
         private static _remove _removeFunc;
         internal static void remove(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string settingName, bool includeDefaults)
         {
         	if (_removeFunc == null)
         	{
         		_removeFunc =
         			(_remove)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSettings_remove"), typeof(_remove));
         	}
         
         	 _removeFunc(thisPtr, settingName, includeDefaults);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _write(IntPtr thisPtr, int argc, string[] argv);
         private static _write _writeFunc;
         internal static bool write(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_writeFunc == null)
         	{
         		_writeFunc =
         			(_write)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSettings_write"), typeof(_write));
         	}
         
         	return  _writeFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _read(IntPtr thisPtr);
         private static _read _readFunc;
         internal static bool read(IntPtr thisPtr)
         {
         	if (_readFunc == null)
         	{
         		_readFunc =
         			(_read)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSettings_read"), typeof(_read));
         	}
         
         	return  _readFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _beginGroup(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string groupName, bool includeDefaults);
         private static _beginGroup _beginGroupFunc;
         internal static void beginGroup(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string groupName, bool includeDefaults)
         {
         	if (_beginGroupFunc == null)
         	{
         		_beginGroupFunc =
         			(_beginGroup)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSettings_beginGroup"), typeof(_beginGroup));
         	}
         
         	 _beginGroupFunc(thisPtr, groupName, includeDefaults);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _endGroup(IntPtr thisPtr);
         private static _endGroup _endGroupFunc;
         internal static void endGroup(IntPtr thisPtr)
         {
         	if (_endGroupFunc == null)
         	{
         		_endGroupFunc =
         			(_endGroup)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSettings_endGroup"), typeof(_endGroup));
         	}
         
         	 _endGroupFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearGroups(IntPtr thisPtr);
         private static _clearGroups _clearGroupsFunc;
         internal static void clearGroups(IntPtr thisPtr)
         {
         	if (_clearGroupsFunc == null)
         	{
         		_clearGroupsFunc =
         			(_clearGroups)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSettings_clearGroups"), typeof(_clearGroups));
         	}
         
         	 _clearGroupsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getCurrentGroups(IntPtr thisPtr);
         private static _getCurrentGroups _getCurrentGroupsFunc;
         internal static IntPtr getCurrentGroups(IntPtr thisPtr)
         {
         	if (_getCurrentGroupsFunc == null)
         	{
         		_getCurrentGroupsFunc =
         			(_getCurrentGroups)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSettings_getCurrentGroups"), typeof(_getCurrentGroups));
         	}
         
         	return  _getCurrentGroupsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Settings_create();
         private static _Settings_create _Settings_createFunc;
         internal static IntPtr Settings_create()
         {
         	if (_Settings_createFunc == null)
         	{
         		_Settings_createFunc =
         			(_Settings_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Settings_create"), typeof(_Settings_create));
         	}
         
         	return  _Settings_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual string findFirstValue(string pattern = "", bool deepSearch = false, bool includeDefaults = false)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.findFirstValue(ObjectPtr, pattern, deepSearch, includeDefaults));
         }
      
         public virtual string findNextValue()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.findNextValue(ObjectPtr));
         }
      
         public virtual void setValue(string settingName, string value = "")
         {
            InternalUnsafeMethods.setValue(ObjectPtr, settingName, value);
         }
      
         public virtual void setDefaultValue(string settingName, string value)
         {
            InternalUnsafeMethods.setDefaultValue(ObjectPtr, settingName, value);
         }
      
         public virtual string value(string settingName, string defaultValue = "")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.value(ObjectPtr, settingName, defaultValue));
         }
      
         public virtual void remove(string settingName, bool includeDefaults = false)
         {
            InternalUnsafeMethods.remove(ObjectPtr, settingName, includeDefaults);
         }
      
         public virtual bool write()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return InternalUnsafeMethods.write(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual bool read()
         {
            return InternalUnsafeMethods.read(ObjectPtr);
         }
      
         public virtual void beginGroup(string groupName, bool includeDefaults = false)
         {
            InternalUnsafeMethods.beginGroup(ObjectPtr, groupName, includeDefaults);
         }
      
         public virtual void endGroup()
         {
            InternalUnsafeMethods.endGroup(ObjectPtr);
         }
      
         public virtual void clearGroups()
         {
            InternalUnsafeMethods.clearGroups(ObjectPtr);
         }
      
         public virtual string getCurrentGroups()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getCurrentGroups(ObjectPtr));
         }
      
      
      #endregion


      #region Properties
      
      
         public string File
         {
         	get { return getFieldValue("File"); }
         	set { setFieldValue("File", value); }
         }
      
      
      #endregion

	}
}