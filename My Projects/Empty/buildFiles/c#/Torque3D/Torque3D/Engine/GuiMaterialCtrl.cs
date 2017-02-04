using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiMaterialCtrl : GuiContainer
	{
		public GuiMaterialCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiMaterialCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiMaterialCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiMaterialCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiMaterialCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiMaterialCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiMaterialCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setMaterial(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string materialName);
         private static _setMaterial _setMaterialFunc;
         internal static bool setMaterial(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string materialName)
         {
         	if (_setMaterialFunc == null)
         	{
         		_setMaterialFunc =
         			(_setMaterial)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMaterialCtrl_setMaterial"), typeof(_setMaterial));
         	}
         
         	return  _setMaterialFunc(thisPtr, materialName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiMaterialCtrl_create();
         private static _GuiMaterialCtrl_create _GuiMaterialCtrl_createFunc;
         internal static IntPtr GuiMaterialCtrl_create()
         {
         	if (_GuiMaterialCtrl_createFunc == null)
         	{
         		_GuiMaterialCtrl_createFunc =
         			(_GuiMaterialCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiMaterialCtrl_create"), typeof(_GuiMaterialCtrl_create));
         	}
         
         	return  _GuiMaterialCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool setMaterial(string materialName)
         {
            return InternalUnsafeMethods.setMaterial(ObjectPtr, materialName);
         }
      
      
      #endregion


      #region Properties
      
      
         public string MaterialName
         {
         	get { return getFieldValue("MaterialName"); }
         	set { setFieldValue("MaterialName", value); }
         }
      
      
      #endregion

	}
}