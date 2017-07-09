using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GuessPakGanern
{
    public partial class PakGanernMenu : Form
    {
        SoundPlayer sound = new SoundPlayer(GuessPakGanern.Properties.Resources.PacManIntro);

        public PakGanernMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            sound.Stop();

            this.Hide();
            Name nameu = new GuessPakGanern.Name();
            nameu.Show();
        }

        private void PakGanernMenu_Load(object sender, EventArgs e)
        {
            sound.PlayLooping();
        }
    }
}
