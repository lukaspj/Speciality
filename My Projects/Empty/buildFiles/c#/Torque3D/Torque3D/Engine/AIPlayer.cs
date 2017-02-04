using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class AIPlayer : Player
	{
		public AIPlayer(bool pRegister = false)
			: base(pRegister)
		{
		}

		public AIPlayer(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public AIPlayer(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public AIPlayer(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public AIPlayer(SimObject pObj) : base(pObj)
		{
		}

		public AIPlayer(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.AIPlayer_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setPathDestination(IntPtr thisPtr, InternalPoint3FStruct goal);
         private static _setPathDestination _setPathDestinationFunc;
         internal static bool setPathDestination(IntPtr thisPtr, InternalPoint3FStruct goal)
         {
         	if (_setPathDestinationFunc == null)
         	{
         		_setPathDestinationFunc =
         			(_setPathDestination)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_setPathDestination"), typeof(_setPathDestination));
         	}
         
         	return  _setPathDestinationFunc(thisPtr, goal);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getPathDestination(IntPtr thisPtr);
         private static _getPathDestination _getPathDestinationFunc;
         internal static InternalPoint3FStruct getPathDestination(IntPtr thisPtr)
         {
         	if (_getPathDestinationFunc == null)
         	{
         		_getPathDestinationFunc =
         			(_getPathDestination)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_getPathDestination"), typeof(_getPathDestination));
         	}
         
         	return  _getPathDestinationFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _followNavPath(IntPtr thisPtr, uint obj);
         private static _followNavPath _followNavPathFunc;
         internal static void followNavPath(IntPtr thisPtr, uint obj)
         {
         	if (_followNavPathFunc == null)
         	{
         		_followNavPathFunc =
         			(_followNavPath)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_followNavPath"), typeof(_followNavPath));
         	}
         
         	 _followNavPathFunc(thisPtr, obj);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _followObject(IntPtr thisPtr, uint obj, float radius);
         private static _followObject _followObjectFunc;
         internal static void followObject(IntPtr thisPtr, uint obj, float radius)
         {
         	if (_followObjectFunc == null)
         	{
         		_followObjectFunc =
         			(_followObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_followObject"), typeof(_followObject));
         	}
         
         	 _followObjectFunc(thisPtr, obj, radius);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _repath(IntPtr thisPtr);
         private static _repath _repathFunc;
         internal static void repath(IntPtr thisPtr)
         {
         	if (_repathFunc == null)
         	{
         		_repathFunc =
         			(_repath)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_repath"), typeof(_repath));
         	}
         
         	 _repathFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findCover(IntPtr thisPtr, InternalPoint3FStruct from, float radius);
         private static _findCover _findCoverFunc;
         internal static int findCover(IntPtr thisPtr, InternalPoint3FStruct from, float radius)
         {
         	if (_findCoverFunc == null)
         	{
         		_findCoverFunc =
         			(_findCover)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_findCover"), typeof(_findCover));
         	}
         
         	return  _findCoverFunc(thisPtr, from, radius);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findNavMesh(IntPtr thisPtr);
         private static _findNavMesh _findNavMeshFunc;
         internal static int findNavMesh(IntPtr thisPtr)
         {
         	if (_findNavMeshFunc == null)
         	{
         		_findNavMeshFunc =
         			(_findNavMesh)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_findNavMesh"), typeof(_findNavMesh));
         	}
         
         	return  _findNavMeshFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getNavMesh(IntPtr thisPtr);
         private static _getNavMesh _getNavMeshFunc;
         internal static int getNavMesh(IntPtr thisPtr)
         {
         	if (_getNavMeshFunc == null)
         	{
         		_getNavMeshFunc =
         			(_getNavMesh)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_getNavMesh"), typeof(_getNavMesh));
         	}
         
         	return  _getNavMeshFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setNavSize(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string size);
         private static _setNavSize _setNavSizeFunc;
         internal static void setNavSize(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string size)
         {
         	if (_setNavSizeFunc == null)
         	{
         		_setNavSizeFunc =
         			(_setNavSize)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_setNavSize"), typeof(_setNavSize));
         	}
         
         	 _setNavSizeFunc(thisPtr, size);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getNavSize(IntPtr thisPtr);
         private static _getNavSize _getNavSizeFunc;
         internal static IntPtr getNavSize(IntPtr thisPtr)
         {
         	if (_getNavSizeFunc == null)
         	{
         		_getNavSizeFunc =
         			(_getNavSize)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_getNavSize"), typeof(_getNavSize));
         	}
         
         	return  _getNavSizeFunc(thisPtr);
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
         				"fnAIPlayer_stop"), typeof(_stop));
         	}
         
         	 _stopFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearAim(IntPtr thisPtr);
         private static _clearAim _clearAimFunc;
         internal static void clearAim(IntPtr thisPtr)
         {
         	if (_clearAimFunc == null)
         	{
         		_clearAimFunc =
         			(_clearAim)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_clearAim"), typeof(_clearAim));
         	}
         
         	 _clearAimFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMoveSpeed(IntPtr thisPtr, float speed);
         private static _setMoveSpeed _setMoveSpeedFunc;
         internal static void setMoveSpeed(IntPtr thisPtr, float speed)
         {
         	if (_setMoveSpeedFunc == null)
         	{
         		_setMoveSpeedFunc =
         			(_setMoveSpeed)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_setMoveSpeed"), typeof(_setMoveSpeed));
         	}
         
         	 _setMoveSpeedFunc(thisPtr, speed);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getMoveSpeed(IntPtr thisPtr);
         private static _getMoveSpeed _getMoveSpeedFunc;
         internal static float getMoveSpeed(IntPtr thisPtr)
         {
         	if (_getMoveSpeedFunc == null)
         	{
         		_getMoveSpeedFunc =
         			(_getMoveSpeed)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_getMoveSpeed"), typeof(_getMoveSpeed));
         	}
         
         	return  _getMoveSpeedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMoveDestination(IntPtr thisPtr, InternalPoint3FStruct goal, bool slowDown);
         private static _setMoveDestination _setMoveDestinationFunc;
         internal static void setMoveDestination(IntPtr thisPtr, InternalPoint3FStruct goal, bool slowDown)
         {
         	if (_setMoveDestinationFunc == null)
         	{
         		_setMoveDestinationFunc =
         			(_setMoveDestination)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_setMoveDestination"), typeof(_setMoveDestination));
         	}
         
         	 _setMoveDestinationFunc(thisPtr, goal, slowDown);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getMoveDestination(IntPtr thisPtr);
         private static _getMoveDestination _getMoveDestinationFunc;
         internal static InternalPoint3FStruct getMoveDestination(IntPtr thisPtr)
         {
         	if (_getMoveDestinationFunc == null)
         	{
         		_getMoveDestinationFunc =
         			(_getMoveDestination)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_getMoveDestination"), typeof(_getMoveDestination));
         	}
         
         	return  _getMoveDestinationFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setAimLocation(IntPtr thisPtr, InternalPoint3FStruct target);
         private static _setAimLocation _setAimLocationFunc;
         internal static void setAimLocation(IntPtr thisPtr, InternalPoint3FStruct target)
         {
         	if (_setAimLocationFunc == null)
         	{
         		_setAimLocationFunc =
         			(_setAimLocation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_setAimLocation"), typeof(_setAimLocation));
         	}
         
         	 _setAimLocationFunc(thisPtr, target);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getAimLocation(IntPtr thisPtr);
         private static _getAimLocation _getAimLocationFunc;
         internal static InternalPoint3FStruct getAimLocation(IntPtr thisPtr)
         {
         	if (_getAimLocationFunc == null)
         	{
         		_getAimLocationFunc =
         			(_getAimLocation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_getAimLocation"), typeof(_getAimLocation));
         	}
         
         	return  _getAimLocationFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setAimObject(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName, InternalPoint3FStruct offset);
         private static _setAimObject _setAimObjectFunc;
         internal static void setAimObject(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName, InternalPoint3FStruct offset)
         {
         	if (_setAimObjectFunc == null)
         	{
         		_setAimObjectFunc =
         			(_setAimObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_setAimObject"), typeof(_setAimObject));
         	}
         
         	 _setAimObjectFunc(thisPtr, objName, offset);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getAimObject(IntPtr thisPtr);
         private static _getAimObject _getAimObjectFunc;
         internal static int getAimObject(IntPtr thisPtr)
         {
         	if (_getAimObjectFunc == null)
         	{
         		_getAimObjectFunc =
         			(_getAimObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_getAimObject"), typeof(_getAimObject));
         	}
         
         	return  _getAimObjectFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _checkInLos(IntPtr thisPtr, IntPtr obj, bool useMuzzle, bool checkEnabled);
         private static _checkInLos _checkInLosFunc;
         internal static bool checkInLos(IntPtr thisPtr, IntPtr obj, bool useMuzzle, bool checkEnabled)
         {
         	if (_checkInLosFunc == null)
         	{
         		_checkInLosFunc =
         			(_checkInLos)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_checkInLos"), typeof(_checkInLos));
         	}
         
         	return  _checkInLosFunc(thisPtr, obj, useMuzzle, checkEnabled);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _checkInFoV(IntPtr thisPtr, IntPtr obj, float fov, bool checkEnabled);
         private static _checkInFoV _checkInFoVFunc;
         internal static bool checkInFoV(IntPtr thisPtr, IntPtr obj, float fov, bool checkEnabled)
         {
         	if (_checkInFoVFunc == null)
         	{
         		_checkInFoVFunc =
         			(_checkInFoV)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_checkInFoV"), typeof(_checkInFoV));
         	}
         
         	return  _checkInFoVFunc(thisPtr, obj, fov, checkEnabled);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMoveTrigger(IntPtr thisPtr, uint slot);
         private static _setMoveTrigger _setMoveTriggerFunc;
         internal static void setMoveTrigger(IntPtr thisPtr, uint slot)
         {
         	if (_setMoveTriggerFunc == null)
         	{
         		_setMoveTriggerFunc =
         			(_setMoveTrigger)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_setMoveTrigger"), typeof(_setMoveTrigger));
         	}
         
         	 _setMoveTriggerFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearMoveTrigger(IntPtr thisPtr, uint slot);
         private static _clearMoveTrigger _clearMoveTriggerFunc;
         internal static void clearMoveTrigger(IntPtr thisPtr, uint slot)
         {
         	if (_clearMoveTriggerFunc == null)
         	{
         		_clearMoveTriggerFunc =
         			(_clearMoveTrigger)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_clearMoveTrigger"), typeof(_clearMoveTrigger));
         	}
         
         	 _clearMoveTriggerFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getMoveTrigger(IntPtr thisPtr, uint slot);
         private static _getMoveTrigger _getMoveTriggerFunc;
         internal static bool getMoveTrigger(IntPtr thisPtr, uint slot)
         {
         	if (_getMoveTriggerFunc == null)
         	{
         		_getMoveTriggerFunc =
         			(_getMoveTrigger)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_getMoveTrigger"), typeof(_getMoveTrigger));
         	}
         
         	return  _getMoveTriggerFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearMoveTriggers(IntPtr thisPtr);
         private static _clearMoveTriggers _clearMoveTriggersFunc;
         internal static void clearMoveTriggers(IntPtr thisPtr)
         {
         	if (_clearMoveTriggersFunc == null)
         	{
         		_clearMoveTriggersFunc =
         			(_clearMoveTriggers)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_clearMoveTriggers"), typeof(_clearMoveTriggers));
         	}
         
         	 _clearMoveTriggersFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getTargetDistance(IntPtr thisPtr, IntPtr obj, bool checkEnabled);
         private static _getTargetDistance _getTargetDistanceFunc;
         internal static float getTargetDistance(IntPtr thisPtr, IntPtr obj, bool checkEnabled)
         {
         	if (_getTargetDistanceFunc == null)
         	{
         		_getTargetDistanceFunc =
         			(_getTargetDistance)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_getTargetDistance"), typeof(_getTargetDistance));
         	}
         
         	return  _getTargetDistanceFunc(thisPtr, obj, checkEnabled);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setAiPose(IntPtr thisPtr, int pose);
         private static _setAiPose _setAiPoseFunc;
         internal static void setAiPose(IntPtr thisPtr, int pose)
         {
         	if (_setAiPoseFunc == null)
         	{
         		_setAiPoseFunc =
         			(_setAiPose)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_setAiPose"), typeof(_setAiPose));
         	}
         
         	 _setAiPoseFunc(thisPtr, pose);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getAiPose(IntPtr thisPtr);
         private static _getAiPose _getAiPoseFunc;
         internal static int getAiPose(IntPtr thisPtr)
         {
         	if (_getAiPoseFunc == null)
         	{
         		_getAiPoseFunc =
         			(_getAiPose)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIPlayer_getAiPose"), typeof(_getAiPose));
         	}
         
         	return  _getAiPoseFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AIPlayer_create();
         private static _AIPlayer_create _AIPlayer_createFunc;
         internal static IntPtr AIPlayer_create()
         {
         	if (_AIPlayer_createFunc == null)
         	{
         		_AIPlayer_createFunc =
         			(_AIPlayer_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AIPlayer_create"), typeof(_AIPlayer_create));
         	}
         
         	return  _AIPlayer_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool setPathDestination(Point3F goal)
         {
            return InternalUnsafeMethods.setPathDestination(ObjectPtr, goal.ToStruct());
         }
      
         public virtual Point3F getPathDestination()
         {
            return new Point3F(InternalUnsafeMethods.getPathDestination(ObjectPtr));
         }
      
         public virtual void followNavPath(uint obj)
         {
            InternalUnsafeMethods.followNavPath(ObjectPtr, obj);
         }
      
         public virtual void followObject(uint obj, float radius)
         {
            InternalUnsafeMethods.followObject(ObjectPtr, obj, radius);
         }
      
         public virtual void repath()
         {
            InternalUnsafeMethods.repath(ObjectPtr);
         }
      
         public virtual int findCover(Point3F from, float radius)
         {
            return InternalUnsafeMethods.findCover(ObjectPtr, from.ToStruct(), radius);
         }
      
         public virtual int findNavMesh()
         {
            return InternalUnsafeMethods.findNavMesh(ObjectPtr);
         }
      
         public virtual int getNavMesh()
         {
            return InternalUnsafeMethods.getNavMesh(ObjectPtr);
         }
      
         public virtual void setNavSize(string size)
         {
            InternalUnsafeMethods.setNavSize(ObjectPtr, size);
         }
      
         public virtual string getNavSize()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getNavSize(ObjectPtr));
         }
      
         public virtual void stop()
         {
            InternalUnsafeMethods.stop(ObjectPtr);
         }
      
         public virtual void clearAim()
         {
            InternalUnsafeMethods.clearAim(ObjectPtr);
         }
      
         public virtual void setMoveSpeed(float speed)
         {
            InternalUnsafeMethods.setMoveSpeed(ObjectPtr, speed);
         }
      
         public virtual float getMoveSpeed()
         {
            return InternalUnsafeMethods.getMoveSpeed(ObjectPtr);
         }
      
         public virtual void setMoveDestination(Point3F goal, bool slowDown = true)
         {
            InternalUnsafeMethods.setMoveDestination(ObjectPtr, goal.ToStruct(), slowDown);
         }
      
         public virtual Point3F getMoveDestination()
         {
            return new Point3F(InternalUnsafeMethods.getMoveDestination(ObjectPtr));
         }
      
         public virtual void setAimLocation(Point3F target)
         {
            InternalUnsafeMethods.setAimLocation(ObjectPtr, target.ToStruct());
         }
      
         public virtual Point3F getAimLocation()
         {
            return new Point3F(InternalUnsafeMethods.getAimLocation(ObjectPtr));
         }
      
         public virtual void setAimObject(string objName, Point3F offset = null)
         {
            if (offset == null) offset = Point3F.Zero;
                  InternalUnsafeMethods.setAimObject(ObjectPtr, objName, offset.ToStruct());
         }
      
         public virtual int getAimObject()
         {
            return InternalUnsafeMethods.getAimObject(ObjectPtr);
         }
      
         public virtual bool checkInLos(ShapeBase obj = null, bool useMuzzle = false, bool checkEnabled = false)
         {
            return InternalUnsafeMethods.checkInLos(ObjectPtr, obj.ObjectPtr, useMuzzle, checkEnabled);
         }
      
         public virtual bool checkInFoV(ShapeBase obj = null, float fov = 45.0f, bool checkEnabled = false)
         {
            return InternalUnsafeMethods.checkInFoV(ObjectPtr, obj.ObjectPtr, fov, checkEnabled);
         }
      
         public virtual void setMoveTrigger(uint slot)
         {
            InternalUnsafeMethods.setMoveTrigger(ObjectPtr, slot);
         }
      
         public virtual void clearMoveTrigger(uint slot)
         {
            InternalUnsafeMethods.clearMoveTrigger(ObjectPtr, slot);
         }
      
         public virtual bool getMoveTrigger(uint slot)
         {
            return InternalUnsafeMethods.getMoveTrigger(ObjectPtr, slot);
         }
      
         public virtual void clearMoveTriggers()
         {
            InternalUnsafeMethods.clearMoveTriggers(ObjectPtr);
         }
      
         public virtual float getTargetDistance(ShapeBase obj = null, bool checkEnabled = false)
         {
            return InternalUnsafeMethods.getTargetDistance(ObjectPtr, obj.ObjectPtr, checkEnabled);
         }
      
         public virtual void setAiPose(int pose)
         {
            InternalUnsafeMethods.setAiPose(ObjectPtr, pose);
         }
      
         public virtual int getAiPose()
         {
            return InternalUnsafeMethods.getAiPose(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public float MMoveTolerance
         {
         	get { return float.Parse(getFieldValue("MMoveTolerance")); }
         	set { setFieldValue("MMoveTolerance", value.ToString()); }
         }
      
         public float MoveStuckTolerance
         {
         	get { return float.Parse(getFieldValue("MoveStuckTolerance")); }
         	set { setFieldValue("MoveStuckTolerance", value.ToString()); }
         }
      
         public int MoveStuckTestDelay
         {
         	get { return int.Parse(getFieldValue("MoveStuckTestDelay")); }
         	set { setFieldValue("MoveStuckTestDelay", value.ToString()); }
         }
      
         public float AttackRadius
         {
         	get { return float.Parse(getFieldValue("AttackRadius")); }
         	set { setFieldValue("AttackRadius", value.ToString()); }
         }
      
         public bool AllowWalk
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowWalk")); }
         	set { setFieldValue("AllowWalk", value ? "1" : "0"); }
         }
      
         public bool AllowJump
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowJump")); }
         	set { setFieldValue("AllowJump", value ? "1" : "0"); }
         }
      
         public bool AllowDrop
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowDrop")); }
         	set { setFieldValue("AllowDrop", value ? "1" : "0"); }
         }
      
         public bool AllowSwim
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowSwim")); }
         	set { setFieldValue("AllowSwim", value ? "1" : "0"); }
         }
      
         public bool AllowLedge
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowLedge")); }
         	set { setFieldValue("AllowLedge", value ? "1" : "0"); }
         }
      
         public bool AllowClimb
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowClimb")); }
         	set { setFieldValue("AllowClimb", value ? "1" : "0"); }
         }
      
         public bool AllowTeleport
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowTeleport")); }
         	set { setFieldValue("AllowTeleport", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}