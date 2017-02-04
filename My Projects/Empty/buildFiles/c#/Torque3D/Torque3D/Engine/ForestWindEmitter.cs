using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ForestWindEmitter : SceneObject
	{
		public ForestWindEmitter(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ForestWindEmitter(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ForestWindEmitter(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ForestWindEmitter(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ForestWindEmitter(SimObject pObj) : base(pObj)
		{
		}

		public ForestWindEmitter(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ForestWindEmitter_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _attachToObject(IntPtr thisPtr, uint objectID);
         private static _attachToObject _attachToObjectFunc;
         internal static void attachToObject(IntPtr thisPtr, uint objectID)
         {
         	if (_attachToObjectFunc == null)
         	{
         		_attachToObjectFunc =
         			(_attachToObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnForestWindEmitter_attachToObject"), typeof(_attachToObject));
         	}
         
         	 _attachToObjectFunc(thisPtr, objectID);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ForestWindEmitter_create();
         private static _ForestWindEmitter_create _ForestWindEmitter_createFunc;
         internal static IntPtr ForestWindEmitter_create()
         {
         	if (_ForestWindEmitter_createFunc == null)
         	{
         		_ForestWindEmitter_createFunc =
         			(_ForestWindEmitter_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ForestWindEmitter_create"), typeof(_ForestWindEmitter_create));
         	}
         
         	return  _ForestWindEmitter_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void attachToObject(uint objectID)
         {
            InternalUnsafeMethods.attachToObject(ObjectPtr, objectID);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool WindEnabled
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("WindEnabled")); }
         	set { setFieldValue("WindEnabled", value ? "1" : "0"); }
         }
      
         public bool RadialEmitter
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RadialEmitter")); }
         	set { setFieldValue("RadialEmitter", value ? "1" : "0"); }
         }
      
         public float Strength
         {
         	get { return float.Parse(getFieldValue("Strength")); }
         	set { setFieldValue("Strength", value.ToString()); }
         }
      
         public float Radius
         {
         	get { return float.Parse(getFieldValue("Radius")); }
         	set { setFieldValue("Radius", value.ToString()); }
         }
      
         public float GustStrength
         {
         	get { return float.Parse(getFieldValue("GustStrength")); }
         	set { setFieldValue("GustStrength", value.ToString()); }
         }
      
         public float GustFrequency
         {
         	get { return float.Parse(getFieldValue("GustFrequency")); }
         	set { setFieldValue("GustFrequency", value.ToString()); }
         }
      
         public float GustYawAngle
         {
         	get { return float.Parse(getFieldValue("GustYawAngle")); }
         	set { setFieldValue("GustYawAngle", value.ToString()); }
         }
      
         public float GustYawFrequency
         {
         	get { return float.Parse(getFieldValue("GustYawFrequency")); }
         	set { setFieldValue("GustYawFrequency", value.ToString()); }
         }
      
         public float GustWobbleStrength
         {
         	get { return float.Parse(getFieldValue("GustWobbleStrength")); }
         	set { setFieldValue("GustWobbleStrength", value.ToString()); }
         }
      
         public float TurbulenceStrength
         {
         	get { return float.Parse(getFieldValue("TurbulenceStrength")); }
         	set { setFieldValue("TurbulenceStrength", value.ToString()); }
         }
      
         public float TurbulenceFrequency
         {
         	get { return float.Parse(getFieldValue("TurbulenceFrequency")); }
         	set { setFieldValue("TurbulenceFrequency", value.ToString()); }
         }
      
         public bool HasMount
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("HasMount")); }
         	set { setFieldValue("HasMount", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}