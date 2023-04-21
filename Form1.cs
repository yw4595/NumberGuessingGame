using System;
using System.Windows.Forms;
/**
 * Author: Yanzhi Wang
 * Purpose: Main form that allows the user to start the number guessing game
 * Restrictions: None
 * Known errors: None
 */


namespace Multiple_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // Verify that low and high values are valid numbers
            if (!int.TryParse(LowTextBox.Text, out int lowNumber))
            {
                MessageBox.Show("Please enter a valid low number.");
                return;
            }

            if (!int.TryParse(HighTextBox.Text, out int highNumber))
            {
                MessageBox.Show("Please enter a valid high number.");
                return;
            }

            // Verify that low is less than high
            if (lowNumber >= highNumber)
            {
                MessageBox.Show("Please enter a low number that is less than the high number.");
                return;
            }

            // Create a new GameForm and show it
           GameForm gameForm = new GameForm(lowNumber, highNumber);
           gameForm.ShowDialog();
        }
    }
}
