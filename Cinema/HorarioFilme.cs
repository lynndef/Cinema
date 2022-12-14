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

        private void HorarioFilme_Load(object sender, EventArgs e)
        {
            LabelNameFilme.Text = nomefilme;
            ImgFilme.BackgroundImage = cartaz;

            labelsala1.Parent = ImgQuadrado;
            labelsala1.BackColor = Color.Transparent;

            imgQuadradoSmall.Parent = ImgQuadrado;
            imgQuadradoSmall.BackColor = Color.Transparent;

            ImgQuadradoSmall2.Parent = ImgQuadrado;
            ImgQuadradoSmall2.BackColor = Color.Transparent;

            labelhrdisp.Parent = imgPanel;
            labelhrdisp.BackColor = Color.Transparent;

            CompreF1H1.Text = "10:30 am" + "\n" + "clique aqui";
            CompreF1H2.Text = "13:30 pm" + "\n" + "clique aqui";

            CompreF2H1.Text = "13:40 pm" + "\n" + "clique aqui";
            CompreF2H2.Text = "16:40 pm" + "\n" + "clique aqui";

            CompreF3H1.Text = "17:00 pm" + "\n" + "clique aqui";
            CompreF3H2.Text = "19:30 pm" + "\n" + "clique aqui";

            if (LabelNameFilme.Text == "Adão Negro")
            {
                CompreF1H1.Visible = true;
                CompreF1H2.Visible = true;
            }
            else if (LabelNameFilme.Text == "Orfã 2")
            {
                CompreF2H1.Visible = true;
                CompreF2H2.Visible = true;
            }
            else if (LabelNameFilme.Text == "Minions 2")
            {
                CompreF3H1.Visible = true;
                CompreF3H2.Visible = true;
            }

        }

        private void LabelCompre1_Click(object sender, EventArgs e)
        {

            Form f3 = new assentos( cartaz, nomefilme, ControleAssentos.Seg.AdaoSala1_10h30); //
            f3.Location = this.Location;
            f3.StartPosition = FormStartPosition.Manual;
            f3.FormClosing += delegate { this.Show(); };
            f3.Show();
            this.Hide();
        }

        private void CompreF1H2_Click_1(object sender, EventArgs e)
        {

            Form f3 = new assentos2( cartaz, nomefilme, ControleAssentos.Seg.AdaoSala1_10h30);
            f3.Location = this.Location;
            f3.StartPosition = FormStartPosition.Manual;
            f3.FormClosing += delegate { this.Show(); };
            f3.Show();
            this.Hide();
        }

        private void CompreF2H1_Click(object sender, EventArgs e)
        {

            Form f3 = new assentos3( cartaz, nomefilme, ControleAssentos.Seg.AdaoSala1_10h30);
            f3.Location = this.Location;
            f3.StartPosition = FormStartPosition.Manual;
            f3.FormClosing += delegate { this.Show(); };
            f3.Show();
            this.Hide();
        }

        private void CompreF2H2_Click(object sender, EventArgs e)
        {

            Form f3 = new assentos4( cartaz, nomefilme, ControleAssentos.Seg.AdaoSala1_10h30);
            f3.Location = this.Location;
            f3.StartPosition = FormStartPosition.Manual;
            f3.FormClosing += delegate { this.Show(); };
            f3.Show();
            this.Hide();
        }

        private void CompreF3H1_Click(object sender, EventArgs e)
        {

            Form f3 = new assentos5( cartaz, nomefilme, ControleAssentos.Seg.AdaoSala1_10h30);
            f3.Location = this.Location;
            f3.StartPosition = FormStartPosition.Manual;
            f3.FormClosing += delegate { this.Show(); };
            f3.Show();
            this.Hide();
        }

        private void CompreF3H2_Click(object sender, EventArgs e)
        {

            Form f3 = new assentos6(cartaz, nomefilme, ControleAssentos.Seg.AdaoSala1_10h30);
            f3.Location = this.Location;
            f3.StartPosition = FormStartPosition.Manual;
            f3.FormClosing += delegate { this.Show(); };
            f3.Show();
            this.Hide();
        }

        private void imgseta_Click(object sender, EventArgs e)
        {
            Form f1 = new MainMenu();
            f1.Location = this.Location;
            f1.StartPosition = FormStartPosition.Manual;
            f1.Show();
            this.Hide();
        }
    }
}
