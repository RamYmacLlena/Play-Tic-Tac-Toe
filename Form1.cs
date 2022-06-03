namespace Play_Tic_Tac_Toe_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Count = 1;

        private void AllButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = (Count % 2 == 0) ? "0" : "X";
            b.Enabled = false;
            if (b.Text == "X")
            {
                PLAYER1lbl.ForeColor = System.Drawing.Color.Red;
                PLAYER2lbl.ForeColor = System.Drawing.Color.DarkGreen;
            } else
            {
                PLAYER2lbl.ForeColor = System.Drawing.Color.Red;
                PLAYER1lbl.ForeColor = System.Drawing.Color.DarkGreen;
            }
            check();
            Count++;
        }
        public void check()
        {
            bool Tie = true;
            //start here for player 2 winning conditions
            if (SLOT1_TOPLEFT.Text == "0" && SLOT2_TOPMIDDLE.Text == "0" && SLOT3_TOPRIGHT.Text == "0")
            {
                Tie = false;
                MessageBox.Show("Player 2 won the game!");
                Winner("Player 2 won the game!");
            }
            if (SLOT1_TOPLEFT.Text == "0" && SLOT4_MIDDLELEFT.Text == "0" && SLOT7_BOTTOMLEFT.Text == "0")
            {
                Tie = false;
                MessageBox.Show("Player 2 won the game!");
                Winner("Player 2 won the game!");
            }
            if (SLOT1_TOPLEFT.Text == "0" && SLOT5_CENTER.Text == "0" && SLOT9_BOTTOMRIGHT.Text == "0")
            {
                Tie = false;
                MessageBox.Show("Player 2 won the game!");
                Winner("Player 2 won the game!");
            }
            if (SLOT2_TOPMIDDLE.Text == "0" && SLOT5_CENTER.Text == "0" && SLOT8_BOTTOMMIDDLE.Text == "0")
            {
                Tie = false;
                MessageBox.Show("Player 2 won the game!");
                Winner("Player 2 won the game!");
            }
            if (SLOT3_TOPRIGHT.Text == "0" && SLOT6_MIDDLERIGHT.Text == "0" && SLOT9_BOTTOMRIGHT.Text == "0")
            {
                Tie = false;
                MessageBox.Show("Player 2 won the game!");
                Winner("Player 2 won the game!");
            }
            if (SLOT4_MIDDLELEFT.Text == "0" && SLOT5_CENTER.Text == "0" && SLOT6_MIDDLERIGHT.Text == "0")
            {
                Tie = false;
                MessageBox.Show("Player 2 won the game!");
                Winner("Player 2 won the game!");
            }
            if (SLOT7_BOTTOMLEFT.Text == "0" && SLOT8_BOTTOMMIDDLE.Text == "0" && SLOT9_BOTTOMRIGHT.Text == "0")
            {
                Tie = false;
                MessageBox.Show("Player 2 won the game!");
                Winner("Player 2 won the game!");
            }
            if (SLOT3_TOPRIGHT.Text == "0" && SLOT5_CENTER.Text == "0" && SLOT7_BOTTOMLEFT.Text == "0")
            {
                Tie = false;
                MessageBox.Show("Player 2 won the game!");
                Winner("Player 2 won the game!");
            }
            //start her for player 1 winning conditions
            if (SLOT1_TOPLEFT.Text == "X" && SLOT2_TOPMIDDLE.Text == "X" && SLOT3_TOPRIGHT.Text == "X")
            {
                Tie = false;
                MessageBox.Show("Player 1 won the game!");
                Winner("Player 1 won the game!");
            }
            if (SLOT1_TOPLEFT.Text == "X" && SLOT4_MIDDLELEFT.Text == "X" && SLOT7_BOTTOMLEFT.Text == "X")
            {
                Tie = false;
                MessageBox.Show("Player 1 won the game!");
                Winner("Player 1 won the game!");
            }
            if (SLOT1_TOPLEFT.Text == "X" && SLOT5_CENTER.Text == "X" && SLOT9_BOTTOMRIGHT.Text == "X")
            {
                Tie = false;
                MessageBox.Show("Player 1 won the game!");
                Winner("Player 1 won the game!");
            }
            if (SLOT2_TOPMIDDLE.Text == "X" && SLOT5_CENTER.Text == "X" && SLOT8_BOTTOMMIDDLE.Text == "X")
            {
                Tie = false;
                MessageBox.Show("Player 1 won the game!");
                Winner("Player 1 won the game!");
            }
            if (SLOT3_TOPRIGHT.Text == "X" && SLOT6_MIDDLERIGHT.Text == "X" && SLOT9_BOTTOMRIGHT.Text == "X")
            {
                Tie = false;
                MessageBox.Show("Player 1 won the game!");
                Winner("Player 1 won the game!");
            }
            if (SLOT4_MIDDLELEFT.Text == "X" && SLOT5_CENTER.Text == "X" && SLOT6_MIDDLERIGHT.Text == "X")
            {
                Tie = false;
                MessageBox.Show("Player 1 won the game!");
                Winner("Player 1 won the game!");
            }
            if (SLOT7_BOTTOMLEFT.Text == "X" && SLOT8_BOTTOMMIDDLE.Text == "X" && SLOT9_BOTTOMRIGHT.Text == "X")
            {
                Tie = false;
                MessageBox.Show("Player 1 won the game!");
                Winner("Player 1 won the game!");
            }
            if (SLOT3_TOPRIGHT.Text == "X" && SLOT5_CENTER.Text == "X" && SLOT7_BOTTOMLEFT.Text == "X")
            {
                Tie = false;
                MessageBox.Show("Player 1 won the game!");
                Winner("Player 1 won the game!");
            }

            else if (Count == 9 && Tie == true)
            {
                MessageBox.Show("THE GAME HAS ENDED IN A DRAW!");
            }
            if (Tie == true && Count == 9)
            {
                string message = "DO YOU WANT TO PLAY AGAIN?";
                string title = "THE GAME HAS ENDED IN A DRAW!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    reset();
                }
                else
                {
                    this.Close();
                    //else condition for when there is no winner
                    //else if (Count == 9)
                    {
                        // MessageBox.Show("Draw!");
                    }
                }
            }
            void reset()
            {
                foreach (Control b in this.Controls)
                {
                    if (b.GetType() == typeof(Button))
                    {
                        if (b.Text != "RESET")
                        {
                            b.Text = "";
                            b.Enabled = true;
                        }

                    }
                }
                Count = 0;
            }


        }
        void Winner(string text)
        {
            if (text == "Player 1 won the game!")
            {
                MessageBox.Show("Congratulations Player 1!");
                int score = 1;
                int txtbxscore = int.Parse(txtbxPlayer1.Text);
                int totalScore = score + txtbxscore;
                txtbxPlayer1.Text = totalScore.ToString();
            }
            else if (text == "Player 2 won the game!")
            {
                MessageBox.Show("Congratulations Player 2!");
                int score = 1;
                int txtbxscore = int.Parse(txtbxPlayer2.Text);
                int totalScore = score + txtbxscore;
                txtbxPlayer2.Text = totalScore.ToString();
            }
            string message = "DO YOU WANT TO PLAY AGAIN?";
            string title = "THE GAME HAS ENDED!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                    reset();
                
            }
            else
            {
                this.Close();
                //else condition for when there is no winner
                //else if (Count == 9)
                {
                    // MessageBox.Show("Draw!");
                }
            }
            void reset()
            {
                foreach (Control b in this.Controls)
                {
                    if (b.GetType() == typeof(Button))
                    {
                        if (b.Text != "RESET")
                        {
                            b.Text = "";
                            b.Enabled = true;
                        }

                    }
                }
                Count = 0;
            }
        }

        private void RESETbtn_Click(object sender, EventArgs e)
        {
            foreach (Control b in this.Controls)
            {
                if (b.GetType() == typeof(Button))
                {
                    if (b.Text != "RESET")
                    {
                        b.Text = "";
                        b.Enabled = true;
                    }

                }
            }
            Count = 1;
            txtbxPlayer2.Text = "0";
            txtbxPlayer1.Text = "0";
        }
    }
}