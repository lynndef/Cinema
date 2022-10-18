using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class MainMenu : Form
    { 

        public MainMenu()
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

        private void imgFilme1_Click(object sender, EventArgs e)
        {

            ImgFilmes.BackgroundImage = filme1.GetCartaz;
            LabelNomeFilme.Text = filme1.GetNome;
            PanelLine1.Visible = true;
            PanelLine1.Size = new Size(138, 4);
            labelSinopse.Text = filme1.GetSinopse;
            labelSinopse.Visible = true;
            PanelLine2.Visible = true;
            labelCaracteristicas.Text = "Classificação " + filme1.GetClassificacao + " anos/ " + filme1.GetGenero1 + "/ " + filme1.GetGenero2 + "/ " + filme1.GetDuracao;
            labelCaracteristicas.Visible = true;
        }


        private void ImgFilme2_Click(object sender, EventArgs e)
        {

            ImgFilmes.BackgroundImage = filme2.GetCartaz;
            LabelNomeFilme.Text = filme2.GetNome;
            PanelLine1.Visible = true;
            PanelLine1.Size = new Size(463, 4);
            labelSinopse.Text = filme2.GetSinopse;
            labelSinopse.Visible = true;
            labelCaracteristicas.Text = "Classificação " + filme2.GetClassificacao + " anos/ " + filme2.GetGenero1 + "/ " + filme2.GetGenero2 + "/ " + filme2.GetDuracao;
            labelCaracteristicas.Visible = true;
            PanelLine2.Visible = true;

        }

        private void ImgFilme3_Click(object sender, EventArgs e)
        {

            ImgFilmes.BackgroundImage = filme3.GetCartaz;
            LabelNomeFilme.Text = filme3.GetNome;
            PanelLine1.Visible = true;
            PanelLine1.Size = new Size(222, 4);
            labelSinopse.Text = filme3.GetSinopse;
            labelSinopse.Visible = true;
            labelCaracteristicas.Text = "Classificação " + filme3.GetClassificacao + " anos/ " + filme3.GetGenero1 + "/ " + filme3.GetGenero2 + "/ " + filme3.GetDuracao;
            labelCaracteristicas.Visible = true;
            PanelLine2.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ImgFilmes_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
