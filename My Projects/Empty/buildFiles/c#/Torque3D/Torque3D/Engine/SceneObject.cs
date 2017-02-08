using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SceneObject : NetObject
	{
		public SceneObject(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SceneObject(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SceneObject(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SceneObject(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SceneObject(SimObject pObj) : base(pObj)
		{
		}

		public SceneObject(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SceneObject_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getType(IntPtr thisPtr);
         private static _getType _getTypeFunc;
         internal static int getType(IntPtr thisPtr)
         {
         	if (_getTypeFunc == null)
         	{
         		_getTypeFunc =
         			(_getType)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_getType"), typeof(_getType));
         	}
         
         	return  _getTypeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _mountObject(IntPtr thisPtr, IntPtr objB, int slot, InternalTransformFStruct txfm);
         private static _mountObject _mountObjectFunc;
         internal static bool mountObject(IntPtr thisPtr, IntPtr objB, int slot, InternalTransformFStruct txfm)
         {
         	if (_mountObjectFunc == null)
         	{
         		_mountObjectFunc =
         			(_mountObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_mountObject"), typeof(_mountObject));
         	}
         
         	return  _mountObjectFunc(thisPtr, objB, slot, txfm);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _unmountObject(IntPtr thisPtr, IntPtr target);
         private static _unmountObject _unmountObjectFunc;
         internal static bool unmountObject(IntPtr thisPtr, IntPtr target)
         {
         	if (_unmountObjectFunc == null)
         	{
         		_unmountObjectFunc =
         			(_unmountObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_unmountObject"), typeof(_unmountObject));
         	}
         
         	return  _unmountObjectFunc(thisPtr, target);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _unmount(IntPtr thisPtr);
         private static _unmount _unmountFunc;
         internal static void unmount(IntPtr thisPtr)
         {
         	if (_unmountFunc == null)
         	{
         		_unmountFunc =
         			(_unmount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_unmount"), typeof(_unmount));
         	}
         
         	 _unmountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isMounted(IntPtr thisPtr);
         private static _isMounted _isMountedFunc;
         internal static bool isMounted(IntPtr thisPtr)
         {
         	if (_isMountedFunc == null)
         	{
         		_isMountedFunc =
         			(_isMounted)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_isMounted"), typeof(_isMounted));
         	}
         
         	return  _isMountedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getObjectMount(IntPtr thisPtr);
         private static _getObjectMount _getObjectMountFunc;
         internal static int getObjectMount(IntPtr thisPtr)
         {
         	if (_getObjectMountFunc == null)
         	{
         		_getObjectMountFunc =
         			(_getObjectMount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_getObjectMount"), typeof(_getObjectMount));
         	}
         
         	return  _getObjectMountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getMountedObjectCount(IntPtr thisPtr);
         private static _getMountedObjectCount _getMountedObjectCountFunc;
         internal static int getMountedObjectCount(IntPtr thisPtr)
         {
         	if (_getMountedObjectCountFunc == null)
         	{
         		_getMountedObjectCountFunc =
         			(_getMountedObjectCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_getMountedObjectCount"), typeof(_getMountedObjectCount));
         	}
         
         	return  _getMountedObjectCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getMountedObject(IntPtr thisPtr, int slot);
         private static _getMountedObject _getMountedObjectFunc;
         internal static int getMountedObject(IntPtr thisPtr, int slot)
         {
         	if (_getMountedObjectFunc == null)
         	{
         		_getMountedObjectFunc =
         			(_getMountedObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_getMountedObject"), typeof(_getMountedObject));
         	}
         
         	return  _getMountedObjectFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getMountedObjectNode(IntPtr thisPtr, int slot);
         private static _getMountedObjectNode _getMountedObjectNodeFunc;
         internal static int getMountedObjectNode(IntPtr thisPtr, int slot)
         {
         	if (_getMountedObjectNodeFunc == null)
         	{
         		_getMountedObjectNodeFunc =
         			(_getMountedObjectNode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_getMountedObjectNode"), typeof(_getMountedObjectNode));
         	}
         
         	return  _getMountedObjectNodeFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getMountNodeObject(IntPtr thisPtr, int node);
         private static _getMountNodeObject _getMountNodeObjectFunc;
         internal static int getMountNodeObject(IntPtr thisPtr, int node)
         {
         	if (_getMountNodeObjectFunc == null)
         	{
         		_getMountNodeObjectFunc =
         			(_getMountNodeObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_getMountNodeObject"), typeof(_getMountNodeObject));
         	}
         
         	return  _getMountNodeObjectFunc(thisPtr, node);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalTransformFStruct _getTransform(IntPtr thisPtr);
         private static _getTransform _getTransformFunc;
         internal static InternalTransformFStruct getTransform(IntPtr thisPtr)
         {
         	if (_getTransformFunc == null)
         	{
         		_getTransformFunc =
         			(_getTransform)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_getTransform"), typeof(_getTransform));
         	}
         
         	return  _getTransformFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalTransformFStruct _getInverseTransform(IntPtr thisPtr);
         private static _getInverseTransform _getInverseTransformFunc;
         internal static InternalTransformFStruct getInverseTransform(IntPtr thisPtr)
         {
         	if (_getInverseTransformFunc == null)
         	{
         		_getInverseTransformFunc =
         			(_getInverseTransform)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_getInverseTransform"), typeof(_getInverseTransform));
         	}
         
         	return  _getInverseTransformFunc(thisPtr);
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
         				"fnSceneObject_getPosition"), typeof(_getPosition));
         	}
         
         	return  _getPositionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setPosition(IntPtr thisPtr, InternalPoint3FStruct pos);
         private static _setPosition _setPositionFunc;
         internal static void setPosition(IntPtr thisPtr, InternalPoint3FStruct pos)
         {
         	if (_setPositionFunc == null)
         	{
         		_setPositionFunc =
         			(_setPosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_setPosition"), typeof(_setPosition));
         	}
         
         	 _setPositionFunc(thisPtr, pos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getEulerRotation(IntPtr thisPtr);
         private static _getEulerRotation _getEulerRotationFunc;
         internal static InternalPoint3FStruct getEulerRotation(IntPtr thisPtr)
         {
         	if (_getEulerRotationFunc == null)
         	{
         		_getEulerRotationFunc =
         			(_getEulerRotation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_getEulerRotation"), typeof(_getEulerRotation));
         	}
         
         	return  _getEulerRotationFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getForwardVector(IntPtr thisPtr);
         private static _getForwardVector _getForwardVectorFunc;
         internal static InternalPoint3FStruct getForwardVector(IntPtr thisPtr)
         {
         	if (_getForwardVectorFunc == null)
         	{
         		_getForwardVectorFunc =
         			(_getForwardVector)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_getForwardVector"), typeof(_getForwardVector));
         	}
         
         	return  _getForwardVectorFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getRightVector(IntPtr thisPtr);
         private static _getRightVector _getRightVectorFunc;
         internal static InternalPoint3FStruct getRightVector(IntPtr thisPtr)
         {
         	if (_getRightVectorFunc == null)
         	{
         		_getRightVectorFunc =
         			(_getRightVector)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_getRightVector"), typeof(_getRightVector));
         	}
         
         	return  _getRightVectorFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getUpVector(IntPtr thisPtr);
         private static _getUpVector _getUpVectorFunc;
         internal static InternalPoint3FStruct getUpVector(IntPtr thisPtr)
         {
         	if (_getUpVectorFunc == null)
         	{
         		_getUpVectorFunc =
         			(_getUpVector)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_getUpVector"), typeof(_getUpVector));
         	}
         
         	return  _getUpVectorFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setTransform(IntPtr thisPtr, InternalTransformFStruct txfm);
         private static _setTransform _setTransformFunc;
         internal static void setTransform(IntPtr thisPtr, InternalTransformFStruct txfm)
         {
         	if (_setTransformFunc == null)
         	{
         		_setTransformFunc =
         			(_setTransform)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_setTransform"), typeof(_setTransform));
         	}
         
         	 _setTransformFunc(thisPtr, txfm);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getScale(IntPtr thisPtr);
         private static _getScale _getScaleFunc;
         internal static InternalPoint3FStruct getScale(IntPtr thisPtr)
         {
         	if (_getScaleFunc == null)
         	{
         		_getScaleFunc =
         			(_getScale)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_getScale"), typeof(_getScale));
         	}
         
         	return  _getScaleFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setScale(IntPtr thisPtr, InternalPoint3FStruct scale);
         private static _setScale _setScaleFunc;
         internal static void setScale(IntPtr thisPtr, InternalPoint3FStruct scale)
         {
         	if (_setScaleFunc == null)
         	{
         		_setScaleFunc =
         			(_setScale)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_setScale"), typeof(_setScale));
         	}
         
         	 _setScaleFunc(thisPtr, scale);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalBox3FStruct _getWorldBox(IntPtr thisPtr);
         private static _getWorldBox _getWorldBoxFunc;
         internal static InternalBox3FStruct getWorldBox(IntPtr thisPtr)
         {
         	if (_getWorldBoxFunc == null)
         	{
         		_getWorldBoxFunc =
         			(_getWorldBox)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_getWorldBox"), typeof(_getWorldBox));
         	}
         
         	return  _getWorldBoxFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getWorldBoxCenter(IntPtr thisPtr);
         private static _getWorldBoxCenter _getWorldBoxCenterFunc;
         internal static InternalPoint3FStruct getWorldBoxCenter(IntPtr thisPtr)
         {
         	if (_getWorldBoxCenterFunc == null)
         	{
         		_getWorldBoxCenterFunc =
         			(_getWorldBoxCenter)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_getWorldBoxCenter"), typeof(_getWorldBoxCenter));
         	}
         
         	return  _getWorldBoxCenterFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalBox3FStruct _getObjectBox(IntPtr thisPtr);
         private static _getObjectBox _getObjectBoxFunc;
         internal static InternalBox3FStruct getObjectBox(IntPtr thisPtr)
         {
         	if (_getObjectBoxFunc == null)
         	{
         		_getObjectBoxFunc =
         			(_getObjectBox)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_getObjectBox"), typeof(_getObjectBox));
         	}
         
         	return  _getObjectBoxFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isGlobalBounds(IntPtr thisPtr);
         private static _isGlobalBounds _isGlobalBoundsFunc;
         internal static bool isGlobalBounds(IntPtr thisPtr)
         {
         	if (_isGlobalBoundsFunc == null)
         	{
         		_isGlobalBoundsFunc =
         			(_isGlobalBounds)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSceneObject_isGlobalBounds"), typeof(_isGlobalBounds));
         	}
         
         	return  _isGlobalBoundsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SceneObject_create();
         private static _SceneObject_create _SceneObject_createFunc;
         internal static IntPtr SceneObject_create()
         {
         	if (_SceneObject_createFunc == null)
         	{
         		_SceneObject_createFunc =
         			(_SceneObject_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SceneObject_create"), typeof(_SceneObject_create));
         	}
         
         	return  _SceneObject_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int getType()
         {
            return InternalUnsafeMethods.getType(ObjectPtr);
         }
      
         public virtual bool mountObject(SceneObject objB, int slot, TransformF txfm = null)
         {
            if (txfm == null) txfm = TransformF.Identity;
                  return InternalUnsafeMethods.mountObject(ObjectPtr, objB.ObjectPtr, slot, txfm.ToStruct());
         }
      
         public virtual bool unmountObject(SceneObject target)
         {
            return InternalUnsafeMethods.unmountObject(ObjectPtr, target.ObjectPtr);
         }
      
         public virtual void unmount()
         {
            InternalUnsafeMethods.unmount(ObjectPtr);
         }
      
         public virtual bool isMounted()
         {
            return InternalUnsafeMethods.isMounted(ObjectPtr);
         }
      
         public virtual int getObjectMount()
         {
            return InternalUnsafeMethods.getObjectMount(ObjectPtr);
         }
      
         public virtual int getMountedObjectCount()
         {
            return InternalUnsafeMethods.getMountedObjectCount(ObjectPtr);
         }
      
         public virtual int getMountedObject(int slot)
         {
            return InternalUnsafeMethods.getMountedObject(ObjectPtr, slot);
         }
      
         public virtual int getMountedObjectNode(int slot)
         {
            return InternalUnsafeMethods.getMountedObjectNode(ObjectPtr, slot);
         }
      
         public virtual int getMountNodeObject(int node)
         {
            return InternalUnsafeMethods.getMountNodeObject(ObjectPtr, node);
         }
      
         public virtual TransformF getTransform()
         {
            return new TransformF(InternalUnsafeMethods.getTransform(ObjectPtr));
         }
      
         public virtual TransformF getInverseTransform()
         {
            return new TransformF(InternalUnsafeMethods.getInverseTransform(ObjectPtr));
         }
      
         public virtual Point3F getPosition()
         {
            return new Point3F(InternalUnsafeMethods.getPosition(ObjectPtr));
         }
      
         public virtual void setPosition(Point3F pos)
         {
            InternalUnsafeMethods.setPosition(ObjectPtr, pos.ToStruct());
         }
      
         public virtual Point3F getEulerRotation()
         {
            return new Point3F(InternalUnsafeMethods.getEulerRotation(ObjectPtr));
         }
      
         public virtual VectorF getForwardVector()
         {
            return new VectorF(InternalUnsafeMethods.getForwardVector(ObjectPtr));
         }
      
         public virtual VectorF getRightVector()
         {
            return new VectorF(InternalUnsafeMethods.getRightVector(ObjectPtr));
         }
      
         public virtual VectorF getUpVector()
         {
            return new VectorF(InternalUnsafeMethods.getUpVector(ObjectPtr));
         }
      
         public virtual void setTransform(TransformF txfm)
         {
            InternalUnsafeMethods.setTransform(ObjectPtr, txfm.ToStruct());
         }
      
         public virtual Point3F getScale()
         {
            return new Point3F(InternalUnsafeMethods.getScale(ObjectPtr));
         }
      
         public virtual void setScale(Point3F scale)
         {
            InternalUnsafeMethods.setScale(ObjectPtr, scale.ToStruct());
         }
      
         public virtual Box3F getWorldBox()
         {
            return new Box3F(InternalUnsafeMethods.getWorldBox(ObjectPtr));
         }
      
         public virtual Point3F getWorldBoxCenter()
         {
            return new Point3F(InternalUnsafeMethods.getWorldBoxCenter(ObjectPtr));
         }
      
         public virtual Box3F getObjectBox()
         {
            return new Box3F(InternalUnsafeMethods.getObjectBox(ObjectPtr));
         }
      
         public virtual bool isGlobalBounds()
         {
            return InternalUnsafeMethods.isGlobalBounds(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public Point3F Position
         {
         	get { return new Point3F(getFieldValue("Position")); }
         	set { setFieldValue("Position", value.ToString()); }
         }
      
         public AngAxisF Rotation
         {
         	get { return new AngAxisF(getFieldValue("Rotation")); }
         	set { setFieldValue("Rotation", value.ToString()); }
         }
      
         public Point3F Scale
         {
         	get { return new Point3F(getFieldValue("Scale")); }
         	set { setFieldValue("Scale", value.ToString()); }
         }
      
         public bool IsRenderEnabled
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsRenderEnabled")); }
         	set { setFieldValue("IsRenderEnabled", value ? "1" : "0"); }
         }
      
         public bool IsSelectionEnabled
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsSelectionEnabled")); }
         	set { setFieldValue("IsSelectionEnabled", value ? "1" : "0"); }
         }
      
         public string MountPID
         {
         	get { return getFieldValue("MountPID"); }
         	set { setFieldValue("MountPID", value); }
         }
      
         public int MountNode
         {
         	get { return int.Parse(getFieldValue("MountNode")); }
         	set { setFieldValue("MountNode", value.ToString()); }
         }
      
         public Point3F MountPos
         {
         	get { return new Point3F(getFieldValue("MountPos")); }
         	set { setFieldValue("MountPos", value.ToString()); }
         }
      
         public Point3F MountRot
         {
         	get { return new Point3F(getFieldValue("MountRot")); }
         	set { setFieldValue("MountRot", value.ToString()); }
         }
      
      
      #endregion

	}
}