﻿using System;
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
    public partial class HorarioFilme : Form
    {
        public HorarioFilme()
        {
            InitializeComponent();
        }

        public HorarioFilme(string nomefilme)
        {
            InitializeComponent();
            this.nomefilme = nomefilme;
        }

        public HorarioFilme(string nomefilme, Image cartaz) : this(nomefilme)
        {
            this.cartaz = cartaz;
        }

        private string nomefilme;
        private Image cartaz;

    
        private void HorarioFilme_Load(object sender, EventArgs e)
        {
            LabelNameFilme.Text = nomefilme;

            if (LabelNameFilme.Text == "Adão Negro")
            {
                CompreF1H1.Visible = true;
                CompreF1H2.Visible = true;
            }
            else if (LabelNameFilme.Text == "Orfã 2")
            {
                CompreF2H1.Visible = true;
                CompreF2H2.Visible = true;
            }
            else if (LabelNameFilme.Text == "Minions 2")
            {
                CompreF3H1.Visible = true;
                CompreF3H2.Visible = true;
            }

        }


        private void LabelCompre1_Click(object sender, EventArgs e)
        {

            int n1 = 1;

            Form f3 = new Assentos(cartaz, nomefilme, ControleAssentos.Seg.AdaoSala1_10h30, n1); //
            f3.Location = this.Location;
            f3.StartPosition = FormStartPosition.Manual;
            f3.FormClosing += delegate { this.Show(); };
            f3.Show();
            this.Hide();

            
        }

        private void CompreF1H2_Click(object sender, EventArgs e)
        {
            int n1 = 2;

            Form f3 = new Assentos(cartaz, nomefilme, ControleAssentos.Seg.AdaoSala1_13h30, n1);
            f3.Location = this.Location;
            f3.StartPosition = FormStartPosition.Manual;
            f3.FormClosing += delegate { this.Show(); };
            f3.Show();
            this.Hide();

        }

    }
}
