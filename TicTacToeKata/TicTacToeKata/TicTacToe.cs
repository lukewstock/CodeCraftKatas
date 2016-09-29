namespace TicTacToeKata
{
    public enum Row
    {
        Top
    }

    public enum Column
    {
        Left,
        Right,
        Middle
    }

    public class TicTacToe
    {
        private bool _playedTopLeft;
        private bool _playedTopRight;

        protected bool Equals(TicTacToe other)
        {
            return _playedTopRight.Equals(other._playedTopRight) && _playedTopLeft.Equals(other._playedTopLeft);
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
            unchecked
            {
                return (_playedTopRight.GetHashCode()*397) ^ _playedTopLeft.GetHashCode();
            }
        }

        public static bool operator ==(TicTacToe left, TicTacToe right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TicTacToe left, TicTacToe right)
        {
            return !Equals(left, right);
        }

        public void Play(Row row, Column column)
        {
            if (column == Column.Left)
            {
                this._playedTopLeft = true;
            }

            this._playedTopRight = true;
        }
    }
}