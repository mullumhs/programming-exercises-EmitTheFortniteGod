using System;

/*
===============================================================================
PROJECT 25: GUESS MY NUMBER
===============================================================================
Objective:
- Understand and practice implementing loops and conditional statements to create a number guessing game.

Main Tasks:
1. Implement a loop that continues as long as the user's guess is incorrect.
2. Within the loop, prompt the user to enter a guess.
3. Use conditional statements to provide feedback to the user about whether their guess is too high, too low, or correct.

Example Output:
- This is how your program should behave:
    Guess the number (between 1 and 100): 50
    Too low! Try again.
    Guess the number (between 1 and 100): 75
    Too high! Try again.
    Guess the number (between 1 and 100): 62
    Correct! Well done.

Extension Tasks:
1. Prompt the user to enter the range for the random number, e.g., 1 to 1000 instead of 1 to 100.
2. Keep a count of how many tries it takes the user to guess correctly, and display this at the end.
3. Enclose the entire game within a loop, so the user can choose to play again without restarting the program.

===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_25_GuessMyNumber
    {
        static void Main(string[] args)
        {
            // Generate Random Number within the specified range
            int randomNumber = GenerateRandomNumber(1, 100);

            // Set guess to number out of random range
            int guess = -1;

            // Write your code here



            // Wait at end
            WaitForKeyPress();
        }

        static int GenerateRandomNumber(int min, int max)
        {
            Random rnd = new System.Random();
            return rnd.Next(min, max + 1);
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
