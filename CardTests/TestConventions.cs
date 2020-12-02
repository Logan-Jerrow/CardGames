
using System;
using System.Collections.Generic;
using System.Linq;
using Ardalis.SmartEnum.AutoFixture;
using AutoFixture;
using AutoFixture.Xunit2;
using CardLibrary;
using CardLibrary.Cards;

namespace CardTests
{
    internal class GetAllCards : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Register<IEnumerable<Card>>(() => Deck.Standard52CardDeck().Cards);
        }
    }
    internal class AllCardAutoDataAttribute : AutoDataAttribute
    {
        public AllCardAutoDataAttribute() : base(() => new Fixture().Customize(new GetAllCards())) { }
    }
    internal class RandomCard : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Register(GetRandomCard);

            Card GetRandomCard()
            {
                Random random = new();
                List<Card> cards = Deck.Standard52CardDeck().Cards.ToList();
                return cards.ElementAt(random.Next(cards.Count));
            }
        }

    }
    internal class CardAutoDataAttribute : AutoDataAttribute
    {
        public CardAutoDataAttribute() : base(() => new Fixture().Customize(new RandomCard())) { }
    }

    internal class RandomAce : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Register(GetRandomAce);

            Card GetRandomAce()
            {
                Random random = new();
                List<Card> cards = Deck.Standard52CardDeck().Cards.Where(c => c.Rank == Rank.Ace).ToList();
                return cards.ElementAt(random.Next(cards.Count));
            }
        }
    }
    internal class AceAutoDataAttribute : AutoDataAttribute
    {
        public AceAutoDataAttribute() : base(() => new Fixture().Customize(new RandomAce())) { }
    }
}