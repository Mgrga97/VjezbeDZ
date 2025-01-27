using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Ucenje;

namespace ZimskiZadaci
{

    // Pretvaranje Fahrenheit u Celzijus i obrnuto
    internal class E16Z8PretvorbaTemperature
    {

        public static void Izvedi()
        {

            
            while (true)
            {

                int izbor = E12Metode.UcitajCijeliBroj("Odaberi koju mjernu jedinicu temperature želiš pretvarati:\n1. Fahrenheit u Celzijus\n2. Celzijus u Fahrenheit\n", 1,2);


               /* Console.WriteLine("Odaberi koju mjernu jedinicu temperature želiš pretvarati: ");
                Console.WriteLine("1. Fahrenheit u Celzijus");
                Console.WriteLine("2. Celzijus u Fahrenheit");

                int izbor = E12Metode.UcitajCijeliBroj("");
                if (izbor < 1 || izbor > 2)
                {
                    Console.WriteLine("Broj nije u rasponu odabira (1 - 2)");
                    continue;
                }
                */
                Console.WriteLine("Unesi temperaturu: ");
                int temperatura = E12Metode.UcitajCijeliBroj("");



                int temp;
                if (izbor == 1)
                {

                    // Pretvaramo F° u C°
                    temp = (temperatura - 32) * 5 / 9;
                    Console.WriteLine("Temperatura  je: {0}", temp + "°C");

                }
                else 
                {

                    // Pretvaramo C° u F°
                    temp = (temperatura * 9)/ 5 + 32;
                    Console.WriteLine("{0}°C je {1}°F", temperatura, temp);

                }

                //Ponavljamo upit
                Console.WriteLine("Želite li nastaviti? (da/ne)");
                string odgovor = E12Metode.UcitajString("").ToLower();

                //Ako je odgovor "da" naredba continue će vratiti na početak beskonačne petlje
                while (odgovor != "da" && odgovor != "ne")
                {
                    Console.WriteLine("Neispravan unos. Molimo unesite 'da' ili 'ne'.");
                    odgovor = E12Metode.UcitajString("").ToLower();
                }

                if (odgovor == "ne")
                {
                    break;
                }
                else
                {
                    continue;
                }
                
            }
            


            












        }


    }


}
