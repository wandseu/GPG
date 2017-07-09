using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace GuessPakGanern
{
    public partial class PakGanernGame : Form
    {
        SoundPlayer GBGM = new SoundPlayer(GuessPakGanern.Properties.Resources.GBGM);
        public int choice = 1;

        public string playerName;
        public string InputPlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public void ReturnPName()
        {
            this.PlayerNameLabel.Text = ("Bes "+InputPlayerName).ToString();
        }

        private int _Score = 0;
        
        public int Score
        {
            get { return _Score; }
            set { _Score = value; }
        }

        private int _ListTemp;
        public int ListTemp
        {
            get { return _ListTemp; }
            set { _ListTemp = value; }
        }

        public PakGanernGame()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PakGanernGame_Load(object sender, EventArgs e)
        {
            GBGM.PlayLooping();
            
            PGamePanel.Controls.Clear();
            PGamePanel.Controls.Add(new CategoryUControl());
        }

        private void Instructions_Click(object sender, EventArgs e)
        {
            HowTo.Visible = false;
            PGamePanel.Controls.Clear();
            PGamePanel.Controls.Add(new CategoryUControl());
        }  

        public void UpdateScore()
        {
            this.ScoreLabel.Text = Score.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            HowTo.Visible = true;
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Changing the category will restart the game. Do you wish to continue?", "Ayaw mo na bes?", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Score = 0;
                UpdateScore();
                PGamePanel.Controls.Clear();
                PGamePanel.Controls.Add(new CategoryUControl());
            }
        }
    } // PakGanern Form
} // namespace
