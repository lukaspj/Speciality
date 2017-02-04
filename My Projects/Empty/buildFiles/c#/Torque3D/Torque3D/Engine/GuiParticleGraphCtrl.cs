using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiParticleGraphCtrl : GuiControl
	{
		public GuiParticleGraphCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiParticleGraphCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiParticleGraphCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiParticleGraphCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiParticleGraphCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiParticleGraphCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiParticleGraphCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSelectedPoint(IntPtr thisPtr, int point);
         private static _setSelectedPoint _setSelectedPointFunc;
         internal static void setSelectedPoint(IntPtr thisPtr, int point)
         {
         	if (_setSelectedPointFunc == null)
         	{
         		_setSelectedPointFunc =
         			(_setSelectedPoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_setSelectedPoint"), typeof(_setSelectedPoint));
         	}
         
         	 _setSelectedPointFunc(thisPtr, point);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSelectedPlot(IntPtr thisPtr, int plotID);
         private static _setSelectedPlot _setSelectedPlotFunc;
         internal static void setSelectedPlot(IntPtr thisPtr, int plotID)
         {
         	if (_setSelectedPlotFunc == null)
         	{
         		_setSelectedPlotFunc =
         			(_setSelectedPlot)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_setSelectedPlot"), typeof(_setSelectedPlot));
         	}
         
         	 _setSelectedPlotFunc(thisPtr, plotID);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearGraph(IntPtr thisPtr, int plotID);
         private static _clearGraph _clearGraphFunc;
         internal static void clearGraph(IntPtr thisPtr, int plotID)
         {
         	if (_clearGraphFunc == null)
         	{
         		_clearGraphFunc =
         			(_clearGraph)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_clearGraph"), typeof(_clearGraph));
         	}
         
         	 _clearGraphFunc(thisPtr, plotID);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearAllGraphs(IntPtr thisPtr);
         private static _clearAllGraphs _clearAllGraphsFunc;
         internal static void clearAllGraphs(IntPtr thisPtr)
         {
         	if (_clearAllGraphsFunc == null)
         	{
         		_clearAllGraphsFunc =
         			(_clearAllGraphs)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_clearAllGraphs"), typeof(_clearAllGraphs));
         	}
         
         	 _clearAllGraphsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _addPlotPoint(IntPtr thisPtr, int plotID, float x, float y, bool setAdded);
         private static _addPlotPoint _addPlotPointFunc;
         internal static int addPlotPoint(IntPtr thisPtr, int plotID, float x, float y, bool setAdded)
         {
         	if (_addPlotPointFunc == null)
         	{
         		_addPlotPointFunc =
         			(_addPlotPoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_addPlotPoint"), typeof(_addPlotPoint));
         	}
         
         	return  _addPlotPointFunc(thisPtr, plotID, x, y, setAdded);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _insertPlotPoint(IntPtr thisPtr, int plotID, int i, float x, float y);
         private static _insertPlotPoint _insertPlotPointFunc;
         internal static void insertPlotPoint(IntPtr thisPtr, int plotID, int i, float x, float y)
         {
         	if (_insertPlotPointFunc == null)
         	{
         		_insertPlotPointFunc =
         			(_insertPlotPoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_insertPlotPoint"), typeof(_insertPlotPoint));
         	}
         
         	 _insertPlotPointFunc(thisPtr, plotID, i, x, y);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _changePlotPoint(IntPtr thisPtr, int plotID, int i, float x, float y);
         private static _changePlotPoint _changePlotPointFunc;
         internal static int changePlotPoint(IntPtr thisPtr, int plotID, int i, float x, float y)
         {
         	if (_changePlotPointFunc == null)
         	{
         		_changePlotPointFunc =
         			(_changePlotPoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_changePlotPoint"), typeof(_changePlotPoint));
         	}
         
         	return  _changePlotPointFunc(thisPtr, plotID, i, x, y);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSelectedPlot(IntPtr thisPtr);
         private static _getSelectedPlot _getSelectedPlotFunc;
         internal static int getSelectedPlot(IntPtr thisPtr)
         {
         	if (_getSelectedPlotFunc == null)
         	{
         		_getSelectedPlotFunc =
         			(_getSelectedPlot)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_getSelectedPlot"), typeof(_getSelectedPlot));
         	}
         
         	return  _getSelectedPlotFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSelectedPoint(IntPtr thisPtr);
         private static _getSelectedPoint _getSelectedPointFunc;
         internal static int getSelectedPoint(IntPtr thisPtr)
         {
         	if (_getSelectedPointFunc == null)
         	{
         		_getSelectedPointFunc =
         			(_getSelectedPoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_getSelectedPoint"), typeof(_getSelectedPoint));
         	}
         
         	return  _getSelectedPointFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isExistingPoint(IntPtr thisPtr, int plotID, int samples);
         private static _isExistingPoint _isExistingPointFunc;
         internal static bool isExistingPoint(IntPtr thisPtr, int plotID, int samples)
         {
         	if (_isExistingPointFunc == null)
         	{
         		_isExistingPointFunc =
         			(_isExistingPoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_isExistingPoint"), typeof(_isExistingPoint));
         	}
         
         	return  _isExistingPointFunc(thisPtr, plotID, samples);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint2FStruct _getPlotPoint(IntPtr thisPtr, int plotID, int samples);
         private static _getPlotPoint _getPlotPointFunc;
         internal static InternalPoint2FStruct getPlotPoint(IntPtr thisPtr, int plotID, int samples)
         {
         	if (_getPlotPointFunc == null)
         	{
         		_getPlotPointFunc =
         			(_getPlotPoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_getPlotPoint"), typeof(_getPlotPoint));
         	}
         
         	return  _getPlotPointFunc(thisPtr, plotID, samples);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getPlotIndex(IntPtr thisPtr, int plotID, float x, float y);
         private static _getPlotIndex _getPlotIndexFunc;
         internal static int getPlotIndex(IntPtr thisPtr, int plotID, float x, float y)
         {
         	if (_getPlotIndexFunc == null)
         	{
         		_getPlotIndexFunc =
         			(_getPlotIndex)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_getPlotIndex"), typeof(_getPlotIndex));
         	}
         
         	return  _getPlotIndexFunc(thisPtr, plotID, x, y);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalColorFStruct _getGraphColor(IntPtr thisPtr, int plotID);
         private static _getGraphColor _getGraphColorFunc;
         internal static InternalColorFStruct getGraphColor(IntPtr thisPtr, int plotID)
         {
         	if (_getGraphColorFunc == null)
         	{
         		_getGraphColorFunc =
         			(_getGraphColor)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_getGraphColor"), typeof(_getGraphColor));
         	}
         
         	return  _getGraphColorFunc(thisPtr, plotID);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint2FStruct _getGraphMin(IntPtr thisPtr, int plotID);
         private static _getGraphMin _getGraphMinFunc;
         internal static InternalPoint2FStruct getGraphMin(IntPtr thisPtr, int plotID)
         {
         	if (_getGraphMinFunc == null)
         	{
         		_getGraphMinFunc =
         			(_getGraphMin)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_getGraphMin"), typeof(_getGraphMin));
         	}
         
         	return  _getGraphMinFunc(thisPtr, plotID);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint2FStruct _getGraphMax(IntPtr thisPtr, int plotID);
         private static _getGraphMax _getGraphMaxFunc;
         internal static InternalPoint2FStruct getGraphMax(IntPtr thisPtr, int plotID)
         {
         	if (_getGraphMaxFunc == null)
         	{
         		_getGraphMaxFunc =
         			(_getGraphMax)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_getGraphMax"), typeof(_getGraphMax));
         	}
         
         	return  _getGraphMaxFunc(thisPtr, plotID);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getGraphName(IntPtr thisPtr, int plotID);
         private static _getGraphName _getGraphNameFunc;
         internal static IntPtr getGraphName(IntPtr thisPtr, int plotID)
         {
         	if (_getGraphNameFunc == null)
         	{
         		_getGraphNameFunc =
         			(_getGraphName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_getGraphName"), typeof(_getGraphName));
         	}
         
         	return  _getGraphNameFunc(thisPtr, plotID);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setGraphMin(IntPtr thisPtr, int plotID, float minX, float minY);
         private static _setGraphMin _setGraphMinFunc;
         internal static void setGraphMin(IntPtr thisPtr, int plotID, float minX, float minY)
         {
         	if (_setGraphMinFunc == null)
         	{
         		_setGraphMinFunc =
         			(_setGraphMin)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_setGraphMin"), typeof(_setGraphMin));
         	}
         
         	 _setGraphMinFunc(thisPtr, plotID, minX, minY);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setGraphMinX(IntPtr thisPtr, int plotID, float minX);
         private static _setGraphMinX _setGraphMinXFunc;
         internal static void setGraphMinX(IntPtr thisPtr, int plotID, float minX)
         {
         	if (_setGraphMinXFunc == null)
         	{
         		_setGraphMinXFunc =
         			(_setGraphMinX)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_setGraphMinX"), typeof(_setGraphMinX));
         	}
         
         	 _setGraphMinXFunc(thisPtr, plotID, minX);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setGraphMinY(IntPtr thisPtr, int plotID, float minX);
         private static _setGraphMinY _setGraphMinYFunc;
         internal static void setGraphMinY(IntPtr thisPtr, int plotID, float minX)
         {
         	if (_setGraphMinYFunc == null)
         	{
         		_setGraphMinYFunc =
         			(_setGraphMinY)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_setGraphMinY"), typeof(_setGraphMinY));
         	}
         
         	 _setGraphMinYFunc(thisPtr, plotID, minX);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setGraphMax(IntPtr thisPtr, int plotID, float maxX, float maxY);
         private static _setGraphMax _setGraphMaxFunc;
         internal static void setGraphMax(IntPtr thisPtr, int plotID, float maxX, float maxY)
         {
         	if (_setGraphMaxFunc == null)
         	{
         		_setGraphMaxFunc =
         			(_setGraphMax)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_setGraphMax"), typeof(_setGraphMax));
         	}
         
         	 _setGraphMaxFunc(thisPtr, plotID, maxX, maxY);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setGraphMaxX(IntPtr thisPtr, int plotID, float maxX);
         private static _setGraphMaxX _setGraphMaxXFunc;
         internal static void setGraphMaxX(IntPtr thisPtr, int plotID, float maxX)
         {
         	if (_setGraphMaxXFunc == null)
         	{
         		_setGraphMaxXFunc =
         			(_setGraphMaxX)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_setGraphMaxX"), typeof(_setGraphMaxX));
         	}
         
         	 _setGraphMaxXFunc(thisPtr, plotID, maxX);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setGraphMaxY(IntPtr thisPtr, int plotID, float maxX);
         private static _setGraphMaxY _setGraphMaxYFunc;
         internal static void setGraphMaxY(IntPtr thisPtr, int plotID, float maxX)
         {
         	if (_setGraphMaxYFunc == null)
         	{
         		_setGraphMaxYFunc =
         			(_setGraphMaxY)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_setGraphMaxY"), typeof(_setGraphMaxY));
         	}
         
         	 _setGraphMaxYFunc(thisPtr, plotID, maxX);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setGraphHidden(IntPtr thisPtr, int plotID, bool isHidden);
         private static _setGraphHidden _setGraphHiddenFunc;
         internal static void setGraphHidden(IntPtr thisPtr, int plotID, bool isHidden)
         {
         	if (_setGraphHiddenFunc == null)
         	{
         		_setGraphHiddenFunc =
         			(_setGraphHidden)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_setGraphHidden"), typeof(_setGraphHidden));
         	}
         
         	 _setGraphHiddenFunc(thisPtr, plotID, isHidden);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setAutoGraphMax(IntPtr thisPtr, bool autoMax);
         private static _setAutoGraphMax _setAutoGraphMaxFunc;
         internal static void setAutoGraphMax(IntPtr thisPtr, bool autoMax)
         {
         	if (_setAutoGraphMaxFunc == null)
         	{
         		_setAutoGraphMaxFunc =
         			(_setAutoGraphMax)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_setAutoGraphMax"), typeof(_setAutoGraphMax));
         	}
         
         	 _setAutoGraphMaxFunc(thisPtr, autoMax);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setAutoRemove(IntPtr thisPtr, bool autoRemove);
         private static _setAutoRemove _setAutoRemoveFunc;
         internal static void setAutoRemove(IntPtr thisPtr, bool autoRemove)
         {
         	if (_setAutoRemoveFunc == null)
         	{
         		_setAutoRemoveFunc =
         			(_setAutoRemove)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_setAutoRemove"), typeof(_setAutoRemove));
         	}
         
         	 _setAutoRemoveFunc(thisPtr, autoRemove);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setRenderAll(IntPtr thisPtr, bool autoRemove);
         private static _setRenderAll _setRenderAllFunc;
         internal static void setRenderAll(IntPtr thisPtr, bool autoRemove)
         {
         	if (_setRenderAllFunc == null)
         	{
         		_setRenderAllFunc =
         			(_setRenderAll)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_setRenderAll"), typeof(_setRenderAll));
         	}
         
         	 _setRenderAllFunc(thisPtr, autoRemove);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setPointXMovementClamped(IntPtr thisPtr, bool autoRemove);
         private static _setPointXMovementClamped _setPointXMovementClampedFunc;
         internal static void setPointXMovementClamped(IntPtr thisPtr, bool autoRemove)
         {
         	if (_setPointXMovementClampedFunc == null)
         	{
         		_setPointXMovementClampedFunc =
         			(_setPointXMovementClamped)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_setPointXMovementClamped"), typeof(_setPointXMovementClamped));
         	}
         
         	 _setPointXMovementClampedFunc(thisPtr, autoRemove);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setRenderGraphTooltip(IntPtr thisPtr, bool autoRemove);
         private static _setRenderGraphTooltip _setRenderGraphTooltipFunc;
         internal static void setRenderGraphTooltip(IntPtr thisPtr, bool autoRemove)
         {
         	if (_setRenderGraphTooltipFunc == null)
         	{
         		_setRenderGraphTooltipFunc =
         			(_setRenderGraphTooltip)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_setRenderGraphTooltip"), typeof(_setRenderGraphTooltip));
         	}
         
         	 _setRenderGraphTooltipFunc(thisPtr, autoRemove);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setGraphName(IntPtr thisPtr, int plotID, [MarshalAs(UnmanagedType.LPWStr)]string graphName);
         private static _setGraphName _setGraphNameFunc;
         internal static void setGraphName(IntPtr thisPtr, int plotID, [MarshalAs(UnmanagedType.LPWStr)]string graphName)
         {
         	if (_setGraphNameFunc == null)
         	{
         		_setGraphNameFunc =
         			(_setGraphName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_setGraphName"), typeof(_setGraphName));
         	}
         
         	 _setGraphNameFunc(thisPtr, plotID, graphName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _resetSelectedPoint(IntPtr thisPtr);
         private static _resetSelectedPoint _resetSelectedPointFunc;
         internal static void resetSelectedPoint(IntPtr thisPtr)
         {
         	if (_resetSelectedPointFunc == null)
         	{
         		_resetSelectedPointFunc =
         			(_resetSelectedPoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiParticleGraphCtrl_resetSelectedPoint"), typeof(_resetSelectedPoint));
         	}
         
         	 _resetSelectedPointFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiParticleGraphCtrl_create();
         private static _GuiParticleGraphCtrl_create _GuiParticleGraphCtrl_createFunc;
         internal static IntPtr GuiParticleGraphCtrl_create()
         {
         	if (_GuiParticleGraphCtrl_createFunc == null)
         	{
         		_GuiParticleGraphCtrl_createFunc =
         			(_GuiParticleGraphCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiParticleGraphCtrl_create"), typeof(_GuiParticleGraphCtrl_create));
         	}
         
         	return  _GuiParticleGraphCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setSelectedPoint(int point)
         {
            InternalUnsafeMethods.setSelectedPoint(ObjectPtr, point);
         }
      
         public virtual void setSelectedPlot(int plotID)
         {
            InternalUnsafeMethods.setSelectedPlot(ObjectPtr, plotID);
         }
      
         public virtual void clearGraph(int plotID)
         {
            InternalUnsafeMethods.clearGraph(ObjectPtr, plotID);
         }
      
         public virtual void clearAllGraphs()
         {
            InternalUnsafeMethods.clearAllGraphs(ObjectPtr);
         }
      
         public virtual int addPlotPoint(int plotID, float x, float y, bool setAdded = true)
         {
            return InternalUnsafeMethods.addPlotPoint(ObjectPtr, plotID, x, y, setAdded);
         }
      
         public virtual void insertPlotPoint(int plotID, int i, float x, float y)
         {
            InternalUnsafeMethods.insertPlotPoint(ObjectPtr, plotID, i, x, y);
         }
      
         public virtual int changePlotPoint(int plotID, int i, float x, float y)
         {
            return InternalUnsafeMethods.changePlotPoint(ObjectPtr, plotID, i, x, y);
         }
      
         public virtual int getSelectedPlot()
         {
            return InternalUnsafeMethods.getSelectedPlot(ObjectPtr);
         }
      
         public virtual int getSelectedPoint()
         {
            return InternalUnsafeMethods.getSelectedPoint(ObjectPtr);
         }
      
         public virtual bool isExistingPoint(int plotID, int samples)
         {
            return InternalUnsafeMethods.isExistingPoint(ObjectPtr, plotID, samples);
         }
      
         public virtual Point2F getPlotPoint(int plotID, int samples)
         {
            return new Point2F(InternalUnsafeMethods.getPlotPoint(ObjectPtr, plotID, samples));
         }
      
         public virtual int getPlotIndex(int plotID, float x, float y)
         {
            return InternalUnsafeMethods.getPlotIndex(ObjectPtr, plotID, x, y);
         }
      
         public virtual ColorF getGraphColor(int plotID)
         {
            return new ColorF(InternalUnsafeMethods.getGraphColor(ObjectPtr, plotID));
         }
      
         public virtual Point2F getGraphMin(int plotID)
         {
            return new Point2F(InternalUnsafeMethods.getGraphMin(ObjectPtr, plotID));
         }
      
         public virtual Point2F getGraphMax(int plotID)
         {
            return new Point2F(InternalUnsafeMethods.getGraphMax(ObjectPtr, plotID));
         }
      
         public virtual string getGraphName(int plotID)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getGraphName(ObjectPtr, plotID));
         }
      
         public virtual void setGraphMin(int plotID, float minX, float minY)
         {
            InternalUnsafeMethods.setGraphMin(ObjectPtr, plotID, minX, minY);
         }
      
         public virtual void setGraphMinX(int plotID, float minX)
         {
            InternalUnsafeMethods.setGraphMinX(ObjectPtr, plotID, minX);
         }
      
         public virtual void setGraphMinY(int plotID, float minX)
         {
            InternalUnsafeMethods.setGraphMinY(ObjectPtr, plotID, minX);
         }
      
         public virtual void setGraphMax(int plotID, float maxX, float maxY)
         {
            InternalUnsafeMethods.setGraphMax(ObjectPtr, plotID, maxX, maxY);
         }
      
         public virtual void setGraphMaxX(int plotID, float maxX)
         {
            InternalUnsafeMethods.setGraphMaxX(ObjectPtr, plotID, maxX);
         }
      
         public virtual void setGraphMaxY(int plotID, float maxX)
         {
            InternalUnsafeMethods.setGraphMaxY(ObjectPtr, plotID, maxX);
         }
      
         public virtual void setGraphHidden(int plotID, bool isHidden)
         {
            InternalUnsafeMethods.setGraphHidden(ObjectPtr, plotID, isHidden);
         }
      
         public virtual void setAutoGraphMax(bool autoMax)
         {
            InternalUnsafeMethods.setAutoGraphMax(ObjectPtr, autoMax);
         }
      
         public virtual void setAutoRemove(bool autoRemove)
         {
            InternalUnsafeMethods.setAutoRemove(ObjectPtr, autoRemove);
         }
      
         public virtual void setRenderAll(bool autoRemove)
         {
            InternalUnsafeMethods.setRenderAll(ObjectPtr, autoRemove);
         }
      
         public virtual void setPointXMovementClamped(bool autoRemove)
         {
            InternalUnsafeMethods.setPointXMovementClamped(ObjectPtr, autoRemove);
         }
      
         public virtual void setRenderGraphTooltip(bool autoRemove)
         {
            InternalUnsafeMethods.setRenderGraphTooltip(ObjectPtr, autoRemove);
         }
      
         public virtual void setGraphName(int plotID, string graphName)
         {
            InternalUnsafeMethods.setGraphName(ObjectPtr, plotID, graphName);
         }
      
         public virtual void resetSelectedPoint()
         {
            InternalUnsafeMethods.resetSelectedPoint(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}