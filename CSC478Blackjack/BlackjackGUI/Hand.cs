using System;
using System.Collections.Generic;
using System.Text;

namespace CSC478Blackjack
{
    class Hand
    {
        Card[] theHand = new Card[5];
        int total = 0;
        int numberOfCards = 0;

        public Hand()
        {
            
        }
        public void DealCard(Card ACard)
        {
            theHand[numberOfCards++] = ACard;
            total = total + ACard.GetValue();
        }
        public int GetTotal()
        {
            return total;
        }
        public void SetTotal()
        {
            int newtotal = 0;
            for (int i = 0; i < this.GetNumberofCards(); i++)
            {
                int cardvalue = GetCard(i).GetValue();
                newtotal = newtotal + cardvalue;
            }
            total = newtotal;
        }
        public String GetTotalString()
        {
            return Convert.ToString(total);
        }
        public void ResetHand()
        {
            total = 0;
            numberOfCards = 0;
            for (int i = 0; i < 5; i++)
            {
                if (GetCard(i) != null && GetCard(i).IsItAnAce())
                {
                    if (GetCard(i).GetValue() == 1)
                    {
                        GetCard(i).ToggleAce();
                    }
                }
                theHand[i] = null;
            }
        }
        public int GetNumberofCards()
        {
            return numberOfCards;
        }
        public Card GetCard(int index)
        {
            return theHand[index];
        }
        public bool HasAces()
        {
            for (int i = 0; i < theHand.Length; i++)
            {
                {
                    if (GetCard(i) != null && GetCard(i).IsItAnAce())
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
