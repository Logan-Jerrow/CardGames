using CardLibrary.Cards;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CardTests.CardLibrary
{
    public class CardTest
    {
        [Fact]
        void Card_Created()
        {
            var card = Card.AceOfSpades;
            Assert.NotNull(card);
            Assert.Contains(nameof(Card.AceOfSpades), card.Name, StringComparison.Ordinal);
        }
    }
}
