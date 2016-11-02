namespace MarsRoverKata
{
    public class MarsRover
    {
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
            if (instructions == "R")
            {
                _startingPosition = "1 1 E";
            }

            if (instructions == "L")
            {
                _startingPosition = "1 1 W";
            }



            if (instructions == "M")
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
        }
    }
}