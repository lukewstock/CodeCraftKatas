using FluentAssertions;
using NUnit.Framework;

namespace MarsRoverTests
{
    [TestFixture]
    public class MarsRoverShould
    {
        [Test]
        public void ReturnPosition()
        {
            var marsRover = new MarsRover();
            var expectedPosition = "1 1 N";

            var position = marsRover.GetPosition();

            position.Should().Be(expectedPosition);
        }
    }

    public class MarsRover
    {
        public string GetPosition()
        {
            return "1 1 N";
        }
    }
}
