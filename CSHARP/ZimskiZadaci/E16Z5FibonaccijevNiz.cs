using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje;

namespace ZimskiZadaci
{
    internal class E16Z5FibonaccijevNiz
    {
        public static void Izvedi()
        {
            Console.WriteLine("Fibonaccijev niz");

            int unosKorisnika = E12Metode.UcitajCijeliBroj("Unesi broj do kojeg će ići fibonaccijev niz: ");
            

            // Potrebno je osigurati dva integera jer fibonaccijev niz zbraja prijašnja dva broja
            int prviBroj = 0, drugiBroj = 1;



            // Onemogućavamo da bude 0 - NULA. ovo ne valja jer ne vraća na početak upita
            /*if (unosKorisnika <= 0)
            {
             
                E12Metode.UcitajCijeliBroj("Broj ne smije biti 0! ");
                return ;

            }
            */
            
           

            Console.WriteLine("Fibonaccijev niz do njegovog {0} broja: ",unosKorisnika);
            for (int i = 1; i <= unosKorisnika; i++)
            {
                Console.Write(prviBroj + " "); // ispis trenutnog broja

                // Izračunavamo sljedeće brojeve u Fibonaccijevom nizu
                int sljedeci = prviBroj + drugiBroj;
                prviBroj = drugiBroj;
                drugiBroj = sljedeci;
                

            }
            Console.WriteLine();

        }
    }
}
