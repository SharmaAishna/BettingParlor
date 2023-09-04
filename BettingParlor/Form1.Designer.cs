namespace BettingParlor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            BettingParlorGroup = new GroupBox();
            numericUpDownBucks = new NumericUpDown();
            labelBucksOnDog = new Label();
            numericUpDownBet = new NumericUpDown();
            label1 = new Label();
            buttonBets = new Button();
            buttonRace = new Button();
            AlBet = new Label();
            BobBet = new Label();
            JoeBet = new Label();
            labelBets = new Label();
            radioButtonAl = new RadioButton();
            radioButtonBob = new RadioButton();
            radioButtonJoe = new RadioButton();
            lblMinimumBet = new Label();
            RaceTrackPictureBox = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            dog1 = new PictureBox();
            dog2 = new PictureBox();
            dog3 = new PictureBox();
            dog4 = new PictureBox();
            pictureBox1 = new PictureBox();
            BettingParlorGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBucks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RaceTrackPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dog1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dog2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dog3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dog4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BettingParlorGroup
            // 
            BettingParlorGroup.Controls.Add(numericUpDownBucks);
            BettingParlorGroup.Controls.Add(labelBucksOnDog);
            BettingParlorGroup.Controls.Add(numericUpDownBet);
            BettingParlorGroup.Controls.Add(label1);
            BettingParlorGroup.Controls.Add(buttonBets);
            BettingParlorGroup.Controls.Add(buttonRace);
            BettingParlorGroup.Controls.Add(AlBet);
            BettingParlorGroup.Controls.Add(BobBet);
            BettingParlorGroup.Controls.Add(JoeBet);
            BettingParlorGroup.Controls.Add(labelBets);
            BettingParlorGroup.Controls.Add(radioButtonAl);
            BettingParlorGroup.Controls.Add(radioButtonBob);
            BettingParlorGroup.Controls.Add(radioButtonJoe);
            BettingParlorGroup.Controls.Add(lblMinimumBet);
            BettingParlorGroup.Location = new Point(12, 289);
            BettingParlorGroup.Name = "BettingParlorGroup";
            BettingParlorGroup.Size = new Size(917, 243);
            BettingParlorGroup.TabIndex = 0;
            BettingParlorGroup.TabStop = false;
            BettingParlorGroup.Text = "Betting Parlor";
            // 
            // numericUpDownBucks
            // 
            numericUpDownBucks.Location = new Point(551, 200);
            numericUpDownBucks.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownBucks.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownBucks.Name = "numericUpDownBucks";
            numericUpDownBucks.Size = new Size(150, 27);
            numericUpDownBucks.TabIndex = 13;
            numericUpDownBucks.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelBucksOnDog
            // 
            labelBucksOnDog.AutoSize = true;
            labelBucksOnDog.Location = new Point(392, 207);
            labelBucksOnDog.Name = "labelBucksOnDog";
            labelBucksOnDog.Size = new Size(153, 20);
            labelBucksOnDog.TabIndex = 12;
            labelBucksOnDog.Text = "bucks on dog number";
            // 
            // numericUpDownBet
            // 
            numericUpDownBet.Location = new Point(221, 200);
            numericUpDownBet.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownBet.Name = "numericUpDownBet";
            numericUpDownBet.Size = new Size(150, 27);
            numericUpDownBet.TabIndex = 11;
            numericUpDownBet.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 205);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 10;
            label1.Text = "name";
            // 
            // buttonBets
            // 
            buttonBets.Location = new Point(104, 194);
            buttonBets.Name = "buttonBets";
            buttonBets.Size = new Size(94, 37);
            buttonBets.TabIndex = 9;
            buttonBets.Text = "Bets";
            buttonBets.UseVisualStyleBackColor = true;
            buttonBets.Click += buttonBets_Click;
            // 
            // buttonRace
            // 
            buttonRace.FlatStyle = FlatStyle.System;
            buttonRace.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRace.Location = new Point(728, 194);
            buttonRace.Name = "buttonRace";
            buttonRace.Size = new Size(123, 37);
            buttonRace.TabIndex = 8;
            buttonRace.Text = "Race!";
            buttonRace.UseVisualStyleBackColor = true;
            buttonRace.Click += buttonRace_Click;
            // 
            // AlBet
            // 
            AlBet.BorderStyle = BorderStyle.FixedSingle;
            AlBet.Location = new Point(519, 162);
            AlBet.Name = "AlBet";
            AlBet.Size = new Size(332, 25);
            AlBet.TabIndex = 7;
            AlBet.Text = "Al's bet";
            // 
            // BobBet
            // 
            BobBet.BorderStyle = BorderStyle.FixedSingle;
            BobBet.Location = new Point(519, 126);
            BobBet.Name = "BobBet";
            BobBet.Size = new Size(332, 25);
            BobBet.TabIndex = 6;
            BobBet.Text = "Bob's bet";
            // 
            // JoeBet
            // 
            JoeBet.BorderStyle = BorderStyle.FixedSingle;
            JoeBet.Location = new Point(519, 87);
            JoeBet.Name = "JoeBet";
            JoeBet.Size = new Size(332, 25);
            JoeBet.TabIndex = 5;
            JoeBet.Text = "Joe's bet";
            // 
            // labelBets
            // 
            labelBets.AutoSize = true;
            labelBets.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBets.Location = new Point(519, 31);
            labelBets.Name = "labelBets";
            labelBets.Size = new Size(53, 28);
            labelBets.TabIndex = 4;
            labelBets.Text = "Bets";
            // 
            // radioButtonAl
            // 
            radioButtonAl.AutoSize = true;
            radioButtonAl.Location = new Point(18, 161);
            radioButtonAl.Name = "radioButtonAl";
            radioButtonAl.Size = new Size(44, 24);
            radioButtonAl.TabIndex = 3;
            radioButtonAl.TabStop = true;
            radioButtonAl.Text = "Al";
            radioButtonAl.UseVisualStyleBackColor = true;
            radioButtonAl.CheckedChanged += radioButtonAl_CheckedChanged;
            // 
            // radioButtonBob
            // 
            radioButtonBob.AutoSize = true;
            radioButtonBob.Location = new Point(18, 125);
            radioButtonBob.Name = "radioButtonBob";
            radioButtonBob.Size = new Size(57, 24);
            radioButtonBob.TabIndex = 2;
            radioButtonBob.TabStop = true;
            radioButtonBob.Text = "Bob";
            radioButtonBob.UseVisualStyleBackColor = true;
            radioButtonBob.CheckedChanged += radioButtonBob_CheckedChanged;
            // 
            // radioButtonJoe
            // 
            radioButtonJoe.AutoSize = true;
            radioButtonJoe.Location = new Point(18, 86);
            radioButtonJoe.Name = "radioButtonJoe";
            radioButtonJoe.Size = new Size(52, 24);
            radioButtonJoe.TabIndex = 1;
            radioButtonJoe.TabStop = true;
            radioButtonJoe.Text = "Joe";
            radioButtonJoe.UseVisualStyleBackColor = true;
            radioButtonJoe.CheckedChanged += radioButtonJoe_CheckedChanged;
            // 
            // lblMinimumBet
            // 
            lblMinimumBet.AutoSize = true;
            lblMinimumBet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMinimumBet.Location = new Point(12, 31);
            lblMinimumBet.Name = "lblMinimumBet";
            lblMinimumBet.Size = new Size(140, 28);
            lblMinimumBet.TabIndex = 0;
            lblMinimumBet.Text = "Minimum bet";
            // 
            // RaceTrackPictureBox
            // 
            RaceTrackPictureBox.BackColor = SystemColors.ControlLightLight;
            RaceTrackPictureBox.Location = new Point(12, 12);
            RaceTrackPictureBox.Name = "RaceTrackPictureBox";
            RaceTrackPictureBox.Size = new Size(917, 279);
            RaceTrackPictureBox.TabIndex = 1;
            RaceTrackPictureBox.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // dog1
            // 
            dog1.Image = Properties.Resources.DogImage1;
            dog1.Location = new Point(12, 12);
            dog1.Name = "dog1";
            dog1.Size = new Size(125, 66);
            dog1.SizeMode = PictureBoxSizeMode.StretchImage;
            dog1.TabIndex = 2;
            dog1.TabStop = false;
            // 
            // dog2
            // 
            dog2.Image = Properties.Resources.DogImage2;
            dog2.Location = new Point(12, 84);
            dog2.Name = "dog2";
            dog2.Size = new Size(125, 62);
            dog2.SizeMode = PictureBoxSizeMode.StretchImage;
            dog2.TabIndex = 14;
            dog2.TabStop = false;
            // 
            // dog3
            // 
            dog3.Image = Properties.Resources.DogImage3;
            dog3.Location = new Point(12, 152);
            dog3.Name = "dog3";
            dog3.Size = new Size(125, 62);
            dog3.SizeMode = PictureBoxSizeMode.StretchImage;
            dog3.TabIndex = 15;
            dog3.TabStop = false;
            // 
            // dog4
            // 
            dog4.Image = Properties.Resources.DogImage4;
            dog4.Location = new Point(12, 221);
            dog4.Name = "dog4";
            dog4.Size = new Size(125, 62);
            dog4.SizeMode = PictureBoxSizeMode.StretchImage;
            dog4.TabIndex = 16;
            dog4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FinishLine;
            pictureBox1.Location = new Point(810, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 275);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 540);
            Controls.Add(pictureBox1);
            Controls.Add(dog4);
            Controls.Add(dog3);
            Controls.Add(dog2);
            Controls.Add(dog1);
            Controls.Add(RaceTrackPictureBox);
            Controls.Add(BettingParlorGroup);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "A Day at the Races";
            BettingParlorGroup.ResumeLayout(false);
            BettingParlorGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBucks).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBet).EndInit();
            ((System.ComponentModel.ISupportInitialize)RaceTrackPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dog1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dog2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dog3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dog4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox BettingParlorGroup;
        private PictureBox RaceTrackPictureBox;
        private Label lblMinimumBet;
        private RadioButton radioButtonAl;
        private RadioButton radioButtonBob;
        private RadioButton radioButtonJoe;
        private Label AlBet;
        private Label BobBet;
        private Label JoeBet;
        private Label labelBets;
        private Label label1;
        private Button buttonBets;
        private Button buttonRace;
        private NumericUpDown numericUpDownBucks;
        private Label labelBucksOnDog;
        private NumericUpDown numericUpDownBet;
        private System.Windows.Forms.Timer timer1;
        private PictureBox dog1;
        private PictureBox dog2;
        private PictureBox dog3;
        private PictureBox dog4;
        private PictureBox pictureBox1;
    }
}