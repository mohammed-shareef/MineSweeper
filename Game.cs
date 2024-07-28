using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    /// <summary>
    /// Manage's an instance of the game currently in play
    /// </summary>
    public class Game
    {
        private readonly int _boardSize;
        private readonly GameBoard _board;
        private Point _playerPosition;
        private int _lives;
        private int _moves;

        public Game(int boardSize, int mineCount, int lives)
        {
            _lives = lives;
            _boardSize = boardSize;
            _playerPosition = Point.Empty;
            _moves = 0;
            _board = new GameBoard(boardSize, mineCount);
        }

        public GameState Play(Direction direction)
        {
            if (_lives <= 0)
                return new GameState(_playerPosition, _lives, _moves, GameStatus.SystemWon);

            _playerPosition = _board.Move(_playerPosition, direction);
            _moves++;

            if (_board.IsMine(_playerPosition))
            {
                _lives--;

                if (_lives <= 0)
                    return new GameState(_playerPosition, _lives, _moves, GameStatus.SystemWon);
            }

            if (_playerPosition.X == _boardSize - 1)
                return new GameState(_playerPosition, _lives, _moves, GameStatus.UserWon);

            return new GameState(_playerPosition, _lives, _moves, GameStatus.InProgress);
        }
    }
}
