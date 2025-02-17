using System.Reflection.Metadata;

double szam1 = 0;
double szam2 = 0;

Console.WriteLine("Írj be egy számot:");
szam1 = double.Parse(Console.ReadLine());

Console.WriteLine("Írj be egy másik számot:");
szam2 = double.Parse(Console.ReadLine());

 double osszeg = szam1 + szam2;

Console.WriteLine($"A két szám összege {osszeg}");
Console.ReadKey();


