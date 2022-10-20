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
    public partial class Assentos : Form
    {
        public Assentos()
        {
            InitializeComponent();
        }

        int TimesClicked = 0;
        int TimesClicked2 = 0;
        int TimesClicked3 = 0;
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAssento1_Click(object sender, EventArgs e)
        {

            TimesClicked = TimesClicked + 1;
            int nAssentos = Convert.ToInt32(LabelNassentos.Text);
            int labelzero = Convert.ToInt32(label0.Text);

            if (TimesClicked % 2 == 0)
            {
                btnAssento1.BackColor = Color.LimeGreen;
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
            }
            else
            {
                btnAssento1.BackColor = Color.Red;
                LabelNassentos.Text = Convert.ToString(nAssentos - 1);
                label0.Text = Convert.ToString(labelzero + 1);
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
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
            }
            else
            {
                btnAssento2.BackColor = Color.Red;
                LabelNassentos.Text = Convert.ToString(nAssentos - 1);
                label0.Text = Convert.ToString(labelzero + 1);
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
                LabelNassentos.Text = Convert.ToString(nAssentos + 1);
                label0.Text = Convert.ToString(labelzero - 1);
            }
            else
            {
                btnAssento3.BackColor = Color.Red;
                LabelNassentos.Text = Convert.ToString(nAssentos - 1);
                label0.Text = Convert.ToString(labelzero + 1);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void labelConfirmar_Click(object sender, EventArgs e)
        {
            


            Form f4 = new Compra(label0.Text);
            f4.Location = this.Location;
            f4.StartPosition = FormStartPosition.Manual;
            f4.FormClosing += delegate { this.Show(); };
            f4.Show();
            this.Hide();
             
                

        }

        private void Assentos_Load(object sender, EventArgs e)
        {

        }
    }
}
