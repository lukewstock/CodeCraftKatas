using System.Collections.Generic;

namespace MarsRoverKata
{
    public class MarsRover
    {
        private const string ROTATE_RIGHT = "R";
        private const string ROTATE_LEFT = "L";
        private const string MOVE_FORWARD = "M";
        private const string SOUTH = "S";
        private const string EAST = "E";
        private const string NORTH = "N";
        private const string WEST = "W";
        private string _currentPosition;

        private readonly Dictionary<string, string> _rotateRightFrom = new Dictionary<string, string>
        {
            {SOUTH, WEST},
            {EAST, SOUTH},
            {NORTH, EAST},
            {WEST, NORTH},
        };

        private readonly Dictionary<string, string> _rotateLeftFrom = new Dictionary<string, string>
        {
            {EAST, NORTH},
            {SOUTH, EAST},
            {WEST, SOUTH},
            {NORTH, WEST}
        };

        private int _currentX;
        private int _currentY;

        public MarsRover(string startingPosition)
        {
            _currentPosition = startingPosition;
            _currentX = int.Parse(_currentPosition[0].ToString());
            _currentY = int.Parse(_currentPosition[2].ToString());
        }

        public string GetCurrentPosition()
        {
            return _currentPosition;
        }

        public void Move(string instructions)
        {
            if (instructions == ROTATE_RIGHT)
            {
                RotateRight();
            }

            if (instructions == ROTATE_LEFT)
            {
                RotateLeft();
            }

            if (instructions == MOVE_FORWARD)
            {
                MoveForwardOneSpace();
            }
        }

        private void MoveForwardOneSpace()
        {
            if (IsFacingNorth())
            {
                _currentY++;
                _currentPosition = string.Format("{0} {1} {2}", _currentX, _currentY, NORTH);
            }
            else
            {
                _currentPosition = "2 1 E";
            }
        }

        private bool IsFacingNorth()
        {
            return _currentPosition.EndsWith(NORTH);
        }

        private void RotateLeft()
        {
            var currentOrientation = _currentPosition[4].ToString();

            var newOrientation = _rotateLeftFrom[currentOrientation];
            var newPosition = string.Format("1 1 {0}", newOrientation);
            _currentPosition = newPosition;
        }

        private void RotateRight()
        {
            var currentOrientation = _currentPosition[4].ToString();

            var newOrientation = _rotateRightFrom[currentOrientation];

            var newPosition = string.Format("1 1 {0}", newOrientation);
            _currentPosition = newPosition;
        }
    }
}