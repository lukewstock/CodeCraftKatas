namespace MarsRoverKata
{
    public class MarsRover
    {
        private const string ROTATE_RIGHT = "R";
        private const string ROTATE_LEFT = "L";
        private const string MOVE_FORWARD = "M";
        private string _currentPosition;

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
            if (_currentPosition == "1 1 E")
            {
                _currentPosition = "2 1 E";
            }
            else
            {
                _currentPosition = "1 2 N";
            }
        }

        private void RotateLeft()
        {
            _currentPosition = "1 1 W";
        }

        private void RotateRight()
        {
            var newPosition = string.Empty;

            var south = "S";
            if (_currentPosition == string.Format("1 1 {0}", south))
            {
                newPosition = "1 1 W";
            }

            var east = "E";
            if (_currentPosition == string.Format("1 1 {0}", east))
            {
                newPosition = "1 1 S";
            }

            var north = "N";
            if (_currentPosition == string.Format("1 1 {0}", north))
            {
                newPosition = "1 1 E";
            }

            var west = "W";
            if (_currentPosition == string.Format("1 1 {0}", west))
            {
                newPosition = "1 1 N";
            }

            _currentPosition = newPosition;
        }
    }
}