using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SimXMLDocument : SimObject
	{
		public SimXMLDocument(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SimXMLDocument(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SimXMLDocument(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SimXMLDocument(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SimXMLDocument(SimObject pObj) : base(pObj)
		{
		}

		public SimXMLDocument(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SimXMLDocument_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _reset(IntPtr thisPtr);
         private static _reset _resetFunc;
         internal static void reset(IntPtr thisPtr)
         {
         	if (_resetFunc == null)
         	{
         		_resetFunc =
         			(_reset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_reset"), typeof(_reset));
         	}
         
         	 _resetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _loadFile(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fileName);
         private static _loadFile _loadFileFunc;
         internal static bool loadFile(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fileName)
         {
         	if (_loadFileFunc == null)
         	{
         		_loadFileFunc =
         			(_loadFile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_loadFile"), typeof(_loadFile));
         	}
         
         	return  _loadFileFunc(thisPtr, fileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _saveFile(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fileName);
         private static _saveFile _saveFileFunc;
         internal static bool saveFile(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fileName)
         {
         	if (_saveFileFunc == null)
         	{
         		_saveFileFunc =
         			(_saveFile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_saveFile"), typeof(_saveFile));
         	}
         
         	return  _saveFileFunc(thisPtr, fileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _parse(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string xmlString);
         private static _parse _parseFunc;
         internal static void parse(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string xmlString)
         {
         	if (_parseFunc == null)
         	{
         		_parseFunc =
         			(_parse)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_parse"), typeof(_parse));
         	}
         
         	 _parseFunc(thisPtr, xmlString);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clear(IntPtr thisPtr);
         private static _clear _clearFunc;
         internal static void clear(IntPtr thisPtr)
         {
         	if (_clearFunc == null)
         	{
         		_clearFunc =
         			(_clear)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_clear"), typeof(_clear));
         	}
         
         	 _clearFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getErrorDesc(IntPtr thisPtr);
         private static _getErrorDesc _getErrorDescFunc;
         internal static IntPtr getErrorDesc(IntPtr thisPtr)
         {
         	if (_getErrorDescFunc == null)
         	{
         		_getErrorDescFunc =
         			(_getErrorDesc)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_getErrorDesc"), typeof(_getErrorDesc));
         	}
         
         	return  _getErrorDescFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearError(IntPtr thisPtr);
         private static _clearError _clearErrorFunc;
         internal static void clearError(IntPtr thisPtr)
         {
         	if (_clearErrorFunc == null)
         	{
         		_clearErrorFunc =
         			(_clearError)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_clearError"), typeof(_clearError));
         	}
         
         	 _clearErrorFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _pushFirstChildElement(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _pushFirstChildElement _pushFirstChildElementFunc;
         internal static bool pushFirstChildElement(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_pushFirstChildElementFunc == null)
         	{
         		_pushFirstChildElementFunc =
         			(_pushFirstChildElement)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_pushFirstChildElement"), typeof(_pushFirstChildElement));
         	}
         
         	return  _pushFirstChildElementFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _pushChildElement(IntPtr thisPtr, int index);
         private static _pushChildElement _pushChildElementFunc;
         internal static bool pushChildElement(IntPtr thisPtr, int index)
         {
         	if (_pushChildElementFunc == null)
         	{
         		_pushChildElementFunc =
         			(_pushChildElement)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_pushChildElement"), typeof(_pushChildElement));
         	}
         
         	return  _pushChildElementFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _nextSiblingElement(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _nextSiblingElement _nextSiblingElementFunc;
         internal static bool nextSiblingElement(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_nextSiblingElementFunc == null)
         	{
         		_nextSiblingElementFunc =
         			(_nextSiblingElement)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_nextSiblingElement"), typeof(_nextSiblingElement));
         	}
         
         	return  _nextSiblingElementFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _elementValue(IntPtr thisPtr);
         private static _elementValue _elementValueFunc;
         internal static IntPtr elementValue(IntPtr thisPtr)
         {
         	if (_elementValueFunc == null)
         	{
         		_elementValueFunc =
         			(_elementValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_elementValue"), typeof(_elementValue));
         	}
         
         	return  _elementValueFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _popElement(IntPtr thisPtr);
         private static _popElement _popElementFunc;
         internal static void popElement(IntPtr thisPtr)
         {
         	if (_popElementFunc == null)
         	{
         		_popElementFunc =
         			(_popElement)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_popElement"), typeof(_popElement));
         	}
         
         	 _popElementFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _attribute(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string attributeName);
         private static _attribute _attributeFunc;
         internal static IntPtr attribute(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string attributeName)
         {
         	if (_attributeFunc == null)
         	{
         		_attributeFunc =
         			(_attribute)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_attribute"), typeof(_attribute));
         	}
         
         	return  _attributeFunc(thisPtr, attributeName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _attributeF32(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string attributeName);
         private static _attributeF32 _attributeF32Func;
         internal static float attributeF32(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string attributeName)
         {
         	if (_attributeF32Func == null)
         	{
         		_attributeF32Func =
         			(_attributeF32)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_attributeF32"), typeof(_attributeF32));
         	}
         
         	return  _attributeF32Func(thisPtr, attributeName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _attributeS32(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string attributeName);
         private static _attributeS32 _attributeS32Func;
         internal static int attributeS32(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string attributeName)
         {
         	if (_attributeS32Func == null)
         	{
         		_attributeS32Func =
         			(_attributeS32)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_attributeS32"), typeof(_attributeS32));
         	}
         
         	return  _attributeS32Func(thisPtr, attributeName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _attributeExists(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string attributeName);
         private static _attributeExists _attributeExistsFunc;
         internal static bool attributeExists(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string attributeName)
         {
         	if (_attributeExistsFunc == null)
         	{
         		_attributeExistsFunc =
         			(_attributeExists)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_attributeExists"), typeof(_attributeExists));
         	}
         
         	return  _attributeExistsFunc(thisPtr, attributeName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _firstAttribute(IntPtr thisPtr);
         private static _firstAttribute _firstAttributeFunc;
         internal static IntPtr firstAttribute(IntPtr thisPtr)
         {
         	if (_firstAttributeFunc == null)
         	{
         		_firstAttributeFunc =
         			(_firstAttribute)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_firstAttribute"), typeof(_firstAttribute));
         	}
         
         	return  _firstAttributeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _lastAttribute(IntPtr thisPtr);
         private static _lastAttribute _lastAttributeFunc;
         internal static IntPtr lastAttribute(IntPtr thisPtr)
         {
         	if (_lastAttributeFunc == null)
         	{
         		_lastAttributeFunc =
         			(_lastAttribute)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_lastAttribute"), typeof(_lastAttribute));
         	}
         
         	return  _lastAttributeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _nextAttribute(IntPtr thisPtr);
         private static _nextAttribute _nextAttributeFunc;
         internal static IntPtr nextAttribute(IntPtr thisPtr)
         {
         	if (_nextAttributeFunc == null)
         	{
         		_nextAttributeFunc =
         			(_nextAttribute)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_nextAttribute"), typeof(_nextAttribute));
         	}
         
         	return  _nextAttributeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _prevAttribute(IntPtr thisPtr);
         private static _prevAttribute _prevAttributeFunc;
         internal static IntPtr prevAttribute(IntPtr thisPtr)
         {
         	if (_prevAttributeFunc == null)
         	{
         		_prevAttributeFunc =
         			(_prevAttribute)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_prevAttribute"), typeof(_prevAttribute));
         	}
         
         	return  _prevAttributeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setAttribute(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string attributeName, [MarshalAs(UnmanagedType.LPWStr)]string value);
         private static _setAttribute _setAttributeFunc;
         internal static void setAttribute(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string attributeName, [MarshalAs(UnmanagedType.LPWStr)]string value)
         {
         	if (_setAttributeFunc == null)
         	{
         		_setAttributeFunc =
         			(_setAttribute)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_setAttribute"), typeof(_setAttribute));
         	}
         
         	 _setAttributeFunc(thisPtr, attributeName, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setObjectAttributes(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objectID);
         private static _setObjectAttributes _setObjectAttributesFunc;
         internal static void setObjectAttributes(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objectID)
         {
         	if (_setObjectAttributesFunc == null)
         	{
         		_setObjectAttributesFunc =
         			(_setObjectAttributes)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_setObjectAttributes"), typeof(_setObjectAttributes));
         	}
         
         	 _setObjectAttributesFunc(thisPtr, objectID);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _pushNewElement(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _pushNewElement _pushNewElementFunc;
         internal static void pushNewElement(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_pushNewElementFunc == null)
         	{
         		_pushNewElementFunc =
         			(_pushNewElement)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_pushNewElement"), typeof(_pushNewElement));
         	}
         
         	 _pushNewElementFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addNewElement(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _addNewElement _addNewElementFunc;
         internal static void addNewElement(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_addNewElementFunc == null)
         	{
         		_addNewElementFunc =
         			(_addNewElement)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_addNewElement"), typeof(_addNewElement));
         	}
         
         	 _addNewElementFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addHeader(IntPtr thisPtr);
         private static _addHeader _addHeaderFunc;
         internal static void addHeader(IntPtr thisPtr)
         {
         	if (_addHeaderFunc == null)
         	{
         		_addHeaderFunc =
         			(_addHeader)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_addHeader"), typeof(_addHeader));
         	}
         
         	 _addHeaderFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addComment(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string comment);
         private static _addComment _addCommentFunc;
         internal static void addComment(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string comment)
         {
         	if (_addCommentFunc == null)
         	{
         		_addCommentFunc =
         			(_addComment)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_addComment"), typeof(_addComment));
         	}
         
         	 _addCommentFunc(thisPtr, comment);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _readComment(IntPtr thisPtr, int index);
         private static _readComment _readCommentFunc;
         internal static IntPtr readComment(IntPtr thisPtr, int index)
         {
         	if (_readCommentFunc == null)
         	{
         		_readCommentFunc =
         			(_readComment)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_readComment"), typeof(_readComment));
         	}
         
         	return  _readCommentFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addText(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string text);
         private static _addText _addTextFunc;
         internal static void addText(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string text)
         {
         	if (_addTextFunc == null)
         	{
         		_addTextFunc =
         			(_addText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_addText"), typeof(_addText));
         	}
         
         	 _addTextFunc(thisPtr, text);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getText(IntPtr thisPtr);
         private static _getText _getTextFunc;
         internal static IntPtr getText(IntPtr thisPtr)
         {
         	if (_getTextFunc == null)
         	{
         		_getTextFunc =
         			(_getText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_getText"), typeof(_getText));
         	}
         
         	return  _getTextFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeText(IntPtr thisPtr);
         private static _removeText _removeTextFunc;
         internal static void removeText(IntPtr thisPtr)
         {
         	if (_removeTextFunc == null)
         	{
         		_removeTextFunc =
         			(_removeText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_removeText"), typeof(_removeText));
         	}
         
         	 _removeTextFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addData(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string text);
         private static _addData _addDataFunc;
         internal static void addData(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string text)
         {
         	if (_addDataFunc == null)
         	{
         		_addDataFunc =
         			(_addData)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_addData"), typeof(_addData));
         	}
         
         	 _addDataFunc(thisPtr, text);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getData(IntPtr thisPtr);
         private static _getData _getDataFunc;
         internal static IntPtr getData(IntPtr thisPtr)
         {
         	if (_getDataFunc == null)
         	{
         		_getDataFunc =
         			(_getData)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimXMLDocument_getData"), typeof(_getData));
         	}
         
         	return  _getDataFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimXMLDocument_create();
         private static _SimXMLDocument_create _SimXMLDocument_createFunc;
         internal static IntPtr SimXMLDocument_create()
         {
         	if (_SimXMLDocument_createFunc == null)
         	{
         		_SimXMLDocument_createFunc =
         			(_SimXMLDocument_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SimXMLDocument_create"), typeof(_SimXMLDocument_create));
         	}
         
         	return  _SimXMLDocument_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void reset()
         {
            InternalUnsafeMethods.reset(ObjectPtr);
         }
      
         public virtual bool loadFile(string fileName)
         {
            return InternalUnsafeMethods.loadFile(ObjectPtr, fileName);
         }
      
         public virtual bool saveFile(string fileName)
         {
            return InternalUnsafeMethods.saveFile(ObjectPtr, fileName);
         }
      
         public virtual void parse(string xmlString)
         {
            InternalUnsafeMethods.parse(ObjectPtr, xmlString);
         }
      
         public virtual void clear()
         {
            InternalUnsafeMethods.clear(ObjectPtr);
         }
      
         public virtual string getErrorDesc()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getErrorDesc(ObjectPtr));
         }
      
         public virtual void clearError()
         {
            InternalUnsafeMethods.clearError(ObjectPtr);
         }
      
         public virtual bool pushFirstChildElement(string name)
         {
            return InternalUnsafeMethods.pushFirstChildElement(ObjectPtr, name);
         }
      
         public virtual bool pushChildElement(int index)
         {
            return InternalUnsafeMethods.pushChildElement(ObjectPtr, index);
         }
      
         public virtual bool nextSiblingElement(string name)
         {
            return InternalUnsafeMethods.nextSiblingElement(ObjectPtr, name);
         }
      
         public virtual string elementValue()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.elementValue(ObjectPtr));
         }
      
         public virtual void popElement()
         {
            InternalUnsafeMethods.popElement(ObjectPtr);
         }
      
         public virtual string attribute(string attributeName)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.attribute(ObjectPtr, attributeName));
         }
      
         public virtual float attributeF32(string attributeName)
         {
            return InternalUnsafeMethods.attributeF32(ObjectPtr, attributeName);
         }
      
         public virtual int attributeS32(string attributeName)
         {
            return InternalUnsafeMethods.attributeS32(ObjectPtr, attributeName);
         }
      
         public virtual bool attributeExists(string attributeName)
         {
            return InternalUnsafeMethods.attributeExists(ObjectPtr, attributeName);
         }
      
         public virtual string firstAttribute()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.firstAttribute(ObjectPtr));
         }
      
         public virtual string lastAttribute()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.lastAttribute(ObjectPtr));
         }
      
         public virtual string nextAttribute()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.nextAttribute(ObjectPtr));
         }
      
         public virtual string prevAttribute()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.prevAttribute(ObjectPtr));
         }
      
         public virtual void setAttribute(string attributeName, string value)
         {
            InternalUnsafeMethods.setAttribute(ObjectPtr, attributeName, value);
         }
      
         public virtual void setObjectAttributes(string objectID)
         {
            InternalUnsafeMethods.setObjectAttributes(ObjectPtr, objectID);
         }
      
         public virtual void pushNewElement(string name)
         {
            InternalUnsafeMethods.pushNewElement(ObjectPtr, name);
         }
      
         public virtual void addNewElement(string name)
         {
            InternalUnsafeMethods.addNewElement(ObjectPtr, name);
         }
      
         public virtual void addHeader()
         {
            InternalUnsafeMethods.addHeader(ObjectPtr);
         }
      
         public virtual void addComment(string comment)
         {
            InternalUnsafeMethods.addComment(ObjectPtr, comment);
         }
      
         public virtual string readComment(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.readComment(ObjectPtr, index));
         }
      
         public virtual void addText(string text)
         {
            InternalUnsafeMethods.addText(ObjectPtr, text);
         }
      
         public virtual string getText()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getText(ObjectPtr));
         }
      
         public virtual void removeText()
         {
            InternalUnsafeMethods.removeText(ObjectPtr);
         }
      
         public virtual void addData(string text)
         {
            InternalUnsafeMethods.addData(ObjectPtr, text);
         }
      
         public virtual string getData()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getData(ObjectPtr));
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}