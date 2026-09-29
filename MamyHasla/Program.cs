// See https://aka.ms/new-console-template for more information


string[] maleLitery =
[
    "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w",
    "x", "y", "z"
];
string[] duzeLitery =
[
    "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W",
    "X", "Y", "Z"
];
string[] znakiDiakrytyczne = ["ą", "ć", "ę", "ł", "ń", "ó", "ś", "ż", "ź", "Ą", "Ć", "Ę", "Ł", "Ń", "Ó", "Ś", "Ż", "Ź"];
string[] cyfry = ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"];
string[] znakiSpecjalne = ["!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+"];


/*
 * nazwa funkcji: GenerujHaslo
   opis funkcji: tworzy losowe hasło składające się z 12 znaków złożone z małych liter, dużych liter, znaków diakrytycznych, cyfr oraz znaków specjalnych.
   parametry: brak
   zwracany typ i opis: funkcja zwraca zmienną ciągu znaków zawierającą gotowe losowe hasło
   pesel: 000000000
 */
string GenerujHaslo()
{
    List<string> haslo = [];
    
    var random = new Random();
    for (int i = 0; i < 3; i++)
    {
        var index = random.Next(0, maleLitery.Length);
        var losowaLiterka = maleLitery[index];
        haslo.Add(losowaLiterka);
    }
    for (int i = 0; i < 3; i++)
    {
        var index = random.Next(0, duzeLitery.Length);
        var losowaLiterka = duzeLitery[index];
        haslo.Add(losowaLiterka);
    }
    for (int i = 0; i < 2; i++)
    {
        var index = random.Next(0, znakiDiakrytyczne.Length);
        var losowyZnak = znakiDiakrytyczne[index];
        haslo.Add(losowyZnak);
    }

    for (int i = 0; i < 2; i++)
    {
        var index = random.Next(0, cyfry.Length);
        var losowyZnak = cyfry[index];
        haslo.Add(losowyZnak);
    }
    for (int i = 0; i < 2; i++)
    {
        var index = random.Next(0, znakiSpecjalne.Length);
        var losowyZnak = znakiSpecjalne[index];
        haslo.Add(losowyZnak);
    }

    haslo.Shuffle();
    
    string gotoweHaslo = "";
    for (int i = 0; i < haslo.Count; i++)
    {
        gotoweHaslo += haslo[i];
    }

    return gotoweHaslo;
}

Console.WriteLine($"Losowe haslo 1: {GenerujHaslo()}");
Console.WriteLine($"Losowe haslo 2: {GenerujHaslo()}");
Console.WriteLine($"Losowe haslo 3: {GenerujHaslo()}");
Console.WriteLine($"Losowe haslo 4: {GenerujHaslo()}");
Console.WriteLine($"Losowe haslo 5: {GenerujHaslo()}");
