using Quoridor.Map;
using Quoridor.Menu;
using Quoridor.MoveChar;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Quoridor
{
    class Process
    {
        public void StartGame()
        {
            int costx = 17;
            int x = 9;
            int y = 1;
            int part = 0;
            int costx1 = 17;
            int y1 = 17;
            int x1 = 9;
            int name1 = 5;
            int name2 = 4;
            int contsW = 0;
            int contsP = 0;
            int[,] field1 = new int[19, 19];
            Field field = new Field();
            field1 = field.Map();
            PlayerStep stepp = new PlayerStep();
            PlayerWall stepw = new PlayerWall();
            ResultOfGame resultPage = new ResultOfGame();
           

            while (true)
            {
                field.CreateField(field1);
                Console.WriteLine($"Ход игрока {part + 1}");
                Console.WriteLine("Двигаться(1) или поставить стенку(2)? \n" +
                    "*для ротации стены нажать Пробел");
                string step = Console.ReadLine();
                if (part == 0)
                {

                    switch (step)
                    {
                        case "1":
                            while (true)
                            {
                                if (contsP == 0)
                                {
                                    Console.Clear();
                                    field.CreateField(field1);
                                    stepp.StepPlayer(ref costx, ref y, ref x, ref name1, ref field1, ref contsP);
                                }
                                else
                                {
                                    resultPage.Check(name1, y);
                                    part++;
                                    contsP--; break;
                                }
                            }
                            Console.Clear(); break;
                        case "2":
                            while (true)
                            {
                                if (contsW == 0)
                                {
                                    Console.Clear();
                                    field.CreateField(field1);
                                    stepw.StepW(ref field1, ref contsW);
                                }
                                else
                                {
                                    field.CreateField(field1);
                                    contsW--;
                                    part++; break;
                                }

                            }
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Невозможно(нажмите любую кнопку для продолжение)");
                            Console.ReadKey();
                            Console.Clear(); break;

                    }
                }
                else if (part == 1)
                {

                    switch (step)
                    {
                        case "1":
                            while (true)
                            {
                                if(contsP == 0)
                                {
                                    Console.Clear();
                                    field.CreateField(field1);
                                    stepp.StepPlayer(ref costx1, ref y1, ref x1, ref name2, ref field1, ref contsP);
                                }
                                else 
                                {
                                    resultPage.Check(name2, y1);
                                    part--;
                                    contsP--; break; 
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
                                    field.CreateField(field1);
                                    stepw.StepW(ref field1, ref contsW);
                                }
                                else
                                {
                                    field.CreateField(field1);
                                    contsW--;
                                    part--; break;
                                }

                            }
                            Console.Clear(); break;
                        default:
                            Console.WriteLine("Невозможно(нажмите любую кнопку для продолжение)");
                            Console.ReadKey();
                            Console.Clear(); break;
                    }
                }
            }
        }
    }
}
