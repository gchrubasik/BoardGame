namespace BoardGame.Directions
{
    public class TurnRightCommandHandler : IChangeDirectionCommandHandler
    {
        public bool CanHandle(string side)
        {
            return side == "R";
        }

        public Direction Change(Direction initialDirection)
        {
            return initialDirection.OnRight;
        }
    }
}
