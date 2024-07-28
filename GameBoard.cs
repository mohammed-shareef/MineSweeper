using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    /// <summary>
    /// The GameBoard is based on the chess board terminology eg: C2 where
    /// x-axis is represented by alphabets & y-axis is represented by numbers
    /// </summary>
    public class GameBoard
    {
        private readonly bool[,] _mines;

        public GameBoard(int size, int mineCount)
        {
            //Create a size x size grid for the game board to place mine(s) on
            _mines = new bool[size, size];
            PlaceMines(mineCount);
        }

        private void PlaceMines(int mineCount)
        {
            var random = new Random();
            var placedMines = 0;

            while (placedMines < mineCount)
            {
                int x = random.Next(_mines.GetLength(0));
                int y = random.Next(_mines.GetLength(1));

                //Place a mine only if one has not been placed yet
                if (!_mines[x, y])
                {
                    _mines[x, y] = true;
                    placedMines++;
                }
            }
        }

        /// <summary>
        /// Check if a mine exists at the current location 
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool IsMine(Point position)
        {
            return _mines[position.X, position.Y];
        }
    }
}
