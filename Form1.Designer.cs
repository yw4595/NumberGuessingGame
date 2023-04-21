namespace Multiple_Forms
{
    partial class Form1
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
            this.StartButton = new System.Windows.Forms.Button();
            this.LowLabel = new System.Windows.Forms.Label();
            this.HighLabel = new System.Windows.Forms.Label();
            this.LowTextBox = new System.Windows.Forms.TextBox();
            this.HighTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(107, 107);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 35);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LowLabel
            // 
            this.LowLabel.AutoSize = true;
            this.LowLabel.Location = new System.Drawing.Point(12, 25);
            this.LowLabel.Name = "LowLabel";
            this.LowLabel.Size = new System.Drawing.Size(99, 13);
            this.LowLabel.TabIndex = 1;
            this.LowLabel.Text = "Low End of Range:";
            // 
            // HighLabel
            // 
            this.HighLabel.AutoSize = true;
            this.HighLabel.Location = new System.Drawing.Point(191, 25);
            this.HighLabel.Name = "HighLabel";
            this.HighLabel.Size = new System.Drawing.Size(101, 13);
            this.HighLabel.TabIndex = 2;
            this.HighLabel.Text = "High End of Range:";
            // 
            // LowTextBox
            // 
            this.LowTextBox.Location = new System.Drawing.Point(11, 69);
            this.LowTextBox.Name = "LowTextBox";
            this.LowTextBox.Size = new System.Drawing.Size(100, 20);
            this.LowTextBox.TabIndex = 3;
            this.LowTextBox.Text = "1";
            // 
            // HighTextBox
            // 
            this.HighTextBox.Location = new System.Drawing.Point(194, 68);
            this.HighTextBox.Name = "HighTextBox";
            this.HighTextBox.Size = new System.Drawing.Size(100, 20);
            this.HighTextBox.TabIndex = 4;
            this.HighTextBox.Text = "100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HighTextBox);
            this.Controls.Add(this.LowTextBox);
            this.Controls.Add(this.HighLabel);
            this.Controls.Add(this.LowLabel);
            this.Controls.Add(this.StartButton);
            this.Location = new System.Drawing.Point(107, 107);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label LowLabel;
        private System.Windows.Forms.Label HighLabel;
        private System.Windows.Forms.TextBox LowTextBox;
        private System.Windows.Forms.TextBox HighTextBox;
    }
}

