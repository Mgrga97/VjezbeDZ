namespace Ucenje
{

    // Napišite program koji unosi ime i broj godina osobe

    // Program ispisuje: Osoba XXXXXX ima YY godina.

    internal class E02Z1
    {
        // Ova metoda je uvijek potrebna (za sada ju "kucamo" ručno)
        public static void Izvedi()
        {

            //ovdje se piše rješenje zadatka

            Console.WriteLine("Unesi ime: ");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesi broj godina: ");
            int godine = int.Parse(Console.ReadLine());

            Console.WriteLine("Osoba {0} ima {1} godina", ime, godine);

        }


    }
}
