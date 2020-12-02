using System.Collections.Generic;
using System.Linq;
using CardLibrary;
using CardLibrary.Cards;
using Xunit;
using FluentAssertions;
namespace CardTests
{
    public class UtilityTest
    {
        [Theory, AllCardAutoData]
        public void Utility_IsFaceCard_12FaceCardsInStandardDeck(IEnumerable<Card> cards)
        {
            cards.Where(c => c.IsFaceCard()).Count().Should().Be(12);
        }
    }
}