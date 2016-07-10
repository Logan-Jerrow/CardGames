using System;

namespace BlackjackModel
{
    public class Blackjack
    {
        private DeckOfCards deck;
        private Player player;
        private Dealer dealer;
        private bool isFirstGame;

        public Blackjack()
        {
            deck = new DeckOfCards();
            player = new Player();
            dealer = new Dealer(deck, player);
            isFirstGame = true;
        }

        public void startGame()
        {
            while (again())
            {
                Console.Clear();
                dealCards();
                playerTurn();
                dealerTurn();

                winner();
                disscardHands();
            }
        }

        private int CompareScores()
        {
            int playerscore = player.hand.calculateValue();
            int dealerscore = dealer.hand.calculateValue();

            if (playerscore < dealerscore)
                return -1;
            else if (playerscore == dealerscore)
                return 0;
            else if (playerscore > dealerscore)
                return 1;
            else
                throw new Exception("CompareScores invalid retern state");
        }

        private void winner()
        {
            Console.Clear();
            showCardsinHands();
            int win = CompareScores();
            if (player.hand.isBust())
                Console.WriteLine("Player Busted! Dealer Won.");
            else if (dealer.hand.isBust())
                Console.WriteLine("Dealer Busted! Player Won.");
            else
            {
                switch (win)
                {
                    case -1:
                        Console.WriteLine("Player Lost!");
                        break;

                    case 0:
                        Console.WriteLine("Player Pushed!");
                        break;

                    case 1:
                        Console.WriteLine("Player Won!");
                        break;
                }
            }
        }

        private void disscardHands()
        {
            player.hand.cards.Clear();
            dealer.hand.cards.Clear();
        }

        private void dealerTurn()
        {
            Console.Clear();
            showCardsinHands();
            Console.WriteLine("DEALERS TURN");
            while (!(dealer.hand.value(17, 'g')))
            {
                dealer.hand.cards.Add(deck.DrawACard());
                Console.WriteLine("Dealers drawing a card [Press any key to continue]");
                Console.ReadKey();
            }
            showCardsinHands();
        }

        private void playerTurn()
        {
            Console.Clear();
            showCardsinHands();
            Console.WriteLine("Players turn");
            while (!(player.hand.isBlackjack() || player.hand.isBust()) || player.hand.isTwentyone())
            {
                //{Hit = true} {stay = false}
                if (player.PlayerChoice())
                {
                    player.hand.cards.Add(deck.DrawACard());
                    player.hand.showAllCards();
                }
                else
                    break;
            }
        }

        private void showCardsinHands()
        {
            //Console.WriteLine("\n====>Dealer's Hand<====");
            //dealer.hand.showAllCards();
            //Console.WriteLine("\n====>Players's Hand<====");
            //player.hand.showAllCards();
            Console.WriteLine("\tDealer's Hand");
            dealer.hand.showAllCards();

            Console.WriteLine("\n\tPlayer's Hand");
            player.hand.showAllCards();
            /*
            Console.WriteLine("Dealer's Hand");
            Console.WriteLine("Dealer's Score: {0}", dealer.hand.calculateValue());
            dealer.hand.showAllCards();

            Console.WriteLine("\nPlayer's Hand");
            Console.WriteLine("Player's Score: {0}", player.hand.calculateValue());
            player.hand.showAllCards();

            */
        }

        private void dealCards()
        {
            dealer.deal();
        }

        private bool again()
        {
            bool inputParsed, flag = true;

            #region again_while

            while (flag)
            {
                string input;

                if (isFirstGame == false)
                    Console.WriteLine("\nWant to play again?\n[y]es or [n]o => ");
                else
                {
                    isFirstGame = false;
                    return true;
                }

                input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "yes":
                    case "y":
                        flag = true;
                        return inputParsed = true;

                    case "no":
                    case "n":
                        flag = true;
                        return inputParsed = false;

                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }

            #endregion again_while

            throw new Exception("again method broke out of while");
        }
    }
}