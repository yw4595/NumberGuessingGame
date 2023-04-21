using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
/**
 * Author: Yanzhi Wang
 * Purpose: Form that runs the number guessing game
 * Restrictions: None
 * Known errors: None
 */

namespace Multiple_Forms
{
    public partial class GameForm : Form
    {
        private int lowNumber;
        private int highNumber;
        private int correctNumber;
        private int remainingSeconds;
        private int numGuesses;
        private Timer timer;

        public GameForm(int low, int high)
        {
            InitializeComponent();

            lowNumber = low;
            highNumber = high;

            // Initialize remainingSeconds to 45 for progress bar
            remainingSeconds = 45;

            // Initialize the timer
            timer = new Timer();
            timer.Interval = 500; // 500 ms
            timer.Tick += Timer_Tick;
            timer.Start();

            // Initialize the progress bar
            countdownProgressBar.Maximum = remainingSeconds * 2;
            countdownProgressBar.Value = countdownProgressBar.Maximum;

            // Generate the correct number
            Random rand = new Random();
            correctNumber = rand.Next(lowNumber, highNumber + 1);

            // Initialize the output label
            outputLabel.Text = $"Guess a number between {lowNumber} and {highNumber}.";
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            // Get the user's guess
            if (!int.TryParse(guessTextBox.Text, out int guess))
            {
                MessageBox.Show("Please enter a valid number for your guess.");
                return;
            }

            // Increment the number of guesses
            numGuesses++;

            // Check if the guess is correct
            if (guess == correctNumber)
            {
                // Stop the timer
                timer.Stop();

                // Display a message box with the number of guesses
                MessageBox.Show($"Woohoo, you got it in {numGuesses} guesses!");

                // Close the form
                this.Close();
            }
            else if (guess < correctNumber)
            {
                outputLabel.Text = $"Your guess of {guess} was LOW.";
            }
            else
            {
                outputLabel.Text = $"Your guess of {guess} was HIGH.";
            }

            // Clear the guess text box
            guessTextBox.Clear();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the progress bar
            countdownProgressBar.Value--;
            remainingSeconds--;

            if (remainingSeconds <= 0)
            {
                // Stop the timer
                timer.Stop();

                // Display a message box with the failure message
                MessageBox.Show($"Sorry, you didn't guess the number in time. The number was {correctNumber}.");

                // Close the form
                this.Close();
            }
        }

        private void guessTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow digits and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
