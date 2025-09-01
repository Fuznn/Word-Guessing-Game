namespace WordGuessingGame
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
            WordToGuess = new Label();
            GuessField = new TextBox();
            WrongGuesses = new Label();
            Guesses = new ListBox();
            Guess = new Button();
            Score = new Label();
            Hint = new Button();
            SuspendLayout();
            // 
            // WordToGuess
            // 
            WordToGuess.BackColor = Color.DarkSeaGreen;
            WordToGuess.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WordToGuess.Location = new Point(12, 9);
            WordToGuess.Margin = new Padding(5);
            WordToGuess.Name = "WordToGuess";
            WordToGuess.Padding = new Padding(25);
            WordToGuess.Size = new Size(544, 91);
            WordToGuess.TabIndex = 0;
            WordToGuess.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GuessField
            // 
            GuessField.Location = new Point(77, 108);
            GuessField.Name = "GuessField";
            GuessField.Size = new Size(405, 23);
            GuessField.TabIndex = 1;
            // 
            // WrongGuesses
            // 
            WrongGuesses.BackColor = Color.DarkSeaGreen;
            WrongGuesses.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WrongGuesses.ForeColor = SystemColors.Control;
            WrongGuesses.Location = new Point(566, 9);
            WrongGuesses.Margin = new Padding(5);
            WrongGuesses.Name = "WrongGuesses";
            WrongGuesses.Padding = new Padding(0, 0, 0, 2);
            WrongGuesses.Size = new Size(220, 26);
            WrongGuesses.TabIndex = 2;
            WrongGuesses.Text = "Wrong Guesses";
            WrongGuesses.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Guesses
            // 
            Guesses.FormattingEnabled = true;
            Guesses.ItemHeight = 15;
            Guesses.Location = new Point(566, 43);
            Guesses.Name = "Guesses";
            Guesses.Size = new Size(220, 169);
            Guesses.TabIndex = 3;
            // 
            // Guess
            // 
            Guess.BackColor = Color.DarkSeaGreen;
            Guess.FlatStyle = FlatStyle.Flat;
            Guess.ForeColor = SystemColors.Control;
            Guess.Location = new Point(191, 137);
            Guess.Name = "Guess";
            Guess.Size = new Size(162, 23);
            Guess.TabIndex = 4;
            Guess.Text = "Guess";
            Guess.UseVisualStyleBackColor = false;
            Guess.Click += button1_Click;
            // 
            // Score
            // 
            Score.Location = new Point(12, 141);
            Score.Name = "Score";
            Score.Size = new Size(85, 19);
            Score.TabIndex = 5;
            Score.Text = "Score:";
            // 
            // Hint
            // 
            Hint.BackColor = Color.DarkSeaGreen;
            Hint.FlatStyle = FlatStyle.Flat;
            Hint.ForeColor = SystemColors.Control;
            Hint.Location = new Point(464, 185);
            Hint.Name = "Hint";
            Hint.Size = new Size(92, 23);
            Hint.TabIndex = 6;
            Hint.Text = "Hint";
            Hint.UseVisualStyleBackColor = true;
            Hint.Click += Hint_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(798, 220);
            Controls.Add(Hint);
            Controls.Add(Score);
            Controls.Add(Guess);
            Controls.Add(Guesses);
            Controls.Add(WrongGuesses);
            Controls.Add(GuessField);
            Controls.Add(WordToGuess);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WordToGuess;
        private TextBox GuessField;
        private Label WrongGuesses;
        private ListBox Guesses;
        private Button Guess;
        private Label Score;
        private Button Hint;
    }
}
