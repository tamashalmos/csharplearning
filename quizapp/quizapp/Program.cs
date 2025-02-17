

using System.Diagnostics;

string question1 = "Mi németország fővárosa?";
string answer1 = "Berlin";
string question2 = "Mi magyarország fővárosa?";
string answer2 = "Budapest";
string question3 = "Melyik szín az RGB-ból az \"R\"";
string answer3 = "Red";
int points = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();
if (answer1.Trim().ToLower() == userAnswer1.ToLower())
{
    Console.WriteLine("Helyes megoldás");
    points++;
}
else
    Console.WriteLine($"Nem helyes. A helyes megoldás {answer1}");

Console.WriteLine(question2);

string userAnswer2 = Console.ReadLine();
if (answer2.Trim().ToLower() == userAnswer2.ToLower())
{
    Console.WriteLine("Helyes megoldás");
    points++;
}
else
    Console.WriteLine($"Nem helyes. A helyes megoldás {answer2}");

Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();
if (answer3.Trim().ToLower() == userAnswer3.ToLower())
{
    Console.WriteLine("Helyes megoldás");
    points++;
}
else
    Console.WriteLine($"Nem helyes. A helyes megoldás {answer3}");

Console.WriteLine($"A pontjaid 3/{points}");

if (points == 3)
    Console.WriteLine("Gratulálok,hibátlan");
else if (points > 0)
    Console.WriteLine("Legalább nem 0");
else
    Console.WriteLine("NULAAAA");













Console.ReadKey();