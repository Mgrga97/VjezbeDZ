using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{

    // Program od korisnika unosi cijeli broj 
    // Koristeći while petlju program ispisuje 
    // zbroj svih parnih brojeva od 1 do unesenog broja (skupa s njim)
    // unos 10 ispis 30
    // unos 12 ispis 42
    internal class E09Z1
    {
        public static void Izvedi()
        {
            Console.Write("Unesite cijeli broj: ");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine(t);

            int i = 0, sum = 0;
            while (i <= t)
            {
                Console.WriteLine("u petlji sam, i={0}", i);
                if (++i % 2 == 0)
                {

                    sum += i++;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
