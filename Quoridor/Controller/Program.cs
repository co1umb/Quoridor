using Quoridor.Map;
using Quoridor.Menu;
using Quoridor.MoveChar;
using System;
using System.Threading;

namespace Quoridor
{
    class Program
    {
        static void Main(string[] args)
        {
            StartMenu startMenu = new StartMenu();
            startMenu.BeginMenu();
        }
    }
}