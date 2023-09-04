using BettingParlor.Classes;

namespace BettingParlor
{
    public partial class Form1 : Form
    {
        Greyhound[] greyhound = new Greyhound[4];//Array of dogs
        Guy[] guy = new Guy[3];//Array of guys
        Random randomizer = new Random();
        public Form1()
        {
            InitializeComponent();
            greyhound[0] = new Greyhound()
            {
                MyPictureBox = dog1,
                StartingPosition = RaceTrackPictureBox.Left,
                RaceTrackLength = RaceTrackPictureBox.Width - dog1.Width,
                MyRandom = randomizer
            };
            greyhound[1] = new Greyhound()
            {
                MyPictureBox = dog2,
                StartingPosition = RaceTrackPictureBox.Left,
                RaceTrackLength = RaceTrackPictureBox.Width - dog2.Width,
                MyRandom = randomizer
            };
            greyhound[2] = new Greyhound()
            {
                MyPictureBox = dog3,
                StartingPosition = RaceTrackPictureBox.Left,
                RaceTrackLength = RaceTrackPictureBox.Width - dog3.Width,
                MyRandom = randomizer
            };
            greyhound[3] = new Greyhound()
            {
                MyPictureBox = dog4,
                StartingPosition = RaceTrackPictureBox.Left,
                RaceTrackLength = RaceTrackPictureBox.Width - dog4.Width,
                MyRandom = randomizer
            };

            guy[0] = new Guy() { Name = "Joe", Cash = 50, MyRadioButton = radioButtonJoe, MyLabel = JoeBet };
            guy[1] = new Guy() { Name = "Bob", Cash = 75, MyRadioButton = radioButtonBob, MyLabel = BobBet };
            guy[2] = new Guy() { Name = "Al", Cash = 45, MyRadioButton = radioButtonAl, MyLabel = AlBet };

            lblMinimumBet.Text = "Minimun Bet:" + numericUpDownBet.Minimum + "bucks.";
            refreshGuyState();
        }

        public void refreshGuyState()
        {
            for (int i = 0; i < guy.Length; i++)
            {
                guy[i].ClearBet();
            }
        }

        private void radioButtonJoe_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = guy[0].Name;
        }

        private void radioButtonBob_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = guy[1].Name;
        }

        private void radioButtonAl_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = guy[2].Name;
        }

        private void buttonBets_Click(object sender, EventArgs e)
        {

            if (radioButtonJoe.Checked)
            {
                guy[0].PlaceBet((int)numericUpDownBet.Value, (int)numericUpDownBucks.Value);
            }
            if (radioButtonBob.Checked)
            {
                guy[1].PlaceBet((int)numericUpDownBet.Value, (int)numericUpDownBucks.Value);
            }
            if (radioButtonAl.Checked)
            {
                guy[2].PlaceBet((int)numericUpDownBet.Value, (int)numericUpDownBucks.Value);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int winningDog = 0;
            for (int i = 0; i < greyhound.Length; i++)
            {
                if (greyhound[i].Run())
                {
                    //we have winner
                    timer1.Stop();
                    winningDog = i++;
                    MessageBox.Show("Dog #" + winningDog + " won the race! ");

                    for (int boy = 0; boy < guy.Length; boy++)
                    {
                        guy[boy].Collect(winningDog);
                    }
                    refreshGuyState();
                    BettingParlorGroup.Enabled = true;
                    break;
                }
            }
        }

        private void buttonRace_Click(object sender, EventArgs e)
        {
            for (int dog = 0; dog < greyhound.Length; dog++)
            {

                greyhound[dog].TakeStartingPosition();
            }
            BettingParlorGroup.Enabled = false;
            timer1.Start();
        }
    }
}