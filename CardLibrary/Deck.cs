using CardLibrary.Cards;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace CardLibrary
{
   public sealed class Deck
    {
        private readonly ImmutableList<Card> deck;

        public Deck()
        {
            deck = Card.List.ToImmutableList();
        }
    }
}
