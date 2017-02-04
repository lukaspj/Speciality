using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class PhysicalZone : SceneObject
	{
		public PhysicalZone(bool pRegister = false)
			: base(pRegister)
		{
		}

		public PhysicalZone(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public PhysicalZone(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public PhysicalZone(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public PhysicalZone(SimObject pObj) : base(pObj)
		{
		}

		public PhysicalZone(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.PhysicalZone_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _activate(IntPtr thisPtr);
         private static _activate _activateFunc;
         internal static void activate(IntPtr thisPtr)
         {
         	if (_activateFunc == null)
         	{
         		_activateFunc =
         			(_activate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPhysicalZone_activate"), typeof(_activate));
         	}
         
         	 _activateFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deactivate(IntPtr thisPtr);
         private static _deactivate _deactivateFunc;
         internal static void deactivate(IntPtr thisPtr)
         {
         	if (_deactivateFunc == null)
         	{
         		_deactivateFunc =
         			(_deactivate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPhysicalZone_deactivate"), typeof(_deactivate));
         	}
         
         	 _deactivateFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _PhysicalZone_create();
         private static _PhysicalZone_create _PhysicalZone_createFunc;
         internal static IntPtr PhysicalZone_create()
         {
         	if (_PhysicalZone_createFunc == null)
         	{
         		_PhysicalZone_createFunc =
         			(_PhysicalZone_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PhysicalZone_create"), typeof(_PhysicalZone_create));
         	}
         
         	return  _PhysicalZone_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void activate()
         {
            InternalUnsafeMethods.activate(ObjectPtr);
         }
      
         public virtual void deactivate()
         {
            InternalUnsafeMethods.deactivate(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public float VelocityMod
         {
         	get { return float.Parse(getFieldValue("VelocityMod")); }
         	set { setFieldValue("VelocityMod", value.ToString()); }
         }
      
         public float GravityMod
         {
         	get { return float.Parse(getFieldValue("GravityMod")); }
         	set { setFieldValue("GravityMod", value.ToString()); }
         }
      
         public Point3F AppliedForce
         {
         	get { return new Point3F(getFieldValue("AppliedForce")); }
         	set { setFieldValue("AppliedForce", value.ToString()); }
         }
      
         public string Polyhedron
         {
         	get { return getFieldValue("Polyhedron"); }
         	set { setFieldValue("Polyhedron", value); }
         }
      
      
      #endregion

	}
}