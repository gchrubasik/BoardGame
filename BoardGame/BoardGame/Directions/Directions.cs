namespace BoardGame.Directions
{
    public static class Directions
    {
        public static readonly Direction North = new Direction {Name = "N"};

        public static readonly Direction West = new Direction {Name = "W"};

        public static readonly Direction East = new Direction {Name = "E"};

        public static readonly Direction South = new Direction {Name = "S"};

        static Directions()
        {
            North.OnLeft = West;
            North.OnRight = East;
            West.OnLeft = South;
            West.OnRight = North;
            South.OnLeft = East;
            South.OnRight = West;
            East.OnLeft = North;
            East.OnRight = South;
        }
    }
}
