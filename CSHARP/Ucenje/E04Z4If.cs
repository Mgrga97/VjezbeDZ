using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04Z4If
    {
        public static void Izvedi()
        {
         

            Console.WriteLine("Unesi naziv grada: ");
            string grad = Console.ReadLine();

            if (grad == "Osijek")
            {
                Console.WriteLine("Slavonija");
            }
            else if (grad == "Zadar")
            {
                Console.WriteLine("Dalmacija");
            }
            else if (grad == "Čakovec")
            {
                Console.WriteLine("Međimurje");
            }
            else if (grad == "Pula")
            {
                Console.WriteLine("Istra");
            }
            else
            {
                Console.WriteLine("Ne znam koja je to regija.");
            }
        }
    }
}
