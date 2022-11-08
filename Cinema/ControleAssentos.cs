using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Horarios
    {
        public int[] AssentosClicks = new int[18] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    }

    public class AssentosDia
    {

        public Horarios AdaoSala1_10h30 = new Horarios();
        public Horarios AdaoSala1_13h30 = new Horarios();
       
        public Horarios OrfanSala1_10h30 = new Horarios();
        public Horarios OrfanSala1_13h30 = new Horarios();
       
    }

    public static class ControleAssentos
    {
        public static AssentosDia Seg = new AssentosDia();
        public static AssentosDia Ter = new AssentosDia();
        public static AssentosDia Qua = new AssentosDia();
        public static AssentosDia Qui = new AssentosDia();
        public static AssentosDia Sex = new AssentosDia();
    }
}
