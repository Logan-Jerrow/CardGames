using System;
using System.Collections.Generic;

namespace BlackjackWPFApp.Model
{
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

    internal class Deck
    {
        internal class DeckOfCard
        {
            private List<Card> unshuffledDeck;

            public DeckOfCard()
            {
                Initialize();
            }

            public Stack<Card> Deck { get; private set; }

            public Card DrawACard()
            {
                return Deck.Pop();
            }

            /// <summary>
            /// The cards in the deck
            /// </summary>
            /// <returns>string</returns>
            public string PrintDeck()
            {
                int i = 0;
                string deck = string.Empty; ;
                foreach (Card c in Deck)
                {
                    i++;
                    deck += c.ToString() + '\n';
                }
                return deck;
            }

            private void Initialize()
            {
                unshuffledDeck = new List<Card>();
                foreach (Card.SUIT s in Enum.GetValues(typeof(Card.SUIT)))
                {
                    foreach (Card.VALUE v in Enum.GetValues(typeof(Card.VALUE)))
                    {
                        unshuffledDeck.Add(new Card { mySuit = s, myValue = v });
                    }
                }

                for (int i = 0; i < 100; i++)
                {
                    unshuffledDeck.Shuffle();
                }

                Deck = new Stack<Card>(unshuffledDeck);
            }
        }
    }
}