using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{

    // Za dani izraz bez razmaka provjeriti da li je palindrom

    internal class E10Z1
    {


        public static void Izvedi()
        {
            Console.WriteLine("E10Z1");
            Console.Write("Upiši izraz: ");

            string izraz = Console.ReadLine();

            Console.WriteLine("Izraz: " + izraz);

            if (izraz.Length % 2 == 0)
            {
                // ako izraz ima parni broj slova
                Console.Write("Parno");
                bool palindrom = true;
                for (int i = 0; i < izraz.Length / 2; i++)
                {
                    if (izraz[i] != izraz[izraz.Length - 1 - i])
                    {
                        palindrom = false;
                        break;
                    }

                }
                Console.Write(palindrom ? "da" : "ne");
            }
            else
            {
                // ako izraz ima neparni broj znakova ( slova )
                Console.WriteLine("Neparno");
                bool palindrom = true;
                for (int i = 0; i <= izraz.Length / 2;i++)
                    if (izraz.Length % 2  == 0)
                    {
                        palindrom = false;
                        break;
                    }
                Console.WriteLine(palindrom ? "da" : "ne");
            }
         
        }


        //abbi
        //kisik
        //anavolimilovana
        //amenetuniminutenema
    }

}
