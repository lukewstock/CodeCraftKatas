using FluentAssertions;
using MarsRoverKata;
using NUnit.Framework;

namespace MarsRoverTests
{
    [TestFixture]
    public class MarsRoverShould
    {
        [Test]
        public void ReturnPosition()
        {
            var marsRover = new MarsRover("1 1 N");
            var expectedPosition = "1 1 N";

            var position = marsRover.GetCurrentPosition();

            position.Should().Be(expectedPosition);
        }

        [Test]
        public void ReturnStartingPositionWhenNoInstructionsHaveBeenProcessed()
        {
            new MarsRover("1 2 N").GetCurrentPosition().Should().Be("1 2 N");
        }
    }
} 
