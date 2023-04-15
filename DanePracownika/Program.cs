using System;

namespace addressbook
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Witaj w programie rejestracji pracownika!");
            Console.WriteLine("Zostaniesz poproszony o podanie podstawowych danych o pracowniku...");
            Console.WriteLine("Wpisz imię pracownika...");

            string workerName = Console.ReadLine();

            Console.WriteLine("Wpisz nazwisko pracownika...");
            string workerSurname = Console.ReadLine();

            Console.WriteLine("Podaj wiek pracownika w latach...");
            string workerAge = Console.ReadLine();

            int workerAgeNumber = 0;

            Int32.TryParse(workerAge, out workerAgeNumber);

            Console.WriteLine("Podaj płeć pracownika w formię: \r\n M = Mężczyzna \r\n K = Kobieta");
            string workerSex = Console.ReadLine();

            if (workerSex.Length > 1)
            {
                Console.WriteLine("Podaj 1 literę");
                workerSex = Console.ReadLine();

                while (workerSex.Length > 1)
                {
                    Console.WriteLine("Podaj 1 literę");
                    workerSex = Console.ReadLine();
                }
            }
            Console.WriteLine("Podaj numer PESEL pracownika...");
            string workerPesel = Console.ReadLine();

            Console.WriteLine("Podaj numer pracownika przypisany do legitymacji (5 cyfr) ...");
            string workerID = Console.ReadLine();


            Console.WriteLine("");
            Console.WriteLine("Dziękuję za podanie danych, oto podsumowanie");
            Console.WriteLine("Imię:" + workerName);
            Console.WriteLine("Nazwisko:" + workerSurname);
            Console.WriteLine("Wiek:" + workerAgeNumber);
            Console.WriteLine("Płeć:" + workerSex);
            Console.WriteLine("PESEL:" + workerPesel);
            Console.WriteLine("Numer pracownika:" + workerID);

        }
    }
}
