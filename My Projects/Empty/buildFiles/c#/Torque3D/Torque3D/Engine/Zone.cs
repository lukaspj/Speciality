using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class Zone : SceneObject
	{
		public Zone(bool pRegister = false)
			: base(pRegister)
		{
		}

		public Zone(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public Zone(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public Zone(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public Zone(SimObject pObj) : base(pObj)
		{
		}

		public Zone(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Zone_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getZoneId(IntPtr thisPtr);
         private static _getZoneId _getZoneIdFunc;
         internal static int getZoneId(IntPtr thisPtr)
         {
         	if (_getZoneIdFunc == null)
         	{
         		_getZoneIdFunc =
         			(_getZoneId)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnZone_getZoneId"), typeof(_getZoneId));
         	}
         
         	return  _getZoneIdFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dumpZoneState(IntPtr thisPtr, bool updateFirst);
         private static _dumpZoneState _dumpZoneStateFunc;
         internal static void dumpZoneState(IntPtr thisPtr, bool updateFirst)
         {
         	if (_dumpZoneStateFunc == null)
         	{
         		_dumpZoneStateFunc =
         			(_dumpZoneState)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnZone_dumpZoneState"), typeof(_dumpZoneState));
         	}
         
         	 _dumpZoneStateFunc(thisPtr, updateFirst);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Zone_create();
         private static _Zone_create _Zone_createFunc;
         internal static IntPtr Zone_create()
         {
         	if (_Zone_createFunc == null)
         	{
         		_Zone_createFunc =
         			(_Zone_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Zone_create"), typeof(_Zone_create));
         	}
         
         	return  _Zone_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int getZoneId()
         {
            return InternalUnsafeMethods.getZoneId(ObjectPtr);
         }
      
         public virtual void dumpZoneState(bool updateFirst = true)
         {
            InternalUnsafeMethods.dumpZoneState(ObjectPtr, updateFirst);
         }
      
      
      #endregion


      #region Properties
      
      
         public SFXAmbience SoundAmbience
         {
         	get { return Sim.FindObject<SFXAmbience>(getFieldValue("SoundAmbience")); }
         	set { setFieldValue("SoundAmbience", value.getId().ToString()); }
         }
      
         public string Plane
         {
         	get { return getFieldValue("Plane"); }
         	set { setFieldValue("Plane", value); }
         }
      
         public string Point
         {
         	get { return getFieldValue("Point"); }
         	set { setFieldValue("Point", value); }
         }
      
         public string Edge
         {
         	get { return getFieldValue("Edge"); }
         	set { setFieldValue("Edge", value); }
         }
      
         public bool UseAmbientLightColor
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseAmbientLightColor")); }
         	set { setFieldValue("UseAmbientLightColor", value ? "1" : "0"); }
         }
      
         public ColorF AmbientLightColor
         {
         	get { return new ColorF(getFieldValue("AmbientLightColor")); }
         	set { setFieldValue("AmbientLightColor", value.ToString()); }
         }
      
         public int ZoneGroup
         {
         	get { return int.Parse(getFieldValue("ZoneGroup")); }
         	set { setFieldValue("ZoneGroup", value.ToString()); }
         }
      
      
      #endregion

	}
}