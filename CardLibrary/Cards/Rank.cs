using Ardalis.SmartEnum;

namespace CardLibrary.Cards
{
    public sealed class Rank : SmartEnum<Rank>
    {
        public static readonly Rank Ace = new Rank(nameof(Ace), 1);
        public static readonly Rank Two = new Rank(nameof(Two), 2);
        public static readonly Rank Three = new Rank(nameof(Three), 3);
        public static readonly Rank Four = new Rank(nameof(Four), 4);
        public static readonly Rank Five = new Rank(nameof(Five), 5);
        public static readonly Rank Six = new Rank(nameof(Six), 6);
        public static readonly Rank Seven = new Rank(nameof(Seven), 7);
        public static readonly Rank Eight = new Rank(nameof(Eight), 8);
        public static readonly Rank Nine = new Rank(nameof(Nine), 9);
        public static readonly Rank Ten = new Rank(nameof(Ten), 10);
        public static readonly Rank Jack = new Rank(nameof(Jack), 11);
        public static readonly Rank Queen = new Rank(nameof(Queen), 12);
        public static readonly Rank King = new Rank(nameof(King), 13);

        private Rank(string name, int value) : base(name, value) { }
    }
}