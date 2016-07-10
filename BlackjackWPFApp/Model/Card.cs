using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackWPFApp.Model
{
    class Card
    {

            public enum SUIT { Clubs, Diamonds, Hearts, Spades };

            public enum VALUE { Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack = 10, Queen = 10, King = 10, Ace };

            public SUIT mySuit { get; set; }
            public VALUE myValue { get; set; }

            public override string ToString()
            {
                return string.Format("{0} of {1}", myValue, mySuit);
            }

}
