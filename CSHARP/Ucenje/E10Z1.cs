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
                Console.WriteLine("Parno");
                bool palindrom = true;
                for (int i = 0; i < izraz.Length / 2; i++)
                {
                    if (izraz[i] != izraz[izraz.Length - 1 - i])
                    {
                        palindrom = false;
                        break;
                    }

                }
                Console.WriteLine(palindrom ? "da" : "ne");
            }
            else
            {
                // ako izraz ima neparni broj znakova ( slova )
                Console.WriteLine("Neparno");
                bool palindrom = true;
                for (int i = 0; i <= izraz.Length / 2; i++)
                    if (izraz.Length % 2 == 0)
                    {
                        palindrom = false;
                        break;
                    }

                Console.WriteLine(palindrom ? "da" : "ne");
            }


            // Subota 21.12. vježbanje 





            Console.WriteLine("Palindrom");
            string izraz2 = E12Metode.UcitajString("Unesi izraz za provjeru palindroma: ");

            bool palindrom2 = true;
            izraz = izraz2.ToUpper();


            //Ispiši prvo slovo
            Console.WriteLine(izraz2[0]); // i = 0

            // Ispiši zadnje slovo
            Console.WriteLine(izraz2[izraz2.Length - 1 - 0]); // i = 0

            //Ispiši drugo slovo
            Console.WriteLine(izraz2[1]); // i = 1

            //Ispiši predzadnje slovo 
            Console.WriteLine(izraz2[izraz2.Length - 1 - 1]); // i = 1


            for (int i = 0; i < izraz2.Length / 2; i++)
            {
                if (izraz2[i] != izraz2[izraz2.Length - 1 - i])
                {
                    palindrom2 = false;
                    break;
                }

            }

            Console.WriteLine("Izraz {0} {1} palindrom", izraz, palindrom2 ? "JE" : "NIJE");

        }


    }




    //abbi
    //kisik
    //anavolimilovana
    //amenetuniminutenema


}



