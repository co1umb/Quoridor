using Quoridor.Map;
using Quoridor.Model.Bot;
using Quoridor.Model;
using System;
using Quoridor.MoveChar;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Quoridor.Menu;

namespace Quoridor.Model
{
    class Process2
    {
        public void Game()
    {
        int[,] map = new int[19, 19];
        Field drawMap = new Field();
        map = drawMap.Map();
        PlayerStep move = new PlayerStep();
        PlayerWall stepw = new PlayerWall();
        int costx = 17, y = 1, x = 9, part = 0;
        int costx1 = 17, y1 = 17, x1 = 9;
        int name1 = 5;
        int name2 = 4;
        int conts = 0;
        int contsW = 0;
        int contsP = 0;
        ResultOfGame resultPage = new ResultOfGame();

        BotWall aiBot = new BotWall();
        BotStep aIMove = new BotStep();
        Random random = new Random();
        while (true)
        {
            drawMap.CreateField(map);
            if (part == 0)
            {
                Console.WriteLine("Ходит Игрок");
                Console.WriteLine("Ходить или ставить стенку (1) или (2)?");
                string step = Console.ReadLine();
                switch (step)
                {
                    case "1":
                        while (true)
                        {
                            if (contsP == 0)
                            {
                                Console.Clear();
                                drawMap.CreateField(map);
                                move.StepPlayer(ref costx, ref y, ref x, ref name1, ref map, ref contsP);
                            }
                            else
                            {
                                resultPage.Check(name1, y);
                                part++;
                                contsP--;
                                break;
                            }
                        }

                        Console.Clear();
                        break;
                    case "2":
                        while (true)
                        {
                            if (contsW == 0)
                            {
                                Console.Clear();
                                drawMap.CreateField(map);
                                stepw.StepW(ref map, ref contsW);
                            }
                            else
                            {
                                drawMap.CreateField(map);
                                contsW--;
                                part++;
                                break;
                            }
                        }
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Не прввильно сделан ход (намжмите любую кнопку, чтобы продолжить)");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            else if (part == 1)
            {
                while (true)
                {
                    if (contsP == 0)
                    {
                        int rnd = random.Next(1, 4);
                        drawMap.CreateField(map);
                        aIMove.Move(ref costx1, ref y1, ref x1, ref name2, ref map, ref contsP, rnd);

                    }
                    else
                    {
                        resultPage.Check(name2, y1);
                        part--;
                        contsP--;
                        break;
                    }
                }
               
               
            }
        }

    }
    }
}
