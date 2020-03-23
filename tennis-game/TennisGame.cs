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
        private static Dictionary<int, string> ScoreMap = new Dictionary<int, string>{
                { 0, "Love" },
                { 15, "Fifteen" },
                  { 30, "Thirty" },
                  { 40, "Fourty" },
            };

        public TennisGame(int score1, int score2)
        {
            this._score1 = score1;
            this._score2 = score2;
        }

        public String display()
        {
            if (_score1 == _score2)
            {
                if (_score1 == 40)
                    return "Deuce";
                return $"{ScoreMap[_score1]}-All";
            }

            return $"{ScoreMap[_score1]}-{ScoreMap[_score2]}";
        }

        public String scores(Player player)
        {
            if (player == Player.One)
            {
                if (_score1 == 0)
                    _score1 = 15;
            }
            return display();
        }
    }
}