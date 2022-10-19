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

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
