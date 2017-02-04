using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeSFXSourceName : GuiInspectorTypeMenuBase
	{
		public GuiInspectorTypeSFXSourceName(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeSFXSourceName(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeSFXSourceName(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeSFXSourceName(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeSFXSourceName(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeSFXSourceName(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeSFXSourceName_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeSFXSourceName_create();
         private static _GuiInspectorTypeSFXSourceName_create _GuiInspectorTypeSFXSourceName_createFunc;
         internal static IntPtr GuiInspectorTypeSFXSourceName_create()
         {
         	if (_GuiInspectorTypeSFXSourceName_createFunc == null)
         	{
         		_GuiInspectorTypeSFXSourceName_createFunc =
         			(_GuiInspectorTypeSFXSourceName_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeSFXSourceName_create"), typeof(_GuiInspectorTypeSFXSourceName_create));
         	}
         
         	return  _GuiInspectorTypeSFXSourceName_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}