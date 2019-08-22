using System.Collections.Generic;
using System.Linq;
using Xunit;

using Robots.Application.UseCases;
using Robots.Domain;

namespace Robots.UnitTests.Application
{
    public class MoveRequestTests
    {
        [Fact]
        public void MoveRequest_Cstr()
        {
            const int X = 10;
            const int Y = 20;
            IEnumerable<(DirectionEnum Direction, int Steps)> commands = new[]
            {
                (Direction: DirectionEnum.E, Steps: 100)
            };

            var sut = new MoveRequest(X, Y, commands);
            Assert.Equal(new Vertex(X, Y), sut.StartPosition);
            Assert.Equal(commands.Count(), sut.Commands.Count());
            Assert.Equal(commands.First().Direction, sut.Commands.First().Direction);
            Assert.Equal(commands.First().Steps, sut.Commands.First().Steps);
        }

        [Fact]
        public void MoveRequest_Cstr_NullCommands_Ok()
        {
            const int X = 10;
            const int Y = 20;
            IEnumerable<(DirectionEnum Direction, int Steps)> commands = null;

            var sut = new MoveRequest(X, Y, commands);
            Assert.Equal(new Vertex(X, Y), sut.StartPosition);
            Assert.Empty(sut.Commands);
        }
    }
}