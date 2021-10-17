using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.Menu
{
    class StartMenu: Play
    {
        public void BeginMenu()
        {
            string choose;
            Console.WriteLine(
                "Начать (1) \n" +
                "Выход  (2)");
            choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    NextMenu(); break;
                case "2":
                    MenuExit(); break;
                default:
                    Console.WriteLine(
                        "Введите другой символ(1/2)"); break;
            }
        }
        public void NextMenu()
        {
            string choose;
            Console.WriteLine(
                "Старт игры против второго игрока (1)  \n" +
                "Вернуться назад (2)");            
            choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    AgainstPlayer();
                    NextMenu(); break;
                case "2":
                    BeginMenu(); break;
                default:
                    Console.WriteLine(
                        "Введите другой символ(1/2)"); break;

            }
        }
        public void MenuExit()
        {
            Console.WriteLine("Удачи!");
            return;
        }
    }
}
