using Ardalis.SmartEnum;

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

        public static readonly Card AceOfSpades = new Card(nameof(AceOfSpades), Suit.Spades, Rank.Ace);
        public static readonly Card TwoOfSpades = new Card(nameof(TwoOfSpades), Suit.Spades, Rank.Two);
        public static readonly Card ThreeOfSpades = new Card(nameof(ThreeOfSpades), Suit.Spades, Rank.Three);
        public static readonly Card FourOfSpades = new Card(nameof(FourOfSpades), Suit.Spades, Rank.Four);
        public static readonly Card FiveOfSpades = new Card(nameof(FiveOfSpades), Suit.Spades, Rank.Five);
        public static readonly Card SixOfSpades = new Card(nameof(SixOfSpades), Suit.Spades, Rank.Six);
        public static readonly Card SevenOfSpades = new Card(nameof(SevenOfSpades), Suit.Spades, Rank.Seven);
        public static readonly Card EightOfSpades = new Card(nameof(EightOfSpades), Suit.Spades, Rank.Eight);
        public static readonly Card NineOfSpades = new Card(nameof(NineOfSpades), Suit.Spades, Rank.Nine);
        public static readonly Card TenOfSpades = new Card(nameof(TenOfSpades), Suit.Spades, Rank.Ten);
        public static readonly Card JackOfSpades = new Card(nameof(JackOfSpades), Suit.Spades, Rank.Jack);
        public static readonly Card QueenOfSpades = new Card(nameof(QueenOfSpades), Suit.Spades, Rank.Queen);
        public static readonly Card KingOfSpades = new Card(nameof(KingOfSpades), Suit.Spades, Rank.King);

        public static readonly Card AceOfHearts = new Card(nameof(AceOfHearts), Suit.Hearts, Rank.Ace);
        public static readonly Card TwoOfHearts = new Card(nameof(TwoOfHearts), Suit.Hearts, Rank.Two);
        public static readonly Card ThreeOfHearts = new Card(nameof(ThreeOfHearts), Suit.Hearts, Rank.Three);
        public static readonly Card FourOfHearts = new Card(nameof(FourOfHearts), Suit.Hearts, Rank.Four);
        public static readonly Card FiveOfHearts = new Card(nameof(FiveOfHearts), Suit.Hearts, Rank.Five);
        public static readonly Card SixOfHearts = new Card(nameof(SixOfHearts), Suit.Hearts, Rank.Six);
        public static readonly Card SevenOfHearts = new Card(nameof(SevenOfHearts), Suit.Hearts, Rank.Seven);
        public static readonly Card EightOfHearts = new Card(nameof(EightOfHearts), Suit.Hearts, Rank.Eight);
        public static readonly Card NineOfHearts = new Card(nameof(NineOfHearts), Suit.Hearts, Rank.Nine);
        public static readonly Card TenOfHearts = new Card(nameof(TenOfHearts), Suit.Hearts, Rank.Ten);
        public static readonly Card JackOfHearts = new Card(nameof(JackOfHearts), Suit.Hearts, Rank.Jack);
        public static readonly Card QueenOfHearts = new Card(nameof(QueenOfHearts), Suit.Hearts, Rank.Queen);
        public static readonly Card KingOfHearts = new Card(nameof(KingOfHearts), Suit.Hearts, Rank.King);

        public static readonly Card AceOfDiamonds = new Card(nameof(AceOfDiamonds), Suit.Diamonds, Rank.Ace);
        public static readonly Card TwoOfDiamonds = new Card(nameof(TwoOfDiamonds), Suit.Diamonds, Rank.Two);
        public static readonly Card ThreeOfDiamonds = new Card(nameof(ThreeOfDiamonds), Suit.Diamonds, Rank.Three);
        public static readonly Card FourOfDiamonds = new Card(nameof(FourOfDiamonds), Suit.Diamonds, Rank.Four);
        public static readonly Card FiveOfDiamonds = new Card(nameof(FiveOfDiamonds), Suit.Diamonds, Rank.Five);
        public static readonly Card SixOfDiamonds = new Card(nameof(SixOfDiamonds), Suit.Diamonds, Rank.Six);
        public static readonly Card SevenOfDiamonds = new Card(nameof(SevenOfDiamonds), Suit.Diamonds, Rank.Seven);
        public static readonly Card EightOfDiamonds = new Card(nameof(EightOfDiamonds), Suit.Diamonds, Rank.Eight);
        public static readonly Card NineOfDiamonds = new Card(nameof(NineOfDiamonds), Suit.Diamonds, Rank.Nine);
        public static readonly Card TenOfDiamonds = new Card(nameof(TenOfDiamonds), Suit.Diamonds, Rank.Ten);
        public static readonly Card JackOfDiamonds = new Card(nameof(JackOfDiamonds), Suit.Diamonds, Rank.Jack);
        public static readonly Card QueenOfDiamonds = new Card(nameof(QueenOfDiamonds), Suit.Diamonds, Rank.Queen);
        public static readonly Card KingOfDiamonds = new Card(nameof(KingOfDiamonds), Suit.Diamonds, Rank.King);

        public static readonly Card AceOfClubs = new Card(nameof(AceOfClubs), Suit.Clubs, Rank.Ace);
        public static readonly Card TwoOfClubs = new Card(nameof(TwoOfClubs), Suit.Clubs, Rank.Two);
        public static readonly Card ThreeOfClubs = new Card(nameof(ThreeOfClubs), Suit.Clubs, Rank.Three);
        public static readonly Card FourOfClubs = new Card(nameof(FourOfClubs), Suit.Clubs, Rank.Four);
        public static readonly Card FiveOfClubs = new Card(nameof(FiveOfClubs), Suit.Clubs, Rank.Five);
        public static readonly Card SixOfClubs = new Card(nameof(SixOfClubs), Suit.Clubs, Rank.Six);
        public static readonly Card SevenOfClubs = new Card(nameof(SevenOfClubs), Suit.Clubs, Rank.Seven);
        public static readonly Card EightOfClubs = new Card(nameof(EightOfClubs), Suit.Clubs, Rank.Eight);
        public static readonly Card NineOfClubs = new Card(nameof(NineOfClubs), Suit.Clubs, Rank.Nine);
        public static readonly Card TenOfClubs = new Card(nameof(TenOfClubs), Suit.Clubs, Rank.Ten);
        public static readonly Card JackOfClubs = new Card(nameof(JackOfClubs), Suit.Clubs, Rank.Jack);
        public static readonly Card QueenOfClubs = new Card(nameof(QueenOfClubs), Suit.Clubs, Rank.Queen);
        public static readonly Card KingOfClubs = new Card(nameof(KingOfClubs), Suit.Clubs, Rank.King);
    }
}
