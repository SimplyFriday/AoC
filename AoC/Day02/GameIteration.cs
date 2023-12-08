namespace AoC.Day02
{
    internal class GameIteration
    {
        public int GameNumber { get; set; }
        public GameConfiguration gameConfiguration;
        public List<GameRound> Rounds { get; set; } = new List<GameRound>();

        public GameIteration(GameConfiguration configuration)
        {
            gameConfiguration = configuration;
        }

        public bool IsPossible()
        {
            foreach (GameRound round in Rounds)
            {
                if (
                    round.RedCount > gameConfiguration.MaxRedCount ||
                    round.BlueCount > gameConfiguration.MaxBlueCount ||
                    round.GreenCount > gameConfiguration.MaxGreenCount
                ) return false;
            }
            return true;
        }

        public int powerOfLowestPossible() {
            GameRound highestCounts = new GameRound
            {
                RedCount = 0,
                BlueCount = 0,
                GreenCount = 0
            };

            foreach (GameRound round in Rounds)
            {
                highestCounts.RedCount = round.RedCount > highestCounts.RedCount ?
                                        round.RedCount : highestCounts.RedCount;

                highestCounts.BlueCount = round.BlueCount > highestCounts.BlueCount ?
                                         round.BlueCount : highestCounts.BlueCount;

                highestCounts.GreenCount = round.GreenCount > highestCounts.GreenCount ?
                                          round.GreenCount : highestCounts.GreenCount;
            }

            //called power bc thats what the puzzle called it
            int power = highestCounts.RedCount * highestCounts.BlueCount * highestCounts.GreenCount;
            return power;
        }
        
        public struct GameRound
        {
            public int RedCount { get; set; }
            public int BlueCount { get; set; }
            public int GreenCount { get; set; }
        }
    }
}
