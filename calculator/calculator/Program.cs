Console.WriteLine("Enter the first number:");
string elsoString = Console.ReadLine();
Console.WriteLine("Enter the second number:");
string masodikString = Console.ReadLine();
int elsoSzam = 0;
int masodikSzam = 0;

Console.WriteLine("Choose an operation: +, -, *, /");
string muvelet = Console.ReadLine();

bool ellenorzes1 = int.TryParse(elsoString, out elsoSzam);
bool ellenorzes2 = int.TryParse(masodikString, out masodikSzam);

if (ellenorzes1 == true && ellenorzes2 == true && masodikSzam != 0)
{

    if (muvelet == "+")
        Console.WriteLine("Result: " + (elsoSzam + masodikSzam));
    else if (muvelet == "-")
        Console.WriteLine("Result: " + (elsoSzam - masodikSzam));
    else if (muvelet == "*")
        Console.WriteLine("Result: " + elsoSzam * masodikSzam);
    else if (muvelet == "/")
        Console.WriteLine("Result: " + elsoSzam / masodikSzam);
    else
        Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
}
else if (ellenorzes1 == true && ellenorzes2 == true && masodikSzam == 0)
{
    Console.WriteLine("Error: Division by zero is not allowed.");
}
else
    Console.WriteLine("Nem egész számot írtál be");

Console.ReadKey();