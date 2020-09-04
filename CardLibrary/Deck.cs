using CardLibrary.Cards;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using MoreLinq;
using System.Linq;
using System.Security.Cryptography;

namespace CardLibrary
{
    public sealed class Standard52CardDeck
    {
        public ImmutableList<Card> Deck { get; private set; }

        public Standard52CardDeck()
        {
            Deck = Card.List.ToImmutableList();
        }

        public void Shuffle()
        {
            List<Card> list = new List<Card>(Deck);
            using (var provider = new RNGCryptoServiceProvider())
            {
                int n = list.Count;
                while (n > 1)
                {
                    byte[] box = new byte[1];
                    do provider.GetBytes(box);
                    while (!(box[0] < n * (byte.MaxValue / n)));
                    int k = (box[0] % n);
                    n--;
                    Card value = list[k];
                    list[k] = list[n];
                    list[n] = value;
                }
            }
            Deck = list.ToImmutableList();
        }
    }
}
