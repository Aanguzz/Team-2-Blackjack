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
    public partial class Form1 : Form
    {
        Funds playerFunds = new Funds(5000);
        Image BackOfCard;
        Button[] PlayerButtonList = new Button[5];
        Button[] DealerButtonList = new Button[5];
        Hand playerHand = new Hand("Player");
        Hand dealerHand = new Hand("Dealer");
        DeckOfCards deck = new DeckOfCards();
        bool firstHand = false;


        public Form1()
        {
            InitializeComponent();
            BackOfCard = Image.FromFile("Cards/BackOfCard.png");
            LoadLists();
            HitButton.Enabled = false;
            StayButton.Enabled = false;
            BankrollAmountBox.Enabled = false;
            BankrollAmountBox.Text = playerFunds.GetTotalFundsString();
            CurrentBetBox.Text = "100";
        }

        private void HitButton_Click(object sender, EventArgs e)
        {
            EnableCardButtons();
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
                //Potential Ace issue fix
                //else if (playerHand.GetTotal() > 21 && playerHand.HasAces())
                //{
                //    if (playerHand.GetCard(0).IsItAnAce())
                //    {
                //        PlayerTotalLabel.Text = playerHand.GetTotalString();
                //        playerHand.GetCard(0).ToggleAce();
                //        playerHand.SetTotal();
                //    }
                //    else if (playerHand.GetCard(1).IsItAnAce())
                //    {
                //        PlayerTotalLabel.Text = playerHand.GetTotalString();
                //        playerHand.GetCard(1).ToggleAce();
                //        playerHand.SetTotal();
                //    }
                //    else if (playerHand.GetCard(2).IsItAnAce())
                //    {
                //        PlayerTotalLabel.Text = playerHand.GetTotalString();
                //        playerHand.GetCard(2).ToggleAce();
                //        playerHand.SetTotal();
                //    }
                //    else if (playerHand.GetCard(3).IsItAnAce())
                //    {
                //        PlayerTotalLabel.Text = playerHand.GetTotalString();
                //        playerHand.GetCard(3).ToggleAce();
                //        playerHand.SetTotal();
                //    }
                //    else if (playerHand.GetCard(4).IsItAnAce())
                //    {
                //        PlayerTotalLabel.Text = playerHand.GetTotalString();
                //        playerHand.GetCard(4).ToggleAce();
                //        playerHand.SetTotal();
                //    }
                //}
            }
            else
            {

                HitButton.Enabled = false;
            }
        }
        private void StayButton_Click(object sender, EventArgs e)
        {
            //take note of the current cards
            //Compare the active card totals
            //Grant the Player or Dealer the win
            //Make the dealer draw if under 17
            //Make the dealer stay on 17 or greater
            DisplayDealerGraphics();
            DisableCardButtons();
            CurrentBetBox.Enabled = true;
            StayButton.Enabled = false;
            HitButton.Enabled = false;
            StartGame.Enabled = true;
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
        private void StartGame_Click(object sender, EventArgs e)
        {
            if (playerFunds.GetBetAmount() > playerFunds.GetTotalFunds())
            {
                CurrentBetBox.Text = playerFunds.GetTotalFundsString();
            }
            BankrollAmountBox.Text = playerFunds.GetTotalFundsString();
            HitButton.Enabled = true;
            StayButton.Enabled = true;
            playerHand.ResetHand();
            dealerHand.ResetHand();
            EnableCardButtons();
            CurrentBetBox.Enabled = false;
            firstHand = true;
            StartGame.Enabled = false;


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
            PlayerButtonList[0] = playerCard1;
            PlayerButtonList[1] = playerCard2;
            PlayerButtonList[2] = playerCard3;
            PlayerButtonList[3] = playerCard4;
            PlayerButtonList[4] = playerCard5;
            DealerButtonList[0] = dealerCard1;
            DealerButtonList[1] = dealerCard2;
            DealerButtonList[2] = dealerCard3;
            DealerButtonList[3] = dealerCard4;
            DealerButtonList[4] = dealerCard5;
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
            if (playerHand.GetTotal() > dealerHand.GetTotal())
            {
                if (dealerHand.GetTotal() > 21)
                {
                    if (checkBlackJack())
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
                    if (checkBlackJack())
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
                    if (checkBlackJack())
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
                MessageBox.Show("Dealer's Hand:" + dealerHand.GetTotalString() + "\nPlayer's Hand:" + playerHand.GetTotalString() + "\n\nTie. Nothing happens.");
            }
            DisableCardButtons();
        }

        private bool checkBlackJack()
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
                    DealerButtonList[i].Visible = false;
                }
                DealerButtonList[0].BackgroundImage = dealerHand.GetCard(0).GetImage();
                DealerButtonList[0].Visible = true;
                DealerButtonList[1].BackgroundImage = BackOfCard;
                DealerButtonList[1].Visible = true;
                DealerTotalLabel.Text = dealerHand.GetCard(0).GetValueString();
            }
            else
            {
                for (int i = 0; i < dealerHand.GetNumberofCards(); i++)
                {
                    Card acard = dealerHand.GetCard(i);
                    DealerButtonList[i].BackgroundImage = acard.GetImage();
                    DealerButtonList[i].Visible = true;
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
                    PlayerButtonList[i].Visible = false;
                    PlayerTotalLabel.Text = "";
                }
                for (int i = 0; i < playerHand.GetNumberofCards(); i++)
                {
                    Card acard = playerHand.GetCard(i);
                    {
                        PlayerButtonList[i].BackgroundImage = acard.GetImage();
                        PlayerButtonList[i].Visible = true;
                        PlayerTotalLabel.Text = playerHand.GetTotalString();
                    }
                }
            }
            else
            {
                for (int i = 0; i < playerHand.GetNumberofCards(); i++)
                {
                    Card acard = playerHand.GetCard(i);
                    PlayerButtonList[i].BackgroundImage = acard.GetImage();
                    PlayerButtonList[i].Visible = true;
                    PlayerTotalLabel.Text = playerHand.GetTotalString();
                }
            }
            BankrollAmountBox.Text = playerFunds.GetTotalFundsString();
        }
        private void CurrentBetBox_TextChanged(object sender, EventArgs e)
        {
            if (CurrentBetBox.Text.Equals(null))
            {
                playerFunds.SetBetAmount(100);
            }
            else
            {
                playerFunds.SetBetAmount(int.Parse(CurrentBetBox.Text));
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
     
    }
}
