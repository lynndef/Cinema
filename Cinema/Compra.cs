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
    public partial class Compra : Form
    {
        public Compra()
        { 
            InitializeComponent();
        }

        public Compra(string text)
        {
            InitializeComponent();
            Text = text;
            
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            label1.Text = Text;

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int labelIn = Convert.ToInt32(labelInt.Text);
            int limite = Convert.ToInt32(label1.Text);
            int valor = Convert.ToInt32(labelvalor.Text);

            if (labelIn > 0)
            {
                labelInt.Text = Convert.ToString(labelIn - 1);
                label1.Text = Convert.ToString(limite + 1);
                labelvalor.Text = Convert.ToString(valor - 20);
            }
            else
            {
                labelIn = 0;
                labelInt.Text = Convert.ToString(labelIn);
            }

            if (label1.Text != "0")
            {
                BtnProsseguir.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int labelIn = Convert.ToInt32(labelInt.Text);
            int limite = Convert.ToInt32(label1.Text);
            int valor = Convert.ToInt32(labelvalor.Text);

            if (limite == 0)
            {
                labelInt.Text = Convert.ToString(labelIn);
            }
            else
            {
                label1.Text = Convert.ToString(limite - 1);
                labelInt.Text = Convert.ToString(labelIn + 1);
                labelvalor.Text = Convert.ToString(valor + 20);
            }

            if (label1.Text == "0")
            {
                BtnProsseguir.Visible = true;
            }
         
        }

        private void butPlus2_Click(object sender, EventArgs e)
        {
            int labelMe = Convert.ToInt32(labelMeia.Text);
            int limite = Convert.ToInt32(label1.Text);
            int valor = Convert.ToInt32(labelvalor.Text);

            if (limite == 0)
            {
                labelMeia.Text = Convert.ToString(labelMe);
                
            }
            else
            {
                labelMeia.Text = Convert.ToString(labelMe + 1);
                label1.Text = Convert.ToString(limite - 1);
                labelvalor.Text = Convert.ToString(valor + 10);

            }

            if (label1.Text == "0")
            {
                BtnProsseguir.Visible = true;
            }
            
        }

        private void butLow2_Click(object sender, EventArgs e)
        {
            int labelMe = Convert.ToInt32(labelMeia.Text);
            int limite = Convert.ToInt32(label1.Text);
            int valor = Convert.ToInt32(labelvalor.Text);

            if (labelMe > 0)
            {
                labelMeia.Text = Convert.ToString(labelMe - 1);
                label1.Text = Convert.ToString(limite + 1);
                labelvalor.Text = Convert.ToString(valor - 10);
            }
            else
            {
                labelMe = 0;
                labelMeia.Text = Convert.ToString(labelMe);
            }

            if (label1.Text != "0")
            {
                BtnProsseguir.Visible = false;
            }   
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form f5 = new pagamento();
            f5.Location = this.Location;
            f5.StartPosition = FormStartPosition.Manual;
            f5.FormClosing += delegate { this.Show(); };
            f5.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
