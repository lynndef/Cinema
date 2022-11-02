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

        public FinalizarPedido()
        {
            InitializeComponent();
        }

        public FinalizarPedido(string text, string nomefilme, Image cartaz, string[] assentosNome)
        {
            InitializeComponent();

            Text = text;
            this.nomefilme = nomefilme;
            this.cartaz = cartaz;
            this.assentosNome = assentosNome;
        }

        private void FinalizarPedido_Load(object sender, EventArgs e)
        {


            LabelNomeFilme.Text = nomefilme;
            LabelCpf.Text = Text;
            ImgFilmes.BackgroundImage = cartaz;
            string posi = string.Join(" ", assentosNome);
            LabelAssento.Text = posi;

        }

        private void LabelAssento_Click(object sender, EventArgs e)
        {

        }

        private void ImgFilmes_Click(object sender, EventArgs e)
        {

        }

        private void labelHorarioSessao_Click(object sender, EventArgs e)
        {

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

    
       


 