using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class CustomMaterial : Material
	{
		public CustomMaterial(bool pRegister = false)
			: base(pRegister)
		{
		}

		public CustomMaterial(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public CustomMaterial(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public CustomMaterial(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public CustomMaterial(SimObject pObj) : base(pObj)
		{
		}

		public CustomMaterial(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.CustomMaterial_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _CustomMaterial_create();
         private static _CustomMaterial_create _CustomMaterial_createFunc;
         internal static IntPtr CustomMaterial_create()
         {
         	if (_CustomMaterial_createFunc == null)
         	{
         		_CustomMaterial_createFunc =
         			(_CustomMaterial_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CustomMaterial_create"), typeof(_CustomMaterial_create));
         	}
         
         	return  _CustomMaterial_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float Version
         {
         	get { return float.Parse(getFieldValue("Version")); }
         	set { setFieldValue("Version", value.ToString()); }
         }
      
         public Material Fallback
         {
         	get { return Sim.FindObject<Material>(getFieldValue("Fallback")); }
         	set { setFieldValue("Fallback", value.getId().ToString()); }
         }
      
         public string Shader
         {
         	get { return getFieldValue("Shader"); }
         	set { setFieldValue("Shader", value); }
         }
      
         public GFXStateBlockData StateBlock
         {
         	get { return Sim.FindObject<GFXStateBlockData>(getFieldValue("StateBlock")); }
         	set { setFieldValue("StateBlock", value.getId().ToString()); }
         }
      
         public string Target
         {
         	get { return getFieldValue("Target"); }
         	set { setFieldValue("Target", value); }
         }
      
         public bool ForwardLit
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ForwardLit")); }
         	set { setFieldValue("ForwardLit", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}