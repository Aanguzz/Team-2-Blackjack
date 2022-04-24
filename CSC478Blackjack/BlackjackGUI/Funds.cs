using System;
using System.Collections.Generic;
using System.Text;

namespace CSC478Blackjack
{
    class Funds
    {
        int totalfunds;
        int betamount = 100;

        public Funds(int initialfunds)
        {
            totalfunds = initialfunds;
        }
        public void SetBetAmount(int bet)
        {
            betamount = bet;
        }
        public int GetBetAmount()
        {
            return betamount;
        }
        public void WonBet()
        {
            totalfunds = totalfunds + betamount;
        }
        public void BlackJackWin()
        {
            totalfunds = totalfunds + (betamount * 3);
        }
        public void LostBet()
        {
            totalfunds = totalfunds - betamount;
        }
        public int GetTotalFunds()
        {
            return totalfunds;
        }
        public string GetTotalFundsString()
        {
            return "$" + Convert.ToString(totalfunds);
        }
    }
}
