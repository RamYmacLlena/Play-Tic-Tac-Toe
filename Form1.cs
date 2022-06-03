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
            b.Text = (Count % 2 == 0) ? "X" : "0";
            b.Enabled = false;
            check();
            Count++;
        }
        public void check()
        {
            //start here for player 1 winning conditions
            if (SLOT1_TOPLEFT.Text == "0" && SLOT2_TOPMIDDLE.Text == "0" && SLOT3_TOPRIGHT.Text == "0")
            {
                MessageBox.Show("Player 1 won the game!");
            }
            if (SLOT1_TOPLEFT.Text == "0" && SLOT4_MIDDLELEFT.Text == "0" && SLOT7_BOTTOMLEFT.Text == "0")
            {
                MessageBox.Show("Player 1 won the game!");
            }
            if (SLOT1_TOPLEFT.Text == "0" && SLOT5_CENTER.Text == "0" && SLOT9_BOTTOMRIGHT.Text == "0")
            {
                MessageBox.Show("Player 1 won the game!");
            }
            if (SLOT2_TOPMIDDLE.Text == "0" && SLOT5_CENTER.Text == "0" && SLOT8_BOTTOMMIDDLE.Text == "0")
            {
                MessageBox.Show("Player 1 won the game!");
            }
            if (SLOT3_TOPRIGHT.Text == "0" && SLOT6_MIDDLERIGHT.Text == "0" && SLOT9_BOTTOMRIGHT.Text == "0")
            {
                MessageBox.Show("Player 1 won the game!");
            }
            if (SLOT4_MIDDLELEFT.Text == "0" && SLOT5_CENTER.Text == "0" && SLOT6_MIDDLERIGHT.Text == "0")
            {
                MessageBox.Show("Player 1 won the game!");
            }
            if (SLOT7_BOTTOMLEFT.Text == "0" && SLOT8_BOTTOMMIDDLE.Text == "0" && SLOT9_BOTTOMRIGHT.Text == "0")
            {
                MessageBox.Show("Player 1 won the game!");
            }
            if (SLOT3_TOPRIGHT.Text == "0" && SLOT5_CENTER.Text == "0" && SLOT7_BOTTOMLEFT.Text == "0")
            {
                MessageBox.Show("Player 1 won the game!");
            }
            //start her for player 2 winning conditions
            if (SLOT1_TOPLEFT.Text == "X" && SLOT2_TOPMIDDLE.Text == "X" && SLOT3_TOPRIGHT.Text == "X")
            {
                MessageBox.Show("Player 2 won the game!");
            }
            if (SLOT1_TOPLEFT.Text == "X" && SLOT4_MIDDLELEFT.Text == "X" && SLOT7_BOTTOMLEFT.Text == "X")
            {
                MessageBox.Show("Player 2 won the game!");
            }
            if (SLOT1_TOPLEFT.Text == "X" && SLOT5_CENTER.Text == "X" && SLOT9_BOTTOMRIGHT.Text == "X")
            {
                MessageBox.Show("Player 2 won the game!");
            }
            if (SLOT2_TOPMIDDLE.Text == "X" && SLOT5_CENTER.Text == "X" && SLOT8_BOTTOMMIDDLE.Text == "X")
            {
                MessageBox.Show("Player 2 won the game!");
            }
            if (SLOT3_TOPRIGHT.Text == "X" && SLOT6_MIDDLERIGHT.Text == "X" && SLOT9_BOTTOMRIGHT.Text == "X")
            {
                MessageBox.Show("Player 2 won the game!");
            }
            if (SLOT4_MIDDLELEFT.Text == "X" && SLOT5_CENTER.Text == "X" && SLOT6_MIDDLERIGHT.Text == "X")
            {
                MessageBox.Show("Player 2 won the game!");
            }
            if (SLOT7_BOTTOMLEFT.Text == "X" && SLOT8_BOTTOMMIDDLE.Text == "X" && SLOT9_BOTTOMRIGHT.Text == "X")
            {
                MessageBox.Show("Player 2 won the game!");
            }
            if (SLOT3_TOPRIGHT.Text == "X" && SLOT5_CENTER.Text == "X" && SLOT7_BOTTOMLEFT.Text == "X")
            {
                MessageBox.Show("Player 2 won the game!");
            }
            //else condition for when there is no winner
            if (Count == 9)
            {
                MessageBox.Show("Draw");
            }
        }
    }
}