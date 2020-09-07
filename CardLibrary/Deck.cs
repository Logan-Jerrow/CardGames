using CardLibrary.Cards;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography;

namespace CardLibrary
{
    public sealed class Standard52CardDeck
    {
        private readonly ImmutableList<Card> deck;

        public Standard52CardDeck() : this(Card.List.ToImmutableList()) { }

        private Standard52CardDeck(ImmutableList<Card> deck)
        {
            this.deck = deck;
        }

        public int Count => deck.Count;

        public IList<Card> Cards => deck.ToList();

        public Standard52CardDeck Shuffle()
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
            return new Standard52CardDeck(list.ToImmutableList());
        }

        private static void Swap(IList<Card> list, int index1, int index2)
        {
            Card temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }

        private static int GetK(RNGCryptoServiceProvider provider, int n)
        {
            byte[] box = new byte[1];
            do provider.GetBytes(box);
            while (!(box[0] < n * (byte.MaxValue / n)));
            return (box[0] % n);
        }
    }
}
