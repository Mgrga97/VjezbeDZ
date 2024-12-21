
namespace Ucenje
{
    internal class E15Subota
    {
        public static void Izvedi()
        {
            PrimjerTryCatch();

            
        }
    

    private static void PrimjerTryCatch()
        {
            

            try
            {
                int.Parse("Osijek");
            }
            catch 
            {
                Console.WriteLine("Žao nam je zbog greške");
                
            }

            // zadatak: osigurajte unos logičke vrijednosti

            bool vrijednost = false; // ne moram napisat = false; , već je false 
         
                Console.WriteLine("Da li si zaposlen/a? (upiši DA ili bilo što za ne) ");
            if (Console.ReadLine().Trim().ToUpper() == "DA")
            {
                vrijednost = true;

            }

            Console.WriteLine(vrijednost);

            Console.WriteLine(E12Metode.UcitajBool("Da li si zaposlen/a? (upiši DA ili bilo što za ne) ","DA"));

            Console.WriteLine(E12Metode.UcitajBool("Jutros sam pojeo tri sendviča (Istina/Laž)","Istina"));

        }
    }
}