using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SFXParameter : SimObject
	{
		public SFXParameter(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SFXParameter(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SFXParameter(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SFXParameter(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SFXParameter(SimObject pObj) : base(pObj)
		{
		}

		public SFXParameter(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SFXParameter_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getParameterName(IntPtr thisPtr);
         private static _getParameterName _getParameterNameFunc;
         internal static IntPtr getParameterName(IntPtr thisPtr)
         {
         	if (_getParameterNameFunc == null)
         	{
         		_getParameterNameFunc =
         			(_getParameterName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXParameter_getParameterName"), typeof(_getParameterName));
         	}
         
         	return  _getParameterNameFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _reset(IntPtr thisPtr);
         private static _reset _resetFunc;
         internal static void reset(IntPtr thisPtr)
         {
         	if (_resetFunc == null)
         	{
         		_resetFunc =
         			(_reset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXParameter_reset"), typeof(_reset));
         	}
         
         	 _resetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SFXParameter_create();
         private static _SFXParameter_create _SFXParameter_createFunc;
         internal static IntPtr SFXParameter_create()
         {
         	if (_SFXParameter_createFunc == null)
         	{
         		_SFXParameter_createFunc =
         			(_SFXParameter_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SFXParameter_create"), typeof(_SFXParameter_create));
         	}
         
         	return  _SFXParameter_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual string getParameterName()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getParameterName(ObjectPtr));
         }
      
         public virtual void reset()
         {
            InternalUnsafeMethods.reset(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public float Value
         {
         	get { return float.Parse(getFieldValue("Value")); }
         	set { setFieldValue("Value", value.ToString()); }
         }
      
         public Point2F Range
         {
         	get { return new Point2F(getFieldValue("Range")); }
         	set { setFieldValue("Range", value.ToString()); }
         }
      
         public SFXChannel Channel
         {
         	get { return (SFXChannel)Enum.Parse(typeof(SFXChannel), getFieldValue("Channel"), true); }
         	set { setFieldValue("Channel", value.ToString()); }
         }
      
         public float DefaultValue
         {
         	get { return float.Parse(getFieldValue("DefaultValue")); }
         	set { setFieldValue("DefaultValue", value.ToString()); }
         }
      
         public string Description
         {
         	get { return getFieldValue("Description"); }
         	set { setFieldValue("Description", value); }
         }
      
      
      #endregion

	}
}