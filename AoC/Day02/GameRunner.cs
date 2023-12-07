using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AoC.Day02
{
    internal class GameRunner
    {
        private readonly GameConfiguration _gameConfiguration;
        private List<GameIteration> _iterationList = new List<GameIteration>();

        public GameRunner (GameConfiguration gameConfiguration)
        {
            _gameConfiguration = gameConfiguration;
        }

        public bool TryLoadInputFile(string filePath)
        {
            // split : for 2 lines then ; for n lines then , for n lines
            try
            {
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    var game = line.Split(':');
                    
                    if (game.Length != 2)
                    {
                        return false;
                    }

                    int gameNum;
                    if (!int.TryParse(
                            game[0].Replace("Game", "").Trim(), 
                            out gameNum))
                    {
                        return false;
                    }

                    var rounds = game[1].Split(";");
                    var iteration = new GameIteration(_gameConfiguration)
                    {
                        GameNumber = gameNum
                    };

                    foreach (var round in rounds)
                    {
                        iteration.Rounds.Add(ParseRoundLine(round));
                    }
                }
            } catch (Exception ex) 
            {
                Console.WriteLine (ex.Message);
            }

            return false;
        }

        private GameIteration.GameRound ParseRoundLine(string roundLine)
        {
            var gr = new GameIteration.GameRound();
            var items = roundLine.Split(",");

            gr.RedCount = items switch
            { 
                [var amount, "red"] => int.Parse(amount),
                _ => 0
            };

            gr.BlueCount = items switch
            {
                [var amount, "blue"] => int.Parse(amount),
                _ => 0
            };

            gr.GreenCount = items switch
            {
                [var amount, "green"] => int.Parse(amount),
                _ => 0
            };

            return gr;
        }

        public int RunSimulation ()
        {
            return 0;
        }
    }
}
