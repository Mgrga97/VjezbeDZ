using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Ucenje;

namespace ZimskiZadaci
{
    internal class E16Z8PretvorbaTemperature
    {

        public static void Izvedi()
        {

            Console.WriteLine("Odaberi mjernu jedinicu za pretvorbu: "); 
            Console.WriteLine("1. Fahrenheit u Celzijus");
            Console.WriteLine("2. Celzijus u Fahrenheit");

            int odabir = int.Parse(Console.ReadLine());

            int temperatura = E12Metode.UcitajCijeliBroj("Unesi broj temperature za pretvorbu: ");

            int rezultat;


            switch (odabir)
            {
                // Pretvaramo Fahrenheit u Celzijuse
                case 1:
                    rezultat = (temperatura - 32) * 5 / 9;
                    Console.WriteLine("{0}°F je {1}°C",temperatura,rezultat);
                    break;

                //Pretvaramo Celzijus u Fahrenheit
                case 2:
                    rezultat = (temperatura * 9 / 5) + 32;
                    Console.WriteLine("{0}°C je {1}°F", temperatura, rezultat);
                    break;

                default:
                    Console.WriteLine("Neispravan unos");
                    break;
            }


        }


    }


}
