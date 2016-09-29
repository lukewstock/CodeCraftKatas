namespace TicTacToeKata
{
    public class TicTacToe
    {
        private bool _played;

        protected bool Equals(TicTacToe other)
        {
            return _played.Equals(other._played);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((TicTacToe) obj);
        }

        public override int GetHashCode()
        {
            return _played.GetHashCode();
        }

        public static bool operator ==(TicTacToe left, TicTacToe right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TicTacToe left, TicTacToe right)
        {
            return !Equals(left, right);
        }

        public void PlayTopLeft()
        {
            this._played = true;
        }

        public void PlayTopRight()
        {
        }

        public void PlayTopMiddle()
        {
            throw new System.NotImplementedException();
        }
    }
}