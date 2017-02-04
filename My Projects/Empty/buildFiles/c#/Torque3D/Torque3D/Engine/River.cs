using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class River : WaterObject
	{
		public River(bool pRegister = false)
			: base(pRegister)
		{
		}

		public River(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public River(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public River(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public River(SimObject pObj) : base(pObj)
		{
		}

		public River(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.River_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _regenerate(IntPtr thisPtr);
         private static _regenerate _regenerateFunc;
         internal static void regenerate(IntPtr thisPtr)
         {
         	if (_regenerateFunc == null)
         	{
         		_regenerateFunc =
         			(_regenerate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnRiver_regenerate"), typeof(_regenerate));
         	}
         
         	 _regenerateFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMetersPerSegment(IntPtr thisPtr, float meters);
         private static _setMetersPerSegment _setMetersPerSegmentFunc;
         internal static void setMetersPerSegment(IntPtr thisPtr, float meters)
         {
         	if (_setMetersPerSegmentFunc == null)
         	{
         		_setMetersPerSegmentFunc =
         			(_setMetersPerSegment)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnRiver_setMetersPerSegment"), typeof(_setMetersPerSegment));
         	}
         
         	 _setMetersPerSegmentFunc(thisPtr, meters);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setBatchSize(IntPtr thisPtr, float meters);
         private static _setBatchSize _setBatchSizeFunc;
         internal static void setBatchSize(IntPtr thisPtr, float meters)
         {
         	if (_setBatchSizeFunc == null)
         	{
         		_setBatchSizeFunc =
         			(_setBatchSize)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnRiver_setBatchSize"), typeof(_setBatchSize));
         	}
         
         	 _setBatchSizeFunc(thisPtr, meters);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setNodeDepth(IntPtr thisPtr, int idx, float meters);
         private static _setNodeDepth _setNodeDepthFunc;
         internal static void setNodeDepth(IntPtr thisPtr, int idx, float meters)
         {
         	if (_setNodeDepthFunc == null)
         	{
         		_setNodeDepthFunc =
         			(_setNodeDepth)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnRiver_setNodeDepth"), typeof(_setNodeDepth));
         	}
         
         	 _setNodeDepthFunc(thisPtr, idx, meters);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMaxDivisionSize(IntPtr thisPtr, float meters);
         private static _setMaxDivisionSize _setMaxDivisionSizeFunc;
         internal static void setMaxDivisionSize(IntPtr thisPtr, float meters)
         {
         	if (_setMaxDivisionSizeFunc == null)
         	{
         		_setMaxDivisionSizeFunc =
         			(_setMaxDivisionSize)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnRiver_setMaxDivisionSize"), typeof(_setMaxDivisionSize));
         	}
         
         	 _setMaxDivisionSizeFunc(thisPtr, meters);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _River_create();
         private static _River_create _River_createFunc;
         internal static IntPtr River_create()
         {
         	if (_River_createFunc == null)
         	{
         		_River_createFunc =
         			(_River_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_River_create"), typeof(_River_create));
         	}
         
         	return  _River_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void regenerate()
         {
            InternalUnsafeMethods.regenerate(ObjectPtr);
         }
      
         public virtual void setMetersPerSegment(float meters)
         {
            InternalUnsafeMethods.setMetersPerSegment(ObjectPtr, meters);
         }
      
         public virtual void setBatchSize(float meters)
         {
            InternalUnsafeMethods.setBatchSize(ObjectPtr, meters);
         }
      
         public virtual void setNodeDepth(int idx, float meters)
         {
            InternalUnsafeMethods.setNodeDepth(ObjectPtr, idx, meters);
         }
      
         public virtual void setMaxDivisionSize(float meters)
         {
            InternalUnsafeMethods.setMaxDivisionSize(ObjectPtr, meters);
         }
      
      
      #endregion


      #region Properties
      
      
         public float SegmentLength
         {
         	get { return float.Parse(getFieldValue("SegmentLength")); }
         	set { setFieldValue("SegmentLength", value.ToString()); }
         }
      
         public float SubdivideLength
         {
         	get { return float.Parse(getFieldValue("SubdivideLength")); }
         	set { setFieldValue("SubdivideLength", value.ToString()); }
         }
      
         public float FlowMagnitude
         {
         	get { return float.Parse(getFieldValue("FlowMagnitude")); }
         	set { setFieldValue("FlowMagnitude", value.ToString()); }
         }
      
         public float LowLODDistance
         {
         	get { return float.Parse(getFieldValue("LowLODDistance")); }
         	set { setFieldValue("LowLODDistance", value.ToString()); }
         }
      
         public string Node
         {
         	get { return getFieldValue("Node"); }
         	set { setFieldValue("Node", value); }
         }
      
      
      #endregion

	}
}