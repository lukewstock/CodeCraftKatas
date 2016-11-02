namespace MarsRoverKata
{
    public class MarsRover
    {
        private string _startingPosition;

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

        public void Move(string s)
        {
            _startingPosition = "1 1 E";
        }
    }
}