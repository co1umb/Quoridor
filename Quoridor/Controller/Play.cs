using System;
using System.Collections.Generic;
using System.Text;
using Quoridor.Model;

namespace Quoridor.Menu
{
    class Play
    {
        Process process = new Process();
        Process2 process2 = new Process2();

        public void AgainstPlayer()
        {
            Console.Clear();
            process.StartGame();
      
        }
        public void AgainstBot()
        {
            Console.Clear();
            process2.Game();

        }
    }
}
