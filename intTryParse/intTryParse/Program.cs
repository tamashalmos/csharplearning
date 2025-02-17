//Feladat:
//bekérni egy számot és ellenőrizni,hogy az e

Console.WriteLine("Írj be egy számot!");
string inputString = Console.ReadLine();
int num1 = 0;

Console.WriteLine(inputString);

bool inputSzam = int.TryParse(inputString, out num1);

if (inputSzam == true)
    System.Console.WriteLine($"A számod + 1 {++num1}");
else
    System.Console.WriteLine("Nem számot adtál meg");


Console.ReadKey();

