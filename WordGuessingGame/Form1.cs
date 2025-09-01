namespace WordGuessingGame
{
    public partial class Form1 : Form
    {
        private GameFunctions functions;
        public Form1()
        {
            InitializeComponent();
            functions = new GameFunctions();
            GameFunctions.Obfuscator();
            WordToGuess.Text = GameFunctions.ObfuscatedBank[functions.CurrentIndex];
            Score.Text = $"Score:";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (functions.CheckGuess(GuessField.Text.Trim()))
            {
                GuessField.Clear();
                if (functions.IsGameOver)
                {
                    MessageBox.Show("Congratulations! You've guessed all the words!",
                        "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else
                {
                    WordToGuess.Text = GameFunctions.ObfuscatedBank[functions.CurrentIndex];
                    Score.Text = $"Score: {functions.CurrentIndex}";
                }
            }
            else
            {
                Guesses.Items.Add(GuessField.Text.Trim());
                GuessField.Clear();
            }
        }

        private void Hint_Click(object sender, EventArgs e)
        {
            functions.GetHint();
        }
    }
}
