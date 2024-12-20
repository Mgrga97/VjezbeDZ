using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07CiklicnaTablica
    {
        public static void Izvedi()
        {
            int kolona = 5; E12Metode.UcitajCijeliBroj("Unesi broj kolona: ");
            int redova = 5; E12Metode.UcitajCijeliBroj("Unesi broj redova: ");

            int[,] tablica =  new int[kolona, redova];

            IspisiTablicu(tablica);

            
            int brojac = 1;
            for (int i = kolona - 1; i >= 0; i--) ;
            {
                tablica[redova - 1, i] = brojac++;
            }

        }

        private static void IspisiTablicu(int[,] tablica)
        {
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for(int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*******************");

        }


    }
}
