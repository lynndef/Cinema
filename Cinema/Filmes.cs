using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Filmes
    {

        public Image cartaz;
        public string Nome;
        public string Sinopse;
        public int classificacao;
        public string genero1;
        public string genero2;
        public string duracao;

        public Filmes(string Nome, string Sinopse, int classificacao, string genero1, string genero2, string duracao, Image cartaz)
        {
            this.cartaz = cartaz;
            this.Nome = Nome;
            this.Sinopse = Sinopse;
            this.classificacao = classificacao;
            this.genero1 = genero1;
            this.genero2 = genero2;
            this.duracao = duracao;

        }

        public Image GetCartaz
        {
            get { return cartaz; }
            set { cartaz = value; }
        }

        public string GetNome
        {
            get { return this.Nome; }
            set { this.Nome = value; }
        }

        public string GetSinopse
        {
            get { return this.Sinopse; }
            set { this.Sinopse = value; }
        }

        public int GetClassificacao
        {
            get { return this.classificacao; }
            set { this.classificacao = value; }
        }

        public string GetGenero1
        {
            get { return this.genero1; }
            set { this.genero1 = value; }
        }

        public string GetGenero2
        {
            get { return this.genero2; }
            set { this.genero2 = value; }
        }

        public string GetDuracao
        {
            get { return this.duracao; }
            set { this.duracao = value; }
        }
    }
}
