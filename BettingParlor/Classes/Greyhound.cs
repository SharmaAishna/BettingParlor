using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingParlor.Classes
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RaceTrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random MyRandom;

        public bool Run()
        {
            Location += MyRandom.Next(4);
            MyPictureBox.Left = StartingPosition + Location;
            MyPictureBox.Refresh();

            if(MyPictureBox.Left >= RaceTrackLength-MyPictureBox.Width+20)
                return true;
            else
                return false;
        }

        public void TakeStartingPosition()
        {
           Location = 0 ;
            MyPictureBox.Left = StartingPosition;
        }
    }
}
