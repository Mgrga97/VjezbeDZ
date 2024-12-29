using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje;

namespace ZimskiZadaci
{
    internal class E16Z3ZbrojNiza
    {
        public static void Izvedi()
        {
            // tražimo korisnika količinu brojeva za niz, unos brojčanih vrijednosti u niz, i sumu tih brojeva

            int velicinaNiza = E12Metode.UcitajCijeliBroj("Koliko brojeva želite unijeti u niz? ");
            int[] niz=new int[velicinaNiza];

            int suma = 0;

            Console.WriteLine("Unesite vrijednosti: ");
            for (int i=0; i<velicinaNiza; i++)
            {
                Console.Write("Broj " + (i+1) + ": ");
                niz[i] = int.Parse(Console.ReadLine());
                suma = suma + niz[i];

                //suma += niz[i];
            }

            Console.WriteLine("Suma svih brojeva je: " + suma);


        }
    }
}
