// Rakendus palub kasutajal märkida oma sugu (m/f)
// Rakendus palub kasutajal sisestada oma perekonnanimi
// Lähtudes kasutajal valikust, rakendus tervitab kasutajat järgmiselt:
// "Welcome, Mr. [perekonnanimi]" / "Welcome, Ms. [perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");
char userGender = Char.Parse(Console.ReadLine()); // sisend loetakse sõnena ja muudetakse sümboliks

Console.WriteLine("Please enter your surname:");
string userSurname = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userSurname}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userSurname}!");
}
else
{
    Console.WriteLine($"Welcome, {userSurname}!");
}