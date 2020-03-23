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
        [TestCase(15,15,"Fifteen-All")]
        [TestCase(15,30,"Fifteen-Thirty")]
        [TestCase(30,15,"Thirty-Fifteen")]
        [TestCase(30,30,"Thirty-All")]
        [TestCase(40,30,"Fourty-Thirty")]
        public void GiveScoresTheResultShouldBeAsExpected(int score1, int score2, string expected)
        {
            // arrange
            TennisGame game = new TennisGame(score1,score2);
            
            // action
            Assert.AreEqual(expected, game.display() );
        }
       
    }
}