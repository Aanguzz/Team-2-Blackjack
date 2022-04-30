using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CSC478Blackjack
{
    class Card
    {
        //2.2.0 Each non-face card should display the appropriate numerical value
        //2.3.0 each non-face card should display the appropriate suit, and number of suit symbols
        //2.4.0 each face card should display the appropriate suit.
        //This is the backend Card class that does the different specific requirements listed from 2.2-2.4
        int value;
        bool IsAce;
        Image image;

        public Card(Image myimage, int myvalue)
        {
            image = myimage;
            value = myvalue;
            IsAce = false;
            if (this.GetValue() == 1 || this.GetValue() == 11)
            {
                this.SetCardToAce();
            }
        }
        public void SetCardToAce()
        {
            IsAce = true;
        }
        public int GetValue()
        {
            return value;
        }
        public String GetValueString()
        {
            return Convert.ToString(value);
        }
        public void ToggleAce()
        {
            if (IsAce)
            {
                if (value == 1)
                {
                    value = 11;
                }
                else
                {
                    value = 1;
                }
            }
        }
        public Image GetImage()
        {
            return image;
        }
        public bool IsItAnAce()
        {
            //Returns true if the card is an Ace, returns false otherwise.
            return IsAce;
        }
    }
}
