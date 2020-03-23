using System;
using System.Collections.Generic;

namespace tennis.test
{
    public class TennisGame
    {
        private int _score1;
        private int _score2;

        public TennisGame(int score1, int score2)
        {
            this._score1 = score1;
            this._score2 = score2;
        }

        public String display()
        {
            var ScoreMap = new Dictionary<int, string>{
                { 0, "Love" },
                { 15, "Fifteen" },
                  { 30, "Thirty" },
            };

            string result = ScoreMap[_score1];
            
            result += "-";

            if (_score1 == _score2) {
                result += "All";
            }
            else 
                result += ScoreMap[_score2];
            

            return result;
        }
    }
}