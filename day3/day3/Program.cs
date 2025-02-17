
// Klub ha 18+ mehet, 16 felett csak szülövel azalatt nem
/*

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

Console.WriteLine("Hány éves vagy?");
int age = int.Parse(Console.ReadLine());

if (age >= 18)
    Console.WriteLine("Beléphetsz");
else if (age >= 16)
{
    Console.WriteLine("Szülővel érkeztél? y ha igen n ha nem");
    string szulovelErkezett = Console.ReadLine();
    if (szulovelErkezett == "y")
        Console.WriteLine("Beléphetsz a szüleiddel");
    else
        Console.WriteLine("Nem léphetsz be szülők nélkül");
}
else
    Console.WriteLine("Semmiképp sem léphetsz be,16 évnél fiatalabb vagy");






    Console.ReadKey();
*/


int day = 2;

            // TODO: Rewrite this if-else structure using a switch statement.
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    default:
        Console.WriteLine("Another day");
        break;
        }
Console.ReadKey();
