using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class WorldEditorSelection : SimPersistSet
	{
		public WorldEditorSelection(bool pRegister = false)
			: base(pRegister)
		{
		}

		public WorldEditorSelection(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public WorldEditorSelection(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public WorldEditorSelection(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public WorldEditorSelection(SimObject pObj) : base(pObj)
		{
		}

		public WorldEditorSelection(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.WorldEditorSelection_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _containsGlobalBounds(IntPtr thisPtr, int argc, string[] argv);
         private static _containsGlobalBounds _containsGlobalBoundsFunc;
         internal static bool containsGlobalBounds(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_containsGlobalBoundsFunc == null)
         	{
         		_containsGlobalBoundsFunc =
         			(_containsGlobalBounds)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditorSelection_containsGlobalBounds"), typeof(_containsGlobalBounds));
         	}
         
         	return  _containsGlobalBoundsFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getCentroid(IntPtr thisPtr, int argc, string[] argv);
         private static _getCentroid _getCentroidFunc;
         internal static IntPtr getCentroid(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_getCentroidFunc == null)
         	{
         		_getCentroidFunc =
         			(_getCentroid)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditorSelection_getCentroid"), typeof(_getCentroid));
         	}
         
         	return  _getCentroidFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getBoxCentroid(IntPtr thisPtr, int argc, string[] argv);
         private static _getBoxCentroid _getBoxCentroidFunc;
         internal static IntPtr getBoxCentroid(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_getBoxCentroidFunc == null)
         	{
         		_getBoxCentroidFunc =
         			(_getBoxCentroid)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditorSelection_getBoxCentroid"), typeof(_getBoxCentroid));
         	}
         
         	return  _getBoxCentroidFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _offset(IntPtr thisPtr, int argc, string[] argv);
         private static _offset _offsetFunc;
         internal static void offset(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_offsetFunc == null)
         	{
         		_offsetFunc =
         			(_offset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditorSelection_offset"), typeof(_offset));
         	}
         
         	 _offsetFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _union(IntPtr thisPtr, int argc, string[] argv);
         private static _union _unionFunc;
         internal static void union(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_unionFunc == null)
         	{
         		_unionFunc =
         			(_union)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditorSelection_union"), typeof(_union));
         	}
         
         	 _unionFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _subtract(IntPtr thisPtr, int argc, string[] argv);
         private static _subtract _subtractFunc;
         internal static void subtract(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_subtractFunc == null)
         	{
         		_subtractFunc =
         			(_subtract)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditorSelection_subtract"), typeof(_subtract));
         	}
         
         	 _subtractFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _WorldEditorSelection_create();
         private static _WorldEditorSelection_create _WorldEditorSelection_createFunc;
         internal static IntPtr WorldEditorSelection_create()
         {
         	if (_WorldEditorSelection_createFunc == null)
         	{
         		_WorldEditorSelection_createFunc =
         			(_WorldEditorSelection_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_WorldEditorSelection_create"), typeof(_WorldEditorSelection_create));
         	}
         
         	return  _WorldEditorSelection_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool containsGlobalBounds()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return InternalUnsafeMethods.containsGlobalBounds(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual string getCentroid()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return Marshal.PtrToStringUni(InternalUnsafeMethods.getCentroid(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
         public virtual string getBoxCentroid()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return Marshal.PtrToStringUni(InternalUnsafeMethods.getBoxCentroid(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
         public virtual void offset(VectorF delta, float gridSnap = 0)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.Add(delta.ToString());
                  tmp_arg_list.Add(gridSnap.ToString());
                  InternalUnsafeMethods.offset(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void union(SimSet set)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.Add(set.getId().ToString());
                  InternalUnsafeMethods.union(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void subtract()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.subtract(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}