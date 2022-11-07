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
    public partial class Assentos : Form
    {
        public Assentos()
        {
            InitializeComponent();
        }

        public Assentos(Image cartaz)
        {
            InitializeComponent();
            this.cartaz = cartaz;
        }

        Horarios horarios;

        public Assentos(Image cartaz, string nomefilme, Horarios horarios) : this(cartaz)
        {
            this.nomefilme = nomefilme;
            this.horarios = horarios;
        }

        String[] AssentosNome = new string[18];

        int TimesClicked = 0;
        int TimesClicked2 = 0;
        int TimesClicked3 = 0;
        int TimesClicked4 = 0;
        int TimesClicked5 = 0;
        int TimesClicked6 = 0;
        int TimesClicked7 = 0;
        int TimesClicked8 = 0;
        int TimesClicked9 = 0;
        int TimesClicked10 = 0;
        int TimesClicked11 = 0;
        int TimesClicked12 = 0;
        int TimesClicked13 = 0;
        int TimesClicked14 = 0;
        int TimesClicked15 = 0;
        int TimesClicked16 = 0;
        int TimesClicked17 = 0;
        int TimesClicked18 = 0;

        private Image cartaz;
        private string nomefilme;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAssento1_Click(object sender, EventArgs e)
        {
            horarios.TimesClicked = horarios.TimesClicked + 1;


            TimesClicked = TimesClicked + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (TimesClicked % 2 == 0)
            {
                btnAssento1.BackColor = Color.LimeGreen;
                btnAssento1.Text = "";
                btnAssento1.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[0] = "";

            }
            else
            {
                btnAssento1.BackColor = Color.Red;
                btnAssento1.Text = "A1";
                btnAssento1.ForeColor = Color.White;
                LabelNassentos.Text = Convert.ToString(nAssentos - 1);
                label0.Text = Convert.ToString(labelzero + 1);
                AssentosNome[0] = "A1";

            }

            if(label0.Text != "0")
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

            TimesClicked2 = TimesClicked2 + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (TimesClicked2 % 2 == 0)
            {
                btnAssento2.BackColor = Color.LimeGreen;
                btnAssento2.Text = "";
                btnAssento2.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[1] = "";
            }
            else
            {
                btnAssento2.BackColor = Color.Red;
                btnAssento2.Text = "A2";
                btnAssento2.ForeColor = Color.White;
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

            TimesClicked3 = TimesClicked3 + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (TimesClicked3 % 2 == 0)
            {
                btnAssento3.BackColor = Color.LimeGreen;
                btnAssento3.Text = "";
                btnAssento3.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[2] = "";
            }
            else
            {
                btnAssento3.BackColor = Color.Red;
                btnAssento3.Text = "A3";
                btnAssento3.ForeColor = Color.White;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Assentos_Load(object sender, EventArgs e)
        {
            ImgCartaz.BackgroundImage = cartaz;
            LabelNome.Text = nomefilme;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAssento4_Click(object sender, EventArgs e)
        {
            TimesClicked4 = TimesClicked4 + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (TimesClicked4 % 2 == 0)
            {
                btnAssento4.BackColor = Color.LimeGreen;
                btnAssento4.Text = "";
                btnAssento4.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[3] = "";
            }
            else
            {
                btnAssento4.BackColor = Color.Red;
                btnAssento4.Text = "A4";
                btnAssento4.ForeColor = Color.White;
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
            TimesClicked5 = TimesClicked5 + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (TimesClicked5 % 2 == 0)
            {
                btnAssento5.BackColor = Color.LimeGreen;
                btnAssento5.Text = "";
                btnAssento5.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[4] = "";
            }
            else
            {
                btnAssento5.BackColor = Color.Red;
                btnAssento5.Text = "A5";
                btnAssento5.ForeColor = Color.White;
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
            TimesClicked6 = TimesClicked6 + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (TimesClicked6 % 2 == 0)
            {
                btnAssento6.BackColor = Color.LimeGreen;
                btnAssento6.Text = "";
                btnAssento6.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[5] = "";
            }
            else
            {
                btnAssento6.BackColor = Color.Red;
                btnAssento6.Text = "A6";
                btnAssento6.ForeColor = Color.White;
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
            TimesClicked7 = TimesClicked7 + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (TimesClicked7 % 2 == 0)
            {
                btnAssento7.BackColor = Color.LimeGreen;
                btnAssento7.Text = "";
                btnAssento7.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[6] = "";
            }
            else
            {
                btnAssento7.BackColor = Color.Red;
                btnAssento7.Text = "B1";
                btnAssento7.ForeColor = Color.White;
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
            TimesClicked8 = TimesClicked8 + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (TimesClicked8 % 2 == 0)
            {
                btnAssento8.BackColor = Color.LimeGreen;
                btnAssento8.Text = "";
                btnAssento8.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[7] = "";
            }
            else
            {
                btnAssento8.BackColor = Color.Red;
                btnAssento8.Text = "B2";
                btnAssento8.ForeColor = Color.White;
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
            TimesClicked9 = TimesClicked9 + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (TimesClicked9 % 2 == 0)
            {
                btnAssento9.BackColor = Color.LimeGreen;
                btnAssento9.Text = "";
                btnAssento9.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[8] = "";
            }
            else
            {
                btnAssento9.BackColor = Color.Red;
                btnAssento9.Text = "B3";
                btnAssento9.ForeColor = Color.White;
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
            TimesClicked10 = TimesClicked10 + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (TimesClicked10 % 2 == 0)
            {
                btnAssento10.BackColor = Color.LimeGreen;
                btnAssento10.Text = "";
                btnAssento10.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[9] = "";
            }
            else
            {
                btnAssento10.BackColor = Color.Red;
                btnAssento10.Text = "B4";
                btnAssento10.ForeColor = Color.White;
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
            TimesClicked11 = TimesClicked11 + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (TimesClicked11 % 2 == 0)
            {
                btnAssento11.BackColor = Color.LimeGreen;
                btnAssento11.Text = "";
                btnAssento11.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[10] = "";
            }
            else
            {
                btnAssento11.BackColor = Color.Red;
                btnAssento11.Text = "B5";
                btnAssento11.ForeColor = Color.White;
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
            TimesClicked12 = TimesClicked12 + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (TimesClicked12 % 2 == 0)
            {
                btnAssento12.BackColor = Color.LimeGreen;
                btnAssento12.Text = "";
                btnAssento12.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[11] = "";
            }
            else
            {
                btnAssento12.BackColor = Color.Red;
                btnAssento12.Text = "B6";
                btnAssento12.ForeColor = Color.White;
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
            TimesClicked13 = TimesClicked13 + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (TimesClicked13 % 2 == 0)
            {
                btnAssento13.BackColor = Color.LimeGreen;
                btnAssento13.Text = "";
                btnAssento13.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[12] = "";
            }
            else
            {
                btnAssento13.BackColor = Color.Red;
                btnAssento13.Text = "C1";
                btnAssento13.ForeColor = Color.White;
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
            TimesClicked14 = TimesClicked14 + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (TimesClicked14 % 2 == 0)
            {
                btnAssento14.BackColor = Color.LimeGreen;
                btnAssento14.Text = "";
                btnAssento14.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[13] = "";
            }
            else
            {
                btnAssento14.BackColor = Color.Red;
                btnAssento14.Text = "C2";
                btnAssento14.ForeColor = Color.White;
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
            TimesClicked15 = TimesClicked15 + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (TimesClicked15 % 2 == 0)
            {
                btnAssento15.BackColor = Color.LimeGreen;
                btnAssento15.Text = "";
                btnAssento15.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[14] = "";
            }
            else
            {
                btnAssento15.BackColor = Color.Red;
                btnAssento15.Text = "C3";
                btnAssento15.ForeColor = Color.White;
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
            TimesClicked16 = TimesClicked16 + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (TimesClicked16 % 2 == 0)
            {
                btnAssento16.BackColor = Color.LimeGreen;
                btnAssento16.Text = "";
                btnAssento16.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[15] = "";
            }
            else
            {
                btnAssento16.BackColor = Color.Red;
                btnAssento16.Text = "C4";
                btnAssento16.ForeColor = Color.White;
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
            TimesClicked17 = TimesClicked17 + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (TimesClicked17 % 2 == 0)
            {
                btnAssento17.BackColor = Color.LimeGreen;
                btnAssento17.Text = "";
                btnAssento17.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[16] = "";
            }
            else
            {
                btnAssento17.BackColor = Color.Red;
                btnAssento17.Text = "C5";
                btnAssento17.ForeColor = Color.White;
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
            TimesClicked18 = TimesClicked18 + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (TimesClicked18 % 2 == 0)
            {
                btnAssento18.BackColor = Color.LimeGreen;
                btnAssento18.Text = "";
                btnAssento18.ForeColor = Color.Black;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
                AssentosNome[17] = "";
            }
            else
            {
                btnAssento18.BackColor = Color.Red;
                btnAssento18.Text = "C6";
                btnAssento18.ForeColor = Color.White;
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
