using System;
using Xunit;

using Robots.Domain;
using Robots.Domain.Exceptions;

namespace Robots.UnitTests.Domain
{
    public class VertexTests
    {
        [Fact]
        public void Vertex_Constructor()
        {
            const int X = 10;
            const int Y = 20;

            var vertex = new Vertex(10, 20);

            Assert.Equal(X, vertex.X);
            Assert.Equal(Y, vertex.Y);
        }

        [Theory]
        [InlineData(-100_001)]
        [InlineData(-100_002)]
        [InlineData(100_001)]
        [InlineData(100_002)]
        public void Vertex_Constructor_WrongValues_ThrowsException(int point)
        {
            Assert.Throws<BadRequestException>(() => new Vertex(point, point));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(1)]
        [InlineData(100_000)]
        [InlineData(-100_000)]
        public void Vertex_Constructor_CorrectValues(int point)
        {
            new Vertex(point, point);
        }
    }
}