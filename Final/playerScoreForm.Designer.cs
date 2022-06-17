namespace Final
{
    partial class playerScoreForm
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
            this.newGameButton = new System.Windows.Forms.Button();
            this.scoreLab = new System.Windows.Forms.Label();
            this.player2ScoreLabel = new System.Windows.Forms.Label();
            this.player1ScoreLabel = new System.Windows.Forms.Label();
            this.player2Lab = new System.Windows.Forms.Label();
            this.player1Lab = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(386, 27);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(182, 89);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // scoreLab
            // 
            this.scoreLab.AutoSize = true;
            this.scoreLab.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreLab.Location = new System.Drawing.Point(227, 9);
            this.scoreLab.Name = "scoreLab";
            this.scoreLab.Size = new System.Drawing.Size(126, 54);
            this.scoreLab.TabIndex = 2;
            this.scoreLab.Text = "Score";
            // 
            // player2ScoreLabel
            // 
            this.player2ScoreLabel.AutoSize = true;
            this.player2ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player2ScoreLabel.Location = new System.Drawing.Point(92, 269);
            this.player2ScoreLabel.Name = "player2ScoreLabel";
            this.player2ScoreLabel.Size = new System.Drawing.Size(37, 45);
            this.player2ScoreLabel.TabIndex = 3;
            this.player2ScoreLabel.Text = "2";
            // 
            // player1ScoreLabel
            // 
            this.player1ScoreLabel.AutoSize = true;
            this.player1ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player1ScoreLabel.Location = new System.Drawing.Point(92, 110);
            this.player1ScoreLabel.Name = "player1ScoreLabel";
            this.player1ScoreLabel.Size = new System.Drawing.Size(37, 45);
            this.player1ScoreLabel.TabIndex = 4;
            this.player1ScoreLabel.Text = "1";
            // 
            // player2Lab
            // 
            this.player2Lab.AutoSize = true;
            this.player2Lab.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player2Lab.Location = new System.Drawing.Point(35, 196);
            this.player2Lab.Name = "player2Lab";
            this.player2Lab.Size = new System.Drawing.Size(149, 45);
            this.player2Lab.TabIndex = 5;
            this.player2Lab.Text = "Player 2:";
            // 
            // player1Lab
            // 
            this.player1Lab.AutoSize = true;
            this.player1Lab.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player1Lab.Location = new System.Drawing.Point(35, 43);
            this.player1Lab.Name = "player1Lab";
            this.player1Lab.Size = new System.Drawing.Size(149, 45);
            this.player1Lab.TabIndex = 6;
            this.player1Lab.Text = "Player 1:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(386, 212);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(182, 89);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // playerScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 331);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.player1Lab);
            this.Controls.Add(this.player2Lab);
            this.Controls.Add(this.player1ScoreLabel);
            this.Controls.Add(this.player2ScoreLabel);
            this.Controls.Add(this.scoreLab);
            this.Controls.Add(this.newGameButton);
            this.Name = "playerScoreForm";
            this.Text = "playerScoreForm";
            this.Load += new System.EventHandler(this.playerScoreForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button newGameButton;
        private Label scoreLab;
        private Label player2ScoreLabel;
        private Label player1ScoreLabel;
        private Label player2Lab;
        private Label player1Lab;
        private Button exitButton;
    }
}