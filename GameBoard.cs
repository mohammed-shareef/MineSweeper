using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class GameBoard
    {
        private readonly bool[,] _mines;

        public GameBoard(int size, int mineCount)
        {
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

                if (!_mines[x, y])
                {
                    _mines[x, y] = true;
                    placedMines++;
                }
            }
        }
    }
}
