namespace Tic_Tac_Toe
{
    public partial class TicTacToe : Form
    {
        public PlayerTurn turn = PlayerTurn.X;
        public enum PlayerTurn
        { X, O };
        public int turnCount = 0;
        public TicTacToe()
        {
            InitializeComponent();
            NewGameButton.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonClicked(object? sender, EventArgs e)
        {
            Button? clicked = sender as Button;

            if(turn == PlayerTurn.X)
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                clicked.Text = "X";
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                clicked.Click -= ButtonClicked;

                if(CheckForWinner() == "X")
                {
                    WinGame(CheckForWinner());
                }
                else if(CheckForWinner() == "")
                turn = PlayerTurn.O;
            }
            else if(turn == PlayerTurn.O)
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                clicked.Text = "O";
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                clicked.Click -= ButtonClicked;

                if (CheckForWinner() == "O")
                {
                    WinGame(CheckForWinner());
                }
                else if(CheckForWinner() == "")
                    turn = PlayerTurn.X;
            }

            CheckForWinner();
            turnCount++;

            if (turnCount == 9)
                EndGame();
        }
        private string CheckForWinner()
        {
            //bool winner = false;

            //left to right
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (A2.Text != ""))
                return A1.Text;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (B2.Text != ""))
                return B1.Text;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (C2.Text != ""))
                return C1.Text;

            //top to bottom
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (B1.Text != ""))
                return A1.Text;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (B2.Text != ""))
                return A2.Text;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (B3.Text != ""))
                return A3.Text;

            //diagonals
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (B2.Text != ""))
                return A1.Text;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (B2.Text != ""))
                return A3.Text;

            //return nothing if there is no winner;
            else return "";
        }
        private void WinGame(string w)
        {
            string winner = w;

            WinnerLabel.Text = w + " Wins!";

            NewGameButton.Show();
        }
        private void EndGame()
        {
            WinnerLabel.Text = "Draw!";
            NewGameButton.Show();
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            foreach(Control c in Controls)
            {
                if(c is Button)
                {
                    if (c == NewGameButton)
                    {

                    }
                    else
                    {
                        c.Text = "";
                        c.Click += ButtonClicked;
                    }
                }
            }

            turn = PlayerTurn.X;

            WinnerLabel.Text = "";
            NewGameButton.Hide();
        }
    }
}