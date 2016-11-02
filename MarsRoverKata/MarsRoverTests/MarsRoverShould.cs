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

        [Test]
        public void ReturnNewPostionWhenMoving()
        {
            const string startingPosition = "1 1 N";
            const string expectedPosition = "1 1 E";
            var marsRover = new MarsRover(startingPosition);

            marsRover.Move("R");

            marsRover.GetCurrentPosition().Should().Be(expectedPosition);
        }
    }
} 
