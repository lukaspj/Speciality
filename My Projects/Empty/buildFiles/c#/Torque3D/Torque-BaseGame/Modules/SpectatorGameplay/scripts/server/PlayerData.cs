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
using tPlayer = Torque3D.Player;
using tPlayerData = Torque3D.PlayerData;
using MathNet.Numerics.Distributions;
using Torque3D.Engine.Util.Enums;

namespace Game.Modules.SpectatorGameplay.scripts.server
{
   [ConsoleClass]
   class PlayerData : tPlayerData
   {
      private int corpseTimeoutValue = 40 * 100;
      

      public void onAdd(tPlayer obj)
      {
      }

      public void onRemove(tPlayer obj)
      {
         int clientid = obj.getControllingClient();
         GameConnectionToClient client = Sim.FindObjectById<GameConnectionToClient>((uint)clientid);
         // TODO i guess this is now how to do it :S
         if (obj.Name == client.getFieldValue("player"))
         {
            client.setFieldValue("player", "0");
         }
      }

      public void onCollision(tPlayer obj, SceneObject col, VectorF vec, float len)
      {
         if(!Global.isObject(col.Name) || obj.getState() == "Dead")
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

      public static List<Player> searchForPlayers(Player obj, GameBord bord)
      {
         List<Player> players = new List<Player>();
         float x = (float)(obj.Position.X + bord.GameSizeX * Math.Cos(obj.Rotation.Z));
         float y = (float)(obj.Position.Y + bord.GameSizeY * Math.Sin(obj.Rotation.Z));
         float yExtend = bord.GameSizeY;
         float xExtend = bord.GameSizeX ;
         
         Point3F boxSearchMid = new Point3F(x,y, 2);
         string player = Global.containerFindFirst((uint) ObjectTypes.PlayerObjectType, boxSearchMid,
            new Point3F(xExtend, yExtend, 2));

         
         while (player != "")
         {
            Console.WriteLine(player);
            Player foundPlayer = Sim.FindObject<Player>(player);
            //Same player that we search with
            if (foundPlayer.getId().ToString() == obj.getId().ToString())
            {
               player = Global.containerFindNext();
               continue;
            }
            // angle from line of sight alpha is greater than half of FOV
            Point2F objPoint = new Point2F(obj.Position.X, obj.Position.Y);
            float objZRoation = obj.Rotation.Z;
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

      public double GetKillPropability(Player obj, Player other)
      {
         Point2F objPoint = new Point2F(obj.Position.X, obj.Position.Y);
         float objZRoation = obj.Rotation.Z;
         Point2F otherPoint = new Point2F(other.Position.X,other.Position.Y);
         double alpha = objZRoation - Math.Atan((otherPoint.Y - objPoint.Y) / (otherPoint.X - objPoint.X));
         double distance = Point2F.Distance(objPoint, otherPoint);
         double distanceFromLOS = distance * Math.Sin(alpha);
         
         Normal dist = new Normal(0, float.Parse(getFieldValue("variance")));
         double max = dist.Maximum;
         double normalizingMult = 1 / max;
         double killProp = dist.Density(distanceFromLOS) * normalizingMult;
         return killProp;
      }
   }

}
