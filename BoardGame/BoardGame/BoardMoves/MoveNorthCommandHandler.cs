namespace BoardGame.BoardMoves
{
    public class MoveNorthCommandHandler : IMoveForwardCommandHandler
    {
        private readonly int _size;

        public MoveNorthCommandHandler(int size)
        {
            _size = size;
        }

        public bool CanHandle(MoveForwardCommand command)
        {
            return command.Direction == Directions.Directions.North;
        }

        public Field Move(Field initialField)
        {
            var maxYValue = _size - 1;
            if (initialField.Y < maxYValue)
            {
                initialField.Y++;
            }
            return initialField;
        }
    }
}
