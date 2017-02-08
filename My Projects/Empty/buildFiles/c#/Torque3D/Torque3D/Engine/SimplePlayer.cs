using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SimplePlayer : ShapeBase
	{
		public SimplePlayer(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SimplePlayer(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SimplePlayer(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SimplePlayer(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SimplePlayer(SimObject pObj) : base(pObj)
		{
		}

		public SimplePlayer(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SimplePlayer_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimplePlayer_create();
         private static _SimplePlayer_create _SimplePlayer_createFunc;
         internal static IntPtr SimplePlayer_create()
         {
         	if (_SimplePlayer_createFunc == null)
         	{
         		_SimplePlayer_createFunc =
         			(_SimplePlayer_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SimplePlayer_create"), typeof(_SimplePlayer_create));
         	}
         
         	return  _SimplePlayer_createFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return:MarshalAs(UnmanagedType.I1)]
         private delegate bool _SimplePlayer_CanSee(IntPtr other);
         private static _SimplePlayer_CanSee _SimplePlayer_CanSeeFunc;
         internal static bool SimplePlayer_CanSee(IntPtr other)
         {
         	if (_SimplePlayer_CanSeeFunc == null)
         	{
               _SimplePlayer_CanSeeFunc =
         			(_SimplePlayer_CanSee)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
                     "fnSimplePlayer_CanSee"), typeof(_SimplePlayer_CanSee));
         	}
         
         	return _SimplePlayer_CanSeeFunc(other);
         }
      
      }
      
      #endregion


      #region Functions

	   public bool CanSee(SimplePlayer other)
	   {
	      return InternalUnsafeMethods.SimplePlayer_CanSee(other.ObjectPtr);
	   }
      
      
      #endregion


      #region Properties
      
      
         public bool MovingRight
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("MovingRight")); }
         	set { setFieldValue("MovingRight", value ? "1" : "0"); }
         }
      
      
         public bool MovingLeft
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("MovingLeft")); }
         	set { setFieldValue("MovingLeft", value ? "1" : "0"); }
         }
      
      
         public bool MovingForward
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("MovingForward")); }
         	set { setFieldValue("MovingForward", value ? "1" : "0"); }
         }
      
      
         public bool MovingBackward
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("MovingBackward")); }
         	set { setFieldValue("MovingBackward", value ? "1" : "0"); }
         }
      
      
         public bool RenderFrustum
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderFrustum")); }
         	set { setFieldValue("RenderFrustum", value ? "1" : "0"); }
         }
      
      
         public string ThinkFunction
         {
         	get { return getFieldValue("ThinkFunction"); }
         	set { setFieldValue("ThinkFunction", value); }
         }
      
      
      #endregion

	}
}