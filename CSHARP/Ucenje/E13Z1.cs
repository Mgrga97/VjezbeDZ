using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{

    // program od korisnika unosi cijeli broj koji mora bit veci od 0 i manji od 10
    // program ispisuje faktorijel od unesenog broja (2x3x4x5x6 za uneseni broj 6)
    internal class E13Z1
    {
        public static void Izvedi()
        {
            int broj = E12Metode.UcitajCijeliBroj("unesi cijeli broj: ");
            while (broj < 0 || broj > 10)
            {
                Console.WriteLine("broj mora biti izmedu 1 i 9");
                broj = E12Metode.UcitajCijeliBroj("unesi cijeli broj: ");
            }

            Console.WriteLine("Rezultat je {0}", Faktorijel(broj));
        }

        private static int Faktorijel(int br)
            
        {
            if (br == 1)
            {
                return 1;


            }


            return br * Faktorijel(br - 1);
      
        }

        

    }
}
