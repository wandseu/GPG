namespace GuessPakGanern
{
    partial class PakGanernGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PakGanernGame));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.HowTo = new System.Windows.Forms.Panel();
            this.Instructions = new System.Windows.Forms.PictureBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.MainMenu = new System.Windows.Forms.Label();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PGamePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.HowTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Instructions)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GuessPakGanern.Properties.Resources.cross_inside_a_square;
            this.pictureBox1.Location = new System.Drawing.Point(781, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::GuessPakGanern.Properties.Resources.minimize_tab;
            this.pictureBox2.Location = new System.Drawing.Point(762, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(142)))), ((int)(((byte)(121)))));
            this.ScoreLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(212)))), ((int)(((byte)(175)))));
            this.ScoreLabel.Location = new System.Drawing.Point(552, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(18, 19);
            this.ScoreLabel.TabIndex = 45;
            this.ScoreLabel.Text = "0";
            // 
            // HowTo
            // 
            this.HowTo.BackColor = System.Drawing.Color.Transparent;
            this.HowTo.BackgroundImage = global::GuessPakGanern.Properties.Resources.howto;
            this.HowTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HowTo.Controls.Add(this.Instructions);
            this.HowTo.Location = new System.Drawing.Point(28, 22);
            this.HowTo.Name = "HowTo";
            this.HowTo.Size = new System.Drawing.Size(743, 580);
            this.HowTo.TabIndex = 50;
            // 
            // Instructions
            // 
            this.Instructions.BackColor = System.Drawing.Color.Transparent;
            this.Instructions.Image = global::GuessPakGanern.Properties.Resources.cross_inside_a_square;
            this.Instructions.Location = new System.Drawing.Point(609, 30);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(20, 20);
            this.Instructions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Instructions.TabIndex = 29;
            this.Instructions.TabStop = false;
            this.Instructions.Click += new System.EventHandler(this.Instructions_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(212)))), ((int)(((byte)(175)))));
            this.HeaderPanel.Controls.Add(this.MainMenu);
            this.HeaderPanel.Controls.Add(this.PlayerNameLabel);
            this.HeaderPanel.Controls.Add(this.pictureBox3);
            this.HeaderPanel.Controls.Add(this.label5);
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Controls.Add(this.ScoreLabel);
            this.HeaderPanel.Location = new System.Drawing.Point(50, 36);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(700, 37);
            this.HeaderPanel.TabIndex = 52;
            // 
            // MainMenu
            // 
            this.MainMenu.AutoSize = true;
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(142)))), ((int)(((byte)(121)))));
            this.MainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(212)))), ((int)(((byte)(175)))));
            this.MainMenu.Location = new System.Drawing.Point(608, 9);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(53, 19);
            this.MainMenu.TabIndex = 61;
            this.MainMenu.Text = "MENU";
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(142)))), ((int)(((byte)(121)))));
            this.PlayerNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(212)))), ((int)(((byte)(175)))));
            this.PlayerNameLabel.Location = new System.Drawing.Point(123, 9);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(34, 19);
            this.PlayerNameLabel.TabIndex = 60;
            this.PlayerNameLabel.Text = "BES";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GuessPakGanern.Properties.Resources.kvhVUAG;
            this.pictureBox3.Location = new System.Drawing.Point(664, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(142)))), ((int)(((byte)(121)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(212)))), ((int)(((byte)(175)))));
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 59;
            this.label5.Text = "PLAYER NAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(142)))), ((int)(((byte)(121)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(212)))), ((int)(((byte)(175)))));
            this.label1.Location = new System.Drawing.Point(492, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = "SCORE:";
            // 
            // PGamePanel
            // 
            this.PGamePanel.BackColor = System.Drawing.Color.Transparent;
            this.PGamePanel.Location = new System.Drawing.Point(30, 73);
            this.PGamePanel.Name = "PGamePanel";
            this.PGamePanel.Size = new System.Drawing.Size(741, 499);
            this.PGamePanel.TabIndex = 53;
            // 
            // PakGanernGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::GuessPakGanern.Properties.Resources.tumblr_n5pcezCGFa1talk0xo1_500;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.HowTo);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.PGamePanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PakGanernGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PakGanernGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.HowTo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Instructions)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Panel HowTo;
        private System.Windows.Forms.PictureBox Instructions;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel PGamePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label PlayerNameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MainMenu;
    }
}