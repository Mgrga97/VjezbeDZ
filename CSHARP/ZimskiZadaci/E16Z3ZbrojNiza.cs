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

        // Zbrajamo unesene brojeve iz niza
        public static void Izvedi()
        {
            // tražimo korisnika količinu brojeva za niz, unos brojčanih vrijednosti u niz, i dajemo sumu tih brojeva

            int velicinaNiza = E12Metode.UcitajCijeliBroj("Koliko brojeva želite unijeti u niz? ");
            int[] niz = new int[velicinaNiza];

            int suma = 0;


            for (int i = 0; i < velicinaNiza; i++)
            {
                while (true)
                {
                    try
                    {

                        
                        Console.WriteLine("Unesite vrijednosti: ");
                        Console.Write("Broj " + (i + 1) + ": ");
                        niz[i] = int.Parse(Console.ReadLine());

                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Broj nije dobro unesen");
                        continue;
                    }


                }



                suma = suma + niz[i];

                //suma += niz[i];
            }

            Console.WriteLine("Suma svih brojeva je: " + suma);


        }
    }
}
