using System;
using System.Runtime.Remoting;

/*
===============================================================================
PROJECT 16: DISTANCE CONVERSION
===============================================================================
Objective:
- Understand and practice creating functions with return values and parameters.

Example Output:
- This is how your program should behave:

    What would you like to do?
    1. Kilometres to Miles
    2. Miles to Kilometres
    1
    Enter distance (in Km) to convert: 100
    That is 62.5 miles

Main Tasks:
1. Write a function named "ConvertKmToMiles" to convert kilometers to miles.
2. Write a function named "ConvertMilesToKm" to convert miles to kilometers.
3. In the Main method, implement an if...else if...else statement based on the user's choice:
   - If choice is "1", call "GetDistance" with "Km" as the argument, then call "ConvertKmToMiles" with the returned value, and output the result.
   - If choice is "2", call "GetDistance" with "Miles" as the argument, then call "ConvertMilesToKm" with the returned value, and output the result.
   - Else, call the "ErrorMessage" method with "Invalid Choice!" as the argument.

Questions:
1. Explain in detail what this line of code does:  string choice = MainMenu();
2. How does the "GetDistance" function work? What does it return? Why does it need a parameter?

Extension Tasks:
1. Try adding options for 'centimetres to inches' and 'inches to centimetres'.
2. (Harder) Research how to round the output to 2 decimal places.
3. (Harder) Research how to implement error handling for invalid user input in the "GetDistance" function.

Additional Resources:
- Functions in C#: https://www.tutorialspoint.com/csharp/csharp_methods.htm
- Methods: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_16_DistanceConversion
    {
        static void Main(string[] args)
        {
            // Runs the menu and stores the choice
            


            // Write your code here

            MainMenu();


            // Wait for key press before exiting
            WaitForKeyPress();
        }

        // Create your functions here



        // Asks the user to enter a distance in the unit specified
        private static double GetDistance(string unit)
        {
            Console.Write($"Enter distance (in {unit}) to convert: ");
            double distance = int.Parse(Console.ReadLine());
            return distance;
        }

        


        // Shows the menu options to the user
        private static void MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Kilometres to Miles");
            Console.WriteLine("2. Miles to Kilometres");
            string choice = Console.ReadLine();
            




            if(choice == "1")
            {
                Console.Write("How many kilometres? ");
                double km = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{km} kilometers to miles = {km * 0.621371}");
            }

            else if(choice == "2")
            {
                Console.Write("How many miles? ");
                double miles = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{miles} miles to kilometers = {miles * 1.60934}");
            }

        }

        // Waits for the user to press any key
        private static void WaitForKeyPress()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        // Displays an error message in red text
        private static void ErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/
