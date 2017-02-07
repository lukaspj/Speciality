using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torque3D;
using Torque3D.Engine;
using Torque3D.Util;

namespace Game.Modules.SpectatorGameplay.scripts.server
{
   class GameBord
   {
      private int _gameSizeX;
      private int _gameSizeY;
      public int GameSizeX => _gameSizeX;
      public int GameSizeY => _gameSizeY;
      private bool[,] gameBord;
      
      public GameBord(int sizeX, int sizeY)
      {
         _gameSizeX = sizeX;
         _gameSizeY = sizeY;
         gameBord = new bool[_gameSizeX, _gameSizeY];
         for (int x = 0; x < _gameSizeX; x++)
         {
            for (int y = 0; y < _gameSizeY; y++)
            {
               gameBord[x, y] = false;
            }
         }
      }

      private int pointToX(Point3F point)
      {
         return (int)point.X + _gameSizeX / 2;
      }
      private int pointToY(Point3F point)
      {
         return (int)point.Y + _gameSizeY / 2;
      }
      public bool IsOccupied(Point3F point)
      {
         int x = pointToX(point);
         int y = pointToY(point);
         if (x >= _gameSizeX || x < 0 || y >= _gameSizeY || y < 0)
            return true;
         else return gameBord[x, y];
      } 

      //I use that the shape is has unit size in x and y
      public void AddShape(TSStatic shape)
      {
         Point3F point = shape.Position;
         Point3F scale = shape.Scale;
         int xPos = pointToX(point);
         int yPos = pointToY(point);
         for (int x = xPos - (int) scale.X / 2; x < xPos + (int) scale.X / 2; x++)
         {
            for (int y = yPos - (int) scale.Y / 2; y < yPos + (int) scale.Y / 2; y++)
            {
               if (x >= _gameSizeX || x < 0 || y >= _gameSizeY || y < 0)
               {
                  continue;
               }
               gameBord[x, y] = true;
            }
         } 
      }

      public Point3F PickPlayerSpawn()
      {
         int x = _gameSizeX /2;
         int y = _gameSizeY /2;
         while (!gameBord[x, y])
         {
            y = (y + 1) % (_gameSizeY-1);
            if (y == 0)
            {
               x = (x + 1) % (_gameSizeX -1);
            }
         }

         return new Point3F(x-_gameSizeX / 2 - 0.6f ,y-_gameSizeY / 2 - 0.6f,0);
      }

      public void CreateBoundingBox()
      {
         float rightWallPos = _gameSizeX / 2;
         float leftWallPos = -_gameSizeX / 2;
         float frontWallpos = _gameSizeY / 2;
         float backWallPos = -_gameSizeY / 2;

         TSStatic rightWall = new TSStatic()
         {
            ShapeName = "data/spectatorGameplay/art/GameShapes/player.dts",
            Position = new Point3F(rightWallPos, 0, 1),
            CollisionType = TSMeshType.Bounds,
            Scale = new Point3F(1, _gameSizeY, 0.5f)
         };
         TSStatic leftWall = new TSStatic()
         {
            ShapeName = "data/spectatorGameplay/art/GameShapes/player.dts",
            Position = new Point3F(leftWallPos, 0, 1),
            CollisionType = TSMeshType.Bounds,
            Scale = new Point3F(1, GameSizeY, 0.5f)
         };
         TSStatic frontWall = new TSStatic()
         {
            ShapeName = "data/spectatorGameplay/art/GameShapes/player.dts",
            Position = new Point3F(0, frontWallpos, 1),
            CollisionType = TSMeshType.Bounds,
            Scale = new Point3F(_gameSizeX, 1, 0.5f)
         };
         TSStatic backWall = new TSStatic()
         {
            ShapeName = "data/spectatorGameplay/art/GameShapes/player.dts",
            Position = new Point3F(0, backWallPos, 1),
            CollisionType = TSMeshType.Bounds,
            Scale = new Point3F(_gameSizeX, 1, 0.5f)
         };
         rightWall.registerObject();
         leftWall.registerObject();
         frontWall.registerObject();
         backWall.registerObject();
         AddShape(rightWall);
         AddShape(leftWall);
         AddShape(frontWall);
         AddShape(backWall);

      }

      public void GenerateRandomObstacles(int count)
      {

         Random rand = new Random();
         for (int i = 0; i < count; i++)
         {
            int xpos = rand.Next(-_gameSizeX / 2, _gameSizeX / 2);
            int ypos = rand.Next(-_gameSizeX / 2, _gameSizeY / 2);
            int x;
            int xscale = (x = rand.Next(0, 5)) == 0 ? 1 : x *2;
            int y;
            int yscale = (y = rand.Next(0, 5)) == 0 ? 1 : y *2;
            TSStatic obstacle = new TSStatic()
            {
               ShapeName = "data/spectatorGameplay/art/GameShapes/player.dts",
               Position = new Point3F(xpos, ypos, 1),
               CollisionType = TSMeshType.Bounds,
               Scale = new Point3F(xscale, yscale, 0.5f)
            };
            obstacle.registerObject();
            AddShape(obstacle);
         }
      }


   }
}
