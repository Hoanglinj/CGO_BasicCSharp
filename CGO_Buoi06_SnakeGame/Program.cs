using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi06_SnakeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(10, 3);
            Console.WriteLine("Hello");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Snake Game 1");
            Console.WriteLine("Snake Game 2");
            Console.BackgroundColor= ConsoleColor.Yellow;
            Console.WriteLine("Snake Game 3");

            Console.ReadKey();
        }
    }
}
