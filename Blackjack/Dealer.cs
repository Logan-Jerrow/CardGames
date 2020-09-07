using CardLibrary;
using CardLibrary.Cards;
using System;
using System.Collections.Generic;

namespace Blackjack
{
    public sealed class Dealer
    {
        public Dealer()
        {
            Deck = Deck.BuildStandard52CardDeck();
        }

        public Deck Deck { get; private set; }

        public void Shuffle() => Deck = Deck.Shuffle();


    }
}

