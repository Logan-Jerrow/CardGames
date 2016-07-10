using System;

namespace BlackjackModel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            do
            {
                var game = new Blackjack();

                game.startGame();
                Console.WriteLine("\n\nHIT Escape TO EXIT");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            //Console.WriteLine("\n\nHIT ANY KEY TO EXIT");
            //Console.ReadKey();
        }
    }
}