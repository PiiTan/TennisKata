using NUnit.Framework;

namespace tennis.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Give00TheResultShouldBeLoveAll()
        {
            // arrange
            TennisGame game = new TennisGame(0,0);
            
            // action
            Assert.AreEqual( "Love-All", game.display() );
        }

        [Test]
        public void Give015TheResultShouldBeLoveFifteen()
        {
            // arrange
            TennisGame game = new TennisGame(0,15);
            
            // action
            Assert.AreEqual( "Love-Fifteen", game.display() );
        }
        [Test]
        public void Give150TheResultShouldBeFifteenLove()
        {
            // arrange
            TennisGame game = new TennisGame(15,0);
            
            // action
            Assert.AreEqual( "Fifteen-Love", game.display() );
        }
    }
}