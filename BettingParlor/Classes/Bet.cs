using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingParlor.Classes
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;
        // Guy Bettor {

        //    get
        //    {
        //        return bettor;
        //    }
        //    set
        //    {
        //        bettor = value;
        //    }
        //}

        //public Bet(Guy bettor)
        //{
        //    this.bettor = bettor;
        //}
        /// <summary>
        /// Bettor Get Description
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            if(Amount>0)
            return Bettor.Name + " bets " + Amount + " bucks on " + Dog;

            return Bettor.Name + " hasn't places a bet.";
        }

        /// <summary>
        /// According to Win or loss updating the Amount
        /// </summary>
        /// <param name="Winner"></param>
        /// <returns></returns>
        public int PayOut(int Winner)
        {
            if (Winner == Dog)
               return Amount;

            else
            {
                return -Amount;
            }

        }
    }
}
