using System.Linq;
using CardLibrary.Cards;

namespace CardLibrary
{
    public static class Utility
    {
        public static bool IsFaceCard(this Card card)
        {
            if (card.Rank >= Rank.Jack) return true;
            return false;
        }
    }
}