namespace BoardGame.Directions
{
    public class TurnLeftCommandHandler : IChangeDirectionCommandHandler
    {
        public bool CanHandle(string side)
        {
            return side == "L";
        }

        public Direction Change(Direction initialDirection)
        {
            return initialDirection.OnLeft;
        }
    }
}
