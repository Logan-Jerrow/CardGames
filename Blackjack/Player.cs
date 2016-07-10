using System;

namespace BlackjackModel
{
    internal class Player
    {
        //private Hand hand;
        public Hand hand { get; set; }

        public Player()
        {
            hand = new Hand();
        }

        public void showPlayerChoice()
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.Write("[h]it or [s]tay\n=> ");
        }

        public bool PlayerChoice()
        {
            showPlayerChoice();
            bool input;

            while (true)
            {
                var c = Console.ReadLine();
                c.ToLower();
                if (c.Contains("h"))
                    return input = true;
                if (c.Contains("s"))
                    return input = false;
                else
                {
                    Console.WriteLine("{0} is invalid input", c);
                    showPlayerChoice();
                }
            }
            return input;
        }
    }
}