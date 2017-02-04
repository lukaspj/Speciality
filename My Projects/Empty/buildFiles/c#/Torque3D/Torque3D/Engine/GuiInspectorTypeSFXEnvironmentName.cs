using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeSFXEnvironmentName : GuiInspectorDatablockField
	{
		public GuiInspectorTypeSFXEnvironmentName(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeSFXEnvironmentName(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeSFXEnvironmentName(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeSFXEnvironmentName(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeSFXEnvironmentName(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeSFXEnvironmentName(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeSFXEnvironmentName_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeSFXEnvironmentName_create();
         private static _GuiInspectorTypeSFXEnvironmentName_create _GuiInspectorTypeSFXEnvironmentName_createFunc;
         internal static IntPtr GuiInspectorTypeSFXEnvironmentName_create()
         {
         	if (_GuiInspectorTypeSFXEnvironmentName_createFunc == null)
         	{
         		_GuiInspectorTypeSFXEnvironmentName_createFunc =
         			(_GuiInspectorTypeSFXEnvironmentName_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeSFXEnvironmentName_create"), typeof(_GuiInspectorTypeSFXEnvironmentName_create));
         	}
         
         	return  _GuiInspectorTypeSFXEnvironmentName_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}