﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{




}

    /*
        *  KORISTEĆI IF
        * 
       Program učitava od korisnika ime grada.U ovisnosti o imenu grada ispisuje regiju prema sljedećim pravilima:

      Osijek -> Slavonija
      Zadar -> Dalmacija
      Čakovec -> Međimurje
      Pula -> Istra
      Za ostale unose program ispisuje: Ne znam koja je to regija.
       */

// dodatno: Odraditi istu logiku s switch
    internal class E04Z4Switch
{
    public static void Izvedi()
    {
        Console.WriteLine("Unesi grad: ");
        string grad = Console.ReadLine();
        {
            Console.WriteLine("Unijeli ste: " +grad);
        }

        switch (grad)
        {
            case "Osijek":
                Console.WriteLine("Slavonija");
                break;
            case "Zadar":
                Console.WriteLine("Dalmacija");
                break;
            case "Čakovec":
                Console.WriteLine("Međimurje");
                break;
            case "Pula":
                Console.WriteLine("Istra");
                break;
            default:
                Console.WriteLine("Ne znam koja je to regija.");
                break;

        }
    }
}

