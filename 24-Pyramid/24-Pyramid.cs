using System;

/*
===============================================================================
PROJECT 24: PYRAMID
===============================================================================
Objective:
- Understand and practice creating nested loops to print pyramid patterns.

Main Tasks:
1. Implement an outer loop that will run 'height' times, each time representing a new line in the pyramid.
2. Implement an inner loop for printing spaces before the stars in each line to center-align the pyramid.
3. Implement another inner loop for printing stars in each line.

Easier Task:
- A pyramid of height 5 will result in this:
    *
   **
  ***
 ****
*****

Harder Task:
- See if you can you figure out how to get both sides:
     **
    ****
   ******
  ********
 **********

Extension Tasks:
1. Print a diamond shape instead of a pyramid.
2. Create a method that takes the height and the character to print (instead of stars).

Questions:
1. Can you explain in your own words how nested loops work?
2. What is the purpose of the documentation above GetNumber()?
3. Can you explain how the GetNumber() method works?

===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_24_Pyramid
    {
        static void Main(string[] args)
        {
            // Get the height
            int height = GetNumber("Enter a height for the pyramid", 0, 20);

            // Write your code here



            // Wait at end
            WaitForKeyPress();
        }

        /// <summary>
        /// Prompts the user for a number within a specified range until a valid number is entered.
        /// </summary>
        /// <param name="message">The prompt message to display.</param>
        /// <param name="minValue">The minimum allowable value.</param>
        /// <param name="maxValue">The maximum allowable value.</param>
        /// <returns>The validated number entered by the user.</returns>
        static int GetNumber(string message, int minValue, int maxValue)
        {
            int number;
            while (true)
            {
                Console.WriteLine($"{message} between {minValue} and {maxValue}:");
                bool success = int.TryParse(Console.ReadLine(), out number);
                if (success && number >= minValue && number <= maxValue)
                {
                    return number;
                }
                Console.WriteLine($"Please enter a number between {minValue} and {maxValue}.");
            }            
        }

        private static void WaitForKeyPress()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/