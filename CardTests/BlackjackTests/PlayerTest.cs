using AutoFixture;
using AutoFixture.Xunit2;
using BlackjackLibrary;
using CardLibrary;
using FluentAssertions;
using System.Linq;
using Xunit;

namespace CardTests.BlackjackTests
{
    public class PlayerTest
    {
        [Theory, AutoData]
        public void PlayerTest_Hand_CreatedEmpty(Player player) => player.PlayerHand.Cards.Should().BeEmpty();

        [Fact]
        public void PlayerTest_Score_CalculateScore()
        {
            var fixture = new Fixture();
            var sut = fixture.CreateMany<Player>(4).ToList();
            var suits = Deck.BuildStandard52CardDeck().Cards.GroupBy(x => x.Suit).ToList();

            for (int i = 0; i > 4; i++)
            {
                sut[i].Add(suits[i]);
                sut[i].Score().Should().Be(85);
            }
        }
    }
}