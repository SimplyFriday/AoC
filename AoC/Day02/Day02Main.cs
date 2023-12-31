﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC.Day02
{
    internal class Day02Main
    {
        public void Run()
        {
            var gameConfig = new GameConfiguration
            {
                MaxRedCount = 12,
                MaxGreenCount = 13,
                MaxBlueCount = 14
            };

            //Console.Write("Enter the game input file location: ");
            //var inputFilePath = Console.ReadLine();
            string inputFilePath = "../../../Day02/2.txt";
            if (string.IsNullOrEmpty(inputFilePath))
            {
                Console.WriteLine("Invalid path. Press enter to continue:");
                Console.ReadKey();
                return;
            }

            var gameRunner = new GameRunner(gameConfig);

            if (gameRunner.TryLoadInputFile(inputFilePath))
            {
                Console.WriteLine($"The result for Day 2 is: {gameRunner.RunSimulation()}\nPress any key to continue:");
                Console.ReadKey();
            }

        }
    }
}
