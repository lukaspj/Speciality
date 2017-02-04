using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorDynamicField : GuiInspectorField
	{
		public GuiInspectorDynamicField(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorDynamicField(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorDynamicField(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorDynamicField(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorDynamicField(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorDynamicField(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorDynamicField_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _renameField(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newDynamicFieldName);
         private static _renameField _renameFieldFunc;
         internal static void renameField(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newDynamicFieldName)
         {
         	if (_renameFieldFunc == null)
         	{
         		_renameFieldFunc =
         			(_renameField)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiInspectorDynamicField_renameField"), typeof(_renameField));
         	}
         
         	 _renameFieldFunc(thisPtr, newDynamicFieldName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorDynamicField_create();
         private static _GuiInspectorDynamicField_create _GuiInspectorDynamicField_createFunc;
         internal static IntPtr GuiInspectorDynamicField_create()
         {
         	if (_GuiInspectorDynamicField_createFunc == null)
         	{
         		_GuiInspectorDynamicField_createFunc =
         			(_GuiInspectorDynamicField_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorDynamicField_create"), typeof(_GuiInspectorDynamicField_create));
         	}
         
         	return  _GuiInspectorDynamicField_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void renameField(string newDynamicFieldName)
         {
            InternalUnsafeMethods.renameField(ObjectPtr, newDynamicFieldName);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}