using BoardGame.BoardMoves;
using NUnit.Framework;

namespace BoardGame.Tests.BoardMoves
{
    public class MoveEastCommandHandlerTests
    {
        [Test]
        public void ShouldBeAbleToHandleCommandWhenMoveDirectionIsEast()
        {
            // arrange
            var command = new MoveForwardCommand
            {
                Direction = Directions.Directions.East
            };

            var handler = new MoveEastCommandHandler(5);

            // act
            var canHandle = handler.CanHandle(command);

            // assert
            Assert.IsTrue(canHandle);
        }

        [Test]
        public void ShouldNotBeAbleToHandleCommandWhenMoveDirectionIsNotEast()
        {
            // arrange
            var command = new MoveForwardCommand
            {
                Direction = Directions.Directions.South
            };

            var handler = new MoveEastCommandHandler(5);

            // act
            var canHandle = handler.CanHandle(command);

            // assert
            Assert.IsFalse(canHandle);
        }

        [Test]
        public void ShouldReturnFieldXDecreasedByOneWhenMovingSouthFromFieldWithPositiveXValue()
        {
            // arrange
            var initialField = new Field
            {
                X = 2
            };

            var handler = new MoveEastCommandHandler(5);

            // act
            var newField = handler.Move(initialField);

            // assert
            Assert.AreEqual(3, newField.X);
        }

        [Test]
        public void ShouldReturn0WhenMovingSouthFromFieldWith0XValue()
        {
            // arrange
            var initialField = new Field
            {
                X = 4
            };

            var handler = new MoveEastCommandHandler(5);

            // act
            var newField = handler.Move(initialField);

            // assert
            Assert.AreEqual(4, newField.X);
        }

    }
}
