using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class AccumulationVolume : SceneObject
	{
		public AccumulationVolume(bool pRegister = false)
			: base(pRegister)
		{
		}

		public AccumulationVolume(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public AccumulationVolume(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public AccumulationVolume(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public AccumulationVolume(SimObject pObj) : base(pObj)
		{
		}

		public AccumulationVolume(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.AccumulationVolume_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AccumulationVolume_create();
         private static _AccumulationVolume_create _AccumulationVolume_createFunc;
         internal static IntPtr AccumulationVolume_create()
         {
         	if (_AccumulationVolume_createFunc == null)
         	{
         		_AccumulationVolume_createFunc =
         			(_AccumulationVolume_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AccumulationVolume_create"), typeof(_AccumulationVolume_create));
         	}
         
         	return  _AccumulationVolume_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string Texture
         {
         	get { return getFieldValue("Texture"); }
         	set { setFieldValue("Texture", value); }
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
      
      
      #endregion

	}
}