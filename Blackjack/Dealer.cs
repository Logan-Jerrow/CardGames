namespace BlackjackModel
{
    internal class Dealer : Player
    {
        private DeckOfCards Deck;
        public Player opponent { get; private set; }

        public Dealer(DeckOfCards dealerDeck, Player player)
        {
            Deck = dealerDeck;
            opponent = player;
        }

        //the dealer deals the cards
        public void deal()
        {
            for (int i = 0; i < 2; i++)
            {
                opponent.hand.cards.Add(Deck.DrawACard());
                this.hand.cards.Add(Deck.DrawACard());
            }
        }
    }
}