using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC478Blackjack
{
    //1.0.0 The Blackjack game will have a GUI in order to interact with various buttons, and will display the current cards being played by both the dealer and player.
    //This is the form that represents the GUI
    public partial class BlackJack : Form
    {
        Funds playerFunds = new Funds(5000);
        //2.1.0 The back of the cards will have a UIS theme. 
        Image backOfCard;
        Button[] playerCardButtonList = new Button[5];
        Button[] dealerCardButtonList = new Button[5];
        Hand playerHand = new Hand();
        Hand dealerHand = new Hand();
        DeckOfCards deck = new DeckOfCards();
        bool firstHand = false;


        public BlackJack()
        {
            InitializeComponent();
            //2.1.0 The back of the cards will have a UIS theme. 
            backOfCard = Image.FromFile("Cards/BackOfCard.png");
            LoadLists();
            HitButton.Enabled = false;
            StayButton.Enabled = false;
            BankrollAmountBox.Enabled = false;
            BankrollAmountBox.Text = playerFunds.GetTotalFundsString();
            CurrentBetBox.Text = "100";
            label1.BackColor = Color.Transparent;
            PlayerTotalLabel.BackColor = Color.Transparent;
            DealerTotalLabel.BackColor = Color.Transparent;
        }
        //1.2.0 The GUI will have a “Hit” button in order for a player to draw a card to their current hand. If the dealer has to draw a card, this same button will be called on the backend.
        //This is the backend of what happens when the hit button is clicked. The Hit button is actually created in the BlackJack.Designer.cs class.
        private void HitButton_Click(object sender, EventArgs e)
        {
            if (DealCardToPlayer())
            {
                if (playerHand.GetTotal() == 21)
                {
                    StartGame.Enabled = true;
                    HitButton.Enabled = false;
                    StayButton.Enabled = false;
                    CurrentBetBox.Enabled = true;
                    DealersTurn();
                    CheckWinner();
                    DisplayDealerGraphics();

                }
                else if (playerHand.GetTotal() > 21 && !playerHand.HasAces())
                {
                    StartGame.Enabled = true;
                    HitButton.Enabled = false;
                    StayButton.Enabled = false;
                    CurrentBetBox.Enabled = true;
                    playerFunds.LostBet();
                    DisplayDealerGraphics();
                    DisplayPlayerGraphics();
                    MessageBox.Show("You busted! Dealer wins.");
                    CheckBankrupt();
                }
                else if (playerHand.GetTotal() > 21 && PlayerCheckAce() == false)
                {
                    StartGame.Enabled = true;
                    HitButton.Enabled = false;
                    StayButton.Enabled = false;
                    CurrentBetBox.Enabled = true;
                    playerFunds.LostBet();
                    DisplayDealerGraphics();
                    DisplayPlayerGraphics();
                    MessageBox.Show("You busted! Dealer wins.");
                    CheckBankrupt();
                }
                //Potential Ace issue fix
                else if (playerHand.GetTotal() > 21 && playerHand.HasAces())
                {
                    PlayerCheckAce();
                }
            }
            else
            {

                HitButton.Enabled = false;
            }
        }
        //1.3.0 The GUI will have a “Stay” button that will allow a player to keep their current hand.
        //This is the backend of what happens when the Stay button is clicked. The stay button is actually created in the BlackJack.Designer.cs class.
        private void StayButton_Click(object sender, EventArgs e)
        {
            //take note of the current cards
            //Compare the active card totals
            //Grant the Player or Dealer the win
            //Make the dealer draw if under 17
            //Make the dealer stay on 17 or greater

            //3.3.0 According to standard rules, once the player stays, the dealer reveals his face down card and adds up their points.
            //If 17 or more they must stay. If 16 or less, they must hit until the points add up to 17 or more.
            //If the dealer has an Ace and counting it as 11 makes the total 17 or more without going over 21, they must stay. 

            DisplayDealerGraphics();
            DisableCardButtons();
            CurrentBetBox.Enabled = true;
            StayButton.Enabled = false;
            HitButton.Enabled = false;
            StartGame.Enabled = true;

            //3.5.0 According to standard rules, if a player goes over 21, the hand is a bust and their bet goes to the dealer.
            if (playerHand.GetTotal() > 21)
            {
                playerFunds.LostBet();
                DealerCheckAce();
                DisplayDealerGraphics();
                DisplayPlayerGraphics();
                MessageBox.Show("You busted! Dealer wins.");
                CheckBankrupt();
            }
            else
            {
                bool dealing = true;
                while (dealing)
                {
                    if (dealerHand.GetTotal() >= 21)
                    {
                        if (!DealerCheckAce())
                        {
                            dealing = false;
                        }
                    }
                    else
                    {
                        if (dealerHand.GetTotal() < 17 || dealerHand.GetTotal() < playerHand.GetTotal())
                        {
                            if (!DealCardToDealer())
                            {
                                dealing = false;
                            }
                        }
                        if (dealerHand.GetTotal() >= 17 && dealerHand.GetTotal() >= playerHand.GetTotal())
                        {
                            if (!DealerCheckAce())
                            {
                                dealing = false;
                            }
                        }
                    }
                }
                CheckWinner();
            }
        }
        //1.1.0 The GUI will have a “Start” button to activate the game, enable the buttons, and draw the initial hands for the player and dealer.
        //This is the backend of what happens when the start button is clicked. The start button is actually created in BlackJack.Designer.cs class.
        private void StartGame_Click(object sender, EventArgs e)
        {
            if (playerFunds.GetBetAmount() > playerFunds.GetTotalFunds())
            {
                CurrentBetBox.Text = playerFunds.GetTotalFundsString();
            }
            CurrentBetBox.Text = playerFunds.GetBetAmount().ToString();
            BankrollAmountBox.Text = playerFunds.GetTotalFundsString();
            HitButton.Enabled = true;
            StayButton.Enabled = true;
            playerHand.ResetHand();
            dealerHand.ResetHand();
            EnableCardButtons();
            CurrentBetBox.Enabled = false;
            firstHand = true;
            StartGame.Enabled = false;
            //3.2.0 The player and dealer will be dealt two cards to start, only one card from the dealer will be visible to the player.

            Card tempCard = deck.GetNextCard();
            dealerHand.DealCard(tempCard);

            tempCard = deck.GetNextCard();
            playerHand.DealCard(tempCard);

            tempCard = deck.GetNextCard();
            dealerHand.DealCard(tempCard);

            tempCard = deck.GetNextCard();
            playerHand.DealCard(tempCard);

            DisplayDealerGraphics();
            DisplayPlayerGraphics();
            firstHand = false;
            //At this stage a “Natural Blackjack” may occur.
            //In such a case, the player with a “Natural Blackjack” wins the hand according to standard rules.
            //Payout is 3 to 1 for the game in this scenario.
            if (playerHand.GetTotal() == 21 && dealerHand.GetTotal() == 21)
            {
                StartGame.Enabled = true;
                HitButton.Enabled = false;
                StayButton.Enabled = false;
                DisplayDealerGraphics();
                MessageBox.Show("Tie. Nothing happens.");
            }
            else if (playerHand.GetTotal() == 21)
            {
                StartGame.Enabled = true;
                HitButton.Enabled = false;
                StayButton.Enabled = false;
                playerFunds.BlackJackWin();
                DisplayDealerGraphics();
                DisplayPlayerGraphics();
                MessageBox.Show("Blackjack!! You win!!!");
            }
            else if (dealerHand.GetTotal() == 21)
            {
                StartGame.Enabled = true;
                HitButton.Enabled = false;
                StayButton.Enabled = false;
                playerFunds.LostBet();
                DisplayDealerGraphics();
                DisplayPlayerGraphics();
                MessageBox.Show("Dealer has Blackjack. You lose.");
                CheckBankrupt();
            }

        }
        public void LoadLists()
        {
            playerCardButtonList[0] = playerCard1;
            playerCardButtonList[1] = playerCard2;
            playerCardButtonList[2] = playerCard3;
            playerCardButtonList[3] = playerCard4;
            playerCardButtonList[4] = playerCard5;
            dealerCardButtonList[0] = dealerCard1;
            dealerCardButtonList[1] = dealerCard2;
            dealerCardButtonList[2] = dealerCard3;
            dealerCardButtonList[3] = dealerCard4;
            dealerCardButtonList[4] = dealerCard5;
        }
        private void DisableCardButtons()
        {
            playerCard1.Enabled = false;
            playerCard2.Enabled = false;
            playerCard3.Enabled = false;
            playerCard4.Enabled = false;
            playerCard5.Enabled = false;
        }
        private void EnableCardButtons()
        {
            playerCard1.Enabled = true;
            playerCard2.Enabled = true;
            playerCard3.Enabled = true;
            playerCard4.Enabled = true;
            playerCard5.Enabled = true;
        }
        private void playerCard1_Click(object sender, EventArgs e)
        {
            playerHand.GetCard(0).ToggleAce();
            playerHand.SetTotal();
            DisplayPlayerGraphics();
        }

        private void playerCard2_Click(object sender, EventArgs e)
        {
            playerHand.GetCard(1).ToggleAce();
            playerHand.SetTotal();
            DisplayPlayerGraphics();
        }

        private void playerCard3_Click(object sender, EventArgs e)
        {
            playerHand.GetCard(2).ToggleAce();
            playerHand.SetTotal();
            DisplayPlayerGraphics();
        }

        private void playerCard4_Click(object sender, EventArgs e)
        {
            playerHand.GetCard(3).ToggleAce();
            playerHand.SetTotal();
            DisplayPlayerGraphics();
        }

        private void playerCard5_Click(object sender, EventArgs e)
        {
            playerHand.GetCard(4).ToggleAce();
            playerHand.SetTotal();
            DisplayPlayerGraphics();
        }
        private void CheckBankrupt()
        {
            if (playerFunds.GetTotalFunds() <= 0)
            {
                MessageBox.Show("You ran out of money. Game over!");
                Application.Exit();
            }
        }
        private void CheckWinner()
        {
            //3.3.0 According to standard rules, once the player stays, the dealer reveals his face down card and adds up their points.
            //If 17 or more they must stay. If 16 or less, they must hit until the points add up to 17 or more.
            //If the dealer has an Ace and counting it as 11 makes the total 17 or more without going over 21, they must stay. 
           
            if (playerHand.GetTotal() > dealerHand.GetTotal())
            {
                if (dealerHand.GetTotal() > 21)
                {
                    if (CheckBlackJack())
                    {
                        playerFunds.BlackJackWin();

                    }
                    else
                    {
                        playerFunds.WonBet();
                    }
                    DisplayPlayerGraphics();
                    MessageBox.Show("Dealer's Hand:" + dealerHand.GetTotalString() + "\nPlayer's Hand:" + playerHand.GetTotalString() + "\n\nDealer Busts. You win!");
                }
                else
                {
                    if (CheckBlackJack())
                    {
                        playerFunds.BlackJackWin();

                    }
                    else
                    {
                        playerFunds.WonBet();
                    }
                    DisplayPlayerGraphics();
                    MessageBox.Show("Dealer's Hand:" + dealerHand.GetTotalString() + "\nPlayer's Hand:" + playerHand.GetTotalString() + "\n\nYou have the better hand. You win!");
                }

            }
            else if (playerHand.GetTotal() < dealerHand.GetTotal())
            {
                if (dealerHand.GetTotal() <= 21)
                {
                    playerFunds.LostBet();
                    DisplayPlayerGraphics();
                    MessageBox.Show("Dealer's Hand:" + dealerHand.GetTotalString() + "\nPlayer's Hand:" + playerHand.GetTotalString() + "\n\nDealer has the better hand. You lose.");
                    CheckBankrupt();
                }
                else
                {
                    if (CheckBlackJack())
                    {
                        playerFunds.BlackJackWin();

                    }
                    else
                    {
                        playerFunds.WonBet();
                    }
                    DisplayPlayerGraphics();
                    MessageBox.Show("Dealer's Hand:" + dealerHand.GetTotalString() + "\nPlayer's Hand:" + playerHand.GetTotalString() + "\n\nDealer Busts. You win!");
                }
            }
            else
            {
                //3.6.0 According to standard rules, a “Push” occurs when the player and the dealer both have blackjack and/or the same number of points in their hand.
                //No bets are paid or collected. In the case of our game, funds are returned to the bankroll.
                MessageBox.Show("Dealer's Hand:" + dealerHand.GetTotalString() + "\nPlayer's Hand:" + playerHand.GetTotalString() + "\n\nTie. Nothing happens.");
            }
            DisableCardButtons();
        }
        //3.4.0 If the player holds exactly 21 then the payout is 3 to 1
        //this is the class that will perform that action
        private bool CheckBlackJack()
        {
            if (playerHand.GetTotal() == 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool DealerCheckAce()
        {
            if (dealerHand.GetTotal() > 21 && dealerHand.HasAces())
            {
                for (int i = 0; i < dealerHand.GetNumberofCards(); i++)
                {
                    if (dealerHand.GetCard(i).IsItAnAce() && dealerHand.GetCard(i).GetValue() == 11)
                    {
                        dealerHand.GetCard(i).ToggleAce();
                        dealerHand.SetTotal();
                        DisplayDealerGraphics();
                        return true;
                    }
                }
            }
            return false;
        }
        private bool PlayerCheckAce()
        {
            if (playerHand.GetTotal() > 21 && playerHand.HasAces())
            {
                for (int i = 0; i < playerHand.GetNumberofCards(); i++)
                {
                    if (playerHand.GetCard(i).IsItAnAce() && playerHand.GetCard(i).GetValue() == 11)
                    {
                        playerHand.GetCard(i).ToggleAce();
                        playerHand.SetTotal();
                        DisplayPlayerGraphics();
                        return true;
                    }
                }
            }
            return false;
        }
        private void DealersTurn()
        {
            bool dealing = true;
            while (dealing)
            {
                if (dealerHand.GetTotal() >= 21)
                {
                    if (!DealerCheckAce())
                    {
                        dealing = false;
                    }
                }
                else
                {
                    if (dealerHand.GetTotal() < 17 || dealerHand.GetTotal() < playerHand.GetTotal())
                    {
                        if (!DealCardToDealer())
                        {
                            dealing = false;
                        }
                    }
                    if (dealerHand.GetTotal() >= 17 && dealerHand.GetTotal() >= playerHand.GetTotal())
                    {
                        if (!DealerCheckAce())
                        {
                            dealing = false;
                        }
                    }
                }
            }
        }
        private Boolean DealCardToDealer()
        {
            int numberofcards = dealerHand.GetNumberofCards();
            if (numberofcards < 5)
            {
                Card somecard = deck.GetNextCard();
                dealerHand.DealCard(somecard);
                DisplayDealerGraphics();
                return true;
            }
            return false;
        }
        private Boolean DealCardToPlayer()
        {
            int numberofcards = playerHand.GetNumberofCards();
            if (numberofcards < 5)
            {
                Card somecard = deck.GetNextCard();
                playerHand.DealCard(somecard);
                DisplayPlayerGraphics();
                return true;
            }
            return false;
        }
        public void DisplayDealerGraphics()
        {
            if (firstHand)
            {
                for (int i = 0; i < 5; i++)
                {
                    dealerCardButtonList[i].Visible = false;
                }
                dealerCardButtonList[0].BackgroundImage = dealerHand.GetCard(0).GetImage();
                dealerCardButtonList[0].Visible = true;
                dealerCardButtonList[1].BackgroundImage = backOfCard;
                dealerCardButtonList[1].Visible = true;
                DealerTotalLabel.Text = dealerHand.GetCard(0).GetValueString();
            }
            else
            {
                for (int i = 0; i < dealerHand.GetNumberofCards(); i++)
                {
                    Card acard = dealerHand.GetCard(i);
                    dealerCardButtonList[i].BackgroundImage = acard.GetImage();
                    dealerCardButtonList[i].Visible = true;
                    DealerTotalLabel.Text = dealerHand.GetTotalString();
                }
            }
        }
        public void DisplayPlayerGraphics()
        {
            if (firstHand)
            {
                for (int i = 0; i < 5; i++)
                {
                    playerCardButtonList[i].Visible = false;
                    PlayerTotalLabel.Text = "";
                }
                for (int i = 0; i < playerHand.GetNumberofCards(); i++)
                {
                    Card acard = playerHand.GetCard(i);
                    {
                        playerCardButtonList[i].BackgroundImage = acard.GetImage();
                        playerCardButtonList[i].Visible = true;
                        PlayerTotalLabel.Text = playerHand.GetTotalString();
                    }
                }
            }
            else
            {
                for (int i = 0; i < playerHand.GetNumberofCards(); i++)
                {
                    Card acard = playerHand.GetCard(i);
                    playerCardButtonList[i].BackgroundImage = acard.GetImage();
                    playerCardButtonList[i].Visible = true;
                    PlayerTotalLabel.Text = playerHand.GetTotalString();
                }
            }
            BankrollAmountBox.Text = playerFunds.GetTotalFundsString();
        }

        //1.5.0 The GUI will have a box to enter your bet for the next round, and cannot exceed the current Bankroll total.
        //This is the background functionality of said box.
        //3.1.0 Before the deal, a player may place a bet from 0 to the amount in their bankroll.
        
        private void CurrentBetBox_TextChanged(object sender, EventArgs e)
        {
            
            if (!CurrentBetBox.Text.Equals(""))
            {
                int betAmount = int.Parse(GetNumbers(CurrentBetBox.Text));
                if (betAmount > playerFunds.GetTotalFunds())
                {
                    CurrentBetBox.Text = playerFunds.GetTotalFundsString();
                }
                else
                {
                    playerFunds.SetBetAmount(betAmount);
                }

            }
            else
            {
                CurrentBetBox.Text = "0";
                playerFunds.SetBetAmount(0);
            }
        }
        
        private static string GetNumbers(string input)
        {
            return new string(input.Where(c => char.IsDigit(c)).ToArray());
        }

    }
}
