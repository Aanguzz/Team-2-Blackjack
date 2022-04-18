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

        public Form1()
        {
            InitializeComponent();
        }

        private void HitButton_Click(object sender, EventArgs e)
        {
            
        }
        private void StayButton_Click(object sender, EventArgs e)
        {

        }
        private void StartGame_Click(object sender, EventArgs e)
        {
            BankrollAmountBox.Text = playerFunds.GetTotalFundsString();
            CurrentBetBox.Text = "0";
            HitButton.Enabled = true;
            StayButton.Enabled = true;

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
