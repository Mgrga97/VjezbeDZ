using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04Z1
    {
        public static void Izvedi() 
        {
            Console.Write("unesite godine: ");
            int godine = int.Parse(Console.ReadLine());
            if (godine >= 18)
            {
                Console.WriteLine("punoljetan");

            }
            else
            {
                Console.WriteLine("maloljetan");
            }

        }

    }
}
