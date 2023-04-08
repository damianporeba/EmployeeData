Console.WriteLine("Witaj w programie rejestracji pracownika!");
Console.WriteLine("Zostaniesz poproszony o podanie podstawowych danych o pracowniku...");
Console.WriteLine("Wpisz imię pracownika...");

string WorkerName = Console.ReadLine();

Console.WriteLine("Wpisz nazwisko pracownika...");
string WorkerSurname = Console.ReadLine();

Console.WriteLine("Podaj wiek pracownika w latach...");
string WorkerAge = Console.ReadLine();

int WorkerAgeNumber = 0;

Int32.TryParse(WorkerAge, out WorkerAgeNumber);

Console.WriteLine("Podaj płeć pracownika w formię: \r\n M = Mężczyzna \r\n K = Kobieta");
string WorkerSex = Console.ReadLine();

Console.WriteLine("Podaj numer PESEL pracownika...");
string WorkerPesel = Console.ReadLine();

Int64 WorkerPeselNumber = 0;
Int64.TryParse (WorkerPesel, out WorkerPeselNumber);

Console.WriteLine("Podaj numer pracownika przypisany do legitymacji (5 cyfr) ...");
string WorkerID = Console.ReadLine();

int WorkerIDNumber = 0;
Int32.TryParse(WorkerID, out WorkerIDNumber);

Console.WriteLine("Dziękuję za podanie danych, oto podsumowanie");
Console.WriteLine("Imię:" + WorkerName);
Console.WriteLine("Nazwisko:" + WorkerSurname);
Console.WriteLine("Wiek:" + WorkerAgeNumber);
Console.WriteLine("Płeć:" + WorkerSex);
Console.WriteLine("PESEL:" + WorkerPeselNumber);
Console.WriteLine("Numer pracownika:" + WorkerIDNumber);

