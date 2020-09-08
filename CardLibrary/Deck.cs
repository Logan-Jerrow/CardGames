using CardLibrary.Cards;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography;

namespace CardLibrary
{
    public sealed class Deck
    {
        private readonly ImmutableList<Card> deck;

        public Deck() : this(Enumerable.Empty<Card>())
        {
        }

        public Deck(IEnumerable<Card> deck)
        {
            this.deck = deck.ToImmutableList();
        }

        public IList<Card> Cards => deck.ToList();

        public int Count => deck.Count;

        public static Deck BuildDeck(IEnumerable<Card> list) => new Deck(list);

        public static Deck BuildStandard52CardDeck() => BuildDeck(Card.List.OrderBy(card => card.Value));

        public Deck Add(Card card)
        {
            return new Deck(deck.Add(card));
        }

        public Deck Add(IEnumerable<Card> card)
        {
            return new Deck(deck.AddRange(card));
        }

        public Deck Pop(out Card card)
        {
            card = deck.Last();
            return BuildDeck(deck.Remove(card));
        }

        public Deck Shuffle()
        {
            List<Card> list = new List<Card>(deck);
            using (var provider = new RNGCryptoServiceProvider())
            {
                for (int i = list.Count - 1; i > 0; i--)
                {
                    int k = GetK(provider, i + 1);
                    Swap(list, k, i);
                }
            }
            return new Deck(list.ToImmutableList());
        }

        private static int GetK(RNGCryptoServiceProvider provider, int n)
        {
            byte[] box = new byte[1];
            do provider.GetBytes(box);
            while (!(box[0] < n * (byte.MaxValue / n)));
            return (box[0] % n);
        }

        private static void Swap(IList<Card> list, int index1, int index2)
        {
            Card temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}