using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeBitMask32Helper : GuiInspectorField
	{
		public GuiInspectorTypeBitMask32Helper(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeBitMask32Helper(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeBitMask32Helper(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeBitMask32Helper(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeBitMask32Helper(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeBitMask32Helper(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeBitMask32Helper_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeBitMask32Helper_create();
         private static _GuiInspectorTypeBitMask32Helper_create _GuiInspectorTypeBitMask32Helper_createFunc;
         internal static IntPtr GuiInspectorTypeBitMask32Helper_create()
         {
         	if (_GuiInspectorTypeBitMask32Helper_createFunc == null)
         	{
         		_GuiInspectorTypeBitMask32Helper_createFunc =
         			(_GuiInspectorTypeBitMask32Helper_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeBitMask32Helper_create"), typeof(_GuiInspectorTypeBitMask32Helper_create));
         	}
         
         	return  _GuiInspectorTypeBitMask32Helper_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}