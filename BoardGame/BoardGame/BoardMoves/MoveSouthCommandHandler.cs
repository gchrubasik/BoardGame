namespace BoardGame.BoardMoves
{
    public class MoveSouthCommandHandler : IMoveForwardCommandHandler
    {
        public bool CanHandle(MoveForwardCommand command)
        {
            return command.Direction == Directions.Directions.South;
        }

        public Field Move(Field initialField)
        {
            if (initialField.Y > 0)
            {
                initialField.Y--;
            }

            return initialField;
        }
    }
}
