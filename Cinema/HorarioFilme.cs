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
    public partial class HorarioFilme : Form
    {
        public HorarioFilme()
        {
            InitializeComponent();
        }


        Filmes filme1 = new Filmes("Duna", "Paul Atreides é um jovem brilhante, dono de um destino além de sua compreensão." + "\n" +
                "Ele deve viajar para o planeta mais perigoso do universo para garantir o futuro de seu povo.", 14, "Ficção Cientifica", "Aventura",
            "2h35h", Cinema.Properties.Resources.Filme_dune);

        Filmes filme2 = new Filmes("Batman vs Superman: A Origem da Justiça", "O implacável vigilante de Gotham City, preocupado com as ações de um super-herói com poderes" + "\n" +
                "quase divinos e sem restrições, enfrenta o mais adorado salvador de Metrópolis, enquanto todos se" + "\n" +
                "questionam sobre o tipo de herói que o mundo realmente precisa. ", 12, "Ação", "Aventura",
            "2h 31m", Cinema.Properties.Resources.filmebat);

        Filmes filme3 = new Filmes("Marjorie Prime", "Em um futuro próximo, um tempo de inteligência artificial, Marjorie descobre que sua memória" + "\n" +
                "está começando a falhar. A violinista de 85 anos passa a maior parte do tempo com a sua filha Tess," + "\n" +
                "o marido desta e a cópia imperfeita do seu falecido esposo, uma versão artificial de Walter especialmente" + "\n" + "programada para fazer com que Marjorie lembre a história da sua vida. ",
                    14, "Ficção Cientifica", "Drama", "1h39m", Cinema.Properties.Resources.marjorie_filme);

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HorarioFilme_Load(object sender, EventArgs e)
        {
            LabelNameFilme.Text = filme1.GetNome;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSeg_Click(object sender, EventArgs e)
        {
           
        }

        private void LabelCompre1_Click(object sender, EventArgs e)
        {
            Form f3 = new Assentos();
            f3.Location = this.Location;
            f3.StartPosition = FormStartPosition.Manual;
            f3.FormClosing += delegate { this.Show(); };
            f3.Show();
            this.Hide();
        }
    }
}
