Console.WriteLine("Wylosowanie Liczby");
// wylosuj liczbe w zakrseise od 1 do 99

Random random = new Random();

int liczba = random.Next(1, 100);

// Console.WriteLine("Wyloswana liczba: " + liczba);

Console.WriteLine("Zgadnij wylosowaną liczbę");

Console.WriteLine("Podaj LIczbę z zakresu 1 do 100");
int zgadywana = int.Parse(Console.ReadLine());

if (zgadywana == liczba)
{
    Console.WriteLine("Zgadnięto");
}
else
{
    Console.WriteLine("Może innym razem");
}