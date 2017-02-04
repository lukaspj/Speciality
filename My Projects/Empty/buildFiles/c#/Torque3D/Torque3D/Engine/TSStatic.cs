using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class TSStatic : SceneObject
	{
		public TSStatic(bool pRegister = false)
			: base(pRegister)
		{
		}

		public TSStatic(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public TSStatic(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public TSStatic(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public TSStatic(SimObject pObj) : base(pObj)
		{
		}

		public TSStatic(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.TSStatic_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getTargetName(IntPtr thisPtr, int index);
         private static _getTargetName _getTargetNameFunc;
         internal static IntPtr getTargetName(IntPtr thisPtr, int index)
         {
         	if (_getTargetNameFunc == null)
         	{
         		_getTargetNameFunc =
         			(_getTargetName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSStatic_getTargetName"), typeof(_getTargetName));
         	}
         
         	return  _getTargetNameFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getTargetCount(IntPtr thisPtr);
         private static _getTargetCount _getTargetCountFunc;
         internal static int getTargetCount(IntPtr thisPtr)
         {
         	if (_getTargetCountFunc == null)
         	{
         		_getTargetCountFunc =
         			(_getTargetCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSStatic_getTargetCount"), typeof(_getTargetCount));
         	}
         
         	return  _getTargetCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _changeMaterial(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string mapTo, IntPtr oldMat, IntPtr newMat);
         private static _changeMaterial _changeMaterialFunc;
         internal static void changeMaterial(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string mapTo, IntPtr oldMat, IntPtr newMat)
         {
         	if (_changeMaterialFunc == null)
         	{
         		_changeMaterialFunc =
         			(_changeMaterial)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSStatic_changeMaterial"), typeof(_changeMaterial));
         	}
         
         	 _changeMaterialFunc(thisPtr, mapTo, oldMat, newMat);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getModelFile(IntPtr thisPtr);
         private static _getModelFile _getModelFileFunc;
         internal static IntPtr getModelFile(IntPtr thisPtr)
         {
         	if (_getModelFileFunc == null)
         	{
         		_getModelFileFunc =
         			(_getModelFile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSStatic_getModelFile"), typeof(_getModelFile));
         	}
         
         	return  _getModelFileFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TSStatic_create();
         private static _TSStatic_create _TSStatic_createFunc;
         internal static IntPtr TSStatic_create()
         {
         	if (_TSStatic_createFunc == null)
         	{
         		_TSStatic_createFunc =
         			(_TSStatic_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_TSStatic_create"), typeof(_TSStatic_create));
         	}
         
         	return  _TSStatic_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual string getTargetName(int index = 0)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getTargetName(ObjectPtr, index));
         }
      
         public virtual int getTargetCount()
         {
            return InternalUnsafeMethods.getTargetCount(ObjectPtr);
         }
      
         public virtual void changeMaterial(string mapTo = "", Material oldMat = null, Material newMat = null)
         {
            InternalUnsafeMethods.changeMaterial(ObjectPtr, mapTo, oldMat.ObjectPtr, newMat.ObjectPtr);
         }
      
         public virtual string getModelFile()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getModelFile(ObjectPtr));
         }
      
      
      #endregion


      #region Properties
      
      
         public string ShapeName
         {
         	get { return getFieldValue("ShapeName"); }
         	set { setFieldValue("ShapeName", value); }
         }
      
         public string Skin
         {
         	get { return getFieldValue("Skin"); }
         	set { setFieldValue("Skin", value); }
         }
      
         public bool PlayAmbient
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("PlayAmbient")); }
         	set { setFieldValue("PlayAmbient", value ? "1" : "0"); }
         }
      
         public bool MeshCulling
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("MeshCulling")); }
         	set { setFieldValue("MeshCulling", value ? "1" : "0"); }
         }
      
         public bool OriginSort
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OriginSort")); }
         	set { setFieldValue("OriginSort", value ? "1" : "0"); }
         }
      
         public string CubeReflectorDesc
         {
         	get { return getFieldValue("CubeReflectorDesc"); }
         	set { setFieldValue("CubeReflectorDesc", value); }
         }
      
         public TSMeshType CollisionType
         {
         	get { return (TSMeshType)Enum.Parse(typeof(TSMeshType), getFieldValue("CollisionType"), true); }
         	set { setFieldValue("CollisionType", value.ToString()); }
         }
      
         public TSMeshType DecalType
         {
         	get { return (TSMeshType)Enum.Parse(typeof(TSMeshType), getFieldValue("DecalType"), true); }
         	set { setFieldValue("DecalType", value.ToString()); }
         }
      
         public bool AllowPlayerStep
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowPlayerStep")); }
         	set { setFieldValue("AllowPlayerStep", value ? "1" : "0"); }
         }
      
         public bool AlphaFadeEnable
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AlphaFadeEnable")); }
         	set { setFieldValue("AlphaFadeEnable", value ? "1" : "0"); }
         }
      
         public float AlphaFadeStart
         {
         	get { return float.Parse(getFieldValue("AlphaFadeStart")); }
         	set { setFieldValue("AlphaFadeStart", value.ToString()); }
         }
      
         public float AlphaFadeEnd
         {
         	get { return float.Parse(getFieldValue("AlphaFadeEnd")); }
         	set { setFieldValue("AlphaFadeEnd", value.ToString()); }
         }
      
         public bool AlphaFadeInverse
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AlphaFadeInverse")); }
         	set { setFieldValue("AlphaFadeInverse", value ? "1" : "0"); }
         }
      
         public float RenderNormals
         {
         	get { return float.Parse(getFieldValue("RenderNormals")); }
         	set { setFieldValue("RenderNormals", value.ToString()); }
         }
      
         public int ForceDetail
         {
         	get { return int.Parse(getFieldValue("ForceDetail")); }
         	set { setFieldValue("ForceDetail", value.ToString()); }
         }
      
      
      #endregion

	}
}