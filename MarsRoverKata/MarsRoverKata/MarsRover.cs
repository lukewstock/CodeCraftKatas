namespace MarsRoverKata
{
    public class MarsRover
    {
        private readonly string _startingPosition;

        public MarsRover(string startingPosition)
        {
            _startingPosition = startingPosition;
            
        }

        public MarsRover()
        {
            throw new System.NotImplementedException();
        }

        public string GetCurrentPosition()
        {
            return _startingPosition;
        }
    }
}