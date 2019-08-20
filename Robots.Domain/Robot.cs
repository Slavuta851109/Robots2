using System;
using System.Collections.Generic;

namespace Robots.Domain
{
    public class Robot
    {
        private HashSet<Vertex> _visitedVertices = new HashSet<Vertex>();
        private Vertex _currentVertex;

        public Robot(
            [NotNull] Vertex initialVertex)
        {
            _visitedVertices.Add(initialVertex);
            _currentVertex = initialVertex;
        }

        public void Move(
            [NotNull] CommandMove command)
        {
            // TODO: do logic here

        }
    }
}