namespace MarsRoverKata
{
    public class MarsRover
    {
        private readonly string _s;

        public MarsRover(string s)
        {
            _s = s;
            
        }

        public MarsRover()
        {
            throw new System.NotImplementedException();
        }

        public string GetCurrentPosition()
        {
            return _s;
        }
    }
}