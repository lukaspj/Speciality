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
         setFieldValue("currentHealth", getFieldValue("maxHealth"));
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
         GameBord bord = GameBord.GetGameBord();
         Point3F rotation = obj.GetEulerRotation();
         List<SimplePlayer> players = new List<SimplePlayer>();
         float x = (float)(obj.Position.X + bord.GameSizeX * Math.Cos(rotation.Z));
         float y = (float)(obj.Position.Y + bord.GameSizeY * Math.Sin(rotation.Z));
         float yExtend = bord.GameSizeY;
         float xExtend = bord.GameSizeX ;
         
         Point3F boxSearchMid = new Point3F(x,y, 2);
         string player = Global.containerFindFirst((uint) ObjectTypes.PlayerObjectType, boxSearchMid,
            new Point3F(xExtend, yExtend, 2));

         
         while (player != "")
         {
            Console.WriteLine(player);
            SimplePlayer foundPlayer = Sim.FindObject<SimplePlayer>(player);
            //Same player that we search with
            if (foundPlayer.getId().ToString() == obj.getId().ToString())
            {
               player = Global.containerFindNext();
               continue;
            }
            // angle from line of sight alpha is greater than half of FOV
            Point2F objPoint = new Point2F(obj.Position.X, obj.Position.Y);
            float objZRoation = rotation.Z;
            Point2F otherPoint = new Point2F(foundPlayer.Position.X, foundPlayer.Position.Y);
            double alpha = objZRoation - Math.Atan((otherPoint.Y - objPoint.Y) / (otherPoint.X - objPoint.X));
            if (alpha > (obj.getCameraFov() / 2))
            {
               player = Global.containerFindNext();
               continue;
            }

            // Cast a ray between the players reporting if we hit something other than a player
            string stuck = Global.containerRayCast(obj.Position, foundPlayer.Position, (uint) ObjectTypes.StaticObjectType);
            if (stuck != "")
            {
               player = Global.containerFindNext();
               continue;
            }
            players.Add(foundPlayer);
            player = Global.containerFindNext();
         }
         return players;
      }

      public static double GetDamagePropability(SimplePlayer obj, SimplePlayer other)
      {
         Point2F objPoint = new Point2F(obj.Position.X, obj.Position.Y);
         float objZRoation = obj.GetEulerRotation().Z;
         Point2F otherPoint = new Point2F(other.Position.X,other.Position.Y);
         double alpha = objZRoation - Math.Atan((otherPoint.Y - objPoint.Y) / (otherPoint.X - objPoint.X));
         double distance = Point2F.Distance(objPoint, otherPoint);
         double distanceFromLOS = distance * Math.Sin(alpha);
         Normal dist = new Normal(0, float.Parse(obj.DataBlock.getFieldValue("variance")));
         double max = dist.Maximum;
         double normalizingMult = 1 / max;
         double killProp = dist.Density(distanceFromLOS) * normalizingMult;
         return killProp;
      }
   }

}
