using System.Collections.Generic;
using System;
using Robots.Domain;

namespace Robots.Application.UseCases
{
    public class MoveRequest
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public IEnumerable<CommandMove> Commands { get; set; }
    }
}