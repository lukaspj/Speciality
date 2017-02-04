using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorDynamicGroup : GuiInspectorGroup
	{
		public GuiInspectorDynamicGroup(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorDynamicGroup(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorDynamicGroup(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorDynamicGroup(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorDynamicGroup(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorDynamicGroup(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorDynamicGroup_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _inspectGroup(IntPtr thisPtr);
         private static _inspectGroup _inspectGroupFunc;
         internal static bool inspectGroup(IntPtr thisPtr)
         {
         	if (_inspectGroupFunc == null)
         	{
         		_inspectGroupFunc =
         			(_inspectGroup)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiInspectorDynamicGroup_inspectGroup"), typeof(_inspectGroup));
         	}
         
         	return  _inspectGroupFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addDynamicField(IntPtr thisPtr);
         private static _addDynamicField _addDynamicFieldFunc;
         internal static void addDynamicField(IntPtr thisPtr)
         {
         	if (_addDynamicFieldFunc == null)
         	{
         		_addDynamicFieldFunc =
         			(_addDynamicField)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiInspectorDynamicGroup_addDynamicField"), typeof(_addDynamicField));
         	}
         
         	 _addDynamicFieldFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeDynamicField(IntPtr thisPtr);
         private static _removeDynamicField _removeDynamicFieldFunc;
         internal static void removeDynamicField(IntPtr thisPtr)
         {
         	if (_removeDynamicFieldFunc == null)
         	{
         		_removeDynamicFieldFunc =
         			(_removeDynamicField)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiInspectorDynamicGroup_removeDynamicField"), typeof(_removeDynamicField));
         	}
         
         	 _removeDynamicFieldFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorDynamicGroup_create();
         private static _GuiInspectorDynamicGroup_create _GuiInspectorDynamicGroup_createFunc;
         internal static IntPtr GuiInspectorDynamicGroup_create()
         {
         	if (_GuiInspectorDynamicGroup_createFunc == null)
         	{
         		_GuiInspectorDynamicGroup_createFunc =
         			(_GuiInspectorDynamicGroup_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorDynamicGroup_create"), typeof(_GuiInspectorDynamicGroup_create));
         	}
         
         	return  _GuiInspectorDynamicGroup_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool inspectGroup()
         {
            return InternalUnsafeMethods.inspectGroup(ObjectPtr);
         }
      
         public virtual void addDynamicField()
         {
            InternalUnsafeMethods.addDynamicField(ObjectPtr);
         }
      
         public virtual void removeDynamicField()
         {
            InternalUnsafeMethods.removeDynamicField(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}