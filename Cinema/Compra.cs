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
            if (label1.Text == "0")
            {
                button1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int labelIn = Convert.ToInt32(labelInt.Text);
            int limite = Convert.ToInt32(label1.Text);
            if (labelIn > 0)
            {
                labelInt.Text = Convert.ToString(labelIn - 1);
                label1.Text = Convert.ToString(limite + 1);
            }
            else
            {
                labelIn = 0;
                labelInt.Text = Convert.ToString(labelIn);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int labelIn = Convert.ToInt32(labelInt.Text);
            int limite = Convert.ToInt32(label1.Text);
            if (limite == 0)
            {
                labelInt.Text = Convert.ToString(labelIn);
            }
            else
            {
                label1.Text = Convert.ToString(limite - 1);
                labelInt.Text = Convert.ToString(labelIn + 1);
            }
        }

        private void butPlus2_Click(object sender, EventArgs e)
        {
            int labelMe = Convert.ToInt32(labelMeia.Text);
            int limite = Convert.ToInt32(label1.Text);
            if (limite == 0)
            {
                labelMeia.Text = Convert.ToString(labelMe);
            }
            else
            {
                labelMeia.Text = Convert.ToString(labelMe + 1);
                label1.Text = Convert.ToString(limite - 1);

            }
        }

        private void butLow2_Click(object sender, EventArgs e)
        {
            int labelMe = Convert.ToInt32(labelMeia.Text);
            int limite = Convert.ToInt32(label1.Text);
            if (labelMe > 0)
            {
                labelMeia.Text = Convert.ToString(labelMe - 1);
                label1.Text = Convert.ToString(limite + 1);
            }
            else
            {
                labelMe = 0;
                labelMeia.Text = Convert.ToString(labelMe);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }
    }
}
