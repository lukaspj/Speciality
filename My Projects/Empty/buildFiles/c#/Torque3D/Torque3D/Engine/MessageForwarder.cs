using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class MessageForwarder : ScriptMsgListener
	{
		public MessageForwarder(bool pRegister = false)
			: base(pRegister)
		{
		}

		public MessageForwarder(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public MessageForwarder(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public MessageForwarder(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public MessageForwarder(SimObject pObj) : base(pObj)
		{
		}

		public MessageForwarder(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.MessageForwarder_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MessageForwarder_create();
         private static _MessageForwarder_create _MessageForwarder_createFunc;
         internal static IntPtr MessageForwarder_create()
         {
         	if (_MessageForwarder_createFunc == null)
         	{
         		_MessageForwarder_createFunc =
         			(_MessageForwarder_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_MessageForwarder_create"), typeof(_MessageForwarder_create));
         	}
         
         	return  _MessageForwarder_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string ToQueue
         {
         	get { return getFieldValue("ToQueue"); }
         	set { setFieldValue("ToQueue", value); }
         }
      
      
      #endregion

	}
}