using Blackjack;
using Xunit;

namespace CardTests.BlackjackTests
{
    public class DealerTest
    {
        [Fact]
        public void Dealer_Deck_IsCreated()
        {
            Dealer dealer = new Dealer();
            dealer.Shuffle();
        }
    }
}