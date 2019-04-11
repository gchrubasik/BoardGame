namespace BoardGame.BoardMoves
{
    public interface IMoveForwardCommandHandler
    {
        bool CanHandle(MoveForwardCommand command);

        Field Move(Field initialField);
    }
}
