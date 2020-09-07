using AutoFixture.Xunit2;
using BlackjackLibrary;
using CardLibrary.Cards;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CardTests.BlackjackTests
{
    public class BlackjackTest
    {
        private const int STANDARD_DECK_COUNT = 52;

        [Theory, AutoData]
        public void Blackjack_Deal_PlayerDeckReciveCard(Blackjack sut)
        {
            Card expected = sut.DealerDeck.Cards.Last();

            sut.Deal();

            sut.DealerDeck.Cards.Should().NotContain(expected).And.HaveCount(STANDARD_DECK_COUNT - 1);
            sut.PlayerDeck.Cards.Should().Contain(expected).And.ContainSingle();
        }
    }
}