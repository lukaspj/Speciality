using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ItemData : ShapeBaseData
	{
		public ItemData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ItemData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ItemData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ItemData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ItemData(SimObject pObj) : base(pObj)
		{
		}

		public ItemData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ItemData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ItemData_create();
         private static _ItemData_create _ItemData_createFunc;
         internal static IntPtr ItemData_create()
         {
         	if (_ItemData_createFunc == null)
         	{
         		_ItemData_createFunc =
         			(_ItemData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ItemData_create"), typeof(_ItemData_create));
         	}
         
         	return  _ItemData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float Friction
         {
         	get { return float.Parse(getFieldValue("Friction")); }
         	set { setFieldValue("Friction", value.ToString()); }
         }
      
         public float Elasticity
         {
         	get { return float.Parse(getFieldValue("Elasticity")); }
         	set { setFieldValue("Elasticity", value.ToString()); }
         }
      
         public bool Sticky
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Sticky")); }
         	set { setFieldValue("Sticky", value ? "1" : "0"); }
         }
      
         public float GravityMod
         {
         	get { return float.Parse(getFieldValue("GravityMod")); }
         	set { setFieldValue("GravityMod", value.ToString()); }
         }
      
         public float MaxVelocity
         {
         	get { return float.Parse(getFieldValue("MaxVelocity")); }
         	set { setFieldValue("MaxVelocity", value.ToString()); }
         }
      
         public ItemLightType LightType
         {
         	get { return (ItemLightType)Enum.Parse(typeof(ItemLightType), getFieldValue("LightType"), true); }
         	set { setFieldValue("LightType", value.ToString()); }
         }
      
         public ColorF LightColor
         {
         	get { return new ColorF(getFieldValue("LightColor")); }
         	set { setFieldValue("LightColor", value.ToString()); }
         }
      
         public int LightTime
         {
         	get { return int.Parse(getFieldValue("LightTime")); }
         	set { setFieldValue("LightTime", value.ToString()); }
         }
      
         public float LightRadius
         {
         	get { return float.Parse(getFieldValue("LightRadius")); }
         	set { setFieldValue("LightRadius", value.ToString()); }
         }
      
         public bool LightOnlyStatic
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("LightOnlyStatic")); }
         	set { setFieldValue("LightOnlyStatic", value ? "1" : "0"); }
         }
      
         public bool SimpleServerCollision
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SimpleServerCollision")); }
         	set { setFieldValue("SimpleServerCollision", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}