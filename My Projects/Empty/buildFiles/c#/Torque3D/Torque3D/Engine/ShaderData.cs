using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ShaderData : SimObject
	{
		public ShaderData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ShaderData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ShaderData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ShaderData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ShaderData(SimObject pObj) : base(pObj)
		{
		}

		public ShaderData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ShaderData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _reload(IntPtr thisPtr);
         private static _reload _reloadFunc;
         internal static void reload(IntPtr thisPtr)
         {
         	if (_reloadFunc == null)
         	{
         		_reloadFunc =
         			(_reload)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShaderData_reload"), typeof(_reload));
         	}
         
         	 _reloadFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ShaderData_create();
         private static _ShaderData_create _ShaderData_createFunc;
         internal static IntPtr ShaderData_create()
         {
         	if (_ShaderData_createFunc == null)
         	{
         		_ShaderData_createFunc =
         			(_ShaderData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ShaderData_create"), typeof(_ShaderData_create));
         	}
         
         	return  _ShaderData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void reload()
         {
            InternalUnsafeMethods.reload(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public string DXVertexShaderFile
         {
         	get { return getFieldValue("DXVertexShaderFile"); }
         	set { setFieldValue("DXVertexShaderFile", value); }
         }
      
         public string DXPixelShaderFile
         {
         	get { return getFieldValue("DXPixelShaderFile"); }
         	set { setFieldValue("DXPixelShaderFile", value); }
         }
      
         public string OGLVertexShaderFile
         {
         	get { return getFieldValue("OGLVertexShaderFile"); }
         	set { setFieldValue("OGLVertexShaderFile", value); }
         }
      
         public string OGLPixelShaderFile
         {
         	get { return getFieldValue("OGLPixelShaderFile"); }
         	set { setFieldValue("OGLPixelShaderFile", value); }
         }
      
         public bool UseDevicePixVersion
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseDevicePixVersion")); }
         	set { setFieldValue("UseDevicePixVersion", value ? "1" : "0"); }
         }
      
         public float PixVersion
         {
         	get { return float.Parse(getFieldValue("PixVersion")); }
         	set { setFieldValue("PixVersion", value.ToString()); }
         }
      
         public string Defines
         {
         	get { return getFieldValue("Defines"); }
         	set { setFieldValue("Defines", value); }
         }
      
         public DynamicFieldVector<string> SamplerNames
         {
         	get { return new DynamicFieldVector<string>(this, "SamplerNames", 8, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<bool> RtParams
         {
         	get { return new DynamicFieldVector<bool>(this, "RtParams", 8, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
      
      #endregion

	}
}