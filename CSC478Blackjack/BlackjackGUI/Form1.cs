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
        bool acestoggle = false;


        public Form1()
        {
            InitializeComponent();
            BackOfCard = Image.FromFile("Cards/BackOfCard.png");
            LoadLists();
        }

        private void HitButton_Click(object sender, EventArgs e)
        {

        }
        private void StayButton_Click(object sender, EventArgs e)
        {

        }
        private void StartGame_Click(object sender, EventArgs e)
        {
            if (playerFunds.GetBetAmount() > playerFunds.GetTotalFunds())
            {
                CurrentBetBox.Text = playerFunds.GetTotalFundsString();
            }
            BankrollAmountBox.Text = playerFunds.GetTotalFundsString();
            CurrentBetBox.Text = "0";
            HitButton.Enabled = true;
            StayButton.Enabled = true;
            playerHand.ResetHand();
            dealerHand.ResetHand();
            EnableCardButtons();
            CurrentBetBox.Enabled = false;
            firstHand = true;
            

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
                DisplayDealerGraphics();
                MessageBox.Show("Tie. Nothing happens.");
            }
            else if (playerHand.GetTotal() == 21)
            {
                playerFunds.WonBet();
                DisplayDealerGraphics();
                DisplayPlayerGraphics();
                MessageBox.Show("Blackjack!! You win!!!");
            }
            else if (dealerHand.GetTotal() == 21)
            {
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
            //PlayerLabelList[0] = playerCardValue1;
            //PlayerLabelList[1] = playerCardValue2;
            //PlayerLabelList[2] = playerCardValue3;
            //PlayerLabelList[3] = playerCardValue4;
            //PlayerLabelList[4] = playerCardValue5;
            //DealerLabelList[0] = dealerCardValue1;
            //DealerLabelList[1] = dealerCardValue2;
            //DealerLabelList[2] = dealerCardValue3;
            //DealerLabelList[3] = dealerCardValue4;
            //DealerLabelList[4] = dealerCardValue5;
        }

        private void CheckBankrupt()
        {
            if (playerFunds.GetTotalFunds() <= 0)
            {
                MessageBox.Show("You ran out of money. Game over!");
                Application.Exit();
            }
        }
       

        private void DiableCardButtons()
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
                //dealerTotal.Text = DealerHand.GetCard(0).GetValueString();
            }
            else
            {
                for (int i = 0; i < dealerHand.GetNumberofCards(); i++)
                {
                    Card acard = dealerHand.GetCard(i);
                    DealerButtonList[i].BackgroundImage = acard.GetImage();
                    DealerButtonList[i].Visible = true;
                    //dealerTotal.Text = dealerHand.GetTotalString();
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
                    //playerTotal.Text = "";
                }
                for (int i = 0; i < playerHand.GetNumberofCards(); i++)
                {
                    Card acard = playerHand.GetCard(i);
                    {
                        PlayerButtonList[i].BackgroundImage = acard.GetImage();
                        PlayerButtonList[i].Visible = true;
                        //playerTotal.Text = PlayerHand.GetTotalString();
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
                    //playerTotal.Text = PlayerHand.GetTotalString();
                }
            }
            BankrollAmountBox.Text = playerFunds.GetTotalFundsString();
        }
        private void BankrollAmountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HitButton.Enabled = false;
            StayButton.Enabled = false;
        }
        private void BetAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
