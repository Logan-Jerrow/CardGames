using System;
using System.Collections.Generic;
using System.Threading;

namespace BlackjackModel
{
    internal class DeckOfCards
    {
        private List<Cards> unshuffledDeck;
        public Stack<Cards> Deck { get; private set; }

        public DeckOfCards()
        {
            Initialize();
        }

        private void Initialize()
        {
            unshuffledDeck = new List<Cards>();
            foreach (Cards.SUIT s in Enum.GetValues(typeof(Cards.SUIT)))
            {
                foreach (Cards.VALUE v in Enum.GetValues(typeof(Cards.VALUE)))
                {
                    unshuffledDeck.Add(new Cards { mySuit = s, myValue = v });
                }
            }

            for (int i = 0; i < 100; i++)
            {
                unshuffledDeck.Shuffle();
            }

            Deck = new Stack<Cards>(unshuffledDeck);
        }

        public Cards DrawACard()
        {
            return Deck.Pop();
        }

        public void PrintDeck()
        {
            int i = 0;
            foreach (Cards c in Deck)
            {
                i++;
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine("Amount of cards: {0}", i);
        }
    }

    public static class ThreadSafeRandom
    {
        [ThreadStatic]
        private static Random Local;

        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }

    internal static class MyExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}