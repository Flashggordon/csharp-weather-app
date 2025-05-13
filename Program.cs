//         Console.WriteLine("Enter the amont of days you want to simulate"); //user intputs 7
//         int days = int.Parse(Console.ReadLine()); //so now days is is what the user input withch is 7 

//         int[] temperature = new int[days]; //creating a memory slot with 7 spaces called temperature 
//         string[] conditions = {"sunny", "rainy", "windy", "snowing", "icy"}; // an array with diffrent weather conditions
//         string[] weatherConditions = new string[days]; // crating a array called weatehr conditions which will eqaual new string[7] 

//     Random random = new Random(); // random number method? is it called a method?

//     for (int i = 0; i < days; i++) //itterating through a the 7 days 
//     {
//         temperature[i] = random.Next(-10, 39);   //chooseing a temperature between -10 and 38 
//             weatherConditions[i] = conditions[random.Next(conditions.Length)]; // so there is 7 spaces from before and it wil put rantdom weatehr conditions inside it 
//     }

//     Console.WriteLine("\nWeather Forecast:\n");

// for (int i = 0; i < days; i++)
// {
//     Console.WriteLine($"Day {i + 1}: {weatherConditions[i]}, {temperature[i]}°C");
// }
//     }



using System.ComponentModel;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;

namespace csharp_weather_app;

class Program
{
    static void Main(string[] args)
    {

double addTemp = 0; 
double CalculateAverage = 0; 
// Create a simple C# program that calculates the average temperature from an array of temperatures. The program should:
 double[] tempratureRange = {10, 20, 30, 40, 50};

// Declare a method CalculateAverage that takes an array of doubles as a parameter. 
for (int i = 0; i < tempratureRange.Length; i++)
{
// Implement the method to calculate the average of the temperatures in the array.
   addTemp += tempratureRange[i]; 
}
// Declare a method PrintAverage that takes an array of doubles as a parameter.
CalculateAverage = addTemp / tempratureRange; 

// Implement the method to call CalculateAverage and print the result to the console.
System.Console.WriteLine($"The average temperature is: {CalculateAverage}");
// Alert!

// The result of execution for the default string should be:

// "The average temperature is: 23.5"

}
}
