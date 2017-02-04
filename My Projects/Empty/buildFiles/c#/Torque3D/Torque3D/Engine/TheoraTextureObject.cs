using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class TheoraTextureObject : SimObject
	{
		public TheoraTextureObject(bool pRegister = false)
			: base(pRegister)
		{
		}

		public TheoraTextureObject(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public TheoraTextureObject(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public TheoraTextureObject(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public TheoraTextureObject(SimObject pObj) : base(pObj)
		{
		}

		public TheoraTextureObject(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.TheoraTextureObject_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _play(IntPtr thisPtr);
         private static _play _playFunc;
         internal static void play(IntPtr thisPtr)
         {
         	if (_playFunc == null)
         	{
         		_playFunc =
         			(_play)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTheoraTextureObject_play"), typeof(_play));
         	}
         
         	 _playFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _stop(IntPtr thisPtr);
         private static _stop _stopFunc;
         internal static void stop(IntPtr thisPtr)
         {
         	if (_stopFunc == null)
         	{
         		_stopFunc =
         			(_stop)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTheoraTextureObject_stop"), typeof(_stop));
         	}
         
         	 _stopFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _pause(IntPtr thisPtr);
         private static _pause _pauseFunc;
         internal static void pause(IntPtr thisPtr)
         {
         	if (_pauseFunc == null)
         	{
         		_pauseFunc =
         			(_pause)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTheoraTextureObject_pause"), typeof(_pause));
         	}
         
         	 _pauseFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TheoraTextureObject_create();
         private static _TheoraTextureObject_create _TheoraTextureObject_createFunc;
         internal static IntPtr TheoraTextureObject_create()
         {
         	if (_TheoraTextureObject_createFunc == null)
         	{
         		_TheoraTextureObject_createFunc =
         			(_TheoraTextureObject_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_TheoraTextureObject_create"), typeof(_TheoraTextureObject_create));
         	}
         
         	return  _TheoraTextureObject_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void play()
         {
            InternalUnsafeMethods.play(ObjectPtr);
         }
      
         public virtual void stop()
         {
            InternalUnsafeMethods.stop(ObjectPtr);
         }
      
         public virtual void pause()
         {
            InternalUnsafeMethods.pause(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public string TheoraFile
         {
         	get { return getFieldValue("TheoraFile"); }
         	set { setFieldValue("TheoraFile", value); }
         }
      
         public string TexTargetName
         {
         	get { return getFieldValue("TexTargetName"); }
         	set { setFieldValue("TexTargetName", value); }
         }
      
         public SFXDescription SFXDescription
         {
         	get { return Sim.FindObject<SFXDescription>(getFieldValue("SFXDescription")); }
         	set { setFieldValue("SFXDescription", value.getId().ToString()); }
         }
      
         public bool Loop
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Loop")); }
         	set { setFieldValue("Loop", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}