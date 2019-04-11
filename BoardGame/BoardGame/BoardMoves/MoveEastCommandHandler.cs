namespace BoardGame.BoardMoves
{
    public class MoveEastCommandHandler : IMoveForwardCommandHandler
    {
        private readonly int _size;

        public MoveEastCommandHandler(int size)
        {
            _size = size;
        }

        public bool CanHandle(MoveForwardCommand command)
        {
            return command.Direction == Directions.Directions.East;
        }

        public Field Move(Field initialField)
        {
            var maxYValue = _size - 1;
            if (initialField.X < maxYValue)
            {
                initialField.X++;
            }
            return initialField;
        }
    }
}
