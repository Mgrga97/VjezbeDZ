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
    internal class E16Z8PretvorbaTemperature
    {

        public static void Izvedi()
        {

            Console.WriteLine("Odaberi koju mjernu jedinicu temperature želiš pretvarati: ");
            Console.WriteLine("1. Fahrenheit u Celzijus");
            Console.WriteLine("2. Celzijus u Fahrenheit");

           
            

            

            
            
            while (true)
            {

                int izbor = E12Metode.UcitajCijeliBroj("");
                if (izbor < 1 || izbor > 2)
                {
                    Console.WriteLine("Broj nije u rasponu odabira (1 - 2)");
                    continue;
                }

                Console.WriteLine("Unesi temperaturu: ");
                int temp;
                int temperatura = int.Parse(Console.ReadLine());

                if (izbor == 1)
                {

                    
                    

                    // Pretvaramo F° u C°
                    temp = (temperatura - 32) / 5 * 9;
                    Console.WriteLine("Temperatura  je: {0}", temp + "°C");

                }
                else if (izbor == 2)
                {
                    // Pretvaramo C° u F°
                    temp = (temperatura * 5 / 9) + 32;
                    Console.WriteLine("{0}°C je {1}°F", temperatura, temp);

                }
                else
                {
                    Console.WriteLine("Greška kod unosa odabira");
                }
                break;
            }
            


            












        }


    }


}
