using System;
using System.Collections.Generic;

namespace tennis.test
{
    public enum Player
    {
        One,
        Two
    }
    public class TennisGame
    {

        private static string[] SCORES = new string[] { "Love", "Fifteen", "Thirty", "Fourty" };

        private static Dictionary<int, int> ScoreMap = new Dictionary<int, int>{
            { 0, 0},
            { 15, 1},
            { 30, 2},
            { 40, 3}
        };

        private Dictionary<Player, int> PlayerScore = new Dictionary<Player, int>{
            { Player.One, 0},
            { Player.Two, 0},
        };

        public TennisGame(int score1, int score2)
        {
            PlayerScore[Player.One] = ScoreMap[score1];
            PlayerScore[Player.Two] = ScoreMap[score2];
        }

        public String display()
        {
            if (PlayerScore[Player.One] == PlayerScore[Player.Two])
            {
                if (PlayerScore[Player.One] == 3)
                    return "Deuce";
                return $"{SCORES[PlayerScore[Player.One]]}-All";
            }

            return $"{SCORES[PlayerScore[Player.One]]}-{SCORES[PlayerScore[Player.Two]]}";
        }

        public String scores(Player player)
        {
            PlayerScore[player]++;

            if (PlayerScore[player] == 4 && PlayerScore[Opponent(player)] != 3)
                return $"Player {getPlayerName(player)} Wins";
            else if (PlayerScore[player] == 4 && PlayerScore[Opponent(player)] == 3)
                return $"Player {getPlayerName(player)} Advantage";
                
            return display();
        }

        private Player Opponent(Player player)
        {
            if (player == Player.One)
                return Player.Two;

            return Player.One;
        }

        private String getPlayerName(Player player)
        {
            string playerText = "One";
            if (player == Player.Two)
            {
                playerText = "Two";
            }
            return playerText;
        }
    }
}