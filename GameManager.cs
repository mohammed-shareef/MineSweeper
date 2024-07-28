using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MineSweeper
{
    /// <summary>
    /// Creates and controls the entire game flow
    /// </summary>
    public class GameManager
    {
        private readonly Game _game;

        public GameManager(int boardSize, int mineCount)
        {
            _game = new Game(boardSize, mineCount);
        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("******************** Mine Sweeper  ********************");
            Console.WriteLine();
            Console.WriteLine("Enter direction to move ");
            Console.WriteLine("[Up - u, Down - d, Left - l, Right - r] or q to quit :");
            Console.WriteLine();
            Console.WriteLine("******************************************************");

        }
    }
}