using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ForestBrushTool : ForestTool
	{
		public ForestBrushTool(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ForestBrushTool(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ForestBrushTool(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ForestBrushTool(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ForestBrushTool(SimObject pObj) : base(pObj)
		{
		}

		public ForestBrushTool(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ForestBrushTool_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _collectElements(IntPtr thisPtr);
         private static _collectElements _collectElementsFunc;
         internal static void collectElements(IntPtr thisPtr)
         {
         	if (_collectElementsFunc == null)
         	{
         		_collectElementsFunc =
         			(_collectElements)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnForestBrushTool_collectElements"), typeof(_collectElements));
         	}
         
         	 _collectElementsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ForestBrushTool_create();
         private static _ForestBrushTool_create _ForestBrushTool_createFunc;
         internal static IntPtr ForestBrushTool_create()
         {
         	if (_ForestBrushTool_createFunc == null)
         	{
         		_ForestBrushTool_createFunc =
         			(_ForestBrushTool_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ForestBrushTool_create"), typeof(_ForestBrushTool_create));
         	}
         
         	return  _ForestBrushTool_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void collectElements()
         {
            InternalUnsafeMethods.collectElements(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public ForestBrushMode Mode
         {
         	get { return (ForestBrushMode)Enum.Parse(typeof(ForestBrushMode), getFieldValue("Mode"), true); }
         	set { setFieldValue("Mode", value.ToString()); }
         }
      
         public float Size
         {
         	get { return float.Parse(getFieldValue("Size")); }
         	set { setFieldValue("Size", value.ToString()); }
         }
      
         public float Pressure
         {
         	get { return float.Parse(getFieldValue("Pressure")); }
         	set { setFieldValue("Pressure", value.ToString()); }
         }
      
         public float Hardness
         {
         	get { return float.Parse(getFieldValue("Hardness")); }
         	set { setFieldValue("Hardness", value.ToString()); }
         }
      
      
      #endregion

	}
}