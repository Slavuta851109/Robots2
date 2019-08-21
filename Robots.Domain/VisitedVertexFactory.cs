using System;

namespace Robots.Domain
{
    internal static class VisitedVertexFactory
    {
        internal static Vertex Create(
            Vertex currentVertex,
            DirectionEnum direction)
        {
            Vertex visitedVertex;
            switch (direction)
            {
                // Y updater
                case DirectionEnum.N:
                    visitedVertex = new Vertex(currentVertex.X, currentVertex.Y + 1);
                    break;
                case DirectionEnum.S:
                    visitedVertex = new Vertex(currentVertex.X, currentVertex.Y - 1);
                    break;
                // X updater
                case DirectionEnum.E:
                    visitedVertex = new Vertex(currentVertex.X + 1, currentVertex.Y);
                    break;
                case DirectionEnum.W:
                    visitedVertex = new Vertex(currentVertex.X - 1, currentVertex.Y);
                    break;
                default:
                    throw new NotSupportedException($"{direction} is not supported.");
            }

            return visitedVertex;
        }
    }
}
