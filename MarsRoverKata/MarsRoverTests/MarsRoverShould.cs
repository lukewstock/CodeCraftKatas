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

        [TestCase("R", "1 1 E")]
        [TestCase("L", "1 1 W")]
        public void ReturnNewPostionWhenMoving(string instructions, string expectedPosition)
        {
            const string startingPosition = "1 1 N";
            var marsRover = new MarsRover(startingPosition);

            marsRover.Move(instructions);

            marsRover.GetCurrentPosition().Should().Be(expectedPosition);
        }
    }
} 
