using CardLibrary;
using CardLibrary.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using MoreLinq;

namespace BlackjackLibrary
{
    public sealed class Participant
    {
        public Participant() : this(Deck.EmptyDeck()) { }

        public Participant(Deck hand)
        {
            ParticipantHand = hand;
        }

        private Deck ParticipantHand { get; set; }

        public void Add(Card cards) => ParticipantHand = ParticipantHand.Add(cards);

        public void Add(IEnumerable<Card> cards) => ParticipantHand = ParticipantHand.Add(cards);

        public IEnumerable<Card> Remove(int amount)
        {

            List<Card> cards = new();
            do
            {
                if (ParticipantHand.Count == 0)
                    break;
                else
                {
                    ParticipantHand.Pop(out Card card);
                    cards.Add(card);
                    amount--;
                }
            } while (amount > 0);
            return cards;
        }

        public int Score()
        {

            int score = 0;
            foreach (Card card in ParticipantHand.Cards)
            {
                score = card.Rank.Value switch
                {
                    var e when e >= Rank.Jack.Value && e <= Rank.King.Value => 10,
                    var e when e >= Rank.Two.Value && e < Rank.Jack.Value => e,
                    var e when e.Equals(Rank.Ace.Value) => 11,
                    _ => throw new System.ComponentModel
                        .InvalidEnumArgumentException("Unknown rank vaule.")
                };
            }
            score = IsHandSoftOrHard(HasAce(ParticipantHand.Cards), score);
            return score;

            static int IsHandSoftOrHard(bool hasAce, int score) => (score > 21 && hasAce) ? score -= 10 : score;

            static bool HasAce(IList<Card> cards) => cards.Select(c => c.Rank).Contains(Rank.Ace);
        }
    }
}