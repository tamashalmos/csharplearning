using System.IO.IsolatedStorage;

string rocket = " /\\\n ||\n/||\\";


for (int i = 0; i < 15; i++)
    {
        Console.Clear();
        string rocketDescend = rocket.Insert(0, "\n");
        Console.WriteLine(rocketDescend);      
        rocket = rocketDescend;
        Thread.Sleep(100);
        Thread.Sleep(100);

    }

Console.WriteLine("Sikeres landolás!!!!");


Console.ReadKey();