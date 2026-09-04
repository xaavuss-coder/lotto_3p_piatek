Console.WriteLine("Wylosowanie Liczby");
// wylosuj liczbe w zakrseise od 1 do 99

Random random = new Random();

int liczba = random.Next(1, 100);

// Console.WriteLine("Wyloswana liczba: " + liczba);

Console.WriteLine("Zgadnij wylosowaną liczbę");

Console.WriteLine("Podaj Liczbę z zakresu 1 do 100");

for (int i = 0; i < 10; i++) {
    int zgadywana = int.Parse(Console.ReadLine());

    if (zgadywana == liczba)
    {
        Console.WriteLine("Zgadnięto");
        break;
    }
    if (zgadywana < liczba)
    {
        Console.WriteLine("Za mało!");
    }
    else
    {
        Console.WriteLine("Za dużo!");
    }
}

