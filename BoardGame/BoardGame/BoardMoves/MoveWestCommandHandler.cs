namespace BoardGame.BoardMoves
{
    public class MoveWestCommandHandler : IMoveForwardCommandHandler
    {
        public bool CanHandle(MoveForwardCommand command)
        {
            return command.Direction == Directions.Directions.West;
        }

        public Field Move(Field initialField)
        {
            if (initialField.X > 0)
            {
                initialField.X--;
            }

            return initialField;
        }
    }
}
