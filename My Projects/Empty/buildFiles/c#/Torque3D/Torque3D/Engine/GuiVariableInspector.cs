using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiVariableInspector : GuiInspector
	{
		public GuiVariableInspector(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiVariableInspector(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiVariableInspector(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiVariableInspector(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiVariableInspector(SimObject pObj) : base(pObj)
		{
		}

		public GuiVariableInspector(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiVariableInspector_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _loadVars(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string searchString);
         private static _loadVars _loadVarsFunc;
         internal static void loadVars(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string searchString)
         {
         	if (_loadVarsFunc == null)
         	{
         		_loadVarsFunc =
         			(_loadVars)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiVariableInspector_loadVars"), typeof(_loadVars));
         	}
         
         	 _loadVarsFunc(thisPtr, searchString);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiVariableInspector_create();
         private static _GuiVariableInspector_create _GuiVariableInspector_createFunc;
         internal static IntPtr GuiVariableInspector_create()
         {
         	if (_GuiVariableInspector_createFunc == null)
         	{
         		_GuiVariableInspector_createFunc =
         			(_GuiVariableInspector_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiVariableInspector_create"), typeof(_GuiVariableInspector_create));
         	}
         
         	return  _GuiVariableInspector_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void loadVars(string searchString)
         {
            InternalUnsafeMethods.loadVars(ObjectPtr, searchString);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}