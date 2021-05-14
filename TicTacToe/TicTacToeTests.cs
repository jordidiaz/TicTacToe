using System;
using TicTacToe.TicTacToe;
using Xunit;

namespace TicTacToe
{
    public class TicTacToeTests
    {
        private readonly Game _game;

        public TicTacToeTests()
        {
            _game = new Game();
        }

        [Fact]
        public void When_starting_the_game_you_have_an_empty_board()
        {
            Assert.True(_game.Board.IsEmpty);
        }

        [Fact]
        public void If_the_first_round_is_not_an_X_is_not_a_valid_movement()
        {
            Assert.Throws<Exception>(() => _game.PlayRound("O", 0, 0));
        }

        [Fact]
        public void The_first_round_should_be_a_X_and_placed_in_the_specified_position()
        {
            _game.PlayRound("X", 0, 0);
            
            Assert.Equal("X", _game.Board.GetPosition(0, 0));
        }

        [Fact]
        public void If_the_second_round_is_not_an_O_is_not_a_valid_movement()
        {
            _game.PlayRound("X", 0, 0);
            Assert.Throws<Exception>(() => _game.PlayRound("X", 0, 0));
        }
    }
}