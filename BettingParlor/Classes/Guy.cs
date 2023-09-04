using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingParlor.Classes
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;
        //public Guy(string name, int cash)
        //{
        //    this.Name = name;
        //    this.Cash = cash;
        //    UpdateLabel(); 
        //}
        public void UpdateLabel()
        {
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = Name + " has " + Cash + " bucks. ";
        }
        public void ClearBet()
        {
            PlaceBet(0, 0);
        }
        public bool PlaceBet(int BettingAmount, int DogToWin)
        {
            if (BettingAmount <= Cash)
            {
                MyBet = new() { Amount = BettingAmount, Dog = DogToWin, Bettor = this };
                UpdateLabel();
                return true;
            }
            else if(BettingAmount == 0)
            {
                MyBet = new() { Amount = BettingAmount, Dog = DogToWin, Bettor = this };
                UpdateLabel();
                MessageBox.Show("Sorry" + this + " you don't have enough money " + BettingAmount + "to bet  further.");
                return false;
            }
            else
            {
                return false;
            }
            
        }

        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            UpdateLabel();
        }
    }
}
