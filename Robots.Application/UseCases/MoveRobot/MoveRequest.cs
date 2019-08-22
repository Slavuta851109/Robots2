using System.Collections.Generic;
using System.Linq;
using Robots.Domain;

namespace Robots.Application.UseCases
{
    public class MoveRequest
    {
        public MoveRequest(int x, int y, IEnumerable<(DirectionEnum Direction, int Steps)> commands)
        {
            this.StartPosition = new Vertex(x, y);
            this.Commands = (commands ?? new (DirectionEnum Direction, int Steps)[0])
                .Select(c => new CommandMove(c.Direction, c.Steps)).ToList();
        }

        public Vertex StartPosition { get; }
        public IEnumerable<CommandMove> Commands { get; }
    }
}