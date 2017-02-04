using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeSFXAmbienceName : GuiInspectorDatablockField
	{
		public GuiInspectorTypeSFXAmbienceName(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeSFXAmbienceName(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeSFXAmbienceName(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeSFXAmbienceName(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeSFXAmbienceName(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeSFXAmbienceName(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeSFXAmbienceName_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeSFXAmbienceName_create();
         private static _GuiInspectorTypeSFXAmbienceName_create _GuiInspectorTypeSFXAmbienceName_createFunc;
         internal static IntPtr GuiInspectorTypeSFXAmbienceName_create()
         {
         	if (_GuiInspectorTypeSFXAmbienceName_createFunc == null)
         	{
         		_GuiInspectorTypeSFXAmbienceName_createFunc =
         			(_GuiInspectorTypeSFXAmbienceName_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeSFXAmbienceName_create"), typeof(_GuiInspectorTypeSFXAmbienceName_create));
         	}
         
         	return  _GuiInspectorTypeSFXAmbienceName_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}