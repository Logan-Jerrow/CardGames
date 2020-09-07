using CardLibrary;
using FluentAssertions;
using Xunit;

namespace CardTests.CardLibraryTest
{
    public class DeckTest
    {
        private const int STANDARD_DECK_COUNT = 52;

        [Fact]
        public void Deck_Build_52Cards()
        {
            Deck.BuildStandard52CardDeck().Cards
                .Should().HaveCount(STANDARD_DECK_COUNT)
                .And.BeInAscendingOrder(x => x.Value)
                .And.OnlyHaveUniqueItems();
        }

        [Fact]
        public void Deck_Creation_IsEmpty()
        {
            Deck deak = new Deck();
            deak.Should().NotBeNull();
            deak.Count.Should().Be(0, "Deck is empty.");
        }

        [Fact]
        public void Deck_Shuffle_Equivalency()
        {
            var deck = Deck.BuildStandard52CardDeck();
            var cards = deck.Cards;
            var shuffledCards = deck.Shuffle().Cards;

            shuffledCards
                .Should().HaveCount(STANDARD_DECK_COUNT)
                .And.BeEquivalentTo(cards)
                .And.OnlyHaveUniqueItems();
        }
    }
}