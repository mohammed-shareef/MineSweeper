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
        /// Move's a player on the board
        /// </summary>
        /// <param name="current">The current position of the player</param>
        /// <param name="direction">The direction the player intends to move</param>
        /// <returns>The new posiiton of the player after the move</returns>
        public Point Move(Point current, Direction direction)
        {
            int newX = current.X;
            int newY = current.Y;

            switch (direction)
            {
                case Direction.Up:
                    newY = Math.Max(0, current.Y - 1);
                    break;
                case Direction.Down:
                    newY = Math.Min(_mines.GetLength(1) - 1, current.Y + 1);
                    break;
                case Direction.Left:
                    newX = Math.Max(0, current.X - 1);
                    break;
                case Direction.Right:
                    newX = Math.Min(_mines.GetLength(0) - 1, current.X + 1);
                    break;
            }

            return new Point(newX, newY);
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
