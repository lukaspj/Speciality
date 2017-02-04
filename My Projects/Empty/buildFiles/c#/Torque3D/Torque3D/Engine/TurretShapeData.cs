using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class TurretShapeData : ItemData
	{
		public TurretShapeData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public TurretShapeData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public TurretShapeData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public TurretShapeData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public TurretShapeData(SimObject pObj) : base(pObj)
		{
		}

		public TurretShapeData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.TurretShapeData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TurretShapeData_create();
         private static _TurretShapeData_create _TurretShapeData_createFunc;
         internal static IntPtr TurretShapeData_create()
         {
         	if (_TurretShapeData_createFunc == null)
         	{
         		_TurretShapeData_createFunc =
         			(_TurretShapeData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_TurretShapeData_create"), typeof(_TurretShapeData_create));
         	}
         
         	return  _TurretShapeData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public bool ZRotOnly
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ZRotOnly")); }
         	set { setFieldValue("ZRotOnly", value ? "1" : "0"); }
         }
      
         public TurretShapeFireLinkType WeaponLinkType
         {
         	get { return (TurretShapeFireLinkType)Enum.Parse(typeof(TurretShapeFireLinkType), getFieldValue("WeaponLinkType"), true); }
         	set { setFieldValue("WeaponLinkType", value.ToString()); }
         }
      
         public bool StartLoaded
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("StartLoaded")); }
         	set { setFieldValue("StartLoaded", value ? "1" : "0"); }
         }
      
         public float CameraOffset
         {
         	get { return float.Parse(getFieldValue("CameraOffset")); }
         	set { setFieldValue("CameraOffset", value.ToString()); }
         }
      
         public float MaxHeading
         {
         	get { return float.Parse(getFieldValue("MaxHeading")); }
         	set { setFieldValue("MaxHeading", value.ToString()); }
         }
      
         public float MinPitch
         {
         	get { return float.Parse(getFieldValue("MinPitch")); }
         	set { setFieldValue("MinPitch", value.ToString()); }
         }
      
         public float MaxPitch
         {
         	get { return float.Parse(getFieldValue("MaxPitch")); }
         	set { setFieldValue("MaxPitch", value.ToString()); }
         }
      
         public float HeadingRate
         {
         	get { return float.Parse(getFieldValue("HeadingRate")); }
         	set { setFieldValue("HeadingRate", value.ToString()); }
         }
      
         public float PitchRate
         {
         	get { return float.Parse(getFieldValue("PitchRate")); }
         	set { setFieldValue("PitchRate", value.ToString()); }
         }
      
      
      #endregion

	}
}