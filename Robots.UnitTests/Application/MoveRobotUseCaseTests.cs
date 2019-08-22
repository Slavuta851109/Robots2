using System.Linq;

using AutoFixture;
using Xunit;
using Robots.Domain;
using Robots.Application.UseCases;

namespace Robots.UnitTests.Application
{
    public class MoveRobotUseCaseTests
    {
        private Fixture _fixture;

        public MoveRobotUseCaseTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void Execute()
        {
            _fixture.Register<DirectionEnum>(() => DirectionEnum.E);
            var request = _fixture.Create<MoveRequest>();
            int expectedSteps = request.Commands.Sum(c => c.Steps) + 1;

            var sut = new MoveRobotUseCase();
            var response = sut.Execute(request);

            Assert.NotNull(response);
            Assert.NotEqual(0, response.CleanedVertices);
            Assert.Equal(expectedSteps, response.CleanedVertices);
        }
    }
}