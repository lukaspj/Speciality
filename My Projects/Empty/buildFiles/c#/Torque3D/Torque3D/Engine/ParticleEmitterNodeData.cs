using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ParticleEmitterNodeData : GameBaseData
	{
		public ParticleEmitterNodeData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ParticleEmitterNodeData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ParticleEmitterNodeData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ParticleEmitterNodeData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ParticleEmitterNodeData(SimObject pObj) : base(pObj)
		{
		}

		public ParticleEmitterNodeData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ParticleEmitterNodeData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ParticleEmitterNodeData_create();
         private static _ParticleEmitterNodeData_create _ParticleEmitterNodeData_createFunc;
         internal static IntPtr ParticleEmitterNodeData_create()
         {
         	if (_ParticleEmitterNodeData_createFunc == null)
         	{
         		_ParticleEmitterNodeData_createFunc =
         			(_ParticleEmitterNodeData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ParticleEmitterNodeData_create"), typeof(_ParticleEmitterNodeData_create));
         	}
         
         	return  _ParticleEmitterNodeData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float TimeMultiple
         {
         	get { return float.Parse(getFieldValue("TimeMultiple")); }
         	set { setFieldValue("TimeMultiple", value.ToString()); }
         }
      
      
      #endregion

	}
}