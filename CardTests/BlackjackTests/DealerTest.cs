using AutoFixture.Xunit2;
using Blackjack;
using CardLibrary.Cards;
using FluentAssertions;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CardTests.BlackjackTests
{
    public class DealerTest
    {
        [Fact]
        public void Dealer_Deal_Card()
        {
            Dealer sut = new Dealer();
            Card expected = sut.Deck.Cards.Last();

            sut.Deal().Should().Be(expected);
        }
    }
}