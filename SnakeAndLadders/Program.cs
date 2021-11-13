using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake and Ladder game");
            SnakeAndLadder snk = new SnakeAndLadder();
            snk.rollDie();
        }
    }
}

