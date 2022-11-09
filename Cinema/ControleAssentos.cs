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
        public int[] AssentosClicks2 = new int[18] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int[] AssentosClicks3 = new int[18] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int[] AssentosClicks4 = new int[18] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int[] AssentosClicks5 = new int[18] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int[] AssentosClicks6 = new int[18] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };


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
  
    }
}
