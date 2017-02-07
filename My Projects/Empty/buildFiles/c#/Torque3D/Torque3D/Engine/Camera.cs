using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class Camera : ShapeBase
	{
      #region Constructors
      public Camera(bool pRegister = false)
			: base(pRegister)
		{
		}

		public Camera(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public Camera(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public Camera(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public Camera(SimObject pObj) : base(pObj)
		{
		}

		public Camera(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

      #endregion

      protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Camera_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate CameraMotionMode _getMode(IntPtr thisPtr);
         private static _getMode _getModeFunc;
         internal static CameraMotionMode getMode(IntPtr thisPtr)
         {
         	if (_getModeFunc == null)
         	{
         		_getModeFunc =
         			(_getMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_getMode"), typeof(_getMode));
         	}
         
         	return  _getModeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getPosition(IntPtr thisPtr);
         private static _getPosition _getPositionFunc;
         internal static InternalPoint3FStruct getPosition(IntPtr thisPtr)
         {
         	if (_getPositionFunc == null)
         	{
         		_getPositionFunc =
         			(_getPosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_getPosition"), typeof(_getPosition));
         	}
         
         	return  _getPositionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getRotation(IntPtr thisPtr);
         private static _getRotation _getRotationFunc;
         internal static InternalPoint3FStruct getRotation(IntPtr thisPtr)
         {
         	if (_getRotationFunc == null)
         	{
         		_getRotationFunc =
         			(_getRotation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_getRotation"), typeof(_getRotation));
         	}
         
         	return  _getRotationFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setRotation(IntPtr thisPtr, InternalPoint3FStruct rot);
         private static _setRotation _setRotationFunc;
         internal static void setRotation(IntPtr thisPtr, InternalPoint3FStruct rot)
         {
         	if (_setRotationFunc == null)
         	{
         		_setRotationFunc =
         			(_setRotation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_setRotation"), typeof(_setRotation));
         	}
         
         	 _setRotationFunc(thisPtr, rot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getOffset(IntPtr thisPtr);
         private static _getOffset _getOffsetFunc;
         internal static InternalPoint3FStruct getOffset(IntPtr thisPtr)
         {
         	if (_getOffsetFunc == null)
         	{
         		_getOffsetFunc =
         			(_getOffset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_getOffset"), typeof(_getOffset));
         	}
         
         	return  _getOffsetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setOffset(IntPtr thisPtr, InternalPoint3FStruct offset);
         private static _setOffset _setOffsetFunc;
         internal static void setOffset(IntPtr thisPtr, InternalPoint3FStruct offset)
         {
         	if (_setOffsetFunc == null)
         	{
         		_setOffsetFunc =
         			(_setOffset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_setOffset"), typeof(_setOffset));
         	}
         
         	 _setOffsetFunc(thisPtr, offset);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setOrbitMode(IntPtr thisPtr, IntPtr orbitObject, InternalTransformFStruct orbitPoint, float minDistance, float maxDistance, float initDistance, bool ownClientObj, InternalPoint3FStruct offset, bool locked);
         private static _setOrbitMode _setOrbitModeFunc;
         internal static void setOrbitMode(IntPtr thisPtr, IntPtr orbitObject, InternalTransformFStruct orbitPoint, float minDistance, float maxDistance, float initDistance, bool ownClientObj, InternalPoint3FStruct offset, bool locked)
         {
         	if (_setOrbitModeFunc == null)
         	{
         		_setOrbitModeFunc =
         			(_setOrbitMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_setOrbitMode"), typeof(_setOrbitMode));
         	}
         
         	 _setOrbitModeFunc(thisPtr, orbitObject, orbitPoint, minDistance, maxDistance, initDistance, ownClientObj, offset, locked);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setOrbitObject(IntPtr thisPtr, IntPtr orbitObject, InternalPoint3FStruct rotation, float minDistance, float maxDistance, float initDistance, bool ownClientObject, InternalPoint3FStruct offset, bool locked);
         private static _setOrbitObject _setOrbitObjectFunc;
         internal static bool setOrbitObject(IntPtr thisPtr, IntPtr orbitObject, InternalPoint3FStruct rotation, float minDistance, float maxDistance, float initDistance, bool ownClientObject, InternalPoint3FStruct offset, bool locked)
         {
         	if (_setOrbitObjectFunc == null)
         	{
         		_setOrbitObjectFunc =
         			(_setOrbitObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_setOrbitObject"), typeof(_setOrbitObject));
         	}
         
         	return  _setOrbitObjectFunc(thisPtr, orbitObject, rotation, minDistance, maxDistance, initDistance, ownClientObject, offset, locked);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setOrbitPoint(IntPtr thisPtr, InternalTransformFStruct orbitPoint, float minDistance, float maxDistance, float initDistance, InternalPoint3FStruct offset, bool locked);
         private static _setOrbitPoint _setOrbitPointFunc;
         internal static void setOrbitPoint(IntPtr thisPtr, InternalTransformFStruct orbitPoint, float minDistance, float maxDistance, float initDistance, InternalPoint3FStruct offset, bool locked)
         {
         	if (_setOrbitPointFunc == null)
         	{
         		_setOrbitPointFunc =
         			(_setOrbitPoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_setOrbitPoint"), typeof(_setOrbitPoint));
         	}
         
         	 _setOrbitPointFunc(thisPtr, orbitPoint, minDistance, maxDistance, initDistance, offset, locked);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setTrackObject(IntPtr thisPtr, IntPtr trackObject, InternalPoint3FStruct offset);
         private static _setTrackObject _setTrackObjectFunc;
         internal static bool setTrackObject(IntPtr thisPtr, IntPtr trackObject, InternalPoint3FStruct offset)
         {
         	if (_setTrackObjectFunc == null)
         	{
         		_setTrackObjectFunc =
         			(_setTrackObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_setTrackObject"), typeof(_setTrackObject));
         	}
         
         	return  _setTrackObjectFunc(thisPtr, trackObject, offset);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setEditOrbitMode(IntPtr thisPtr);
         private static _setEditOrbitMode _setEditOrbitModeFunc;
         internal static void setEditOrbitMode(IntPtr thisPtr)
         {
         	if (_setEditOrbitModeFunc == null)
         	{
         		_setEditOrbitModeFunc =
         			(_setEditOrbitMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_setEditOrbitMode"), typeof(_setEditOrbitMode));
         	}
         
         	 _setEditOrbitModeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setFlyMode(IntPtr thisPtr);
         private static _setFlyMode _setFlyModeFunc;
         internal static void setFlyMode(IntPtr thisPtr)
         {
         	if (_setFlyModeFunc == null)
         	{
         		_setFlyModeFunc =
         			(_setFlyMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_setFlyMode"), typeof(_setFlyMode));
         	}
         
         	 _setFlyModeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setNewtonFlyMode(IntPtr thisPtr);
         private static _setNewtonFlyMode _setNewtonFlyModeFunc;
         internal static void setNewtonFlyMode(IntPtr thisPtr)
         {
         	if (_setNewtonFlyModeFunc == null)
         	{
         		_setNewtonFlyModeFunc =
         			(_setNewtonFlyMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_setNewtonFlyMode"), typeof(_setNewtonFlyMode));
         	}
         
         	 _setNewtonFlyModeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isRotationDamped(IntPtr thisPtr);
         private static _isRotationDamped _isRotationDampedFunc;
         internal static bool isRotationDamped(IntPtr thisPtr)
         {
         	if (_isRotationDampedFunc == null)
         	{
         		_isRotationDampedFunc =
         			(_isRotationDamped)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_isRotationDamped"), typeof(_isRotationDamped));
         	}
         
         	return  _isRotationDampedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getAngularVelocity(IntPtr thisPtr);
         private static _getAngularVelocity _getAngularVelocityFunc;
         internal static InternalPoint3FStruct getAngularVelocity(IntPtr thisPtr)
         {
         	if (_getAngularVelocityFunc == null)
         	{
         		_getAngularVelocityFunc =
         			(_getAngularVelocity)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_getAngularVelocity"), typeof(_getAngularVelocity));
         	}
         
         	return  _getAngularVelocityFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setAngularVelocity(IntPtr thisPtr, InternalPoint3FStruct velocity);
         private static _setAngularVelocity _setAngularVelocityFunc;
         internal static void setAngularVelocity(IntPtr thisPtr, InternalPoint3FStruct velocity)
         {
         	if (_setAngularVelocityFunc == null)
         	{
         		_setAngularVelocityFunc =
         			(_setAngularVelocity)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_setAngularVelocity"), typeof(_setAngularVelocity));
         	}
         
         	 _setAngularVelocityFunc(thisPtr, velocity);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setAngularForce(IntPtr thisPtr, float force);
         private static _setAngularForce _setAngularForceFunc;
         internal static void setAngularForce(IntPtr thisPtr, float force)
         {
         	if (_setAngularForceFunc == null)
         	{
         		_setAngularForceFunc =
         			(_setAngularForce)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_setAngularForce"), typeof(_setAngularForce));
         	}
         
         	 _setAngularForceFunc(thisPtr, force);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setAngularDrag(IntPtr thisPtr, float drag);
         private static _setAngularDrag _setAngularDragFunc;
         internal static void setAngularDrag(IntPtr thisPtr, float drag)
         {
         	if (_setAngularDragFunc == null)
         	{
         		_setAngularDragFunc =
         			(_setAngularDrag)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_setAngularDrag"), typeof(_setAngularDrag));
         	}
         
         	 _setAngularDragFunc(thisPtr, drag);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMass(IntPtr thisPtr, float mass);
         private static _setMass _setMassFunc;
         internal static void setMass(IntPtr thisPtr, float mass)
         {
         	if (_setMassFunc == null)
         	{
         		_setMassFunc =
         			(_setMass)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_setMass"), typeof(_setMass));
         	}
         
         	 _setMassFunc(thisPtr, mass);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getVelocity(IntPtr thisPtr);
         private static _getVelocity _getVelocityFunc;
         internal static InternalPoint3FStruct getVelocity(IntPtr thisPtr)
         {
         	if (_getVelocityFunc == null)
         	{
         		_getVelocityFunc =
         			(_getVelocity)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_getVelocity"), typeof(_getVelocity));
         	}
         
         	return  _getVelocityFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setVelocity(IntPtr thisPtr, InternalPoint3FStruct velocity);
         private static _setVelocity _setVelocityFunc;
         internal static void setVelocity(IntPtr thisPtr, InternalPoint3FStruct velocity)
         {
         	if (_setVelocityFunc == null)
         	{
         		_setVelocityFunc =
         			(_setVelocity)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_setVelocity"), typeof(_setVelocity));
         	}
         
         	 _setVelocityFunc(thisPtr, velocity);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setDrag(IntPtr thisPtr, float drag);
         private static _setDrag _setDragFunc;
         internal static void setDrag(IntPtr thisPtr, float drag)
         {
         	if (_setDragFunc == null)
         	{
         		_setDragFunc =
         			(_setDrag)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_setDrag"), typeof(_setDrag));
         	}
         
         	 _setDragFunc(thisPtr, drag);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setFlyForce(IntPtr thisPtr, float force);
         private static _setFlyForce _setFlyForceFunc;
         internal static void setFlyForce(IntPtr thisPtr, float force)
         {
         	if (_setFlyForceFunc == null)
         	{
         		_setFlyForceFunc =
         			(_setFlyForce)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_setFlyForce"), typeof(_setFlyForce));
         	}
         
         	 _setFlyForceFunc(thisPtr, force);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSpeedMultiplier(IntPtr thisPtr, float multiplier);
         private static _setSpeedMultiplier _setSpeedMultiplierFunc;
         internal static void setSpeedMultiplier(IntPtr thisPtr, float multiplier)
         {
         	if (_setSpeedMultiplierFunc == null)
         	{
         		_setSpeedMultiplierFunc =
         			(_setSpeedMultiplier)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_setSpeedMultiplier"), typeof(_setSpeedMultiplier));
         	}
         
         	 _setSpeedMultiplierFunc(thisPtr, multiplier);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setBrakeMultiplier(IntPtr thisPtr, float multiplier);
         private static _setBrakeMultiplier _setBrakeMultiplierFunc;
         internal static void setBrakeMultiplier(IntPtr thisPtr, float multiplier)
         {
         	if (_setBrakeMultiplierFunc == null)
         	{
         		_setBrakeMultiplierFunc =
         			(_setBrakeMultiplier)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_setBrakeMultiplier"), typeof(_setBrakeMultiplier));
         	}
         
         	 _setBrakeMultiplierFunc(thisPtr, multiplier);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isEditOrbitMode(IntPtr thisPtr);
         private static _isEditOrbitMode _isEditOrbitModeFunc;
         internal static bool isEditOrbitMode(IntPtr thisPtr)
         {
         	if (_isEditOrbitModeFunc == null)
         	{
         		_isEditOrbitModeFunc =
         			(_isEditOrbitMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_isEditOrbitMode"), typeof(_isEditOrbitMode));
         	}
         
         	return  _isEditOrbitModeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setValidEditOrbitPoint(IntPtr thisPtr, bool validPoint);
         private static _setValidEditOrbitPoint _setValidEditOrbitPointFunc;
         internal static void setValidEditOrbitPoint(IntPtr thisPtr, bool validPoint)
         {
         	if (_setValidEditOrbitPointFunc == null)
         	{
         		_setValidEditOrbitPointFunc =
         			(_setValidEditOrbitPoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_setValidEditOrbitPoint"), typeof(_setValidEditOrbitPoint));
         	}
         
         	 _setValidEditOrbitPointFunc(thisPtr, validPoint);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setEditOrbitPoint(IntPtr thisPtr, InternalPoint3FStruct point);
         private static _setEditOrbitPoint _setEditOrbitPointFunc;
         internal static void setEditOrbitPoint(IntPtr thisPtr, InternalPoint3FStruct point)
         {
         	if (_setEditOrbitPointFunc == null)
         	{
         		_setEditOrbitPointFunc =
         			(_setEditOrbitPoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_setEditOrbitPoint"), typeof(_setEditOrbitPoint));
         	}
         
         	 _setEditOrbitPointFunc(thisPtr, point);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _autoFitRadius(IntPtr thisPtr, float radius);
         private static _autoFitRadius _autoFitRadiusFunc;
         internal static void autoFitRadius(IntPtr thisPtr, float radius)
         {
         	if (_autoFitRadiusFunc == null)
         	{
         		_autoFitRadiusFunc =
         			(_autoFitRadius)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_autoFitRadius"), typeof(_autoFitRadius));
         	}
         
         	 _autoFitRadiusFunc(thisPtr, radius);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _lookAt(IntPtr thisPtr, InternalPoint3FStruct point);
         private static _lookAt _lookAtFunc;
         internal static void lookAt(IntPtr thisPtr, InternalPoint3FStruct point)
         {
         	if (_lookAtFunc == null)
         	{
         		_lookAtFunc =
         			(_lookAt)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCamera_lookAt"), typeof(_lookAt));
         	}
         
         	 _lookAtFunc(thisPtr, point);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Camera_create();
         private static _Camera_create _Camera_createFunc;
         internal static IntPtr Camera_create()
         {
         	if (_Camera_createFunc == null)
         	{
         		_Camera_createFunc =
         			(_Camera_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Camera_create"), typeof(_Camera_create));
         	}
         
         	return  _Camera_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual CameraMotionMode getMode()
         {
            return InternalUnsafeMethods.getMode(ObjectPtr);
         }
      
         public virtual Point3F getPosition()
         {
            return new Point3F(InternalUnsafeMethods.getPosition(ObjectPtr));
         }
      
         public virtual Point3F getRotation()
         {
            return new Point3F(InternalUnsafeMethods.getRotation(ObjectPtr));
         }
      
         public virtual void setRotation(Point3F rot)
         {
            InternalUnsafeMethods.setRotation(ObjectPtr, rot.ToStruct());
         }
      
         public virtual Point3F getOffset()
         {
            return new Point3F(InternalUnsafeMethods.getOffset(ObjectPtr));
         }
      
         public virtual void setOffset(Point3F offset)
         {
            InternalUnsafeMethods.setOffset(ObjectPtr, offset.ToStruct());
         }
      
         public virtual void setOrbitMode(GameBase orbitObject, TransformF orbitPoint, float minDistance, float maxDistance, float initDistance, bool ownClientObj = false, Point3F offset = null, bool locked = false)
         {
            if (offset == null) offset = Point3F.Zero;
                  InternalUnsafeMethods.setOrbitMode(ObjectPtr, orbitObject.ObjectPtr, orbitPoint.ToStruct(), minDistance, maxDistance, initDistance, ownClientObj, offset.ToStruct(), locked);
         }
      
         public virtual bool setOrbitObject(GameBase orbitObject, VectorF rotation, float minDistance, float maxDistance, float initDistance, bool ownClientObject = false, Point3F offset = null, bool locked = false)
         {
            if (offset == null) offset = Point3F.Zero;
                  return InternalUnsafeMethods.setOrbitObject(ObjectPtr, orbitObject.ObjectPtr, rotation.ToStruct(), minDistance, maxDistance, initDistance, ownClientObject, offset.ToStruct(), locked);
         }
      
         public virtual void setOrbitPoint(TransformF orbitPoint, float minDistance, float maxDistance, float initDistance, Point3F offset = null, bool locked = false)
         {
            if (offset == null) offset = Point3F.Zero;
                  InternalUnsafeMethods.setOrbitPoint(ObjectPtr, orbitPoint.ToStruct(), minDistance, maxDistance, initDistance, offset.ToStruct(), locked);
         }
      
         public virtual bool setTrackObject(GameBase trackObject, Point3F offset = null)
         {
            if (offset == null) offset = Point3F.Zero;
                  return InternalUnsafeMethods.setTrackObject(ObjectPtr, trackObject.ObjectPtr, offset.ToStruct());
         }
      
         public virtual void setEditOrbitMode()
         {
            InternalUnsafeMethods.setEditOrbitMode(ObjectPtr);
         }
      
         public virtual void setFlyMode()
         {
            InternalUnsafeMethods.setFlyMode(ObjectPtr);
         }
      
         public virtual void setNewtonFlyMode()
         {
            InternalUnsafeMethods.setNewtonFlyMode(ObjectPtr);
         }
      
         public virtual bool isRotationDamped()
         {
            return InternalUnsafeMethods.isRotationDamped(ObjectPtr);
         }
      
         public virtual VectorF getAngularVelocity()
         {
            return new VectorF(InternalUnsafeMethods.getAngularVelocity(ObjectPtr));
         }
      
         public virtual void setAngularVelocity(VectorF velocity)
         {
            InternalUnsafeMethods.setAngularVelocity(ObjectPtr, velocity.ToStruct());
         }
      
         public virtual void setAngularForce(float force)
         {
            InternalUnsafeMethods.setAngularForce(ObjectPtr, force);
         }
      
         public virtual void setAngularDrag(float drag)
         {
            InternalUnsafeMethods.setAngularDrag(ObjectPtr, drag);
         }
      
         public virtual void setMass(float mass)
         {
            InternalUnsafeMethods.setMass(ObjectPtr, mass);
         }
      
         public virtual VectorF getVelocity()
         {
            return new VectorF(InternalUnsafeMethods.getVelocity(ObjectPtr));
         }
      
         public virtual void setVelocity(Point3F velocity)
         {
            InternalUnsafeMethods.setVelocity(ObjectPtr, velocity.ToStruct());
         }
      
         public virtual void setDrag(float drag)
         {
            InternalUnsafeMethods.setDrag(ObjectPtr, drag);
         }
      
         public virtual void setFlyForce(float force)
         {
            InternalUnsafeMethods.setFlyForce(ObjectPtr, force);
         }
      
         public virtual void setSpeedMultiplier(float multiplier)
         {
            InternalUnsafeMethods.setSpeedMultiplier(ObjectPtr, multiplier);
         }
      
         public virtual void setBrakeMultiplier(float multiplier)
         {
            InternalUnsafeMethods.setBrakeMultiplier(ObjectPtr, multiplier);
         }
      
         public virtual bool isEditOrbitMode()
         {
            return InternalUnsafeMethods.isEditOrbitMode(ObjectPtr);
         }
      
         public virtual void setValidEditOrbitPoint(bool validPoint)
         {
            InternalUnsafeMethods.setValidEditOrbitPoint(ObjectPtr, validPoint);
         }
      
         public virtual void setEditOrbitPoint(Point3F point)
         {
            InternalUnsafeMethods.setEditOrbitPoint(ObjectPtr, point.ToStruct());
         }
      
         public virtual void autoFitRadius(float radius)
         {
            InternalUnsafeMethods.autoFitRadius(ObjectPtr, radius);
         }
      
         public virtual void lookAt(Point3F point)
         {
            InternalUnsafeMethods.lookAt(ObjectPtr, point.ToStruct());
         }
      
      
      #endregion


      #region Properties
      
      
         public CameraMotionMode ControlMode
         {
         	get { return (CameraMotionMode)Enum.Parse(typeof(CameraMotionMode), getFieldValue("ControlMode"), true); }
         	set { setFieldValue("ControlMode", value.ToString()); }
         }
      
         public bool NewtonMode
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("NewtonMode")); }
         	set { setFieldValue("NewtonMode", value ? "1" : "0"); }
         }
      
         public bool NewtonRotation
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("NewtonRotation")); }
         	set { setFieldValue("NewtonRotation", value ? "1" : "0"); }
         }
      
         public float Mass
         {
         	get { return float.Parse(getFieldValue("Mass")); }
         	set { setFieldValue("Mass", value.ToString()); }
         }
      
         public float Drag
         {
         	get { return float.Parse(getFieldValue("Drag")); }
         	set { setFieldValue("Drag", value.ToString()); }
         }
      
         public float Force
         {
         	get { return float.Parse(getFieldValue("Force")); }
         	set { setFieldValue("Force", value.ToString()); }
         }
      
         public float AngularDrag
         {
         	get { return float.Parse(getFieldValue("AngularDrag")); }
         	set { setFieldValue("AngularDrag", value.ToString()); }
         }
      
         public float AngularForce
         {
         	get { return float.Parse(getFieldValue("AngularForce")); }
         	set { setFieldValue("AngularForce", value.ToString()); }
         }
      
         public float SpeedMultiplier
         {
         	get { return float.Parse(getFieldValue("SpeedMultiplier")); }
         	set { setFieldValue("SpeedMultiplier", value.ToString()); }
         }
      
         public float BrakeMultiplier
         {
         	get { return float.Parse(getFieldValue("BrakeMultiplier")); }
         	set { setFieldValue("BrakeMultiplier", value.ToString()); }
         }
      
      
      #endregion

	}
}