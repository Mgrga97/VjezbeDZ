using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje;

namespace ZimskiZadaci
{
    internal class E16Z6StringUnazad
    {
        public static void Izvedi()
        {
            // Tražimo korisnika unos nečega

            string pojam = E12Metode.UcitajString("Unesite pojam za ispis unatrag: ");

           
            // stavljamo varijablu string unatrag izvan petlje i ostavimo praznu da bi petlja mogla unijeti vrijednost
            // moze ici i string unatrag = string.Empty 

            string unatrag = " ";

            for (int i = pojam.Length - 1; i >= 0; i--)
            {
                // unatrag = pojam[i] + unatrag

                unatrag += pojam[i];
            }
            Console.WriteLine("Pojam  unatrag: " + unatrag );
            
        }
    }
}
