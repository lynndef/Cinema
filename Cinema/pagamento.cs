using Cinema.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Pagamento : Form
    {
        private string nomefilme;
        private Image cartaz;
        private string[] assentosNome;

        public Pagamento()
        {
            InitializeComponent();
        }

        public Pagamento(string nomefilme, Image cartaz, string[] assentosNome)
        {
            InitializeComponent();
            this.nomefilme = nomefilme;
            this.cartaz = cartaz;
            this.assentosNome = assentosNome;
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

            labelcpf.Visible = false;
            labelpix.Visible = false;
            textBox1.Visible = false;
            label4.Visible = true;
            ComboCard.Visible = true;
            imgCartao.Visible = false;
            textBox1.Location = new Point(875, 444);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            labelpix.Visible = false;
            textBox1.Visible = false; 
            label4.Visible = false;
            ComboCard.Visible = false;
            labelcpf.Visible = true;
            textBox1.Visible = true;
            imgCartao.Visible = false;
            textBox1.Location = new Point(875, 444);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           label4.Visible = false;
           ComboCard.Visible = false;
           labelcpf.Visible = false;
           labelpix.Visible = true;
           textBox1.Visible = true;
           imgCartao.Visible = false;
           textBox1.Location = new Point(875, 444);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

            if(textBox1.Text.Length == 16)
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
            Form f4 = new FinalizarPedido(textBox1.Text, nomefilme, cartaz, assentosNome);
            f4.Location = this.Location;
            f4.StartPosition = FormStartPosition.CenterScreen;
            
            f4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void ComboCard_SelectedIndexChanged(object sender, EventArgs e)
        {
                if(ComboCard.SelectedIndex == 0)
            {
                imgCartao.Visible = true;
                imgCartao.BackgroundImage = Cinema.Properties.Resources.Visa_logo;
                textBox1.Visible = true;
                textBox1.Location = new Point(870, 507);
            }
            else if(ComboCard.SelectedIndex == 1)
            {
                imgCartao.Visible = true;
                imgCartao.BackgroundImage = Cinema.Properties.Resources.MasterCard_Logo;
                textBox1.Visible = true;
                textBox1.Location = new Point(870, 507);
            }
            else if(ComboCard.SelectedIndex == 2)
            {
                imgCartao.Visible = true;
                imgCartao.BackgroundImage = Cinema.Properties.Resources.elo_logo2;
                textBox1.Visible = true;
                textBox1.Location = new Point(870, 507);

            }
            else if(ComboCard.SelectedIndex == 3)
            {
                imgCartao.Visible = true;
                imgCartao.BackgroundImage = Cinema.Properties.Resources.banco_do_brasil_logo;
                textBox1.Visible = true;
                textBox1.Location = new Point(870, 507);
            }

        }

        private void imgCartao_Click(object sender, EventArgs e)
        {
            
        }
    }
}

// os verdadeiros labels são os amigos que fazemos pelo caminho