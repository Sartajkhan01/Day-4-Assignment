﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Assignment
{
    internal class UC4_WinningPosition
    {
        static void Main(string[] args)
        {
            const int noPlayOption = 0;
            const int ladderOption = 1;
            const int snakeOption = 2;
            const int playerOne = 1;
            int positionOne = 0;
            while (positionOne < 100)
            {
                Random random = new Random();
                int dieRoll = random.Next(1, 7);
                int options = random.Next(0, 3);
                switch (options)
                {
                    case noPlayOption:
                        positionOne = positionOne + 0;
                        break;
                    case ladderOption:
                        positionOne = positionOne + dieRoll;
                        break;
                    case snakeOption:
                        positionOne = positionOne - dieRoll;
                        if (positionOne < 0)
                        {
                            positionOne = 0;
                        }
                        break;
                }
            }
            Console.WriteLine("Player Wins with Position :" + positionOne);
        }
    }
}
