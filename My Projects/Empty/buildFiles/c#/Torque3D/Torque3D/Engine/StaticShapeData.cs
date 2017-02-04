using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class StaticShapeData : ShapeBaseData
	{
		public StaticShapeData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public StaticShapeData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public StaticShapeData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public StaticShapeData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public StaticShapeData(SimObject pObj) : base(pObj)
		{
		}

		public StaticShapeData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.StaticShapeData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _StaticShapeData_create();
         private static _StaticShapeData_create _StaticShapeData_createFunc;
         internal static IntPtr StaticShapeData_create()
         {
         	if (_StaticShapeData_createFunc == null)
         	{
         		_StaticShapeData_createFunc =
         			(_StaticShapeData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_StaticShapeData_create"), typeof(_StaticShapeData_create));
         	}
         
         	return  _StaticShapeData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public bool NoIndividualDamage
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("NoIndividualDamage")); }
         	set { setFieldValue("NoIndividualDamage", value ? "1" : "0"); }
         }
      
         public int DynamicType
         {
         	get { return int.Parse(getFieldValue("DynamicType")); }
         	set { setFieldValue("DynamicType", value.ToString()); }
         }
      
      
      #endregion

	}
}