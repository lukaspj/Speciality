using System;
using System.Collections.Generic;
using System.Linq;
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

      public static SimplePlayer searchForPlayers(SimplePlayer obj, GameBord bord)
      {
         Point3F boxSearchMid = new Point3F(obj.Position.X + bord.GameSizeX, obj.Position.Y + bord.GameSizeY, 2);
         string player = Global.containerFindFirst((uint) ObjectTypes.PlayerObjectType, boxSearchMid,
            new Point3F(bord.GameSizeX, bord.GameSizeY, 2));

         
         while (player != "")
         {
            Console.WriteLine(player);
            Player foundPlayer = Sim.FindObject<Player>(player);
            if (foundPlayer.getId().ToString() == obj.getId().ToString())
            {
               player = Global.containerFindNext();
               continue;
            }

            string stuck = Global.containerRayCast(obj.Position, foundPlayer.Position, (uint) ObjectTypes.StaticObjectType);
            Console.WriteLine(stuck);
            player = Global.containerFindNext();
         }
         return null;
      }

      public static double GetKillPropability(SimplePlayer obj, SimplePlayer other)
      {
         Point2F objPoint = new Point2F(obj.Position.X, obj.Position.Y);
         float objZRoation = obj.Rotation.Z;
         Point2F otherPoint = new Point2F(other.Position.X,other.Position.Y);
         double distance = Point2F.Distance(objPoint, otherPoint);
         double alpha = objZRoation - Math.Atan((otherPoint.Y - objPoint.Y) / (otherPoint.X - objPoint.X));
         double distanceFromLOS = distance * Math.Sin(alpha);
         
         Normal dist = new Normal(0, float.Parse(obj.DataBlock.getFieldValue("variance")));
         double max = dist.Maximum;
         double normalizingMult = 1 / max;
         double killProp = dist.Density(distanceFromLOS) * normalizingMult;
         return killProp;
      }
   }

}
