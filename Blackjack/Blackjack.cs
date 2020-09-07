using CardLibrary;
using CardLibrary.Cards;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackjackLibrary
{
    public sealed class Blackjack
    {
        public Blackjack()
        {
            DealerDeck = Deck.BuildStandard52CardDeck().Shuffle();
            PlayerDeck = new Deck();
        }

        public Deck DealerDeck { get; private set; }

        public Deck PlayerDeck { get; private set; }

        public void Deal()
        {
            DealerDeck = DealerDeck.Pop(out Card card);
            PlayerDeck = PlayerDeck.Add(card);
        }
    }
}