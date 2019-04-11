using BoardGame.BoardMoves;
using NUnit.Framework;

namespace BoardGame.Tests.BoardMoves
{
    public class MoveNorthCommandHandlerTests
    {
        [Test]
        public void ShouldBeAbleToHandleCommandWhenMoveDirectionIsNorth()
        {
            // arrange
            var command = new MoveForwardCommand
            {
                Direction = Directions.Directions.North
            };

            var handler = new MoveNorthCommandHandler(5);

            // act
            var canHandle = handler.CanHandle(command);

            // assert
            Assert.IsTrue(canHandle);
        }

        [Test]
        public void ShouldNotBeAbleToHandleCommandWhenMoveDirectionIsNotNorth()
        {
            // arrange
            var command = new MoveForwardCommand
            {
                Direction = Directions.Directions.South
            };

            var handler = new MoveNorthCommandHandler(5);

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

            var handler = new MoveNorthCommandHandler(5);

            // act
            var newField = handler.Move(initialField);

            // assert
            Assert.AreEqual(3, newField.Y);
        }

        [Test]
        public void ShouldReturn0WhenMovingSouthFromFieldWith0YValue()
        {
            // arrange
            var initialField = new Field
            {
                Y = 4
            };

            var handler = new MoveNorthCommandHandler(5);

            // act
            var newField = handler.Move(initialField);

            // assert
            Assert.AreEqual(4, newField.Y);
        }

    }
}
