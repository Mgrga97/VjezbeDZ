using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje;

namespace ZimskiZadaci
{
    internal class E16LjubavniKalkulator
    {

        public static void Izvedi()

        {

            string ona = E12Metode.UcitajString("Unesi svoje ime: "); //marta

            string on = E12Metode.UcitajString("Unesi ime simpatije: "); //manuel

            var SvaSlova = ona.Trim().ToLower() + on.Trim().ToLower();


            Console.WriteLine(SvaSlova);

            var brojevi = PrebrojZnakove(SvaSlova);

            var rezultat = IzracunajLjubavSusjednimBrojevima(brojevi);

            int rjesenje = IzracunajLjubavPrviPaZadnjiBroj(brojevi);

            Console.WriteLine(string.Join('|', SvaSlova.ToArray()));
            Console.WriteLine(string.Join('|', brojevi));

            Console.WriteLine("Vasa ljubav iznosi {0} %",rezultat);





        }

        private static int IzracunajLjubavPrviPaZadnjiBroj(int[] brojevi)
        {
            // ova metoda treba zbrajati brojeve logikom prvi pa zadnji, drugi pa predzadnji itd.
            // ako ostane broj na kraju zbrajanja njega prepisujemo

            return 0;
        }

        private static int IzracunajLjubavSusjednimBrojevima(int[]brojevi)
        {
            // ova metoda treba vratiti zbroj svih brojeva u nizu
            int sum = 0;
            foreach (var broj in brojevi)
            {
                sum += broj;
            }
            return sum;
        }

        

        private static int[] PrebrojZnakove(string SvaSlova)
        {

            int[] brojevi = new int[SvaSlova.Length];

            var ponavljanja = 0;

            for (int i = 0; i < SvaSlova.Length; i++)
            {
                ponavljanja = 0;
                for (int j = 0; j < SvaSlova.Length; j++)
                {
                    if (SvaSlova[i] == SvaSlova[j])
                    {
                        ponavljanja++;
                    }
                }
                brojevi[i] = ponavljanja;
            }

            return brojevi;
        }


        
        
            
            
        


    }




}

