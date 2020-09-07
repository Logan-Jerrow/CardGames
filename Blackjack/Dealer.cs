using CardLibrary;

namespace Blackjack
{
    public sealed class Dealer
    {
        public Dealer()
        {
            Deck = new Standard52CardDeck().Shuffle();
        }

        public Standard52CardDeck Deck { get; }
    }
}
