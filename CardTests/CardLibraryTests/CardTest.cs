using CardLibrary.Cards;
using System;
using Xunit;

namespace CardTests.CardLibraryTest
{
    public class CardTest
    {
        [Fact]
        public void Cards_Created()
        {
            Assert.All(Card.List, (card) => Assert.True(
                card.Value == 100 * card.Suit + card.Rank &&
                card.Name.Equals(card.Rank.Name + "Of" + card.Suit.Name,
                    StringComparison.Ordinal)));
        }
    }
}