using System.ComponentModel;
using System.Runtime.InteropServices;

namespace csharp_weather_app;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the amont of days you want to simulate"); //user intputs 7
        int days = int.Parse(Console.ReadLine()); //so now days is is what the user input withch is 7 

        int[] temperature = new int[days]; //creating a memory slot with 7 spaces called temperature 
        string[] conditions = {"sunny", "rainy", "windy", "snowing", "icy"}; // an array with diffrent weather conditions
        string[] weatherConditions = new string[days]; // crating a array called weatehr conditions which will eqaual new string[7] spaces of memory but is it now called new string?????

    Random random = new Random(); // random number method? is it called a method?

    for (int i = 0; i < days; i++) //itterating through a the 7 days 
    {
        temperature[i] = random.Next(-10, 39);   //chooseing a temperature between -10 and 38 
            weatherConditions[i] = conditions[random.Next(conditions.Length)]; // so there is 7 spaces from before and it wil put rantdom weatehr conditions inside it 
Console.WriteLine("\nWeather Forecast:\n");

for (int i = 0; i < days; i++)
{
    Console.WriteLine($"Day {i + 1}: {weatherConditions[i]}, {temperature[i]}°C");
}
    }
    }
}
