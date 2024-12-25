using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimskiZadaci
{
    internal class E16Pravokutnik
    {
        public static void Izvedi()
        {
            //Console.WriteLine("Hello World!");
            Console.Write("Unesi dužinu pravokutnika: ");
            int duzina = int.Parse(Console.ReadLine());

            
            Console.Write("Unesi širinu pravokutnika: ");
            int sirina = int.Parse(Console.ReadLine());

            // Izračunavanje površine
            int povrsina = duzina * sirina;

            // Prikaz rezultata
            Console.WriteLine("Površina pravokutnika je: ",povrsina);
            Console.WriteLine(povrsina);

        }
    }


}
