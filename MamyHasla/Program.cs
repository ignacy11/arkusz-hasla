// See https://aka.ms/new-console-template for more information

// maleListrey[0]
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


string GenerujHaslo()
{
    string haslo = "";
    return haslo;
}


var random = new Random();
for (int i = 0; i < 3; i++)
{
    var index = random.Next(0, maleLitery.Length);
    var losowaLiterka = maleLitery[index];
    haslo += losowaLiterka;
}
for (int i = 0; i < 3; i++)
{
    var index = random.Next(0, duzeLitery.Length);
    var losowaLiterka = duzeLitery[index];
    haslo += losowaLiterka;
}
for (int i = 0; i < 2; i++)
{
    var index = random.Next(0, znakiDiakrytyczne.Length);
    var losowyZnak = znakiDiakrytyczne[index];
    haslo += losowyZnak;
}

for (int i = 0; i < 2; i++)
{
    var index = random.Next(0, cyfry.Length);
    var losowyZnak = cyfry[index];
    haslo += losowyZnak;
}
for (int i = 0; i < 2; i++)
{
    var index = random.Next(0, znakiSpecjalne.Length);
    var losowyZnak = znakiSpecjalne[index];
    haslo += losowyZnak;
}

Console.WriteLine($" jedna losowa mała literka {haslo }");

