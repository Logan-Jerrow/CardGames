using CardLibrary.Cards;
using Xunit;

namespace CardTests.CardLibrary
{
    public class CardTest
    {
        [Fact]
        public void Cards_Created()
        {
            Assert.True(Card.List.Count == 52); // 52 is the standard amount of cards.
        }
    }
}
