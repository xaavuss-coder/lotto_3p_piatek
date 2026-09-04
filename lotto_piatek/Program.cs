Console.WriteLine("Wylosowanie Liczby");
// wylosuj liczbe w zakrseise od 1 do 99

Random random = new Random();

int liczba = random.Next(1, 100);

Console.WriteLine("Wyloswana liczba: " + liczba);