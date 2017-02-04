using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspector : GuiStackControl
	{
		public GuiInspector(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspector(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspector(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspector(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspector(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspector(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspector_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _inspect(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string simObject);
         private static _inspect _inspectFunc;
         internal static void inspect(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string simObject)
         {
         	if (_inspectFunc == null)
         	{
         		_inspectFunc =
         			(_inspect)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiInspector_inspect"), typeof(_inspect));
         	}
         
         	 _inspectFunc(thisPtr, simObject);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addInspect(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string simObject, bool autoSync);
         private static _addInspect _addInspectFunc;
         internal static void addInspect(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string simObject, bool autoSync)
         {
         	if (_addInspectFunc == null)
         	{
         		_addInspectFunc =
         			(_addInspect)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiInspector_addInspect"), typeof(_addInspect));
         	}
         
         	 _addInspectFunc(thisPtr, simObject, autoSync);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeInspect(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string simObject);
         private static _removeInspect _removeInspectFunc;
         internal static void removeInspect(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string simObject)
         {
         	if (_removeInspectFunc == null)
         	{
         		_removeInspectFunc =
         			(_removeInspect)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiInspector_removeInspect"), typeof(_removeInspect));
         	}
         
         	 _removeInspectFunc(thisPtr, simObject);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _refresh(IntPtr thisPtr);
         private static _refresh _refreshFunc;
         internal static void refresh(IntPtr thisPtr)
         {
         	if (_refreshFunc == null)
         	{
         		_refreshFunc =
         			(_refresh)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiInspector_refresh"), typeof(_refresh));
         	}
         
         	 _refreshFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getInspectObject(IntPtr thisPtr, int index);
         private static _getInspectObject _getInspectObjectFunc;
         internal static IntPtr getInspectObject(IntPtr thisPtr, int index)
         {
         	if (_getInspectObjectFunc == null)
         	{
         		_getInspectObjectFunc =
         			(_getInspectObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiInspector_getInspectObject"), typeof(_getInspectObject));
         	}
         
         	return  _getInspectObjectFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getNumInspectObjects(IntPtr thisPtr);
         private static _getNumInspectObjects _getNumInspectObjectsFunc;
         internal static int getNumInspectObjects(IntPtr thisPtr)
         {
         	if (_getNumInspectObjectsFunc == null)
         	{
         		_getNumInspectObjectsFunc =
         			(_getNumInspectObjects)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiInspector_getNumInspectObjects"), typeof(_getNumInspectObjects));
         	}
         
         	return  _getNumInspectObjectsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newObjectName);
         private static _setName _setNameFunc;
         internal static void setName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newObjectName)
         {
         	if (_setNameFunc == null)
         	{
         		_setNameFunc =
         			(_setName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiInspector_setName"), typeof(_setName));
         	}
         
         	 _setNameFunc(thisPtr, newObjectName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _apply(IntPtr thisPtr);
         private static _apply _applyFunc;
         internal static void apply(IntPtr thisPtr)
         {
         	if (_applyFunc == null)
         	{
         		_applyFunc =
         			(_apply)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiInspector_apply"), typeof(_apply));
         	}
         
         	 _applyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setObjectField(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fieldname, [MarshalAs(UnmanagedType.LPWStr)]string data);
         private static _setObjectField _setObjectFieldFunc;
         internal static void setObjectField(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fieldname, [MarshalAs(UnmanagedType.LPWStr)]string data)
         {
         	if (_setObjectFieldFunc == null)
         	{
         		_setObjectFieldFunc =
         			(_setObjectField)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiInspector_setObjectField"), typeof(_setObjectField));
         	}
         
         	 _setObjectFieldFunc(thisPtr, fieldname, data);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findByObject(IntPtr thisPtr, IntPtr _object);
         private static _findByObject _findByObjectFunc;
         internal static int findByObject(IntPtr thisPtr, IntPtr _object)
         {
         	if (_findByObjectFunc == null)
         	{
         		_findByObjectFunc =
         			(_findByObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiInspector_findByObject"), typeof(_findByObject));
         	}
         
         	return  _findByObjectFunc(thisPtr, _object);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspector_create();
         private static _GuiInspector_create _GuiInspector_createFunc;
         internal static IntPtr GuiInspector_create()
         {
         	if (_GuiInspector_createFunc == null)
         	{
         		_GuiInspector_createFunc =
         			(_GuiInspector_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspector_create"), typeof(_GuiInspector_create));
         	}
         
         	return  _GuiInspector_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void inspect(string simObject = "")
         {
            InternalUnsafeMethods.inspect(ObjectPtr, simObject);
         }
      
         public virtual void addInspect(string simObject, bool autoSync = true)
         {
            InternalUnsafeMethods.addInspect(ObjectPtr, simObject, autoSync);
         }
      
         public virtual void removeInspect(string simObject)
         {
            InternalUnsafeMethods.removeInspect(ObjectPtr, simObject);
         }
      
         public virtual void refresh()
         {
            InternalUnsafeMethods.refresh(ObjectPtr);
         }
      
         public virtual string getInspectObject(int index = 0)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getInspectObject(ObjectPtr, index));
         }
      
         public virtual int getNumInspectObjects()
         {
            return InternalUnsafeMethods.getNumInspectObjects(ObjectPtr);
         }
      
         public virtual void setName(string newObjectName)
         {
            InternalUnsafeMethods.setName(ObjectPtr, newObjectName);
         }
      
         public virtual void apply()
         {
            InternalUnsafeMethods.apply(ObjectPtr);
         }
      
         public virtual void setObjectField(string fieldname, string data)
         {
            InternalUnsafeMethods.setObjectField(ObjectPtr, fieldname, data);
         }
      
         public virtual int findByObject(SimObject _object)
         {
            return InternalUnsafeMethods.findByObject(ObjectPtr, _object.ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public int DividerMargin
         {
         	get { return int.Parse(getFieldValue("DividerMargin")); }
         	set { setFieldValue("DividerMargin", value.ToString()); }
         }
      
         public string GroupFilters
         {
         	get { return getFieldValue("GroupFilters"); }
         	set { setFieldValue("GroupFilters", value); }
         }
      
         public bool ShowCustomFields
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowCustomFields")); }
         	set { setFieldValue("ShowCustomFields", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}