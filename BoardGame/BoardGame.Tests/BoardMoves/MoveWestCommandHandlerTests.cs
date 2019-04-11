using BoardGame.BoardMoves;
using NUnit.Framework;

namespace BoardGame.Tests.BoardMoves
{
    public class MoveWestCommandHandlerTests
    {
        [Test]
        public void ShouldBeAbleToHandleCommandWhenMoveDirectionIsWest()
        {
            // arrange
            var command = new MoveForwardCommand
            {
                Direction = Directions.Directions.West
            };

            var handler = new MoveWestCommandHandler();

            // act
            var canHandle = handler.CanHandle(command);

            // assert
            Assert.IsTrue(canHandle);
        }

        [Test]
        public void ShouldNotBeAbleToHandleCommandWhenMoveDirectionIsNotWest()
        {
            // arrange
            var command = new MoveForwardCommand
            {
                Direction = Directions.Directions.North
            };

            var handler = new MoveWestCommandHandler();

            // act
            var canHandle = handler.CanHandle(command);

            // assert
            Assert.IsFalse(canHandle);
        }

        [Test]
        public void ShouldReturnFieldXDecreasedByOneWhenMovingWestFromFieldWithPositiveXValue()
        {
            // arrange
            var initialField = new Field
            {
                X = 2
            };

            var handler = new MoveWestCommandHandler();

            // act
            var newField = handler.Move(initialField);

            // assert
            Assert.AreEqual(1, newField.X);
        }

        [Test]
        public void ShouldReturn0WhenMovingWestFromFieldWith0XValue()
        {
            // arrange
            var initialField = new Field
            {
                X = 0
            };

            var handler = new MoveWestCommandHandler();

            // act
            var newField = handler.Move(initialField);

            // assert
            Assert.AreEqual(0, newField.X);
        }

    }
}
