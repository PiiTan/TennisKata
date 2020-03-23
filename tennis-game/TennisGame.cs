using System;

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
            string result = string.Empty;
            if(_score1 == 0) {
                result += "Love";
            }
            else {
                result += "Fifteen";
            }

            result += "-";

            if (_score1 == _score2) {
                result += "All";
            }
            else if(_score2 == 15) {
                result += "Fifteen";
            }
            else {
                result += "Love";
            }
            return result;
        }
    }
}