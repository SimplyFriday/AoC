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
            GameRound lowestCounts = new GameRound
            {
                RedCount = int.MaxValue,
                BlueCount = int.MaxValue,
                GreenCount = int.MaxValue
            };

            foreach (GameRound round in Rounds)
            {
                lowestCounts.RedCount = round.RedCount < lowestCounts.RedCount ?
                                        round.RedCount : lowestCounts.RedCount;

                lowestCounts.BlueCount = round.BlueCount < lowestCounts.BlueCount ?
                                         round.BlueCount : lowestCounts.BlueCount;

                lowestCounts.GreenCount = round.GreenCount < lowestCounts.GreenCount ?
                                          round.GreenCount : lowestCounts.GreenCount;
            }

            //called power bc thats what the puzzle called it
            int power = lowestCounts.RedCount * lowestCounts.BlueCount * lowestCounts.GreenCount;
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
