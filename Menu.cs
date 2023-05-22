using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_pavao
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AlimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadalimentos cadali = new cadalimentos();
            cadali.Show();
        }

        private void AlimentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            altalimentos altali = new altalimentos();
            altali.Show();
        }

        private void AnimaisToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            delalimentos delalt = new delalimentos();
            delalt.Show();
        }

        private void AnimaisToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ConsAliAni consali = new ConsAliAni();
            consali.Show();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_formClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
