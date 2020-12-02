using Ardalis.SmartEnum.AutoFixture;
using AutoFixture;
using AutoFixture.Xunit2;
using BlackjackLibrary;
using CardLibrary;
using CardLibrary.Cards;
using FluentAssertions;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using CardTests;

namespace CardTests.BlackjackTests
{
    public class ParticipantTest
    {
        [Theory, AceAutoData]
        public void Participant_Score_SoftAceIsEleven(Card card, Participant sut)
        {
            sut.Add(card);
            sut.Score().Should().Be(11);
        }

    }
}