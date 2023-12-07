using System;
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

            Console.Write("Enter the game input file location: ");
            var inputFilePath = Console.ReadLine();

            if (string.IsNullOrEmpty(inputFilePath))
            {
                Console.WriteLine("Invalid path. Press enter to continue:");
                return;
            }

            var gameRunner = new GameRunner(gameConfig);
            GameIteration? gameIteration; 

            if (gameRunner.TryLoadInputFile(inputFilePath, out gameIteration))
            {
                Console.WriteLine($"The result for Day 2 is: {gameRunner.RunSimulation()}");
            }

        }
    }
}
