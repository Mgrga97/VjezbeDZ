using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje;

namespace ZimskiZadaci
{
    internal class E16Z4ProsjekOcjena
    {
        public static void Izvedi()
        {

            // Console.WriteLine("E16Z4");
            int brojOcjena = E12Metode.UcitajCijeliBroj("Unesi broj ocjena za izračun: ");
            int[] ocjene = new int[brojOcjena];

            // FOR PETLJA koja dodaje redni broj ispred svake Ocjene prije unosa ( Ocjena 1. Ocjena 2. itd.)

            for (int i = 0; i < ocjene.Length; i++)
            {
                Console.Write("Ocjena " + (i + 1) + " :");
                ocjene[i] = int.Parse(Console.ReadLine());

            }

            // FOR PETLJA koja zbraja sve ocjene i dijeli ih sa brojem unesenih ocjena
            // varijabla suma mora biti deklarirana izvan petlje


            int suma = 0;

            for (int i = 0;i < ocjene.Length; i++)
            {

                suma += ocjene[i];
                
            }
            
            // umjesto int stavljamo float da pretvori cijeli broj u decimalni, također dodajemo (float) ispred sume jer je ranije stavljen int

            float prosjek = (float) suma / brojOcjena;


            Console.WriteLine("Prosjek svih ocjena je: " + prosjek);


        }
    }
}
