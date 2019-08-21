using System;
using Xunit;

using Robots.Domain;
using Robots.Domain.Exceptions;

namespace Robots.UnitTests.Domain
{
    public class CommandMoveTests
    {
        [Fact]
        public void CommandMove_Constructor()
        {
            var direction = DirectionEnum.E;
            const int Steps = 20;

            var sut = new CommandMove(direction, Steps);

            Assert.Equal(direction, sut.Direction);
            Assert.Equal(Steps, sut.Steps);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(100_000)]
        [InlineData(100_001)]
        public void CommandMove_Constructor_WrongValue_ThrowsException(int steps)
        {
            Assert.Throws<BadRequestException>(() => new CommandMove(DirectionEnum.E, steps));
        }
    }
}