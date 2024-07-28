using System.Drawing;

namespace MineSweeper
{
    public interface IGameBoard
    {
        Point Move(Point current, Direction direction);
        bool IsMine(Point playerPosition);
    }
}
