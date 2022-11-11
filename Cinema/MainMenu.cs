using Cinema.Properties;
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

        Filmes filme1 = new Filmes("Adão Negro", " O poderoso Adão Negro é libertado de sua tumba para lançar" + "\n " +"sua justiça cruel sob a Terra.", 14, "Ação", "Fantasia",
            "2h 05m", Cinema.Properties.Resources.Filme_adao_negro, Cinema.Properties.Resources.Black_Adam_bannerfinal);

        Filmes filme2 = new Filmes("Orfã 2", " A aterradora saga de Esther continua nesta emocionante prequela, Órfã." + "\n " + "Depois de planejar" + " uma brilhante fuga " +
            "de um hospital psiquiátrico na Estónia," + "\n " + "Esther viaja até a América passando-se pela filha desaparecida de uma " +
            "família milionária. " , 12, " Terror", "Thriller",
            "1h 39m", Cinema.Properties.Resources.filme_orfa2, Cinema.Properties.Resources.orfa2_banner);

        Filmes filme3 = new Filmes("Minions 2", " Nos anos 1970, o jovem Gru tenta entrar para um time de supervilões," + "\n " +"mas a entrevista é desastrosa e ele" +
            " e seus minions acabam fugindo" + "\n " +"do grupo de mal-feitores. ",
                    14, "Comédia", "Aventura", "1h 30m", Cinema.Properties.Resources.Filme_minons22, Cinema.Properties.Resources.minions2);

        private void imgFilme1_Click(object sender, EventArgs e)
        {

            ImgFilmes.BackgroundImage = filme1.GetBanner;
            LabelNomeFilme.Text = filme1.GetNome;
      
            labelSinopse.Text = filme1.GetSinopse;
            labelSinopse.Visible = true;
       
            labelCaracteristicas.Text = "Classificação " + filme1.GetClassificacao + " anos/ " + filme1.GetGenero1 + "/ " + filme1.GetGenero2 + "/ " + filme1.GetDuracao;
            labelCaracteristicas.Visible = true;
            labelhoraio.Visible = true;
        }


        private void ImgFilme2_Click(object sender, EventArgs e)
        {

            ImgFilmes.BackgroundImage = filme2.GetBanner;
            LabelNomeFilme.Text = filme2.GetNome;
         
            labelSinopse.Text = filme2.GetSinopse;
            labelSinopse.Visible = true;
            labelCaracteristicas.Text = "Classificação " + filme2.GetClassificacao + " anos/ " + filme2.GetGenero1 + "/ " + filme2.GetGenero2 + "/ " + filme2.GetDuracao;
            labelCaracteristicas.Visible = true;
          
            labelhoraio.Visible = true;

        }

        private void ImgFilme3_Click(object sender, EventArgs e)
        {

            ImgFilmes.BackgroundImage = filme3.GetBanner;
            LabelNomeFilme.Text = filme3.GetNome;
          
            labelSinopse.Text = filme3.GetSinopse;
            labelSinopse.Visible = true;
            labelCaracteristicas.Text = "Classificação " + filme3.GetClassificacao + " anos/ " + filme3.GetGenero1 + "/ " + filme3.GetGenero2 + "/ " + filme3.GetDuracao;
            labelCaracteristicas.Visible = true;
       
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
            LabelNomeFilme.Parent = ImgFilmes;
            LabelNomeFilme.BackColor = Color.Transparent;

            labelSinopse.Parent = ImgFilmes;
            labelSinopse.BackColor = Color.Transparent;

            labelCaracteristicas.Parent = ImgFilmes;
            labelCaracteristicas.BackColor = Color.Transparent;

            LabelNomeFilme.Text = filme2.GetNome;
            labelSinopse.Text = filme2.GetSinopse;
            labelCaracteristicas.Text = "Classificação " + filme3.GetClassificacao + " anos/ " + filme3.GetGenero1 + "/ " + filme3.GetGenero2 + "/ " + filme3.GetDuracao;


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void labelhoraio_Click(object sender, EventArgs e)
        {
            string nomefilme = "";
            Image cartaz = filme1.cartaz;

            if (ImgFilmes.BackgroundImage == filme1.GetBanner)
            {
                nomefilme = filme1.GetNome;
                cartaz = filme1.GetCartaz;
            }
            else if(ImgFilmes.BackgroundImage == filme2.GetBanner)
            {
                nomefilme = filme2.GetNome;
                cartaz=filme2.GetCartaz;
            }
            else if(ImgFilmes.BackgroundImage == filme3.GetBanner)
            {
                nomefilme = filme3.GetNome;
                cartaz = filme3.cartaz;
            }

            Form f2 = new HorarioFilme(nomefilme, cartaz);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
