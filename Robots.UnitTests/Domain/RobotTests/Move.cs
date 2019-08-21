using System;
using Xunit;
using Robots.Domain;

namespace Robots.UnitTests.Domain.RobotTests
{
    public class Move
    {
        [Theory]
        [InlineData(DirectionEnum.N, 1)]
        [InlineData(DirectionEnum.S, -1)]
        public void Move_Vertical(DirectionEnum direction, int sign)
        {
            const int Steps = 5;
            const int X = 2;
            const int Y = 20;
            var sut = new Robot(new Vertex(X, Y));

            sut.Move(new CommandMove(direction, Steps));
            var vertex = sut.GetCurrentVertex();

            Assert.Equal(X, vertex.X);
            Assert.Equal(Y + (sign * Steps), vertex.Y);
        }

        [Theory]
        [InlineData(DirectionEnum.E, 1)]
        [InlineData(DirectionEnum.W, -1)]
        public void Move_Horizontal(DirectionEnum direction, int sign)
        {
            const int Steps = 5;
            const int X = 2;
            const int Y = 20;
            var sut = new Robot(new Vertex(X, Y));

            sut.Move(new CommandMove(direction, Steps));
            var vertex = sut.GetCurrentVertex();

            Assert.Equal(Y, vertex.Y);
            Assert.Equal(X + (sign * Steps), vertex.X);
        }
    }
}