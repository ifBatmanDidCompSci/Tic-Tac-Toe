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
            this.enterButton = new System.Windows.Forms.Button();
            this.player1pvpTB = new System.Windows.Forms.TextBox();
            this.pvpCB = new System.Windows.Forms.CheckBox();
            this.pvcCB = new System.Windows.Forms.CheckBox();
            this.player2Lab = new System.Windows.Forms.Label();
            this.player2TB = new System.Windows.Forms.TextBox();
            this.player1pvcTB = new System.Windows.Forms.TextBox();
            this.player1pvcLab = new System.Windows.Forms.Label();
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
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(354, 245);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(194, 78);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Visible = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // player1pvpTB
            // 
            this.player1pvpTB.Location = new System.Drawing.Point(125, 94);
            this.player1pvpTB.Multiline = true;
            this.player1pvpTB.Name = "player1pvpTB";
            this.player1pvpTB.Size = new System.Drawing.Size(284, 38);
            this.player1pvpTB.TabIndex = 4;
            this.player1pvpTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.player1pvpTB.Visible = false;
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
            this.pvcCB.Location = new System.Drawing.Point(147, 178);
            this.pvcCB.Name = "pvcCB";
            this.pvcCB.Size = new System.Drawing.Size(298, 42);
            this.pvcCB.TabIndex = 6;
            this.pvcCB.Text = "Player vs Computer";
            this.pvcCB.UseVisualStyleBackColor = true;
            this.pvcCB.CheckedChanged += new System.EventHandler(this.pvcCB_CheckedChanged);
            // 
            // player2Lab
            // 
            this.player2Lab.AutoSize = true;
            this.player2Lab.Location = new System.Drawing.Point(228, 150);
            this.player2Lab.Name = "player2Lab";
            this.player2Lab.Size = new System.Drawing.Size(74, 25);
            this.player2Lab.TabIndex = 7;
            this.player2Lab.Text = "Player 2";
            this.player2Lab.Visible = false;
            // 
            // player2TB
            // 
            this.player2TB.Location = new System.Drawing.Point(125, 178);
            this.player2TB.Multiline = true;
            this.player2TB.Name = "player2TB";
            this.player2TB.Size = new System.Drawing.Size(284, 42);
            this.player2TB.TabIndex = 8;
            this.player2TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.player2TB.Visible = false;
            // 
            // player1pvcTB
            // 
            this.player1pvcTB.Location = new System.Drawing.Point(125, 135);
            this.player1pvcTB.Multiline = true;
            this.player1pvcTB.Name = "player1pvcTB";
            this.player1pvcTB.Size = new System.Drawing.Size(284, 40);
            this.player1pvcTB.TabIndex = 9;
            this.player1pvcTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.player1pvcTB.Visible = false;
            this.player1pvcTB.TextChanged += new System.EventHandler(this.player1pvcTB_TextChanged);
            // 
            // player1pvcLab
            // 
            this.player1pvcLab.AutoSize = true;
            this.player1pvcLab.Location = new System.Drawing.Point(228, 107);
            this.player1pvcLab.Name = "player1pvcLab";
            this.player1pvcLab.Size = new System.Drawing.Size(74, 25);
            this.player1pvcLab.TabIndex = 10;
            this.player1pvcLab.Text = "Player 1";
            this.player1pvcLab.Visible = false;
            // 
            // NameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 335);
            this.Controls.Add(this.player1pvcLab);
            this.Controls.Add(this.player1pvcTB);
            this.Controls.Add(this.player2TB);
            this.Controls.Add(this.player2Lab);
            this.Controls.Add(this.pvcCB);
            this.Controls.Add(this.pvpCB);
            this.Controls.Add(this.player1pvpTB);
            this.Controls.Add(this.enterButton);
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
        private Button enterButton;
        private Label player2Lab;
        private Label player1pvcLab;
        public TextBox player1pvpTB;
        public CheckBox pvpCB;
        public CheckBox pvcCB;
        public TextBox player2TB;
        public TextBox player1pvcTB;
    }
}