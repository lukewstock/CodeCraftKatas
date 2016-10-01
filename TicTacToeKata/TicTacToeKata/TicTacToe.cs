using System.Linq;

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
        private bool[] _playedTop = new[] {false, false, false};

        protected bool Equals(TicTacToe other)
        {
            return _playedTop
                .Select((t, column) => t.Equals(other._playedTop[column]))
                .All(comparisonResult => comparisonResult.Equals(true));
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
            return (_playedTop != null ? _playedTop.GetHashCode() : 0);
        }

        public void Play(Row row, Column column)
        {
            if (column == Column.Left)
            {
                _playedTop[0] = true;
            }
            if (column == Column.Middle)
            {
                _playedTop[1] = true;
            }
            _playedTop[2] = true;
        }

        public static bool operator ==(TicTacToe left, TicTacToe right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TicTacToe left, TicTacToe right)
        {
            return !Equals(left, right);
        }
    }
}