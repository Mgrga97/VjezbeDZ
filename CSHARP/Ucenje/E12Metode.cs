using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E12Metode
    {
        public static void Izvedi()
        {
            // metode se sastoje od dva dijela
            // 1. Tijelo metode 
            // 2. Poziv metode ( e12metode.Izvedi )


            // poziv metode
            Tip1();
            Tip1();

            Tip2(7);
            Tip2(5);

            Tip2(10, "Poziv druge varijante metode Tip2");

            int i = Tip3() + 1;
            Console.WriteLine(i);

            int[] niz = { 2, 5, 2, 1, 4, 1, 2, 1, 4, 2, 3};
            Console.WriteLine(Tip4(niz));

            // Metoda koja vraća vrijednost može biti pozvana i kao void metoda
            Tip4(niz); // ona će se izvesti ali ne vraća vrijednost
            
        }

        // tijelo metode
        // tip 1: ne prima parametre, ne vraća vrijednost

        static void Tip1(/*ovdje dolaze parametri, ili ne */) // void ( praznina ) je oznaka da ne vraća vrijednost
        {
            Console.WriteLine("Ispis iz 1. tipa metode");
            Console.WriteLine("*****************");
            Console.WriteLine("Kraj ispisa iz 1. tipa metode");
        }


        // Tip 2: prima parametre ali ne vraća vrijednost 
        private static void Tip2(int x) // x je parametar koji je tipa INT
        {
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(i);
            }
        }

        // potpis metode : 
        // naziv + lista parametara
        // Method overloading
        private static void Tip2(int x, string naslov)
        {
            Console.WriteLine(naslov);
            Tip2(x);

        }

        // Tip 3 ne prima parametre ali vraća vrijednost
        private static int Tip3()
        {
            return int.MaxValue; // svaka metoda tipa koji nije void mora imati return 
        }

        // Tip 4: prima parametre i vraća vrijednost
        /// <summary>
        /// 
        /// Metoda će za primljeni niz cijelih brojeva vratiti sumu
        /// <param name="niz"></param>
        /// <returns> Suma primljenih brojeva </returns>
        private static int Tip4(int[] niz)
        {
            int suma = 0;
            foreach (int i in niz)
            {
                suma += i;
            }
            return suma;

        }


        // NAMA BITNE METODE
        // Write once, use everywhere

        public static int UcitajCijeliBroj(string poruka)
        {
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("Problem kod učitanja broja! ");
                    
                }
            }


           //  return 0; // kasnije obrisemo

        }


    }
}
