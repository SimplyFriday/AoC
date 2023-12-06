namespace AoC.Day02
{
    internal class GameIteration
    {
        public List<GameRound> Rounds { get; set; } = new List<GameRound>();

        public bool IsPossible (GameConfiguration configuration)
        {
            return false;
        }

        public class GameRound
        {
            public int RedCount { get; set; }
            public int BlueCount { get; set; }
            public int GreenCount { get; set; }
        }
    }
}
