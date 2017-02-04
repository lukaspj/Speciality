using System;
using System.Runtime.InteropServices;
using Torque3D.Engine;
/*
namespace Torque3D
{
   public unsafe class SimObject : IDisposable
   {
      public Sim.SimObjectPtr* ObjectPtr { get; protected set; }

      public SimObject()
      {
         //ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.SimObjectCreateInstance());
      }

      public SimObject(uint pId)
      {
         //ObjectPtr = Sim.FindObjectWrapperById(pId);
      }

      public SimObject(string pName)
      {
         //ObjectPtr = Sim.FindObjectWrapperByName(pName);
      }

      public SimObject(IntPtr pObjPtr)
      {
         //ObjectPtr = Sim.WrapObject(pObjPtr);
      }

      public SimObject(Sim.SimObjectPtr* pObjPtr)
      {
         ObjectPtr = pObjPtr;
      }

      public SimObject(SimObject pObj)
      {
         ObjectPtr = pObj.ObjectPtr;
      }

      public string GetName()
      {
         return "";
      }

      public void SetPointerFromObject(SimObject obj)
      {
         ObjectPtr = obj.ObjectPtr;
      }

      public bool IsDead()
      {
         return ObjectPtr->ObjPtr == IntPtr.Zero;
      }

      public uint GetID()
      {
         return 0;
      }

      #region IDisposable

      public void Dispose()
      {
         Dispose(true);
         GC.SuppressFinalize(this);
      }

      protected virtual void Dispose(bool pDisposing)
      {
         if (ObjectPtr->ObjPtr != IntPtr.Zero)
         {
            Marshal.FreeHGlobal((IntPtr)ObjectPtr);
         }
      }

      ~SimObject()
      {
         Dispose(false);
      }

      #endregion
   }
}
*/