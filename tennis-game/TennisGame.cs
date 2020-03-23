using System;
using System.Collections.Generic;

namespace tennis.test
{
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
            string result = ScoreMap[_score1];
            
            result += "-";

            if (_score1 == _score2) {
                if (_score1 == 40)
                    return "Deuce";
                result += "All";
            }
            else 
                result += ScoreMap[_score2];
            
            return result;
        }
    }
}