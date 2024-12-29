﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje;

namespace ZimskiZadaci
{
    internal class E16Z2ProvjeraBroja
    {
        public static void Izvedi()
        {
            // Console.WriteLine("E16Z2");

            int broj = E12Metode.UcitajCijeliBroj("Unesi cijeli broj: ");
            Console.WriteLine("Unijeli ste {0} ",broj);

            if (broj == 0)
            {
                Console.WriteLine("Broj {0} je NULA.", broj);
            }
            else if (broj == 1)
            {
                Console.WriteLine("Broj {0} je NEGATIVAN",broj);
            }
            else
            {
                Console.WriteLine("Broj {0} je POZITIVAN :) ",broj);
            }

        }
    }
}