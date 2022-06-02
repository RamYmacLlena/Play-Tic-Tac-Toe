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
            if (SLOT1_TOPLEFT.Text == "0" && SLOT2_TOPMIDDLE.Text == "0" && SLOT3_TOPRIGHT.Text == "0")
            {
                MessageBox.Show("Player 1 won the game");
            }
        }
    }
}