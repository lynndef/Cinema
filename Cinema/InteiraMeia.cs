﻿using System;
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

        private void Compra_Load(object sender, EventArgs e)
        {
            label1.Text = Text;
            ImgFilme.BackgroundImage = cartaz;
            labelnome.Text = nomefilme;
             
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

            if (label1.Text == "0")
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

            if (label1.Text == "0")
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
            Form f5 = new Pagamento(nomefilme, cartaz, assentosNome);
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