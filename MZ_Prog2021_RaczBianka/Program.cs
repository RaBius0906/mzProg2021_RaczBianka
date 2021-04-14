using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MZ_Prog2021_RaczBianka
{
    class Program
    {
        static void Main(string[] args)
        {
            // fájlbeolvasás
            string[] sorok = File.ReadAllLines("balkezesek.csv");
            List<Adat> adatok = new List<Adat>();
            foreach (string sor in sorok.Skip(1))
            {
                adatok.Add(new Adat(sor));
            }

            // 1. feladat
            int N = adatok.Count;
            Console.WriteLine($"Hány versenyzőről van adatunk? Válasz: {N}");
            
            



            Console.ReadLine();
        }
    }
}
