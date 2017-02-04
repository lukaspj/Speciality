using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class FieldBrushObject : SimObject
	{
		public FieldBrushObject(bool pRegister = false)
			: base(pRegister)
		{
		}

		public FieldBrushObject(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public FieldBrushObject(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public FieldBrushObject(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public FieldBrushObject(SimObject pObj) : base(pObj)
		{
		}

		public FieldBrushObject(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.FieldBrushObject_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _queryGroups(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string simObjName);
         private static _queryGroups _queryGroupsFunc;
         internal static IntPtr queryGroups(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string simObjName)
         {
         	if (_queryGroupsFunc == null)
         	{
         		_queryGroupsFunc =
         			(_queryGroups)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnFieldBrushObject_queryGroups"), typeof(_queryGroups));
         	}
         
         	return  _queryGroupsFunc(thisPtr, simObjName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _queryFields(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string simObjName, [MarshalAs(UnmanagedType.LPWStr)]string groupList);
         private static _queryFields _queryFieldsFunc;
         internal static IntPtr queryFields(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string simObjName, [MarshalAs(UnmanagedType.LPWStr)]string groupList)
         {
         	if (_queryFieldsFunc == null)
         	{
         		_queryFieldsFunc =
         			(_queryFields)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnFieldBrushObject_queryFields"), typeof(_queryFields));
         	}
         
         	return  _queryFieldsFunc(thisPtr, simObjName, groupList);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _copyFields(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string simObjName, [MarshalAs(UnmanagedType.LPWStr)]string pFieldList);
         private static _copyFields _copyFieldsFunc;
         internal static void copyFields(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string simObjName, [MarshalAs(UnmanagedType.LPWStr)]string pFieldList)
         {
         	if (_copyFieldsFunc == null)
         	{
         		_copyFieldsFunc =
         			(_copyFields)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnFieldBrushObject_copyFields"), typeof(_copyFields));
         	}
         
         	 _copyFieldsFunc(thisPtr, simObjName, pFieldList);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _pasteFields(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string simObjName);
         private static _pasteFields _pasteFieldsFunc;
         internal static void pasteFields(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string simObjName)
         {
         	if (_pasteFieldsFunc == null)
         	{
         		_pasteFieldsFunc =
         			(_pasteFields)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnFieldBrushObject_pasteFields"), typeof(_pasteFields));
         	}
         
         	 _pasteFieldsFunc(thisPtr, simObjName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FieldBrushObject_create();
         private static _FieldBrushObject_create _FieldBrushObject_createFunc;
         internal static IntPtr FieldBrushObject_create()
         {
         	if (_FieldBrushObject_createFunc == null)
         	{
         		_FieldBrushObject_createFunc =
         			(_FieldBrushObject_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_FieldBrushObject_create"), typeof(_FieldBrushObject_create));
         	}
         
         	return  _FieldBrushObject_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual string queryGroups(string simObjName)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.queryGroups(ObjectPtr, simObjName));
         }
      
         public virtual string queryFields(string simObjName, string groupList = "")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.queryFields(ObjectPtr, simObjName, groupList));
         }
      
         public virtual void copyFields(string simObjName, string pFieldList = "")
         {
            InternalUnsafeMethods.copyFields(ObjectPtr, simObjName, pFieldList);
         }
      
         public virtual void pasteFields(string simObjName)
         {
            InternalUnsafeMethods.pasteFields(ObjectPtr, simObjName);
         }
      
      
      #endregion


      #region Properties
      
      
         public string Description
         {
         	get { return getFieldValue("Description"); }
         	set { setFieldValue("Description", value); }
         }
      
         public string SortName
         {
         	get { return getFieldValue("SortName"); }
         	set { setFieldValue("SortName", value); }
         }
      
      
      #endregion

	}
}