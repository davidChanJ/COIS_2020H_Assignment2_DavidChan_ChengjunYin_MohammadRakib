//public class Program
//{
//    public static void Main()
//    {

//    }
//}

using System;
using System.Collections.Generic;


//2nd
class Program
{
    public static void Main()
    {
        // Input Parameters
        double M = GetInput("Enter the mean for inter-arrival time (M): ");

        // Simulation Parameters
        int numofSimulations = 1000;

        // Run Simulation
        double total = 0;
        Random random = new Random();

        for (int i = 0; i < numofSimulations; i++)
        {
            double u = random.NextDouble();
            double randomValue = -M * Math.Log(u);
            total += randomValue;
        }

        // Calculate Average
        double average = total / numofSimulations;

        // Display Results
        Console.WriteLine($"Mean of {numofSimulations} random numbers drawn from exponential distribution with mean {M}: {average}");

        // M and N are random integers
        // Define the range [M, N)
        int M2 = 5; // Lower bound (inclusive)
        int N = 15; // Upper bound (exclusive)

        // Create a Random object
        Random r2 = new Random();

        // Generate a uniformly distributed random integer r where M ≤ r < N
        int randomInteger = r2.Next(M2, N);

        // Display the result
        Console.WriteLine($"Random integer between {M} (inclusive) and {N} (exclusive): {randomInteger}");

    }

    static double GetInput(string prompt)
    {
        Console.Write(prompt);
        return Convert.ToDouble(Console.ReadLine());
    }
}
