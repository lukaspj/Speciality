using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class MissionArea : NetObject
	{
		public MissionArea(bool pRegister = false)
			: base(pRegister)
		{
		}

		public MissionArea(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public MissionArea(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public MissionArea(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public MissionArea(SimObject pObj) : base(pObj)
		{
		}

		public MissionArea(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.MissionArea_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getArea(IntPtr thisPtr);
         private static _getArea _getAreaFunc;
         internal static IntPtr getArea(IntPtr thisPtr)
         {
         	if (_getAreaFunc == null)
         	{
         		_getAreaFunc =
         			(_getArea)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMissionArea_getArea"), typeof(_getArea));
         	}
         
         	return  _getAreaFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setArea(IntPtr thisPtr, int x, int y, int width, int height);
         private static _setArea _setAreaFunc;
         internal static void setArea(IntPtr thisPtr, int x, int y, int width, int height)
         {
         	if (_setAreaFunc == null)
         	{
         		_setAreaFunc =
         			(_setArea)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMissionArea_setArea"), typeof(_setArea));
         	}
         
         	 _setAreaFunc(thisPtr, x, y, width, height);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _postApply(IntPtr thisPtr);
         private static _postApply _postApplyFunc;
         internal static void postApply(IntPtr thisPtr)
         {
         	if (_postApplyFunc == null)
         	{
         		_postApplyFunc =
         			(_postApply)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMissionArea_postApply"), typeof(_postApply));
         	}
         
         	 _postApplyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MissionArea_create();
         private static _MissionArea_create _MissionArea_createFunc;
         internal static IntPtr MissionArea_create()
         {
         	if (_MissionArea_createFunc == null)
         	{
         		_MissionArea_createFunc =
         			(_MissionArea_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_MissionArea_create"), typeof(_MissionArea_create));
         	}
         
         	return  _MissionArea_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual string getArea()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getArea(ObjectPtr));
         }
      
         public virtual void setArea(int x, int y, int width, int height)
         {
            InternalUnsafeMethods.setArea(ObjectPtr, x, y, width, height);
         }
      
         public virtual void postApply()
         {
            InternalUnsafeMethods.postApply(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public RectI Area
         {
         	get { return new RectI(getFieldValue("Area")); }
         	set { setFieldValue("Area", value.ToString()); }
         }
      
         public float FlightCeiling
         {
         	get { return float.Parse(getFieldValue("FlightCeiling")); }
         	set { setFieldValue("FlightCeiling", value.ToString()); }
         }
      
         public float FlightCeilingRange
         {
         	get { return float.Parse(getFieldValue("FlightCeilingRange")); }
         	set { setFieldValue("FlightCeilingRange", value.ToString()); }
         }
      
      
      #endregion

	}
}