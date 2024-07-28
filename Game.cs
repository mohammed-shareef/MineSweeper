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
        private readonly GameBoard _board;

        public Game(int boardSize, int mineCount)
        {
            _board = new GameBoard(boardSize, mineCount);
        }
    }
}
