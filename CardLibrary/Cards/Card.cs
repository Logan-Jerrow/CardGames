using Ardalis.SmartEnum;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardLibrary.Cards
{
    public class Card : SmartEnum<Card>
    {
        public Suit Suit { get; }
        public Rank Rank { get; }

        private Card(string name, Suit suit, Rank rank)
            : base(name, suit.Value * rank.Value)
        {
            Suit = suit;
            Rank = rank;
        }

        public static readonly Card AceOfSpades =
            new Card(nameof(AceOfSpades), Suit.Spades, Rank.Ace);

    }
}
