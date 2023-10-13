using System;

/*
===============================================================================
PROJECT 21: WHILE LOOPS
===============================================================================
Objective:
- Understand and practice using while loops for repeated tasks.

Example:
- Here is an example while loop:

    int count = 1;
    while(count < 11)
    {
        Console.WriteLine(count);
        count++;
    }

Main Tasks:
1. Correct the condition in the provided while loop so that the user can only proceed with a number less than 100.
2. Implement a while loop that requires the user to enter a correct password before displaying a secret message.

Questions:
1. What is the shortcut for creating a WHILE loop?
2. When would you use a WHILE loop?

Extension Tasks:
1. Extend the first task by also ensuring that the number is also greater than 1.
2. Try re-creating Fizz Buzz using a WHILE loop.

Additional Resources:
- While Loops in C#: https://www.tutorialspoint.com/csharp/csharp_while_loop.htm
- While Statement: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_21_WhileLoops
    {
        static void Main(string[] args)
        {
            WaitBetween("Loop to ensure number is less than 100: ");

            // 1. Fix the condition of the WHILE loop so that the program works
            Console.WriteLine("Please enter a number less than 100 to continue...");
            int number = int.Parse(Console.ReadLine());
            while (????)
            {
                Console.WriteLine("Incorrect input, try again...");
                number = int.Parse(Console.ReadLine());
            }

            WaitBetween("WHILE loop to password protect a secret message: ");

            // 2. Write a WHILE loop to ensure the user enters a correct password of your choosing
            // Then, under the loop, output a message of your choice



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