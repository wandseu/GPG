using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessPakGanern
{
    public partial class ArtistsUControl : UserControl
    {
        public ArtistsUControl()
        {
            InitializeComponent();
        }

        private System.Media.SoundPlayer mediaSoundPlayer = new System.Media.SoundPlayer();
        List<Label> labels = new List<Label>();
        public string[] words;
        public char[] a;
        public string randString;
        int errorctr = 0;
        int correctctr = 0;

        private void ArtistsUControl_Load(object sender, EventArgs e)
        {
            RandomWord();
        }

        public void RandomWord()
        {
            string[] words =
                {
                   "taylorswift",
                   "edsheeran",
                   "adele",
                   "onedirection",
                   "justinbieber",
                   "selenagomez",
                   "mileycyrus",
                   "arianagrande",
                   "nickiminaj",
                   "rihanna",
                   "chrisbrown",
                   "thevamps",
                   "troyesivan",
                   "twentyonepilots",
                   "thechainsmokers",
                   "shawnmendes",
                   "charlieputh",
                   "fifthharmony",
                   "littlemix",
                   "fettywap"
                };

            randString = words[new Random().Next(0, words.Length)];

            a = new char[randString.Length];

            int space = 600 / a.Length - 1;

            for (int i = 0; i < a.Length; i++)
            {
                labels.Add(new Label());
                labels[i].Font = new Font(this.Font.Name, 15, FontStyle.Bold);
                labels[i].Location = new Point((i * space) + 10, 125);
                labels[i].Parent = DisplayWordPanel;
                labels[i].Text = "__";
                labels[i].BringToFront();
                labels[i].CreateControl();
            }
        } // RandomWord()

        private void buttonQ_Click(object sender, EventArgs e)
        {
            bool minuslife = false;

            Button bttn = (Button)sender;
            bttn.Enabled = false;

            for (int i = 0; i < randString.Length; i++)
            {
                if (char.Equals(bttn.Text[0], char.ToUpper(randString[i])))
                {
                    labels[i].Font = new Font("Century Gothic", 15, FontStyle.Bold);
                    labels[i].Text = " " + bttn.Text + " ";
                    minuslife = true;
                    correctctr++;
                    // MarioJump.Play();
                }
            }

            if (minuslife == false)
            {
                errorctr++;
                //  Buzzer.Play();
            }

            if (randString.Length == correctctr)
            {
                PakGanernGame pgame = this.ParentForm as PakGanernGame;
                pgame.Score += 10;
                pgame.UpdateScore();
                RevealWordPanel.BringToFront();
                RevealWordLabel.Text = randString.ToString().ToUpper();
                RevealWordLabel.Font = new Font("Summeron", 30, FontStyle.Bold);
                RevealWordLabel.Parent = RevealWordPanel;

                CongratsPanel.BringToFront();
            }

            // hearts life
            if (errorctr == 1)
            {
                life8.Visible = false;
                DonutPictureBox.Image = Properties.Resources.donut2;
            }

            else if (errorctr == 2)
            {
                life7.Visible = false;
                DonutPictureBox.Image = Properties.Resources.donut3;
            }

            else if (errorctr == 3)
            {
                life6.Visible = false;
                DonutPictureBox.Image = Properties.Resources.donut4;
            }

            else if (errorctr == 4)
            {
                life5.Visible = false;
                DonutPictureBox.Image = Properties.Resources.donut5;
            }

            else if (errorctr == 5)
            {
                life4.Visible = false;
                DonutPictureBox.Image = Properties.Resources.donut6;
            }

            else if (errorctr == 6)
            {
                life3.Visible = false;
                DonutPictureBox.Image = Properties.Resources.donut7;
            }

            else if (errorctr == 7)
            {
                life2.Visible = false;
                DonutPictureBox.Image = Properties.Resources.donut8;
            }

            else if (errorctr == 8)
            {
                life1.Visible = false;
                DonutPictureBox.Image = Properties.Resources.donut1;

                RevealWordPanel.BringToFront();
                RevealWordLabel.Text = randString.ToString().ToUpper();
                RevealWordLabel.Font = new Font("Summeron", 30, FontStyle.Bold);
                RevealWordLabel.Parent = RevealWordPanel;

                GameOverPanel.BringToFront();
            }
        }

        private void EndGameBttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewGameBttn_Click(object sender, EventArgs e)
        {
            // Clear Score
            PakGanernGame pgame = this.ParentForm as PakGanernGame;
            pgame.Score = 0;
            pgame.UpdateScore();

            PGamePanel.Controls.Clear();
            PGamePanel.Controls.Add(new CategoryUControl());
            GameOverPanel.SendToBack();
        }

        private void CongratsEndGameBttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextRoundBttn_Click(object sender, EventArgs e)
        {
            PGamePanel.Controls.Clear();
            PGamePanel.Controls.Add(new ArtistsUControl());
            CongratsPanel.SendToBack();
        }
    }
}
