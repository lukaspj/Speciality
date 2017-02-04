using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class InspectorFieldUndoAction : UndoAction
	{
		public InspectorFieldUndoAction(bool pRegister = false)
			: base(pRegister)
		{
		}

		public InspectorFieldUndoAction(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public InspectorFieldUndoAction(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public InspectorFieldUndoAction(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public InspectorFieldUndoAction(SimObject pObj) : base(pObj)
		{
		}

		public InspectorFieldUndoAction(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.InspectorFieldUndoAction_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _InspectorFieldUndoAction_create();
         private static _InspectorFieldUndoAction_create _InspectorFieldUndoAction_createFunc;
         internal static IntPtr InspectorFieldUndoAction_create()
         {
         	if (_InspectorFieldUndoAction_createFunc == null)
         	{
         		_InspectorFieldUndoAction_createFunc =
         			(_InspectorFieldUndoAction_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_InspectorFieldUndoAction_create"), typeof(_InspectorFieldUndoAction_create));
         	}
         
         	return  _InspectorFieldUndoAction_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public GuiInspector InspectorGui
         {
         	get { return Sim.FindObject<GuiInspector>(getFieldValue("InspectorGui")); }
         	set { setFieldValue("InspectorGui", value.getId().ToString()); }
         }
      
         public int ObjectId
         {
         	get { return int.Parse(getFieldValue("ObjectId")); }
         	set { setFieldValue("ObjectId", value.ToString()); }
         }
      
         public string FieldName
         {
         	get { return getFieldValue("FieldName"); }
         	set { setFieldValue("FieldName", value); }
         }
      
         public string FieldValue
         {
         	get { return getFieldValue("FieldValue"); }
         	set { setFieldValue("FieldValue", value); }
         }
      
         public string ArrayIndex
         {
         	get { return getFieldValue("ArrayIndex"); }
         	set { setFieldValue("ArrayIndex", value); }
         }
      
      
      #endregion

	}
}