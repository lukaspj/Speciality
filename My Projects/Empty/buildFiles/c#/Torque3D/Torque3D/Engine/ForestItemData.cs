using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ForestItemData : SimDataBlock
	{
		public ForestItemData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ForestItemData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ForestItemData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ForestItemData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ForestItemData(SimObject pObj) : base(pObj)
		{
		}

		public ForestItemData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ForestItemData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ForestItemData_create();
         private static _ForestItemData_create _ForestItemData_createFunc;
         internal static IntPtr ForestItemData_create()
         {
         	if (_ForestItemData_createFunc == null)
         	{
         		_ForestItemData_createFunc =
         			(_ForestItemData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ForestItemData_create"), typeof(_ForestItemData_create));
         	}
         
         	return  _ForestItemData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string ShapeFile
         {
         	get { return getFieldValue("ShapeFile"); }
         	set { setFieldValue("ShapeFile", value); }
         }
      
         public bool Collidable
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Collidable")); }
         	set { setFieldValue("Collidable", value ? "1" : "0"); }
         }
      
         public float Radius
         {
         	get { return float.Parse(getFieldValue("Radius")); }
         	set { setFieldValue("Radius", value.ToString()); }
         }
      
         public float Mass
         {
         	get { return float.Parse(getFieldValue("Mass")); }
         	set { setFieldValue("Mass", value.ToString()); }
         }
      
         public float Rigidity
         {
         	get { return float.Parse(getFieldValue("Rigidity")); }
         	set { setFieldValue("Rigidity", value.ToString()); }
         }
      
         public float TightnessCoefficient
         {
         	get { return float.Parse(getFieldValue("TightnessCoefficient")); }
         	set { setFieldValue("TightnessCoefficient", value.ToString()); }
         }
      
         public float DampingCoefficient
         {
         	get { return float.Parse(getFieldValue("DampingCoefficient")); }
         	set { setFieldValue("DampingCoefficient", value.ToString()); }
         }
      
         public float WindScale
         {
         	get { return float.Parse(getFieldValue("WindScale")); }
         	set { setFieldValue("WindScale", value.ToString()); }
         }
      
         public float TrunkBendScale
         {
         	get { return float.Parse(getFieldValue("TrunkBendScale")); }
         	set { setFieldValue("TrunkBendScale", value.ToString()); }
         }
      
         public float BranchAmp
         {
         	get { return float.Parse(getFieldValue("BranchAmp")); }
         	set { setFieldValue("BranchAmp", value.ToString()); }
         }
      
         public float DetailAmp
         {
         	get { return float.Parse(getFieldValue("DetailAmp")); }
         	set { setFieldValue("DetailAmp", value.ToString()); }
         }
      
         public float DetailFreq
         {
         	get { return float.Parse(getFieldValue("DetailFreq")); }
         	set { setFieldValue("DetailFreq", value.ToString()); }
         }
      
      
      #endregion

	}
}