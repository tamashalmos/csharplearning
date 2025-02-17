using System.IO.IsolatedStorage;

namespace WeatherSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //usertől kérünk egy imputot,hogy hány napot akar szimulálni
            //a hőfok random szám -10 és 40 között

            Console.WriteLine("Enter the number of days to simulate");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Cloudy", "Rainy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++) {

                temperature[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
                Console.WriteLine($"{weatherConditions[i]} {temperature[i]}");

            }
            double avarageTemp = avarageTemperatureCalculator(temperature);
            Console.WriteLine($"The avarage of the temperatures is {avarageTemperatureCalculator(temperature)}");
            Console.ReadKey();






        }
        static double avarageTemperatureCalculator(int[] temperature) {
            double sum = 0;
            foreach (int i in temperature)
            {
                sum += i;
            }
            double avarage = sum / temperature.Length;

            return avarage;
        }
    }
}
