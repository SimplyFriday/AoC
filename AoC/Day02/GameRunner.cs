using System;
using System.Collections.Generic;
using System.Linq;
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
            return false;
        }

        public int RunSimulation ()
        {
            return 0;
        }
    }
}
