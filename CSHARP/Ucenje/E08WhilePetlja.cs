﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E08WhilePetlja
    {
        public static void Izvedi()
        {
            // Console.WriteLine("E08");

            int brojDo = 0; // ovo unosi korisnik

            for (int i = 0; i<brojDo; i++)
            {
                Console.WriteLine(i);
            }

            // if radi sa bool tipom podatka
            // beskonačna petlja

            while (true)
            {
                Console.WriteLine("Osijek");
                break;
            }


            int broj = 0, t = 2;

            while (broj < 10 && t==2)
            {
                Console.WriteLine(++broj);
            }

            broj = 10;
            while(broj<10)
            {
                Console.WriteLine(++broj);
            }


            // zbroj prvih 100 brojeva
            //FOR petljom
            int suma = 0;
            for(int i = 0; i <= 100; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);


            //WHILE petljom
            int sum = 0;
            broj = 1;
            while (broj <= 100)
            {
                
                sum += broj++;
            }
            Console.WriteLine(sum);
            

        }
    }
}
