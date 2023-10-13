using System;

/*
===============================================================================
PROJECT 19: FOR LOOPS 2
===============================================================================
Objective:
- Understand and practice using for loops with conditional statements.

Example:
- Below are examples to guide you through the expected behavior of the program:

    Example 1:
    for (int num = 1; num < 11; num++)
    {
        if(num == 7) 
        {
            Console.WriteLine("Found 7");
        }
    }
    Output:
    Found 7

    Example 2:
    for (int counter = 0; counter < 100; counter++)
    {
        if(counter % 3 == 0)
        { 
            Console.WriteLine(counter);
        }
    }
    Output:
    0
    3
    6
    ... and so on

Main Tasks:
1. Create a FOR loop that goes from 0 to 99 by steps of 1. Inside the loop, print a message only if the number equals 42.
2. Create a FOR loop that goes from 100 to 199 by steps of 3. Inside the loop, print a message only if the number is divisible by 2.

Questions:
1. What is the shortcut for creating a FOR loop?
2. What does the modulus (%) operator do?

Extension Tasks:
1. Try using multiple 'else if' and 'else' statements to expand the functionality of each loop.

Additional Resources:
- Modulus operator: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#remainder-operator-
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_19_ForLoops2
    {
        static void Main(string[] args)
        {
            WaitBetween("Loop to find the number 42:");



            WaitBetween("Loop to find numbers divisible by 2:");



            // Wait at end
            WaitAtEnd();
        }

        private static void WaitAtEnd()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void WaitBetween(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
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