//Create a simple C# program that declares an array of integers,
//initializes it with values, and uses a foreach loop to print each value to the console.

int[] szamok = { 1, 2, 3, 4, 5 };

foreach (int szam in szamok)
    Console.WriteLine(szam);

Console.ReadKey();