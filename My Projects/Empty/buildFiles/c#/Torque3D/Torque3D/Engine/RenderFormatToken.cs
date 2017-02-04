using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RenderFormatToken : RenderPassStateToken
	{
		public RenderFormatToken(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RenderFormatToken(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RenderFormatToken(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RenderFormatToken(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RenderFormatToken(SimObject pObj) : base(pObj)
		{
		}

		public RenderFormatToken(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RenderFormatToken_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RenderFormatToken_create();
         private static _RenderFormatToken_create _RenderFormatToken_createFunc;
         internal static IntPtr RenderFormatToken_create()
         {
         	if (_RenderFormatToken_createFunc == null)
         	{
         		_RenderFormatToken_createFunc =
         			(_RenderFormatToken_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RenderFormatToken_create"), typeof(_RenderFormatToken_create));
         	}
         
         	return  _RenderFormatToken_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public GFXFormat Format
         {
         	get { return (GFXFormat)Enum.Parse(typeof(GFXFormat), getFieldValue("Format"), true); }
         	set { setFieldValue("Format", value.ToString()); }
         }
      
         public GFXFormat DepthFormat
         {
         	get { return (GFXFormat)Enum.Parse(typeof(GFXFormat), getFieldValue("DepthFormat"), true); }
         	set { setFieldValue("DepthFormat", value.ToString()); }
         }
      
         public PostEffect CopyEffect
         {
         	get { return Sim.FindObject<PostEffect>(getFieldValue("CopyEffect")); }
         	set { setFieldValue("CopyEffect", value.getId().ToString()); }
         }
      
         public PostEffect ResolveEffect
         {
         	get { return Sim.FindObject<PostEffect>(getFieldValue("ResolveEffect")); }
         	set { setFieldValue("ResolveEffect", value.getId().ToString()); }
         }
      
         public int AaLevel
         {
         	get { return int.Parse(getFieldValue("AaLevel")); }
         	set { setFieldValue("AaLevel", value.ToString()); }
         }
      
      
      #endregion

	}
}