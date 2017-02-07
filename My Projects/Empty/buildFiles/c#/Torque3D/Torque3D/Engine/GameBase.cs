using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GameBase : SceneObject
	{
		public GameBase(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GameBase(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GameBase(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GameBase(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GameBase(SimObject pObj) : base(pObj)
		{
		}

		public GameBase(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GameBase_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getDataBlock(IntPtr thisPtr);
         private static _getDataBlock _getDataBlockFunc;
         internal static int getDataBlock(IntPtr thisPtr)
         {
         	if (_getDataBlockFunc == null)
         	{
         		_getDataBlockFunc =
         			(_getDataBlock)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGameBase_getDataBlock"), typeof(_getDataBlock));
         	}
         
         	return  _getDataBlockFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setDataBlock(IntPtr thisPtr, IntPtr data);
         private static _setDataBlock _setDataBlockFunc;
         internal static bool setDataBlock(IntPtr thisPtr, IntPtr data)
         {
         	if (_setDataBlockFunc == null)
         	{
         		_setDataBlockFunc =
         			(_setDataBlock)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGameBase_setDataBlock"), typeof(_setDataBlock));
         	}
         
         	return  _setDataBlockFunc(thisPtr, data);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _applyImpulse(IntPtr thisPtr, InternalPoint3FStruct pos, InternalPoint3FStruct vel);
         private static _applyImpulse _applyImpulseFunc;
         internal static bool applyImpulse(IntPtr thisPtr, InternalPoint3FStruct pos, InternalPoint3FStruct vel)
         {
         	if (_applyImpulseFunc == null)
         	{
         		_applyImpulseFunc =
         			(_applyImpulse)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGameBase_applyImpulse"), typeof(_applyImpulse));
         	}
         
         	return  _applyImpulseFunc(thisPtr, pos, vel);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _applyRadialImpulse(IntPtr thisPtr, InternalPoint3FStruct origin, float radius, float magnitude);
         private static _applyRadialImpulse _applyRadialImpulseFunc;
         internal static void applyRadialImpulse(IntPtr thisPtr, InternalPoint3FStruct origin, float radius, float magnitude)
         {
         	if (_applyRadialImpulseFunc == null)
         	{
         		_applyRadialImpulseFunc =
         			(_applyRadialImpulse)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGameBase_applyRadialImpulse"), typeof(_applyRadialImpulse));
         	}
         
         	 _applyRadialImpulseFunc(thisPtr, origin, radius, magnitude);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GameBase_create();
         private static _GameBase_create _GameBase_createFunc;
         internal static IntPtr GameBase_create()
         {
         	if (_GameBase_createFunc == null)
         	{
         		_GameBase_createFunc =
         			(_GameBase_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameBase_create"), typeof(_GameBase_create));
         	}
         
         	return  _GameBase_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int getDataBlock()
         {
            return InternalUnsafeMethods.getDataBlock(ObjectPtr);
         }
      
         public virtual bool setDataBlock(GameBaseData data)
         {
            return InternalUnsafeMethods.setDataBlock(ObjectPtr, data.ObjectPtr);
         }
      
         public virtual bool applyImpulse(Point3F pos, VectorF vel)
         {
            return InternalUnsafeMethods.applyImpulse(ObjectPtr, pos.ToStruct(), vel.ToStruct());
         }
      
         public virtual void applyRadialImpulse(Point3F origin, float radius, float magnitude)
         {
            InternalUnsafeMethods.applyRadialImpulse(ObjectPtr, origin.ToStruct(), radius, magnitude);
         }
      
      
      #endregion


      #region Properties
      
      
         public GameBaseData DataBlock
         {
         	get { return Sim.FindObject<GameBaseData>(getFieldValue("DataBlock")); }
         	set { setFieldValue("DataBlock", value.getName()); }
         }
      
      
      #endregion

	}
}