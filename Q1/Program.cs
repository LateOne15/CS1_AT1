// Lleyton Eggins, 30128198
// Created 31/07/2025, Modified 07/08/2025
// AT1_Q1_Hydroelectric_Dam, V1.0
// Question 1. Hydroelectric dam flowrate monitoring to display warning/okay message
// take user input for flow, parse for int, check for bounds, throw error on invalid data

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flowRate;
            Console.Write("Input flow rate sensor value: ");
            bool succeed = int.TryParse(Console.ReadLine(), out flowRate);  // get user input, determine if user input is valid
            if (succeed) // standard operation
            {
                if (flowRate < 75) // underflow threshold
                {
                    Console.WriteLine("Warning: Flow Rate Low");
                }
                else if (flowRate > 120) // overflow threshold
                {
                    Console.WriteLine("Warning: Flow Rate High");
                }
                else // within standard bounds
                {
                    Console.WriteLine("Flow Rate OK");
                }
            }
            else // in the case of invalid data
            {
                Console.WriteLine("Invalid input type.");
            }
        }
    }
}
