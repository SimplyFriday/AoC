﻿namespace AoC.Day02
{
    internal class GameIteration
    {
        public GameConfiguration gameConfiguration;
        public List<GameRound> Rounds { get; set; } = new List<GameRound>();
        GameIteration( GameConfiguration configuration){
            gameConfiguration = configuration;
        }

        public bool IsPossible(GameConfiguration configuration)
        {
            foreach (var round in Rounds){
                switch round {
                    case round.RedCount > gameConfiguration.MaxRedCount: return false;
                    case round.RedCount > gameConfiguration.MaxRedCount: return false;
                    case round.RedCount > gameConfiguration.MaxRedCount: return false;
                } 
            }
            return true; 
        }

    public class GameRound
    {
        public int RedCount { get; set; }
        public int BlueCount { get; set; }
        public int GreenCount { get; set; }
    }
}
}
