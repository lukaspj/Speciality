using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiGraphCtrl : GuiControl
	{
		public GuiGraphCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiGraphCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiGraphCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiGraphCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiGraphCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiGraphCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiGraphCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addDatum(IntPtr thisPtr, int plotId, float value);
         private static _addDatum _addDatumFunc;
         internal static void addDatum(IntPtr thisPtr, int plotId, float value)
         {
         	if (_addDatumFunc == null)
         	{
         		_addDatumFunc =
         			(_addDatum)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiGraphCtrl_addDatum"), typeof(_addDatum));
         	}
         
         	 _addDatumFunc(thisPtr, plotId, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getDatum(IntPtr thisPtr, int plotId, int index);
         private static _getDatum _getDatumFunc;
         internal static float getDatum(IntPtr thisPtr, int plotId, int index)
         {
         	if (_getDatumFunc == null)
         	{
         		_getDatumFunc =
         			(_getDatum)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiGraphCtrl_getDatum"), typeof(_getDatum));
         	}
         
         	return  _getDatumFunc(thisPtr, plotId, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addAutoPlot(IntPtr thisPtr, int plotId, [MarshalAs(UnmanagedType.LPWStr)]string variable, int updateFrequency);
         private static _addAutoPlot _addAutoPlotFunc;
         internal static void addAutoPlot(IntPtr thisPtr, int plotId, [MarshalAs(UnmanagedType.LPWStr)]string variable, int updateFrequency)
         {
         	if (_addAutoPlotFunc == null)
         	{
         		_addAutoPlotFunc =
         			(_addAutoPlot)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiGraphCtrl_addAutoPlot"), typeof(_addAutoPlot));
         	}
         
         	 _addAutoPlotFunc(thisPtr, plotId, variable, updateFrequency);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeAutoPlot(IntPtr thisPtr, int plotId);
         private static _removeAutoPlot _removeAutoPlotFunc;
         internal static void removeAutoPlot(IntPtr thisPtr, int plotId)
         {
         	if (_removeAutoPlotFunc == null)
         	{
         		_removeAutoPlotFunc =
         			(_removeAutoPlot)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiGraphCtrl_removeAutoPlot"), typeof(_removeAutoPlot));
         	}
         
         	 _removeAutoPlotFunc(thisPtr, plotId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setGraphType(IntPtr thisPtr, int plotId, GuiGraphType graphType);
         private static _setGraphType _setGraphTypeFunc;
         internal static void setGraphType(IntPtr thisPtr, int plotId, GuiGraphType graphType)
         {
         	if (_setGraphTypeFunc == null)
         	{
         		_setGraphTypeFunc =
         			(_setGraphType)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiGraphCtrl_setGraphType"), typeof(_setGraphType));
         	}
         
         	 _setGraphTypeFunc(thisPtr, plotId, graphType);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _matchScale(IntPtr thisPtr, int argc, string[] argv);
         private static _matchScale _matchScaleFunc;
         internal static void matchScale(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_matchScaleFunc == null)
         	{
         		_matchScaleFunc =
         			(_matchScale)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiGraphCtrl_matchScale"), typeof(_matchScale));
         	}
         
         	 _matchScaleFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiGraphCtrl_create();
         private static _GuiGraphCtrl_create _GuiGraphCtrl_createFunc;
         internal static IntPtr GuiGraphCtrl_create()
         {
         	if (_GuiGraphCtrl_createFunc == null)
         	{
         		_GuiGraphCtrl_createFunc =
         			(_GuiGraphCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiGraphCtrl_create"), typeof(_GuiGraphCtrl_create));
         	}
         
         	return  _GuiGraphCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void addDatum(int plotId, float value)
         {
            InternalUnsafeMethods.addDatum(ObjectPtr, plotId, value);
         }
      
         public virtual float getDatum(int plotId, int index)
         {
            return InternalUnsafeMethods.getDatum(ObjectPtr, plotId, index);
         }
      
         public virtual void addAutoPlot(int plotId, string variable, int updateFrequency)
         {
            InternalUnsafeMethods.addAutoPlot(ObjectPtr, plotId, variable, updateFrequency);
         }
      
         public virtual void removeAutoPlot(int plotId)
         {
            InternalUnsafeMethods.removeAutoPlot(ObjectPtr, plotId);
         }
      
         public virtual void setGraphType(int plotId, GuiGraphType graphType)
         {
            InternalUnsafeMethods.setGraphType(ObjectPtr, plotId, graphType);
         }
      
         public virtual void matchScale(int plotID1, int plotID2)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.Add(plotID1.ToString());
                  tmp_arg_list.Add(plotID2.ToString());
                  InternalUnsafeMethods.matchScale(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
      
      #endregion


      #region Properties
      
      
         public float CenterY
         {
         	get { return float.Parse(getFieldValue("CenterY")); }
         	set { setFieldValue("CenterY", value.ToString()); }
         }
      
         public DynamicFieldVector<ColorF> PlotColor
         {
         	get { return new DynamicFieldVector<ColorF>(this, "PlotColor", 6, val => new ColorF(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<GuiGraphType> PlotType
         {
         	get { return new DynamicFieldVector<GuiGraphType>(this, "PlotType", 6, val => (GuiGraphType)Enum.Parse(typeof(GuiGraphType), val, true), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<string> PlotVariable
         {
         	get { return new DynamicFieldVector<string>(this, "PlotVariable", 6, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<int> PlotInterval
         {
         	get { return new DynamicFieldVector<int>(this, "PlotInterval", 6, val => int.Parse(val), obj => obj.ToString()); }
         }
      
      
      #endregion

	}
}