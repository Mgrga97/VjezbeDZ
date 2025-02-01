using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje;

namespace ZimskiZadaci
{
    internal class E16LjubavniKalkulator
    {

        public static void Izvedi()

        {

            string PrvoIme = E12Metode.UcitajString("Unesi svoje ime: "); //marta

            string DrugoIme = E12Metode.UcitajString("Unesi ime simpatije: "); //manuel

            var SvaSlova = PrvoIme.Trim().ToLower() + DrugoIme.Trim().ToLower();


            Console.WriteLine(SvaSlova);

            int[] brojevi = PrebrojZnakove(SvaSlova);


            //Console.WriteLine(string.Join('|', SvaSlova.ToArray()));
            //Console.WriteLine(string.Join('|', brojevi));

            int rjesenje = IzracunajPostotak(brojevi);

            Console.WriteLine("rjesenje {0} %", rjesenje);


        }


        private static int[] PrebrojZnakove(string SvaSlova)
        {

            int[] brojevi = new int[SvaSlova.Length];

            var ponavljanja = 0;

            for (int i = 0; i < SvaSlova.Length; i++)
            {
                ponavljanja = 0;
                for (int j = 0; j < SvaSlova.Length; j++)
                {
                    if (SvaSlova[i] == SvaSlova[j])
                    {
                        ponavljanja++;
                    }
                }
                brojevi[i] = ponavljanja;
            }

            return brojevi;
        }

        private static int IzracunajPostotak(int[] brojevi)
        {

            List<int> niz = brojevi.ToList();

            while (niz.Count > 2)
            {
                List<int> noviNiz = new List<int>();

                for (int i = 0; i < niz.Count / 2; i++)
                {
                    int zbroj = niz[i] + niz[niz.Count - 1 - i];
                    if (zbroj >= 10)
                    {
                        noviNiz.Add(zbroj % 10);
                        noviNiz.Add(zbroj / 10);
                    }
                    else
                    {
                        noviNiz.Add(zbroj);
                    }
                    Console.WriteLine($"Zbrajanje: {niz[i]} + {niz[niz.Count - 1 - i]} = {zbroj}");
                }

                if (niz.Count % 2 != 0)
                {
                    noviNiz.Add(niz[niz.Count / 2]);
                    Console.WriteLine($"Dodavanje srednjeg elementa: {niz[niz.Count / 2]}");
                }

                niz = noviNiz;
                Console.WriteLine($"Trenutni niz: {string.Join(", ", niz)}");
            }

            int postotak = niz[0] * 10 + niz[1];
            return postotak % 100;


        }

    }

}

