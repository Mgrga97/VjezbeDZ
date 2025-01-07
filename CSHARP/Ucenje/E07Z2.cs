using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07Z2
    {
        // Za dva unesena cijela broja ispisati sve brojeve između njih

        // Vrijedi i ako je prvi broj veći od drugog..

        public static void Izvedi()
        {

            /* 
            Console.WriteLine("Unesite prvi broj ");
            int prvibroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj");
            int drugibroj = int.Parse(Console.ReadLine());

            for (int i = prvibroj; i < drugibroj; i++)
            {
                Console.WriteLine(i);
            }
            */

            Console.WriteLine("Unesite prvi broj ");
            int prvibroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj");
            int drugibroj = int.Parse(Console.ReadLine());

            

            // Provjeravamo jesu li brojevi jednaki
            if (prvibroj == drugibroj)
            {
                Console.WriteLine("Brojevi su jednaki.");
            }
            else
            {
                // Određujemo manji i veći broj // otvaramo dvije varijable unutar else-a koje će prepoznati vrijednosti u unesenim brojevima od korisnika i smjestiti ih unutra
                int manji = prvibroj < drugibroj ? prvibroj : drugibroj;
                int veci = prvibroj > drugibroj ? prvibroj : drugibroj;


                // Ispisujemo brojeve između manji+1 i veci-1
                Console.WriteLine("Brojevi između " + manji + " i " + veci + " su:");

                for (int i = manji + 1; i < veci; i++)
                {
                    Console.WriteLine(i); // Ispis svakog broja
                }

            }


        }
    }
}
