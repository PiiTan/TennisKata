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

        private int _score1;
        private int _score2;
        private static string[] SCORES = new string[] { "Love", "Fifteen", "Thirty", "Fourty" };

        private static Dictionary<int, int> ScoreMap = new Dictionary<int, int>{
            { 0, 0},
            { 15, 1},
            { 30, 2},
            { 40, 3}
        };
        public TennisGame(int score1, int score2)
        {
            this._score1 = ScoreMap[score1];
            this._score2 = ScoreMap[score2];
        }

        public String display()
        {
            if (_score1 == _score2)
            {
                if (_score1 == 3)
                    return "Deuce";
                return $"{SCORES[_score1]}-All";
            }

            return $"{SCORES[_score1]}-{SCORES[_score2]}";
        }

        public String scores(Player player)
        {
            if (player == Player.One)
                _score1++;
            else
                _score2++;

            // Check win conditions
            if (_score1 == 4 && _score2 != 3)
                return "Player One Wins";

            return display();
        }
    }
}