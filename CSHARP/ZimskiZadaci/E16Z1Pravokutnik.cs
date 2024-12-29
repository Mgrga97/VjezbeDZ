using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje;

namespace ZimskiZadaci
{
    internal class E16Z1Pravokutnik
    {
        public static void Izvedi()
        {
            //Console.WriteLine("Hello World!");

            int duzina = E12Metode.UcitajCijeliBroj("Unesi dužinu pravokutnika: ");


            //Console.Write("Unesi dužinu pravokutnika: ");
            //int duzina = int.Parse(Console.ReadLine());


            int sirina  = E12Metode.UcitajCijeliBroj("Unesi širinu pravokutnika: ");

            //Console.Write("Unesi širinu pravokutnika: ");
            //int sirina = int.Parse(Console.ReadLine());


            // Izračunavanje površine
            int povrsina = duzina * sirina;

            // Prikaz rezultata
            Console.WriteLine("Površina pravokutnika je: ",povrsina);
            Console.WriteLine(povrsina);

        }
    }


}
