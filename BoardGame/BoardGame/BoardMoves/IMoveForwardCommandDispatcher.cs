using System.Collections.Generic;
using System.Linq;

namespace BoardGame.BoardMoves
{
    public class MoveForwardCommandDispatcher
    {
        private IEnumerable<IMoveForwardCommandHandler> handlers;

        public MoveForwardCommandDispatcher(int boardSize)
        {
            handlers = new IMoveForwardCommandHandler[]
            {
                new MoveEastCommandHandler(boardSize),
                new MoveNorthCommandHandler(boardSize),
                new MoveSouthCommandHandler(),
                new MoveWestCommandHandler()
            };
        }

        public Field Handle(MoveForwardCommand command)
        {
            var handler = this.handlers.Single(h => h.CanHandle(command));
            return handler.Move(command.InitialField);
        }
    }
}
