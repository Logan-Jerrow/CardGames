using CardLibrary;
using FluentAssertions;
using System.Linq;
using Xunit;

namespace CardTests.CardLibraryTest
{
    public class DeckTest
    {
        [Fact]
        public void Deck_Created_52Cards()
        {
            Standard52CardDeck standard52 = new Standard52CardDeck();
            Assert.True(standard52.Deck.Count == 52);
        }

        [Fact]
        public void Deck_Shuffle_Equivalency()
        {
            var deck = new Standard52CardDeck();
            var cards = deck.Deck.ToList();
            var shuffledCards = deck.Shuffle().Deck.ToList();

            cards.Should().BeEquivalentTo(shuffledCards);
        }
    }
}
