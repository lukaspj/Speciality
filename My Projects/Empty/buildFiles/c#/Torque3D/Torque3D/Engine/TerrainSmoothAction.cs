using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class TerrainSmoothAction : UndoAction
	{
		public TerrainSmoothAction(bool pRegister = false)
			: base(pRegister)
		{
		}

		public TerrainSmoothAction(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public TerrainSmoothAction(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public TerrainSmoothAction(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public TerrainSmoothAction(SimObject pObj) : base(pObj)
		{
		}

		public TerrainSmoothAction(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.TerrainSmoothAction_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _smooth(IntPtr thisPtr, IntPtr terrain, float factor, uint steps);
         private static _smooth _smoothFunc;
         internal static void smooth(IntPtr thisPtr, IntPtr terrain, float factor, uint steps)
         {
         	if (_smoothFunc == null)
         	{
         		_smoothFunc =
         			(_smooth)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainSmoothAction_smooth"), typeof(_smooth));
         	}
         
         	 _smoothFunc(thisPtr, terrain, factor, steps);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TerrainSmoothAction_create();
         private static _TerrainSmoothAction_create _TerrainSmoothAction_createFunc;
         internal static IntPtr TerrainSmoothAction_create()
         {
         	if (_TerrainSmoothAction_createFunc == null)
         	{
         		_TerrainSmoothAction_createFunc =
         			(_TerrainSmoothAction_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_TerrainSmoothAction_create"), typeof(_TerrainSmoothAction_create));
         	}
         
         	return  _TerrainSmoothAction_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void smooth(TerrainBlock terrain, float factor, uint steps)
         {
            InternalUnsafeMethods.smooth(ObjectPtr, terrain.ObjectPtr, factor, steps);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}