using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeCommand : GuiInspectorField
	{
		public GuiInspectorTypeCommand(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeCommand(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeCommand(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeCommand(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeCommand(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeCommand(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeCommand_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeCommand_create();
         private static _GuiInspectorTypeCommand_create _GuiInspectorTypeCommand_createFunc;
         internal static IntPtr GuiInspectorTypeCommand_create()
         {
         	if (_GuiInspectorTypeCommand_createFunc == null)
         	{
         		_GuiInspectorTypeCommand_createFunc =
         			(_GuiInspectorTypeCommand_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeCommand_create"), typeof(_GuiInspectorTypeCommand_create));
         	}
         
         	return  _GuiInspectorTypeCommand_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}