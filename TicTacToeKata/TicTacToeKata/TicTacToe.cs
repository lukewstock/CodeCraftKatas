using System.Data;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace TicTacToeKata
{
    public enum Row
    {
        Top,
        Middle
    }

    public enum Column
    {
        Left = 0,
        Middle = 1,
        Right = 2
    }

    public class TicTacToe
    {
        private bool[] _playedTop = new[] {false, false, false};
        private bool[] _playedMiddleRow = new[] {false, false, false};

        protected bool Equals(TicTacToe other)
        {
            return _playedTop
                .Select((t, column) => t.Equals(other._playedTop[column]))
                .All(comparisonResult => comparisonResult.Equals(true))
                &&
                _playedMiddleRow
                .Select((t, column) => t.Equals(other._playedMiddleRow[column]))
                .All((compariosonResult => compariosonResult.Equals(true)));
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
            if (row == Row.Top)
            {
                _playedTop[(int) column] = true;
            }

            _playedMiddleRow[(int) column] = true;
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