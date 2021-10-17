using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.Menu
{
    class ResultOfGame: StartMenu
    {

        public void FirstPlayerWin()
        {
            Console.Clear();
            Console.WriteLine("Победа первого игрока! (нажмите любую кнопку для продолжения)");
            Console.ReadKey();
            Console.WriteLine();
            NextMenu();

        }
        public void SecondPlayerWin()
        {
            Console.Clear();
            Console.WriteLine("Победа второго игрока! (нажмите любую кнопку для продолжения)");
            Console.ReadKey();
            Console.WriteLine();
            NextMenu();

        }
        public void Check(int name, int playerY)
        {
            if (name == 5)
            {
                if (playerY == 17)
                {
                    FirstPlayerWin();
                }
            }
            if (name == 4)
            {
                if (playerY == 1)
                {
                    SecondPlayerWin();
                }
            }
        }
    }
}
