// Lleyton Eggins, 30128198
// Created 31/07/2025, Modified 07/08/2025
// AT1_Q2_UV_Index, V1.0
// Question 2. UV Index safety display
// take user input for UV index, display corresponding message of safety with colour determined by switch/case

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int UVIndex;
            Console.Write("Input a UV Index: ");
            bool succeed = int.TryParse(Console.ReadLine(), out UVIndex); // input is taken and parsed - bad data will give an error message
            if (succeed) // standard operation
            {
                switch(UVIndex)
                {
                    case 1: // fall through for each range
                    case 2:
                        Console.BackgroundColor = ConsoleColor.Green; // colour of the background, matching UV index
                        Console.ForegroundColor = ConsoleColor.White; // foreground colour to ensure readability
                        Console.WriteLine(" Low "); // display of risk level with colours applied. spaces exist to increase size of coloured area
                        Console.ResetColor(); // colours returend to normal after display
                        break;

                    case 3: // same protocol for other ranges
                    case 4:
                    case 5:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black; //black needed for readability
                        Console.WriteLine(" Moderate ");
                        Console.ResetColor();
                        break;

                    case 6:
                    case 7:
                        Console.BackgroundColor = ConsoleColor.DarkYellow; // in lieu of orange
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" High ");
                        Console.ResetColor();
                        break;

                    case 8:
                    case 9:
                    case 10:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" Very High ");
                        Console.ResetColor();
                        break;

                    case 11:
                    case 12:
                    case 13:
                        Console.BackgroundColor = ConsoleColor.Magenta; // largely matches a violet, as no exact option exists in ConsoleColor
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" Extreme ");
                        Console.ResetColor();
                        break;

                    default:
                        Console.WriteLine("Input is outside the of bounds of the UV Index"); // below 1 or above 13 the input does not fit the uv index provided
                        break;
                }
            }
            else // in case of bad data
            {
                Console.WriteLine("Invalid input type.");
            }
        }
    }
}
