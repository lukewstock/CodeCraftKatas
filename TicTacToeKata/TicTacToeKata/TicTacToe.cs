using System.Data;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace TicTacToeKata
{
    public enum Row
    {
        Top,
        Middle,
        Bottom
    }

    public enum Column
    {
        Left,
        Middle,
        Right
    }

    public class TicTacToe
    {
        private readonly bool[,] _playedBoard = new bool[3, 3]
        {
            {false, false, false},
            {false, false, false},
            {false, false, false}
        };

        protected bool Equals(TicTacToe other)
        {
            for (var row = 0; row < 3; row++)
            {
                for (var column = 0; column < 3; column++)
                {
                    if (_playedBoard[row, column] != other._playedBoard[row, column])
                    {
                        return false;
                    }
                }
            }

            return true;
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
            return (_playedBoard != null ? _playedBoard.GetHashCode() : 0);
        }

        public void Play(Row row, Column column)
        {
            _playedBoard[(int)row, (int)column] = true;
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