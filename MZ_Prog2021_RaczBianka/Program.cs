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
        public static int i;
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

            // 2. feladat - Kik azok a versenyzők, akik 1980-ban léptek először pályára?
            List<string> ElsoPalya1980 = new List<string>();
            foreach (Adat adat in adatok)
            {
                if (adat.Elso == 1980)
                {
                    ElsoPalya1980.Add(adat.getNev());
                }
            }

            // 3. feladat - Adott név szerepel-e a 2. feladat listájában, ha igen irja ki a magasságát, ha nem "hibás adat!" üzenet jelenjen meg.
            // magasság adat inch-ben, 1 tizedes jegyre kerekítve
            Random rnd = new Random();
            int bekertNevIndex = rnd.Next(0, 385);
            string bekertNev = adatok[bekertNevIndex].Nev;
            //string bekertNev = "Mark Davis";

            int listaN = ElsoPalya1980.Count;
           
            for (i = 0; i < listaN; i++)
            {
                if (ElsoPalya1980[i] == bekertNev)
                {
                    
                    Console.WriteLine($" {bekertNev} magassága: {adatok[bekertNevIndex].Magassag / 2.54:F1} inch");
                }
                else
                {
                    Console.WriteLine($"Hibás adat!");
                }
            }


            // 4. feladat - Válasszunk egy tetszőleges évszámot és irassunk ki mindent azokról a versenyzőkről akik ebben az évben léptek először a pályára.
            //int tetszolegesEvszam = rnd.Next(1990, 1999);
            int tetszolegesEvszam = 1999;
            
            List<string> evszamLista = new List<string>();

            foreach (Adat adat in adatok)
            {
                if (adat.Elso == tetszolegesEvszam)
                {
                    evszamLista.Add(adat.getNev());
                }
            }
            Console.WriteLine($"A {tetszolegesEvszam} évben először pályára lépett játékosok neveit:");
            foreach (string item in evszamLista)
            {
                Console.WriteLine($"\t {item} ");
            }


            // 5. feladat - Melyik a legkorábbi év amikor pályára léptek? V:1969
            int legkorabbiKezdesIndex = 0;
            for (i = 1; i < N; i++)
            {
                if (adatok[i].Elso < adatok[legkorabbiKezdesIndex].Elso)
                {
                    legkorabbiKezdesIndex = i;
                }
            }
            Console.WriteLine($"Melyik a legkorábbi év amikor pályára léptek? Válasz: {adatok[legkorabbiKezdesIndex].Elso}");

            // 6. feladat - Minden játékos 2000 előtt lépett utoljára pályára? V:igen
            i = 0;
            while (i < N && adatok[i].Utolso < 2000) { i++; }
            bool mindenki2000elott = i >= N;
            string valasz = mindenki2000elott ? "igen" : "nem";
            Console.WriteLine($"Minden játékos 2000 előtt lépett utoljára pályára? Válasz: {valasz}");

            // 7. feladat - Hány olyan játékos van akinek a nevében szerepel a John, sorold fel ezeket a neveket.


            // 8. feladat - fájlba kiratás
            //Dictionary<string, int> nevekDB = new Dictionary<string, int>();
            //foreach (Adat adat in adatok)
            //{
            //    string kulcs = adat.Nev.Split(' ');
            //    if (nevekDB.ContainsKey(kulcs))
            //    {
            //        nevekDB[kulcs]++;
            //    }
            //    else
            //    {
            //        nevekDB.Add(kulcs, 1);
            //    }
            //}
            //Console.WriteLine($"Melyik névből hány darab van a listában?");
            //foreach (KeyValuePair<string, int> item in nevekDB)
            //{
            //    Console.WriteLine($"\t{item.Key}: {item.Value} db");
            //}

            File.WriteAllLines("kernevek.txt");


            Console.ReadLine();
        }
    }
}
