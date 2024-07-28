using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    internal static class StringExtensions
    {
        public static Direction ToDirection(this string input)
        {
            Direction direction = Direction.Up;

            if (string.IsNullOrEmpty(input) || input.Length != 1)
                throw new InvalidDataException("Invalid input. Please enter u, d, l, or r.");

            switch (input.ToUpper()[0])
            {
                case 'U':
                    return direction;
                case 'D':
                    direction = Direction.Down;
                    break;
                case 'L':
                    direction = Direction.Left;
                    break;
                case 'R':
                    direction = Direction.Right;
                    break;
            }

            return direction;
        }
    }
}
