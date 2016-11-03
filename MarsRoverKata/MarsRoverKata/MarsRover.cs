namespace MarsRoverKata
{
    public class MarsRover
    {
        private const string ROTATE_RIGHT = "R";
        private const string ROTATE_LEFT = "L";
        private const string MOVE_FORWARD = "M";
        private string _startingPosition;

        public MarsRover(string startingPosition)
        {
            _startingPosition = startingPosition;
        }

        public string GetCurrentPosition()
        {
            return _startingPosition;
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
            if (_startingPosition == "1 1 E")
            {
                _startingPosition = "2 1 E";
            }
            else
            {
                _startingPosition = "1 2 N";
            }
        }

        private void RotateLeft()
        {
            _startingPosition = "1 1 W";
        }

        private void RotateRight()
        {
            var newPosition = string.Empty;

            if (_startingPosition == "1 1 S")
            {
                newPosition = "1 1 W";
            }

            if (_startingPosition == "1 1 E")
            {
                newPosition = "1 1 S";
            }

            if (_startingPosition == "1 1 N")
            {
                newPosition = "1 1 E";
            }

            if (_startingPosition == "1 1 W")
            {
                newPosition = "1 1 N";
            }

            _startingPosition = newPosition;
        }
    }
}