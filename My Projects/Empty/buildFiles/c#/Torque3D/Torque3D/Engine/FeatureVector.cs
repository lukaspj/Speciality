using System;
using System.Runtime.InteropServices;
using Torque3D.Engine;

namespace Torque3D
{
   public class FeatureVector : SimObject
   {
      protected override void CreateSimObjectPtr()
      {
         ObjectPtr = InternalUnsafeMethods.FeatureVector_create();
      }

      #region UnsafeNativeMethods

      internal new struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FeatureVector_create();

         private static _FeatureVector_create _FeatureVector_createFunc;

         internal static IntPtr FeatureVector_create()
         {
            if (_FeatureVector_createFunc == null)
               _FeatureVector_createFunc =
                  (_FeatureVector_create)
                  Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
                     "fn_FeatureVector_create"), typeof(_FeatureVector_create));

            return _FeatureVector_createFunc();
         }
      }

      #endregion

      #region Constructors

      public FeatureVector(bool pRegister = false)
         : base(pRegister)
      {
      }

      public FeatureVector(string pName, bool pRegister = false)
         : this(false)
      {
         Name = pName;
         if (pRegister) registerObject();
      }

      public FeatureVector(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
      {
         CopyFrom(Sim.FindObject<SimObject>(pParent));
      }

      public FeatureVector(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
      {
         CopyFrom(pParent);
      }

      public FeatureVector(SimObject pObj) : base(pObj)
      {
      }

      public FeatureVector(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      #endregion

      #region Functions

      #endregion

      #region Properties

      public float DeltaRot
      {
         get { return float.Parse(getFieldValue("DeltaRot")); }
         set { setFieldValue("DeltaRot", value.ToString()); }
      }

      public float DeltaMovedX
      {
         get { return float.Parse(getFieldValue("DeltaMovedX")); }
         set { setFieldValue("DeltaMovedX", value.ToString()); }
      }

      public float DeltaMovedY
      {
         get { return float.Parse(getFieldValue("DeltaMovedY")); }
         set { setFieldValue("DeltaMovedY", value.ToString()); }
      }

      public float VelX
      {
         get { return float.Parse(getFieldValue("VelX")); }
         set { setFieldValue("VelX", value.ToString()); }
      }

      public float VelY
      {
         get { return float.Parse(getFieldValue("VelY")); }
         set { setFieldValue("VelY", value.ToString()); }
      }

      public float KillProb
      {
         get { return float.Parse(getFieldValue("KillProb")); }
         set { setFieldValue("KillProb", value.ToString()); }
      }

      public float DistanceToObstacle
      {
         get { return float.Parse(getFieldValue("DistanceToObstacle")); }
         set { setFieldValue("DistanceToObstacle", value.ToString()); }
      }

      public float Health
      {
         get { return float.Parse(getFieldValue("Health")); }
         set { setFieldValue("Health", value.ToString()); }
      }

      public int TickCount
      {
         get { return int.Parse(getFieldValue("TickCount")); }
         set { setFieldValue("TickCount", value.ToString()); }
      }

      public int TicksSinceObservedEnemy
      {
         get { return int.Parse(getFieldValue("TicksSinceObservedEnemy")); }
         set { setFieldValue("TicksSinceObservedEnemy", value.ToString()); }
      }

      public int TicksSinceDamage
      {
         get { return int.Parse(getFieldValue("TicksSinceDamage")); }
         set { setFieldValue("TicksSinceDamage", value.ToString()); }
      }

      public int ShootDelay
      {
         get { return int.Parse(getFieldValue("ShootDelay")); }
         set { setFieldValue("ShootDelay", value.ToString()); }
      }

      #endregion
   }
}