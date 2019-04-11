using BoardGame.BoardMoves;
using BoardGame.Directions;

namespace BoardGame
{
    public class Game
    {
        private MoveForwardCommandDispatcher _moveForwardCommandDispatcher = new MoveForwardCommandDispatcher(5);

        private ChangeDirectionCommandDispatcher _changeDirectionCommandDispatcher = new ChangeDirectionCommandDispatcher();

        private readonly Piece Piece = new Piece
        {
            Direction = Directions.Directions.North,
            Field = new Field
            {
                X = 0,
                Y = 0
            }
        };
        
        public GameResult Play(string commands)
        {
            foreach (var command in commands)
            {
                this.ExecuteCommand(command);
            }

            return new GameResult
            {
                Direction = Piece.Direction.Name,
                Y = Piece.Field.Y,
                X = Piece.Field.X
            };
        }

        private void ExecuteCommand(char command)
        {
            if (command == 'L' || command == 'R')
            {
                var changeDirectionCommand = new ChangeDirectionCommand
                {
                    Side = command.ToString(),
                    InitialDirection = this.Piece.Direction
                };

                this.Piece.Direction = _changeDirectionCommandDispatcher.Handle(changeDirectionCommand);
            }

            if (command == 'M')
            {
                var moveForwardCommand = new MoveForwardCommand
                {
                    Direction = Piece.Direction,
                    InitialField = Piece.Field
                };
                
                this.Piece.Field = _moveForwardCommandDispatcher.Handle(moveForwardCommand);
            }
        }
    }
}
