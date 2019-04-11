using BoardGame.BoardMoves;
using NUnit.Framework;

namespace BoardGame.Tests.BoardMoves
{
    public class MoveSouthCommandHandlerTests
    {
        [Test]
        public void ShouldBeAbleToHandleCommandWhenMoveDirectionIsSouth()
        {
            // arrange
            var command = new MoveForwardCommand
            {
                Direction = Directions.Directions.South
            };

            var handler = new MoveSouthCommandHandler();

            // act
            var canHandle = handler.CanHandle(command);

            // assert
            Assert.IsTrue(canHandle);
        }

        [Test]
        public void ShouldNotBeAbleToHandleCommandWhenMoveDirectionIsNotSouth()
        {
            // arrange
            var command = new MoveForwardCommand
            {
                Direction = Directions.Directions.North
            };

            var handler = new MoveSouthCommandHandler();

            // act
            var canHandle = handler.CanHandle(command);

            // assert
            Assert.IsFalse(canHandle);
        }

        [Test]
        public void ShouldReturnFieldYDecreasedByOneWhenMovingSouthFromFieldWithPositiveYValue()
        {
            // arrange
            var initialField = new Field
            {
                Y = 2
            };

            var handler = new MoveSouthCommandHandler();

            // act
            var newField = handler.Move(initialField);

            // assert
            Assert.AreEqual(1, newField.Y);
        }

        [Test]
        public void ShouldReturn0WhenMovingSouthFromFieldWith0YValue()
        {
            // arrange
            var initialField = new Field
            {
                Y = 0
            };

            var handler = new MoveSouthCommandHandler();

            // act
            var newField = handler.Move(initialField);

            // assert
            Assert.AreEqual(0, newField.Y);
        }

    }
}
