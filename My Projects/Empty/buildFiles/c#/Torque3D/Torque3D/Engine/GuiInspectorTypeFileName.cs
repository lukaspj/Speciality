using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeFileName : GuiInspectorField
	{
		public GuiInspectorTypeFileName(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeFileName(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeFileName(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeFileName(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeFileName(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeFileName(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeFileName_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _apply(IntPtr thisPtr, int argc, string[] argv);
         private static _apply _applyFunc;
         internal static void apply(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_applyFunc == null)
         	{
         		_applyFunc =
         			(_apply)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiInspectorTypeFileName_apply"), typeof(_apply));
         	}
         
         	 _applyFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeFileName_create();
         private static _GuiInspectorTypeFileName_create _GuiInspectorTypeFileName_createFunc;
         internal static IntPtr GuiInspectorTypeFileName_create()
         {
         	if (_GuiInspectorTypeFileName_createFunc == null)
         	{
         		_GuiInspectorTypeFileName_createFunc =
         			(_GuiInspectorTypeFileName_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeFileName_create"), typeof(_GuiInspectorTypeFileName_create));
         	}
         
         	return  _GuiInspectorTypeFileName_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void apply()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.apply(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}