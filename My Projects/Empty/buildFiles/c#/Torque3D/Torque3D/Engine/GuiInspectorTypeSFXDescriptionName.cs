using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeSFXDescriptionName : GuiInspectorDatablockField
	{
		public GuiInspectorTypeSFXDescriptionName(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeSFXDescriptionName(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeSFXDescriptionName(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeSFXDescriptionName(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeSFXDescriptionName(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeSFXDescriptionName(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeSFXDescriptionName_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeSFXDescriptionName_create();
         private static _GuiInspectorTypeSFXDescriptionName_create _GuiInspectorTypeSFXDescriptionName_createFunc;
         internal static IntPtr GuiInspectorTypeSFXDescriptionName_create()
         {
         	if (_GuiInspectorTypeSFXDescriptionName_createFunc == null)
         	{
         		_GuiInspectorTypeSFXDescriptionName_createFunc =
         			(_GuiInspectorTypeSFXDescriptionName_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeSFXDescriptionName_create"), typeof(_GuiInspectorTypeSFXDescriptionName_create));
         	}
         
         	return  _GuiInspectorTypeSFXDescriptionName_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}