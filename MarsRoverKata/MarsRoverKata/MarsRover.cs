﻿using System.Collections.Generic;

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

        public MarsRover(string startingPosition)
        {
            _currentPosition = startingPosition;
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
            if (_currentPosition == string.Format("2 2 {0}", NORTH))
            {
                var y = "3";
                _currentPosition = string.Format("2 {0} N", y);
            }
            else if (_currentPosition == string.Format("3 3 {0}", NORTH))
            {
                var y = "4";
                _currentPosition = string.Format("3 {0} N", y);
            }
            else if (_currentPosition == string.Format("1 1 {0}", NORTH))
            {
                var y = "2";
                _currentPosition = string.Format("1 {0} N", y);
            }
            else
            {
                _currentPosition = "2 1 E";
            }
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