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


            Console.WriteLine(string.Join('|', SvaSlova.ToArray()));
            Console.WriteLine(string.Join('|', brojevi));

            int rjesenje = IzracunajPostotak(brojevi);

            Console.WriteLine("rjesenje {0} %", rjesenje);
            Console.WriteLine();


            Console.WriteLine(string.Join(' ',brojevi));
            int susjednimBrojevima = IzracunajPostotakSusjednim(brojevi);



            Console.WriteLine("Rjesenje susjednim brojevima {0} %", susjednimBrojevima);


        }


        private static int[] PrebrojZnakove(string SvaSlova)
        {

            int[] brojevi = new int[SvaSlova.Length];

            var ponavljanja = 0;

            //Vanjska petlja koja prolazi kroz cijeli niz 
            for (int i = 0; i < SvaSlova.Length; i++)
            {
                //Unutarnja petlja koja prolazi kroz niz i zapisuje ista slova u ponavljanja
                ponavljanja = 0;
                for (int j = 0; j < SvaSlova.Length; j++)
                {
                    if (SvaSlova[i] == SvaSlova[j]) // uspoređuje slova i ako su ista povećava se ponavljanje pa kreće dalje
                    {
                        ponavljanja++;
                    }
                }
                brojevi[i] = ponavljanja; // Pohranjuje broj pojavljivanja trenutnog znaka 
            }

            return brojevi;
        }

        private static int IzracunajPostotak(int[] brojevi)
        {
            {
                int duljina = brojevi.Length;

                while (duljina > 2)
                {
                    int novaDuljina = 0; // Inicijaliziramo novu duljinu na 0
                    for (int i = 0; i < duljina / 2; i++)
                    {
                        int zbroj = brojevi[i] + brojevi[duljina - 1 - i];
                        if (zbroj >= 10)
                        {
                            novaDuljina += 2; // Dva elementa u novom nizu (jedinice i desetice)
                        }
                        else
                        {
                            novaDuljina++; // Jedan element u novom nizu
                        }
                    }
                    if (duljina % 2 != 0)
                    {
                        novaDuljina++; // Još jedan element ako je duljina bila neparna
                    }

                    int[] noviNiz = new int[novaDuljina]; // Kreiramo niz *nakon* što smo izračunali točnu duljinu

                    int noviIndex = 0; // Indeks za noviNiz
                    for (int i = 0; i < duljina / 2; i++)
                    {
                        int zbroj = brojevi[i] + brojevi[duljina - 1 - i];

                        if (zbroj >= 10)
                        {
                            noviNiz[noviIndex++] = zbroj % 10;
                            noviNiz[noviIndex++] = zbroj / 10;
                        }
                        else
                        {
                            noviNiz[noviIndex++] = zbroj;
                        }

                        Console.WriteLine("Zbrajanje: " + brojevi[i] + " + " + brojevi[duljina - 1 - i] + " = " + zbroj);
                    }

                    if (duljina % 2 != 0)
                    {
                        noviNiz[noviIndex++] = brojevi[duljina / 2];
                        Console.WriteLine("Dodavanje srednjeg elementa: " + brojevi[duljina / 2]);
                    }

                    brojevi = noviNiz;
                    duljina = brojevi.Length; // Duljina se uzima iz novog niza

                    Console.Write("Trenutni niz: ");
                    for (int i = 0; i < duljina; i++)
                    {
                        Console.Write(brojevi[i] + " ");
                    }
                    Console.WriteLine();
                }

                int postotak = brojevi[0] * 10 + brojevi[1];
                return postotak % 100;
            }

        }

        private static int IzracunajPostotakSusjednim(int[] brojevi)
        {
            int duljina = brojevi.Length;

            while (duljina > 2)
            {
                int novaDuljina = 0;
                for (int i = 0; i < duljina - 1; i += 2) // Zbrajamo susjedna dva broja
                {
                    int zbroj = brojevi[i] + brojevi[i + 1];
                    if (zbroj >= 10)
                    {
                        novaDuljina += 2;
                    }
                    else
                    {
                        novaDuljina++;
                    }
                }
                if (duljina % 2 != 0)
                {
                    novaDuljina++; // Ako je duljina bila neparna, zadnji element ide u novi niz
                }

                int[] noviNiz = new int[novaDuljina];

                int noviIndex = 0;
                for (int i = 0; i < duljina - 1; i += 2) // Opet, zbrajamo susjedna dva broja
                {
                    int zbroj = brojevi[i] + brojevi[i + 1];

                    if (zbroj >= 10)
                    {
                        noviNiz[noviIndex++] = zbroj % 10;
                        noviNiz[noviIndex++] = zbroj / 10;
                    }
                    else
                    {
                        noviNiz[noviIndex++] = zbroj;
                    }

                    Console.WriteLine("Zbrajanje: " + brojevi[i] + " + " + brojevi[i + 1] + " = " + zbroj);
                }

                if (duljina % 2 != 0)
                {
                    noviNiz[noviIndex++] = brojevi[duljina - 1]; // Zadnji element ide u novi niz
                    Console.WriteLine("Dodavanje zadnjeg elementa: " + brojevi[duljina - 1]);
                }

                brojevi = noviNiz;
                duljina = brojevi.Length;

                Console.Write("Trenutni niz: ");
                for (int i = 0; i < duljina; i++)
                {
                    Console.Write(brojevi[i] + " ");
                }
                Console.WriteLine();
            }

            int postotak = brojevi[0] * 10 + brojevi[1];
            return postotak % 100;
        }

    }
}

