using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SimplePlayerData : ShapeBaseData
	{
		public SimplePlayerData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SimplePlayerData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SimplePlayerData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SimplePlayerData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SimplePlayerData(SimObject pObj) : base(pObj)
		{
		}

		public SimplePlayerData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SimplePlayerData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimplePlayerData_create();
         private static _SimplePlayerData_create _SimplePlayerData_createFunc;
         internal static IntPtr SimplePlayerData_create()
         {
         	if (_SimplePlayerData_createFunc == null)
         	{
               _SimplePlayerData_createFunc =
         			(_SimplePlayerData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
                     "fn_SimplePlayerData_create"), typeof(_SimplePlayerData_create));
         	}
         
         	return _SimplePlayerData_createFunc();
         }
      
      }

      #endregion


      #region Functions


      #endregion


      #region Properties

      public float MoveSpeed
      {
         get { return float.Parse(getFieldValue("MoveSpeed")); }
         set { setFieldValue("MoveSpeed", value.ToString()); }
      }

      public float TurnSpeed
      {
         get { return float.Parse(getFieldValue("TurnSpeed")); }
         set { setFieldValue("TurnSpeed", value.ToString()); }
      }

      public float Friction
      {
         get { return float.Parse(getFieldValue("Friction")); }
         set { setFieldValue("Friction", value.ToString()); }
      }

      public float FOV
      {
         get { return float.Parse(getFieldValue("FOV")); }
         set { setFieldValue("FOV", value.ToString()); }
      }

      public float AspectRatio
      {
         get { return float.Parse(getFieldValue("AspectRatio")); }
         set { setFieldValue("AspectRatio", value.ToString()); }
      }

      public float NearDist
      {
         get { return float.Parse(getFieldValue("NearDist")); }
         set { setFieldValue("NearDist", value.ToString()); }
      }

      public float FarDist
      {
         get { return float.Parse(getFieldValue("FarDist")); }
         set { setFieldValue("FarDist", value.ToString()); }
      }
      
      public float Health
      {
         get { return float.Parse(getFieldValue("Health")); }
         set { setFieldValue("Health", value.ToString()); }
      }

      #endregion

   }
}