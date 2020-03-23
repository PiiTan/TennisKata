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
    }
}