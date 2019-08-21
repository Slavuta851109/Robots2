using System;
using Xunit;
using Robots.Domain;

namespace Robots.UnitTests.Domain.RobotTests
{
    public class Constructor
    {
        [Fact]
        public void Cstr_Store_InitialVertex()
        {
            var initialVertex = new Vertex(10, 20);
            var sut = new Robot(initialVertex);
            Assert.Equal(initialVertex, sut.GetCurrentVertex());
        }
    }
}