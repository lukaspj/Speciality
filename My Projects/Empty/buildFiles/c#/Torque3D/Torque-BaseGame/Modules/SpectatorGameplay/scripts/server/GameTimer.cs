using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torque3D;

namespace Game.Modules.SpectatorGameplay.scripts.server
{
   [ConsoleClass]
   class GameTimer : ScriptTickObject
   {
      private readonly string _cbFunction;
      private readonly int _tickCount;
      private int _currentCount;

      public GameTimer(string pCbFunction, int pTickCount, bool pRegister = false) : base(pRegister)
      {
         _cbFunction = pCbFunction;
         _tickCount = pTickCount;
         Name = "GameTimer";
      }

      public void start()
      {
         _currentCount = _tickCount;
         setProcessTicks(true);
      }

      public void stop()
      {
         setProcessTicks(false);
      }

      public void onProcessTick()
      {
         _currentCount--;
         Global.call(_cbFunction, _currentCount.ToString());
         if (_currentCount == 0)
         {
            _currentCount = _tickCount;
         }
      }
   }
}
