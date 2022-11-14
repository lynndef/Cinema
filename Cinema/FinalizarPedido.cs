using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class FinalizarPedido : Form
    {
        private string nomefilme;
        private Image cartaz;
        private string[] assentosNome;
        private string sessao;

        public FinalizarPedido(string sessao, string text, string nomefilme, Image cartaz, string[] assentosNome)
        {
            InitializeComponent();
            this.sessao = sessao;
            Text = text;
            this.nomefilme = nomefilme;
            this.cartaz = cartaz;
            this.assentosNome = assentosNome;
        }

        private void FinalizarPedido_Load(object sender, EventArgs e)
        {

            ImgFilmes.BackgroundImage = cartaz;
            LabelNomeFilme.Text = nomefilme;
            labelHorarioSessao.Text = sessao;

            LabelCpf.Text = Text.Substring(0, 12).PadRight(16, '*');
            LabelAssento.Text = string.Join(" ", assentosNome).Trim();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintImage);
            pd.Print();
        }

        void PrintImage(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int width = this.Width;
            int height = this.Height;

            Rectangle bounds = new Rectangle(x, y, width, height);

            Bitmap img = new Bitmap(width, height);

            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form f6 = new MainMenu();
            f6.Location = this.Location;
            f6.StartPosition = FormStartPosition.Manual;
            f6.Show();
            this.Close();
        }

    }
}

    
       


 