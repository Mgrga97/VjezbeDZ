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

            string ona = E12Metode.UcitajString("Unesi svoje ime: ");

            string on = E12Metode.UcitajString("Unesi ime simpatije: ");

            var SvaSlova = ona.Trim().ToLower() + on.Trim().ToLower();


            Console.WriteLine(SvaSlova);

            var brojevi = PrebrojZnakove(SvaSlova);



            Console.WriteLine(string.Join('|', SvaSlova.ToArray()));
            Console.WriteLine(string.Join('|', brojevi));

            
            int zbroj = 0;
            int lijeviIndex = 0;
            int desniIndex = brojevi.Length - 1;

            while (lijeviIndex <= desniIndex && zbroj >= 100)
            {
                zbroj = brojevi[lijeviIndex] + brojevi[desniIndex];
                Console.WriteLine($"Zbroj {lijeviIndex}. i {desniIndex}. elementa: {zbroj}");
                lijeviIndex++;
                desniIndex--;
            }

            Console.WriteLine(zbroj);
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

