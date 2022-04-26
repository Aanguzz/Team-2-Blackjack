using System;
using System.Collections.Generic;
using System.Text;

namespace CSC478Blackjack
{
    class Funds
    {
        int totalFunds;
        int betAmount = 100;

        public Funds(int initialfunds)
        {
            totalFunds = initialfunds;
        }
        public void SetBetAmount(int bet)
        {
            betAmount = bet;
        }
        public int GetBetAmount()
        {
            return betAmount;
        }
        public void WonBet()
        {
            totalFunds = totalFunds + betAmount;
        }
        public void BlackJackWin()
        {
            totalFunds = totalFunds + (betAmount * 3);
        }
        public void LostBet()
        {
            totalFunds = totalFunds - betAmount;
        }
        public int GetTotalFunds()
        {
            return totalFunds;
        }
        public string GetTotalFundsString()
        {
            return "$" + Convert.ToString(totalFunds);
        }
    }
}
