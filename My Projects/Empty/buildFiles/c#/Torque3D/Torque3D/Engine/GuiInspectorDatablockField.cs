using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorDatablockField : GuiInspectorTypeMenuBase
	{
		public GuiInspectorDatablockField(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorDatablockField(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorDatablockField(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorDatablockField(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorDatablockField(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorDatablockField(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorDatablockField_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorDatablockField_create();
         private static _GuiInspectorDatablockField_create _GuiInspectorDatablockField_createFunc;
         internal static IntPtr GuiInspectorDatablockField_create()
         {
         	if (_GuiInspectorDatablockField_createFunc == null)
         	{
         		_GuiInspectorDatablockField_createFunc =
         			(_GuiInspectorDatablockField_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorDatablockField_create"), typeof(_GuiInspectorDatablockField_create));
         	}
         
         	return  _GuiInspectorDatablockField_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}