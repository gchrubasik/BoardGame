namespace BoardGame.Directions
{
    public class ChangeDirectionCommand
    {
        public string Side { get; set; }

        public Direction InitialDirection { get; set; }
    }
}
