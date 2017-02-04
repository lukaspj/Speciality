using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ReflectorDesc : SimDataBlock
	{
		public ReflectorDesc(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ReflectorDesc(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ReflectorDesc(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ReflectorDesc(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ReflectorDesc(SimObject pObj) : base(pObj)
		{
		}

		public ReflectorDesc(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ReflectorDesc_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ReflectorDesc_create();
         private static _ReflectorDesc_create _ReflectorDesc_createFunc;
         internal static IntPtr ReflectorDesc_create()
         {
         	if (_ReflectorDesc_createFunc == null)
         	{
         		_ReflectorDesc_createFunc =
         			(_ReflectorDesc_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ReflectorDesc_create"), typeof(_ReflectorDesc_create));
         	}
         
         	return  _ReflectorDesc_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public int TexSize
         {
         	get { return int.Parse(getFieldValue("TexSize")); }
         	set { setFieldValue("TexSize", value.ToString()); }
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
      
         public int ObjectTypeMask
         {
         	get { return int.Parse(getFieldValue("ObjectTypeMask")); }
         	set { setFieldValue("ObjectTypeMask", value.ToString()); }
         }
      
         public float DetailAdjust
         {
         	get { return float.Parse(getFieldValue("DetailAdjust")); }
         	set { setFieldValue("DetailAdjust", value.ToString()); }
         }
      
         public float Priority
         {
         	get { return float.Parse(getFieldValue("Priority")); }
         	set { setFieldValue("Priority", value.ToString()); }
         }
      
         public int MaxRateMs
         {
         	get { return int.Parse(getFieldValue("MaxRateMs")); }
         	set { setFieldValue("MaxRateMs", value.ToString()); }
         }
      
         public bool UseOcclusionQuery
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseOcclusionQuery")); }
         	set { setFieldValue("UseOcclusionQuery", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}