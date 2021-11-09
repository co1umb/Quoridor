﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.Model.Bot
{
    class BotWall
    {
        public int wallx = 15, wally = 8, topleft = 1;
        public int wallmapx = 8, wallmapy = 8, eight = 0;
        public void MoveWall(ref int[,] map, ref int contsW, int position)
        {
            Console.SetCursorPosition(wallx, wally);
            ConsoleKeyInfo wall = Console.ReadKey(true);
            if (position == 0) Console.Write("-");
            else Console.Write("|");

            if (wall.Key == ConsoleKey.LeftArrow && wallx - 4 >= 0 && map[wallmapy, wallmapx - 2] == 2)
            {
                if (wallmapx != 8 || wallmapy != 8 || eight == 0) map[wallmapy, wallmapx] = 2;
                wallx = wallx - 4;
                wallmapx = wallmapx - 2;
                if (topleft == 1)
                    map[wallmapy, wallmapx] = 7;
                else map[wallmapy, wallmapx] = 8;
            }
            if (wall.Key == ConsoleKey.RightArrow && wallx + 4 <= 34 && map[wallmapy, wallmapx + 2] == 2)
            {
                if (wallmapx != 8 || wallmapy != 8 || eight == 0) map[wallmapy, wallmapx] = 2;
                wallx = wallx + 4;
                wallmapx = wallmapx + 2;
                if (topleft == 1)
                    map[wallmapy, wallmapx] = 7;
                else map[wallmapy, wallmapx] = 8;
            }
            if (wall.Key == ConsoleKey.UpArrow && wally - 3 >= 0 && map[wallmapy - 2, wallmapx] == 2)
            {
                if (wallmapx != 8 || wallmapy != 8 || eight == 0) map[wallmapy, wallmapx] = 2;
                wally = wally - 2;
                wallmapy = wallmapy - 2;
                if (topleft == 1)
                    map[wallmapy, wallmapx] = 7;
                else map[wallmapy, wallmapx] = 8;
            }
            if (wall.Key == ConsoleKey.DownArrow && wally + 2 <= 17 && map[wallmapy + 2, wallmapx] == 2)
            {
                if (wallmapx != 8 || wallmapy != 8 || eight == 0) map[wallmapy, wallmapx] = 2;
                wally = wally + 2;
                wallmapy = wallmapy + 2;
                if (topleft == 1)
                    map[wallmapy, wallmapx] = 7;
                else map[wallmapy, wallmapx] = 8;
            }
            if (wall.Key == ConsoleKey.Enter)
            {
                wallx = 15;
                wally = 8;
                if (topleft == 1 && map[wallmapy + 1, wallmapx] != 7 && map[wallmapy - 1, wallmapx] != 7)
                {
                    map[wallmapy, wallmapx] = 7;
                    map[wallmapy - 1, wallmapx] = 7;
                    map[wallmapy + 1, wallmapx] = 7;
                    if (wallmapy == 8 && wallmapx == 8) eight++;
                    contsW++;
                }
                else if (topleft == 0 && map[wallmapy, wallmapx - 1] != 8 && map[wallmapy, wallmapx + 1] != 8)
                {
                    map[wallmapy, wallmapx] = 8;
                    map[wallmapy, wallmapx - 1] = 8;
                    map[wallmapy, wallmapx + 1] = 8;
                    if (wallmapy == 8 && wallmapx == 8) eight++;
                    contsW++;
                }
                else map[wallmapy, wallmapx] = 2;
                wallmapx = 8;
                wallmapy = 8;
            }
        }
    }
}
