using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using Ucenje;

namespace ZimskiZadaci
{

    //Za dani string prebrojava i ispisuje sve samoglasnike u njemu (a, e, i, o, u)

    internal class E16Z7BrojacSamoglasnika
    {

        public static void Izvedi()
        {


            // Tražimo od korisnika unos teksta



            for (; ; )
            {
                string tekst = E12Metode.UcitajString("Unesi nekakav izraz (STOP za kraj): ");
                if (tekst.ToUpper() == "STOP")
                {
                    Console.WriteLine("Doviđenja");
                    break;
                }

                int brojacSamoglasnika = 0;

                try
                {
                    int.Parse(tekst);
                    Console.WriteLine("Ne smije biti broj");
                    continue;
                }
                catch
                {


                }

                for (int i = 0; i < tekst.Length; i++)
                {
                    char c = char.ToLower(tekst[i]);


                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')

                    {
                        brojacSamoglasnika++;
                    }

                    

                }

                // Ispisujemo rezultat
                Console.WriteLine("Broj samoglasnika u unesenom tekstu je: " + brojacSamoglasnika);

            }



        }





    }
}
