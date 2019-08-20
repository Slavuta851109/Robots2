using System;
using Robots.Domain.Exceptions;

namespace Robots.Domain
{
    public struct Vertex
    {
        public int X { get; }
        public int Y { get; }

        public Vertex(int x, int y)
        {
            X = x;
            Y = y;

            ValidateVertex(x);
            ValidateVertex(y);
        }

        private void ValidateVertex(int point)
        {
            int UPPER = 100_000;
            int LOWER = -100_000;
            if (point < LOWER || point > UPPER)
            {
                throw new BadRequestException($"{nameof(point)} must be {LOWER} <= x <= {UPPER}. Value: {point}.");
            }
        }

        // TODO: GetHashCode
    }
}
