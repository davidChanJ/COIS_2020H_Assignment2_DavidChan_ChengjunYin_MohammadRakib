////public class Program
////{
////    public static void Main()
////    {

////    }
////}

//using System;
//using System.Collections.Generic;


////2nd
//class Program
//{
//    public static void Main()
//    {
//        // Input Parameters
//        double M = geInPut("Enter the mean for inter-arrival time (M): ");

//        // Simulation Parameters
//        int numOfSimulations = 1000;

//        // Run Simulation
//        double total = 0;
//        Random random = new Random();

//        for (int i = 0; i < numOfSimulations; i++)
//        {
//            double u = random.NextDouble();
//            double randomValue = -M * Math.Log(u);
//            total += randomValue;
//        }

//        // Calculate Average
//        double average = total / numOfSimulations;

//        // Display Results
//        Console.WriteLine("Mean of {0} random numbers drawn from exponential distribution with mean {1}: {2}", numOfSimulations, M, average);

//        // M and N are random integers
//        // Define the range [M, N)
//        int M2 = 5; // Lower bound (inclusive)
//        int N = 15; // Upper bound (exclusive)

//        // Create a Random object
//        Random r2 = new Random();

//        // Generate a uniformly distributed random integer r where M ≤ r < N
//        int randomInteger = r2.Next(M2, N);

//        // Display the result
//        Console.WriteLine($"Random integer between {M} (inclusive) and {N} (exclusive): {randomInteger}");

//    }

//    static double geInPut(string prompt)
//    {
//        Console.Write(prompt);
//        return Convert.ToDouble(Console.ReadLine());
//    }
//}

////class Program
////{
////    static void Main()
////    {
////        // M and N are random integers
////        // Define the range [M, N)
////        int M = 5; // Lower bound (inclusive)
////        int N = 15; // Upper bound (exclusive)

////        // Create a Random object
////        Random random = new Random();

////        // Generate a uniformly distributed random integer r where M ≤ r < N
////        int randomInteger = random.Next(M, N);

////        // Display the result
////        Console.WriteLine($"Random integer between {M} (inclusive) and {N} (exclusive): {randomInteger}");
////    }
////}

