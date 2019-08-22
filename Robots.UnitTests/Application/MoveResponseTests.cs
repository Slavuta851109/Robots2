using Xunit;
using Robots.Application.UseCases;

namespace Robots.UnitTests.Application
{
    public class MoveResponseTests
    {
        [Fact]
        public void MoveResponse_Cstr()
        {
            const int Expected_NumberOfSteps = 101;
            var sut = new MoveResponse(Expected_NumberOfSteps);
            Assert.Equal(Expected_NumberOfSteps, sut.CleanedVertices);
        }
    }
}