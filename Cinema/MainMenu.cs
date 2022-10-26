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

        Filmes filme1 = new Filmes("Adão Negro", "O poderoso Adão Negro é libertado de sua tumba para lançar sua justiça cruel sob a Terra.", 14, "Ação", "Fantasia",
            "2h 05m", Cinema.Properties.Resources.Filme_adao_negro);

        Filmes filme2 = new Filmes("Orfã 2", "A aterradora saga de Esther continua nesta emocionante prequela, Órfã. Depois de planear uma brilhante fuga" + "\n" + 
            "de um hospital psiquiátrico na Estónia, Esther viaja até a América passando-se pela filha desaparecida de uma" + "\n" + 
            "família milionária. No entanto, após uma inesperada reviravolta, a mãe começa a desconfiar da criança assassina, " + "\n " + "e tudo faz para proteger a sua família. ", 12, " Terror", "Thriller",
            "1h 39m", Cinema.Properties.Resources.filme_orfa2);

        Filmes filme3 = new Filmes("Minions 2", "Nos anos 1970, o jovem Gru tenta entrar para um time de supervilões, mas a entrevista é desastrosa e ele" +"\n"+
            "e seus minions acabam fugindo do grupo de mal-feitores. ",
                    14, "Comédia", "Aventura", "1h 30m", Cinema.Properties.Resources.Filme_minons22);

        private void imgFilme1_Click(object sender, EventArgs e)
        {

            ImgFilmes.BackgroundImage = filme1.GetCartaz;
            LabelNomeFilme.Text = filme1.GetNome;
            PanelLine1.Visible = true;
            PanelLine1.Size = new Size(195, 4);
            labelSinopse.Text = filme1.GetSinopse;
            labelSinopse.Visible = true;
            PanelLine2.Visible = true;
            labelCaracteristicas.Text = "Classificação " + filme1.GetClassificacao + " anos/ " + filme1.GetGenero1 + "/ " + filme1.GetGenero2 + "/ " + filme1.GetDuracao;
            labelCaracteristicas.Visible = true;
            labelhoraio.Visible = true;
        }


        private void ImgFilme2_Click(object sender, EventArgs e)
        {

            ImgFilmes.BackgroundImage = filme2.GetCartaz;
            LabelNomeFilme.Text = filme2.GetNome;
            PanelLine1.Visible = true;
            PanelLine1.Size = new Size(155, 4);
            labelSinopse.Text = filme2.GetSinopse;
            labelSinopse.Visible = true;
            labelCaracteristicas.Text = "Classificação " + filme2.GetClassificacao + " anos/ " + filme2.GetGenero1 + "/ " + filme2.GetGenero2 + "/ " + filme2.GetDuracao;
            labelCaracteristicas.Visible = true;
            PanelLine2.Visible = true;
            labelhoraio.Visible = true;

        }

        private void ImgFilme3_Click(object sender, EventArgs e)
        {

            ImgFilmes.BackgroundImage = filme3.GetCartaz;
            LabelNomeFilme.Text = filme3.GetNome;
            PanelLine1.Visible = true;
            PanelLine1.Size = new Size(190, 4);
            labelSinopse.Text = filme3.GetSinopse;
            labelSinopse.Visible = true;
            labelCaracteristicas.Text = "Classificação " + filme3.GetClassificacao + " anos/ " + filme3.GetGenero1 + "/ " + filme3.GetGenero2 + "/ " + filme3.GetDuracao;
            labelCaracteristicas.Visible = true;
            PanelLine2.Visible = true;
            labelhoraio.Visible = true;
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

        private void labelhoraio_Click(object sender, EventArgs e)
        {
            string nomefilme = "";

            if(ImgFilmes.BackgroundImage == filme1.GetCartaz)
            {
                nomefilme = filme1.GetNome;
            }
            else if(ImgFilmes.BackgroundImage == filme2.GetCartaz)
            {
                nomefilme = filme2.GetNome;
            }
            else if(ImgFilmes.BackgroundImage == filme3.GetCartaz)
            {
                nomefilme = filme3.GetNome;
            }

            Form f2 = new HorarioFilme(nomefilme);
            f2.Location = this.Location;
            f2.StartPosition = FormStartPosition.Manual;
            f2.FormClosing += delegate { this.Show(); };
            f2.Show();
            this.Hide();
        }

        private void ImgFilmes_Click_1(object sender, EventArgs e)
        {

        }

        private void PanelLine2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelCaracteristicas_Click(object sender, EventArgs e)
        {

        }

        private void labelSinopse_Click(object sender, EventArgs e)
        {

        }

        private void LabelNomeFilme_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
