using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeBitMask32 : GuiInspectorField
	{
		public GuiInspectorTypeBitMask32(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeBitMask32(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeBitMask32(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeBitMask32(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeBitMask32(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeBitMask32(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeBitMask32_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _applyBit(IntPtr thisPtr, int argc, string[] argv);
         private static _applyBit _applyBitFunc;
         internal static void applyBit(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_applyBitFunc == null)
         	{
         		_applyBitFunc =
         			(_applyBit)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiInspectorTypeBitMask32_applyBit"), typeof(_applyBit));
         	}
         
         	 _applyBitFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeBitMask32_create();
         private static _GuiInspectorTypeBitMask32_create _GuiInspectorTypeBitMask32_createFunc;
         internal static IntPtr GuiInspectorTypeBitMask32_create()
         {
         	if (_GuiInspectorTypeBitMask32_createFunc == null)
         	{
         		_GuiInspectorTypeBitMask32_createFunc =
         			(_GuiInspectorTypeBitMask32_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeBitMask32_create"), typeof(_GuiInspectorTypeBitMask32_create));
         	}
         
         	return  _GuiInspectorTypeBitMask32_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void applyBit()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.applyBit(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}