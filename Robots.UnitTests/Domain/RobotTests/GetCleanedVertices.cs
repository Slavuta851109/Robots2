using System;
using Xunit;
using Robots.Domain;

namespace Robots.UnitTests.Domain.RobotTests
{
    public class GetCleanedVertices
    {
        [Fact]
        public void GetCleanedVertices_NoMovement_OneCleaned()
        {
            const int ExpectedCleaned = 1;

            var sut = new Robot(new Vertex(2, 20));
            int cleanedNumber = sut.GetCleanedVertices();

            Assert.Equal(ExpectedCleaned, cleanedNumber);
        }

        [Fact]
        public void GetCleanedVertices_MoveOneDirection()
        {
            const int Steps = 5;
            const int ExpectedCleaned = Steps + 1;

            var sut = new Robot(new Vertex(2, 20));

            sut.Move(new CommandMove(DirectionEnum.N, Steps));
            int cleanedNumber = sut.GetCleanedVertices();

            Assert.Equal(ExpectedCleaned, cleanedNumber);
        }

        [Fact]
        public void GetCleanedVertices_MoveForwardAndBack()
        {
            const int Steps = 5;
            const int ExpectedCleaned = (Steps * 2) + 1;

            var sut = new Robot(new Vertex(-2, -20));

            sut.Move(new CommandMove(DirectionEnum.N, Steps));
            sut.Move(new CommandMove(DirectionEnum.S, Steps));
            sut.Move(new CommandMove(DirectionEnum.E, Steps));
            sut.Move(new CommandMove(DirectionEnum.W, Steps));
            int cleanedNumber = sut.GetCleanedVertices();

            Assert.Equal(ExpectedCleaned, cleanedNumber);
        }

        [Fact]
        public void GetCleanedVertices_MoveCircle()
        {
            const int Steps = 5;
            const int ExpectedCleaned = (Steps * 4) + 1 - 1; // circle + initial - last (as it is initial)

            var sut = new Robot(new Vertex(0, 0));

            sut.Move(new CommandMove(DirectionEnum.N, Steps));
            sut.Move(new CommandMove(DirectionEnum.E, Steps));
            sut.Move(new CommandMove(DirectionEnum.S, Steps));
            sut.Move(new CommandMove(DirectionEnum.W, Steps));

            sut.Move(new CommandMove(DirectionEnum.N, Steps));
            sut.Move(new CommandMove(DirectionEnum.E, Steps));
            sut.Move(new CommandMove(DirectionEnum.S, Steps));
            sut.Move(new CommandMove(DirectionEnum.W, Steps));

            int cleanedNumber = sut.GetCleanedVertices();

            Assert.Equal(ExpectedCleaned, cleanedNumber);
        }
    }
}