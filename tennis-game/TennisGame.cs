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
            return "Love-All";
        }
    }
}