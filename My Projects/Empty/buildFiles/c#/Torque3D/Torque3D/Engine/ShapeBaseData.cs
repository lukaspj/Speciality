using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ShapeBaseData : GameBaseData
	{
		public ShapeBaseData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ShapeBaseData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ShapeBaseData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ShapeBaseData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ShapeBaseData(SimObject pObj) : base(pObj)
		{
		}

		public ShapeBaseData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ShapeBaseData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _checkDeployPos(IntPtr thisPtr, InternalTransformFStruct txfm);
         private static _checkDeployPos _checkDeployPosFunc;
         internal static bool checkDeployPos(IntPtr thisPtr, InternalTransformFStruct txfm)
         {
         	if (_checkDeployPosFunc == null)
         	{
         		_checkDeployPosFunc =
         			(_checkDeployPos)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBaseData_checkDeployPos"), typeof(_checkDeployPos));
         	}
         
         	return  _checkDeployPosFunc(thisPtr, txfm);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalTransformFStruct _getDeployTransform(IntPtr thisPtr, InternalPoint3FStruct pos, InternalPoint3FStruct normal);
         private static _getDeployTransform _getDeployTransformFunc;
         internal static InternalTransformFStruct getDeployTransform(IntPtr thisPtr, InternalPoint3FStruct pos, InternalPoint3FStruct normal)
         {
         	if (_getDeployTransformFunc == null)
         	{
         		_getDeployTransformFunc =
         			(_getDeployTransform)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnShapeBaseData_getDeployTransform"), typeof(_getDeployTransform));
         	}
         
         	return  _getDeployTransformFunc(thisPtr, pos, normal);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ShapeBaseData_create();
         private static _ShapeBaseData_create _ShapeBaseData_createFunc;
         internal static IntPtr ShapeBaseData_create()
         {
         	if (_ShapeBaseData_createFunc == null)
         	{
         		_ShapeBaseData_createFunc =
         			(_ShapeBaseData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ShapeBaseData_create"), typeof(_ShapeBaseData_create));
         	}
         
         	return  _ShapeBaseData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool checkDeployPos(TransformF txfm)
         {
            return InternalUnsafeMethods.checkDeployPos(ObjectPtr, txfm.ToStruct());
         }
      
         public virtual TransformF getDeployTransform(Point3F pos, Point3F normal)
         {
            return new TransformF(InternalUnsafeMethods.getDeployTransform(ObjectPtr, pos.ToStruct(), normal.ToStruct()));
         }
      
      
      #endregion


      #region Properties
      
      
         public bool ShadowEnable
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShadowEnable")); }
         	set { setFieldValue("ShadowEnable", value ? "1" : "0"); }
         }
      
         public int ShadowSize
         {
         	get { return int.Parse(getFieldValue("ShadowSize")); }
         	set { setFieldValue("ShadowSize", value.ToString()); }
         }
      
         public float ShadowMaxVisibleDistance
         {
         	get { return float.Parse(getFieldValue("ShadowMaxVisibleDistance")); }
         	set { setFieldValue("ShadowMaxVisibleDistance", value.ToString()); }
         }
      
         public float ShadowProjectionDistance
         {
         	get { return float.Parse(getFieldValue("ShadowProjectionDistance")); }
         	set { setFieldValue("ShadowProjectionDistance", value.ToString()); }
         }
      
         public float ShadowSphereAdjust
         {
         	get { return float.Parse(getFieldValue("ShadowSphereAdjust")); }
         	set { setFieldValue("ShadowSphereAdjust", value.ToString()); }
         }
      
         public string ShapeFile
         {
         	get { return getFieldValue("ShapeFile"); }
         	set { setFieldValue("ShapeFile", value); }
         }
      
         public ExplosionData Explosion
         {
         	get { return Sim.FindObject<ExplosionData>(getFieldValue("Explosion")); }
         	set { setFieldValue("Explosion", value.getId().ToString()); }
         }
      
         public ExplosionData UnderwaterExplosion
         {
         	get { return Sim.FindObject<ExplosionData>(getFieldValue("UnderwaterExplosion")); }
         	set { setFieldValue("UnderwaterExplosion", value.getId().ToString()); }
         }
      
         public DebrisData Debris
         {
         	get { return Sim.FindObject<DebrisData>(getFieldValue("Debris")); }
         	set { setFieldValue("Debris", value.getId().ToString()); }
         }
      
         public bool RenderWhenDestroyed
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderWhenDestroyed")); }
         	set { setFieldValue("RenderWhenDestroyed", value ? "1" : "0"); }
         }
      
         public string DebrisShapeName
         {
         	get { return getFieldValue("DebrisShapeName"); }
         	set { setFieldValue("DebrisShapeName", value); }
         }
      
         public float Mass
         {
         	get { return float.Parse(getFieldValue("Mass")); }
         	set { setFieldValue("Mass", value.ToString()); }
         }
      
         public float Drag
         {
         	get { return float.Parse(getFieldValue("Drag")); }
         	set { setFieldValue("Drag", value.ToString()); }
         }
      
         public float Density
         {
         	get { return float.Parse(getFieldValue("Density")); }
         	set { setFieldValue("Density", value.ToString()); }
         }
      
         public float MaxEnergy
         {
         	get { return float.Parse(getFieldValue("MaxEnergy")); }
         	set { setFieldValue("MaxEnergy", value.ToString()); }
         }
      
         public float MaxDamage
         {
         	get { return float.Parse(getFieldValue("MaxDamage")); }
         	set { setFieldValue("MaxDamage", value.ToString()); }
         }
      
         public float DisabledLevel
         {
         	get { return float.Parse(getFieldValue("DisabledLevel")); }
         	set { setFieldValue("DisabledLevel", value.ToString()); }
         }
      
         public float DestroyedLevel
         {
         	get { return float.Parse(getFieldValue("DestroyedLevel")); }
         	set { setFieldValue("DestroyedLevel", value.ToString()); }
         }
      
         public float RepairRate
         {
         	get { return float.Parse(getFieldValue("RepairRate")); }
         	set { setFieldValue("RepairRate", value.ToString()); }
         }
      
         public bool InheritEnergyFromMount
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("InheritEnergyFromMount")); }
         	set { setFieldValue("InheritEnergyFromMount", value ? "1" : "0"); }
         }
      
         public bool IsInvincible
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsInvincible")); }
         	set { setFieldValue("IsInvincible", value ? "1" : "0"); }
         }
      
         public float CameraMaxDist
         {
         	get { return float.Parse(getFieldValue("CameraMaxDist")); }
         	set { setFieldValue("CameraMaxDist", value.ToString()); }
         }
      
         public float CameraMinDist
         {
         	get { return float.Parse(getFieldValue("CameraMinDist")); }
         	set { setFieldValue("CameraMinDist", value.ToString()); }
         }
      
         public float CameraDefaultFov
         {
         	get { return float.Parse(getFieldValue("CameraDefaultFov")); }
         	set { setFieldValue("CameraDefaultFov", value.ToString()); }
         }
      
         public float CameraMinFov
         {
         	get { return float.Parse(getFieldValue("CameraMinFov")); }
         	set { setFieldValue("CameraMinFov", value.ToString()); }
         }
      
         public float CameraMaxFov
         {
         	get { return float.Parse(getFieldValue("CameraMaxFov")); }
         	set { setFieldValue("CameraMaxFov", value.ToString()); }
         }
      
         public bool CameraCanBank
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CameraCanBank")); }
         	set { setFieldValue("CameraCanBank", value ? "1" : "0"); }
         }
      
         public bool MountedImagesBank
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("MountedImagesBank")); }
         	set { setFieldValue("MountedImagesBank", value ? "1" : "0"); }
         }
      
         public bool FirstPersonOnly
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FirstPersonOnly")); }
         	set { setFieldValue("FirstPersonOnly", value ? "1" : "0"); }
         }
      
         public bool UseEyePoint
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseEyePoint")); }
         	set { setFieldValue("UseEyePoint", value ? "1" : "0"); }
         }
      
         public bool ObserveThroughObject
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ObserveThroughObject")); }
         	set { setFieldValue("ObserveThroughObject", value ? "1" : "0"); }
         }
      
         public bool ComputeCRC
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ComputeCRC")); }
         	set { setFieldValue("ComputeCRC", value ? "1" : "0"); }
         }
      
         public string CubeReflectorDesc
         {
         	get { return getFieldValue("CubeReflectorDesc"); }
         	set { setFieldValue("CubeReflectorDesc", value); }
         }
      
      
      #endregion

	}
}