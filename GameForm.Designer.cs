namespace Multiple_Forms
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.gameStatusStrip = new System.Windows.Forms.StatusStrip();
            this.countdownProgressBar = new System.Windows.Forms.ProgressBar();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // guessTextBox
            // 
            this.guessTextBox.Location = new System.Drawing.Point(12, 12);
            this.guessTextBox.MaxLength = 3;
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(100, 20);
            this.guessTextBox.TabIndex = 0;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(125, 54);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 1;
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(12, 74);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(75, 23);
            this.guessButton.TabIndex = 2;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // gameStatusStrip
            // 
            this.gameStatusStrip.Location = new System.Drawing.Point(0, 428);
            this.gameStatusStrip.Name = "gameStatusStrip";
            this.gameStatusStrip.Size = new System.Drawing.Size(800, 22);
            this.gameStatusStrip.TabIndex = 3;
            this.gameStatusStrip.Text = "statusStrip1";
            // 
            // countdownProgressBar
            // 
            this.countdownProgressBar.Location = new System.Drawing.Point(286, 172);
            this.countdownProgressBar.Maximum = 45;
            this.countdownProgressBar.Name = "countdownProgressBar";
            this.countdownProgressBar.Size = new System.Drawing.Size(100, 23);
            this.countdownProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.countdownProgressBar.TabIndex = 4;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 500;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countdownProgressBar);
            this.Controls.Add(this.gameStatusStrip);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.guessTextBox);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.StatusStrip gameStatusStrip;
        private System.Windows.Forms.ProgressBar countdownProgressBar;
        private System.Windows.Forms.Timer gameTimer;
    }
}