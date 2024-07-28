using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    /// <summary>
    /// Holds the state of a Game
    /// </summary>
    /// <param name="PlayerPosition">The current position of the player</param>
    /// <param name="Lives">The number of lives a player has</param>
    /// <param name="Moves">The total moves taken</param>
    /// <param name="Status">Whether the game has been won or lost</param>
    public record GameState(Point PlayerPosition, int Lives, int Moves, GameStatus Status);
}
