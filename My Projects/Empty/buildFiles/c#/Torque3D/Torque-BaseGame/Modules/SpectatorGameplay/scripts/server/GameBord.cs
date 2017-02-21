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
      public static int _gameSizeX;
      public static int _gameSizeY;
      public  int GameSizeX => _gameSizeX;
      public int GameSizeY => _gameSizeY;
      private bool[,] gameBord;
      private string shape = "data/spectatorGameplay/art/GameShapes/player.dts";
      public static float _wallHeight = 1.5f;
      public GameBord(int sizeX, int sizeY)
      {
         _gameSizeX = sizeX % 2 == 0 ? ++sizeX : sizeX;
         _gameSizeY = sizeY % 2 == 0 ? ++sizeY : sizeY;
         gameBord = new bool[_gameSizeX, _gameSizeY];
         for (int x = 0; x < _gameSizeX; x++)
         {
            for (int y = 0; y < _gameSizeY; y++)
            {
               gameBord[x, y] = false;
            }
         }
      }

      private static GameBord _gameBord = null;
      public static GameBord GetGameBord(int sizeX = 10, int sizeY = 10)
      {
         if (_gameBord == null)
         {
            _gameBord = new GameBord(sizeX,sizeY);
         }
         return _gameBord;
      }

      private int PointToX(Point3F point)
      {

         int pointToX = (int)point.X + _gameSizeX / 2;
         return pointToX;
       
      }
      private int PointToY(Point3F point)
      {
         int pointToY = (int)point.Y + _gameSizeY / 2;
         return pointToY;
         
      }

      private Point3F XYToPoint(int x, int y)
      {
         return new Point3F(x - _gameSizeX /2, y - _gameSizeY / 2, 0);
      }
      public bool IsOccupied(Point3F point)
      {
         int x = PointToX(point);
         int y = PointToY(point);
         return IsOccupied(x, y);
      }

      public bool IsOccupied(int x, int y)
      {
         if (x >= _gameSizeX || x < 0 || y >= _gameSizeY || y < 0)
            return true;
         else return gameBord[x, y];
      }

      //I use that the shape is has unit size in x and y
      public void AddShape(TSStatic shape)
      {
         Point3F point = shape.Position;
         Point3F scale = shape.Scale;
         int xPos = PointToX(point);
         int yPos = PointToY(point);
         for (int x = xPos - (int) (scale.X / 2); x <= xPos + (int) (scale.X / 2); x++)
         {
            for (int y = yPos - (int) (scale.Y / 2); y <= yPos + (int) (scale.Y / 2); y++)
            {
               if (x >= _gameSizeX || x < 0 || y >= _gameSizeY || y < 0)
               {
                  continue;
               }
               gameBord[x, y] = true;
            }
         } 
      }

      public Point3F PickPlayerSpawn(Point3F point)
      {

         int x = PointToX(point);
         int y = PointToY(point);
         int i_step = 1;
         bool isAdding = true;
         if (!IsOccupied(x, y))
         {
            gameBord[x, y] = true;

            return XYToPoint(x, y);
         }
         while (true)
         {
            for (int i = 0; i < i_step; i++)
            {
               if (!IsOccupied(isAdding ? ++x : --x, y))
               {
                  gameBord[x, y] = true;

                  return XYToPoint(x, y);
               }
            }
            for (int i = 0; i < i_step; i++)
            {
               if (!IsOccupied(x, isAdding ? ++y : --y)) 
               {
                  gameBord[x, y] = true;

                  return XYToPoint(x, y);
               }
            }
            i_step++;
            isAdding = !isAdding;
         }
      }

      public void CreateBoundingBox()
      {
         SimGroup obstacleGroup = Sim.FindObject<SimGroup>("Obstacles");
         float rightWallPos = _gameSizeX / 2;
         float leftWallPos = -_gameSizeX / 2;
         float frontWallpos = _gameSizeY / 2;
         float backWallPos = -_gameSizeY / 2;
         TSStatic rightWall = new TSStatic()
         {
            ShapeName = shape,
            Position = XYToPoint(_gameSizeX-1,(_gameSizeY-1)/2),
            CollisionType = TSMeshType.Bounds,
            Scale = new Point3F(1, _gameSizeY, _wallHeight)
         };
         TSStatic leftWall = new TSStatic()
         {
            ShapeName = shape,
            Position = XYToPoint(0,(_gameSizeY-1)/2),
            CollisionType = TSMeshType.Bounds,
            Scale = new Point3F(1, GameSizeY, _wallHeight)
         };
         TSStatic frontWall = new TSStatic()
         {
            ShapeName = shape,
            Position = XYToPoint((_gameSizeX-1)/2, 0),
            CollisionType = TSMeshType.Bounds,
            Scale = new Point3F(_gameSizeX, 1, _wallHeight)
         };
         TSStatic backWall = new TSStatic()
         {
            ShapeName = shape,
            Position = XYToPoint((_gameSizeX-1)/2,_gameSizeY-1),
            CollisionType = TSMeshType.Bounds,
            Scale = new Point3F(_gameSizeX, 1, _wallHeight)
         };
         rightWall.registerObject();
         leftWall.registerObject();
         frontWall.registerObject();
         backWall.registerObject();
         AddShape(rightWall);
         AddShape(leftWall);
         AddShape(frontWall);
         AddShape(backWall);
         obstacleGroup.add(leftWall);
         obstacleGroup.add(rightWall);
         obstacleGroup.add(frontWall);
         obstacleGroup.add(backWall);
      }

      public void GenerateRandomObstacles(int count)
      {
         SimGroup obstacleGroup = Sim.FindObject<SimGroup>("Obstacles");
         Random rand = new Random();
         for (int i = 0; i < count; i++)
         {
            int xpos = rand.Next(0, _gameSizeX-1);
            int ypos = rand.Next(0, _gameSizeY-1);
            int xscale = rand.Next(1, 10);
            int yscale =  rand.Next(1, 10);
            if (xpos + xscale / 2 > _gameSizeX - 1)
            {
               xscale = (_gameSizeX - 1 - xpos) * 2;
            }
            if (xpos - xscale / 2 < 0)
            {
               xscale = xpos / 2;
            }
            if (ypos + yscale / 2 > _gameSizeY - 1)
            {
               yscale = (_gameSizeY - 1 - ypos) * 2;
            }
            if (ypos - yscale / 2 < 0)
            {
               yscale = ypos / 2;
            }
            if (xscale == 0 || yscale == 0)
            {
               //dont add the obstacle and try to add another one instead if the scale is 0.
               i--;
               continue;
            }
            TSStatic obstacle = new TSStatic()
            {
               ShapeName = shape,
               Position = XYToPoint(xpos,ypos),
               CollisionType = TSMeshType.Bounds,
               Scale = new Point3F(xscale, yscale, _wallHeight)
            };
            obstacle.registerObject();
            AddShape(obstacle);
            obstacleGroup.add(obstacle);
         }
      }


   }
}
