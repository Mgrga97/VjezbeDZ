using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{

    // Program od korisnika traži unos dva cijela broja
    // Program ispisuje manji

    // isti zadatak ali za tri unesena broja ispisati najmanji

    internal class E04Z3
    {
        public static void Izvedi()
        {
            // Console.WriteLine("E04Z3");
            Console.WriteLine("Unesi prvi broj: ");
            int prvibroj = int.Parse(Console.ReadLine());

         

            Console.WriteLine("Unesi drugi broj: ");
            int drugibroj = int.Parse(Console.ReadLine());

            if (prvibroj > drugibroj)
            {
                Console.WriteLine("Manji broj je: " + drugibroj);
            }
            else if (drugibroj < prvibroj)
            {

                Console.WriteLine("Manji broj je: " + prvibroj);

            }
            else
            {
                Console.WriteLine("Brojevi jednaki");
            }
        }
    }
}
