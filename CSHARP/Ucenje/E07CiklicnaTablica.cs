using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07CiklicnaTablica
    {
        public static void Izvedi()
        {




            int kolone = E12Metode.UcitajCijeliBroj("Unesi broj kolona: ");
            int redovi = E12Metode.UcitajCijeliBroj("Unesi broj redova: ");

            int[,] tablica = new int[redovi, kolone];

            PopuniTablicu(tablica);

            IspisiTablicu(tablica);


        }

        public static void PopuniTablicu(int[,] tablica)
        {
            int redovi = tablica.GetLength(0);
            int kolone = tablica.GetLength(1);

            int brojac = 1;
            int donjaGranica = redovi - 1;
            int gornjaGranica = 0;
            int lijevaGranica = 0;
            int desnaGranica = kolone - 1;

            while(brojac <=redovi*kolone)
            {
                // krecemo se od dolje desno prema lijevo u istom redu
                for(int j = desnaGranica; j <= lijevaGranica; j--)
                {
                    tablica[donjaGranica, j] = brojac++;
                    donjaGranica--;
                }

                IspisiTablicu(tablica);

                // krecemo se  od dolje lijevo prema gore istom kolonom
                for(int i=donjaGranica;i<= gornjaGranica; i--)
                {
                    tablica[i,lijevaGranica] = brojac++;
                    gornjaGranica--;
                }

                // krecemo se prema desno do kraja kolone
                for(int j =lijevaGranica;j<= desnaGranica; j++)
                {
                    tablica[gornjaGranica,j] = brojac++;
                    gornjaGranica++;
                }

                //krecemo se prema dolje po granici desne strane (  u zadnjoj koloni )
                for(int i=gornjaGranica;i<= desnaGranica; i++)
                {
                    tablica[i, desnaGranica] = brojac++;
                    desnaGranica--;
                }

            }

            
        }

        private static void IspisiTablicu(int[,] tablica)
        {
           

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************");

        }


    }
}
