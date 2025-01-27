using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Ucenje;

namespace ZimskiZadaci
{

    // Tražimo korisnika unos brojeva u niz, te ih ispisujemo unazad 
    internal class E16Z9NizUnazad
    {
        public static void Izvedi()
        {

            // Tražimo korisnika da odredi veličinu niza brojeva

            int velicinaNiza = E12Metode.UcitajCijeliBroj("Koliko brojeva želite staviti u niz? ");
            int[] niz = new int[velicinaNiza];


            // Čitamo od korisnika veličinu niza i dodajemo redni broj ispred rečenice za svaki unos 
            for (int i = 0; i < velicinaNiza; i++)
            {

                Console.Write("Unesite broj {0}",i + 1 + ": ");
                niz[i] = int.Parse(Console.ReadLine());

            }


            //  Ispisujemo sve upisane brojeve unazad  
            // Odvajamo ih zarezom i rješavamo se zareza nakon zadnjeg broja sa IF ELSE uvjetima

            Console.WriteLine("Niz unesenih brojeva unazad: ");
            for (int i = velicinaNiza - 1;i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.Write(niz[i]);
                }
                else
                {
                    Console.Write(niz[i] + ",");
                }

               // Console.Write(niz[i]); bez IF ELSE prikazuje rezultat ali ponavlja rečenicu Niz unesenih broja unazad: - ovako pokazuje samo jednom pa slaže brojeve


            }
            Console.WriteLine();

            
        }


    }
}
