using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class LightAnimData : SimDataBlock
	{
		public LightAnimData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public LightAnimData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public LightAnimData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public LightAnimData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public LightAnimData(SimObject pObj) : base(pObj)
		{
		}

		public LightAnimData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.LightAnimData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _LightAnimData_create();
         private static _LightAnimData_create _LightAnimData_createFunc;
         internal static IntPtr LightAnimData_create()
         {
         	if (_LightAnimData_createFunc == null)
         	{
         		_LightAnimData_createFunc =
         			(_LightAnimData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_LightAnimData_create"), typeof(_LightAnimData_create));
         	}
         
         	return  _LightAnimData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public DynamicFieldVector<float> OffsetA
         {
         	get { return new DynamicFieldVector<float>(this, "OffsetA", 3, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> OffsetZ
         {
         	get { return new DynamicFieldVector<float>(this, "OffsetZ", 3, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> OffsetPeriod
         {
         	get { return new DynamicFieldVector<float>(this, "OffsetPeriod", 3, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<string> OffsetKeys
         {
         	get { return new DynamicFieldVector<string>(this, "OffsetKeys", 3, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<bool> OffsetSmooth
         {
         	get { return new DynamicFieldVector<bool>(this, "OffsetSmooth", 3, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<float> RotA
         {
         	get { return new DynamicFieldVector<float>(this, "RotA", 3, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> RotZ
         {
         	get { return new DynamicFieldVector<float>(this, "RotZ", 3, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> RotPeriod
         {
         	get { return new DynamicFieldVector<float>(this, "RotPeriod", 3, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<string> RotKeys
         {
         	get { return new DynamicFieldVector<string>(this, "RotKeys", 3, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<bool> RotSmooth
         {
         	get { return new DynamicFieldVector<bool>(this, "RotSmooth", 3, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<float> ColorA
         {
         	get { return new DynamicFieldVector<float>(this, "ColorA", 3, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> ColorZ
         {
         	get { return new DynamicFieldVector<float>(this, "ColorZ", 3, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> ColorPeriod
         {
         	get { return new DynamicFieldVector<float>(this, "ColorPeriod", 3, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<string> ColorKeys
         {
         	get { return new DynamicFieldVector<string>(this, "ColorKeys", 3, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<bool> ColorSmooth
         {
         	get { return new DynamicFieldVector<bool>(this, "ColorSmooth", 3, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public float BrightnessA
         {
         	get { return float.Parse(getFieldValue("BrightnessA")); }
         	set { setFieldValue("BrightnessA", value.ToString()); }
         }
      
         public float BrightnessZ
         {
         	get { return float.Parse(getFieldValue("BrightnessZ")); }
         	set { setFieldValue("BrightnessZ", value.ToString()); }
         }
      
         public float BrightnessPeriod
         {
         	get { return float.Parse(getFieldValue("BrightnessPeriod")); }
         	set { setFieldValue("BrightnessPeriod", value.ToString()); }
         }
      
         public string BrightnessKeys
         {
         	get { return getFieldValue("BrightnessKeys"); }
         	set { setFieldValue("BrightnessKeys", value); }
         }
      
         public bool BrightnessSmooth
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("BrightnessSmooth")); }
         	set { setFieldValue("BrightnessSmooth", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}