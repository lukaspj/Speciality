using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeSFXParameterName : GuiInspectorTypeMenuBase
	{
		public GuiInspectorTypeSFXParameterName(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeSFXParameterName(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeSFXParameterName(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeSFXParameterName(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeSFXParameterName(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeSFXParameterName(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeSFXParameterName_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeSFXParameterName_create();
         private static _GuiInspectorTypeSFXParameterName_create _GuiInspectorTypeSFXParameterName_createFunc;
         internal static IntPtr GuiInspectorTypeSFXParameterName_create()
         {
         	if (_GuiInspectorTypeSFXParameterName_createFunc == null)
         	{
         		_GuiInspectorTypeSFXParameterName_createFunc =
         			(_GuiInspectorTypeSFXParameterName_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeSFXParameterName_create"), typeof(_GuiInspectorTypeSFXParameterName_create));
         	}
         
         	return  _GuiInspectorTypeSFXParameterName_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}