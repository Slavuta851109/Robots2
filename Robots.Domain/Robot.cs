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
            for (int i = 0; i < command.Steps; i++)
            {
                _currentVertex = VisitedVertexFactory.Create(_currentVertex, command.Direction);
                _visitedVertices.Add(_currentVertex);
            }
        }

        public Vertex GetCurrentVertex() => _currentVertex;
    }
}