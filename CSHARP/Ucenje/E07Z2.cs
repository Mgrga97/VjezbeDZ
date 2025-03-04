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

            // korisnik unosi dva broja
            // ispisujemo sve brojeve između

            var brojJedan = E12Metode.UcitajCijeliBroj("Unesi prvi broj: ");
            var brojDva = E12Metode.UcitajCijeliBroj("Unesi drugi broj: ");


            if (brojJedan > brojDva)
            {
                for (int i = brojDva; i <= brojJedan; i++)
                {
                    if (i == brojDva)
                    {
                        continue;
                    }
                    Console.WriteLine(i);

                }

            }
            else if (brojJedan < brojDva)
            {
                for (int i = brojJedan; i <= brojDva; i++)
                {
                    if (i == brojJedan)
                    {
                        continue;
                    }
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Brojevi su jednaki");
            }


        }
    }
}
