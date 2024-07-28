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

        public GameManager(int boardSize, int mineCount, int lives)
        {
            _game = new Game(boardSize, mineCount, lives,new GameBoard(boardSize, mineCount));
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

            while (true)
            {
                try
                {
                    string input = Console.ReadLine()?.ToUpper();

                    if (input == "Q")
                        break;

                    Direction direction = input.ToDirection();

                    GameState state = _game.Play(direction);
                    DisplayGameState(state);

                    if (state.Status != GameStatus.InProgress)
                    {
                        Console.WriteLine(state.Status == GameStatus.UserWon ? "You win !!" : "You lost...");
                        Console.WriteLine("Game over !");
                        break;
                    }
                }
                catch (InvalidDataException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void DisplayGameState(GameState state)
        {
            Console.WriteLine($"Point: {(char)('A' + state.PlayerPosition.Y)}{state.PlayerPosition.X + 1}");
            Console.WriteLine($"Lives: {state.Lives}");
            Console.WriteLine($"Moves: {state.Moves}");
        }
    }
}