using Ardalis.SmartEnum;

namespace CardLibrary.Cards
{
    public partial class Card : SmartEnum<Card>
    {
        public Suit Suit { get; }
        public Rank Rank { get; }

        private Card(string name, Suit suit, Rank rank)
            : base(name, suit.Value * rank.Value)
        {
            Suit = suit;
            Rank = rank;
        }
    }
}
