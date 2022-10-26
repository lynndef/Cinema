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
    public partial class pagamento : Form
    {
        public pagamento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pagamento_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            textBox2.Visible = true;
            textSeta.Visible = true;
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            label2.Visible = false;
            textBox1.Visible = false; 
            label4.Visible = false;
            textSeta.Visible = false;
            label3.Visible = true;
            textBox2.Visible = true;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           label4.Visible = false;
           textSeta.Visible = false;
           label3.Visible = false;
           textBox2.Visible = false;
           label2.Visible = true;
           textBox1.Visible = true;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

// os verdadeiros labels são os amigos que a gente faz pelo caminho