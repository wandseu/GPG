

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessPakGanern
{
    public partial class Name : Form
    {
        public string PName;
        public string pName
        {
            get { return this.PName; }
            set { PName = value; }
        }

        public string ReturnPName()
        {
            return pName;
        }

        public Name()
        {
            InitializeComponent();
        }

        private void EnterNameBttn_Click(object sender, EventArgs e)
        {
            if(txtName.Text == string.Empty)
            {
                MessageBox.Show("Player name can't be empty, Bes!");
            }

            else
            {
                this.Hide();
                PakGanernGame pgame = new PakGanernGame();
                pgame.InputPlayerName = txtName.Text;
                pgame.ReturnPName();
                pgame.Show();
            }
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtName.Text == string.Empty)
                {
                    MessageBox.Show("Player name can't be empty, Bes!");
                }

                else
                {
                    this.Hide();
                    PakGanernGame pgame = new PakGanernGame();
                    pgame.InputPlayerName = txtName.Text;
                    pgame.ReturnPName();
                    pgame.Show();
                }
            }
        }
    }
}
