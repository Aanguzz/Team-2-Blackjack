using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace CSC478Blackjack
{
    class DeckOfCards
    {
        Card[] allCards = new Card[52];
        int currentCardNumber = 0;

        public DeckOfCards()
        {
            LoadCards();
            ShuffleDeck();
        }
        private void LoadCards()
        {
            Card ACard;
            string[] list = Directory.GetFiles(@"Cards", "*.gif"); //populate an array of strings
                                                                   //containing the filenames of all "*.gif" found in the local "cards" directory.
                                                                   // The * will fill in any text before .gif, so that all file names ending in .gif will be considered by the GetFiles() method

            for (int index = 0; index < 52; index++) //iterate through all 52 items(cards)
            {
                int value = GetNextCardValue(index); //captures the card value. GetNextCard returns card value.
                Image image = Image.FromFile(list[index]); //captures card image

                ACard = new Card(image, value); //instantiates a card object and passes the captured values to that object.
                if (index > 32 && index < 36)
                {
                    ACard.SetCardToAce();         //Sets IsAce boolean to True if card is an Ace.
                                                  //The Aces will be between index 32 and 36 due to the order in which the array was populated

                }
                allCards[index] = ACard; //Assigns the properties of Acard to a Card object in the AllCards[] array
                                         //at the current index(which is the incrementing forloop control variable).
            }
        }
        private int GetNextCardValue(int currentcardnumber)
        {
            int cardValue = 0;
            if (currentcardnumber < 33)
                cardValue = (currentcardnumber / 4) + 2;
            else
            {
                cardValue = 10;
            }
            if (currentcardnumber > 31 && currentcardnumber < 36)
                cardValue = 11;//aces
            return cardValue;
        }
        public Card GetNextCard()
        {
            return (allCards[currentCardNumber+=1]);
        }
        public void ShuffleDeck()
        {
            Random rand = new Random();
            for (int i = 0; i < allCards.Length - 1; i++)
            {
                int j = rand.Next(i + 1, allCards.Length);
                Card temp = allCards[i];
                allCards[i] = allCards[j];
                allCards[j] = temp;
            }
            currentCardNumber = 0;
        }
    }
}

