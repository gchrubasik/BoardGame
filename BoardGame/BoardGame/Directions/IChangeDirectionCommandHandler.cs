namespace BoardGame.Directions
{
    public interface IChangeDirectionCommandHandler
    {
        bool CanHandle(string side);

        Direction Change(Direction initialDirection);
    }
}
