using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class CoverPoint : SceneObject
	{
		public CoverPoint(bool pRegister = false)
			: base(pRegister)
		{
		}

		public CoverPoint(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public CoverPoint(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public CoverPoint(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public CoverPoint(SimObject pObj) : base(pObj)
		{
		}

		public CoverPoint(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.CoverPoint_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isOccupied(IntPtr thisPtr);
         private static _isOccupied _isOccupiedFunc;
         internal static bool isOccupied(IntPtr thisPtr)
         {
         	if (_isOccupiedFunc == null)
         	{
         		_isOccupiedFunc =
         			(_isOccupied)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCoverPoint_isOccupied"), typeof(_isOccupied));
         	}
         
         	return  _isOccupiedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _CoverPoint_create();
         private static _CoverPoint_create _CoverPoint_createFunc;
         internal static IntPtr CoverPoint_create()
         {
         	if (_CoverPoint_createFunc == null)
         	{
         		_CoverPoint_createFunc =
         			(_CoverPoint_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CoverPoint_create"), typeof(_CoverPoint_create));
         	}
         
         	return  _CoverPoint_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool isOccupied()
         {
            return InternalUnsafeMethods.isOccupied(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public CoverPointSize Size
         {
         	get { return (CoverPointSize)Enum.Parse(typeof(CoverPointSize), getFieldValue("Size"), true); }
         	set { setFieldValue("Size", value.ToString()); }
         }
      
         public float Quality
         {
         	get { return float.Parse(getFieldValue("Quality")); }
         	set { setFieldValue("Quality", value.ToString()); }
         }
      
         public bool PeekLeft
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("PeekLeft")); }
         	set { setFieldValue("PeekLeft", value ? "1" : "0"); }
         }
      
         public bool PeekRight
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("PeekRight")); }
         	set { setFieldValue("PeekRight", value ? "1" : "0"); }
         }
      
         public bool PeekOver
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("PeekOver")); }
         	set { setFieldValue("PeekOver", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}