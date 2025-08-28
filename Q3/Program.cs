// Lleyton Eggins, 30128198
// 31/07/2025, 14/08/2025
// AT1_Q3_CITE_FAQ, V1.0
// Question 3. CITE FAQ knowledge base menu
// take user input for a menu option on FAQ items, display requested item, then return 
// to the menu unless the program is exited with an input of 7

using System;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Channels;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            bool success;
            do
            {
                // block of explanatory text
                Console.WriteLine("\nPlease choose an item to display from one of the following options:");
                Console.WriteLine("1 - Syntax Definition");
                Console.WriteLine("2 - Syntax Rules");
                Console.WriteLine("3 - Small Scale App Dev Definition");
                Console.WriteLine("4 - Document Deisgn Definition");
                Console.WriteLine("5 - Coding Techniques Definition");
                Console.WriteLine("6 - Coding Standards Definition");
                Console.WriteLine("7 - Quit Program\n");

                Console.Write("Your choice: ");
                success = int.TryParse(Console.ReadLine(), out option); // input and parsing, with error handler
                if (success)
                {
                    switch(option) // switch between the options
                    {
                        case 1:
                            Console.WriteLine("Syntax Definition:");
                            Console.WriteLine("Syntax is the rules of coding that are mandatory to be followed in " +
                                "order for a\nprogram to run. They vary between languages, but are always consistent" +
                                " within a\nlanguage, and govern how structure and formatting must be done for key " +
                                "features such as\nstructures, line endings, loops, and variable declarations.");
                            break;

                        case 2:
                            Console.WriteLine("Syntax Rules - C#:");
                            Console.WriteLine("C# is a strongly-typed language, meaning every variable declaration " +
                                "must include\nthe datatype of that variable. Structures, including loops, if " +
                                "statements, and classes,\nmust be contained within braces after their name and/or " +
                                "conditions. All line endings\nmust use semicolons, with the only exceptions being " +
                                "those lines that exclusively contain\nthe braces of a structure.");
                            break;

                        case 3:
                            Console.WriteLine("Small Scale App Development Definition:");
                            Console.WriteLine("A development style that focuses on small scale and lightweight " +
                                "applications for specific audiences\nor use cases. This is more affordable and " +
                                "quicker than building large and complex systems, focuses on\ncore features or " +
                                "requirements, and is easier to prototype and modify during development. Small scale" +
                                "\napplications can be scaled up to a larger user base, but this is not a " +
                                "requirement.\n(source: " +
                                "https://addictaco.com/small-scale-web-app-development-a-comprehensive-guide/ )");
                            break;

                        case 4:
                            Console.WriteLine("Document Design Definition:");
                            Console.WriteLine("The practice of designing a program through documentation known as " +
                                "design documentation. This\nserves to write out a plan of the project, identify its" +
                                " requirements and features, consider its end\nusers, and determine the measure of " +
                                "the project's success. To this end, the majority of the program\nwill be designed " +
                                "in this phase, but the implemention and testing is left for later stages.");
                            break;

                        case 5:
                            Console.WriteLine("Coding Techniques Definition:");
                            Console.WriteLine("These are techniques by which to improve or implement code in " +
                                "programs for a desired result.\nTechniques will go beyond the most basic syntax and" +
                                " attempt to create code that is either more\nreadable, more effecient, or in some " +
                                "other way desirable to a different approach. However, some\ntechniques are " +
                                "considered to be outside of best practices, and others will not adhere to coding\n" +
                                "standards within an organistion or project, so care must be taken to keep code " +
                                "usable in its environment.");
                            break;

                        case 6:
                            Console.WriteLine("Coding Standards Definition:");
                            Console.WriteLine("Standards in coding are a set of rules for a group of developers to " +
                                "follow. Unlike coding\nsyntax, these are not necessary to ensure running code, but " +
                                "they are employed to create consistency\nand readability between the work of " +
                                "different people, improving collaboration and maintenace. These\nstandards may vary" +
                                " by organisation, or even project, and can include guidelines for:\n" +
                                "   Testing, security, version control, commenting, formatting, naming conventions,\n"+
                                "   documentation, error handling, code reviews, and more.");
                             break;

                        case 7:
                            Console.WriteLine("Quitting program...");
                            break;

                        default:
                            Console.WriteLine("That option is not valid. Please make a different choice.");
                            break;
                    }
                }
                else // in case of bad data
                {
                    Console.WriteLine("That is not an accepted datatype. Please ensure an integer.");
                }
            } while (option != 7); //will exit program when 7 is entered
        }
    }
}
