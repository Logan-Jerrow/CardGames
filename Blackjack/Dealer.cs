using CardLibrary;
using CardLibrary.Cards;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack
{
    public sealed class Dealer
    {
        public Dealer()
        {
            Deck = Deck.BuildStandard52CardDeck().Shuffle();
        }

        public Deck Deck { get; private set; }

        public Card Deal()
        {
            Deck = Deck.Pop(out Card card);
            return card;
        }

        public void Shuffle() => Deck = Deck.Shuffle();
    }
}