using System;
using System.Collections;
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
    public partial class assentos6 : Form
    {
        public assentos6()
        {
            InitializeComponent();
        }

        public assentos6(Image cartaz)
        {
            InitializeComponent();
            this.cartaz = cartaz;
        }

        Horarios horarios;

        public assentos6(Image cartaz, string nomefilme, Horarios horarios) : this(cartaz)
        {
            this.nomefilme = nomefilme;
            this.horarios = horarios;
        }

        public assentos6(string sessao, Image cartaz, string nomefilme, Horarios adaoSala1_10h30)
        {
            this.sessao = sessao;
            this.cartaz = cartaz;
            this.nomefilme = nomefilme;
            this.adaoSala1_10h30 = adaoSala1_10h30;
        }

        String[] AssentosNome = new string[18];

        private Image cartaz;
        private string nomefilme;
        private string sessao;
        private Horarios adaoSala1_10h30;

        private void assentos6_Load(object sender, EventArgs e)
        {
            ImgCartaz.BackgroundImage = cartaz;
            LabelNome.Text = nomefilme;

            if (ControleAssentos.Seg.AdaoSala1_10h30.AssentosClicks6[0] != 0)
            {
                btnAssento1.Visible = false;
                a1.Visible = true;
            }
            if (ControleAssentos.Seg.AdaoSala1_10h30.AssentosClicks6[1] != 0)
            {
                btnAssento2.Visible = false;
                a2.Visible = true;
            }
            if (ControleAssentos.Seg.AdaoSala1_10h30.AssentosClicks6[2] != 0)
            {
                btnAssento3.Visible = false;
                a3.Visible = true;
            }
            if (ControleAssentos.Seg.AdaoSala1_10h30.AssentosClicks6[3] != 0)
            {
                btnAssento4.Visible = false;
                a4.Visible = true;
            }
            if (ControleAssentos.Seg.AdaoSala1_10h30.AssentosClicks6[4] != 0)
            {
                btnAssento5.Visible = false;
                a5.Visible = true;
            }
            if (ControleAssentos.Seg.AdaoSala1_10h30.AssentosClicks6[5] != 0)
            {
                btnAssento6.Visible = false;
                a6.Visible = true;
            }
            if (ControleAssentos.Seg.AdaoSala1_10h30.AssentosClicks6[6] != 0)
            {
                btnAssento7.Visible = false;
                a7.Visible = true;
            }
            if (ControleAssentos.Seg.AdaoSala1_10h30.AssentosClicks6[7] != 0)
            {
                btnAssento8.Visible = false;
                a8.Visible = true;
            }
            if (ControleAssentos.Seg.AdaoSala1_10h30.AssentosClicks6[8] != 0)
            {
                btnAssento9.Visible = false;
                a9.Visible = true;
            }
            if (ControleAssentos.Seg.AdaoSala1_10h30.AssentosClicks6[9] != 0)
            {
                btnAssento10.Visible = false;
                a10.Visible = true;
            }
            if (ControleAssentos.Seg.AdaoSala1_10h30.AssentosClicks6[10] != 0)
            {
                btnAssento11.Visible = false;
                a11.Visible = true;
            }
            if (ControleAssentos.Seg.AdaoSala1_10h30.AssentosClicks6[11] != 0)
            {
                btnAssento12.Visible = false;
                a12.Visible = true;
            }
            if (ControleAssentos.Seg.AdaoSala1_10h30.AssentosClicks6[12] != 0)
            {
                btnAssento13.Visible = false;
                a13.Visible = true;
            }
            if (ControleAssentos.Seg.AdaoSala1_10h30.AssentosClicks6[13] != 0)
            {
                btnAssento14.Visible = false;
                a14.Visible = true;
            }
            if (ControleAssentos.Seg.AdaoSala1_10h30.AssentosClicks6[14] != 0)
            {
                btnAssento15.Visible = false;
                a15.Visible = true;
            }
            if (ControleAssentos.Seg.AdaoSala1_10h30.AssentosClicks6[15] != 0)
            {
                btnAssento16.Visible = false;
                a16.Visible = true;
            }
            if (ControleAssentos.Seg.AdaoSala1_10h30.AssentosClicks6[16] != 0)
            {
                btnAssento17.Visible = false;
                a17.Visible = true;
            }
            if (ControleAssentos.Seg.AdaoSala1_10h30.AssentosClicks6[17] != 0)
            {
                btnAssento18.Visible = false;
                a18.Visible = true;
            }
        }

        private void btnAssento1_Click(object sender, EventArgs e)
        {


            horarios.AssentosClicks6[0] = horarios.AssentosClicks6[0] + 1;

            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);


            if (horarios.AssentosClicks6[0] % 2 == 0)
            {
                horarios.AssentosClicks6[0] = 0;
                btnAssento1.BackColor = Color.FromArgb(3, 171, 224);
                btnAssento1.Text = "";
                btnAssento1.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[0] = "";

            }
            else
            {
                btnAssento1.BackColor = Color.LimeGreen;
                btnAssento1.Text = "A1";
                btnAssento1.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos - 1);
                label0.Text = Convert.ToString(labelzero + 1);
                AssentosNome[0] = "A1";

            }

            if (label0.Text != "0")
            {
                BtnConfirmar.Visible = true;
            }
            else
            {
                BtnConfirmar.Visible = false;
            }


        }

        private void btnAssento2_Click(object sender, EventArgs e)
        {

            horarios.AssentosClicks6[1] = horarios.AssentosClicks6[1] + 1;


            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (horarios.AssentosClicks6[1] % 2 == 0)
            {
                horarios.AssentosClicks6[1] = 0;
                btnAssento2.BackColor = Color.FromArgb(3, 171, 224);
                btnAssento2.Text = "";
                btnAssento2.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[1] = "";
            }
            else
            {
                btnAssento2.BackColor = Color.LimeGreen;
                btnAssento2.Text = "A2";
                btnAssento2.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos - 1);
                label0.Text = Convert.ToString(labelzero + 1);
                AssentosNome[1] = "A2";

            }

            if (label0.Text != "0")
            {
                BtnConfirmar.Visible = true;
            }
            else
            {
                BtnConfirmar.Visible = false;
            }


        }

        private void btnAssento3_Click(object sender, EventArgs e)
        {

            horarios.AssentosClicks6[2] = horarios.AssentosClicks6[2] + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (horarios.AssentosClicks6[2] % 2 == 0)
            {
                horarios.AssentosClicks6[2] = 0;
                btnAssento3.BackColor = Color.FromArgb(3, 171, 224);
                btnAssento3.Text = "";
                btnAssento3.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[2] = "";
            }
            else
            {
                btnAssento3.BackColor = Color.LimeGreen;
                btnAssento3.Text = "A3";
                btnAssento3.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos - 1);
                label0.Text = Convert.ToString(labelzero + 1);
                AssentosNome[2] = "A3";

            }

            if (label0.Text != "0")
            {
                BtnConfirmar.Visible = true;
            }
            else
            {
                BtnConfirmar.Visible = false;
            }

        }


        private void btnAssento4_Click(object sender, EventArgs e)
        {
            horarios.AssentosClicks6[3] = horarios.AssentosClicks6[3] + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (horarios.AssentosClicks6[3] % 2 == 0)
            {
                horarios.AssentosClicks6[3] = 0;
                btnAssento4.BackColor = Color.FromArgb(3, 171, 224);
                btnAssento4.Text = "";
                btnAssento4.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[3] = "";
            }
            else
            {
                btnAssento4.BackColor = Color.LimeGreen;
                btnAssento4.Text = "A4";
                btnAssento4.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos - 1);
                label0.Text = Convert.ToString(labelzero + 1);
                AssentosNome[3] = "A4";
            }

            if (label0.Text != "0")
            {
                BtnConfirmar.Visible = true;
            }
            else
            {
                BtnConfirmar.Visible = false;
            }
        }

        private void btnAssento5_Click(object sender, EventArgs e)
        {
            horarios.AssentosClicks6[4] = horarios.AssentosClicks6[4] + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (horarios.AssentosClicks6[4] % 2 == 0)
            {
                horarios.AssentosClicks6[4] = 0;
                btnAssento5.BackColor = Color.FromArgb(3, 171, 224);
                btnAssento5.Text = "";
                btnAssento5.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[4] = "";
            }
            else
            {
                btnAssento5.BackColor = Color.LimeGreen;
                btnAssento5.Text = "A5";
                btnAssento5.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos - 1);
                label0.Text = Convert.ToString(labelzero + 1);
                AssentosNome[4] = "A5";

            }

            if (label0.Text != "0")
            {
                BtnConfirmar.Visible = true;
            }
            else
            {
                BtnConfirmar.Visible = false;
            }
        }

        private void btnAssento6_Click(object sender, EventArgs e)
        {
            horarios.AssentosClicks6[5] = horarios.AssentosClicks6[5] + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (horarios.AssentosClicks6[5] % 2 == 0)
            {
                horarios.AssentosClicks6[5] = 0;
                btnAssento6.BackColor = Color.FromArgb(3, 171, 224);
                btnAssento6.Text = "";
                btnAssento6.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[5] = "";
            }
            else
            {
                btnAssento6.BackColor = Color.LimeGreen;
                btnAssento6.Text = "A6";
                btnAssento6.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos - 1);
                label0.Text = Convert.ToString(labelzero + 1);
                AssentosNome[5] = "";
            }

            if (label0.Text != "0")
            {
                BtnConfirmar.Visible = true;
            }
            else
            {
                BtnConfirmar.Visible = false;
            }
        }

        private void btnAssento7_Click(object sender, EventArgs e)
        {
            horarios.AssentosClicks6[6] = horarios.AssentosClicks6[6] + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (horarios.AssentosClicks6[6] % 2 == 0)
            {
                horarios.AssentosClicks6[6] = 0;
                btnAssento7.BackColor = Color.FromArgb(3, 171, 224);
                btnAssento7.Text = "";
                btnAssento7.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[6] = "";
            }
            else
            {
                btnAssento7.BackColor = Color.LimeGreen;
                btnAssento7.Text = "B1";
                btnAssento7.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos - 1);
                label0.Text = Convert.ToString(labelzero + 1);
                AssentosNome[6] = "B1";
            }

            if (label0.Text != "0")
            {
                BtnConfirmar.Visible = true;
            }
            else
            {
                BtnConfirmar.Visible = false;
            }
        }

        private void btnAssento8_Click(object sender, EventArgs e)
        {
            horarios.AssentosClicks6[7] = horarios.AssentosClicks6[7] + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (horarios.AssentosClicks6[7] % 2 == 0)
            {
                horarios.AssentosClicks6[7] = 0;
                btnAssento8.BackColor = Color.FromArgb(3, 171, 224);
                btnAssento8.Text = "";
                btnAssento8.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[7] = "";
            }
            else
            {
                btnAssento8.BackColor = Color.LimeGreen;
                btnAssento8.Text = "B2";
                btnAssento8.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos - 1);
                label0.Text = Convert.ToString(labelzero + 1);
                AssentosNome[7] = btnAssento8.Text;
            }

            if (label0.Text != "0")
            {
                BtnConfirmar.Visible = true;
            }
            else
            {
                BtnConfirmar.Visible = false;
            }
        }

        private void btnAssento9_Click(object sender, EventArgs e)
        {
            horarios.AssentosClicks6[8] = horarios.AssentosClicks6[8] + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (horarios.AssentosClicks6[8] % 2 == 0)
            {
                horarios.AssentosClicks6[8] = 0;
                btnAssento9.BackColor = Color.FromArgb(3, 171, 224);
                btnAssento9.Text = "";
                btnAssento9.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[8] = "";
            }
            else
            {
                btnAssento9.BackColor = Color.LimeGreen;
                btnAssento9.Text = "B3";
                btnAssento9.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos - 1);
                label0.Text = Convert.ToString(labelzero + 1);
                AssentosNome[8] = btnAssento9.Text;
            }

            if (label0.Text != "0")
            {
                BtnConfirmar.Visible = true;
            }
            else
            {
                BtnConfirmar.Visible = false;
            }
        }

        private void btnAssento10_Click(object sender, EventArgs e)
        {
            horarios.AssentosClicks6[9] = horarios.AssentosClicks6[9] + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (horarios.AssentosClicks6[9] % 2 == 0)
            {
                horarios.AssentosClicks6[9] = 0;
                btnAssento10.BackColor = Color.FromArgb(3, 171, 224);
                btnAssento10.Text = "";
                btnAssento10.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[9] = "";
            }
            else
            {
                btnAssento10.BackColor = Color.LimeGreen;
                btnAssento10.Text = "B4";
                btnAssento10.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos - 1);
                label0.Text = Convert.ToString(labelzero + 1);
                AssentosNome[9] = btnAssento10.Text;
            }

            if (label0.Text != "0")
            {
                BtnConfirmar.Visible = true;
            }
            else
            {
                BtnConfirmar.Visible = false;
            }
        }

        private void btnAssento11_Click(object sender, EventArgs e)
        {
            horarios.AssentosClicks6[10] = horarios.AssentosClicks6[10] + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (horarios.AssentosClicks6[10] % 2 == 0)
            {
                horarios.AssentosClicks6[10] = 0;
                btnAssento11.BackColor = Color.FromArgb(3, 171, 224);
                btnAssento11.Text = "";
                btnAssento11.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[10] = "";
            }
            else
            {
                btnAssento11.BackColor = Color.LimeGreen;
                btnAssento11.Text = "B5";
                btnAssento11.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos - 1);
                label0.Text = Convert.ToString(labelzero + 1);
                AssentosNome[10] = btnAssento11.Text;
            }

            if (label0.Text != "0")
            {
                BtnConfirmar.Visible = true;
            }
            else
            {
                BtnConfirmar.Visible = false;
            }
        }

        private void btnAssento12_Click(object sender, EventArgs e)
        {
            horarios.AssentosClicks6[11] = horarios.AssentosClicks6[11] + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (horarios.AssentosClicks6[11] % 2 == 0)
            {
                horarios.AssentosClicks6[11] = 0;
                btnAssento12.BackColor = Color.FromArgb(3, 171, 224);
                btnAssento12.Text = "";
                btnAssento12.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[11] = "";
            }
            else
            {
                btnAssento12.BackColor = Color.LimeGreen;
                btnAssento12.Text = "B6";
                btnAssento12.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos - 1);
                label0.Text = Convert.ToString(labelzero + 1);
                AssentosNome[11] = btnAssento12.Text;
            }

            if (label0.Text != "0")
            {
                BtnConfirmar.Visible = true;
            }
            else
            {
                BtnConfirmar.Visible = false;
            }
        }

        private void btnAssento13_Click(object sender, EventArgs e)
        {
            horarios.AssentosClicks6[12] = horarios.AssentosClicks6[12] + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (horarios.AssentosClicks6[12] % 2 == 0)
            {
                horarios.AssentosClicks6[12] = 0;
                btnAssento13.BackColor = Color.FromArgb(3, 171, 224);
                btnAssento13.Text = "";
                btnAssento13.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[12] = "";
            }
            else
            {
                horarios.AssentosClicks6[13] = 0;
                btnAssento13.BackColor = Color.LimeGreen;
                btnAssento13.Text = "C1";
                btnAssento13.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos - 1);
                label0.Text = Convert.ToString(labelzero + 1);
                AssentosNome[12] = btnAssento13.Text;
            }

            if (label0.Text != "0")
            {
                BtnConfirmar.Visible = true;
            }
            else
            {
                BtnConfirmar.Visible = false;
            }
        }

        private void btnAssento14_Click(object sender, EventArgs e)
        {
            horarios.AssentosClicks6[13] = horarios.AssentosClicks6[13] + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (horarios.AssentosClicks6[13] % 2 == 0)
            {
                horarios.AssentosClicks6[13] = 0;
                btnAssento14.BackColor = Color.FromArgb(3, 171, 224);
                btnAssento14.Text = "";
                btnAssento14.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[13] = "";
            }
            else
            {
                btnAssento14.BackColor = Color.LimeGreen;
                btnAssento14.Text = "C2";
                btnAssento14.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos - 1);
                label0.Text = Convert.ToString(labelzero + 1);
                AssentosNome[13] = btnAssento14.Text;
            }

            if (label0.Text != "0")
            {
                BtnConfirmar.Visible = true;
            }
            else
            {
                BtnConfirmar.Visible = false;
            }
        }

        private void btnAssento15_Click(object sender, EventArgs e)
        {
            horarios.AssentosClicks6[14] = horarios.AssentosClicks6[14] + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (horarios.AssentosClicks6[14] % 2 == 0)
            {
                horarios.AssentosClicks6[14] = 0;
                btnAssento15.BackColor = Color.FromArgb(3, 171, 224);
                btnAssento15.Text = "";
                btnAssento15.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[14] = "";
            }
            else
            {
                btnAssento15.BackColor = Color.LimeGreen;
                btnAssento15.Text = "C3";
                btnAssento15.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos - 1);
                label0.Text = Convert.ToString(labelzero + 1);
                AssentosNome[14] = btnAssento15.Text;
            }

            if (label0.Text != "0")
            {
                BtnConfirmar.Visible = true;
            }
            else
            {
                BtnConfirmar.Visible = false;
            }
        }

        private void btnAssento16_Click(object sender, EventArgs e)
        {
            horarios.AssentosClicks6[15] = horarios.AssentosClicks6[15] + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (horarios.AssentosClicks6[15] % 2 == 0)
            {
                horarios.AssentosClicks6[15] = 0;
                btnAssento16.BackColor = Color.FromArgb(3, 171, 224);
                btnAssento16.Text = "";
                btnAssento16.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[15] = "";
            }
            else
            {
                btnAssento16.BackColor = Color.LimeGreen;
                btnAssento16.Text = "C4";
                btnAssento16.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos - 1);
                label0.Text = Convert.ToString(labelzero + 1);
                AssentosNome[15] = btnAssento16.Text;
            }

            if (label0.Text != "0")
            {
                BtnConfirmar.Visible = true;
            }
            else
            {
                BtnConfirmar.Visible = false;
            }
        }

        private void btnAssento17_Click(object sender, EventArgs e)
        {
            horarios.AssentosClicks6[16] = horarios.AssentosClicks6[16] + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (horarios.AssentosClicks6[16] % 2 == 0)
            {
                horarios.AssentosClicks6[16] = 0;
                btnAssento17.BackColor = Color.FromArgb(3, 171, 224);
                btnAssento17.Text = "";
                btnAssento17.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[16] = "";
            }
            else
            {
                btnAssento17.BackColor = Color.LimeGreen;
                btnAssento17.Text = "C5";
                btnAssento17.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos - 1);
                label0.Text = Convert.ToString(labelzero + 1);
                AssentosNome[16] = btnAssento17.Text;
            }

            if (label0.Text != "0")
            {
                BtnConfirmar.Visible = true;
            }
            else
            {
                BtnConfirmar.Visible = false;
            }
        }

        private void btnAssento18_Click(object sender, EventArgs e)
        {
            horarios.AssentosClicks6[17] = horarios.AssentosClicks6[17] + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (horarios.AssentosClicks6[17] % 2 == 0)
            {
                horarios.AssentosClicks6[17] = 0;
                btnAssento18.BackColor = Color.FromArgb(3, 171, 224);
                btnAssento18.Text = "";
                btnAssento18.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[17] = "";
            }
            else
            {
                btnAssento18.BackColor = Color.LimeGreen;
                btnAssento18.Text = "C6";
                btnAssento18.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos - 1);
                label0.Text = Convert.ToString(labelzero + 1);
                AssentosNome[17] = btnAssento18.Text;
            }

            if (label0.Text != "0")
            {
                BtnConfirmar.Visible = true;
            }
            else
            {
                BtnConfirmar.Visible = false;
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            Form f4 = new InteiraMeia(label0.Text, nomefilme, cartaz, AssentosNome);
            f4.Location = this.Location;
            f4.StartPosition = FormStartPosition.Manual;
            f4.FormClosing += delegate { this.Show(); };
            f4.Show();
            this.Hide();
        }


    }
}
