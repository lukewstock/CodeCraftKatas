using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
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
        public void NotBeEqual_GivenOneNewGameAndOneGameWithTopLeftPlayed()
        {
            var newGame = new TicTacToe();
            var playedGame = new TicTacToe();
            playedGame.PlayTopLeft();

            newGame.Should().NotBe(playedGame);
        }

        [Test]
        public void NotBeEqual_GivenOneNewGameAndOneGameWithTopRightPlayed()
        {
            var newGame = new TicTacToe();
            var topRightGame = new TicTacToe();
            topRightGame.PlayTopRight();

            newGame.Should().NotBe(topRightGame);
        }

        [Test]
        public void NotBeEqual_GivenOneTopLeftGameAndOneTopRightGame()
        {
            var topLeftGame = new TicTacToe();
            topLeftGame.PlayTopLeft();
            var topRightGame = new TicTacToe();
            topRightGame.PlayTopRight();

            topLeftGame.Should().NotBe(topRightGame);


        }
    }
}
