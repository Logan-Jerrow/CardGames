using System;
using System.Collections.Generic;

namespace BlackjackModel
{
    internal class Hand
    {
        //private List<Cards> cards;
        public List<Cards> cards { get; set; }

        //minimumce value for ace high vs low to matter
        private int ACE_Range = 11;

        public Hand()
        {
            cards = new List<Cards>();
        }

        public bool isTwentyone()
        {
            return value(21, 'e');
        }

        public bool isBlackjack()
        {
            bool flag = false;
            if (cards.Count == 2 && value(21, 'e'))
                flag = true;
            return flag;
        }

        public bool isBust()
        {
            return value(21, 'g');
        }

        public bool value(int compareValue, char compare)
        {
            int value = calculateValue();
            switch (compare)
            {
                case 'e':
                    return value == compareValue;

                case 'g':
                    return value > compareValue;
            }
            throw new Exception("value Compare did not match");
        }

        public int calculateValue()
        {
            int aceCount = 0;
            int score = 0;
            for (int i = 0; i < cards.Count; i++)
            {
                if (Cards.VALUE.Ace == cards[i].myValue)
                {
                    aceCount++;
                    score += 1;
                }
                else
                    score += (int)cards[i].myValue;
            }
            //two ace highs = 22
            //so calculating more the one ace_high will allways equale bust
            //And if the current score is greater or equal to 11 any ace_high will cause bust
            if (aceCount > 0 && score < ACE_Range)
                return addAce(score);
            else
                return score;
        }

        //Add each ace till bust
        private int addAce(int score)
        {
            //turn ace_low(1) into ace_high(11)
            score--;
            score += 11;

            //is score bust?
            //Should NOT happen
            if (score > 21)
                throw new Exception("addAce Busted");
            else
                return score;
        }

        public void showAllCards()
        {
            Console.WriteLine("\t\tScore: {0}", calculateValue());
            for (int i = 0; i < cards.Count; i++)
            {
                Console.Write("\t\t{0}\n", cards[i].ToString());
            }
        }
    }
}