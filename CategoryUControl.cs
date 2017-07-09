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
    public partial class CategoryUControl : UserControl
    {
        public CategoryUControl()
        {
            InitializeComponent();
        }

        private void AnimalBttn_Click(object sender, EventArgs e)
        {
            CategoryPanel.SendToBack();
            GamePanel.BringToFront();
            GamePanel.Controls.Clear();
            GamePanel.Controls.Add(new AnimalsUControl());
        }

        private void MoviesBttn_Click(object sender, EventArgs e)
        {
            CategoryPanel.SendToBack();
            GamePanel.BringToFront();
            GamePanel.Controls.Clear();
            GamePanel.Controls.Add(new MoviesUControl());
        }

        private void GamesBttn_Click(object sender, EventArgs e)
        {
            CategoryPanel.SendToBack();
            GamePanel.BringToFront();
            GamePanel.Controls.Clear();
            GamePanel.Controls.Add(new GamesUControl());
        }

        private void SuperHeroBttn_Click(object sender, EventArgs e)
        {
            CategoryPanel.SendToBack();
            GamePanel.BringToFront();
            GamePanel.Controls.Clear();
            GamePanel.Controls.Add(new SuperHeroUControl());
        }

        private void CountriesBttn_Click(object sender, EventArgs e)
        {
            CategoryPanel.SendToBack();
            GamePanel.BringToFront();
            GamePanel.Controls.Clear();
            GamePanel.Controls.Add(new CountriesUControl());
        }

        private void ArtistsBttn_Click(object sender, EventArgs e)
        {
            CategoryPanel.SendToBack();
            GamePanel.BringToFront();
            GamePanel.Controls.Clear();
            GamePanel.Controls.Add(new ArtistsUControl());
        }

        private void CategoryUControl_Load(object sender, EventArgs e)
        {
            CategoryPanel.Visible = false;
            SplashScreenPanel.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                SplashScreenPanel.Visible = false;
                CategoryPanel.Visible = true;
            }
        }
    }
}
