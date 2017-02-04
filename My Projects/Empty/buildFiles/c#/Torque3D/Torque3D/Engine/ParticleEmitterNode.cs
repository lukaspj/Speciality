using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ParticleEmitterNode : GameBase
	{
		public ParticleEmitterNode(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ParticleEmitterNode(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ParticleEmitterNode(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ParticleEmitterNode(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ParticleEmitterNode(SimObject pObj) : base(pObj)
		{
		}

		public ParticleEmitterNode(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ParticleEmitterNode_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setEmitterDataBlock(IntPtr thisPtr, IntPtr emitterDatablock);
         private static _setEmitterDataBlock _setEmitterDataBlockFunc;
         internal static void setEmitterDataBlock(IntPtr thisPtr, IntPtr emitterDatablock)
         {
         	if (_setEmitterDataBlockFunc == null)
         	{
         		_setEmitterDataBlockFunc =
         			(_setEmitterDataBlock)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnParticleEmitterNode_setEmitterDataBlock"), typeof(_setEmitterDataBlock));
         	}
         
         	 _setEmitterDataBlockFunc(thisPtr, emitterDatablock);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setActive(IntPtr thisPtr, bool active);
         private static _setActive _setActiveFunc;
         internal static void setActive(IntPtr thisPtr, bool active)
         {
         	if (_setActiveFunc == null)
         	{
         		_setActiveFunc =
         			(_setActive)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnParticleEmitterNode_setActive"), typeof(_setActive));
         	}
         
         	 _setActiveFunc(thisPtr, active);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ParticleEmitterNode_create();
         private static _ParticleEmitterNode_create _ParticleEmitterNode_createFunc;
         internal static IntPtr ParticleEmitterNode_create()
         {
         	if (_ParticleEmitterNode_createFunc == null)
         	{
         		_ParticleEmitterNode_createFunc =
         			(_ParticleEmitterNode_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ParticleEmitterNode_create"), typeof(_ParticleEmitterNode_create));
         	}
         
         	return  _ParticleEmitterNode_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setEmitterDataBlock(ParticleEmitterData emitterDatablock = null)
         {
            InternalUnsafeMethods.setEmitterDataBlock(ObjectPtr, emitterDatablock.ObjectPtr);
         }
      
         public virtual void setActive(bool active)
         {
            InternalUnsafeMethods.setActive(ObjectPtr, active);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool Active
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Active")); }
         	set { setFieldValue("Active", value ? "1" : "0"); }
         }
      
         public ParticleEmitterData Emitter
         {
         	get { return Sim.FindObject<ParticleEmitterData>(getFieldValue("Emitter")); }
         	set { setFieldValue("Emitter", value.getId().ToString()); }
         }
      
         public float Velocity
         {
         	get { return float.Parse(getFieldValue("Velocity")); }
         	set { setFieldValue("Velocity", value.ToString()); }
         }
      
      
      #endregion

	}
}