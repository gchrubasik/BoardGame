using BoardGame.Directions;

namespace BoardGame.BoardMoves
{
    public class MoveForwardCommand
    {
        public Direction Direction { get; set; }

        public Field InitialField { get; set; }
    }
}
