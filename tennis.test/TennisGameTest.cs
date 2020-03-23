using NUnit.Framework;

namespace tennis.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0,0,"Love-All")]
        [TestCase(0,15,"Love-Fifteen")]
        [TestCase(15,0,"Fifteen-Love")]
        public void GiveScoresTheResultShouldBeAsExpected(int score1, int score2, string expected)
        {
            // arrange
            TennisGame game = new TennisGame(score1,score2);
            
            // action
            Assert.AreEqual(expected, game.display() );
        }
       
    }
}