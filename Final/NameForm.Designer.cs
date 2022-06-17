namespace Final
{
    partial class NameForm
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
            this.player1pvpLab = new System.Windows.Forms.Label();
            this.nameLab = new System.Windows.Forms.Label();
            this.pvpCB = new System.Windows.Forms.CheckBox();
            this.pvcCB = new System.Windows.Forms.CheckBox();
            this.hardDifficultyRB = new System.Windows.Forms.RadioButton();
            this.easyDifficultyRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // player1pvpLab
            // 
            this.player1pvpLab.AutoSize = true;
            this.player1pvpLab.Location = new System.Drawing.Point(228, 66);
            this.player1pvpLab.Name = "player1pvpLab";
            this.player1pvpLab.Size = new System.Drawing.Size(74, 25);
            this.player1pvpLab.TabIndex = 0;
            this.player1pvpLab.Text = "Player 1";
            this.player1pvpLab.Visible = false;
            // 
            // nameLab
            // 
            this.nameLab.AutoSize = true;
            this.nameLab.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLab.Location = new System.Drawing.Point(198, 6);
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(146, 45);
            this.nameLab.TabIndex = 2;
            this.nameLab.Text = "Name(s)";
            this.nameLab.Visible = false;
            // 
            // pvpCB
            // 
            this.pvpCB.AutoSize = true;
            this.pvpCB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pvpCB.Location = new System.Drawing.Point(147, 66);
            this.pvpCB.Name = "pvpCB";
            this.pvpCB.Size = new System.Drawing.Size(248, 42);
            this.pvpCB.TabIndex = 5;
            this.pvpCB.Text = "Player vs Player";
            this.pvpCB.UseVisualStyleBackColor = true;
            this.pvpCB.CheckedChanged += new System.EventHandler(this.pvpCB_CheckedChanged);
            // 
            // pvcCB
            // 
            this.pvcCB.AutoSize = true;
            this.pvcCB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pvcCB.Location = new System.Drawing.Point(147, 186);
            this.pvcCB.Name = "pvcCB";
            this.pvcCB.Size = new System.Drawing.Size(298, 42);
            this.pvcCB.TabIndex = 6;
            this.pvcCB.Text = "Player vs Computer";
            this.pvcCB.UseVisualStyleBackColor = true;
            this.pvcCB.CheckedChanged += new System.EventHandler(this.pvcCB_CheckedChanged);
            // 
            // hardDifficultyRB
            // 
            this.hardDifficultyRB.AutoSize = true;
            this.hardDifficultyRB.Location = new System.Drawing.Point(182, 286);
            this.hardDifficultyRB.Name = "hardDifficultyRB";
            this.hardDifficultyRB.Size = new System.Drawing.Size(151, 29);
            this.hardDifficultyRB.TabIndex = 7;
            this.hardDifficultyRB.TabStop = true;
            this.hardDifficultyRB.Text = "Hard Difficulty";
            this.hardDifficultyRB.UseVisualStyleBackColor = true;
            this.hardDifficultyRB.Visible = false;
            this.hardDifficultyRB.CheckedChanged += new System.EventHandler(this.hardDifficultyRB_CheckedChanged);
            // 
            // easyDifficultyRB
            // 
            this.easyDifficultyRB.AutoSize = true;
            this.easyDifficultyRB.Location = new System.Drawing.Point(182, 234);
            this.easyDifficultyRB.Name = "easyDifficultyRB";
            this.easyDifficultyRB.Size = new System.Drawing.Size(147, 29);
            this.easyDifficultyRB.TabIndex = 8;
            this.easyDifficultyRB.TabStop = true;
            this.easyDifficultyRB.Text = "Easy Difficulty";
            this.easyDifficultyRB.UseVisualStyleBackColor = true;
            this.easyDifficultyRB.Visible = false;
            this.easyDifficultyRB.CheckedChanged += new System.EventHandler(this.easyDifficultyRB_CheckedChanged);
            // 
            // NameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 339);
            this.Controls.Add(this.easyDifficultyRB);
            this.Controls.Add(this.hardDifficultyRB);
            this.Controls.Add(this.pvcCB);
            this.Controls.Add(this.pvpCB);
            this.Controls.Add(this.nameLab);
            this.Controls.Add(this.player1pvpLab);
            this.Name = "NameForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label player1pvpLab;
        private Label nameLab;
        public CheckBox pvpCB;
        public CheckBox pvcCB;
        private RadioButton hardDifficultyRB;
        private RadioButton easyDifficultyRB;
    }
}