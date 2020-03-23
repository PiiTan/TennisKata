using NUnit.Framework;

namespace tennis.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // Start: Score Display
        [TestCase(0, 0, "Love-All")]
        [TestCase(0, 15, "Love-Fifteen")]
        [TestCase(15, 0, "Fifteen-Love")]
        [TestCase(15, 15, "Fifteen-All")]
        [TestCase(15, 30, "Fifteen-Thirty")]
        [TestCase(30, 15, "Thirty-Fifteen")]
        [TestCase(30, 30, "Thirty-All")]
        [TestCase(40, 30, "Fourty-Thirty")]
        [TestCase(30, 40, "Thirty-Fourty")]
        [TestCase(40, 40, "Deuce")]
        public void GiveScoresTheResultShouldBeAsExpected(int score1, int score2, string expected)
        {
            // arrange
            TennisGame game = new TennisGame(score1, score2);

            // action
            Assert.AreEqual(expected, game.display());
        }
        // End: Score Display
        [Test]
        public void ScoreShouldIncrementPlayerScore()
        {
            TennisGame game = new TennisGame(0, 0);

            Assert.AreEqual("Fifteen-Love", game.scores(Player.One));
        }
        [TestCase(Player.One, "Player One Wins")]
        [TestCase(Player.Two, "Player Two Wins")]
        public void PlayerWinsIfPlayerAlreadyScores40AndOtherPlayerIsNotAt40(Player player, string expected)
        {
            TennisGame game;

            if (player == Player.One)
            {
                game = new TennisGame(40, 0);
            }
            else
            {
                game = new TennisGame(0, 40);
            }

            Assert.AreEqual(expected, game.scores(player));
        }
        [TestCase(Player.One, "Player One Advantage")]
        [TestCase(Player.Two, "Player Two Advantage")]
        public void PlayerGainAdvantageOnDeuce(Player player, string expected)
        {
            TennisGame game = new TennisGame(40,40);

            Assert.AreEqual(expected, game.scores(player));
        }

        [TestCase(Player.One)]
        [TestCase(Player.Two)]
        public void PlayerReturnToDeuceOnAdvantage(Player player)
        {
            TennisGame game = new TennisGame(40,40);
            game.scores(Opponent(player));

            Assert.AreEqual("Deuce", game.scores(player));
        }
        private Player Opponent(Player player)
        {
            if (player == Player.One)
                return Player.Two;

            return Player.One;
        }
    }
}