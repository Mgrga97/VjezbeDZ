using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04Z1
    {
        public static void Izvedi()
        {

            // Program od korisnika traži unos broj godina koje ima korisnik
            // Program ispisuje da li je korisnik punoljetna osoba ili ne
            // dodatno: Ako korisnik unese broj manji od nula ili veći od 112 izbacuje grešku

            //Prvi način ponovno postavlja upit dok ne unese BROJ točno (ne može string), a drugi je lakši shvatiti


            /*int godine;
            while (true)
            {
                Console.Write("unesite godine: ");
                
                try
                {
                    godine = int.Parse(Console.ReadLine());
                    if (godine <=0 || godine > 112)
                    {
                        Console.WriteLine("Greška");
                        continue;
                    }
                    if (godine <18 )
                    {
                        Console.WriteLine("Maloljetan/na");
                    }
                    if(godine > 18)
                    {
                        Console.WriteLine("Punoljetan/na");
                    }
                    
                    break;
                }
                catch
                {
                    Console.WriteLine("Nisi dobro unio broj godina");

                }

            }*/


            Console.Write("Unesi godine: ");
            int godine = int.Parse(Console.ReadLine());

            if (godine > 112 | godine <= 0)
            {
                Console.WriteLine("Greška");
            }
            else if (godine >= 18)
            {
                Console.WriteLine("Punoljetan");
            }
            else 
            {
                Console.WriteLine("Maloljetan");
            }
            
        }
    }
}