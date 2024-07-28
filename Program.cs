namespace MineSweeper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new GameManager(8, 10, 3);
            game.Run();
        }
    }
}
