using System;
using BlackjackLibrary;

bool flag = false;
do
{

    System.Console.WriteLine("Select option:");
    System.Console.WriteLine("[b]: To play a game of Blackjack.");
    System.Console.WriteLine("[q]: To quit.");
    switch (Console.ReadKey().KeyChar)
    {
        case 'B':
        case 'b':
            StartGame();
            break;
        case 'Q':
        case 'q':
            flag = false;
            break;
        default:
            System.Console.WriteLine("Unknown option.");
            break;
    }
} while (flag);

void StartGame()
{
    new Blackjack().StartGame();
}