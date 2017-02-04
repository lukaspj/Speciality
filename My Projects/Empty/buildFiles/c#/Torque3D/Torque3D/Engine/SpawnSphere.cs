using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SpawnSphere : MissionMarker
	{
		public SpawnSphere(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SpawnSphere(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SpawnSphere(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SpawnSphere(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SpawnSphere(SimObject pObj) : base(pObj)
		{
		}

		public SpawnSphere(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SpawnSphere_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _spawnObject(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string additionalProps);
         private static _spawnObject _spawnObjectFunc;
         internal static int spawnObject(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string additionalProps)
         {
         	if (_spawnObjectFunc == null)
         	{
         		_spawnObjectFunc =
         			(_spawnObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSpawnSphere_spawnObject"), typeof(_spawnObject));
         	}
         
         	return  _spawnObjectFunc(thisPtr, additionalProps);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SpawnSphere_create();
         private static _SpawnSphere_create _SpawnSphere_createFunc;
         internal static IntPtr SpawnSphere_create()
         {
         	if (_SpawnSphere_createFunc == null)
         	{
         		_SpawnSphere_createFunc =
         			(_SpawnSphere_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SpawnSphere_create"), typeof(_SpawnSphere_create));
         	}
         
         	return  _SpawnSphere_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int spawnObject(string additionalProps)
         {
            return InternalUnsafeMethods.spawnObject(ObjectPtr, additionalProps);
         }
      
      
      #endregion


      #region Properties
      
      
         public string SpawnClass
         {
         	get { return getFieldValue("SpawnClass"); }
         	set { setFieldValue("SpawnClass", value); }
         }
      
         public string SpawnDatablock
         {
         	get { return getFieldValue("SpawnDatablock"); }
         	set { setFieldValue("SpawnDatablock", value); }
         }
      
         public string SpawnProperties
         {
         	get { return getFieldValue("SpawnProperties"); }
         	set { setFieldValue("SpawnProperties", value); }
         }
      
         public string SpawnScript
         {
         	get { return getFieldValue("SpawnScript"); }
         	set { setFieldValue("SpawnScript", value); }
         }
      
         public bool AutoSpawn
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AutoSpawn")); }
         	set { setFieldValue("AutoSpawn", value ? "1" : "0"); }
         }
      
         public bool SpawnTransform
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SpawnTransform")); }
         	set { setFieldValue("SpawnTransform", value ? "1" : "0"); }
         }
      
         public float Radius
         {
         	get { return float.Parse(getFieldValue("Radius")); }
         	set { setFieldValue("Radius", value.ToString()); }
         }
      
         public float SphereWeight
         {
         	get { return float.Parse(getFieldValue("SphereWeight")); }
         	set { setFieldValue("SphereWeight", value.ToString()); }
         }
      
         public float IndoorWeight
         {
         	get { return float.Parse(getFieldValue("IndoorWeight")); }
         	set { setFieldValue("IndoorWeight", value.ToString()); }
         }
      
         public float OutdoorWeight
         {
         	get { return float.Parse(getFieldValue("OutdoorWeight")); }
         	set { setFieldValue("OutdoorWeight", value.ToString()); }
         }
      
      
      #endregion

	}
}