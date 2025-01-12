using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje;

namespace ZimskiZadaci
{
    internal class E16Z10Kalkulator
    {
        public static void Izvedi()
        {

            Console.WriteLine("Kalkulator");

            int unos = E12Metode.UcitajCijeliBroj("Odaberi koju funkciju će kalkulator obavljati:\n 1.Zbrajanje \n 2.Oduzimanje \n 3.Množenje \n 4.Dijeljenje \n:");
            int prviBroj = E12Metode.UcitajCijeliBroj("Unesi prvi broj: ");
            int drugiBroj = E12Metode.UcitajCijeliBroj("Unesi drugi broj: ");



            float rezultat;


            switch (unos)
            {
                case 1:
                    rezultat = prviBroj + drugiBroj;
                    Console.WriteLine("{0} + {1} je: {2}", prviBroj, drugiBroj, rezultat);
                    break;

                case 2:
                    rezultat = prviBroj - drugiBroj;
                    Console.WriteLine("{0} - {1} je: {2}", prviBroj, drugiBroj, rezultat);
                    break;

                case 3:
                    rezultat = prviBroj * drugiBroj;
                    Console.WriteLine("{0} * {1} je: {2}", prviBroj, drugiBroj, rezultat);
                    break;

                case 4:
                    if (prviBroj == 0 || drugiBroj == 0)
                    {
                        Console.WriteLine("Zabranjeno dijeljenje s nulom");
                    }
                    else
                    {
                        rezultat = prviBroj / drugiBroj;
                        Console.WriteLine("{0} / {1} je: {2}", prviBroj, drugiBroj, rezultat);
                        
                    }
                    break;

                default:
                    Console.WriteLine("Neispravan unos");
                    break;



            }

            //Pravimo ponovni upit za korištenje kalkulatora
            while (true)
            {
                Console.WriteLine("Želite li nastaviti? (da/ne)");
                string odgovor = E12Metode.UcitajString("").ToLower();

                //Ako je odgovor "da" naredba continue će vratiti na početak beskonačne petlje
                while (odgovor != "da" && odgovor != "ne")
                {
                    Console.WriteLine("Neispravan unos. Molimo unesite 'da' ili 'ne'.");
                    odgovor = E12Metode.UcitajString("").ToLower();
                }

                if (odgovor == "ne")
                {
                    break;
                }
                else
                {
                    continue;
                }

            }
            
        }
    }
}
