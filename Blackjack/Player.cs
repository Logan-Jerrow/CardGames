using CardLibrary;
using CardLibrary.Cards;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackjackLibrary
{
    public sealed class Player
    {
        public Player()
        {
            PlayerHand = new Deck();
        }

        public Deck PlayerHand { get; private set; }

        public void Add(IEnumerable<Card> cards)
        {
            PlayerHand = PlayerHand.Add(cards);
        }

        public int Score()
        {
            return PlayerHand.Cards.Aggregate(0, ScoreCalculator());
        }

        private static Func<int, Card, int> ScoreCalculator()
        {
            return (score, card) =>
            {
                if (card.Rank.Value == 1) return score += 1; // Ace
                if (card.Rank.Value < 11) return score += card.Rank.Value; // Numeric card
                if (card.Rank.Value > 10) return score += 10; // Face card
                return score;
            };
        }
    }
}