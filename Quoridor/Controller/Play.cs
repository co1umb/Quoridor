using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.Menu
{
    class Play
    {
        Process process = new Process();

        public void AgainstPlayer()
        {
            Console.Clear();
            process.StartGame();
      
        }
    }
}
