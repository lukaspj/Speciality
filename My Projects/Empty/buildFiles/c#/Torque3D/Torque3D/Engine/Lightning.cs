using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class Lightning : GameBase
	{
		public Lightning(bool pRegister = false)
			: base(pRegister)
		{
		}

		public Lightning(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public Lightning(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public Lightning(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public Lightning(SimObject pObj) : base(pObj)
		{
		}

		public Lightning(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Lightning_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _warningFlashes(IntPtr thisPtr);
         private static _warningFlashes _warningFlashesFunc;
         internal static void warningFlashes(IntPtr thisPtr)
         {
         	if (_warningFlashesFunc == null)
         	{
         		_warningFlashesFunc =
         			(_warningFlashes)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnLightning_warningFlashes"), typeof(_warningFlashes));
         	}
         
         	 _warningFlashesFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _strikeRandomPoint(IntPtr thisPtr);
         private static _strikeRandomPoint _strikeRandomPointFunc;
         internal static void strikeRandomPoint(IntPtr thisPtr)
         {
         	if (_strikeRandomPointFunc == null)
         	{
         		_strikeRandomPointFunc =
         			(_strikeRandomPoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnLightning_strikeRandomPoint"), typeof(_strikeRandomPoint));
         	}
         
         	 _strikeRandomPointFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _strikeObject(IntPtr thisPtr, IntPtr pSB);
         private static _strikeObject _strikeObjectFunc;
         internal static void strikeObject(IntPtr thisPtr, IntPtr pSB)
         {
         	if (_strikeObjectFunc == null)
         	{
         		_strikeObjectFunc =
         			(_strikeObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnLightning_strikeObject"), typeof(_strikeObject));
         	}
         
         	 _strikeObjectFunc(thisPtr, pSB);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Lightning_create();
         private static _Lightning_create _Lightning_createFunc;
         internal static IntPtr Lightning_create()
         {
         	if (_Lightning_createFunc == null)
         	{
         		_Lightning_createFunc =
         			(_Lightning_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Lightning_create"), typeof(_Lightning_create));
         	}
         
         	return  _Lightning_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void warningFlashes()
         {
            InternalUnsafeMethods.warningFlashes(ObjectPtr);
         }
      
         public virtual void strikeRandomPoint()
         {
            InternalUnsafeMethods.strikeRandomPoint(ObjectPtr);
         }
      
         public virtual void strikeObject(ShapeBase pSB)
         {
            InternalUnsafeMethods.strikeObject(ObjectPtr, pSB.ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public int StrikesPerMinute
         {
         	get { return int.Parse(getFieldValue("StrikesPerMinute")); }
         	set { setFieldValue("StrikesPerMinute", value.ToString()); }
         }
      
         public float StrikeWidth
         {
         	get { return float.Parse(getFieldValue("StrikeWidth")); }
         	set { setFieldValue("StrikeWidth", value.ToString()); }
         }
      
         public float StrikeRadius
         {
         	get { return float.Parse(getFieldValue("StrikeRadius")); }
         	set { setFieldValue("StrikeRadius", value.ToString()); }
         }
      
         public ColorF Color
         {
         	get { return new ColorF(getFieldValue("Color")); }
         	set { setFieldValue("Color", value.ToString()); }
         }
      
         public ColorF FadeColor
         {
         	get { return new ColorF(getFieldValue("FadeColor")); }
         	set { setFieldValue("FadeColor", value.ToString()); }
         }
      
         public float ChanceToHitTarget
         {
         	get { return float.Parse(getFieldValue("ChanceToHitTarget")); }
         	set { setFieldValue("ChanceToHitTarget", value.ToString()); }
         }
      
         public float BoltStartRadius
         {
         	get { return float.Parse(getFieldValue("BoltStartRadius")); }
         	set { setFieldValue("BoltStartRadius", value.ToString()); }
         }
      
         public bool UseFog
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseFog")); }
         	set { setFieldValue("UseFog", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}