using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class Taml : SimObject
	{
		public Taml(bool pRegister = false)
			: base(pRegister)
		{
		}

		public Taml(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public Taml(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public Taml(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public Taml(SimObject pObj) : base(pObj)
		{
		}

		public Taml(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Taml_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setFormat(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string formatName);
         private static _setFormat _setFormatFunc;
         internal static void setFormat(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string formatName)
         {
         	if (_setFormatFunc == null)
         	{
         		_setFormatFunc =
         			(_setFormat)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTaml_setFormat"), typeof(_setFormat));
         	}
         
         	 _setFormatFunc(thisPtr, formatName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getFormat(IntPtr thisPtr);
         private static _getFormat _getFormatFunc;
         internal static IntPtr getFormat(IntPtr thisPtr)
         {
         	if (_getFormatFunc == null)
         	{
         		_getFormatFunc =
         			(_getFormat)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTaml_getFormat"), typeof(_getFormat));
         	}
         
         	return  _getFormatFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setAutoFormat(IntPtr thisPtr, bool autoFormat);
         private static _setAutoFormat _setAutoFormatFunc;
         internal static void setAutoFormat(IntPtr thisPtr, bool autoFormat)
         {
         	if (_setAutoFormatFunc == null)
         	{
         		_setAutoFormatFunc =
         			(_setAutoFormat)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTaml_setAutoFormat"), typeof(_setAutoFormat));
         	}
         
         	 _setAutoFormatFunc(thisPtr, autoFormat);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getAutoFormat(IntPtr thisPtr);
         private static _getAutoFormat _getAutoFormatFunc;
         internal static bool getAutoFormat(IntPtr thisPtr)
         {
         	if (_getAutoFormatFunc == null)
         	{
         		_getAutoFormatFunc =
         			(_getAutoFormat)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTaml_getAutoFormat"), typeof(_getAutoFormat));
         	}
         
         	return  _getAutoFormatFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setWriteDefaults(IntPtr thisPtr, bool writeDefaults);
         private static _setWriteDefaults _setWriteDefaultsFunc;
         internal static void setWriteDefaults(IntPtr thisPtr, bool writeDefaults)
         {
         	if (_setWriteDefaultsFunc == null)
         	{
         		_setWriteDefaultsFunc =
         			(_setWriteDefaults)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTaml_setWriteDefaults"), typeof(_setWriteDefaults));
         	}
         
         	 _setWriteDefaultsFunc(thisPtr, writeDefaults);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getWriteDefaults(IntPtr thisPtr);
         private static _getWriteDefaults _getWriteDefaultsFunc;
         internal static bool getWriteDefaults(IntPtr thisPtr)
         {
         	if (_getWriteDefaultsFunc == null)
         	{
         		_getWriteDefaultsFunc =
         			(_getWriteDefaults)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTaml_getWriteDefaults"), typeof(_getWriteDefaults));
         	}
         
         	return  _getWriteDefaultsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setProgenitorUpdate(IntPtr thisPtr, bool progenitorUpdate);
         private static _setProgenitorUpdate _setProgenitorUpdateFunc;
         internal static void setProgenitorUpdate(IntPtr thisPtr, bool progenitorUpdate)
         {
         	if (_setProgenitorUpdateFunc == null)
         	{
         		_setProgenitorUpdateFunc =
         			(_setProgenitorUpdate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTaml_setProgenitorUpdate"), typeof(_setProgenitorUpdate));
         	}
         
         	 _setProgenitorUpdateFunc(thisPtr, progenitorUpdate);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getProgenitorUpdate(IntPtr thisPtr);
         private static _getProgenitorUpdate _getProgenitorUpdateFunc;
         internal static bool getProgenitorUpdate(IntPtr thisPtr)
         {
         	if (_getProgenitorUpdateFunc == null)
         	{
         		_getProgenitorUpdateFunc =
         			(_getProgenitorUpdate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTaml_getProgenitorUpdate"), typeof(_getProgenitorUpdate));
         	}
         
         	return  _getProgenitorUpdateFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setAutoFormatXmlExtension(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string extension);
         private static _setAutoFormatXmlExtension _setAutoFormatXmlExtensionFunc;
         internal static void setAutoFormatXmlExtension(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string extension)
         {
         	if (_setAutoFormatXmlExtensionFunc == null)
         	{
         		_setAutoFormatXmlExtensionFunc =
         			(_setAutoFormatXmlExtension)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTaml_setAutoFormatXmlExtension"), typeof(_setAutoFormatXmlExtension));
         	}
         
         	 _setAutoFormatXmlExtensionFunc(thisPtr, extension);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getAutoFormatXmlExtension(IntPtr thisPtr);
         private static _getAutoFormatXmlExtension _getAutoFormatXmlExtensionFunc;
         internal static IntPtr getAutoFormatXmlExtension(IntPtr thisPtr)
         {
         	if (_getAutoFormatXmlExtensionFunc == null)
         	{
         		_getAutoFormatXmlExtensionFunc =
         			(_getAutoFormatXmlExtension)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTaml_getAutoFormatXmlExtension"), typeof(_getAutoFormatXmlExtension));
         	}
         
         	return  _getAutoFormatXmlExtensionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setAutoFormatBinaryExtension(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string extension);
         private static _setAutoFormatBinaryExtension _setAutoFormatBinaryExtensionFunc;
         internal static void setAutoFormatBinaryExtension(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string extension)
         {
         	if (_setAutoFormatBinaryExtensionFunc == null)
         	{
         		_setAutoFormatBinaryExtensionFunc =
         			(_setAutoFormatBinaryExtension)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTaml_setAutoFormatBinaryExtension"), typeof(_setAutoFormatBinaryExtension));
         	}
         
         	 _setAutoFormatBinaryExtensionFunc(thisPtr, extension);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getAutoFormatBinaryExtension(IntPtr thisPtr);
         private static _getAutoFormatBinaryExtension _getAutoFormatBinaryExtensionFunc;
         internal static IntPtr getAutoFormatBinaryExtension(IntPtr thisPtr)
         {
         	if (_getAutoFormatBinaryExtensionFunc == null)
         	{
         		_getAutoFormatBinaryExtensionFunc =
         			(_getAutoFormatBinaryExtension)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTaml_getAutoFormatBinaryExtension"), typeof(_getAutoFormatBinaryExtension));
         	}
         
         	return  _getAutoFormatBinaryExtensionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setBinaryCompression(IntPtr thisPtr, bool compressed);
         private static _setBinaryCompression _setBinaryCompressionFunc;
         internal static void setBinaryCompression(IntPtr thisPtr, bool compressed)
         {
         	if (_setBinaryCompressionFunc == null)
         	{
         		_setBinaryCompressionFunc =
         			(_setBinaryCompression)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTaml_setBinaryCompression"), typeof(_setBinaryCompression));
         	}
         
         	 _setBinaryCompressionFunc(thisPtr, compressed);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getBinaryCompression(IntPtr thisPtr);
         private static _getBinaryCompression _getBinaryCompressionFunc;
         internal static bool getBinaryCompression(IntPtr thisPtr)
         {
         	if (_getBinaryCompressionFunc == null)
         	{
         		_getBinaryCompressionFunc =
         			(_getBinaryCompression)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTaml_getBinaryCompression"), typeof(_getBinaryCompression));
         	}
         
         	return  _getBinaryCompressionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setJSONStrict(IntPtr thisPtr, bool strict);
         private static _setJSONStrict _setJSONStrictFunc;
         internal static void setJSONStrict(IntPtr thisPtr, bool strict)
         {
         	if (_setJSONStrictFunc == null)
         	{
         		_setJSONStrictFunc =
         			(_setJSONStrict)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTaml_setJSONStrict"), typeof(_setJSONStrict));
         	}
         
         	 _setJSONStrictFunc(thisPtr, strict);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getJSONStrict(IntPtr thisPtr);
         private static _getJSONStrict _getJSONStrictFunc;
         internal static bool getJSONStrict(IntPtr thisPtr)
         {
         	if (_getJSONStrictFunc == null)
         	{
         		_getJSONStrictFunc =
         			(_getJSONStrict)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTaml_getJSONStrict"), typeof(_getJSONStrict));
         	}
         
         	return  _getJSONStrictFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _write(IntPtr thisPtr, IntPtr obj, [MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _write _writeFunc;
         internal static bool write(IntPtr thisPtr, IntPtr obj, [MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_writeFunc == null)
         	{
         		_writeFunc =
         			(_write)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTaml_write"), typeof(_write));
         	}
         
         	return  _writeFunc(thisPtr, obj, filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _read(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _read _readFunc;
         internal static IntPtr read(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_readFunc == null)
         	{
         		_readFunc =
         			(_read)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTaml_read"), typeof(_read));
         	}
         
         	return  _readFunc(thisPtr, filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Taml_create();
         private static _Taml_create _Taml_createFunc;
         internal static IntPtr Taml_create()
         {
         	if (_Taml_createFunc == null)
         	{
         		_Taml_createFunc =
         			(_Taml_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Taml_create"), typeof(_Taml_create));
         	}
         
         	return  _Taml_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setFormat(string formatName)
         {
            InternalUnsafeMethods.setFormat(ObjectPtr, formatName);
         }
      
         public virtual string getFormat()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getFormat(ObjectPtr));
         }
      
         public virtual void setAutoFormat(bool autoFormat)
         {
            InternalUnsafeMethods.setAutoFormat(ObjectPtr, autoFormat);
         }
      
         public virtual bool getAutoFormat()
         {
            return InternalUnsafeMethods.getAutoFormat(ObjectPtr);
         }
      
         public virtual void setWriteDefaults(bool writeDefaults)
         {
            InternalUnsafeMethods.setWriteDefaults(ObjectPtr, writeDefaults);
         }
      
         public virtual bool getWriteDefaults()
         {
            return InternalUnsafeMethods.getWriteDefaults(ObjectPtr);
         }
      
         public virtual void setProgenitorUpdate(bool progenitorUpdate)
         {
            InternalUnsafeMethods.setProgenitorUpdate(ObjectPtr, progenitorUpdate);
         }
      
         public virtual bool getProgenitorUpdate()
         {
            return InternalUnsafeMethods.getProgenitorUpdate(ObjectPtr);
         }
      
         public virtual void setAutoFormatXmlExtension(string extension)
         {
            InternalUnsafeMethods.setAutoFormatXmlExtension(ObjectPtr, extension);
         }
      
         public virtual string getAutoFormatXmlExtension()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getAutoFormatXmlExtension(ObjectPtr));
         }
      
         public virtual void setAutoFormatBinaryExtension(string extension)
         {
            InternalUnsafeMethods.setAutoFormatBinaryExtension(ObjectPtr, extension);
         }
      
         public virtual string getAutoFormatBinaryExtension()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getAutoFormatBinaryExtension(ObjectPtr));
         }
      
         public virtual void setBinaryCompression(bool compressed)
         {
            InternalUnsafeMethods.setBinaryCompression(ObjectPtr, compressed);
         }
      
         public virtual bool getBinaryCompression()
         {
            return InternalUnsafeMethods.getBinaryCompression(ObjectPtr);
         }
      
         public virtual void setJSONStrict(bool strict)
         {
            InternalUnsafeMethods.setJSONStrict(ObjectPtr, strict);
         }
      
         public virtual bool getJSONStrict()
         {
            return InternalUnsafeMethods.getJSONStrict(ObjectPtr);
         }
      
         public virtual bool write(SimObject obj, string filename)
         {
            return InternalUnsafeMethods.write(ObjectPtr, obj.ObjectPtr, filename);
         }
      
         public virtual SimObject read(string filename)
         {
            return new SimObject(InternalUnsafeMethods.read(ObjectPtr, filename));
         }
      
      
      #endregion


      #region Properties
      
      
         public _TamlFormatMode Format
         {
         	get { return (_TamlFormatMode)Enum.Parse(typeof(_TamlFormatMode), getFieldValue("Format"), true); }
         	set { setFieldValue("Format", value.ToString()); }
         }
      
         public bool JSONStrict
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("JSONStrict")); }
         	set { setFieldValue("JSONStrict", value ? "1" : "0"); }
         }
      
         public bool BinaryCompression
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("BinaryCompression")); }
         	set { setFieldValue("BinaryCompression", value ? "1" : "0"); }
         }
      
         public bool WriteDefaults
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("WriteDefaults")); }
         	set { setFieldValue("WriteDefaults", value ? "1" : "0"); }
         }
      
         public bool ProgenitorUpdate
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ProgenitorUpdate")); }
         	set { setFieldValue("ProgenitorUpdate", value ? "1" : "0"); }
         }
      
         public bool AutoFormat
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AutoFormat")); }
         	set { setFieldValue("AutoFormat", value ? "1" : "0"); }
         }
      
         public string AutoFormatXmlExtension
         {
         	get { return getFieldValue("AutoFormatXmlExtension"); }
         	set { setFieldValue("AutoFormatXmlExtension", value); }
         }
      
         public string AutoFormatBinaryExtension
         {
         	get { return getFieldValue("AutoFormatBinaryExtension"); }
         	set { setFieldValue("AutoFormatBinaryExtension", value); }
         }
      
         public string AutoFormatJSONExtension
         {
         	get { return getFieldValue("AutoFormatJSONExtension"); }
         	set { setFieldValue("AutoFormatJSONExtension", value); }
         }
      
      
      #endregion

	}
}