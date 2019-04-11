using NUnit.Framework;

namespace BoardGame.Tests
{
    public class GameTests
    {
        [TestCase("MRMLMRM", 2, 2, "E")]
        [TestCase("RMMMLMM", 3, 2, "N")]
        [TestCase("MMMMM", 0, 4, "N")]
        public void ShouldReturnCorrectResultsForGivenCommands(string commands, int expectedX, int expectedY, string expectedDirection)
        {
            //arrange
            var game = new Game();

            // act
            var gameResult = game.Play(commands);

            // assert
            Assert.AreEqual(expectedX, gameResult.X);
            Assert.AreEqual(expectedY, gameResult.Y);
            Assert.AreEqual(expectedDirection, gameResult.Direction);
        }
    }
}
