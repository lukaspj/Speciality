using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeShapeFilename : GuiInspectorTypeFileName
	{
		public GuiInspectorTypeShapeFilename(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeShapeFilename(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeShapeFilename(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeShapeFilename(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeShapeFilename(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeShapeFilename(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeShapeFilename_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeShapeFilename_create();
         private static _GuiInspectorTypeShapeFilename_create _GuiInspectorTypeShapeFilename_createFunc;
         internal static IntPtr GuiInspectorTypeShapeFilename_create()
         {
         	if (_GuiInspectorTypeShapeFilename_createFunc == null)
         	{
         		_GuiInspectorTypeShapeFilename_createFunc =
         			(_GuiInspectorTypeShapeFilename_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeShapeFilename_create"), typeof(_GuiInspectorTypeShapeFilename_create));
         	}
         
         	return  _GuiInspectorTypeShapeFilename_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}