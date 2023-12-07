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
                        int r = 0, g = 0, b = 0;
                        var roundItems = round.Split(",");
                        
                        foreach (var item in roundItems) 
                        { 
                            var parts = item.Trim().Split(' ');

                            switch (parts[1])
                            {
                                case "red":
                                    r += int.Parse(parts[0]);
                                    break;
                                case "green":
                                    g += int.Parse(parts[0]);
                                    break;
                                case "blue":
                                    b += int.Parse(parts[0]);
                                    break;
                                default:
                                    break;
                            }
                        }

                        var gr = new GameIteration.GameRound
                        {
                            RedCount = r,
                            GreenCount = g,
                            BlueCount = b
                        };

                        iteration.Rounds.Add(gr);
                    }

                    _iterationList.Add(iteration);
                }
            } catch (Exception ex) 
            {
                Console.WriteLine (ex.Message);
                return false;
            }

            return true;
        }

        public int RunSimulation ()
        {
            return 0;
        }
    }
}
