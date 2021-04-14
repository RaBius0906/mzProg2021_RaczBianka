using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MZ_Prog2021_RaczBianka
{
    class Adat
    {
        // név;első;utolsó;súly;magasság
        public string Nev;
        public string Elso;
        public string Utolso;
        public int Suly;
        public int Magassag;

        public Adat(string sor)
        {
            string[] s = sor.Split(';');
            this.Nev = s[0];
            this.Elso = s[1];
            this.Utolso = s[2];
            this.Suly = int.Parse(s[3]);
            this.Magassag = int.Parse(s[4]);
        }




    }
}
