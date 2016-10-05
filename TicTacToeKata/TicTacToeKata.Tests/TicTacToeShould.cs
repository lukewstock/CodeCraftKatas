using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using FluentAssertions.Primitives;
using NUnit.Framework;

namespace TicTacToeKata.Tests
{
    public class TicTacToeShould
    {
        [Test]
        public void BeEqual_GivenTwoNewGames()
        {
            var firstNewGame = new TicTacToe();
            var secondNewGame = new TicTacToe();

            firstNewGame.Should().Be(secondNewGame);
        }

        [Test]
        public void NotBeEqual_GivenOneNewGameAndPlayedGame()
        {
            var newGame = new TicTacToe();
            var playedGame = new TicTacToe();

            playedGame.Play(Row.Top, Column.Right);

            newGame.Should().NotBe(playedGame);
        }

        [TestCase(Row.Top, Column.Left, Row.Top, Column.Left, true)]
        [TestCase(Row.Top, Column.Left, Row.Top, Column.Right, false)]
        [TestCase(Row.Top, Column.Right, Row.Top, Column.Middle, false)]
        [TestCase(Row.Middle, Column.Right, Row.Top, Column.Right, false)]
        [TestCase(Row.Middle, Column.Right, Row.Middle, Column.Left, false)]
        [TestCase(Row.Middle, Column.Middle, Row.Middle, Column.Left, false)]
        [TestCase(Row.Bottom, Column.Left, Row.Middle, Column.Left, false)]
        [TestCase(Row.Bottom, Column.Left, Row.Bottom, Column.Middle, false)]
        public void CompareTwoGamesForEquality(Row firstGameRow, Column firstGameColumn, Row secondGameRow, Column secondGameColumn, bool expectedEquality)
        {
            var firstGame = new TicTacToe();
            var secondGame = new TicTacToe();

            firstGame.Play(firstGameRow, firstGameColumn);
            secondGame.Play(secondGameRow, secondGameColumn);

            var areEqual = firstGame.Equals(secondGame);

            areEqual.Should().Be(expectedEquality);
        }
    }
}
