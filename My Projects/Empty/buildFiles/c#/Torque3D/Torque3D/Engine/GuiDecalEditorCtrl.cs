using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiDecalEditorCtrl : EditTSCtrl
	{
		public GuiDecalEditorCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiDecalEditorCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiDecalEditorCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiDecalEditorCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiDecalEditorCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiDecalEditorCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiDecalEditorCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deleteSelectedDecal(IntPtr thisPtr);
         private static _deleteSelectedDecal _deleteSelectedDecalFunc;
         internal static void deleteSelectedDecal(IntPtr thisPtr)
         {
         	if (_deleteSelectedDecalFunc == null)
         	{
         		_deleteSelectedDecalFunc =
         			(_deleteSelectedDecal)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiDecalEditorCtrl_deleteSelectedDecal"), typeof(_deleteSelectedDecal));
         	}
         
         	 _deleteSelectedDecalFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deleteDecalDatablock(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string datablock);
         private static _deleteDecalDatablock _deleteDecalDatablockFunc;
         internal static void deleteDecalDatablock(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string datablock)
         {
         	if (_deleteDecalDatablockFunc == null)
         	{
         		_deleteDecalDatablockFunc =
         			(_deleteDecalDatablock)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiDecalEditorCtrl_deleteDecalDatablock"), typeof(_deleteDecalDatablock));
         	}
         
         	 _deleteDecalDatablockFunc(thisPtr, datablock);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMode(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newMode);
         private static _setMode _setModeFunc;
         internal static void setMode(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newMode)
         {
         	if (_setModeFunc == null)
         	{
         		_setModeFunc =
         			(_setMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiDecalEditorCtrl_setMode"), typeof(_setMode));
         	}
         
         	 _setModeFunc(thisPtr, newMode);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getMode(IntPtr thisPtr);
         private static _getMode _getModeFunc;
         internal static IntPtr getMode(IntPtr thisPtr)
         {
         	if (_getModeFunc == null)
         	{
         		_getModeFunc =
         			(_getMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiDecalEditorCtrl_getMode"), typeof(_getMode));
         	}
         
         	return  _getModeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getDecalCount(IntPtr thisPtr);
         private static _getDecalCount _getDecalCountFunc;
         internal static int getDecalCount(IntPtr thisPtr)
         {
         	if (_getDecalCountFunc == null)
         	{
         		_getDecalCountFunc =
         			(_getDecalCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiDecalEditorCtrl_getDecalCount"), typeof(_getDecalCount));
         	}
         
         	return  _getDecalCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getDecalTransform(IntPtr thisPtr, uint id);
         private static _getDecalTransform _getDecalTransformFunc;
         internal static IntPtr getDecalTransform(IntPtr thisPtr, uint id)
         {
         	if (_getDecalTransformFunc == null)
         	{
         		_getDecalTransformFunc =
         			(_getDecalTransform)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiDecalEditorCtrl_getDecalTransform"), typeof(_getDecalTransform));
         	}
         
         	return  _getDecalTransformFunc(thisPtr, id);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getDecalLookupName(IntPtr thisPtr, uint id);
         private static _getDecalLookupName _getDecalLookupNameFunc;
         internal static IntPtr getDecalLookupName(IntPtr thisPtr, uint id)
         {
         	if (_getDecalLookupNameFunc == null)
         	{
         		_getDecalLookupNameFunc =
         			(_getDecalLookupName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiDecalEditorCtrl_getDecalLookupName"), typeof(_getDecalLookupName));
         	}
         
         	return  _getDecalLookupNameFunc(thisPtr, id);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _selectDecal(IntPtr thisPtr, uint id);
         private static _selectDecal _selectDecalFunc;
         internal static void selectDecal(IntPtr thisPtr, uint id)
         {
         	if (_selectDecalFunc == null)
         	{
         		_selectDecalFunc =
         			(_selectDecal)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiDecalEditorCtrl_selectDecal"), typeof(_selectDecal));
         	}
         
         	 _selectDecalFunc(thisPtr, id);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _editDecalDetails(IntPtr thisPtr, uint id, InternalPoint3FStruct pos, InternalPoint3FStruct tan, float size);
         private static _editDecalDetails _editDecalDetailsFunc;
         internal static void editDecalDetails(IntPtr thisPtr, uint id, InternalPoint3FStruct pos, InternalPoint3FStruct tan, float size)
         {
         	if (_editDecalDetailsFunc == null)
         	{
         		_editDecalDetailsFunc =
         			(_editDecalDetails)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiDecalEditorCtrl_editDecalDetails"), typeof(_editDecalDetails));
         	}
         
         	 _editDecalDetailsFunc(thisPtr, id, pos, tan, size);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSelectionCount(IntPtr thisPtr);
         private static _getSelectionCount _getSelectionCountFunc;
         internal static int getSelectionCount(IntPtr thisPtr)
         {
         	if (_getSelectionCountFunc == null)
         	{
         		_getSelectionCountFunc =
         			(_getSelectionCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiDecalEditorCtrl_getSelectionCount"), typeof(_getSelectionCount));
         	}
         
         	return  _getSelectionCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _retargetDecalDatablock(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string dbFrom, [MarshalAs(UnmanagedType.LPWStr)]string dbTo);
         private static _retargetDecalDatablock _retargetDecalDatablockFunc;
         internal static void retargetDecalDatablock(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string dbFrom, [MarshalAs(UnmanagedType.LPWStr)]string dbTo)
         {
         	if (_retargetDecalDatablockFunc == null)
         	{
         		_retargetDecalDatablockFunc =
         			(_retargetDecalDatablock)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiDecalEditorCtrl_retargetDecalDatablock"), typeof(_retargetDecalDatablock));
         	}
         
         	 _retargetDecalDatablockFunc(thisPtr, dbFrom, dbTo);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiDecalEditorCtrl_create();
         private static _GuiDecalEditorCtrl_create _GuiDecalEditorCtrl_createFunc;
         internal static IntPtr GuiDecalEditorCtrl_create()
         {
         	if (_GuiDecalEditorCtrl_createFunc == null)
         	{
         		_GuiDecalEditorCtrl_createFunc =
         			(_GuiDecalEditorCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiDecalEditorCtrl_create"), typeof(_GuiDecalEditorCtrl_create));
         	}
         
         	return  _GuiDecalEditorCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void deleteSelectedDecal()
         {
            InternalUnsafeMethods.deleteSelectedDecal(ObjectPtr);
         }
      
         public virtual void deleteDecalDatablock(string datablock)
         {
            InternalUnsafeMethods.deleteDecalDatablock(ObjectPtr, datablock);
         }
      
         public virtual void setMode(string newMode)
         {
            InternalUnsafeMethods.setMode(ObjectPtr, newMode);
         }
      
         public virtual string getMode()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getMode(ObjectPtr));
         }
      
         public virtual int getDecalCount()
         {
            return InternalUnsafeMethods.getDecalCount(ObjectPtr);
         }
      
         public virtual string getDecalTransform(uint id)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getDecalTransform(ObjectPtr, id));
         }
      
         public virtual string getDecalLookupName(uint id)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getDecalLookupName(ObjectPtr, id));
         }
      
         public virtual void selectDecal(uint id)
         {
            InternalUnsafeMethods.selectDecal(ObjectPtr, id);
         }
      
         public virtual void editDecalDetails(uint id, Point3F pos, Point3F tan, float size)
         {
            InternalUnsafeMethods.editDecalDetails(ObjectPtr, id, pos.ToStruct(), tan.ToStruct(), size);
         }
      
         public virtual int getSelectionCount()
         {
            return InternalUnsafeMethods.getSelectionCount(ObjectPtr);
         }
      
         public virtual void retargetDecalDatablock(string dbFrom, string dbTo)
         {
            InternalUnsafeMethods.retargetDecalDatablock(ObjectPtr, dbFrom, dbTo);
         }
      
      
      #endregion


      #region Properties
      
      
         public DecalData CurrentDecalData
         {
         	get { return Sim.FindObject<DecalData>(getFieldValue("CurrentDecalData")); }
         	set { setFieldValue("CurrentDecalData", value.getId().ToString()); }
         }
      
      
      #endregion

	}
}