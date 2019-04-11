using System.Collections.Generic;
using System.Linq;

namespace BoardGame.Directions
{
    public class ChangeDirectionCommandDispatcher
    {
        private IEnumerable<IChangeDirectionCommandHandler> _handlers = new IChangeDirectionCommandHandler[]
        {
            new TurnLeftCommandHandler(),
            new TurnRightCommandHandler()
        };

        public Direction Handle(ChangeDirectionCommand command)
        {
            var handler = _handlers.Single(x => x.CanHandle(command.Side));

            return handler.Change(command.InitialDirection);
        }
    }
}
