using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class Marker : SceneObject
	{
		public Marker(bool pRegister = false)
			: base(pRegister)
		{
		}

		public Marker(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public Marker(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public Marker(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public Marker(SimObject pObj) : base(pObj)
		{
		}

		public Marker(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Marker_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Marker_create();
         private static _Marker_create _Marker_createFunc;
         internal static IntPtr Marker_create()
         {
         	if (_Marker_createFunc == null)
         	{
         		_Marker_createFunc =
         			(_Marker_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Marker_create"), typeof(_Marker_create));
         	}
         
         	return  _Marker_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public int SeqNum
         {
         	get { return int.Parse(getFieldValue("SeqNum")); }
         	set { setFieldValue("SeqNum", value.ToString()); }
         }
      
         public MarkerKnotType Type
         {
         	get { return (MarkerKnotType)Enum.Parse(typeof(MarkerKnotType), getFieldValue("Type"), true); }
         	set { setFieldValue("Type", value.ToString()); }
         }
      
         public int MsToNext
         {
         	get { return int.Parse(getFieldValue("MsToNext")); }
         	set { setFieldValue("MsToNext", value.ToString()); }
         }
      
         public MarkerSmoothingType SmoothingType
         {
         	get { return (MarkerSmoothingType)Enum.Parse(typeof(MarkerSmoothingType), getFieldValue("SmoothingType"), true); }
         	set { setFieldValue("SmoothingType", value.ToString()); }
         }
      
      
      #endregion

	}
}