using CardLibrary.Cards;
using Xunit;

namespace CardTests.CardLibrary
{
    public class CardTest
    {
        [Fact]
        public void Card_Created()
        {
            foreach (var card in Card.List)
            {
                Assert.NotNull(card);
                Assert.Equal(
                    card.Rank.Name + "Of" + card.Suit.Name,
                    card.Name);
                Assert.Equal(Suit.FromName(card.Suit.Name), card.Suit);
                Assert.Equal(Rank.FromName(card.Rank.Name), card.Rank);
            }
        }
    }
}
