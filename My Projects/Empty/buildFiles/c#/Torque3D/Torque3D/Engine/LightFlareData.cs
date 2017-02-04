using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class LightFlareData : SimDataBlock
	{
		public LightFlareData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public LightFlareData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public LightFlareData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public LightFlareData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public LightFlareData(SimObject pObj) : base(pObj)
		{
		}

		public LightFlareData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.LightFlareData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _apply(IntPtr thisPtr);
         private static _apply _applyFunc;
         internal static void apply(IntPtr thisPtr)
         {
         	if (_applyFunc == null)
         	{
         		_applyFunc =
         			(_apply)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnLightFlareData_apply"), typeof(_apply));
         	}
         
         	 _applyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _LightFlareData_create();
         private static _LightFlareData_create _LightFlareData_createFunc;
         internal static IntPtr LightFlareData_create()
         {
         	if (_LightFlareData_createFunc == null)
         	{
         		_LightFlareData_createFunc =
         			(_LightFlareData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_LightFlareData_create"), typeof(_LightFlareData_create));
         	}
         
         	return  _LightFlareData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void apply()
         {
            InternalUnsafeMethods.apply(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public float OverallScale
         {
         	get { return float.Parse(getFieldValue("OverallScale")); }
         	set { setFieldValue("OverallScale", value.ToString()); }
         }
      
         public float OcclusionRadius
         {
         	get { return float.Parse(getFieldValue("OcclusionRadius")); }
         	set { setFieldValue("OcclusionRadius", value.ToString()); }
         }
      
         public bool RenderReflectPass
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderReflectPass")); }
         	set { setFieldValue("RenderReflectPass", value ? "1" : "0"); }
         }
      
         public bool FlareEnabled
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FlareEnabled")); }
         	set { setFieldValue("FlareEnabled", value ? "1" : "0"); }
         }
      
         public string FlareTexture
         {
         	get { return getFieldValue("FlareTexture"); }
         	set { setFieldValue("FlareTexture", value); }
         }
      
         public DynamicFieldVector<RectF> ElementRect
         {
         	get { return new DynamicFieldVector<RectF>(this, "ElementRect", 20, val => new RectF(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> ElementDist
         {
         	get { return new DynamicFieldVector<float>(this, "ElementDist", 20, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> ElementScale
         {
         	get { return new DynamicFieldVector<float>(this, "ElementScale", 20, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<ColorF> ElementTint
         {
         	get { return new DynamicFieldVector<ColorF>(this, "ElementTint", 20, val => new ColorF(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<bool> ElementRotate
         {
         	get { return new DynamicFieldVector<bool>(this, "ElementRotate", 20, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<bool> ElementUseLightColor
         {
         	get { return new DynamicFieldVector<bool>(this, "ElementUseLightColor", 20, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
      
      #endregion

	}
}