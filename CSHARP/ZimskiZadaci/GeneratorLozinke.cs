using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje;

namespace ZimskiZadaci
{
    internal class GeneratorLozinke
    {


        public static void Izvedi()
        {

            Console.WriteLine("Dobrodošli u generator lozinke");

            // Učitavanje duljine lozinke i broja lozinki koje treba generirati
            int duljina = E12Metode.UcitajCijeliBroj("Unesite duljinu lozinke: ");
            int brojLozinki = E12Metode.UcitajCijeliBroj("Koliko lozinki želite generirati? ");

            // Postavljanje skupa dostupnih znakova na temelju korisničkih odabira
            string dostupniZnakovi = "";
            if (E12Metode.UcitajBool("Uključena velika slova? ", "da")) dostupniZnakovi += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (E12Metode.UcitajBool("Uključena mala slova? ", "da")) dostupniZnakovi += "abcdefghijklmnopqrstuvwxyz";
            if (E12Metode.UcitajBool("Uključeni brojevi? ", "da")) dostupniZnakovi += "0123456789";
            if (E12Metode.UcitajBool("Uključiti interpunkcijske znakove? ", "da")) dostupniZnakovi += "!@#$%^&*()-_=+[]{}|;:'<>,.?/";

            // Učitavanje specifičnih pravila za generiranje lozinke
            bool ponavljanjeZnakova = E12Metode.UcitajBool("Ponavljati znakove? ", "da");
            bool pocinjeBrojem = E12Metode.UcitajBool("Počinje li lozinka s brojem? ", "da");
            bool pocinjeInterpunkcijskim = !pocinjeBrojem && E12Metode.UcitajBool("Počinje li lozinka s interpunkcijskim znakom? ", "da");
            bool zavrsavaBrojem = E12Metode.UcitajBool("Završava li lozinka s brojem? ", "da");
            bool zavrsavaInterpunkcijskim = !zavrsavaBrojem && E12Metode.UcitajBool("Završava li lozinka s interpunkcijskim znakom? ", "da");

            Random random = new Random();

            // Generiranje lozinki prema odabranim pravilima
            for (int i = 0; i < brojLozinki; i++)
            {
                string lozinka = "";

                // Dodavanje početnog znaka ako je specificirano
                if (pocinjeBrojem) lozinka += "0123456789"[random.Next(10)];
                else if (pocinjeInterpunkcijskim) lozinka += "!@#$%^&*()-_=+[]{}|;:'<>,.?/"[random.Next(28)];

                // Generiranje srednjeg dijela lozinke
                int maksimalnaDuzina = duljina;
                if (zavrsavaBrojem) maksimalnaDuzina--;
                if (zavrsavaInterpunkcijskim) maksimalnaDuzina--;

                while (lozinka.Length < maksimalnaDuzina)
                {
                    lozinka += dostupniZnakovi[random.Next(dostupniZnakovi.Length)];
                }


                // drugi način
                /*while (lozinka.Length < duljina - (zavrsavaBrojem ? 1 : 0) - (zavrsavaInterpunkcijskim ? 1 : 0))
                                {
                                    lozinka += dostupniZnakovi[random.Next(dostupniZnakovi.Length)];
                                }
                */


                // Dodavanje završnog znaka ako je specificirano
                if (zavrsavaBrojem) lozinka += "0123456789"[random.Next(10)];
                else if (zavrsavaInterpunkcijskim) lozinka += "!@#$%^&*()-_=+[]{}|;:'<>,.?/"[random.Next(28)];

                // Ispis generirane lozinke
                Console.WriteLine(lozinka);




            }

        }
    }
}
