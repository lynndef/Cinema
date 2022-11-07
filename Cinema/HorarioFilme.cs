using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class HorarioFilme : Form
    {
        public HorarioFilme()
        {
            InitializeComponent();
        }

        public HorarioFilme(string nomefilme)
        {
            InitializeComponent();
            this.nomefilme = nomefilme;
        }

        public HorarioFilme(string nomefilme, Image cartaz) : this(nomefilme)
        {
            this.cartaz = cartaz;
        }

        private string nomefilme;
        private Image cartaz;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HorarioFilme_Load(object sender, EventArgs e)
        {
            LabelNameFilme.Text = nomefilme;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSeg_Click(object sender, EventArgs e)
        {
           
        }

        private void LabelCompre1_Click(object sender, EventArgs e)
        {
            Form f3 = new Assentos(cartaz, nomefilme, ControleAssentos.Seg.AdaoSala1_10h30); //
            f3.Location = this.Location;
            f3.StartPosition = FormStartPosition.Manual;
            f3.FormClosing += delegate { this.Show(); };
            f3.Show();
            this.Hide();
        }
    }
}
