using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Horarios
    {
       public int TimesClicked = 0;
       public int TimesClicked2 = 0;
       public int TimesClicked3 = 0;
       public int TimesClicked4 = 0;
       public int TimesClicked5 = 0;
       public int TimesClicked6 = 0;
       public int TimesClicked7 = 0;
       public int TimesClicked8 = 0;
       public int TimesClicked9 = 0;
       public int TimesClicked10 = 0;
       public int TimesClicked11 = 0;
       public int TimesClicked12 = 0;
       public int TimesClicked13 = 0;
       public int TimesClicked14 = 0;
       public int TimesClicked15 = 0;
       public int TimesClicked16 = 0;
       public int TimesClicked17 = 0;
       public int TimesClicked18 = 0;
    }

    public class AssentosDia
    {

        public Horarios AdaoSala1_10h30 = new Horarios();







        public Horarios AdaoSala1_13h30 = new Horarios();
        public Horarios AdaoSala1_14h30 = new Horarios();
        
        public Horarios OrfanSala1_10h30 = new Horarios();
        public Horarios OrfanSala1_13h30 = new Horarios();
        public Horarios OrfanSala1_14h30 = new Horarios();
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
