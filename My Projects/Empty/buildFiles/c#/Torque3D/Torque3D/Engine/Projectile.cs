using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class Projectile : GameBase
	{
		public Projectile(bool pRegister = false)
			: base(pRegister)
		{
		}

		public Projectile(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public Projectile(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public Projectile(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public Projectile(SimObject pObj) : base(pObj)
		{
		}

		public Projectile(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Projectile_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _presimulate(IntPtr thisPtr, float seconds);
         private static _presimulate _presimulateFunc;
         internal static void presimulate(IntPtr thisPtr, float seconds)
         {
         	if (_presimulateFunc == null)
         	{
         		_presimulateFunc =
         			(_presimulate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnProjectile_presimulate"), typeof(_presimulate));
         	}
         
         	 _presimulateFunc(thisPtr, seconds);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Projectile_create();
         private static _Projectile_create _Projectile_createFunc;
         internal static IntPtr Projectile_create()
         {
         	if (_Projectile_createFunc == null)
         	{
         		_Projectile_createFunc =
         			(_Projectile_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Projectile_create"), typeof(_Projectile_create));
         	}
         
         	return  _Projectile_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void presimulate(float seconds = 1.0f)
         {
            InternalUnsafeMethods.presimulate(ObjectPtr, seconds);
         }
      
      
      #endregion


      #region Properties
      
      
         public Point3F InitialPosition
         {
         	get { return new Point3F(getFieldValue("InitialPosition")); }
         	set { setFieldValue("InitialPosition", value.ToString()); }
         }
      
         public Point3F InitialVelocity
         {
         	get { return new Point3F(getFieldValue("InitialVelocity")); }
         	set { setFieldValue("InitialVelocity", value.ToString()); }
         }
      
         public int SourceObject
         {
         	get { return int.Parse(getFieldValue("SourceObject")); }
         	set { setFieldValue("SourceObject", value.ToString()); }
         }
      
         public int SourceSlot
         {
         	get { return int.Parse(getFieldValue("SourceSlot")); }
         	set { setFieldValue("SourceSlot", value.ToString()); }
         }
      
      
      #endregion

	}
}