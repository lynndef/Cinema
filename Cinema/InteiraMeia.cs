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
    public partial class InteiraMeia : Form
    {
        private Image cartaz;
        private string nomefilme;
        private string[] assentosNome;
        private string sessao;

        public InteiraMeia()
        { 
            InitializeComponent();
        }

        public InteiraMeia(string text, string nomefilme, Image cartaz, string[] assentosNome)
        {
            InitializeComponent();
            Text = text;
            this.nomefilme = nomefilme;
            this.cartaz = cartaz;
            this.assentosNome = assentosNome;
        }

        public InteiraMeia(string sessao, string text, string nomefilme, Image cartaz, string[] assentosNome)
        {
            this.sessao = sessao;
            Text = text;
            this.nomefilme = nomefilme;
            this.cartaz = cartaz;
            this.assentosNome = assentosNome;
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            label1.Text = Text;
            ImgFilme.BackgroundImage = cartaz;
            labelnome.Text = nomefilme;

            labeltitulo.Parent = imgpanel;
            labeltitulo.BackColor = Color.Transparent;

            labelpagamento.Parent = imgPagamento;
            labelpagamento.BackColor = Color.Transparent;

          
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inteira = Convert.ToInt32(labelInt.Text);
            int ingressos = Convert.ToInt32(label1.Text);
            int valor = Convert.ToInt32(labelvalor.Text);

            if (inteira > 0)
            {
                labelInt.Text = Convert.ToString(inteira - 1);
                label1.Text = Convert.ToString(ingressos + 1);
                labelvalor.Text = Convert.ToString(valor - 20);
            }
            else
            {
                inteira = 0;
                labelInt.Text = Convert.ToString(inteira);
            }

            if (label1.Text != "0")
            {
                BtnProsseguir.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int inteira = Convert.ToInt32(labelInt.Text);
            int ingressos = Convert.ToInt32(label1.Text);
            int valor = Convert.ToInt32(labelvalor.Text);

            if (ingressos == 0)
            {
                labelInt.Text = Convert.ToString(inteira);
            }
            else
            {
                label1.Text = Convert.ToString(ingressos - 1);
                labelInt.Text = Convert.ToString(inteira + 1);
                labelvalor.Text = Convert.ToString(valor + 20);
            }

            if (label1.Text == "0" && textBox1.Text.Length == 16)
            {
                BtnProsseguir.Visible = true;
            }
         
        }

        private void butPlus2_Click(object sender, EventArgs e)
        {
            int labelMe = Convert.ToInt32(labelMeia.Text);
            int ingressos = Convert.ToInt32(label1.Text);
            int valor = Convert.ToInt32(labelvalor.Text);

            if (ingressos == 0)
            {
                labelMeia.Text = Convert.ToString(labelMe);
                
            }
            else
            {
                labelMeia.Text = Convert.ToString(labelMe + 1);
                label1.Text = Convert.ToString(ingressos - 1);
                labelvalor.Text = Convert.ToString(valor + 10);

            }

            if (label1.Text == "0" && textBox1.Text.Length == 16)
            {
                BtnProsseguir.Visible = true;
            }
            
        }

        private void butLow2_Click(object sender, EventArgs e)
        {
            int labelMe = Convert.ToInt32(labelMeia.Text);
            int ingressos = Convert.ToInt32(label1.Text);
            int valor = Convert.ToInt32(labelvalor.Text);

            if (labelMe > 0)
            {
                labelMeia.Text = Convert.ToString(labelMe - 1);
                label1.Text = Convert.ToString(ingressos + 1);
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

            Form f5 = new FinalizarPedido( textBox1.Text, nomefilme, cartaz, assentosNome);
            f5.Location = this.Location;
            f5.StartPosition = FormStartPosition.CenterScreen;
            f5.FormClosing += delegate { this.Show(); };
            f5.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void imgInt_Click(object sender, EventArgs e)
        {
            
        }

        private void labelInt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            labelcpf.Visible = false;
            labelpix.Visible = false;
            textBox1.Visible = false;
            label4.Visible = true;
            ComboCard.Visible = true;
            imgCartao.Visible = false;
            textBox1.Location = new Point(982, 658);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            labelpix.Visible = false;
            textBox1.Visible = false;
            label4.Visible = false;
            ComboCard.Visible = false;
            labelcpf.Visible = true;
            textBox1.Visible = true;
            imgCartao.Visible = false;
            textBox1.Location = new Point(982, 658);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            label4.Visible = false;
            ComboCard.Visible = false;
            labelcpf.Visible = false;
            labelpix.Visible = true;
            textBox1.Visible = true;
            imgCartao.Visible = false;
            textBox1.Location = new Point(982, 658);
        }

        private void ComboCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboCard.SelectedIndex == 0)
            {
                imgCartao.Visible = true;
                imgCartao.BackgroundImage = Cinema.Properties.Resources.Visa_logo;
                textBox1.Visible = true;
                textBox1.Location = new Point(982, 720);
            }
            else if (ComboCard.SelectedIndex == 1)
            {
                imgCartao.Visible = true;
                imgCartao.BackgroundImage = Cinema.Properties.Resources.MasterCard_Logo;
                textBox1.Visible = true;
                textBox1.Location = new Point(982, 720);
            }
            else if (ComboCard.SelectedIndex == 2)
            {
                imgCartao.Visible = true;
                imgCartao.BackgroundImage = Cinema.Properties.Resources.elo_logo2;
                textBox1.Visible = true;
                textBox1.Location = new Point(982, 720);

            }
            else if (ComboCard.SelectedIndex == 3)
            {
                imgCartao.Visible = true;
                imgCartao.BackgroundImage = Cinema.Properties.Resources.banco_do_brasil_logo;
                textBox1.Visible = true;
                textBox1.Location = new Point(982, 720);
            }
        }

        private void labelpagamento_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 16)
            {
                BtnProsseguir.Visible = true;
            }
            else
            {
                BtnProsseguir.Visible = false;
            }
        }
    }
}
