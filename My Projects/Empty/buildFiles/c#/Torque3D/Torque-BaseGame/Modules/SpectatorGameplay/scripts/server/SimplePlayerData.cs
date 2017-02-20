using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Torque3D.Engine;
using Torque3D;
using Torque3D.Util;
using Game.Modules.ClientServer.Server;
using tSimplePlayerData = Torque3D.SimplePlayerData;
using MathNet.Numerics.Distributions;
using Torque3D.Engine.Util.Enums;

namespace Game.Modules.SpectatorGameplay.scripts.server
{
   [ConsoleClass]
   class SimplePlayerData : tSimplePlayerData
   {
      private int corpseTimeoutValue = 40 * 100;
      

      public void onAdd(SimplePlayer obj)
      {
      }

      public void onRemove(SimplePlayer obj)
      {
         int clientid = obj.getControllingClient();
         GameConnectionToClient client = Sim.FindObjectById<GameConnectionToClient>((uint)clientid);
         // TODO i guess this is now how to do it :S
         if (obj.Name == client.getFieldValue("player"))
         {
            client.setFieldValue("player", "0");
         }
      }

      public void onCollision(SimplePlayer obj, SceneObject col, VectorF vec, float len)
      {
         if(!Global.isObject(col.Name)/* || obj.getState() == "Dead"*/)
         {
            return;
         }

         if(col.getClassName() == "Item")
         {
            //TODO is this how to do it ???
            obj.call("pickup", col.Name);
            return;
         }
         if(col.getClassName() == "StaticShape") {
            obj.setVelocity(new Point3F(0, 0, 0));
         }
         
      }


      public static List<SimplePlayer> searchForPlayers(SimplePlayer obj)
      {
         SimGroup Players = Sim.FindObject<SimGroup>("Players");
         if (Players == null) return null;

         List<SimplePlayer> retList = new List<SimplePlayer>();
         for (uint i = 0; i < Players.getCount(); i++)
         {
            SimplePlayer other = Players.getObject(i).As<SimplePlayer>();
            if (obj == other) continue;
            if(obj.CanSee(other)) retList.Add(other);
         }
         return retList;
      }

      [ConsoleFunction]
      public static double GetDamagePropability(SimplePlayer obj, SimplePlayer other)
      {
         
         Point2F objPoint = new Point2F(obj.Position.X, obj.Position.Y);
         float objZRoation = obj.GetEulerRotation().Z;// > Math.PI ? obj.GetEulerRotation().Z - (float)Math.PI /2 : obj.GetEulerRotation().Z + (float) Math.PI /2;
         Point2F otherPoint = new Point2F(other.Position.X,other.Position.Y);
         double tanObjOther = (otherPoint.X - objPoint.X) / (otherPoint.Y - objPoint.Y);
         double alpha;
         if (tanObjOther > 0)
         {
            alpha = objZRoation - Math.Atan(tanObjOther);
         }
         else
         {
            alpha = Math.PI - objZRoation - Math.Atan(tanObjOther);
         }

         double distance = Point2F.Distance(objPoint, otherPoint);
         double distanceFromLOS = distance * Math.Sin(alpha);
         Normal dist = new Normal(0, float.Parse(obj.DataBlock.getFieldValue("variance")));
         double normalizingMult = 1 / dist.Density(dist.Median);
         double killProp = dist.Density(distanceFromLOS) * normalizingMult;
         SetDamageProbText(obj.Name, (float)killProp);
         return killProp;
      }

      [ConsoleFunction]
      public static void SetDamageProbText(string playerName, float value)
      {
         GuiTextCtrl text = Sim.FindObject<GuiTextCtrl>(playerName + "damage");
         if (text != null)
         {
            text.setText("Damage%: " + (int)(value * 1000) / 10.0f);
         }
      }
   }

}
