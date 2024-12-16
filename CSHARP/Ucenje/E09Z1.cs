using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
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
