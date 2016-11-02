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
            var marsRover = new MarsRover("1 1 N");

            marsRover.Move("R");

            marsRover.GetCurrentPosition().Should().Be("1 1 E");
        }
    }
} 
