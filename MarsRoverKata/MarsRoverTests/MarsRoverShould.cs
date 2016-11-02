using FluentAssertions;
using MarsRoverKata;
using NUnit.Framework;

namespace MarsRoverTests
{
    [TestFixture]
    public class MarsRoverShould
    {
        [Test]
        public void ReturnStartingPositionWhenNoInstructionsHaveBeenProcessed()
        {
            const string startingPosition = "1 2 N";
            var marsRover = new MarsRover(startingPosition);

            var currentPosition = marsRover.GetCurrentPosition();

            currentPosition.Should().Be(startingPosition);
        }

        [TestCase("1 1 N", "R", "1 1 E")]
        [TestCase("1 1 N", "L", "1 1 W")]
        [TestCase("1 1 N", "M", "1 2 N")]
        public void ReturnNewPostionWhenMoving(string startingPosition, string instructions, string expectedPosition)
        {
            var marsRover = new MarsRover(startingPosition);

            marsRover.Move(instructions);

            marsRover.GetCurrentPosition().Should().Be(expectedPosition);
        }
    }
}  